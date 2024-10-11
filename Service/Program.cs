using Microsoft.EntityFrameworkCore;
using ServiceDataLayer.Models;

var builder = WebApplication.CreateBuilder(args);

// ����������� � ���� ������ (�������� ConnectionString �� ���� ������ �����������)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ServiceDBContext>(options =>
    options.UseSqlServer(connectionString));

// ����������� ������������ � ������ ��������
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ��������� ��������� HTTP-��������
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// ����������� ��������� ��� ������������
app.MapControllers();

app.Run();
