using CityManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityManager.DAL.Configurations
{
    internal class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(2000);

            builder.HasData(new City()
            {
                Id = 1,
                Name = "Владимир",
                Description = "Один из крупнейших туристических центров европейской части России. " +
                "Входит в туристический маршрут «Золотое кольцо России». " +
                "Расположен преимущественно на левом берегу реки Клязьмы, в 176 км к востоку от Москвы.",
                Country = "Россия",
                Population = 352347,
            });
        }
    }
}
