using System;
using System.Threading.Channels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.SqlServer;
using OneCodeRebs.Models.REBSModels;

#nullable disable

namespace OneCodeRebs.Repository
{
    public partial class REBSContext : DbContext
    {
        public REBSContext()
        {
        }

        public REBSContext(DbContextOptions<REBSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Models.REBSModels.Channel> Channels { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<ContactDetail> ContactDetails { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-CK1QGGA6;Database=REBS;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Models.REBSModels.Channel>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutoReply).HasMaxLength(100);

                entity.Property(e => e.ColorColorColor)
                    .HasMaxLength(100)
                    .HasColumnName("Color\r\n\r\ncolor\r\n\r\nColor");

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NotificationEmail).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(100);

                entity.Property(e => e.ReopenClosedTicketTimeWindowDaysReopenClosedTicketTimeWindowDays).HasColumnName("ReopenClosedTicketTimeWindowDays\r\n\r\nReopenClosedTicketTimeWindowDays");

                entity.Property(e => e.ShowContactFields).HasMaxLength(100);

                entity.Property(e => e.ShowTicketFields).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.Text).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(100);

                entity.HasOne(d => d.Users)
                    .WithMany()
                    .HasForeignKey(d => d.UsersId)
                    .HasConstraintName("FK_Channels_Users");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Abbr)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Notes)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.NotesId)
                    .HasConstraintName("FK_Company_Notes");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Company_Users");
            });

            modelBuilder.Entity<ContactDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Abbr).HasMaxLength(10);

                entity.Property(e => e.Avatar).HasMaxLength(200);

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FormattedPhone).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Identifier).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Pivot).HasMaxLength(100);

                entity.Property(e => e.ProfileImage).HasColumnType("image");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.Note1)
                    .HasMaxLength(200)
                    .HasColumnName("Note");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Notes__UserId__2B3F6F97");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Abbr)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Authorization).HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(25);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(25);

                entity.Property(e => e.LocaleCode).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.ProfileImage).HasColumnType("image");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.Text).HasMaxLength(100);

                entity.Property(e => e.Timezone).HasMaxLength(50);

                entity.Property(e => e.UserStatus).HasMaxLength(20);

                entity.Property(e => e.VoipDevice).HasMaxLength(20);

                entity.Property(e => e.VoipStatus).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
