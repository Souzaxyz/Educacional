using Academico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers
{
    public class AlunoController : Controller
    {
        private static IList<Aluno> alunos = new List<Aluno>()
        {
            new Aluno()
            {
                AlunoID = 1,
                Nome = "Hogwarts",
                Matricula = "1"
            },
            new Aluno()
            {
                AlunoID = 2,
                Nome = "Mansão X",
                Matricula = "2"
            }
        };
        public IActionResult Index()
        {
            return View(alunos);
        }
    }
}
