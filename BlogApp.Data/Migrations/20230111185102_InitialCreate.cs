using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApp.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    AuthorName = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorPhoto = table.Column<string>(type: "TEXT", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsApproved = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategories",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategories", x => new { x.ArticleId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ArticleCategories_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "AuthorName", "AuthorPhoto", "Content", "DateAdded", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Name", "Url" },
                values: new object[] { 1, "Sezenler Olmuş", "1_en.jpeg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1.jpeg", true, false, true, "How to be a devoloper", "technology-software" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "AuthorName", "AuthorPhoto", "Content", "DateAdded", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Name", "Url" },
                values: new object[] { 2, "Kuzu kuzu", "2_en.jpeg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2.jpeg", true, false, true, "Endüstri 4.0 Gerçekten Nedir? Tüm Çalışanları Nasıl Etkileyecek?", "technology-industry" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "AuthorName", "AuthorPhoto", "Content", "DateAdded", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Name", "Url" },
                values: new object[] { 3, "oy dağlar", "3_en.jpeg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3.jpeg", true, false, true, "Android Geliştirici Seçenekleri ile Neler Yapabilirsiniz?", "technology-android" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "AuthorName", "AuthorPhoto", "Content", "DateAdded", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Name", "Url" },
                values: new object[] { 4, "senin paran", "4_alm.jpeg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4.jpeg", true, false, false, "Turkish cuisine", "turkish-cuisine" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "AuthorName", "AuthorPhoto", "Content", "DateAdded", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Name", "Url" },
                values: new object[] { 5, "burda geçmez", "5_alm.jpeg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5.jpeg", true, false, false, "Chinese cuisine", "chinese-cuisine" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "AuthorName", "AuthorPhoto", "Content", "DateAdded", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Name", "Url" },
                values: new object[] { 6, "Queen", "6_alm.jpeg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6.jpeg", false, false, true, "French cuisine", "french-cuisine" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "AuthorName", "AuthorPhoto", "Content", "DateAdded", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Name", "Url" },
                values: new object[] { 7, "otomasyon fan", "7_ital.jpeg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7.jpeg", true, false, false, "Classic Music", "art-music" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "AuthorName", "AuthorPhoto", "Content", "DateAdded", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Name", "Url" },
                values: new object[] { 8, "Dudu dudu", "8_ital.jpeg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8.jpeg", true, false, false, "Cinema", "art-cinema" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "AuthorName", "AuthorPhoto", "Content", "DateAdded", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Name", "Url" },
                values: new object[] { 9, "namık kemal", "9_ital.jpeg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9.jpeg", true, false, false, "Painters", "art-painters" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "AuthorName", "AuthorPhoto", "Content", "DateAdded", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Name", "Url" },
                values: new object[] { 10, "orham kemal", "10_kor.jpeg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10.jpeg", true, false, false, "places to visit in Italy", "travel-italy" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "AuthorName", "AuthorPhoto", "Content", "DateAdded", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Name", "Url" },
                values: new object[] { 11, "yaşar kemal", "11_kor.jpeg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "11.jpeg", true, false, true, "First settlement", "travel-first-settlement" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "AuthorName", "AuthorPhoto", "Content", "DateAdded", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Name", "Url" },
                values: new object[] { 12, "yaşar yaşamaz", "12_kor.jpeg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12.jpeg", true, false, true, "The nature beauty Kaş", "travel-kaş" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name", "Url" },
                values: new object[] { 1, "Technology Category", "Technology", "technology" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name", "Url" },
                values: new object[] { 2, "Food Category", "Food", "food" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name", "Url" },
                values: new object[] { 3, "Art Category", "Art", "art" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name", "Url" },
                values: new object[] { 4, "Travel Category", "Travel", "travel" });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 4, 2 });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 5, 2 });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 6, 2 });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 7, 3 });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 8, 3 });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 9, 3 });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 10, 4 });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 11, 4 });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 12, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategories_CategoryId",
                table: "ArticleCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleCategories");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
