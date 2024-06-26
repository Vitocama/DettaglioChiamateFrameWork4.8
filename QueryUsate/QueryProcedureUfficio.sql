
ALTER procedure [dbo].[sp_creazioneTabellaUfficio]
@anno int 
as begin

	IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'sommaImportoChiamate' AND TABLE_SCHEMA = 'dbo')
    DROP TABLE dbo.sommaImportoChiamate;

if exists(select * from INFORMATION_SCHEMA.TABLES where table_name='UFFICIO')
drop table UFFICIO

if exists(select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME='TabellaSpesasomma')
drop table TabellaSpesasomma

if exists(select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME='tmptabella')
drop table tmptabella

if exists(select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME='tmptabella1')
 drop table  tmptabella1





create table sommaImportoChiamate(
idcliente varchar(256),
voip varchar(256),
portabilita varchar(256),
CF varchar(256),
CodCli varchar(256),
datadisdetta varchar(256),
spese float
)

insert into sommaImportoChiamate(idcliente,voip,portabilita,cf,codcli,datadisdetta,spese)
select voipCliente.id,voip,portabilita,CF,Contratti.CodCli,voipCliente.datadisdetta,sum(importo)as spese
from Clienti join Contratti on Clienti.CodCli=Contratti.CodCli
join voipCliente on Contratti.IdContratto=voipCliente.id
join voipdettaglio on (voipCliente.portabilita=voipdettaglio.chiamante or voipCliente.voip=voipdettaglio.chiamante )
where year(voipdettaglio.data)=@anno and ((year(voipCliente.datadisdetta)=1900 or year(voipCliente.datadisdetta)=@anno) and year(datainizio)<=@anno)
group by voipCliente.id,voip,portabilita,CF,Contratti.CodCli,voipCliente.datadisdetta




CREATE TABLE UFFICIO (
    tiporecord varchar(1) default '1' NULL,
    CF varchar(16)  NULL,
    COGNOME varchar(24) default            NULL,
    NOME varchar(20)  NULL,
    SESSO varchar(1) NULL,
    DTNASCITA varchar(8) NULL,
    LUOGONASCITA varchar(40) NULL,
    PROV varchar(2)  NULL,
    DENOMINAZIONE varchar(60)  NULL,
    COMUNEDOMICILIO varchar(40)  NULL,
    SIGLACOMUNEDOMICILIO varchar(2) NULL,
    estremiCONTRATTO varchar(30) default 'linea voip' NULL,
    TIPOTARIFFA varchar(1) default '2'  NULL,
    DESTINAZIONEUSO varchar(1) default '2' NULL,
    TIPOCONTRATTO varchar(1)  NULL,
    TIPOLOGIAUTENZA varchar(1) default '2'  NULL,
    DATAINIZIO varchar(8)  NULL,
    NUMEROINIZIALE varchar(6) default '     0' NULL,
    NUMEROFINALE varchar(6) default '     0' NULL,
    INDIRIZZO varchar(40)  NULL,
    CODICECOMUNE varchar(4) NULL,
    MESIFATTURAZIONE varchar(2)  NULL,
    COSTOANNUALERICARICHE varchar(9) default '        0' NULL,
    TRAFFICOANNUO varchar(9) default '        0' NULL,
    AMMONTAREFATTURATO varchar(9) NULL,
    FILLER varchar(1456) NULL,
    CARATTEREDICONTROLLO varchar(1)  NULL,
    CARATTEREFINERIGA varchar(4) NULL
)



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
    contratti.TipoContr,
    contratti.IdContratto,
    contratti.CodCli,
	FORMAT(voipCliente.datainizio, 'ddMMyyyy') AS datainizio,
    voipCliente.portabilita as NumeroIniziale,
	voipCliente.voip as NumeroFinale,
    left(clienti.Ind,40 )as indirizzo,
    FORMAT(voipCliente.datadisdetta, 'ddMMyyyy') AS datadisdetta,
	sommaImportoChiamate.spese as costi
	into tmptabella
FROM 
    voipCliente 
JOIN 
    contratti ON voipCliente.id = contratti.IdContratto 
JOIN 
    clienti ON contratti.CodCli = clienti.CodCli join sommaImportoChiamate on contratti.IdContratto=sommaImportoChiamate.idcliente

	

	select distinct *
	into tmptabella1
	from tmptabella
	

	UPDATE TMPTABELLA1
SET costi = 
    CASE 
        WHEN costi - FLOOR(costi) < 0.5 THEN FLOOR(costi)
        ELSE CEILING(costi)
    END;



INSERT INTO UFFICIO (
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
    tmptabella1

UPDATE UFFICIO
SET UFFICIO.SIGLACOMUNEDOMICILIO = sigleComuni.Provincia
FROM UFFICIO
 JOIN sigleComuni ON UFFICIO.COMUNEDOMICILIO = sigleComuni.Comune

 update UFFICIO
 set CARATTEREFINERIGA='crlf',CARATTEREDICONTROLLO='a'

 update UFFICIO
 set filler=replicate(' ',1456)


update UFFICIO
set UFFICIO.CF=tmptabella.PIva
from UFFICIO join tmptabella on UFFICIO.cf=tmptabella.CF
where piva is not null

UPDATE UFFICIO
SET PROV= CASE WHEN SUBSTRING(UFFICIO.cf,12,1)='Z' then 'EE' else prov end 


update UFFICIO
set TIPOCONTRATTO=2


UPDATE UFFICIO
SET UFFICIO.CODICECOMUNE = TargheComuni.CodiceComune
FROM UFFICIO
  JOIN TargheComuni ON UFFICIO.COMUNEDOMICILIO = TargheComuni.Comune

update UFFICIO
    set MESIFATTURAZIONE=CASE 
        WHEN RIGHT(datadisdetta, 4) = '2023' THEN
            CASE 
                WHEN SUBSTRING(datadisdetta, 3, 2) <= 12 THEN ' '+CAST(SUBSTRING(datadisdetta, 3, 2) AS varchar(2))
                ELSE 12
            END
        ELSE 12
    END 
from UFFICIO join tmptabella on UFFICIO.cf=tmptabella.CF or UFFICIO.cf=tmptabella.PIva
	
UPDATE UFFICIO
SET PROV= CASE WHEN prov is null then ' ' else prov end 


 update UFFICIO
set UFFICIO.DENOMINAZIONE=' ',COMUNEDOMICILIO=' ',SIGLACOMUNEDOMICILIO=' ',prov=' '
where CF not like '[0-9]%'


UPDATE UFFICIO
SET UFFICIO.cognome = CASE
                  WHEN SUBSTRING(UFFICIO.cf,1,1) like '[0-9]'  THEN ' '
                  ELSE tmptabella.cognome
              END
from UFFICIO join tmptabella on UFFICIO.cf=tmptabella.CF or UFFICIO.cf=tmptabella.PIva


UPDATE UFFICIO
SET nome = CASE
WHEN SUBSTRING(UFFICIO.cf,1,1) like '[0-9]' THEN ' '
                  ELSE tmptabella.nome
              END
from UFFICIO join tmptabella on UFFICIO.cf=tmptabella.CF or UFFICIO.cf=tmptabella.PIva


UPDATE UFFICIO
SET sesso = CASE
                  WHEN SUBSTRING(UFFICIO.cf,1,1) like '[0-9]'  THEN ' '
                  ELSE tmptabella.sesso
              END
from UFFICIO join tmptabella on UFFICIO.cf=tmptabella.CF or UFFICIO.cf=tmptabella.PIva


			  UPDATE UFFICIO
SET LUOGONASCITA = CASE
                  WHEN SUBSTRING(UFFICIO.cf,1,1) like '[0-9]' THEN ' '
                  ELSE LUOGONASCITA
              END
from UFFICIO join tmptabella on UFFICIO.cf=tmptabella.CF or UFFICIO.cf=tmptabella.PIva

			  UPDATE UFFICIO
SET PROV= CASE
                  WHEN SUBSTRING(UFFICIO.cf,1,1) like '[0-9]' THEN ' '
                  ELSE tmptabella.prov
              END
from UFFICIO join tmptabella on UFFICIO.cf=tmptabella.CF or UFFICIO.cf=tmptabella.PIva

			  UPDATE UFFICIO
SET dtnascita= CASE
                  WHEN SUBSTRING(UFFICIO.cf,1,1)  like '[a-zA-Z]' THEN tmptabella.DtNascita
                  ELSE ' '
              END
from UFFICIO join tmptabella on UFFICIO.cf=tmptabella.CF or UFFICIO.cf=tmptabella.PIva



			  UPDATE UFFICIO
SET DESTINAZIONEUSO= CASE
                  WHEN SUBSTRING(UFFICIO.cf,1,1) like '[0-9]' THEN 1
                  ELSE 2
              END
from UFFICIO join tmptabella on UFFICIO.cf=tmptabella.CF or UFFICIO.cf=tmptabella.PIva

UPDATE UFFICIO
SET COMUNEDOMICILIO=CASE when SUBSTRING(CF,1,1) LIKE '[a-zA-z]' then ' ' else COMUNEDOMICILIO end

UPDATE UFFICIO
SET SIGLACOMUNEDOMICILIO=CASE when SUBSTRING(CF,1,1) LIKE '[a-zA-z]' then ' ' else SIGLACOMUNEDOMICILIO end

UPDATE UFFICIO
SET UFFICIO.CODICECOMUNE = case when CODICECOMUNE is null then ' ' else CODICECOMUNE end

UPDATE UFFICIO    
SET PROV= CASE WHEN SUBSTRING(UFFICIO.cf,12,1)='Z' then 'EE' else prov end 

update UFFICIO
set AMMONTAREFATTURATO=RIGHT('       '+AMMONTAREFATTURATO,9);



    DROP TABLE dbo.sommaImportoChiamate;

drop table tmptabella


 drop table  tmptabella1




end

