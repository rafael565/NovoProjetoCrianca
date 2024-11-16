using Microsoft.AspNetCore.Mvc;
using NovoProjetoCrianca.Enum;
using NovoProjetoCrianca.Models;
using Microsoft.EntityFrameworkCore;


namespace NovoProjetoCrianca.Controllers
{
    public class DadosController : Controller
    {
        private readonly Contexto _context;

        public DadosController(Contexto context)
        {
            _context = context;
        }

        public IActionResult Aluno()
        {
            _context.Database.ExecuteSqlRaw("delete from alunos");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('alunos', RESEED, 0)");

            Random randNum = new Random();

            string[] vNomeMas = { "Miguel", "Arthur", "Bernardo", "Heitor", "Davi", "Lorenzo", "Théo", "Pedro", "Gabriel", "Enzo", "Matheus", "Lucas", "Benjamin", "Nicolas", "Guilherme", "Rafael", "Joaquim", "Samuel", "Enzo Gabriel", "João Miguel", "Henrique", "Gustavo", "Murilo", "Pedro Henrique", "Pietro", "Lucca", "Felipe", "João Pedro", "Isaac", "Benício", "Daniel", "Anthony", "Leonardo", "Davi Lucca", "Bryan", "Eduardo", "João Lucas", "Victor", "João", "Cauã", "Antônio", "Vicente", "Caleb", "Gael", "Bento", "Caio", "Emanuel", "Vinícius", "João Guilherme", "Davi Lucas", "Noah", "João Gabriel", "João Victor", "Luiz Miguel", "Francisco", "Kaique", "Otávio", "Augusto", "Levi", "Yuri", "Enrico", "Thiago", "Ian", "Victor Hugo", "Thomas", "Henry", "Luiz Felipe", "Ryan", "Arthur Miguel", "Davi Luiz", "Nathan", "Pedro Lucas", "Davi Miguel", "Raul", "Pedro Miguel", "Luiz Henrique", "Luan", "Erick", "Martin", "Bruno", "Rodrigo", "Luiz Gustavo", "Arthur Gabriel", "Breno", "Kauê", "Enzo Miguel", "Fernando", "Arthur Henrique", "Luiz Otávio", "Carlos Eduardo", "Tomás", "Lucas Gabriel", "André", "José", "Yago", "Danilo", "Anthony Gabriel", "Ruan", "Miguel Henrique", "Oliver" };
            string[] vNomeFem = { "Alice", "Sophia", "Helena", "Valentina", "Laura", "Isabella", "Manuela", "Júlia", "Heloísa", "Luiza", "Maria Luiza", "Lorena", "Lívia", "Giovanna", "Maria Eduarda", "Beatriz", "Maria Clara", "Cecília", "Eloá", "Lara", "Maria Júlia", "Isadora", "Mariana", "Emanuelly", "Ana Júlia", "Ana Luiza", "Ana Clara", "Melissa", "Yasmin", "Maria Alice", "Isabelly", "Lavínia", "Esther", "Sarah", "Elisa", "Antonella", "Rafaela", "Maria Cecília", "Liz", "Marina", "Nicole", "Maitê", "Isis", "Alícia", "Luna", "Rebeca", "Agatha", "Letícia", "Maria-", "Gabriela", "Ana Laura", "Catarina", "Clara", "Ana Beatriz", "Vitória", "Olívia", "Maria Fernanda", "Emilly", "Maria Valentina", "Milena", "Maria Helena", "Bianca", "Larissa", "Mirella", "Maria Flor", "Allana", "Ana Sophia", "Clarice", "Pietra", "Maria Vitória", "Maya", "Laís", "Ayla", "Ana Lívia", "Eduarda", "Mariah", "Stella", "Ana", "Gabrielly", "Sophie", "Carolina", "Maria Laura", "Maria Heloísa", "Maria Sophia", "Fernanda", "Malu", "Analu", "Amanda", "Aurora", "Maria Isis", "Louise", "Heloise", "Ana Vitória", "Ana Cecília", "Ana Liz", "Joana", "Luana", "Antônia", "Isabel", "Bruna" };


            for (int i = 0; i < 100; i++)
            {
                Aluno aluno = new Aluno();

                aluno.dadofamiliaID = randNum.Next(1, _context.DadosFamilias.Count() + 1);
                aluno.nome = (i % 2 == 0) ? vNomeMas[i / 2] : vNomeFem[i / 2];
                Int64 Ncpf = randNum.NextInt64(11111111111, 99999999999);
                aluno.cpf = string.Join("", Ncpf);
                aluno.genero = (Genero)randNum.Next(2);
                aluno.escolaridade = (Escolaridade)randNum.Next(2);
                int ano = randNum.Next(2005, 2024 + 1);
                int mes = randNum.Next(1, 13);
                int dia = randNum.Next(1, 31);
                DateOnly dataNascimento = new DateOnly(ano, mes, dia);
                aluno.DatadeNascimento = dataNascimento;
                aluno.email = aluno.nome.ToLower() + "@gmail.com.br";
                _context.Alunos.Add(aluno);
            }

            _context.SaveChanges();

            return View(_context.Alunos.OrderBy(o => o.id).ToList());
        }
    }

}
