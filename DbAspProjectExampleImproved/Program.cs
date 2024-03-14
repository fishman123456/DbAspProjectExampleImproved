using DbAspProjectExampleImproved.Service;
using DbAspProjectExampleImproved.Storage;

var builder = WebApplication.CreateBuilder(args);

// ������������ �������� ������� 
builder.Services.AddControllers();                                  // ���������� ������� ������������ � IoC-���������
builder.Services.AddDbContext<ApplicationDbContext>();              // ������� DbContext
builder.Services.AddTransient<IClientService, RdbClientService>();  // ������� ������ ��� ������ � �������� � IoC-���������
builder.Services.AddTransient<IProductService, RdbProductService>();  // ������� ������ ��� ������ � �������� � IoC-���������

var app = builder.Build();

// ������������ ����������
app.MapControllers();   // �������� ����������� ������������ (endpoints) � ����������

// �������:
// 1. ���������� ������ (�������, �������, ��������� ��������, ��������� �������)
// 2. �������� ������ � ��� ����� ��������� - ����� (Product), ����: id, description: stringm, price: decimal, quantity: int
// 3. �������������� ������ � ����� ���������
// 4. ����������� ��������� �������

app.Run();
