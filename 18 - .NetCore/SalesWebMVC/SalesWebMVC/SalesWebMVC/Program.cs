// Entry point da aplicação

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SalesWebMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

// AUlA - 250

// Web Services x Template Engine

// WS: Sistema dá resposta dos dados e o navegador monta o html css e js
// Frameworkd/Libs Javascript: React, Vue.js, Angular e Jquery(DOM)

// TE: Monta a página de resposta no back-end e devolve o html montado no navegador
// Java: Spring, Thymeleaf
// C#: ASP.Net Core(Framework), Razor engine(Sistemas de templates)
// PHP: Laravel, Blade template


//Responsibility of each MVC part:

//Model: domain entities structure and their transformations (domain model)
// - Entities
// - Services (related to entities)
// - Repositories(persistent data access)
//
//Controllers: receives user interactions and treat them - intermediário entre model e view
//
//Views: defines structure and behaviour of user interface


// ----------------------------X-------------------------------------

// Aula 251

// Entity Framework

//Problema:Por muitos anos, uma grande dificuldade de se criar sistemas orientados a objetos foi a comunicação com o banco de dados relacional.


// Conexão manual: Modelo de tabelas (Relacional) com modelo de objetos da linguagem, ex:

//Client client = null;
//using (connection)
//{
//    using (var command = new SqlCommand("SELECT * FROM Clients WHERE Id = @id;", connection))
//    {
//        command.Parameters.Add(new SqlParameter("@id", id));
//        connection.Open();
//        using (var reader = command.ExecuteReader())
//        {
//            if (reader.Read())
//            {
//                client = new Client();
//                client.Id = reader.GetString(0);
//                client.Name = reader.GetString(1);
//                client.Email = reader.GetString(2);
//                client.Phone = reader.GetString(3);
//            }
//        }
//    }
//}
//return client;


//Outras questões que devem ser tratadas:
//• Contexto de persistência (monitorar alterações nos objetos que estão atrelados a uma conexão em um dado momento) • Alterações
//• Transação
//• Concorrência
//• Mapa de identidade (cache de objetos já carregados)
//• Carregamento tardio(lazy loading) - busca de objeto que tem relação para muitos, não se deve carregar todos até precisar para não sobrecarregar a memória
//• Etc.


//Solução: Mapeamento Objeto-Relacional
//ORM(Object - Relational Mapping): Permite programar em nível de objetos e
//comunicar de forma transparente com um banco de dados relacional


//Entity Framework Core (Multiplataforma) o 6 é exclusivo p/ windows
//https://docs.microsoft.com/en-us/ef/

//Providers: Comunicação com BD específicos: SQL Server, PostgreSQL, Oracle Database, Mysql, IBM DB2, SQLite
//https://docs.microsoft.com/en-us/ef/core/providers/index



//Principais classes:

//• DbContext: um objeto DbContext encapsula uma sessão com o banco de dados para um determinado modelo de dados (representado por DbSet's).
//• É usado para consultar e salvar entidades no banco de dados
//• Define quais entidades farão parte do modelo de dados do sistema
//• Pode definir várias configurações
//• É uma combinação dos padrões Unity of Work e Repository
//• Unity of work: "mantém uma lista de objetos afetados por uma transação e coordena a escrita de mudanças e trata possíveis problemas de concorrência" - Martin Fowler. (persistência)
//• Repository: define um objeto capaz de realizar operações de acesso a dados (consultar, salvar, atualizar, deletar - CRUD) para uma entidade.


//• DbSet<TEntity>: representa a coleção de entidades de um dado tipo em
//um contexto. Tipicamente corresponde a uma tabela do banco de dados.

// Processo geral para se executar operações:
// Linq (funções lambda) executadas no DbSet(Pedidos) e convertidas em tempo de execução em consultas SQL no Banco de Dados