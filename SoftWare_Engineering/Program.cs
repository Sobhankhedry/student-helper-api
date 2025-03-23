using Microsoft.EntityFrameworkCore;
using SoftWare_Engineering.Data;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("https://0.0.0.0:7006", "http://0.0.0.0:7007");

// Add services to the container.
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins"; //added 

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DBContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});


var app = builder.Build();
app.UseCors("AllowAll");//added

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
