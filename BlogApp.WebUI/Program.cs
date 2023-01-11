using Microsoft.AspNetCore.Identity;
using BlogApp.Business.Abstract;
using BlogApp.Business.Concrete;
using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var sqliteConnection = builder.Configuration.GetConnectionString("SqliteCon");
//builder.Services.AddDbContext<IdentityContext>(options => options.UseSqlite(sqliteConnection));
builder.Services.AddDbContext<BlogAppContext>(options => options.UseSqlite(sqliteConnection));

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IArticleRepository, EfCoreArticleRepository>();
builder.Services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();

builder.Services.AddScoped<IArticleService, ArticleManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "deleteArticle",
    pattern: "admin/deletearticle/{id}",
    defaults: new { controller = "Admin", action = "ArticleDelete" }
);

app.MapControllerRoute(
    name: "detailsEditArticle",
    pattern: "admin/detailsedit/{id}",
    defaults: new { controller = "Admin", action = "ArticleDetailsEdit" }
);

app.MapControllerRoute(
    name: "search",
    pattern: "search",
    defaults: new { controller = "BlogApp", action = "Search" }
);

app.MapControllerRoute(
    name: "articles",
    pattern: "articles/{category?}",
    defaults: new { controller = "BlogApp", action = "List" }
);

app.MapControllerRoute(
    name: "details",
    pattern: "article/{url}",
    defaults: new { controller = "BlogApp", action = "Details" }
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

