using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FileHelper.EntitiesKONGNEW;

public partial class KongnewContext : DbContext
{
    public KongnewContext()
    {
    }

    public KongnewContext(DbContextOptions<KongnewContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Abilitazioni> Abilitazionis { get; set; }

    public virtual DbSet<AbilitazioniFunzioni> AbilitazioniFunzionis { get; set; }

    public virtual DbSet<AgendaStorico> AgendaStoricos { get; set; }

    public virtual DbSet<Agendum> Agenda { get; set; }

    public virtual DbSet<AgentiFattureNonPagate> AgentiFattureNonPagates { get; set; }

    public virtual DbSet<AgentiProvvigioni> AgentiProvvigionis { get; set; }

    public virtual DbSet<Antivirus> Antiviruses { get; set; }

    public virtual DbSet<AntivirusMarche> AntivirusMarches { get; set; }

    public virtual DbSet<Apparati> Apparatis { get; set; }

    public virtual DbSet<ApparatiAbilitazioni> ApparatiAbilitazionis { get; set; }

    public virtual DbSet<ApparatiTipi> ApparatiTipis { get; set; }

    public virtual DbSet<ArticoliDaEscludere> ArticoliDaEscluderes { get; set; }

    public virtual DbSet<ArticoliProvvigioni> ArticoliProvvigionis { get; set; }

    public virtual DbSet<Automatismi> Automatismis { get; set; }

    public virtual DbSet<Clienti> Clientis { get; set; }

    public virtual DbSet<ClientiTelefono> ClientiTelefonos { get; set; }

    public virtual DbSet<Comuni> Comunis { get; set; }

    public virtual DbSet<Contratti> Contrattis { get; set; }

    public virtual DbSet<ContrattiArticoli> ContrattiArticolis { get; set; }

    public virtual DbSet<ContrattiAttivazioni> ContrattiAttivazionis { get; set; }

    public virtual DbSet<ContrattiNon> ContrattiNons { get; set; }

    public virtual DbSet<ContrattiOld> ContrattiOlds { get; set; }

    public virtual DbSet<ContrattiPerKong> ContrattiPerKongs { get; set; }

    public virtual DbSet<ContrattiProfili> ContrattiProfilis { get; set; }

    public virtual DbSet<ContrattiRateOld> ContrattiRateOlds { get; set; }

    public virtual DbSet<ContrattiScadenze> ContrattiScadenzes { get; set; }

    public virtual DbSet<ContrattiTipi> ContrattiTipis { get; set; }

    public virtual DbSet<ContrattiTipiFatturazione> ContrattiTipiFatturaziones { get; set; }

    public virtual DbSet<Eccezioni> Eccezionis { get; set; }

    public virtual DbSet<Foglio1> Foglio1s { get; set; }

    public virtual DbSet<LivelliPassword> LivelliPasswords { get; set; }

    public virtual DbSet<Messaggi> Messaggis { get; set; }

    public virtual DbSet<MessaggiDefinizione> MessaggiDefiniziones { get; set; }

    public virtual DbSet<Operazioni> Operazionis { get; set; }

    public virtual DbSet<OperazioniPianificate> OperazioniPianificates { get; set; }

    public virtual DbSet<OperazioniPianificateStorico> OperazioniPianificateStoricos { get; set; }

    public virtual DbSet<Pagamento> Pagamentos { get; set; }

    public virtual DbSet<PartiteAperte> PartiteApertes { get; set; }

    public virtual DbSet<Prodotti> Prodottis { get; set; }

    public virtual DbSet<ProfiliKing> ProfiliKings { get; set; }

    public virtual DbSet<ProfiliKingTemp> ProfiliKingTemps { get; set; }

    public virtual DbSet<ProfiliUtentiTutti> ProfiliUtentiTuttis { get; set; }

    public virtual DbSet<Ricaricabili> Ricaricabilis { get; set; }

    public virtual DbSet<SchedeSim> SchedeSims { get; set; }

    public virtual DbSet<SchedeSimFatture> SchedeSimFattures { get; set; }

    public virtual DbSet<Sconti> Scontis { get; set; }

    public virtual DbSet<Sm> Sms { get; set; }

    public virtual DbSet<Smsstorico> Smsstoricos { get; set; }

    public virtual DbSet<SommaImportoChiamate> SommaImportoChiamates { get; set; }

    public virtual DbSet<TipiContrattiRicaricabili> TipiContrattiRicaricabilis { get; set; }

    public virtual DbSet<TipiOperazione> TipiOperaziones { get; set; }

    public virtual DbSet<Tmptabella> Tmptabellas { get; set; }

    public virtual DbSet<Utenti> Utentis { get; set; }

    public virtual DbSet<UtentiAbilitazioni> UtentiAbilitazionis { get; set; }

    public virtual DbSet<UtentiAccesso> UtentiAccessos { get; set; }

    public virtual DbSet<UtentiFunzioni> UtentiFunzionis { get; set; }

    public virtual DbSet<UtentiPassword> UtentiPasswords { get; set; }

    public virtual DbSet<VoiPautomatismi> VoiPautomatismis { get; set; }

    public virtual DbSet<VoiPcliente> VoiPclientes { get; set; }

    public virtual DbSet<VoiPcontratti> VoiPcontrattis { get; set; }

    public virtual DbSet<VoiPcontrattiCanoni> VoiPcontrattiCanonis { get; set; }

    public virtual DbSet<VoiPdettaglioStorico> VoiPdettaglioStoricos { get; set; }

    public virtual DbSet<VoiPdettaglioTemp> VoiPdettaglioTemps { get; set; }

    public virtual DbSet<VoiPdettaglioold> VoiPdettaglioolds { get; set; }

    public virtual DbSet<VoiPnazioni> VoiPnazionis { get; set; }

    public virtual DbSet<VoiPnumerovoip> VoiPnumerovoips { get; set; }

    public virtual DbSet<VoiPofferte> VoiPoffertes { get; set; }

    public virtual DbSet<VoiPprefissi> VoiPprefissis { get; set; }

    public virtual DbSet<VoiPtipoChiamate> VoiPtipoChiamates { get; set; }

    public virtual DbSet<VoiPtotalefattura> VoiPtotalefatturas { get; set; }

    public virtual DbSet<VoiPufficio> VoiPufficios { get; set; }

    public virtual DbSet<Voipdettaglio> Voipdettaglios { get; set; }

    public virtual DbSet<_1Fonti> _1Fontis { get; set; }

    public virtual DbSet<_2Gateway> _2Gateways { get; set; }

    public virtual DbSet<_2GatewayBakup> _2GatewayBakups { get; set; }

    public virtual DbSet<_3Ponti> _3Pontis { get; set; }

    public virtual DbSet<_4Pannelli> _4Pannellis { get; set; }

    public virtual DbSet<_4PannelliBackup> _4PannelliBackups { get; set; }

    public virtual DbSet<_4Tecnologium> _4Tecnologia { get; set; }

    public virtual DbSet<_5ClientiReteBackup> _5ClientiReteBackups { get; set; }

    public virtual DbSet<_5Clientirete> _5Clientiretes { get; set; }

    public virtual DbSet<_6TabellaEsclusionePannelli> _6TabellaEsclusionePannellis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-8OH69FI3\\SQLEXPRESS01;Database=kongnew;Trusted_Connection=True;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Abilitazioni>(entity =>
        {
            entity.ToTable("Abilitazioni");

            entity.Property(e => e.Abilitazione).HasDefaultValue((byte)0);
            entity.Property(e => e.Funzione)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AbilitazioniFunzioni>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Funzioni");

            entity.ToTable("AbilitazioniFunzioni");

            entity.Property(e => e.Descrizione).HasMaxLength(255);
            entity.Property(e => e.Funzione).HasMaxLength(50);
        });

        modelBuilder.Entity<AgendaStorico>(entity =>
        {
            entity.ToTable("AgendaStorico");

            entity.Property(e => e.Codice)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Concluso).HasDefaultValue(false);
            entity.Property(e => e.DataFine).HasColumnType("datetime");
            entity.Property(e => e.DataInizio).HasColumnType("datetime");
            entity.Property(e => e.DataInserimento).HasColumnType("datetime");
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Denom)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione).IsUnicode(false);
            entity.Property(e => e.GeneratoDa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.Interno).HasDefaultValue(false);
            entity.Property(e => e.Titolo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Agendum>(entity =>
        {
            entity.Property(e => e.Codice)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Concluso).HasDefaultValue(false);
            entity.Property(e => e.DataFine).HasColumnType("datetime");
            entity.Property(e => e.DataInizio).HasColumnType("datetime");
            entity.Property(e => e.DataInserimento).HasColumnType("datetime");
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Denom)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione).IsUnicode(false);
            entity.Property(e => e.GeneratoDa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.Interno).HasDefaultValue(false);
            entity.Property(e => e.Titolo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AgentiFattureNonPagate>(entity =>
        {
            entity.ToTable("AgentiFattureNonPagate");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Agente)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Anno)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodArt)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodDoc)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.DataDoc).HasColumnType("datetime");
            entity.Property(e => e.DataScad).HasColumnType("datetime");
            entity.Property(e => e.Denom)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.NumDoc)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Partita)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AgentiProvvigioni>(entity =>
        {
            entity.ToTable("AgentiProvvigioni");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Agente)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Anno)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodArt)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodDoc)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.DataDoc).HasColumnType("datetime");
            entity.Property(e => e.DataScad).HasColumnType("datetime");
            entity.Property(e => e.Denom)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.NumDoc)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Partita)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Antivirus>(entity =>
        {
            entity.ToTable("Antivirus");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Cap)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Citta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodiceAntivirus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodiceKing)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IDmarca).HasColumnName("iDMarca");
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.Importo).HasDefaultValue(0.0);
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.Postazioni).HasDefaultValue(0);
            entity.Property(e => e.Pr)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Tel2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AntivirusMarche>(entity =>
        {
            entity.ToTable("AntivirusMarche");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Antivirus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.P1).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<Apparati>(entity =>
        {
            entity.ToTable("Apparati");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Apparato)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.IndirizzoIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IndirizzoIP");
            entity.Property(e => e.LuogoApparato)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.TipoNavigation).WithMany(p => p.Apparatis)
                .HasForeignKey(d => d.Tipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Apparati_ApparatiTipi");
        });

        modelBuilder.Entity<ApparatiAbilitazioni>(entity =>
        {
            entity.ToTable("ApparatiAbilitazioni");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");

            entity.HasOne(d => d.IDutenteNavigation).WithMany(p => p.ApparatiAbilitazionis)
                .HasForeignKey(d => d.IDutente)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ApparatiAbilitazioni_Utenti");
        });

        modelBuilder.Entity<ApparatiTipi>(entity =>
        {
            entity.ToTable("ApparatiTipi");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ArticoliDaEscludere>(entity =>
        {
            entity.ToTable("ArticoliDaEscludere");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.ArticoloSuKing)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ArticoloSuKIng");
        });

        modelBuilder.Entity<ArticoliProvvigioni>(entity =>
        {
            entity.HasKey(e => e.CodArt);

            entity.ToTable("ArticoliProvvigioni");

            entity.Property(e => e.CodArt)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
        });

        modelBuilder.Entity<Automatismi>(entity =>
        {
            entity.ToTable("Automatismi");

            entity.Property(e => e.AziendaKing)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodIva)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodIvaSpesePostali)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.ContoRicavo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ContrattiSuKong).HasDefaultValue(false);
            entity.Property(e => e.ContrattoScaduto).HasMaxLength(50);
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.DisdettaSuUsermanKing)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GetAllUsername)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("getAllUsername");
            entity.Property(e => e.GetProfileUsername)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("getProfileUsername");
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.IndirizzoServerSmtp)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("IndirizzoServerSMTP");
            entity.Property(e => e.MsgContratto).HasMaxLength(200);
            entity.Property(e => e.MsgRitardo).HasMaxLength(200);
            entity.Property(e => e.NomeLog).HasMaxLength(50);
            entity.Property(e => e.NomeSms)
                .HasMaxLength(50)
                .HasColumnName("NomeSMS");
            entity.Property(e => e.NomeUtenteSmtp)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NomeUtenteSMTP");
            entity.Property(e => e.PasswordSmtp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PasswordSMTP");
            entity.Property(e => e.Porta).HasDefaultValue(0);
            entity.Property(e => e.Psenza)
                .HasMaxLength(50)
                .HasColumnName("PSenza");
            entity.Property(e => e.PwdSms)
                .HasMaxLength(50)
                .HasColumnName("PwdSMS");
            entity.Property(e => e.PwdSmsapi)
                .HasMaxLength(50)
                .HasColumnName("PwdSMSAPI");
            entity.Property(e => e.RicaricabiliDatabase).HasMaxLength(50);
            entity.Property(e => e.RicaricabiliPassword).HasMaxLength(50);
            entity.Property(e => e.RicaricabiliServer).HasMaxLength(50);
            entity.Property(e => e.RicaricabiliUser).HasMaxLength(50);
            entity.Property(e => e.SetProfileUsername)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("setProfileUsername");
            entity.Property(e => e.Sospeso).HasMaxLength(50);
            entity.Property(e => e.Tlssmtp)
                .HasDefaultValue(false)
                .HasColumnName("TLSSMTP");
            entity.Property(e => e.UserSms)
                .HasMaxLength(50)
                .HasColumnName("UserSMS");
            entity.Property(e => e.UserSmsapi)
                .HasMaxLength(50)
                .HasColumnName("UserSMSAPI");
        });

        modelBuilder.Entity<Clienti>(entity =>
        {
            entity.HasKey(e => e.CodCli);

            entity.ToTable("Clienti");

            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
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

        modelBuilder.Entity<ClientiTelefono>(entity =>
        {
            entity.ToTable("ClientiTelefono");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Cellulare)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CellulareSms)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CellulareSMS");
            entity.Property(e => e.CodCli).HasMaxLength(10);
            entity.Property(e => e.Denom).HasMaxLength(60);
            entity.Property(e => e.Tel)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Tel2)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Comuni>(entity =>
        {
            entity.HasKey(e => e.CodiceComune);

            entity.ToTable("Comuni");

            entity.Property(e => e.CodiceComune)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cap)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Comune)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Provincia)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Contratti>(entity =>
        {
            entity.HasKey(e => e.IdContratto).HasName("PK_Contratti_1");

            entity.ToTable("Contratti");

            entity.Property(e => e.IdContratto)
                .HasMaxLength(10)
                .IsUnicode(false);
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
            entity.Property(e => e.FlagAmmSuContr).HasDefaultValue(false);
            entity.Property(e => e.FlagAssEnteIsp).HasDefaultValue(false);
            entity.Property(e => e.FlagChFermoImp).HasDefaultValue(false);
            entity.Property(e => e.FlagFattRich).HasDefaultValue(false);
            entity.Property(e => e.FlagIntr).HasDefaultValue(false);
            entity.Property(e => e.FlagManGrat).HasDefaultValue(false);
            entity.Property(e => e.FlagRateo).HasDefaultValue(false);
            entity.Property(e => e.FlagRepCompl).HasDefaultValue(false);
            entity.Property(e => e.FlagRinegoz).HasDefaultValue(false);
            entity.Property(e => e.FlagSim)
                .HasDefaultValue(false)
                .HasColumnName("FlagSIM");
            entity.Property(e => e.FlagVoceFatt).HasDefaultValue(false);
            entity.Property(e => e.Fstato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FStato");
            entity.Property(e => e.GruAum)
                .HasMaxLength(4)
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
            entity.Property(e => e.URicaricabile)
                .HasDefaultValue(false)
                .HasColumnName("U_Ricaricabile");
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

        modelBuilder.Entity<ContrattiArticoli>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Profili");

            entity.ToTable("ContrattiArticoli");

            entity.Property(e => e.ArticoloKing).HasDefaultValue(false);
            entity.Property(e => e.AttivazioneSo).HasColumnName("AttivazioneSO");
            entity.Property(e => e.CodArt)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodIva)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ContoRicavo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IDcontratto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("iDContratto");
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.ISnoleggio).HasColumnName("iSNoleggio");
            entity.Property(e => e.Importo).HasDefaultValue(0.0);
            entity.Property(e => e.Misura)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Prezzo).HasDefaultValue(0.0);
            entity.Property(e => e.PrezzoAnnuale).HasDefaultValue(0.0);
            entity.Property(e => e.PrezzoAnnualeSo).HasColumnName("PrezzoAnnualeSO");
            entity.Property(e => e.Qta).HasDefaultValue(0.0);

            entity.HasOne(d => d.IDcontrattoNavigation).WithMany(p => p.ContrattiArticolis)
                .HasForeignKey(d => d.IDcontratto)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ContrattiArticoli_Contratti");
        });

        modelBuilder.Entity<ContrattiAttivazioni>(entity =>
        {
            entity.ToTable("ContrattiAttivazioni");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.IdContratto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idContratto");
            entity.Property(e => e.Importo).HasDefaultValue(0.0);
            entity.Property(e => e.Ricorrente).HasDefaultValue(false);
            entity.Property(e => e.SuPrimaRata).HasDefaultValue(false);
        });

        modelBuilder.Entity<ContrattiNon>(entity =>
        {
            entity.ToTable("ContrattiNON");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.AnnoScad)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DataDecIniz).HasColumnType("datetime");
            entity.Property(e => e.DataFine).HasColumnType("datetime");
            entity.Property(e => e.DataInizio).HasColumnType("datetime");
            entity.Property(e => e.DataMov).HasColumnType("datetime");
            entity.Property(e => e.DataScad).HasColumnType("datetime");
            entity.Property(e => e.DataScadFin).HasColumnType("datetime");
            entity.Property(e => e.Denom)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.EsComp)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Fstato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FStato");
            entity.Property(e => e.IdContratto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MeseScad)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Nfatt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NFatt");
            entity.Property(e => e.TipoContr)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ContrattiOld>(entity =>
        {
            entity.HasKey(e => e.IDcontratto).HasName("PK_Contratti");

            entity.ToTable("ContrattiOLD");

            entity.Property(e => e.IDcontratto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("iDContratto");
            entity.Property(e => e.CodBanca)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodDoc)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CodPag)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Denom)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.DescrizioneSconto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FlagConsumi).HasDefaultValue(false);
            entity.Property(e => e.IDtipo).HasColumnName("iDTipo");
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.Note).IsUnicode(false);
            entity.Property(e => e.NoteInterne).IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ContrattiPerKong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ContrattiPerKong");

            entity.Property(e => e.CodBanca)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodPag)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.DataDec).HasColumnType("datetime");
            entity.Property(e => e.DataDisdetta).HasColumnType("datetime");
            entity.Property(e => e.DataInSosp).HasColumnType("datetime");
            entity.Property(e => e.DataScad).HasColumnType("datetime");
            entity.Property(e => e.DataStip).HasColumnType("datetime");
            entity.Property(e => e.Fstato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FStato");
            entity.Property(e => e.IdContratto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.TipoContr)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ContrattiProfili>(entity =>
        {
            entity.ToTable("ContrattiProfili");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Attivazione).HasDefaultValue(0.0);
            entity.Property(e => e.AttivazioneSo)
                .HasDefaultValue(0.0)
                .HasColumnName("AttivazioneSO");
            entity.Property(e => e.Attivo).HasDefaultValue(true);
            entity.Property(e => e.CodIva)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Codice)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ContoRicavo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdUtente).HasColumnName("idUtente");
            entity.Property(e => e.IsNoleggio)
                .HasDefaultValue(false)
                .HasColumnName("isNoleggio");
            entity.Property(e => e.PrezzoAnnuale).HasDefaultValue(0.0);
            entity.Property(e => e.PrezzoAnnualeSo)
                .HasDefaultValue(0.0)
                .HasColumnName("PrezzoAnnualeSO");
            entity.Property(e => e.Profilo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ricaricabile).HasDefaultValue(false);
        });

        modelBuilder.Entity<ContrattiRateOld>(entity =>
        {
            entity.HasKey(e => e.IDcontratto).HasName("PK_ContrattiRate");

            entity.ToTable("ContrattiRateOLD");

            entity.Property(e => e.IDcontratto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("iDContratto");
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.Importo1).HasDefaultValue(0.0);
            entity.Property(e => e.Importo10).HasDefaultValue(0.0);
            entity.Property(e => e.Importo11).HasDefaultValue(0.0);
            entity.Property(e => e.Importo12).HasDefaultValue(0.0);
            entity.Property(e => e.Importo2).HasDefaultValue(0.0);
            entity.Property(e => e.Importo3).HasDefaultValue(0.0);
            entity.Property(e => e.Importo4).HasDefaultValue(0.0);
            entity.Property(e => e.Importo5).HasDefaultValue(0.0);
            entity.Property(e => e.Importo6).HasDefaultValue(0.0);
            entity.Property(e => e.Importo7).HasDefaultValue(0.0);
            entity.Property(e => e.Importo8).HasDefaultValue(0.0);
            entity.Property(e => e.Importo9).HasDefaultValue(0.0);
            entity.Property(e => e.NMesi1).HasColumnName("nMesi1");
            entity.Property(e => e.NMesi10).HasColumnName("nMesi10");
            entity.Property(e => e.NMesi11).HasColumnName("nMesi11");
            entity.Property(e => e.NMesi12).HasColumnName("nMesi12");
            entity.Property(e => e.NMesi2).HasColumnName("nMesi2");
            entity.Property(e => e.NMesi3).HasColumnName("nMesi3");
            entity.Property(e => e.NMesi4).HasColumnName("nMesi4");
            entity.Property(e => e.NMesi5).HasColumnName("nMesi5");
            entity.Property(e => e.NMesi6).HasColumnName("nMesi6");
            entity.Property(e => e.NMesi7).HasColumnName("nMesi7");
            entity.Property(e => e.NMesi8).HasColumnName("nMesi8");
            entity.Property(e => e.NMesi9).HasColumnName("nMesi9");
            entity.Property(e => e.Rata1).HasDefaultValue(false);
            entity.Property(e => e.Rata10).HasDefaultValue(false);
            entity.Property(e => e.Rata11).HasDefaultValue(false);
            entity.Property(e => e.Rata12).HasDefaultValue(false);
            entity.Property(e => e.Rata2).HasDefaultValue(false);
            entity.Property(e => e.Rata3).HasDefaultValue(false);
            entity.Property(e => e.Rata4).HasDefaultValue(false);
            entity.Property(e => e.Rata5).HasDefaultValue(false);
            entity.Property(e => e.Rata6).HasDefaultValue(false);
            entity.Property(e => e.Rata7).HasDefaultValue(false);
            entity.Property(e => e.Rata8).HasDefaultValue(false);
            entity.Property(e => e.Rata9).HasDefaultValue(false);

            entity.HasOne(d => d.IDcontrattoNavigation).WithOne(p => p.ContrattiRateOld)
                .HasForeignKey<ContrattiRateOld>(d => d.IDcontratto)
                .HasConstraintName("FK_ContrattiRate_Contratti1");
        });

        modelBuilder.Entity<ContrattiScadenze>(entity =>
        {
            entity.HasKey(e => e.IDscadenza);

            entity.ToTable("ContrattiScadenze");

            entity.Property(e => e.IDscadenza).HasColumnName("iDScadenza");
            entity.Property(e => e.CodArt)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IDcontratto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("iDContratto");
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.NumeroFattura)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RigaManuale).HasDefaultValue(false);

            entity.HasOne(d => d.IDcontrattoNavigation).WithMany(p => p.ContrattiScadenzes)
                .HasForeignKey(d => d.IDcontratto)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ContrattiScadenze_Contratti");
        });

        modelBuilder.Entity<ContrattiTipi>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_ContrattiTipi_1");

            entity.ToTable("ContrattiTipi");

            entity.HasIndex(e => e.Codice, "ak_Codice").IsUnique();

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Codice)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Connessione)
                .HasDefaultValue(false)
                .HasComment("True se è una connessione");
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FlagConsumi).HasComment("Se il contratto prevede dei consumi");
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
        });

        modelBuilder.Entity<ContrattiTipiFatturazione>(entity =>
        {
            entity.ToTable("ContrattiTipiFatturazione");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.Mesi).HasDefaultValue(0);
            entity.Property(e => e.Posticipata).HasDefaultValue(false);
        });

        modelBuilder.Entity<Eccezioni>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Eccezioni");

            entity.Property(e => e.Codice)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Contratto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.Data1).HasColumnType("datetime");
            entity.Property(e => e.Data2).HasColumnType("datetime");
            entity.Property(e => e.DataOperazione).HasColumnType("datetime");
            entity.Property(e => e.Denominazione)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.InvioSms).HasColumnName("InvioSMS");
            entity.Property(e => e.ProcessatoMsg).HasColumnName("ProcessatoMSG");
            entity.Property(e => e.ProfiloAttuale)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProfiloFuturo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UserMan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Utente)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Foglio1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Foglio1$");

            entity.Property(e => e.Apn)
                .HasMaxLength(255)
                .HasColumnName("APN");
            entity.Property(e => e.Attiva).HasMaxLength(255);
            entity.Property(e => e.Dismessa).HasMaxLength(255);
            entity.Property(e => e.Fornitore).HasMaxLength(255);
            entity.Property(e => e.Imei)
                .HasMaxLength(255)
                .HasColumnName("IMEI");
            entity.Property(e => e.InMagazzino).HasMaxLength(255);
            entity.Property(e => e.Puk)
                .HasMaxLength(255)
                .HasColumnName("PUK");
            entity.Property(e => e.RiferimentoOperatore).HasMaxLength(255);
            entity.Property(e => e.Telefono).HasMaxLength(255);
            entity.Property(e => e.TipoAbbonamento).HasMaxLength(255);
            entity.Property(e => e.Utente).HasMaxLength(255);
        });

        modelBuilder.Entity<LivelliPassword>(entity =>
        {
            entity.HasKey(e => e.Codice);

            entity.ToTable("LivelliPassword");

            entity.Property(e => e.Codice).ValueGeneratedNever();
            entity.Property(e => e.Descrizione).IsUnicode(false);
        });

        modelBuilder.Entity<Messaggi>(entity =>
        {
            entity.ToTable("Messaggi");

            entity.Property(e => e.Codice).HasMaxLength(10);
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Denom).HasMaxLength(60);
            entity.Property(e => e.IDoperazionePianificata).HasColumnName("iDOperazionePianificata");
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.IdSms)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Id_Sms");
            entity.Property(e => e.Numero)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.StatusDetail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoMessaggio)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IDoperazionePianificataNavigation).WithMany(p => p.Messaggis)
                .HasForeignKey(d => d.IDoperazionePianificata)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Messaggi_OperazioniPianificate");
        });

        modelBuilder.Entity<MessaggiDefinizione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MessaggiDefinizione_1");

            entity.ToTable("MessaggiDefinizione");

            entity.Property(e => e.Descrizione)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Messaggio).HasMaxLength(320);
            entity.Property(e => e.Parametro1)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Parametro2)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Parametro3)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Operazioni>(entity =>
        {
            entity.ToTable("Operazioni");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.IDoperazionePianificata).HasColumnName("iDOperazionePianificata");
            entity.Property(e => e.Profilo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserMan)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IDoperazionePianificataNavigation).WithMany(p => p.Operazionis)
                .HasForeignKey(d => d.IDoperazionePianificata)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Operazioni_OperazioniPianificate");
        });

        modelBuilder.Entity<OperazioniPianificate>(entity =>
        {
            entity.ToTable("OperazioniPianificate");

            entity.Property(e => e.Codice)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Contratto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DataFine).HasColumnType("datetime");
            entity.Property(e => e.DataInizio).HasColumnType("datetime");
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.DataOperazione).HasColumnType("datetime");
            entity.Property(e => e.Denominazione)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.InvioSms).HasColumnName("InvioSMS");
            entity.Property(e => e.Messaggio2)
                .HasMaxLength(320)
                .IsUnicode(false);
            entity.Property(e => e.ProfiloAttuale)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProfiloFuturo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.UserMan)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OperazioniPianificateStorico>(entity =>
        {
            entity.ToTable("OperazioniPianificateStorico");

            entity.Property(e => e.Codice)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Contratto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DataFine).HasColumnType("datetime");
            entity.Property(e => e.DataInizio).HasColumnType("datetime");
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.DataOperazione).HasColumnType("datetime");
            entity.Property(e => e.DataPassaggioStorico).HasColumnType("datetime");
            entity.Property(e => e.Denominazione)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.InvioSms).HasColumnName("InvioSMS");
            entity.Property(e => e.Messaggio2)
                .HasMaxLength(320)
                .IsUnicode(false);
            entity.Property(e => e.ProfiloAttuale)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProfiloFuturo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TipoOperazione).HasComment("0-Cambio Profilo 1-Disdetta contratto 2-Riattivazione dopo pagamento 3-Disattivazione moroso");
            entity.Property(e => e.UserMan)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pagamento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pagamento");

            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.DataFattura).HasMaxLength(255);
            entity.Property(e => e.IdContratto).HasMaxLength(255);
            entity.Property(e => e.Idpagamento).HasColumnName("IDPagamento");
            entity.Property(e => e.NumeroFattura).HasMaxLength(255);
            entity.Property(e => e.PayerId)
                .HasMaxLength(255)
                .HasColumnName("PayerID");
            entity.Property(e => e.PaymentiId)
                .HasMaxLength(255)
                .HasColumnName("PaymentiID");
            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.Scadenza).HasColumnType("datetime");
            entity.Property(e => e.Token).HasMaxLength(255);
        });

        modelBuilder.Entity<PartiteAperte>(entity =>
        {
            entity.ToTable("PartiteAperte");

            entity.Property(e => e.Codice)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DataDoc).HasColumnType("datetime");
            entity.Property(e => e.DataScad).HasColumnType("datetime");
            entity.Property(e => e.Denom).HasMaxLength(60);
            entity.Property(e => e.Partita)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Prodotti>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("prodotti");

            entity.Property(e => e.Durata).HasColumnName("durata");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Immagine)
                .HasMaxLength(255)
                .HasColumnName("immagine");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .HasColumnName("nome");
            entity.Property(e => e.Prezzo).HasColumnName("prezzo");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TipoContratto).HasMaxLength(255);
        });

        modelBuilder.Entity<ProfiliKing>(entity =>
        {
            entity.ToTable("ProfiliKing");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.ArtMag)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Denom)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.DescrAgg)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fstato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FStato");
            entity.Property(e => e.IdContratto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoContr)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.URicaricabile)
                .HasDefaultValue(false)
                .HasColumnName("U_Ricaricabile");
            entity.Property(e => e.UUserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_UserName");
        });

        modelBuilder.Entity<ProfiliKingTemp>(entity =>
        {
            entity.ToTable("ProfiliKingTemp");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.ActualProfile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ArtMag)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Comment)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Denom)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.DescrAgg)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fstato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FStato");
            entity.Property(e => e.IdContratto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoContr)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.URicaricabile).HasColumnName("U_Ricaricabile");
            entity.Property(e => e.UUserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("U_UserName");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProfiliUtentiTutti>(entity =>
        {
            entity.ToTable("ProfiliUtentiTutti");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.ActualProfile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comment)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ricaricabili>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ricaricabili");

            entity.Property(e => e.CodCli).HasMaxLength(255);
            entity.Property(e => e.DataContratto).HasColumnType("datetime");
            entity.Property(e => e.IdContratto).HasMaxLength(255);
            entity.Property(e => e.Scadenza).HasColumnType("datetime");
            entity.Property(e => e.TipoContratto).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(255);
        });

        modelBuilder.Entity<SchedeSim>(entity =>
        {
            entity.ToTable("SchedeSim");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Apn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APN");
            entity.Property(e => e.Fornitore)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Imei)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMEI");
            entity.Property(e => e.Puk)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RiferimentoOperatore)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoAbbonamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Utente)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SchedeSimFatture>(entity =>
        {
            entity.ToTable("SchedeSimFatture");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.IDscheda).HasColumnName("iDScheda");
            entity.Property(e => e.NumeroFattura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Periodo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IDschedaNavigation).WithMany(p => p.SchedeSimFattures)
                .HasForeignKey(d => d.IDscheda)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SchedeSimFatture_SchedeSim");
        });

        modelBuilder.Entity<Sconti>(entity =>
        {
            entity.ToTable("Sconti");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.ScontoDurata).HasDefaultValue(0.0);
            entity.Property(e => e.ScontoDurata1).HasDefaultValue(0.0);
            entity.Property(e => e.ScontoDurata2).HasDefaultValue(0.0);
            entity.Property(e => e.ScontoDurata3).HasDefaultValue(0.0);
            entity.Property(e => e.ScontoPagamento).HasDefaultValue(0.0);
            entity.Property(e => e.ScontoUnicaSoluzione).HasDefaultValue(0.0);
            entity.Property(e => e.TipoPagamento)
                .HasDefaultValue(false)
                .HasComment("0-Bonifico o Contanti 1-RID o Carta di credito");
            entity.Property(e => e.UnicaSoluzione)
                .HasDefaultValue(false)
                .HasComment("False = non unica soluzione True=Unica Soluzione");
        });

        modelBuilder.Entity<Sm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SmsDaInviare");

            entity.Property(e => e.Codice).HasMaxLength(10);
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Denom).HasMaxLength(60);
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.IdSms)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Id_Sms");
            entity.Property(e => e.Numero)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.StatusDetail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoMessaggio)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Smsstorico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SMSInviati_1");

            entity.ToTable("SMSStorico");

            entity.Property(e => e.Codice).HasMaxLength(10);
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.DataModifica).HasColumnType("datetime");
            entity.Property(e => e.Denom).HasMaxLength(60);
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.IdSms)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Id_Sms");
            entity.Property(e => e.Numero)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.StatusDetail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoMessaggio)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SommaImportoChiamate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sommaImportoChiamate");

            entity.Property(e => e.Cf)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("CF");
            entity.Property(e => e.CodCli)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Datadisdetta)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("datadisdetta");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Portabilita)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("portabilita");
            entity.Property(e => e.Spese).HasColumnName("spese");
            entity.Property(e => e.Voip)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("voip");
        });

        modelBuilder.Entity<TipiContrattiRicaricabili>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TipiContrattiRicaricabili");

            entity.Property(e => e.Codice)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ID).HasColumnName("iD");
        });

        modelBuilder.Entity<TipiOperazione>(entity =>
        {
            entity.ToTable("TipiOperazione");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tmptabella>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptabella");

            entity.Property(e => e.Cf)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CF");
            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Cognome)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.ComuneDomicilio)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Costi).HasColumnName("costi");
            entity.Property(e => e.Datadisdetta)
                .HasMaxLength(4000)
                .HasColumnName("datadisdetta");
            entity.Property(e => e.Datainizio)
                .HasMaxLength(4000)
                .HasColumnName("datainizio");
            entity.Property(e => e.Denominazione)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("denominazione");
            entity.Property(e => e.DtNascita).HasMaxLength(8);
            entity.Property(e => e.IdContratto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idContratto");
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("indirizzo");
            entity.Property(e => e.Luogodinascita)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("luogodinascita");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.NumeroFinale).HasMaxLength(20);
            entity.Property(e => e.NumeroIniziale).HasMaxLength(20);
            entity.Property(e => e.Piva)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("PIva");
            entity.Property(e => e.Prov)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("prov");
            entity.Property(e => e.Sesso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sesso");
            entity.Property(e => e.SiglaComuneDomicilio)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Utenti>(entity =>
        {
            entity.ToTable("Utenti");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Administrator).HasDefaultValue(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Esercizio).HasDefaultValue((byte)0);
            entity.Property(e => e.IsActive)
                .HasDefaultValue(false)
                .HasColumnName("isActive");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PasswordSenzaScadenza).HasDefaultValue(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UtentiAbilitazioni>(entity =>
        {
            entity.ToTable("UtentiAbilitazioni");

            entity.Property(e => e.Abilitazione).HasDefaultValue((byte)0);
            entity.Property(e => e.IDfunzione).HasColumnName("iDFunzione");
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
        });

        modelBuilder.Entity<UtentiAccesso>(entity =>
        {
            entity.HasKey(e => e.IDaccesso);

            entity.ToTable("UtentiAccesso");

            entity.Property(e => e.IDaccesso).HasColumnName("iDAccesso");
            entity.Property(e => e.DataAccesso).HasColumnType("datetime");
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");

            entity.HasOne(d => d.IDutenteNavigation).WithMany(p => p.UtentiAccessos)
                .HasForeignKey(d => d.IDutente)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UtentiAccesso_Utenti");
        });

        modelBuilder.Entity<UtentiFunzioni>(entity =>
        {
            entity.ToTable("UtentiFunzioni");

            entity.Property(e => e.Descrizione).HasMaxLength(255);
            entity.Property(e => e.Funzione).HasMaxLength(50);
        });

        modelBuilder.Entity<UtentiPassword>(entity =>
        {
            entity.ToTable("UtentiPassword");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IDutenteNavigation).WithMany(p => p.UtentiPasswords)
                .HasForeignKey(d => d.IDutente)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UtentiPassword_Utenti");
        });

        modelBuilder.Entity<VoiPautomatismi>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_VoipAutomatismi");

            entity.ToTable("VoiPAutomatismi");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.LunghezzaPrefisso).HasDefaultValue(0);
        });

        modelBuilder.Entity<VoiPcliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VoiPCliente");

            entity.Property(e => e.Datadisdetta).HasColumnName("datadisdetta");
            entity.Property(e => e.Datainizio).HasColumnName("datainizio");
            entity.Property(e => e.Dataport).HasColumnName("dataport");
            entity.Property(e => e.Fatturazione).HasColumnName("fatturazione");
            entity.Property(e => e.Id)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Lastdata).HasColumnName("lastdata");
            entity.Property(e => e.Migrazione).HasColumnName("migrazione");
            entity.Property(e => e.Migrazioneport).HasColumnName("migrazioneport");
            entity.Property(e => e.Nome).HasColumnName("nome");
            entity.Property(e => e.Offerta).HasColumnName("offerta");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Portabilita)
                .HasMaxLength(50)
                .HasColumnName("portabilita");
            entity.Property(e => e.Seriale).HasColumnName("seriale");
            entity.Property(e => e.Stato).HasColumnName("stato");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
            entity.Property(e => e.Voip)
                .HasMaxLength(50)
                .HasColumnName("voip");
        });

        modelBuilder.Entity<VoiPcontratti>(entity =>
        {
            entity.HasKey(e => e.IdContratto).HasName("PK_VoIPContratti");

            entity.ToTable("VoiPContratti");

            entity.Property(e => e.IdContratto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idContratto");
            entity.Property(e => e.AdeguamentoIstat).HasDefaultValue(false);
            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Datadisdetta).HasColumnName("datadisdetta");
            entity.Property(e => e.Datainizio).HasColumnName("datainizio");
            entity.Property(e => e.Dataport).HasColumnName("dataport");
            entity.Property(e => e.Fatturazione).HasColumnName("fatturazione");
            entity.Property(e => e.Lastdata).HasColumnName("lastdata");
            entity.Property(e => e.Migrazione)
                .HasMaxLength(20)
                .HasColumnName("migrazione");
            entity.Property(e => e.Migrazioneport)
                .HasMaxLength(20)
                .HasColumnName("migrazioneport");
            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Offerta)
                .HasDefaultValue(0)
                .HasColumnName("offerta");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Portabilita)
                .HasMaxLength(20)
                .HasColumnName("portabilita");
            entity.Property(e => e.Sconto).HasDefaultValue(0.0);
            entity.Property(e => e.Seriale)
                .HasMaxLength(50)
                .HasColumnName("seriale");
            entity.Property(e => e.Stato)
                .HasDefaultValue(false)
                .HasColumnName("stato");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
            entity.Property(e => e.Voip)
                .HasMaxLength(20)
                .HasColumnName("voip");
        });

        modelBuilder.Entity<VoiPcontrattiCanoni>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_VContrattiCanoni");

            entity.ToTable("VoiPContrattiCanoni");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Attivo).HasDefaultValue(false);
            entity.Property(e => e.CanoneAnnuo).HasDefaultValue(0.0);
            entity.Property(e => e.IdContratto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idContratto");
            entity.Property(e => e.MesiFatturazione).HasDefaultValue(0);
        });

        modelBuilder.Entity<VoiPdettaglioStorico>(entity =>
        {
            entity.ToTable("VoiPDettaglioStorico");

            entity.Property(e => e.ID).HasColumnName("iD");
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
            entity.Property(e => e.IDutente).HasColumnName("iDUtente");
            entity.Property(e => e.Importo).HasColumnName("importo");
            entity.Property(e => e.Ntipo).HasColumnName("NTipo");
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

        modelBuilder.Entity<VoiPdettaglioTemp>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_VoIPDettaglioTemp");

            entity.ToTable("VoiPDettaglioTemp");

            entity.Property(e => e.ID).HasColumnName("iD");
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
            entity.Property(e => e.Ntipo).HasColumnName("NTipo");
            entity.Property(e => e.Orachiamata)
                .HasMaxLength(50)
                .HasColumnName("orachiamata");
            entity.Property(e => e.Prefisso)
                .HasMaxLength(50)
                .HasColumnName("prefisso");
            entity.Property(e => e.Spesa).HasColumnName("spesa");
        });

        modelBuilder.Entity<VoiPdettaglioold>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_VoIPdettaglio");

            entity.ToTable("VoiPdettaglioold");

            entity.Property(e => e.ID).HasColumnName("iD");
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
            entity.Property(e => e.Ntipo).HasColumnName("NTipo");
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

        modelBuilder.Entity<VoiPnazioni>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_VoIPNazioni");

            entity.ToTable("VoiPNazioni");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Stato)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VoiPnumerovoip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VoIPNumerovoip");

            entity.ToTable("VoiPNumerovoip");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Denom)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.IDcontratto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("iDContratto");
            entity.Property(e => e.IDofferta).HasColumnName("iDOfferta");
            entity.Property(e => e.Migrazione).HasMaxLength(50);
            entity.Property(e => e.Migrazioneoperatore).HasMaxLength(50);
            entity.Property(e => e.Note).IsUnicode(false);
            entity.Property(e => e.Numeroportato).HasMaxLength(50);
            entity.Property(e => e.Numerovoip).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Seriale).HasMaxLength(50);
            entity.Property(e => e.Tipo).HasMaxLength(50);
        });

        modelBuilder.Entity<VoiPofferte>(entity =>
        {
            entity.HasKey(e => e.Idofferta).HasName("PK_VoIPofferta");

            entity.ToTable("VoiPofferte");

            entity.Property(e => e.Idofferta).HasColumnName("idofferta");
            entity.Property(e => e.AllInclusive).HasDefaultValue(false);
            entity.Property(e => e.CanoneMensile).HasDefaultValue(0.0);
            entity.Property(e => e.CostoVfissi).HasColumnName("CostoVFissi");
            entity.Property(e => e.CostoVmobili).HasColumnName("CostoVMobili");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Minfisso).HasDefaultValue(0);
            entity.Property(e => e.Minmobile).HasDefaultValue(0);
            entity.Property(e => e.Note).IsUnicode(false);
            entity.Property(e => e.Scatto).HasDefaultValue(false);
        });

        modelBuilder.Entity<VoiPprefissi>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_VoIPprefissi");

            entity.ToTable("VoiPprefissi");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Costo).HasColumnName("costo");
            entity.Property(e => e.IDnazione).HasColumnName("iDNazione");
            entity.Property(e => e.Prefisso)
                .HasMaxLength(50)
                .HasColumnName("prefisso");
            entity.Property(e => e.Scatto).HasColumnName("scatto");
            entity.Property(e => e.Stato)
                .HasMaxLength(50)
                .HasColumnName("stato");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
        });

        modelBuilder.Entity<VoiPtipoChiamate>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_VoIPTipoChiamate");

            entity.ToTable("VoiPTipoChiamate");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fisso).HasDefaultValue(false);
            entity.Property(e => e.Prefisso)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RifOfferta).HasDefaultValue(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VoiPtotalefattura>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_VoIPtotalefattura");

            entity.ToTable("VoiPtotalefattura");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Anno)
                .HasMaxLength(50)
                .HasColumnName("anno");
            entity.Property(e => e.Annoultima)
                .HasMaxLength(50)
                .HasColumnName("annoultima");
            entity.Property(e => e.Giorno)
                .HasMaxLength(50)
                .HasColumnName("giorno");
            entity.Property(e => e.Giornoultima)
                .HasMaxLength(50)
                .HasColumnName("giornoultima");
            entity.Property(e => e.Idvoip)
                .HasMaxLength(50)
                .HasColumnName("idvoip");
            entity.Property(e => e.Mese)
                .HasMaxLength(50)
                .HasColumnName("mese");
            entity.Property(e => e.Meseultima)
                .HasMaxLength(50)
                .HasColumnName("meseultima");
            entity.Property(e => e.Totale).HasColumnName("totale");
        });

        modelBuilder.Entity<VoiPufficio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VoiPUFFI__3213E83F7E912710");

            entity.ToTable("VoiPUFFICIO");

            entity.Property(e => e.Id).HasColumnName("id");
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
            entity.Property(e => e.Fatturato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FATTURATO");
            entity.Property(e => e.Filler)
                .HasMaxLength(1456)
                .IsUnicode(false)
                .HasColumnName("FILLER");
            entity.Property(e => e.Indirizzo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("INDIRIZZO");
            entity.Property(e => e.Lunghezzafatturato)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("LUNGHEZZAFATTURATO");
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

        modelBuilder.Entity<Voipdettaglio>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_Voipdettaglio_1");

            entity.ToTable("Voipdettaglio");

            entity.Property(e => e.ID).HasColumnName("iD");
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
            entity.Property(e => e.Ntipo).HasColumnName("NTipo");
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

        modelBuilder.Entity<_1Fonti>(entity =>
        {
            entity.HasKey(e => e.IDfonte);

            entity.ToTable("1_fonti");

            entity.Property(e => e.IDfonte).HasColumnName("iDFonte");
            entity.Property(e => e.Fonte)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FONTE");
            entity.Property(e => e.Note).HasColumnType("ntext");
        });

        modelBuilder.Entity<_2Gateway>(entity =>
        {
            entity.HasKey(e => e.IDgateway);

            entity.ToTable("2_gateways");

            entity.Property(e => e.IDgateway).HasColumnName("iDGateway");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gateway)
                .HasMaxLength(255)
                .HasColumnName("GATEWAY");
            entity.Property(e => e.IdFonte).HasColumnName("idFonte");
            entity.Property(e => e.Note).HasColumnType("ntext");
        });

        modelBuilder.Entity<_2GatewayBakup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("2_gatewayBakup");

            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gateway)
                .HasMaxLength(255)
                .HasColumnName("GATEWAY");
            entity.Property(e => e.IDgateway).HasColumnName("iDGateway");
            entity.Property(e => e.IdFonte).HasColumnName("idFonte");
            entity.Property(e => e.Note).HasColumnType("ntext");
        });

        modelBuilder.Entity<_3Ponti>(entity =>
        {
            entity.HasKey(e => e.IDponti);

            entity.ToTable("3_ponti");

            entity.Property(e => e.IDponti).HasColumnName("iDPonti");
            entity.Property(e => e.Dipendenza)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdGateway).HasColumnName("idGateway");
            entity.Property(e => e.IdPontePadre).HasColumnName("idPontePadre");
            entity.Property(e => e.Note).HasColumnType("ntext");
            entity.Property(e => e.Ponte)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<_4Pannelli>(entity =>
        {
            entity.HasKey(e => e.IDpannelli);

            entity.ToTable("4_pannelli");

            entity.Property(e => e.IDpannelli).HasColumnName("iDPannelli");
            entity.Property(e => e.IdPonti).HasColumnName("idPonti");
            entity.Property(e => e.Note).HasColumnType("ntext");
            entity.Property(e => e.Pannello)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PANNELLO");
            entity.Property(e => e.Ponte)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PONTE");
        });

        modelBuilder.Entity<_4PannelliBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("4_PannelliBackup");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.IDpannelli).HasColumnName("iDPannelli");
            entity.Property(e => e.IdPonti).HasColumnName("idPonti");
            entity.Property(e => e.Note).HasColumnType("ntext");
            entity.Property(e => e.Pannello)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PANNELLO");
            entity.Property(e => e.Ponte)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PONTE");
        });

        modelBuilder.Entity<_4Tecnologium>(entity =>
        {
            entity.ToTable("4_tecnologia");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.Tecnologia)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<_5ClientiReteBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("5_ClientiReteBackup");

            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Denom)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.IDpannelli).HasColumnName("iDpannelli");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Note).HasColumnType("ntext");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<_5Clientirete>(entity =>
        {
            entity.ToTable("5_Clientirete");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.ActualProfile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodCli)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Denom)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.IDpannelli).HasColumnName("iDpannelli");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Note).IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<_6TabellaEsclusionePannelli>(entity =>
        {
            entity.ToTable("6_TabellaEsclusionePannelli");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
