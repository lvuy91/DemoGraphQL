using DemoGraphQL.Mutations;
using DemoGraphQL.Queries;
using DemoGraphQL.Repositories;
using DemoGraphQL.Transactions;
using HotChocolate.Execution.Processing;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

InitInjection(builder.Services);
InitGraphQL(builder.Services);

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

app.MapGraphQL();

app.Run();

static void InitInjection(IServiceCollection services)
{
    //services.AddScoped<IApplicationBuilder, ApplicationBuilder>();
    //services.AddScoped<ICustomerRepository, CustomerRepository>();
    //services.AddScoped<IOrderRepository, OrderRepository>();
    //services.AddScoped<IProductRepository, ProductRepository>();
    /*[UseMutationConvention]
    public User? UpdateUserNameAsync([ID] Guid userId, string username)
    {
    //...
    }*/
}

static void InitGraphQL(IServiceCollection services)
{
    services
        .AddGraphQLServer()
        .AddMutationConventions(applyToAllMutations: true)
        .AddQueryType<OrderQuery>()
        .AddMutationType<OrderMutation>()
        .AddTransactionScopeHandler<CustomTransactionScopeHandler>();
}
