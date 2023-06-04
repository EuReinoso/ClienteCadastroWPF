using ClienteCadastroWPF.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ClienteCadastroWPF.Data
{
    public class DB : DbContext
    {
        public DB()
        {

        }

        public DB(DbContextOptions<DB> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Dictionary<object, object> dbConfig = Util.JsonToDict(@"./DB_CONFIG.json");

            optionsBuilder.UseSqlServer($"Server={dbConfig["INSTANCIA"]};DataBase={dbConfig["DATABASE"]};User Id={dbConfig["USUARIO"]};Password={dbConfig["SENHA"]};TrustServerCertificate=True;");
        }

        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<EnderecoModel> Endereco { get; set; }
    }
}