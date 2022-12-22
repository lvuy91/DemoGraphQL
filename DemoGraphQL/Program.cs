using DemoGraphQL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

InitInjection(builder.Services);

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

static void InitInjection(IServiceCollection services)
{
    services.Services.AddScoped<IApplicationBuilder, ApplicationBuilder>();
    services.Services.AddScoped<ICustomerRepository, CustomerRepository>();
    services.Services.AddScoped<IOrderRepository, OrderRepository>();
    services.Services.AddScoped<IProductRepository, ProductRepository>();
}