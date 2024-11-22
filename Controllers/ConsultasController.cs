using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovoProjetoCrianca.Models.Consultas;
using NovoProjetoCrianca.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;

namespace NovoProjetoCrianca.Controllers
{
    [Authorize(Roles = "ADMIN, SUPERVISOR")]
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
                where professor.turma != null && professor.turma.curso != null
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

        public IActionResult FiltrarAluno()
        {
            return View();
        }

        public IActionResult ResFiltrarAluno(int ?id, string ?nome)
        {
            List<Aluno> listaAlunos = new List<Aluno>();
            if (id != null)

            listaAlunos = contexto.Alunos.Where(a=>a.id==id).ToList();


             else
                   if (!nome.IsNullOrEmpty()) 
                listaAlunos = contexto.Alunos.Where(n => n.nome.Contains(nome)).OrderBy(o => o.nome).ToList();

            else
                listaAlunos = contexto.Alunos.ToList();

            return View(listaAlunos);
        }

        public IActionResult FiltrarMatricula()
        {
            return View();
        }

        public IActionResult ResFiltrarMatricula(int? id, string? nome, string? nome2)
        {
            List<Matricula> listaMatricula = new List<Matricula>();

            if (id != null)
            {
                listaMatricula = contexto.Matriculas
                    .Include(a => a.aluno)
                    .Include(b => b.turma)
                    .Where(a => a.id == id)
                    .ToList();
            }
            else if (!nome.IsNullOrEmpty())
            {
                listaMatricula = contexto.Matriculas
                    .Include(a => a.aluno)
                    .Include(b => b.turma)
                    .Where(n => n.aluno.nome.Contains(nome))
                    .ToList();
            }
            else if (!nome2.IsNullOrEmpty())
            {
                
                listaMatricula = contexto.Matriculas
                    .Include(a => a.aluno)
                    .Include(b => b.turma)
                    .Where(n => n.turma.nomeTurma.Contains(nome2))
                    .ToList();
            }
            else
            {
                
                listaMatricula = contexto.Matriculas
                    .Include(a => a.aluno)
                    .Include(b => b.turma)
                    .ToList();
            }

            return View(listaMatricula);
        }

    }


}



