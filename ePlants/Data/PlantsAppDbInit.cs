using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using ePlants.Models;

namespace ePlants.Data
{
    public class PlantsAppDbInit
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<PlantsDbContext>();
                context.Database.EnsureCreated();

                if (!context.Customers.Any())
                {
                    context.Customers.AddRange(new List<CustomerModel>()
                    {
                        new CustomerModel()
                        {
                            Gender = Enums.HumanGender.Male,
                            FirstName = "Model",
                            LastName = "Test",
                            Email = "kwixacademy@gmail.com",
                            HashedPassword = "test",
                            Phone = "0799999999"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Plants.Any())
                {
                    context.Plants.AddRange(new List<PlantModel>()
                    {
                        new PlantModel()
                        {
                            Name = "Watermelon Peperomia",
                            PlantCategory = PlantCategory.Both,
                            Description = "Peperomia este o specie de plantă cu flori din familia Piperaceae, originară din nordul Americii de Sud, incluzând Bolivia, Brazilia, Ecuador și Venezuela. Planta nu este strâns legată de pepene verde sau begonie.",
                            Price = 112.99m
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Features.Any())
                {
                    context.Features.AddRange(new List<FeatureModel>()
                    {
                        new FeatureModel()
                        {
                           PetFriendly = false,
                           AirPurifying = true
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Sizes.Any())
                {
                    context.Sizes.AddRange(new List<SizeModel>()
                    {
                        new SizeModel()
                        {
                            Name = "MD",
                            Length = 15f,
                            Width = 15f,
                            Weight = 150f,
                            Height = 15f,
                            ShapeId = 1,
                            PlantId = 1
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Shapes.Any())
                {
                    context.Shapes.AddRange(new List<ShapeModel>()
                    {
                        new ShapeModel()
                        {
                           Name = "Ghiveci rotund"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Manufacturers.Any())
                {
                    context.Manufacturers.AddRange(new List<ManufacturerModel>()
                    {
                        new ManufacturerModel()
                        {
                            Name = "Gradina Tulcea",
                            Description = "Plante de calitate pentru gradina ta",
                            WebsiteUrl = "https://www.gradina-tulcea.ro",
                            Email = "gradina_tulcea@gmail.com",
                            Telephone = "0799999999"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Addresses.Any())
                {
                    context.Addresses.AddRange(new List<AddressModel>()
                    {
                        new AddressModel()
                        {
                            StreetAddress = "Str.Energiei",
                            ZipCode = "000000",
                            ManufacturerId = 1,
                            CityId = 1
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Cities.Any())
                {
                    context.Cities.AddRange(new List<CityModel>()
                    {
                        new CityModel()
                        {
                            Name = "Tulcea",
                            CountyId = 1
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Counties.Any())
                {
                    context.Counties.AddRange(new List<CountyModel>()
                    {
                        new CountyModel()
                        {
                            Name = "Tulcea"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Plants_Manufacturers.Any())
                {
                    context.Plants_Manufacturers.AddRange(new List<Plant_Manufacturer>()
                    {
                        new Plant_Manufacturer()
                        {
                            PlantId = 1,
                            ManufacturerId = 1,
                            Quantity = 7
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Plants_Features.Any())
                {
                    context.Plants_Features.AddRange(new List<Plant_Features>()
                    {
                        new Plant_Features()
                        {
                            PlantId = 1,
                            FeatureId = 1
                        }
                    });
                    context.SaveChanges();
                }


            }
        }
    }
}
