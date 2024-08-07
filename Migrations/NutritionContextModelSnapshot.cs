﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nutrition.Data;

#nullable disable

namespace Nutrition.Migrations
{
    [DbContext(typeof(NutritionContext))]
    partial class NutritionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("Nutrition.Models.NutritionLabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Calcium")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Calories")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cholesterol")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DietaryFiber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FoodName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Iron")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Protein")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SaturatedFat")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ServingSize")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sodium")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sugars")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalCarbohydrates")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalFat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TransFat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VitaminA")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VitaminC")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("NutritionLabels");
                });
#pragma warning restore 612, 618
        }
    }
}
