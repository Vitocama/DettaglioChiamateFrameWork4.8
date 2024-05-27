---<--! Per popolare VoipTmpFatturazione




--LE QUERY USATE PER ANDARE A POPOLARE LA TABELLA vOIPTMPFATTURAZIONE


delete from voiptmpfatturazione


INSERT INTO [dbo].[voiptmpFatturazione] (
        [orachiamata],
        [data],
        [idDettaglio],
        [contratto],
        [nome],
        [CodCli],
        [telefono],
        [offerta], 
        [durata],  
        [secondi]
     

		)
   
    SELECT 
        voipdettaglio.orachiamata,
        voipdettaglio.data,
	    voipdettaglio.id,
        VoipContratti.id AS [contratto],
        VoipContratti.nome,
        Contratti.CodCli,
        VoipContratti.voip,
        VoipContratti.offerta,
        voipdettaglio.durata,
        DATEDIFF(second,'0:0:0',voipdettaglio.durata) AS secondi
		

    FROM 
        VoipContratti 
    JOIN 
        voipdettaglio ON voipdettaglio.chiamante = VoipContratti.voip 
    JOIN 
        Contratti ON VoipContratti.id = Contratti.IdContratto 
    WHERE
       voipdettaglio.data >= '01-03-2020' AND voipdettaglio.data <= '01-03-2023'
 AND idcontratto IN ('24GI.VOIP')

 ----------utenti voip e portabilita'

 INSERT INTO [dbo].[voiptmpFatturazione] (
        [orachiamata],
        [data],
        [idDettaglio],
        [contratto],
        [nome],
        [CodCli],
        [telefono],
        [offerta], 
        [durata],  
        [secondi]

		)
   
    SELECT 
        voipdettaglio.orachiamata,
        voipdettaglio.data,
	    voipdettaglio.id,
        VoipContratti.id AS [contratto],
        VoipContratti.nome,
        Contratti.CodCli,
        VoipContratti.portabilita,
        VoipContratti.offerta,
        voipdettaglio.durata,
        DATEDIFF(second,'0:0:0',voipdettaglio.durata) AS secondi
   
		

    FROM 
        VoipContratti 
    JOIN 
        voipdettaglio ON voipdettaglio.chiamante = VoipContratti.portabilita
    JOIN 
        Contratti ON VoipContratti.id = Contratti.IdContratto 

    WHERE 
       voipdettaglio.data >= '01-03-2020' AND voipdettaglio.data <= '01-03-2023'  AND idcontratto IN ('24GI.VOIP')


--Nchiamate

UPDATE voiptmpfatturazione
SET Nchiamate=1

-- popola Scatto

	               UPDATE voiptmpFatturazione
SET voiptmpFatturazione.scatto =VoiPofferte.Scatto*NchiamateAddebitabili
FROM VoiPofferte 
JOIN voiptmpFatturazione ON VoiPofferte.idofferta = voiptmpFatturazione.offerta 
JOIN voipdettaglio ON voipdettaglio.id = voiptmpFatturazione.idDettaglio;




--NchiamateAddebitabili

UPDATE voiptmpfatturazione
SET     NchiamateAddebitabili=case 
WHEN importo=0 THEN 0 ELSE 1 
END
FROM voiptmpFatturazione 
JOIN voipdettaglio 
ON voiptmpFatturazione.iddettaglio=voipdettaglio.id

--scatto
       UPDATE voiptmpFatturazione
SET voiptmpFatturazione.scatto =VoiPofferte.Scatto*NchiamateAddebitabili
FROM VoiPofferte 
JOIN voiptmpFatturazione ON VoiPofferte.idofferta = voiptmpFatturazione.offerta 
JOIN voipdettaglio ON voipdettaglio.id = voiptmpFatturazione.idDettaglio;






--Tipo

            UPDATE voiptmpFatturazione
SET voiptmpFatturazione.tipo=VoiPdettaglio.tipo
FROM VoiptmpFatturazione
JOIN VoiPdettaglio
ON VoiPdettaglio.id=voiptmpFatturazione.idDettaglio
where
VoiptmpFatturazione.idDettaglio=VoiPdettaglio.iD

--descrizione

UPDATE voiptmpFatturazione
SET descrizione= voipTipoChiamate.Descrizione
FROM voiptmpFatturazione JOIN
voipTipoChiamate 
ON voiptmpFatturazione.Tipo=voipTipoChiamate.tipo

--secondiAddebitabili

                   UPDATE voiptmpFatturazione
SET secondiAddebitabili=
CASE WHEN importo=0 
THEN 0 ELSE secondi END
FROM voiptmpFatturazione JOIN voipdettaglio 
ON voiptmpfatturazione.idDettaglio=voipdettaglio.id

--   ClnOffertaScatto

            UPDATE voiptmpFatturazione
SET voiptmpFatturazione.scatto =VoiPofferte.Scatto*NchiamateAddebitabili
FROM VoiPofferte 
JOIN voiptmpFatturazione ON VoiPofferte.idofferta = voiptmpFatturazione.offerta 
JOIN voipdettaglio ON voipdettaglio.id = voiptmpFatturazione.idDettaglio;


--SpesaChimata

            UPDATE voiptmpfatturazione
SET SpesaChimata=VoiPofferte.SpesaScatto* VoiptmpFatturazione.Scatto
FROM VoiptmpFatturazione JOIN VoiPofferte
on VoiptmpFatturazione.offerta=VoiPofferte.idofferta

--ultimaFatturazione

           UPDATE voiptmpFatturazione
SET voiptmpfatturazione.ultimaFatturazione=voipContratti.lastdata
FROM voiptmpFatturazione 
JOIN VoipContratti
ON voiptmpFatturazione.contratto=VoipContratti.id

--CONTA SECONDI

 INSERT INTO voipConteggioSecondo(
 contratto,
 SommaDeiSecondi,
  tipo
 )
 SELECT 
   contratto,
  sum(datediff(second,'0:0:0',voiptmpFatturazione.durata)) AS sommaDeiSecondi,
  tipo
 FROM 
   voiptmpFatturazione
   GROUP BY 
   contratto,
   tipo;


   