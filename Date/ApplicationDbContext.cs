
// Essa classe necessita Herdar a DbContext da forma que está abaixo Ex: public class ApplicationDbContext : DbContext
// 2.1 Criar uma Classe = "ApplicationDbContext" e essa classe necessita Herdar a DbContext Ex: "public class ApplicationDbContext : DbContext"(inserindo dois pontos: DbContext)
// 2.2 Criar um Contrutor dentro da Classe = "ApplicationDbContext", poderar usar o atalho *ctor e pressionar TAB*. E deixa-lo vazio.
// 2.3 Inserir no parametro do Contrutor a Ex: "DbContextOptions<>"
// 2.4 A DbContextOptions receberá o nome da Classe atual "ApplicationDbContext" Ex: DbContextOptions < DbContextOptions >
// 2.5 A DbContextOptions<ApplicationDbContext> é um tipo de dados "option" por isso inserir a frente. *: base(options) Pega as opções do DbContext* Ex: (DbContextOptions < ApplicationDbContext > options) : base(options)


using CadastroPrimoMoveis.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CadastroPrimoMoveis.Date
{      // Herdando a DbContext e dando o nome do Contexto como "ApplicationDbContext"
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options)
        {
        }

        // Criar tabela do banco de dados e inserir as colunas dentro da tabela que foram criadas dentro da PASTA "Models"
        
        // 4 - Cria a tabela do banco de dados
        // 4.1 Criar tabela do banco de dados e inserir as colunas dentro da tabela que foram criadas dentro da PASTA "Models", (Ex: Public DbSet<>)
        // 4.2 Inserir estrutura dentro da tabela que é a "classe" criada que se chama "ClienteModel" que está dentro da pasta "Models" (Ex: Public DbSet<ClienteModel>)
        // 4.3 Dar um nome a nova tabela criada(public DbSet<ClientesModel> Cliente) e o tipo de entrada e saida de dados(Cliente { get; set; }
        // ). Ex completo: public DbSet<ClientesModel> Cliente { get; set; }

        // AGORA É SÓ ADICIONAR A MIGRATIONS
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
