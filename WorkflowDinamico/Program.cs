using WorkflowDinamico.App.Factorys;
using WorkflowDinamico.App.PipelineSteps;
using WorkflowDinamico.App.Resolvers;
using WorkflowDinamico.App.Services;
using WorkflowDinamico.Domain.Interfaces;
using WorkflowDinamico.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//AppService
builder.Services.AddScoped<GeracaoMaterialAppService>();
builder.Services.AddScoped<GeracaoAlunoReservaDaTurmaAppService>();
//DomainServices
builder.Services.AddScoped<GeraEnvelopeProvaAlfabetizaService>();
builder.Services.AddScoped<GeraEnvelopeProvaSaebService>();
builder.Services.AddScoped<GeraMaloteService>();
builder.Services.AddScoped<GeraMaloteAlfabetizaService>();
builder.Services.AddScoped<GerarReservaTurmaEspecialService>();
builder.Services.AddScoped<GerarReservaTurmaService>();    
builder.Services.AddScoped<IGeraCDLService,GeraCDLService>();
builder.Services.AddScoped<IGeraEscolaAplicacaoService, GeraEscolaAplicacaoService>();
builder.Services.AddScoped<IGeraPoloAplicacaoService, GeraPoloAplicacaoService>();
builder.Services.AddScoped<IGeraTurmaAplicacaoService, GeraTurmaAplicacaoService>();
//Steps
builder.Services.AddScoped<GerarEscolaAplicacaoStep>();
builder.Services.AddScoped<GerarPoloAplicacaoSaebStep>();
builder.Services.AddScoped<GerarPoloAplicacaoStep>();
builder.Services.AddScoped<GerarTurmaAplicacaoStep>();
builder.Services.AddScoped<GerarEnvelopeProvaStep>();
builder.Services.AddScoped<GerarMaloteStep>();
builder.Services.AddScoped<GerarCDLStep>();
//Resolvers
builder.Services.AddScoped<IEnvelopeProvaResolver, EnvelopeProvaResolver>();
builder.Services.AddScoped<IMaloteResolver, MaloteResolver>();
builder.Services.AddScoped<IAlunoReservaResolver, AlunoReservaResolver>();
//Factory
builder.Services.AddScoped<PipelineGeracaoMaterialFactory>();

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
