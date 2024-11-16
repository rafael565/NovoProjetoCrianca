using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovoProjetoCrianca.Models.Consultas;
using NovoProjetoCrianca.Models;

namespace NovoProjetoCrianca.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly Contexto contexto;

        public ConsultasController(Contexto context)
        {
            contexto = context;
        }

        public IActionResult ProfesTurmCurso()
{
    var lstProfesTurmCurso = 
        from professor in contexto.Professores
            .Include(p => p.turma)        
            .ThenInclude(t => t.curso)   
        where professor.turma != null && professor.turma.curso != null // Garante que as relações existem
        group professor by new
        {
            turma = professor.turma.nomeTurma, // Nome da turma
            curso = professor.turma.curso.nome // Nome do curso
        }
        into grupo
        orderby grupo.Key.turma, grupo.Key.curso // Ordena por turma e curso
        select new ProfesTurmCurso
        {
            professor = string.Join(", ", grupo.Select(g => g.nome)), // Lista de professores agrupados
            turma = grupo.Key.turma,                                 // Nome da turma
            curso = grupo.Key.curso                                  // Nome do curso
        };

    return View(lstProfesTurmCurso.ToList());


        }

    }
}
