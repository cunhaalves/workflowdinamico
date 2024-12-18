﻿using WorkflowDinamico.Domain;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.PipelineSteps
{
    public class GerarPoloAplicacaoStep : IPipelineStep
    {
        private IGeraPoloAplicacaoService _service;
        public GerarPoloAplicacaoStep(IGeraPoloAplicacaoService geraPoloAplicacaoService)
        {
            _service = geraPoloAplicacaoService;
        }
        public async Task ExecuteAsync(PipelineContext context, Func<Task> next)
        {
            Console.WriteLine("Gerando Polo...");

            _service.GerarPoloAplicacao();

            context.Data["PoloGerado"] = true;
            await next();
        }
    }
}
