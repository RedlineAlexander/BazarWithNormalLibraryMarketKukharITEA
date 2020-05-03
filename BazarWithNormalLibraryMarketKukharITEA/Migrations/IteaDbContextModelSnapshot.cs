﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using database.BazarWithNormalLibraryMarketKukharITEA;

namespace BazarWithNormalLibraryMarketKukharITEA.Migrations
{
    [DbContext(typeof(IteaDbContext))]
    partial class IteaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BazarWithNormalLibraryMarketKukharITEA.Entities.Buyers", b =>
                {
                    b.Property<int>("BuyersId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BuyersGoodBuy");

                    b.Property<string>("BuyersName");

                    b.Property<int>("Id");

                    b.HasKey("BuyersId");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("BazarWithNormalLibraryMarketKukharITEA.Entities.Consumers", b =>
                {
                    b.Property<int>("ConsumersId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConsumerGood");

                    b.Property<string>("ConsumerName");

                    b.Property<string>("ConsumerPavilyon");

                    b.Property<int>("Id");

                    b.HasKey("ConsumersId");

                    b.HasIndex("Id");

                    b.ToTable("Consumers");
                });

            modelBuilder.Entity("BazarWithNormalLibraryMarketKukharITEA.Entities.Consumers", b =>
                {
                    b.HasOne("BazarWithNormalLibraryMarketKukharITEA.Entities.Buyers")
                        .WithMany("Consumers")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
