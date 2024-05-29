
DELETE FROM voipConteggioSecondo

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



				  SELECT    
               
                contratto, 
                nome, 
                CodCli,  
                telefono,  
                offerta, 
                Tipo, 
                descrizione,  
                secondi, 
                secondiAddebitabili, 
                Nchiamate, 
                NchiamateAddebitabili, 
                Scatto,  spesa 
                FROM   voiptmpfatturazioneClone
                order by contratto


				UPDATE voiptmpFatturazione
SET voiptmpFatturazione.scatto =VoiPofferte.Scatto*NchiamateAddebitabili
FROM VoiPofferte 
JOIN voiptmpFatturazione ON VoiPofferte.idofferta = voiptmpFatturazione.offerta 
JOIN voipdettaglio ON voipdettaglio.id = voiptmpFatturazione.idDettaglio;


UPDATE voiptmpfatturazione
                SET Nchiamate=1


 UPDATE voiptmpfatturazione
            SET     NchiamateAddebitabili=case 
            WHEN importo=0 THEN 0 ELSE 1 
            END
            FROM voiptmpFatturazione 
            JOIN voipdettaglio 
            ON voiptmpFatturazione.iddettaglio=voipdettaglio.id




UPDATE voiptmpFatturazione
SET voiptmpFatturazione.tipo=VoiPdettaglio.tipo
FROM VoiptmpFatturazione
JOIN VoiPdettaglio
ON VoiPdettaglio.id=voiptmpFatturazione.idDettaglio
where
VoiptmpFatturazione.idDettaglio=VoiPdettaglio.iD



UPDATE voiptmpFatturazione
            SET descrizione= voipTipoChiamate.Descrizione
            FROM voiptmpFatturazione JOIN
            voipTipoChiamate 
            ON voiptmpFatturazione.Tipo=voipTipoChiamate.tipo



             UPDATE voiptmpfatturazione
 SET SpesaChimata=VoiPofferte.SpesaScatto* VoiptmpFatturazione.Scatto
 FROM VoiptmpFatturazione JOIN VoiPofferte
 on VoiptmpFatturazione.offerta=VoiPofferte.idofferta



 UPDATE voiptmpFatturazione
 SET voiptmpfatturazione.ultimaFatturazione=voipContratti.lastdata
 FROM voiptmpFatturazione 
 JOIN VoipContratti
 ON voiptmpFatturazione.contratto=VoipContratti.id



 UPDATE voiptmpFatturazione
 SET secondiAddebitabili=
 CASE WHEN importo=0 
 THEN 0 ELSE secondi END
 FROM voiptmpFatturazione JOIN voipdettaglio 
 ON voiptmpfatturazione.idDettaglio=voipdettaglio.id


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
        voipdettaglio ON voipdettaglio.chiamante = VoipContratti.portabilita 
    JOIN 
        Contratti ON VoipContratti.id = Contratti.IdContratto 
    WHERE
       voipdettaglio.data >= @inizio AND voipdettaglio.data <= @fine
 AND idcontratto IN ('EMi.voip','EMi.voip2','EMi.voip3')

            

            }
            sql = sql.Substring(0, sql.Length - 1);
            sql += ")";

            fatturazione.AddParam("@inizio", dtpInizio.Value.Date);
            fatturazione.AddParam("@fine", dtpFine.Value.Date);
            fatturazione.ExecQuery(sql);

            sql = @"
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
       voipdettaglio.data >= @inizio AND voipdettaglio.data <= @fine 


	   --AND idcontratto IN (


	   DELETE FROM voiptmpfatturazioneClone

	   DBCC CHECKIDENT ('voiptmpFatturazioneClone', RESEED, 0)

	   INSERT INTO voiptmpFatturazioneClone(contratto, Tipo, secondiaddebitabili, nome, CodCli, telefono, descrizione)
            SELECT
              
                contratto,
                Tipo,
                SUM(secondiaddebitabili) AS secondiaddebitabili,
                nome,
                CodCli,
                telefono,
                descrizione
            FROM
                voiptmpFatturazione
            GROUP BY
                contratto, Tipo, nome, CodCli, telefono, descrizione




	UPDATE voiptmpFatturazioneClone
SET voiptmpFatturazioneClone.secondi = sec.secondi
FROM voiptmpFatturazioneClone
JOIN (
    SELECT 
        contratto, 
        Tipo, 
        SUM(secondi) AS secondi
    FROM 
        voiptmpFatturazione 
    GROUP BY 
        contratto, Tipo
)as sec ON voiptmpFatturazioneClone.contratto = sec.contratto AND voiptmpFatturazioneClone.Tipo = sec.Tipo;



UPDATE voiptmpFatturazioneClone
            SET voiptmpFatturazioneClone.Nchiamate= chiamata.Nchiamate
            FROM voiptmpFatturazioneClone
            JOIN (
                SELECT
                    contratto, 
                    Tipo, 
                    SUM(Nchiamate) AS Nchiamate
                FROM 
                    voiptmpFatturazione 
                GROUP BY 
                    contratto, Tipo
            )as chiamata ON voiptmpFatturazioneClone.contratto = chiamata.contratto AND voiptmpFatturazioneClone.Tipo = chiamata.Tipo;



 UPDATE VoiptmpFatturazioneClone
            SET voiptmpFatturazioneClone.NchiamateAddebitabili= chiamata.NchiamateAddebitabili
            FROM voiptmpFatturazioneClone
            JOIN (
                SELECT
                    contratto, 
                    Tipo, 
                    SUM(NchiamateAddebitabili) AS NchiamateAddebitabili
                FROM 
                    voiptmpFatturazione 
                GROUP BY 
                    contratto, Tipo
            ) chiamata ON voiptmpFatturazioneClone.contratto = chiamata.contratto AND VoiptmpFatturazioneClone


			 UPDATE voiptmpfatturazioneclone
 SET offerta=voiptmpFatturazione.offerta
 FROM voiptmpfatturazioneClone 
 JOIN voiptmpFatturazione 
 ON voiptmpFatturazione.contratto=voiptmpfatturazioneClone.contratto 
 AND voiptmpFatturazione.tipo=voiptmpfatturazioneClone.Tipo


 UPDATE voiptmpFatturazione
        SET secondiAddebitabili=
        CASE WHEN importo=0 
        THEN 0 ELSE secondi END
        FROM voiptmpFatturazione JOIN voipdettaglio
        ON voiptmpfatturazione.idDettaglio=voipdettaglio.id

 UPDATE voiptmpFatturazioneClone
 SET voiptmpFatturazioneclone.scatto =ROUND(VoiPofferte.Scatto*voiptmpfatturazioneClone.NchiamateAddebitabili,2)
 FROM VoiPofferte
 JOIN voiptmpFatturazioneclone ON VoiPofferte.idofferta = voiptmpFatturazioneclone.offerta

 SELECT * FROM voiptmpFatturazione 
                   WHERE offerta=0

delete from voiptmpfatturazione DBCC CHECKIDENT ('voiptmpFatturazione', RESEED, 0)

