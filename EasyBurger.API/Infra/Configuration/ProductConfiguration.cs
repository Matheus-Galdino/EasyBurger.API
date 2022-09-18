using EasyBurger.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyBurger.API.Infra.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Price).HasColumnType("decimal(5,2)");
            builder.Property(x => x.ImgUrl).HasColumnType("TEXT");
            builder.Property(x => x.Description).HasColumnType("TEXT");

            builder.HasIndex(x => x.Name).IsUnique();

            builder.HasData(new List<Product>
            {
                new Product
                {
                    Id = Guid.Parse("5172cb3a-ba03-42e3-aa03-b10410bb3d44"),
                    Name = "Cheese bacon",
                    Price = 28.9m,
                    Rating = 5,
                    ImgUrl = "https://static-images.ifood.com.br/image/upload/t_medium/pratos/381719c4-1633-4690-a9bd-b2937d38b658/202102031326_Iejr_.jpeg",
                    Description = "Hambúrguer artesanal, queijo, alface americana, tomate, maionese artesanal, bacon e pão de brioche."
                },
                new Product
                {
                    Id = Guid.Parse("81459d7e-fba4-4a3f-b06c-64c5a0417400"),
                    Name = "Galaxy",
                    Price = 33.60m,
                    Rating = 4.7,
                    ImgUrl = "https://files.menudino.com/cardapios/33262/189.jpg",
                    Description = "2 Deliciosos hambúrgueres artesanais 150g, fatias de Cheddar, fatias de mussarela, bacon, maionese, alface americana, tomate, cebola roxa, molho jack no pão tradicional"
                },
                new Product
                {
                    Id = Guid.Parse("f08209a5-ddb7-4e1f-a629-a2ebd87b71da"),
                    Name = "Star",
                    Price = 20.90m,
                    Rating = 4.2,
                    ImgUrl = "https://files.menudino.com/cardapios/33262/196.jpg",
                    Description = "Delicioso hambúrguer artesanal 140g, fatias de Cheddar, molho de cheddar da casa, bacon, alface americana, tomate, cebola roxa, maionese e molho especial no pão tradicional",
                },
                new Product
                {
                    Id = Guid.Parse("feb0dee2-9d82-452f-8707-be0782238953"),
                    Name = "Provolone Crispy",
                    Price = 37.50m,
                    Rating = 4,
                    ImgUrl = "https://files.menudino.com/cardapios/33262/188.jpg",
                    Description = "Delicioso hambúrguer artesanal 180g, fatia de Cheddar, empanado de 2 queijos (catupiry e provolone) frito, cebola crispy, fatias de cheddar, bacon e maionese no pão tradicional ou pão de brioche"
                },
                new Product
                {
                    Id = Guid.Parse("8d51cad6-bca4-4f00-bea6-983c71e9dc66"),
                    Name = "Brutus",
                    Price = 36.00m,
                    Rating = 4.6,
                    ImgUrl = "https://static-images.ifood.com.br/image/upload/t_medium/pratos/a9399dc5-5f22-454a-8895-16c154511760/202004282006_lkS3_b.jpg",
                    Description = "Dois hambúrgueres 120 gr de angus, vinagrete de chimichurri, alface no pão brioche."
                },
                new Product
                {
                    Id = Guid.Parse("109a39d8-7f02-4778-b19b-9e0089d225d7"),
                    Name = "Relíquia",
                    Price = 32.00m,
                    Rating = 4,
                    ImgUrl = "https://static-images.ifood.com.br/image/upload/t_medium/pratos/a9399dc5-5f22-454a-8895-16c154511760/202111021436_0G0V_i.jpg",
                    Description = "Smash de 120g de carne angus, queijo gorgonzola, bacon, geleia de tomate e maionese da casa."
                }
            });
        }
    }
}
