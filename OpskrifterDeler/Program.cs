using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OpskrifterDeler.Data;
using OpskrifterDeler.DBContext;
using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Repositories;
using OpskrifterDeler.Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("OpskrifterDelerContextConnection") ?? throw new InvalidOperationException("Connection string 'OpskrifterDelerContextConnection' not found.");

//builder.Services.AddDbContext<OpskrifterDelerContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Transient);
builder.Services.AddDbContext<OpskrifterDelerContext>(options =>
			   options.UseSqlServer(builder.Configuration.GetConnectionString("OpskrifterDelerContextConnection")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<OpskrifterDelerContext>();

// Add services to the container.
builder.Services.AddScoped(typeof(IAccountRepository), typeof(AccountRepository));
builder.Services.AddTransient(typeof(IAccountService), typeof(AccountService));
builder.Services.AddScoped(typeof(IFavoriteRepository), typeof(FavoriteRepository));
builder.Services.AddTransient(typeof(IFavoriteService), typeof(FavoriteService));
//builder.Services.AddScoped(typeof(IReviewRepository), typeof(ReviewRepository));
//builder.Services.AddTransient(typeof(IReviewService), typeof(ReviewService));


builder.Services.AddControllers().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin  
    .AllowCredentials());               // allow credentials 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
