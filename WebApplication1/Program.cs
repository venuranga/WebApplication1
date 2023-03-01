using Microsoft.EntityFrameworkCore;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

String ConStr = "Server=127.0.0.1;Database=CarAuctionDb;password=iamleVenu98#;uid=root";


builder.Services.AddControllers();
builder.Services.AddDbContext<CarAuction.AuctionContext>(opt =>
    opt.UseMySql(ConStr, ServerVersion.AutoDetect(ConStr)));// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
