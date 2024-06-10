
-- query che verifica se i prefissi sono presenti nella tabella voipTipoChiamata


	SELECT VoiPdettaglio.*
FROM VoiPdettaglio
LEFT JOIN VoiPTipoChiamate
ON LEFT(VoiPdettaglio.prefisso, 3) = VoiPTipoChiamate.Prefisso
   OR LEFT(VoiPdettaglio.prefisso, 2) = VoiPTipoChiamate.Prefisso
WHERE VoiPTipoChiamate.Prefisso IS NULL;




