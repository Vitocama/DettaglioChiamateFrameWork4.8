USE [kongNew]
GO
/****** Object:  StoredProcedure [dbo].[sp_creazioneTabellaUfficio]    Script Date: 29/05/2024 18:56:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER     procedure [dbo].[sp_creazioneTabellaUfficio]
@anno int 
as begin


delete from VoiPsommaImportoChiamate;

delete from VoiPUFFICIO


delete from VoiPTabellaSpesasomma


delete from VoiPtmptabella




/* Crea la tabella VoiPsommaImportoChiamate che serve per sommare gli importi di ogni chiamata raggruppate per contratto*/
/*
create table VoiPsommaImportoChiamate(
idcliente varchar(256),
voip varchar(256),
portabilita varchar(256),
CF varchar(256),
CodCli varchar(256),
datadisdetta varchar(256),
spese float
)

*/

/* riempie la tabella creata precedentemente */

insert into VoiPsommaImportoChiamate(idcliente,voip,portabilita,cf,codcli,datadisdetta,spese)
select voipcontratti.idContratto,voip,portabilita,CF,voipContratti.CodCli,voipcontratti.datadisdetta,sum(importo)as spese
from Clienti join voipContratti on Clienti.CodCli=voipContratti.CodCli
join voipdettaglio on (voipcontratti.portabilita=voipdettaglio.chiamante or voipcontratti.voip=voipdettaglio.chiamante )
where year(voipdettaglio.data)=@anno and ((year(voipcontratti.datadisdetta)=1900 or year(voipcontratti.datadisdetta)=@anno) and year(datainizio)<=@anno)
group by voipcontratti.idContratto,voip,portabilita,CF,voipContratti.CodCli,voipcontratti.datadisdetta






/* seleziona tutti i campi che saranno utili per riempire la tabella VoipUfficio */

SELECT 
    clienti.CF,
    clienti.PIva,
    left(clienti.Cognome,24)as cognome,
    left(clienti.nome,20) as nome,
    left(clienti.Sesso,1)as sesso,
    left(FORMAT(clienti.DtNascita, 'ddMMyyyy'),8 )AS DtNascita,
    left(clienti.LuogoNascita,40) as luogodinascita,
	left(clienti.ProvNascita,2) as prov,
    left(clienti.Denom,60) as denominazione,
	left(clienti.loc,40) as ComuneDomicilio,
	left(clienti.Prov,2 )as SiglaComuneDomicilio,
    voipcontratti.idContratto,
    voipcontratti.CodCli,
	FORMAT(voipcontratti.datainizio, 'ddMMyyyy') AS datainizio,
    voipcontratti.portabilita as NumeroIniziale,
	voipcontratti.voip as NumeroFinale,
    left(clienti.Ind,40 )as indirizzo,
    FORMAT(voipcontratti.datadisdetta, 'ddMMyyyy') AS datadisdetta,
	VoiPsommaImportoChiamate.spese as costi
	into VoiPtmptabella
FROM 
    voipcontratti 
JOIN 
clienti ON voipcontratti.CodCli = clienti.CodCli join VoiPsommaImportoChiamate on voipcontratti.idContratto=VoiPsommaImportoChiamate.idcliente

	

	/* arrontonda i costi minori di 0.5 € secondo le specifiche dell'agenzia */

	UPDATE VoiPtmptabella
SET costi = 
    CASE 
        WHEN costi - FLOOR(costi) < 0.5 THEN FLOOR(costi)
        ELSE CEILING(costi)
    END;



	/* riempie parzialmente la tabella VoipUfficio */

INSERT INTO VoiPUFFICIO (
    cf,
    cognome,
    nome,
    sesso,
    dtnascita,
    luogonascita,
    prov,
    denominazione,
    ComuneDomicilio,
	datainizio,
    indirizzo,
	AMMONTAREFATTURATO
	
)
SELECT
    CASE
        WHEN piva IS NOT NULL THEN piva
        ELSE cf
    END AS cf,
    cognome,
    nome,
    sesso,
    dtnascita,
    luogodinascita AS luogonascita, 
    prov,
    denominazione,
    ComuneDomicilio,
	datainizio,
    indirizzo,
	RIGHT('              '+costi,9)
FROM
    VoiPtmptabella


	/* fine riempimento */



	/*  aggiorna la colonna SIGLACOMUNEDOMICILIO prendendo i dati dalla tabella dei Comuni */

UPDATE VoiPUFFICIO
SET VoiPUFFICIO.SIGLACOMUNEDOMICILIO = Comuni.Provincia
FROM VoiPUFFICIO
 JOIN Comuni ON VoiPUFFICIO.COMUNEDOMICILIO = Comuni.Comune







 /* inserisce il carattere di controllo alla fine della tabella */

 update VoiPUFFICIO
 set CARATTEREFINERIGA='crlf',CARATTEREDICONTROLLO='a'


 /* aggiunge gli spazi mancanti */

 update VoiPUFFICIO
 set filler=replicate(' ',1456)



 /* inserisce in CF la partita se presente */

update VoiPUFFICIO
set VoiPUFFICIO.CF=VoiPtmptabella.PIva
from VoiPUFFICIO join VoiPtmptabella on VoiPUFFICIO.cf=VoiPtmptabella.CF
where piva is not null




/* inserisce la provincia di nascita e se straniero inserisce EE */
UPDATE VoiPUFFICIO
SET PROV= CASE WHEN SUBSTRING(VoiPUFFICIO.cf,12,1)='Z' then 'EE' else prov end 


/* valore fisso sempre 2 per tipocontratto */
update VoiPUFFICIO
set TIPOCONTRATTO=2



/* inserisce il codice comune di residenza */
UPDATE VoiPUFFICIO
SET VoiPUFFICIO.CODICECOMUNE = Comuni.CodiceComune
FROM VoiPUFFICIO
  JOIN Comuni ON VoiPUFFICIO.COMUNEDOMICILIO = Comuni.Comune


  /* inserisce i mesi di fatturazione in base alla data disdetta */


update VoiPUFFICIO

 set MESIFATTURAZIONE=CASE 
        WHEN RIGHT(datadisdetta, 4) = @anno THEN
            
			
			CASE 

                WHEN SUBSTRING(datadisdetta, 3, 2) <= 12 THEN 
				
				 CAST( SUBSTRING(datadisdetta, 3, 2) AS varchar(2))

                ELSE 12
            END
        ELSE 12
    END 
from VoiPUFFICIO join VoiPtmptabella on VoiPUFFICIO.cf=VoiPtmptabella.CF or VoiPUFFICIO.cf=VoiPtmptabella.PIva




update VoiPUFFICIO

SET MESIFATTURAZIONE=CASE 
	WHEN LEN(MESIFATTURAZIONE) =2 THEN  MESIFATTURAZIONE
	ELSE  ' ' + MESIFATTURAZIONE

END




	/* la provincia va inserita solo se l'utente è una persona fisica altrimenti spazio vuoto */
UPDATE VoiPUFFICIO
SET PROV= CASE WHEN prov is null then ' ' else prov end 


/* se è una persona fisica mette i dati riportati sotto come spazi */

 update VoiPUFFICIO
set VoiPUFFICIO.DENOMINAZIONE=' ',COMUNEDOMICILIO=' ',SIGLACOMUNEDOMICILIO=' ',prov=' '
where CF not like '[0-9]%'


/* inserisce il cognome se non è una partita iva */
UPDATE VoiPUFFICIO
SET VoiPUFFICIO.cognome = CASE
                  WHEN SUBSTRING(VoiPUFFICIO.cf,1,1) like '[0-9]'  THEN ' '
                  ELSE VoiPtmptabella.cognome
              END
from VoiPUFFICIO join VoiPtmptabella on VoiPUFFICIO.cf=VoiPtmptabella.CF or VoiPUFFICIO.cf=VoiPtmptabella.PIva

/* inserisce il nome se non è una partita iva */

UPDATE VoiPUFFICIO
SET nome = CASE
WHEN SUBSTRING(VoiPUFFICIO.cf,1,1) like '[0-9]' THEN ' '
                  ELSE VoiPtmptabella.nome
              END
from VoiPUFFICIO join VoiPtmptabella on VoiPUFFICIO.cf=VoiPtmptabella.CF or VoiPUFFICIO.cf=VoiPtmptabella.PIva



/* inserisce il sesso se è una persona fisica */
UPDATE VoiPUFFICIO
SET sesso = CASE
                  WHEN SUBSTRING(VoiPUFFICIO.cf,1,1) like '[0-9]'  THEN ' '
                  ELSE VoiPtmptabella.sesso
              END
from VoiPUFFICIO join VoiPtmptabella on VoiPUFFICIO.cf=VoiPtmptabella.CF or VoiPUFFICIO.cf=VoiPtmptabella.PIva

/* inserisce il luogo di nascita se è una persona fisica */

			  UPDATE VoiPUFFICIO
SET LUOGONASCITA = CASE
                  WHEN SUBSTRING(VoiPUFFICIO.cf,1,1) like '[0-9]' THEN ' '
                  ELSE LUOGONASCITA
              END
from VoiPUFFICIO join VoiPtmptabella on VoiPUFFICIO.cf=VoiPtmptabella.CF or VoiPUFFICIO.cf=VoiPtmptabella.PIva

/* inserisce la provincia solo se è persona fisica */
  UPDATE VoiPUFFICIO
SET PROV= CASE
                  WHEN SUBSTRING(VoiPUFFICIO.cf,1,1) like '[0-9]' THEN ' '
                  ELSE VoiPtmptabella.prov
              END
from VoiPUFFICIO join VoiPtmptabella on VoiPUFFICIO.cf=VoiPtmptabella.CF or VoiPUFFICIO.cf=VoiPtmptabella.PIva


/* inserisce la data di nascita solo se è una persona fisica */
 UPDATE VoiPUFFICIO
SET dtnascita= CASE
                  WHEN SUBSTRING(VoiPUFFICIO.cf,1,1)  like '[a-zA-Z]' THEN VoiPtmptabella.DtNascita
                  ELSE ' '
              END
from VoiPUFFICIO join VoiPtmptabella on VoiPUFFICIO.cf=VoiPtmptabella.CF or VoiPUFFICIO.cf=VoiPtmptabella.PIva



/* inserisce DESTINAZIONEUSO tipo di contratto 1-persona fisica 2- azienda */
 UPDATE VoiPUFFICIO
SET DESTINAZIONEUSO= CASE
                  WHEN SUBSTRING(VoiPUFFICIO.cf,1,1) like '[0-9]' THEN 1
                  ELSE 2
              END
from VoiPUFFICIO join VoiPtmptabella on VoiPUFFICIO.cf=VoiPtmptabella.CF or VoiPUFFICIO.cf=VoiPtmptabella.PIva


/* inserisce il comune domicilio solo per le aziende mentre per le persone fisiche inserisce uno spazio */
UPDATE VoiPUFFICIO
SET COMUNEDOMICILIO=CASE when SUBSTRING(CF,1,1) LIKE '[a-zA-z]' then ' ' else COMUNEDOMICILIO end

/* inserisce SIGLACOMUNEDOMICILIOo solo per le aziende mentre per le persone fisiche inserisce uno spazio */
UPDATE VoiPUFFICIO
SET SIGLACOMUNEDOMICILIO=CASE when SUBSTRING(CF,1,1) LIKE '[a-zA-z]' then ' ' else SIGLACOMUNEDOMICILIO end


/* inserisce CODICECOMUNE quando è presente, altrimenti uno spazio */
UPDATE VoiPUFFICIO
SET VoiPUFFICIO.CODICECOMUNE = case when CODICECOMUNE is null then ' ' else CODICECOMUNE end

/* inserisce la provincia quando persona estera */
UPDATE VoiPUFFICIO    
SET PROV= CASE WHEN SUBSTRING(VoiPUFFICIO.cf,12,1)='Z' then 'EE' else prov end 

/*prende i nove caratteri più a destra */
update VoiPUFFICIO
set AMMONTAREFATTURATO=RIGHT(AMMONTAREFATTURATO,9+'       '),
LUNGHEZZAFATTURATO=LEN(AMMONTAREFATTURATO)

update VoiPUFFICIO
SET FATTURATO= replicate (' ', 9 - LUNGHEZZAFATTURATO) +AMMONTAREFATTURATO

update VoiPUFFICIO
SET AMMONTAREFATTURATO= FATTURATO


 







end

