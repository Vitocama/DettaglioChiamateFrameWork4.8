using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FileHelper.Entities;

public partial class Voip1Context : DbContext
{
    public Voip1Context()
    {
    }

    public Voip1Context(DbContextOptions<Voip1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Clienti> Clientis { get; set; }

    public virtual DbSet<ConteggioSecondo> ConteggioSecondos { get; set; }

    public virtual DbSet<Contratti> Contrattis { get; set; }

    public virtual DbSet<Dettaglio> Dettaglios { get; set; }

    public virtual DbSet<DettaglioChiamate> DettaglioChiamates { get; set; }

    public virtual DbSet<DettaglioStorico> DettaglioStoricos { get; set; }

    public virtual DbSet<Fatturazione> Fatturaziones { get; set; }

    public virtual DbSet<Offertum> Offerta { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<SigleComuni> SigleComunis { get; set; }

    public virtual DbSet<TabellaUfficio> TabellaUfficios { get; set; }

    public virtual DbSet<TargheComuni> TargheComunis { get; set; }

    public virtual DbSet<TipoChiamate> TipoChiamates { get; set; }

    public virtual DbSet<TmpFatturazione> TmpFatturaziones { get; set; }

    public virtual DbSet<Tmpfatturazione1> Tmpfatturazione1s { get; set; }

    public virtual DbSet<TmpfatturazioneClone> TmpfatturazioneClones { get; set; }

    public virtual DbSet<Ufficio> Ufficios { get; set; }

    public virtual DbSet<Ufficio2023> Ufficio2023s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-8OH69FI3\\SQLEXPRESS01;Database=voip1;Trusted_Connection=True;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>(entity =>
        {
            entity.HasKey(e => e.BlogId).HasName("PK_dbo.Blogs");

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Url).HasMaxLength(200);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_cliente");

            entity.ToTable("Cliente");

            entity.Property(e => e.Id)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Datadisdetta).HasColumnName("datadisdetta");
            entity.Property(e => e.Datainizio).HasColumnName("datainizio");
            entity.Property(e => e.Dataport).HasColumnName("dataport");
            entity.Property(e => e.Fatturazione).HasColumnName("fatturazione");
            entity.Property(e => e.Lastdata).HasColumnName("lastdata");
            entity.Property(e => e.Migrazione).HasColumnName("migrazione");
            entity.Property(e => e.Migrazioneport).HasColumnName("migrazioneport");
            entity.Property(e => e.Nome).HasColumnName("nome");
            entity.Property(e => e.Offerta).HasColumnName("offerta");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Portabilita).HasColumnName("portabilita");
            entity.Property(e => e.Seriale).HasColumnName("seriale");
            entity.Property(e => e.Stato).HasColumnName("stato");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
            entity.Property(e => e.Voip).HasColumnName("voip");
        });

        modelBuilder.Entity<Clienti>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Clienti");

            entity.Property(e => e.AllegatoCf).HasColumnName("AllegatoCF");
            entity.Property(e => e.Altro)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AutorizzoEmail).HasColumnName("AutorizzoEMail");
            entity.Property(e => e.AutorizzoPubbSito)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.B2bPec)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("B2B_PEC");
            entity.Property(e => e.B2bPortale)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("B2B_PORTALE");
            entity.Property(e => e.Cap)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CapoGruppo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cellulare)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Cf)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CF");
            entity.Property(e => e.Civaestero)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CIVAEstero");
            entity.Property(e => e.CodClass)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodCliFatt)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodCliPadre)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodLing)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodNaz)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CodRapprLegBl)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodTessera)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodTipo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Cognome)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.CtoTratGar)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DasCodUffAdm)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("DasCodUffADM");
            entity.Property(e => e.DasDestCodAccisa)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.DataInf).HasColumnType("datetime");
            entity.Property(e => e.DataInser).HasColumnType("datetime");
            entity.Property(e => e.DataSollecito).HasColumnType("datetime");
            entity.Property(e => e.DataStatoContab).HasColumnType("datetime");
            entity.Property(e => e.DataUltAgg).HasColumnType("datetime");
            entity.Property(e => e.DataValuta).HasColumnType("datetime");
            entity.Property(e => e.Datapcona)
                .HasColumnType("datetime")
                .HasColumnName("DATAPCONA");
            entity.Property(e => e.Datapconda)
                .HasColumnType("datetime")
                .HasColumnName("DATAPCONDA");
            entity.Property(e => e.DatasollecitoS).HasColumnType("datetime");
            entity.Property(e => e.Denom)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.DsNaz)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.DtNascita).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EMail");
            entity.Property(e => e.EmailAmm)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EMailAmm");
            entity.Property(e => e.EmailComm)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EMailComm");
            entity.Property(e => e.EmailCred)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EMailCred");
            entity.Property(e => e.EmailMan)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EMailMan");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Fitosog).HasColumnName("FITOSOG");
            entity.Property(e => e.FlgCfcedente).HasColumnName("FlgCFCedente");
            entity.Property(e => e.FlgForzaCodFisErr).HasColumnName("flgForzaCodFisErr");
            entity.Property(e => e.FlgForzaPartIvaErr).HasColumnName("flgForzaPartIvaErr");
            entity.Property(e => e.FlgSplitPaymentPa).HasColumnName("flgSplitPaymentPA");
            entity.Property(e => e.Ggritardo).HasColumnName("GGRitardo");
            entity.Property(e => e.Ind)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Iso)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Loc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LuogoNascita)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modem)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.NoteRecCrd).HasColumnType("text");
            entity.Property(e => e.NotificaViaSms).HasColumnName("NotificaViaSMS");
            entity.Property(e => e.OpeRespCli)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.OraFestFineSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraFestInizioSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraNottFine)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraNottFineSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraNottInizio)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraNottInizioSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraOrdFineSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraOrdInizioSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraStdFine)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraStdInizio)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraStraFineSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraStraInizioSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PaCoduff)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("PA_CODUFF");
            entity.Property(e => e.PaNoEsigIva).HasColumnName("PA_NoEsigIva");
            entity.Property(e => e.PassWord)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PecAmm)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Piva)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("PIva");
            entity.Property(e => e.PreInt)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Prov)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ProvNascita)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Rating)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.RespCredito)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Rfcodice)
                .HasMaxLength(28)
                .IsUnicode(false)
                .HasColumnName("RFCodice");
            entity.Property(e => e.Rfcognome)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("RFCognome");
            entity.Property(e => e.Rfdenom)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("RFDenom");
            entity.Property(e => e.Rfnaz)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("RFNaz");
            entity.Property(e => e.Rfnome)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("RFNome");
            entity.Property(e => e.Riferim)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Rwemail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RWEmail");
            entity.Property(e => e.RwflgAddViagg).HasColumnName("RWFlgAddViagg");
            entity.Property(e => e.RwnumReport).HasColumnName("RWNumReport");
            entity.Property(e => e.Sesso)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SoanaPrinc).HasColumnName("SOAnaPrinc");
            entity.Property(e => e.Socap)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SOCap");
            entity.Property(e => e.Societa)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Socomune)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("SOComune");
            entity.Property(e => e.Soindirizzo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("SOIndirizzo");
            entity.Property(e => e.Sollecito)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.SollecitoS)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Sonaz)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SONaz");
            entity.Property(e => e.Sonciv)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SONciv");
            entity.Property(e => e.Soprov)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SOProv");
            entity.Property(e => e.Stato)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.StatoContab)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.StatoModulo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Tel)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Tel2)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Telex)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Titolo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UAvvocato).HasColumnName("U_Avvocato");
            entity.Property(e => e.UCellulareSms)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("U_CellulareSMS");
            entity.Property(e => e.UDataConsegnaAvvocato)
                .HasColumnType("datetime")
                .HasColumnName("U_DataConsegnaAvvocato");
            entity.Property(e => e.UEscludiScadenziario).HasColumnName("U_EscludiScadenziario");
            entity.Property(e => e.UFaldone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_Faldone");
            entity.Property(e => e.UNumeroVoip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_NumeroVoip");
            entity.Property(e => e.UPasswordVoip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_PasswordVoip");
            entity.Property(e => e.UUserNameVoip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_UserNameVoip");
            entity.Property(e => e.VoceFin)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConteggioSecondo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ConteggioSecondo");

            entity.Property(e => e.Contratto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contratto");
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Contratti>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Contratti");

            entity.Property(e => e.CodAmmSuContr)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodBanca)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodLu)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodPag)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Commessa)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ContrStatusCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ContrattoRinegoz)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DataChius).HasColumnType("datetime");
            entity.Property(e => e.DataDec).HasColumnType("datetime");
            entity.Property(e => e.DataDecIniz).HasColumnType("datetime");
            entity.Property(e => e.DataDecManu).HasColumnType("datetime");
            entity.Property(e => e.DataDisdetta).HasColumnType("datetime");
            entity.Property(e => e.DataFinSosp).HasColumnType("datetime");
            entity.Property(e => e.DataInSosp).HasColumnType("datetime");
            entity.Property(e => e.DataInser).HasColumnType("datetime");
            entity.Property(e => e.DataScad).HasColumnType("datetime");
            entity.Property(e => e.DataScadFin).HasColumnType("datetime");
            entity.Property(e => e.DataStatoComm).HasColumnType("datetime");
            entity.Property(e => e.DataStip).HasColumnType("datetime");
            entity.Property(e => e.DivDest)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FlagSim).HasColumnName("FlagSIM");
            entity.Property(e => e.Fstato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FStato");
            entity.Property(e => e.GruAum)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.IdContratto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.OraFestFineSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraFestInizioSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraNottFine)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraNottFineSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraNottInizio)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraNottInizioSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraOrdFineSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraOrdInizioSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraStdFine)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraStdInizio)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraStraFineSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.OraStraInizioSab)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PaCig)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PA_CIG");
            entity.Property(e => e.PaCup)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PA_CUP");
            entity.Property(e => e.PaData)
                .HasColumnType("datetime")
                .HasColumnName("PA_DATA");
            entity.Property(e => e.PaIddoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PA_IDDOC");
            entity.Property(e => e.StatoComm)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.TipoContr)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.UCodiceMigrazione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_CodiceMigrazione");
            entity.Property(e => e.UGps)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_GPS");
            entity.Property(e => e.UIppubblicoCpe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_IPPubblicoCpe");
            entity.Property(e => e.UNote)
                .HasColumnType("text")
                .HasColumnName("U_Note");
            entity.Property(e => e.URicaricabile).HasColumnName("U_Ricaricabile");
            entity.Property(e => e.USsid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_SSID");
            entity.Property(e => e.UTecnico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_tecnico");
            entity.Property(e => e.UUbicazione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_Ubicazione");
            entity.Property(e => e.UUserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_UserName");
            entity.Property(e => e.UValoreCpe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_ValoreCPE");
            entity.Property(e => e.XmlCommessa)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Zona)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Dettaglio>(entity =>
        {
            entity.ToTable("dettaglio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Chiamante)
                .HasMaxLength(50)
                .HasColumnName("chiamante");
            entity.Property(e => e.Chiamato)
                .HasMaxLength(50)
                .HasColumnName("chiamato");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Durata)
                .HasMaxLength(50)
                .HasColumnName("durata");
            entity.Property(e => e.Importo).HasColumnName("importo");
            entity.Property(e => e.Orachiamata)
                .HasMaxLength(50)
                .HasColumnName("orachiamata");
            entity.Property(e => e.Prefisso)
                .HasMaxLength(50)
                .HasColumnName("prefisso");
            entity.Property(e => e.Spesa).HasColumnName("spesa");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<DettaglioChiamate>(entity =>
        {
            entity.ToTable("DettaglioChiamate");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Chiamante)
                .HasMaxLength(255)
                .HasColumnName("chiamante");
            entity.Property(e => e.Chiamato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("chiamato");
            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Durata)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("durata");
            entity.Property(e => e.IdContratto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("idContratto");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Orachiamata)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("orachiamata");
            entity.Property(e => e.Prefisso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prefisso");
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<DettaglioStorico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DettaglioStorico");

            entity.Property(e => e.Chiamante)
                .HasMaxLength(50)
                .HasColumnName("chiamante");
            entity.Property(e => e.Chiamato)
                .HasMaxLength(50)
                .HasColumnName("chiamato");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.DataPassaggioStorico)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dataPassaggioStorico");
            entity.Property(e => e.Durata)
                .HasMaxLength(50)
                .HasColumnName("durata");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Importo).HasColumnName("importo");
            entity.Property(e => e.Orachiamata)
                .HasMaxLength(50)
                .HasColumnName("orachiamata");
            entity.Property(e => e.Prefisso)
                .HasMaxLength(50)
                .HasColumnName("prefisso");
            entity.Property(e => e.Spesa).HasColumnName("spesa");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Fatturazione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fatturazione");

            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Contratto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("contratto");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Fatturazione1).HasColumnName("fatturazione");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Nome).HasColumnName("nome");
            entity.Property(e => e.Offerta).HasColumnName("offerta");
            entity.Property(e => e.Portabilita).HasColumnName("portabilita");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
            entity.Property(e => e.Voip).HasColumnName("voip");
        });

        modelBuilder.Entity<Offertum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("offerta");

            entity.Property(e => e.Costo).HasColumnName("costo");
            entity.Property(e => e.Idofferta).HasColumnName("idofferta");
            entity.Property(e => e.Minfisso).HasColumnName("minfisso");
            entity.Property(e => e.Minmobile).HasColumnName("minmobile");
            entity.Property(e => e.Nome).HasColumnName("nome");
            entity.Property(e => e.Scatto).HasColumnName("scatto");
            entity.Property(e => e.SpesaVfissi).HasColumnName("SpesaVFissi");
            entity.Property(e => e.SpesaVmobili).HasColumnName("SpesaVMobili");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK_dbo.Posts");

            entity.Property(e => e.Content).HasColumnType("ntext");
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.Blog).WithMany(p => p.Posts)
                .HasForeignKey(d => d.BlogId)
                .HasConstraintName("FK_dbo.Posts_dbo.Blogs_BlogId");
        });

        modelBuilder.Entity<SigleComuni>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sigleComuni");

            entity.Property(e => e.Comune)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TabellaUfficio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tabellaUfficio");

            entity.Property(e => e.CodiceComune)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodiceFiscale)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Cognome)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("COGNOME");
            entity.Property(e => e.ComuneDiComicilio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Datadinascita)
                .HasMaxLength(4000)
                .HasColumnName("DATADINASCITA");
            entity.Property(e => e.Datainizio)
                .HasMaxLength(4000)
                .HasColumnName("datainizio");
            entity.Property(e => e.Denom)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Disdetta)
                .HasMaxLength(4000)
                .HasColumnName("disdetta");
            entity.Property(e => e.Id)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.IdContratto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INDIRIZZO");
            entity.Property(e => e.Luogodinascita)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LUOGODINASCITA");
            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NOME");
            entity.Property(e => e.Piva)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("PIva");
            entity.Property(e => e.Provinciadinascita)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PROVINCIADINASCITA");
            entity.Property(e => e.Sesso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SESSO");
            entity.Property(e => e.SigliaComuneDomicilio)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Spesa).HasColumnName("spesa");
        });

        modelBuilder.Entity<TargheComuni>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TargheComuni");

            entity.Property(e => e.Cap)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CodiceAuto).ValueGeneratedOnAdd();
            entity.Property(e => e.CodiceComune)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comune)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoChiamate>(entity =>
        {
            entity.ToTable("TipoChiamate");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Prefisso)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TmpFatturazione>(entity =>
        {
            entity.ToTable("tmpFatturazione");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Contratto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contratto");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Durata).HasColumnName("durata");
            entity.Property(e => e.IdDettaglio).HasColumnName("idDettaglio");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Offerta).HasColumnName("offerta");
            entity.Property(e => e.Secondi).HasColumnName("secondi");
            entity.Property(e => e.SecondiAddebitabili).HasColumnName("secondiAddebitabili");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Tmpfatturazione1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpfatturazione1");

            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Contratto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("contratto");
            entity.Property(e => e.Durata)
                .HasMaxLength(50)
                .HasColumnName("durata");
            entity.Property(e => e.Nome).HasColumnName("nome");
            entity.Property(e => e.Offerta).HasColumnName("offerta");
            entity.Property(e => e.Orachiamata)
                .HasMaxLength(50)
                .HasColumnName("orachiamata");
            entity.Property(e => e.Secondi).HasColumnName("secondi");
            entity.Property(e => e.SecondiAddebitabili).HasColumnName("secondiAddebitabili");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TmpfatturazioneClone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpfatturazioneClone");

            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Contratto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contratto");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descrizione");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Offerta).HasColumnName("offerta");
            entity.Property(e => e.Secondi).HasColumnName("secondi");
            entity.Property(e => e.SecondiAddebitabili).HasColumnName("secondiAddebitabili");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ufficio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UFFICIO__3214EC0779DB978D");

            entity.ToTable("UFFICIO");

            entity.Property(e => e.Ammontarefatturato)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("AMMONTAREFATTURATO");
            entity.Property(e => e.Caratteredicontrollo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARATTEREDICONTROLLO");
            entity.Property(e => e.Caratterefineriga)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CARATTEREFINERIGA");
            entity.Property(e => e.Cf)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CF");
            entity.Property(e => e.Codicecomune)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CODICECOMUNE");
            entity.Property(e => e.Cognome)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("COGNOME");
            entity.Property(e => e.Comunedomicilio)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("COMUNEDOMICILIO");
            entity.Property(e => e.Costoannualericariche)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("COSTOANNUALERICARICHE");
            entity.Property(e => e.Datainizio)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DATAINIZIO");
            entity.Property(e => e.Denominazione)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DENOMINAZIONE");
            entity.Property(e => e.Destinazioneuso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DESTINAZIONEUSO");
            entity.Property(e => e.Dtnascita)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DTNASCITA");
            entity.Property(e => e.EstremiContratto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("estremiCONTRATTO");
            entity.Property(e => e.Filler)
                .HasMaxLength(1456)
                .IsUnicode(false)
                .HasColumnName("FILLER");
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("INDIRIZZO");
            entity.Property(e => e.Luogonascita)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("LUOGONASCITA");
            entity.Property(e => e.Mesifatturazione)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MESIFATTURAZIONE");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
            entity.Property(e => e.Numerofinale)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("NUMEROFINALE");
            entity.Property(e => e.Numeroiniziale)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("NUMEROINIZIALE");
            entity.Property(e => e.Prov)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PROV");
            entity.Property(e => e.Sesso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SESSO");
            entity.Property(e => e.Siglacomunedomicilio)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SIGLACOMUNEDOMICILIO");
            entity.Property(e => e.Tipocontratto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPOCONTRATTO");
            entity.Property(e => e.Tipologiautenza)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPOLOGIAUTENZA");
            entity.Property(e => e.Tiporecord)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("1")
                .HasColumnName("tiporecord");
            entity.Property(e => e.Tipotariffa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPOTARIFFA");
            entity.Property(e => e.Trafficoannuo)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("TRAFFICOANNUO");
        });

        modelBuilder.Entity<Ufficio2023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Ufficio2023");

            entity.Property(e => e.Ammontarefatturato)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("AMMONTAREFATTURATO");
            entity.Property(e => e.Caratteredicontrollo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARATTEREDICONTROLLO");
      
                
               
              
            entity.Property(e => e.Cf)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CF");
            entity.Property(e => e.Codicecomune)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CODICECOMUNE");
            entity.Property(e => e.Cognome)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("COGNOME");
            entity.Property(e => e.Comunedomicilio)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("COMUNEDOMICILIO");
            entity.Property(e => e.Costoannualericariche)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue("        0")
                .HasColumnName("COSTOANNUALERICARICHE");
            entity.Property(e => e.Datainizio)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DATAINIZIO");
            entity.Property(e => e.Denominazione)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DENOMINAZIONE");
            entity.Property(e => e.Destinazioneuso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("2")
                .HasColumnName("DESTINAZIONEUSO");
            entity.Property(e => e.Dtnascita)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DTNASCITA");
            entity.Property(e => e.EstremiContratto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("linea voip")
                .HasColumnName("estremiCONTRATTO");
            entity.Property(e => e.Filler)
                .HasMaxLength(1456)
                .IsUnicode(false)
                .HasColumnName("FILLER");
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("INDIRIZZO");
            entity.Property(e => e.Luogonascita)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("LUOGONASCITA");
            entity.Property(e => e.Mesifatturazione)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MESIFATTURAZIONE");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
            entity.Property(e => e.Numerofinale)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("     0")
                .HasColumnName("NUMEROFINALE");
            entity.Property(e => e.Numeroiniziale)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("     0")
                .HasColumnName("NUMEROINIZIALE");
            entity.Property(e => e.Prov)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PROV");
            entity.Property(e => e.Sesso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SESSO");
            entity.Property(e => e.Siglacomunedomicilio)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SIGLACOMUNEDOMICILIO");
            entity.Property(e => e.Tipocontratto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPOCONTRATTO");
            entity.Property(e => e.Tipologiautenza)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("2")
                .HasColumnName("TIPOLOGIAUTENZA");
            entity.Property(e => e.Tiporecord)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("1")
                .HasColumnName("tiporecord");
            entity.Property(e => e.Tipotariffa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("2")
                .HasColumnName("TIPOTARIFFA");
            entity.Property(e => e.Trafficoannuo)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValue("        0")
                .HasColumnName("TRAFFICOANNUO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
