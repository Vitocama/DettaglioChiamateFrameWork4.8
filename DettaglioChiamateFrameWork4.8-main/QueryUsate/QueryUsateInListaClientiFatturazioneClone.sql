
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
    WHERE 
        ultimafatturazione IS NOT NULL
    GROUP BY 
        contratto, Tipo
) AS sec 
ON voiptmpFatturazioneClone.contratto = sec.contratto 
AND voiptmpFatturazioneClone.Tipo = sec.Tipo;



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
					 WHERE 
        ultimafatturazione IS NOT NULL
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
					 WHERE 
        ultimafatturazione IS NOT NULL
                GROUP BY 
                    contratto, Tipo
            ) chiamata ON voiptmpFatturazioneClone.contratto = chiamata.contratto AND VoiptmpFatturazioneClone.Tipo = chiamata.Tipo;


			 UPDATE voiptmpfatturazioneclone
 SET offerta=voiptmpFatturazione.offerta
 FROM voiptmpfatturazioneClone 
 JOIN voiptmpFatturazione 
 ON voiptmpFatturazione.contratto=voiptmpfatturazioneClone.contratto 
 AND voiptmpFatturazione.tipo=voiptmpfatturazioneClone.Tipo
  WHERE 
        ultimafatturazione IS NOT NULL


 UPDATE voiptmpFatturazione
        SET secondiAddebitabili=
        CASE WHEN importo=0 
        THEN 0 ELSE secondi END
        FROM voiptmpFatturazione JOIN voipdettaglio
        ON voiptmpfatturazione.idDettaglio=voipdettaglio.id
		 WHERE 
        ultimafatturazione IS NOT NULL

 UPDATE voiptmpFatturazioneClone
 SET voiptmpFatturazioneclone.scatto =ROUND(VoiPofferte.Scatto*voiptmpfatturazioneClone.NchiamateAddebitabili,2)
 FROM VoiPofferte
 JOIN voiptmpFatturazioneclone ON VoiPofferte.idofferta = voiptmpFatturazioneclone.offerta



