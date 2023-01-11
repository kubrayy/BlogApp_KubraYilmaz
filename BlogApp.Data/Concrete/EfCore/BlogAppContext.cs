using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public class BlogAppContext : DbContext
    {
        public BlogAppContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Article> Articles { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<ArticleCategory> ArticleCategories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=BlogAppDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<ArticleCategory>()
                .HasKey(ac => new
                {
                    ac.ArticleId,
                    ac.CategoryId
                });

            modelBuilder
                .Entity<Category>()
                .HasData(
                new Category() { CategoryId = 1, Name = "Technology", Description = "Technology Category", Url = "technology" },
                new Category() { CategoryId = 2, Name = "Food", Description = "Food Category", Url = "food" },
                new Category() { CategoryId = 3, Name = "Art", Description = "Art Category", Url = "art" },
                new Category() { CategoryId = 4, Name = "Travel", Description = "Travel Category", Url = "travel" }
                );

            modelBuilder
                .Entity<Article>()
                .HasData(
                new Article() { ArticleId = 1, Name = "How to be a devoloper", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Url = "technology-software", IsApproved = true, IsHome = true, ImageUrl = "1.jpeg", AuthorName = "Sezenler Olmuş" , AuthorPhoto = "1_en.jpeg"},
                new Article() { ArticleId = 2, Name = "Endüstri 4.0 Gerçekten Nedir? Tüm Çalışanları Nasıl Etkileyecek?", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Url = "technology-industry", IsApproved = true, IsHome = true, ImageUrl = "2.jpeg", AuthorName = "Kuzu kuzu", AuthorPhoto = "2_en.jpeg" },
                new Article() { ArticleId = 3, Name = "Android Geliştirici Seçenekleri ile Neler Yapabilirsiniz?", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Url = "technology-android", IsApproved = true, IsHome = true, ImageUrl = "3.jpeg", AuthorName ="oy dağlar", AuthorPhoto = "3_en.jpeg" },
                new Article() { ArticleId = 4, Name = "Turkish cuisine", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Url = "turkish-cuisine", IsApproved = true, IsHome = false, ImageUrl = "4.jpeg", AuthorName = "senin paran", AuthorPhoto = "4_alm.jpeg" },
                new Article() { ArticleId = 5, Name = "Chinese cuisine", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Url = "chinese-cuisine", IsApproved = true, IsHome = false, ImageUrl = "5.jpeg", AuthorName = "burda geçmez", AuthorPhoto = "5_alm.jpeg" },
                new Article() { ArticleId = 6, Name = "French cuisine", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Url = "french-cuisine", IsApproved = false, IsHome = true, ImageUrl = "6.jpeg", AuthorName = "Queen" , AuthorPhoto = "6_alm.jpeg" },
                new Article() { ArticleId = 7, Name = "Classic Music", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Url = "art-music", IsApproved = true, IsHome = false, ImageUrl = "7.jpeg", AuthorName = "otomasyon fan" , AuthorPhoto= "7_ital.jpeg" },
                new Article() { ArticleId = 8, Name = "Cinema", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Url = "art-cinema", IsApproved = true, IsHome = false, ImageUrl = "8.jpeg", AuthorName = "Dudu dudu" , AuthorPhoto= "8_ital.jpeg" },
                new Article() { ArticleId = 9, Name = "Painters", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Url = "art-painters", IsApproved = true, IsHome = false, ImageUrl = "9.jpeg", AuthorName = "namık kemal", AuthorPhoto= "9_ital.jpeg" },
                new Article() { ArticleId = 10, Name = "places to visit in Italy", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Url = "travel-italy", IsApproved = true, IsHome = false, ImageUrl = "10.jpeg", AuthorName = "orham kemal", AuthorPhoto= "10_kor.jpeg" },
                new Article() { ArticleId = 11, Name = "First settlement", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Url = "travel-first-settlement", IsApproved = true, IsHome = true, ImageUrl = "11.jpeg", AuthorName ="yaşar kemal", AuthorPhoto= "11_kor.jpeg" },
                new Article() { ArticleId = 12, Name = "The nature beauty Kaş", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Url = "travel-kaş", IsApproved = true, IsHome = true, ImageUrl = "12.jpeg", AuthorName = "yaşar yaşamaz", AuthorPhoto= "12_kor.jpeg" }
                );

            modelBuilder
                .Entity<ArticleCategory>()
                .HasData(
                new ArticleCategory() { ArticleId = 1, CategoryId = 1 },
                new ArticleCategory() { ArticleId = 2, CategoryId = 1 },
                new ArticleCategory() { ArticleId = 3, CategoryId = 1 },
                new ArticleCategory() { ArticleId = 4, CategoryId = 2 },
                new ArticleCategory() { ArticleId = 5, CategoryId = 2 },
                new ArticleCategory() { ArticleId = 6, CategoryId = 2 },
                new ArticleCategory() { ArticleId = 7, CategoryId = 3 },
                new ArticleCategory() { ArticleId = 8, CategoryId = 3 },
                new ArticleCategory() { ArticleId = 9, CategoryId = 3 },
                new ArticleCategory() { ArticleId = 10, CategoryId = 4 },
                new ArticleCategory() { ArticleId = 11, CategoryId = 4 },
                new ArticleCategory() { ArticleId = 12, CategoryId = 4 }
                );
        }
    }
}

