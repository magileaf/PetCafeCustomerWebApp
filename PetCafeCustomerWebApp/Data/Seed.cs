﻿using Microsoft.AspNetCore.Identity;
using PetCafeCustomerWebApp.Data.Enum;
using PetCafeCustomerWebApp.Models;

namespace PetCafeCustomerWebApp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Dogs.Any())
                {
                    context.Dogs.AddRange(new List<Dog>()
                    {
                        new Dog()
                        {
                            DogName = "NuNu",
                            Image = "https://freerangestock.com/thumbnail/123781/pembroke-welsh-corgi.jpg",
                            Introduction = "This is my first Dog",
                            DogCategory = DogCategory.HerdingGroup,
                            VisitTime = new VisitTime()
                            {
                                Day = "Sunday",
                                TimeFrame = "Afternoon"
                            }   
                         },
                        new Dog()
                        {
                            DogName = "Pinky",
                            Image = "https://freerangestock.com/thumbnail/89960/photo.jpg",
                            Introduction = "He loves to eat",
                            DogCategory = DogCategory.HoundGroup,
                            VisitTime = new VisitTime()
                            {
                                Day = "Sunday",
                                TimeFrame = "Afternoon"
                            }
                         },
                        new Dog()
                        {
                            DogName = "Sunny",
                            Image = "https://freerangestock.com/thumbnail/41954/photo.jpg",
                            Introduction = "He is a nice dog",
                            DogCategory = DogCategory.NonSportingGroup,
                            VisitTime = new VisitTime()
                            {
                                Day = "Monday",
                                TimeFrame = "Morning"
                            }
                         }
                    });
                    context.SaveChanges();
                }
                //Races
                if (!context.Sharings.Any())
                {
                    context.Sharings.AddRange(new List<Sharing>()
                    {
                        new Sharing()
                        {
                            SharingName = "Cooking MaMa",
                            Image = "https://images.unsplash.com/photo-1556911220-e15b29be8c8f?crop=entropy&cs=tinysrgb&fm=jpg&ixlib=rb-1.2.1&q=80&raw_url=true&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070",
                            Introduction = "Angel is a mother of four kids. She is so experienced to prepare meals for children",
                            SharingCategory = SharingCategory.Cooking,
                            VisitTime = new VisitTime()
                            {
                                Day = "Wednesday",
                                TimeFrame = "Afternoon"
                            }
                        },
                        new Sharing()
                        {
                            SharingName = "Leave No Trace of Wing",
                            Image = "https://images.pexels.com/photos/4861347/pexels-photo-4861347.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Introduction = "A regular of classic literature sharing every week",
                            SharingCategory = SharingCategory.Reading,
                            VisitTime = new VisitTime()
                            {
                                Day = "Tuesday",
                                TimeFrame = "Night"
                            }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

        //public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {
        //        //Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //        //Users
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
        //        string adminUserEmail = "teddysmithdeveloper@gmail.com";

        //        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //        if (adminUser == null)
        //        {
        //            var newAdminUser = new AppUser()
        //            {
        //                UserName = "teddysmithdev",
        //                Email = adminUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //        }

        //        string appUserEmail = "user@etickets.com";

        //        var appUser = await userManager.FindByEmailAsync(appUserEmail);
        //        if (appUser == null)
        //        {
        //            var newAppUser = new AppUser()
        //            {
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //        }
        //    }
        //}
    }
}