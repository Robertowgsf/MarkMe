﻿// <auto-generated />
using System;
using MarkMe.API.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MarkMe.API.Migrations
{
    [DbContext(typeof(MarkMeContext))]
    partial class MarkMeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MarkMe.API.Domain.Categoria", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<long>("TarefaId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TarefaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("MarkMe.API.Domain.Tarefa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Concluida")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataDeEntrega")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<long>("TodoListId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TodoListId");

                    b.ToTable("Tarefas");
                });

            modelBuilder.Entity("MarkMe.API.Domain.TodoList", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TodoLists");
                });

            modelBuilder.Entity("MarkMe.API.Domain.Categoria", b =>
                {
                    b.HasOne("MarkMe.API.Domain.Tarefa", "Tarefa")
                        .WithMany("Categorias")
                        .HasForeignKey("TarefaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarkMe.API.Domain.Tarefa", b =>
                {
                    b.HasOne("MarkMe.API.Domain.TodoList", "TodoList")
                        .WithMany("Tarefas")
                        .HasForeignKey("TodoListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}