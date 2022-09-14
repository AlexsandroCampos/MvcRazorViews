using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel> {
        new EstudanteViewModel(1, "Gustagol", "Rua dos inteligentes", true), 
        new EstudanteViewModel(2, "Daiki", "Rua dos criativos", true), 
        new EstudanteViewModel(3, "Caio", "Rua dos programadores", false), 
    };
    public IActionResult Index() {
        return View(estudantes);
    }

    public IActionResult Show(int id) {
        return View(estudantes[id-2]);
    }
}