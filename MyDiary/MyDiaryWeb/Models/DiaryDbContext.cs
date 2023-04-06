using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyDiaryWeb.Models;

public partial class DiaryDbContext : DbContext
{
    public DiaryDbContext()
    {
    }

    public DiaryDbContext(DbContextOptions<DiaryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Content> Contents { get; set; }

    public virtual DbSet<Password> Passwords { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=THANHND\\SQLEXPRESS; Database=DiaryDB;user=sa;password=123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Content>(entity =>
        {
            entity.ToTable("Content");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content1)
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.IsFavorite).HasColumnName("isFavorite");
            entity.Property(e => e.IsSecure).HasColumnName("isSecure");
        });

        modelBuilder.Entity<Password>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Password");

            entity.Property(e => e.Password1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
