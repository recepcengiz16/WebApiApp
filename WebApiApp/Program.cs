using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebApiApp.Data;
using WebApiApp.Interfaces;
using WebApiApp.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(opt =>
{
    opt.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidIssuer = "http://localhost",
        ValidAudience = "http://localhost",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Recepreceprecep1.")),
        ValidateIssuerSigningKey=true,
        ValidateLifetime=true, //expires süresi ve baþlangýç tarihini kontrol etsin
        ClockSkew=TimeSpan.Zero //sunucu ile client arasýnda gecikme olmasýn dedik
    };
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DB"));
});

builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddCors(cors =>
{
    cors.AddPolicy("UdemyCorsPolicy",opt =>
    {
        opt.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseRouting();
app.UseCors("UdemyCorsPolicy");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
