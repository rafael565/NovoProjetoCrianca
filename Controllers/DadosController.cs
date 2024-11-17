using Microsoft.AspNetCore.Mvc;
using NovoProjetoCrianca.Enum;
using NovoProjetoCrianca.Models;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;
using System;
using System.Drawing.Drawing2D;



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

                int totalFamilias = _context.DadosFamilias.Count();
                aluno.dadofamiliaID = randNum.Next(1, totalFamilias + 1);
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

        public IActionResult DadosFamilia()
        {
            _context.Database.ExecuteSqlRaw("delete from DadosFamilias");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('DadosFamilias', RESEED, 0)");

            Random randNum = new Random();

            string[] vNome = { "Miguel", "Arthur", "Bernardo", "Heitor", "Davi", "Lorenzo", "Théo", "Pedro", "Gabriel", "Enzo", "Matheus", "Lucas", "Benjamin", "Nicolas", "Guilherme", "Rafael", "Joaquim", "Samuel", "Enzo Gabriel", "João Miguel", "Henrique", "Gustavo", "Murilo", "Pedro Henrique", "Pietro", "Lucca", "Felipe", "João Pedro", "Isaac", "Benício", "Daniel", "Anthony", "Leonardo", "Davi Lucca", "Bryan", "Eduardo", "João Lucas", "Victor", "João", "Cauã", "Antônio", "Vicente", "Caleb", "Gael", "Bento", "Caio", "Emanuel", "Vinícius", "João Guilherme", "Davi Lucas", "Noah", "João Gabriel", "João Victor", "Luiz Miguel", "Francisco", "Kaique", "Otávio", "Augusto", "Levi", "Yuri", "Enrico", "Thiago", "Ian", "Victor Hugo", "Thomas", "Henry", "Luiz Felipe", "Ryan", "Arthur Miguel", "Davi Luiz", "Nathan", "Pedro Lucas", "Davi Miguel", "Raul", "Pedro Miguel", "Luiz Henrique", "Luan", "Erick", "Martin", "Bruno", "Rodrigo", "Luiz Gustavo", "Arthur Gabriel", "Breno", "Kauê", "Enzo Miguel", "Fernando", "Arthur Henrique", "Luiz Otávio", "Carlos Eduardo", "Tomás", "Lucas Gabriel", "André", "José", "Yago", "Danilo", "Anthony Gabriel", "Ruan", "Miguel Henrique", "Oliver" };
            string[] vNomeMae = { "Alice", "Sophia", "Helena", "Valentina", "Laura", "Isabella", "Manuela", "Júlia", "Heloísa", "Luiza", "Maria Luiza", "Lorena", "Lívia", "Giovanna", "Maria Eduarda", "Beatriz", "Maria Clara", "Cecília", "Eloá", "Lara", "Maria Júlia", "Isadora", "Mariana", "Emanuelly", "Ana Júlia", "Ana Luiza", "Ana Clara", "Melissa", "Yasmin", "Maria Alice", "Isabelly", "Lavínia", "Esther", "Sarah", "Elisa", "Antonella", "Rafaela", "Maria Cecília", "Liz", "Marina", "Nicole", "Maitê", "Isis", "Alícia", "Luna", "Rebeca", "Agatha", "Letícia", "Maria-", "Gabriela", "Ana Laura", "Catarina", "Clara", "Ana Beatriz", "Vitória", "Olívia", "Maria Fernanda", "Emilly", "Maria Valentina", "Milena", "Maria Helena", "Bianca", "Larissa", "Mirella", "Maria Flor", "Allana", "Ana Sophia", "Clarice", "Pietra", "Maria Vitória", "Maya", "Laís", "Ayla", "Ana Lívia", "Eduarda", "Mariah", "Stella", "Ana", "Gabrielly", "Sophie", "Carolina", "Maria Laura", "Maria Heloísa", "Maria Sophia", "Fernanda", "Malu", "Analu", "Amanda", "Aurora", "Maria Isis", "Louise", "Heloise", "Ana Vitória", "Ana Cecília", "Ana Liz", "Joana", "Luana", "Antônia", "Isabel", "Bruna" };
            string[] nomes_ruas = {"Rua das Flores", "Rua do Sol", "Rua dos Pássaros", "Rua da Paz", "Rua Nova", "Rua do Campo", "Rua Alegre", "Rua Bela Vista", "Rua Esperança", "Rua da Amizade", "Rua das Palmeiras", "Rua da Alegria", "Rua Central", "Rua do Bosque", "Rua da Luz", "Rua da Fonte", "Rua Santa Clara", "Rua do Lago", "Rua do Horizonte", "Rua da Colina"};

            for (int i = 0; i < 100; i++)
            {
                DadoFamilia dadosfamilia = new DadoFamilia();

                int indice_nomemae = randNum.Next(1, 50);
                dadosfamilia.nomeMae = vNomeMae[indice_nomemae];
                int indice_nomepai = randNum.Next(1, 50);
                dadosfamilia.nomePai = vNomeMae[indice_nomepai];
                int ano = randNum.Next(1960, 2000 + 1);
                int mes = randNum.Next(1, 13);
                int dia = randNum.Next(1, 31);
                DateTime dataNascimentomae = new DateTime(ano, mes, dia);
                dadosfamilia.DatadeNascimentoMae = dataNascimentomae;
                int ano_pai = randNum.Next(1960, 2000 + 1);
                int mes_pai = randNum.Next(1, 13);
                int dia_pai = randNum.Next(1, 31);
                DateTime dataNascimentopai = new DateTime(ano_pai, mes_pai, dia_pai);
                dadosfamilia.DatadeNascimentoPai = dataNascimentopai;
                Int64 NMae = randNum.NextInt64(11111111111, 99999999999);
                dadosfamilia.telefoneMae = string.Join("", NMae);
                Int64 NPai = randNum.NextInt64(11111111111, 99999999999);
                dadosfamilia.telefonePai = string.Join("", NPai);
                dadosfamilia.cidade = (Cidade)randNum.Next(4);
                dadosfamilia.HistoricoFamiliar = (HistoricoFamiliar)randNum.Next(2);
                int indice_rua = randNum.Next(1, 20);
                dadosfamilia.endereco = nomes_ruas[indice_rua] + ", Numero" + randNum.Next(1, 320);
                dadosfamilia.email = dadosfamilia.nomeMae.ToLower() + "@gmail.com.br";
                _context.DadosFamilias.Add(dadosfamilia);
            }

            _context.SaveChanges();

            return View(_context.DadosFamilias.OrderBy(o => o.id).ToList());
        }

        public IActionResult AssistenteSocial()
        {
            _context.Database.ExecuteSqlRaw("delete from AssistentesSociais");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('AssistentesSociais', RESEED, 0)");

            Random randNum = new Random();

            string[] vNomeMas = { "Miguel", "Arthur", "Bernardo", "Heitor", "Davi", "Lorenzo", "Théo", "Pedro", "Gabriel", "Enzo", "Matheus", "Lucas", "Benjamin", "Nicolas", "Guilherme", "Rafael", "Joaquim", "Samuel", "Enzo Gabriel", "João Miguel", "Henrique", "Gustavo", "Murilo", "Pedro Henrique", "Pietro", "Lucca", "Felipe", "João Pedro", "Isaac", "Benício", "Daniel", "Anthony", "Leonardo", "Davi Lucca", "Bryan", "Eduardo", "João Lucas", "Victor", "João", "Cauã", "Antônio", "Vicente", "Caleb", "Gael", "Bento", "Caio", "Emanuel", "Vinícius", "João Guilherme", "Davi Lucas", "Noah", "João Gabriel", "João Victor", "Luiz Miguel", "Francisco", "Kaique", "Otávio", "Augusto", "Levi", "Yuri", "Enrico", "Thiago", "Ian", "Victor Hugo", "Thomas", "Henry", "Luiz Felipe", "Ryan", "Arthur Miguel", "Davi Luiz", "Nathan", "Pedro Lucas", "Davi Miguel", "Raul", "Pedro Miguel", "Luiz Henrique", "Luan", "Erick", "Martin", "Bruno", "Rodrigo", "Luiz Gustavo", "Arthur Gabriel", "Breno", "Kauê", "Enzo Miguel", "Fernando", "Arthur Henrique", "Luiz Otávio", "Carlos Eduardo", "Tomás", "Lucas Gabriel", "André", "José", "Yago", "Danilo", "Anthony Gabriel", "Ruan", "Miguel Henrique", "Oliver" };
            string[] vNomeFem = { "Alice", "Sophia", "Helena", "Valentina", "Laura", "Isabella", "Manuela", "Júlia", "Heloísa", "Luiza", "Maria Luiza", "Lorena", "Lívia", "Giovanna", "Maria Eduarda", "Beatriz", "Maria Clara", "Cecília", "Eloá", "Lara", "Maria Júlia", "Isadora", "Mariana", "Emanuelly", "Ana Júlia", "Ana Luiza", "Ana Clara", "Melissa", "Yasmin", "Maria Alice", "Isabelly", "Lavínia", "Esther", "Sarah", "Elisa", "Antonella", "Rafaela", "Maria Cecília", "Liz", "Marina", "Nicole", "Maitê", "Isis", "Alícia", "Luna", "Rebeca", "Agatha", "Letícia", "Maria-", "Gabriela", "Ana Laura", "Catarina", "Clara", "Ana Beatriz", "Vitória", "Olívia", "Maria Fernanda", "Emilly", "Maria Valentina", "Milena", "Maria Helena", "Bianca", "Larissa", "Mirella", "Maria Flor", "Allana", "Ana Sophia", "Clarice", "Pietra", "Maria Vitória", "Maya", "Laís", "Ayla", "Ana Lívia", "Eduarda", "Mariah", "Stella", "Ana", "Gabrielly", "Sophie", "Carolina", "Maria Laura", "Maria Heloísa", "Maria Sophia", "Fernanda", "Malu", "Analu", "Amanda", "Aurora", "Maria Isis", "Louise", "Heloise", "Ana Vitória", "Ana Cecília", "Ana Liz", "Joana", "Luana", "Antônia", "Isabel", "Bruna" };


            for (int i = 0; i < 100; i++)
            {
                AssistenteSocial assistentesocial = new AssistenteSocial();

                assistentesocial.nome = (i % 2 == 0) ? vNomeMas[i / 2] : vNomeFem[i / 2];
                Int64 Ncpf = randNum.NextInt64(11111111111, 99999999999);
                assistentesocial.cpf = string.Join("", Ncpf);
                assistentesocial.email = assistentesocial.nome.ToLower() + "@gmail.com.br";
                Int64 Ntel =randNum.NextInt64(11111111111, 99999999999);
                assistentesocial.telefone = string.Join("", Ntel);
                _context.AssistentesSociais.Add(assistentesocial);
            }

            _context.SaveChanges();

            return View(_context.AssistentesSociais.OrderBy(o => o.id).ToList());
        }

        public IActionResult Atendimento()
        {
            _context.Database.ExecuteSqlRaw("delete from Atendimentos");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Atendimentos', RESEED, 0)");

            Random randNum = new Random();

            for (int i = 0; i < 100; i++)
            {
                Atendimento atendimento = new Atendimento();

                atendimento.assistenteSocialID = randNum.Next(1, _context.AssistentesSociais.Count() + 1);
                atendimento.dadofamiliaID = randNum.Next(1, _context.DadosFamilias.Count() + 1);
                int ano = randNum.Next(2005, 2024 + 1);
                int mes = randNum.Next(1, 13);
                int dia = randNum.Next(1, 31);
                DateOnly dataAtendimento = new DateOnly(ano, mes, dia);
                atendimento.DataAtendimento = dataAtendimento;
                atendimento.observacao = (Obs)randNum.Next(2);
                _context.Atendimentos.Add(atendimento);
            }

            _context.SaveChanges();

            return View(_context.Atendimentos.OrderBy(o => o.id).ToList());
        }

        public IActionResult Atividade()
        {
            _context.Database.ExecuteSqlRaw("delete from Atividades");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Atividades', RESEED, 0)");

            Random randNum = new Random();

            string[] atividades_escolares = {"Redação", "Experimento Científico", "Apresentação de Trabalho", "Leitura de Livro", "Resolução de Problemas", "Pesquisa de Campo", "Trabalho em Grupo", "Debate", "Prova de Matemática", "Análise de Texto", "Jogos Educativos", "Exercícios de Fixação", "Prática de Laboratório", "Discussão em Sala", "Aula de Arte", "Projeto de Ciências", "Desafio de Lógica", "Estudo Dirigido", "Simulado", "Revisão para Provas"};

            for (int i = 0; i < 100; i++)
            {
                Atividade atividade = new Atividade();

                int indice_atv = randNum.Next(1, 20);
                atividade.nome = atividades_escolares[indice_atv];
                atividade.descricao = (Descricao)randNum.Next(2);
                int ano = randNum.Next(2005, 2024 + 1);
                int mes = randNum.Next(1, 13);
                int dia = randNum.Next(1, 31);
                DateOnly dataAtv = new DateOnly(ano, mes, dia);
                atividade.DataAtividade = dataAtv;
                int tempo = randNum.Next(1, 4);
                atividade.duracaoAtividade = string.Join(" ", tempo) + "Horas";
                _context.Atividades.Add(atividade);
            }

            _context.SaveChanges();

            return View(_context.Atividades.OrderBy(o => o.id).ToList());
        }

        public IActionResult Chamada()
        {
            _context.Database.ExecuteSqlRaw("delete from Chamadas");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Chamadas', RESEED, 0)");

            Random randNum = new Random();

            for (int i = 0; i < 100; i++)
            {
                Chamada chamada = new Chamada();

                chamada.matriculaID = randNum.Next(1, _context.Matriculas.Count() + 1);
                int ano = randNum.Next(2005, 2024 + 1);
                int mes = randNum.Next(1, 13);
                int dia = randNum.Next(1, 31);
                DateOnly dataChamada = new DateOnly(ano, mes, dia);
                chamada.DatadeChamada = dataChamada;
                chamada.Presenca = (Presenca)randNum.Next(2);
                _context.Chamadas.Add(chamada);
            }

            _context.SaveChanges();

            return View(_context.Chamadas.OrderBy(o => o.id).ToList());
        }

        public IActionResult Curso()
        {
            _context.Database.ExecuteSqlRaw("delete from Cursos");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Cursos', RESEED, 0)");

            Random randNum = new Random();

            string[] cursos = { "Matemática", "Física", "Química", "Biologia", "História", "Geografia", "Linguística", "Psicologia", "Medicina", "Direito", "Engenharia Civil", "Engenharia Elétrica", "Arquitetura", "Design Gráfico", "Informática", "Administração", "Economia", "Jornalismo", "Pedagogia", "Sociologia" };


            for (int i = 0; i < 20; i++)
            {
                Curso curso = new Curso();

                curso.nome = cursos[i];
                curso.descricao = (Desc_curso)randNum.Next(2);
                curso.periodo = (Periodo)randNum.Next(2);
                int tempo = randNum.Next(4, 6);
                curso.CargaHoraria = string.Join(" ", tempo) + "Horas Aula por Dia";
                _context.Cursos.Add(curso);
            }

            _context.SaveChanges();

            return View(_context.Cursos.OrderBy(o => o.id).ToList());
        }

        public IActionResult Encaminhamento()
        {
            _context.Database.ExecuteSqlRaw("delete from Encaminhamentos");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Encaminhamentos', RESEED, 0)");

            Random randNum = new Random();

            for (int i = 0; i < 100; i++)
            {
                Encaminhamento encaminhamento = new Encaminhamento();

                encaminhamento.entidadeID = randNum.Next(1, _context.Entidades.Count() + 1);
                encaminhamento.assistentesocialID = randNum.Next(1, _context.AssistentesSociais.Count() + 1);
                encaminhamento.alunoID = randNum.Next(1, _context.Alunos.Count() + 1);
                int ano = randNum.Next(2005, 2024 + 1);
                int mes = randNum.Next(1, 13);
                int dia = randNum.Next(1, 31);
                DateOnly dataEncaminhamento = new DateOnly(ano, mes, dia);
                encaminhamento.DatadeEncaminhamento = dataEncaminhamento;
                encaminhamento.motivo = (Motivo)randNum.Next(2);
                _context.Encaminhamentos.Add(encaminhamento);
            }

            _context.SaveChanges();

            return View(_context.Encaminhamentos.OrderBy(o => o.id).ToList());
        }

        public IActionResult Entidade()
        {
            _context.Database.ExecuteSqlRaw("delete from Entidades");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Entidades', RESEED, 0)");

            Random randNum = new Random();

            string[] entidades = {"Conselho Federal de Serviço Social (CFESS)", "Associação Brasileira de Ensino e Pesquisa em Serviço Social (ABEPSS)", "Conselhos Regionais de Serviço Social (CRESS)", "Fórum de Serviço Social", "Instituto Brasileiro de Política e Direito (IBPD)", "Associação Nacional de Assistentes Sociais (ANAS)", "Federação Nacional dos Trabalhadores em Saúde (FENATS)", "Rede Social de Direitos", "Centro de Referência em Serviço Social", "Centro de Defesa dos Direitos Humanos", "Organização Internacional do Trabalho (OIT)", "Fundação Getúlio Vargas (FGV) – Serviço Social", "Instituto de Serviço Social e Políticas Sociais (ISSPS)", "Associação Nacional de Municípios e de Secretários Municipais de Assistência Social (ANAMSS)", "Rede de Proteção Social", "Centro de Capacitação e Formação em Serviço Social", "Conselho Nacional de Assistência Social (CNAS)", "Movimento Nacional de Direitos Humanos", "Associação Brasileira de Política Social", "Instituto de Assistência e Apoio Social"};
            string[] nomes_ruas = { "Rua das Flores", "Rua do Sol", "Rua dos Pássaros", "Rua da Paz", "Rua Nova", "Rua do Campo", "Rua Alegre", "Rua Bela Vista", "Rua Esperança", "Rua da Amizade", "Rua das Palmeiras", "Rua da Alegria", "Rua Central", "Rua do Bosque", "Rua da Luz", "Rua da Fonte", "Rua Santa Clara", "Rua do Lago", "Rua do Horizonte", "Rua da Colina" };

            for (int i = 0; i < 20; i++)
            {
                Entidade entidade = new Entidade();

                entidade.nomeEntidade = entidades[i];
                entidade.endereco = nomes_ruas[i] + ", Numero " + randNum.Next(20, 320);
                entidade.statusContrato = (Status)randNum.Next(2);
                int ano = randNum.Next(2005, 2024 + 1);
                int mes = randNum.Next(1, 13);
                int dia = randNum.Next(1, 31);
                DateOnly datainicio = new DateOnly(ano, mes, dia);
                entidade.DatadeInicio = datainicio;
                int ano_fim = randNum.Next(2005, 2024 + 1);
                int mes_fim = randNum.Next(1, 13);
                int dia_fim = randNum.Next(1, 31);
                DateOnly datafim = new DateOnly(ano_fim, mes_fim, dia_fim);
                entidade.DatadoFim = datafim;
                _context.Entidades.Add(entidade);
            }

            _context.SaveChanges();

            return View(_context.Entidades.OrderBy(o => o.id).ToList());
        }

        public IActionResult Materia()
        {
            _context.Database.ExecuteSqlRaw("delete from Materias");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Materias', RESEED, 0)");

            Random randNum = new Random();

            string[] materias = { "Matemática", "Português", "Física", "Química", "Biologia", "História", "Geografia", "Inglês", "Arte", "Educação Física", "Filosofia", "Sociologia", "Religião", "Educação Moral e Cívica", "Literatura", "Espanhol", "Língua Estrangeira", "Tecnologia", "Cidadania", "Astronomia" };


            for (int i = 0; i < 20; i++)
            {
                Materia materia = new Materia();

                int indicemateria = randNum.Next(1, 20);
                materia.nome = materias[indicemateria];
                materia.CursoID = randNum.Next(1, _context.Cursos.Count() + 1);
                _context.Materias.Add(materia);
            }

            _context.SaveChanges();

            return View(_context.Materias.OrderBy(o => o.id).ToList());
        }

        public IActionResult Matricula()
        {
            _context.Database.ExecuteSqlRaw("delete from Matriculas");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Matriculas', RESEED, 0)");

            Random randNum = new Random();

            for (int i = 0; i < 20; i++)
            {
                Matricula matricula = new Matricula();
                matricula.turmaID = randNum.Next(1, _context.Turmas.Count() + 1);
                matricula.alunoID = randNum.Next(1, _context.Alunos.Count() + 1);
                int ano = randNum.Next(2005, 2024 + 1);
                int mes = randNum.Next(1, 13);
                int dia = randNum.Next(1, 31);
                DateOnly datamatricula = new DateOnly(ano, mes, dia);
                matricula.DataMatricula = datamatricula;
                matricula.statusMatricula = (Status)randNum.Next(2);
                _context.Matriculas.Add(matricula);
            }

            _context.SaveChanges();

            return View(_context.Matriculas.OrderBy(o => o.id).ToList());
        }

        public IActionResult PerfilSocioEconomico()
        {
            _context.Database.ExecuteSqlRaw("delete from PerfisSociosEconomicos");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('PerfisSociosEconomicos', RESEED, 0)");

            Random randNum = new Random();

            string[] profissoes = {"Médico", "Advogado", "Engenheiro", "Professor", "Arquiteto", "Dentista", "Psicólogo", "Enfermeiro", "Farmacêutico", "Fisioterapeuta", "Veterinário", "Contador", "Publicitário", "Designer", "Programador", "Bancário", "Economista", "Chef de Cozinha", "Jornalista", "Biólogo", "Geólogo", "Químico", "Pedagogo", "Artista", "Ator", "Músico", "Fotógrafo", "Redator", "Consultor", "Analista de Sistemas", "Bibliotecário", "Corretor de Imóveis", "Cabeleireiro", "Esteticista", "Carpinteiro", "Eletricista", "Mecânico", "Motorista", "Costureira", "Jardineiro", "Segurança", "Assistente Social", "Terapeuta Ocupacional", "Nutricionista", "Relações Públicas", "Cientista de Dados", "Auditor", "Mestre de Obras", "Consultor Financeiro", "Administrador", "Agente de Viagens", "Recepcionista", "Arqueólogo", "Geógrafo", "Historiador", "Animador de Eventos", "Técnico de TI", "Estudante", "Analista de Marketing", "Gerente de Projetos", "Supervisor", "Gestor de Pessoas", "Técnico de Enfermagem", "Cientista Político", "Especialista em SEO", "Engenheiro de Software", "Empreendedor", "Instrutor de Yoga", "Consultor de Imagem", "Professor de Educação Física", "Turismólogo", "Técnico de Segurança", "Zootecnista", "Biotecnologista", "Gestor de Logística", "Designer de Interiores", "Técnico em Eletromecânica", "Guias de Turismo", "Professor de Artes", "Cientista Ambiental", "Técnico em Redes", "Designer de Moda", "Cozinheiro", "Maquiador", "Motorista de Ambulância", "Fazendeiro", "Técnico de Enfermagem", "Agente de Saúde", "Padeiro", "Marinheiro", "Piloto de Avião", "Empregada Doméstica", "Pesquisador Científico", "Funcionário Público", "Porteiro", "Auditor Fiscal", "Engenheiro Agrônomo", "Técnico em Agropecuária", "Cientista de Alimentos", "Veterinário de Animais Silvestres", "Técnico de Laboratório", "Analista de Dados", "Instrutor de Trânsito", "Físico", "Programador Web", "Consultor Jurídico", "Técnico de Radiologia", "Bombeiro", "Cinegrafista", "Técnico de Som", "Estudante de Medicina", "Administrador de Banco de Dados", "Pesquisador de Mercado", "Instrutor de Linguagem de Sinais", "Cabelereiro de Noivas"};


            for (int i = 0; i < 20; i++)
            {
                PerfilSocioEconomico perfilsocioeconomico = new PerfilSocioEconomico();
                perfilsocioeconomico.dadofamiliaID = randNum.Next(1, _context.DadosFamilias.Count() + 1);
                perfilsocioeconomico.rendafamilia = randNum.Next(0, 5000);
                perfilsocioeconomico.situacaofamilia = (Situacao)randNum.Next(3);
                int indiceprofissao = randNum.Next(1, 100);
                perfilsocioeconomico.profissaoPai = profissoes[indiceprofissao];
                int indiceprofissao2 = randNum.Next(1, 100);
                perfilsocioeconomico.profissaoMae = profissoes[indiceprofissao2];

                _context.PerfisSociosEconomicos.Add(perfilsocioeconomico);
            }

            _context.SaveChanges();

            return View(_context.PerfisSociosEconomicos.OrderBy(o => o.id).ToList());
        }

        public IActionResult Professor()
        {
            _context.Database.ExecuteSqlRaw("delete from Professores");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Professores', RESEED, 0)");

            Random randNum = new Random();

            string[] vNomeMas = { "Miguel", "Arthur", "Bernardo", "Heitor", "Davi", "Lorenzo", "Théo", "Pedro", "Gabriel", "Enzo", "Matheus", "Lucas", "Benjamin", "Nicolas", "Guilherme", "Rafael", "Joaquim", "Samuel", "Enzo Gabriel", "João Miguel", "Henrique", "Gustavo", "Murilo", "Pedro Henrique", "Pietro", "Lucca", "Felipe", "João Pedro", "Isaac", "Benício", "Daniel", "Anthony", "Leonardo", "Davi Lucca", "Bryan", "Eduardo", "João Lucas", "Victor", "João", "Cauã", "Antônio", "Vicente", "Caleb", "Gael", "Bento", "Caio", "Emanuel", "Vinícius", "João Guilherme", "Davi Lucas", "Noah", "João Gabriel", "João Victor", "Luiz Miguel", "Francisco", "Kaique", "Otávio", "Augusto", "Levi", "Yuri", "Enrico", "Thiago", "Ian", "Victor Hugo", "Thomas", "Henry", "Luiz Felipe", "Ryan", "Arthur Miguel", "Davi Luiz", "Nathan", "Pedro Lucas", "Davi Miguel", "Raul", "Pedro Miguel", "Luiz Henrique", "Luan", "Erick", "Martin", "Bruno", "Rodrigo", "Luiz Gustavo", "Arthur Gabriel", "Breno", "Kauê", "Enzo Miguel", "Fernando", "Arthur Henrique", "Luiz Otávio", "Carlos Eduardo", "Tomás", "Lucas Gabriel", "André", "José", "Yago", "Danilo", "Anthony Gabriel", "Ruan", "Miguel Henrique", "Oliver" };
            string[] vNomeFem = { "Alice", "Sophia", "Helena", "Valentina", "Laura", "Isabella", "Manuela", "Júlia", "Heloísa", "Luiza", "Maria Luiza", "Lorena", "Lívia", "Giovanna", "Maria Eduarda", "Beatriz", "Maria Clara", "Cecília", "Eloá", "Lara", "Maria Júlia", "Isadora", "Mariana", "Emanuelly", "Ana Júlia", "Ana Luiza", "Ana Clara", "Melissa", "Yasmin", "Maria Alice", "Isabelly", "Lavínia", "Esther", "Sarah", "Elisa", "Antonella", "Rafaela", "Maria Cecília", "Liz", "Marina", "Nicole", "Maitê", "Isis", "Alícia", "Luna", "Rebeca", "Agatha", "Letícia", "Maria-", "Gabriela", "Ana Laura", "Catarina", "Clara", "Ana Beatriz", "Vitória", "Olívia", "Maria Fernanda", "Emilly", "Maria Valentina", "Milena", "Maria Helena", "Bianca", "Larissa", "Mirella", "Maria Flor", "Allana", "Ana Sophia", "Clarice", "Pietra", "Maria Vitória", "Maya", "Laís", "Ayla", "Ana Lívia", "Eduarda", "Mariah", "Stella", "Ana", "Gabrielly", "Sophie", "Carolina", "Maria Laura", "Maria Heloísa", "Maria Sophia", "Fernanda", "Malu", "Analu", "Amanda", "Aurora", "Maria Isis", "Louise", "Heloise", "Ana Vitória", "Ana Cecília", "Ana Liz", "Joana", "Luana", "Antônia", "Isabel", "Bruna" };
            string[] especializacao = { "Matemática", "Português", "Física", "Química", "Biologia", "História", "Geografia", "Inglês", "Arte", "Educação Física", "Filosofia", "Sociologia", "Religião", "Educação Moral e Cívica", "Literatura", "Espanhol", "Língua Estrangeira", "Tecnologia", "Cidadania", "Astronomia" };

            for (int i = 0; i < 100; i++)
            {
                Professor professor = new Professor();

                professor.nome = (i % 2 == 0) ? vNomeMas[i / 2] : vNomeFem[i / 2];
                Int64 Ntel = randNum.NextInt64(11111111111, 99999999999);
                professor.telefone = string.Join("", Ntel);
                professor.email = professor.nome.ToLower() + "@gmail.com.br";
                professor.turmaID = randNum.Next(1, _context.Turmas.Count() + 1);
                int indice_especilizacao = randNum.Next(1, 20);
                professor.especializacao = especializacao[indice_especilizacao];
                _context.Professores.Add(professor);
            }

            _context.SaveChanges();

            return View(_context.Professores.OrderBy(o => o.id).ToList());
        }

        public IActionResult Turma()
        {
            _context.Database.ExecuteSqlRaw("delete from Turmas");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Turmas', RESEED, 0)");

            Random randNum = new Random();

            string[] nomeTurma = { "Matemática", "Física", "Química", "Biologia", "História", "Geografia", "Linguística", "Psicologia", "Medicina", "Direito", "Engenharia Civil", "Engenharia Elétrica", "Arquitetura", "Design Gráfico", "Informática", "Administração", "Economia", "Jornalismo", "Pedagogia", "Sociologia" };


            for (int i = 0; i < 100; i++)
            {
                Turma turma = new Turma();

                turma.cursoID = randNum.Next(1, _context.Cursos.Count() + 1);
                int indice_nome = randNum.Next(1, 20);
                turma.nomeTurma = nomeTurma[indice_nome] + " Turma " + randNum.Next(1, 3);
                turma.serie = randNum.Next(1, 5);
                turma.maximoAluno = randNum.Next(15, 30);
                turma.minimoAluno = randNum.Next(1, 5);
                _context.Turmas.Add(turma);
            }

            _context.SaveChanges();

            return View(_context.Turmas.OrderBy(o => o.id).ToList());
        }


        public IActionResult Visita()
        {
            _context.Database.ExecuteSqlRaw("delete from Visitas");
            _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Visitas', RESEED, 0)");

            Random randNum = new Random();

            for (int i = 0; i < 100; i++)
            {
                Visita visita = new Visita();

                visita.assistenteSocialID = randNum.Next(1, _context.AssistentesSociais.Count() + 1);
                visita.dadofamiliaID = randNum.Next(1, _context.DadosFamilias.Count() + 1);
                int ano = randNum.Next(2005, 2024 + 1);
                int mes = randNum.Next(1, 13);
                int dia = randNum.Next(1, 31);
                DateOnly dataAtendimento = new DateOnly(ano, mes, dia);
                visita.DataAtendimento = dataAtendimento;
                visita.observacao = (Obs)randNum.Next(2);
                _context.Visitas.Add(visita);
            }

            _context.SaveChanges();

            return View(_context.Visitas.OrderBy(o => o.id).ToList());
        }


    }



}
