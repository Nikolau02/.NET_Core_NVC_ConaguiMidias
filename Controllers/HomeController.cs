using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TCC_Novo.Models;

namespace TCC_Novo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Servicos()
    {
        return View();
    }
    public IActionResult Institucional()
    {
        return View();
    }
    public IActionResult Portifolio()
    {
        return View();
    }
    public IActionResult Clientes()
    {
        return View();
    }
    public IActionResult Dicas()
    {
        return View();
    }

    //Cadastro-----------------------------------------------------------------
    public IActionResult FaleConosco()
    {
        return View();
    }
    [HttpPost]
    public IActionResult FaleConosco(Agendamento agendamento)
    {
        AgendamentoService agendar = new AgendamentoService();
        int novoId = agendar.Agendar(agendamento);
        if (novoId != 0)
        {
            ViewData["Mensagem"] = "Cadastro realizado com sucesso";
        }
        else
        {
            ViewData["Mensagem"] = "Falha no cadastro";
        }
        return View();
    }

    //Atualização---------------------------------------------------------------
    public IActionResult Update(int id)
    {
        Agendamento agendamento = new AgendamentoService().BuscaPorId(id);
        return View(agendamento);
    }
    [HttpPost]
    public IActionResult Update(Agendamento agendamento)
    {
        new AgendamentoService().Editar(agendamento);
        return RedirectToAction("ListaAgendamentos", "Home");
    }

    //Exclusão------------------------------------------------------------------

    public IActionResult Remover(int id)
    {
        AgendamentoService service = new AgendamentoService();
        service.Excluir(id);
        return RedirectToAction("ListaAgendamentos", "Home");
    }

    //Listagem------------------------------------------------------------------
    public IActionResult ListaAgendamentos()
    {
        return View(new AgendamentoService().Listar());
    }
}
