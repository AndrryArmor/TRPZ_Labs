﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderingGoods.DataAccessLayer;

namespace OrderingGoods.DataAccessLayer.Migrations
{
    [DbContext(typeof(OrderingGoodsContext))]
    partial class OrderingGoodsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderingGoods.DataAccessLayer.Entities.GoodEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Goods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Дерев'яний дубовий стіл з шухлядками",
                            Manufacturer = "Київмеблі",
                            Model = "Вікторія",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Дерев'яна соснова шафа-купе",
                            Manufacturer = "Київмеблі",
                            Model = "Сергій",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Блакитна футболка розміру XS з принтом в стилі аніме",
                            Manufacturer = "Versacci",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 4,
                            Description = "Червоні шорти розміру L з зображеннями пальм",
                            Manufacturer = "Хмельницький ринок",
                            TypeId = 4
                        },
                        new
                        {
                            Id = 5,
                            Description = "Білі кросівки 37 розміру",
                            Manufacturer = "Reebok",
                            TypeId = 5
                        },
                        new
                        {
                            Id = 6,
                            Description = "Пральна машина з горизонтальним завантаженням 134х109х65",
                            Manufacturer = "Kaiser",
                            Model = "HT3001",
                            TypeId = 6
                        },
                        new
                        {
                            Id = 7,
                            Description = "Мікрохвильова піч з 35 режимами роботи 74х43х50",
                            Manufacturer = "LG",
                            Model = "Profy",
                            TypeId = 7
                        },
                        new
                        {
                            Id = 8,
                            Description = "Ноутбук чорного кольору з діагоналлю 15', 8-ядерним процесором Intel Core i7 і відеокартою nVidia GeForce",
                            Manufacturer = "HP",
                            Model = "ProBook 4540s",
                            TypeId = 8
                        },
                        new
                        {
                            Id = 9,
                            Description = "Смартфон з діагоналлю 6,22', 8-ядерним процесором Snapdragon 632 і NFC",
                            Manufacturer = "Samsung",
                            Model = "Galaxy S10",
                            TypeId = 9
                        },
                        new
                        {
                            Id = 10,
                            Description = "Смартфон з діагоналлю 5,7', 4-ядерним процесором MediaTek 231 і сканером відбитків пальців",
                            Manufacturer = "Xiaomi",
                            Model = "Redmi Note 7A",
                            TypeId = 9
                        },
                        new
                        {
                            Id = 11,
                            Description = "Смартфон з діагоналлю 6,22', 8-ядерним процесором Snapdragon 632, NFC і IRDA",
                            Manufacturer = "Xiaomi",
                            Model = "Redmi Note 8T",
                            TypeId = 9
                        },
                        new
                        {
                            Id = 12,
                            Description = "Фотоапарат з 30х зумом, 50 режимами налаштувань і автофокусом",
                            Manufacturer = "Nikon",
                            Model = "300X",
                            TypeId = 10
                        });
                });

            modelBuilder.Entity("OrderingGoods.DataAccessLayer.Entities.GoodTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GoodTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Стіл"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Шафа"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Футболка"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Шорти"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Кросівки"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Пральна машина"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Мікрохвильова піч"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Ноутбук"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Телефон"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Фотоапарат"
                        });
                });

            modelBuilder.Entity("OrderingGoods.DataAccessLayer.Entities.ItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GoodId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GoodId");

                    b.HasIndex("ShopId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GoodId = 8,
                            Price = 999.89999999999998,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 2,
                            GoodId = 9,
                            Price = 450.0,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 3,
                            GoodId = 10,
                            Price = 325.5,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 4,
                            GoodId = 11,
                            Price = 624.42999999999995,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 5,
                            GoodId = 8,
                            Price = 1099.9000000000001,
                            ShopId = 2
                        },
                        new
                        {
                            Id = 6,
                            GoodId = 9,
                            Price = 400.0,
                            ShopId = 2
                        },
                        new
                        {
                            Id = 7,
                            GoodId = 10,
                            Price = 325.5,
                            ShopId = 2
                        },
                        new
                        {
                            Id = 8,
                            GoodId = 6,
                            Price = 345.0,
                            ShopId = 2
                        },
                        new
                        {
                            Id = 9,
                            GoodId = 7,
                            Price = 63.539999999999999,
                            ShopId = 2
                        },
                        new
                        {
                            Id = 10,
                            GoodId = 1,
                            Price = 36.25,
                            ShopId = 3
                        },
                        new
                        {
                            Id = 11,
                            GoodId = 2,
                            Price = 209.0,
                            ShopId = 3
                        },
                        new
                        {
                            Id = 12,
                            GoodId = 3,
                            Price = 10.119999999999999,
                            ShopId = 4
                        },
                        new
                        {
                            Id = 13,
                            GoodId = 4,
                            Price = 5.7400000000000002,
                            ShopId = 4
                        },
                        new
                        {
                            Id = 14,
                            GoodId = 5,
                            Price = 44.119999999999997,
                            ShopId = 4
                        },
                        new
                        {
                            Id = 15,
                            GoodId = 1,
                            Price = 40.200000000000003,
                            ShopId = 5
                        },
                        new
                        {
                            Id = 16,
                            GoodId = 5,
                            Price = 25.649999999999999,
                            ShopId = 5
                        },
                        new
                        {
                            Id = 17,
                            GoodId = 8,
                            Price = 899.89999999999998,
                            ShopId = 5
                        },
                        new
                        {
                            Id = 18,
                            GoodId = 10,
                            Price = 300.60000000000002,
                            ShopId = 5
                        });
                });

            modelBuilder.Entity("OrderingGoods.DataAccessLayer.Entities.OrderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OrderingGoods.DataAccessLayer.Entities.ShopEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "TechCenter"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Eldorado"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Furniture House"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Second hand"
                        },
                        new
                        {
                            Id = 5,
                            Name = "1000 things"
                        });
                });

            modelBuilder.Entity("OrderingGoods.DataAccessLayer.Entities.GoodEntity", b =>
                {
                    b.HasOne("OrderingGoods.DataAccessLayer.Entities.GoodTypeEntity", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderingGoods.DataAccessLayer.Entities.ItemEntity", b =>
                {
                    b.HasOne("OrderingGoods.DataAccessLayer.Entities.GoodEntity", "Good")
                        .WithMany()
                        .HasForeignKey("GoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderingGoods.DataAccessLayer.Entities.ShopEntity", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderingGoods.DataAccessLayer.Entities.OrderEntity", b =>
                {
                    b.HasOne("OrderingGoods.DataAccessLayer.Entities.ItemEntity", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
