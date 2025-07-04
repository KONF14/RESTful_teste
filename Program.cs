using Microsoft.EntityFrameworkCore;
using RESTful_teste.Data;
using RESTful_teste.Repository;
using RESTful_teste.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ClienteContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Repositórios
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();

// Serviços
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<IPedidoService, PedidoService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run(); // para mim mesmo aqui é o coração da execução caso tiver alguma interferência não apague em hipótese nenhuma
