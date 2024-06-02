using FileHelpers;

namespace FileHelper.EntitiesKONGNEW
{
    [FixedLengthRecord(FixedMode.AllowMoreChars)] // Configura la classe per utilizzare campi a larghezza fissa
    public class UfficioFILE
    {
        [FieldFixedLength(1)]
        public string Tiporecord { get; set; }

        [FieldFixedLength(16)]
        public string Cf { get; set; }

        [FieldFixedLength(24)]
        public string Cognome { get; set; }

        [FieldFixedLength(20)]
        public string Nome { get; set; }

        [FieldFixedLength(1)]
        public string Sesso { get; set; }

        [FieldFixedLength(8)]
        public string Dtnascita { get; set; }

        [FieldFixedLength(40)]
        public string Luogonascita { get; set; }

        [FieldFixedLength(2)]
        public string Prov { get; set; }

        [FieldFixedLength(60)]
        public string Denominazione { get; set; }

        [FieldFixedLength(40)]
        public string Comunedomicilio { get; set; }

        [FieldFixedLength(2)]
        public string Siglacomunedomicilio { get; set; }

        [FieldFixedLength(30)]
        public string EstremiContratto { get; set; }

        [FieldFixedLength(1)]
        public string Tipotariffa { get; set; }

        [FieldFixedLength(1)]
        public string Destinazioneuso { get; set; }

        [FieldFixedLength(1)]
        public string Tipocontratto { get; set; }

        [FieldFixedLength(1)]
        public string Tipologiautenza { get; set; }

        [FieldFixedLength(8)]
        public string Datainizio { get; set; }

        [FieldFixedLength(6)]
        public string Numeroiniziale { get; set; }

        [FieldFixedLength(6)]
        public string Numerofinale { get; set; }

        [FieldFixedLength(40)]
        public string Indirizzo { get; set; }

        [FieldFixedLength(4)]
        public string Codicecomune { get; set; }

        [FieldFixedLength(2)]
        public string Mesifatturazione { get; set; }

        [FieldFixedLength(9)]
        public string Costoannualericariche { get; set; }

        [FieldFixedLength(9)]
        public string Trafficoannuo { get; set; }

        [FieldFixedLength(9)]
        public string Ammontarefatturato { get; set; }

        [FieldFixedLength(1456)]
        public string Filler { get; set; }

        [FieldFixedLength(1)]
        public string Caratteredicontrollo { get; set; }

       
    }
}
