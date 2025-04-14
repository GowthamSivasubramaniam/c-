using Microsoft.EntityFrameworkCore;
using ProductMicroservice.Data;
using ProductMicroservice.Services;
using ProductMicroservice.Middleware;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseInMemoryDatabase("ProductsDb"));

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLogging();

var app = builder.Build();


app.UseGlobalExceptionHandler();
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
