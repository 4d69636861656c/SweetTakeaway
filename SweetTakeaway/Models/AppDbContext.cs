using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SweetTakeaway.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Biscuits and cookies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Chocolate and candies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Custards and puddings" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Deep-fried desserts" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 6, CategoryName = "Frozen desserts" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 7, CategoryName = "Jellied desserts" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 8, CategoryName = "Pastries" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 9, CategoryName = "Pies, cobblers, and clafoutis" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 10, CategoryName = "Sweet soups" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 11, CategoryName = "Dessert wines" });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Some nice biscuits",
                    Price = 0.99M,
                    ShortDescription = "Some nice cookies for you.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                    "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                    "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 1,
                    ImageUrl = "\\images\\NiceBiscuits.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\NiceBiscuits.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 2,
                    Name = "Chocolate fudge cake",
                    Price = 99.99M,
                    ShortDescription = "The perfect cake to gift to your loved ones on birthdays.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                        "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 2,
                    ImageUrl = "\\images\\ChocolateFudgeCake.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\ChocolateFudgeCake.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 3,
                    Name = "Gunny candy",
                    Price = 0.09M,
                    ShortDescription = "Some gummy candy for you to chew while watching Netflix.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                        "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 3,
                    ImageUrl = "\\images\\GummyCandy.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\GummyCandy.jpg",
                    IsInStock = true,
                    IsOnSale = false
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 4,
                    Name = "Chocolate pudding",
                    Price = 3.99M,
                    ShortDescription = "This chocolate pudding will make you smile.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                        "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 4,
                    ImageUrl = "\\images\\ChocolatePudding.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\ChocolatePudding.jpg",
                    IsInStock = true,
                    IsOnSale = false
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 5,
                    Name = "Deep fried banana",
                    Price = 1.99M,
                    ShortDescription = "Bananas are even better when deep-fried. Try it now!",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                        "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 5,
                    ImageUrl = "\\images\\DeepFriedBananas.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\DeepFriedBananas.jpg",
                    IsInStock = true,
                    IsOnSale = false
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 6,
                    Name = "Fresh strawberry ice cream",
                    Price = 9.99M,
                    ShortDescription = "This ice cream will keep you fresh in sunny days!",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                        "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 6,
                    ImageUrl = "\\images\\FreshStrawberryIceCream.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\FreshStrawberryIceCream.jpg",
                    IsInStock = true,
                    IsOnSale = false
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 7,
                    Name = "Sparkling ruby cabernet jelly with cherries",
                    Price = 29.99M,
                    ShortDescription = "Now isn't that a fancy name? Buy one now and tell your friends about it!",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                        "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 7,
                    ImageUrl = "\\images\\SparklingRubyCabernetJellyWithCherries.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\SparklingRubyCabernetJellyWithCherries.jpg",
                    IsInStock = true,
                    IsOnSale = false
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 8,
                    Name = "Apple cinnamon pastries",
                    Price = 9.99M,
                    ShortDescription = "Get a bag and we'll double it!",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                        "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 8,
                    ImageUrl = "\\images\\AppleCinnamonPastries.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\AppleCinnamonPastries.jpg",
                    IsInStock = true,
                    IsOnSale = false
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 9,
                    Name = "Berry pie",
                    Price = 39.99M,
                    ShortDescription = "A delicious berry pie made just for you!",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                        "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 9,
                    ImageUrl = "\\images\\BerryPie.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\BerryPie.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 10,
                    Name = "Roasted sweet potato and carrot soup",
                    Price = 9.99M,
                    ShortDescription = "Look! It's a potato and carrot soup made with love.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                        "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 10,
                    ImageUrl = "\\images\\RoastedSweetPotatoAndCarrotSoup.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\RoastedSweetPotatoAndCarrotSoup.jpg",
                    IsInStock = true,
                    IsOnSale = false
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 11,
                    Name = "Accordini recioto classico acinatico 1980",
                    Price = 499.99M,
                    ShortDescription = "This gorgeous wine from Veneto shows beautiful hues of ruby red in the glass.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                        "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    CategoryId = 11,
                    ImageUrl = "\\images\\AccordiniReciotoClassicoAcinatico2013.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\AccordiniReciotoClassicoAcinatico2013.jpg",
                    IsInStock = true,
                    IsOnSale = false
                });
        }
    }
}