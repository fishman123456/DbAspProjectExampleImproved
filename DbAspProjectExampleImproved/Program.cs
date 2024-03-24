using DbAspProjectExampleImproved.Service;
using DbAspProjectExampleImproved.Storage;

var builder = WebApplication.CreateBuilder(args);

// конфигурация сервисов билдера 
builder.Services.AddControllers();                                  // добавление классов контроллеров в IoC-контейнер
builder.Services.AddDbContext<ApplicationDbContext>();              // добавим DbContext
builder.Services.AddTransient<IClientService, RdbClientService>();  // добавим сервис для работы с клиентам в IoC-контейнер
builder.Services.AddTransient<IProductService, RdbProductService>();  // добавим сервис для работы с клиентам в IoC-контейнер
builder.Services.AddTransient<ICategoryService, RdbCategoryService>();
builder.Services.AddTransient<IOrderProduct,RdbOrderProductService>();
var app = builder.Build();

// конфигурация приложения
app.MapControllers();   // привяжем обработчики контроллеров (endpoints) к приложению

// ЗАДАНИЕ:
// 1. Развернуть проект (скачать, открыть, применить миграции, выполнить запросы)
// 2. Добавить работу с еще одной сущностью - Товар (Product), поля: id, description: stringm, price: decimal, quantity: int
// 3. Протестировать работу с новой сущностью
// 4. Реализовать диаграмму классов

app.Run();
