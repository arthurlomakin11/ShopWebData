﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopWebData;

namespace ShopWebData.Migrations
{
    [DbContext(typeof(ShopWebContext))]
    [Migration("20210304121357_Migration_41")]
    partial class Migration_41
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ShopWebData.Adress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdressType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Zones")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("ShopWebData.Attribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ArgbColor")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Attributes");
                });

            modelBuilder.Entity("ShopWebData.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeliveryTimeId")
                        .HasColumnType("int");

                    b.Property<bool?>("OperatorViewed")
                        .HasColumnType("bit");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<int?>("ShopAdressId")
                        .HasColumnType("int");

                    b.Property<string>("ShopComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("DeliveryTimeId");

                    b.HasIndex("ShopAdressId");

                    b.HasIndex("ShopId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ShopWebData.CartGift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(7,3)");

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartGifts");
                });

            modelBuilder.Entity("ShopWebData.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(7,3)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(7,3)");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopWebData.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<bool>("ShowText")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ShopWebData.DeliveryTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("CustomTime")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("DeliveryTimes");
                });

            modelBuilder.Entity("ShopWebData.Gift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(7,3)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(7,4)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Gifts");
                });

            modelBuilder.Entity("ShopWebData.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ShopWebData.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Controller")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("HasSubItems")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("SequentialNumber")
                        .HasColumnType("int");

                    b.Property<bool>("ShowDropDown")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowInMenu")
                        .HasColumnType("bit");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("ShopWebData.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextMessage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("ShopWebData.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Countable")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GiftAmount")
                        .HasColumnType("decimal(3,2)");

                    b.Property<bool>("IsGift")
                        .HasColumnType("bit");

                    b.Property<decimal>("MinQuantity")
                        .HasColumnType("decimal(3,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(7,4)");

                    b.Property<bool>("Promotional")
                        .HasColumnType("bit");

                    b.Property<decimal>("QuantityStep")
                        .HasColumnType("decimal(3,2)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ShopWebData.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Key")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("ShopWebData.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapsDirectionsUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapsUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ProcessedManually")
                        .HasColumnType("bit");

                    b.Property<string>("WorkTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("ShopWebData.ShopsAdresses", b =>
                {
                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<int>("AdressId")
                        .HasColumnType("int");

                    b.Property<int>("SequentialNumber")
                        .HasColumnType("int");

                    b.HasKey("ShopId", "AdressId");

                    b.HasIndex("AdressId");

                    b.ToTable("ShopsAdresses");
                });

            modelBuilder.Entity("ShopWebData.Statistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AnonymousUserId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<string>("MenuItemName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MenuItemId");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("ShopWebData.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Fio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsLegalEntity")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsTemporary")
                        .HasColumnType("bit");

                    b.Property<string>("LegalEntityID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("OrganizationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShopAdressId")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PhoneNumber");

                    b.HasIndex("ShopAdressId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ShopWebData.UserAdress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShopAdressId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("ShopAdressId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAdress");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ShopWebData.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ShopWebData.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopWebData.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ShopWebData.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopWebData.Adress", b =>
                {
                    b.HasOne("ShopWebData.Adress", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("ShopWebData.Attribute", b =>
                {
                    b.HasOne("ShopWebData.Product", "Product")
                        .WithMany("Attributes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShopWebData.Cart", b =>
                {
                    b.HasOne("ShopWebData.User", "Buyer")
                        .WithMany("Carts")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopWebData.DeliveryTime", "DeliveryTime")
                        .WithMany()
                        .HasForeignKey("DeliveryTimeId");

                    b.HasOne("ShopWebData.Adress", "ShopAdress")
                        .WithMany()
                        .HasForeignKey("ShopAdressId");

                    b.HasOne("ShopWebData.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId");

                    b.OwnsOne("ShopWebData.DiscountType", "Discount", b1 =>
                        {
                            b1.Property<int>("CartId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<int>("Discount")
                                .HasColumnType("int");

                            b1.Property<decimal>("DiscountAmount")
                                .HasColumnType("decimal(7,4)");

                            b1.HasKey("CartId");

                            b1.ToTable("Carts");

                            b1.WithOwner()
                                .HasForeignKey("CartId");
                        });

                    b.OwnsOne("ShopWebData.Status", "CartStatus", b1 =>
                        {
                            b1.Property<int>("CartId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<DateTime>("CreationDateTime")
                                .HasColumnType("datetime");

                            b1.Property<bool>("Deleted")
                                .HasColumnType("bit");

                            b1.Property<DateTime>("DeletionDateTime")
                                .HasColumnType("datetime");

                            b1.HasKey("CartId");

                            b1.ToTable("Carts");

                            b1.WithOwner()
                                .HasForeignKey("CartId");
                        });

                    b.Navigation("Buyer");

                    b.Navigation("CartStatus")
                        .IsRequired();

                    b.Navigation("DeliveryTime");

                    b.Navigation("Discount");

                    b.Navigation("Shop");

                    b.Navigation("ShopAdress");
                });

            modelBuilder.Entity("ShopWebData.CartGift", b =>
                {
                    b.HasOne("ShopWebData.Cart", "Cart")
                        .WithMany("Gifts")
                        .HasForeignKey("CartId");

                    b.HasOne("ShopWebData.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShopWebData.CartItem", b =>
                {
                    b.HasOne("ShopWebData.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId");

                    b.HasOne("ShopWebData.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.OwnsOne("ShopWebData.DiscountType", "Discount", b1 =>
                        {
                            b1.Property<int>("CartItemId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<int>("Discount")
                                .HasColumnType("int");

                            b1.Property<decimal>("DiscountAmount")
                                .HasColumnType("decimal(7,4)");

                            b1.HasKey("CartItemId");

                            b1.ToTable("CartItems");

                            b1.WithOwner()
                                .HasForeignKey("CartItemId");
                        });

                    b.OwnsOne("ShopWebData.Status", "Status", b1 =>
                        {
                            b1.Property<int>("CartItemId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<DateTime>("CreationDateTime")
                                .HasColumnType("datetime");

                            b1.Property<bool>("Deleted")
                                .HasColumnType("bit");

                            b1.Property<DateTime>("DeletionDateTime")
                                .HasColumnType("datetime");

                            b1.HasKey("CartItemId");

                            b1.ToTable("CartItems");

                            b1.WithOwner()
                                .HasForeignKey("CartItemId");
                        });

                    b.Navigation("Cart");

                    b.Navigation("Discount");

                    b.Navigation("Product");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ShopWebData.Category", b =>
                {
                    b.HasOne("ShopWebData.Category", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("ShopWebData.Gift", b =>
                {
                    b.HasOne("ShopWebData.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShopWebData.Image", b =>
                {
                    b.HasOne("ShopWebData.Category", "Category")
                        .WithMany("Images")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ShopWebData.MenuItem", "MenuItem")
                        .WithMany("Images")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ShopWebData.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Category");

                    b.Navigation("MenuItem");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShopWebData.MenuItem", b =>
                {
                    b.HasOne("ShopWebData.MenuItem", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("ShopWebData.Product", b =>
                {
                    b.HasOne("ShopWebData.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShopWebData.ShopsAdresses", b =>
                {
                    b.HasOne("ShopWebData.Adress", "Adress")
                        .WithMany("ShopAdresses")
                        .HasForeignKey("AdressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopWebData.Shop", "Shop")
                        .WithMany("ShopsAdresses")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adress");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("ShopWebData.Statistics", b =>
                {
                    b.HasOne("ShopWebData.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("ShopWebData.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId");

                    b.Navigation("Category");

                    b.Navigation("MenuItem");
                });

            modelBuilder.Entity("ShopWebData.User", b =>
                {
                    b.HasOne("ShopWebData.Adress", "ShopAdress")
                        .WithMany()
                        .HasForeignKey("ShopAdressId");

                    b.Navigation("ShopAdress");
                });

            modelBuilder.Entity("ShopWebData.UserAdress", b =>
                {
                    b.HasOne("ShopWebData.Adress", "ShopAdress")
                        .WithMany()
                        .HasForeignKey("ShopAdressId");

                    b.HasOne("ShopWebData.User", "User")
                        .WithMany("Adresses")
                        .HasForeignKey("UserId");

                    b.Navigation("ShopAdress");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShopWebData.Adress", b =>
                {
                    b.Navigation("ShopAdresses");
                });

            modelBuilder.Entity("ShopWebData.Cart", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("Gifts");
                });

            modelBuilder.Entity("ShopWebData.Category", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShopWebData.MenuItem", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("ShopWebData.Product", b =>
                {
                    b.Navigation("Attributes");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("ShopWebData.Shop", b =>
                {
                    b.Navigation("ShopsAdresses");
                });

            modelBuilder.Entity("ShopWebData.User", b =>
                {
                    b.Navigation("Adresses");

                    b.Navigation("Carts");
                });
#pragma warning restore 612, 618
        }
    }
}
