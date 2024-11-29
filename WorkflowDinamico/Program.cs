using WorkflowDinamico.App.Factorys;
using WorkflowDinamico.App.PipelineSteps;
using WorkflowDinamico.App.Resolvers;
using WorkflowDinamico.App.Services;
using WorkflowDinamico.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<PipelineFactory>();
builder.Services.AddScoped<FluxoAppService>();
builder.Services.AddScoped<GerarEscolaAplicacaoStep>();
builder.Services.AddScoped<GerarPoloAplicacaoEspecialStep>();
builder.Services.AddScoped<GerarPoloAplicacaoStep>();
builder.Services.AddScoped<GerarTurmaAplicacaoStep>();
builder.Services.AddScoped<GerarEnvelopeProvaStep>();
builder.Services.AddScoped<GeraEnvelopeProvaAlfabetizaService>();
builder.Services.AddScoped<GeraEnvelopeProvaSaebService>();
builder.Services.AddScoped<IEnvelopeProvaResolver, EnvelopeProvaResolver>();

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
