using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ViagensMVC.Models;

namespace ViagensMVC.Db
{
    public class ViagensOnlineDb : DbContext
    {
        private const string conexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\di3911\Documents\Unidas2020\Exercicio-Lab-Impacta\ViagensMVC\ViagensMVC\App_Data\ViagensOnlineDb.mdf;Integrated Security=True";

        public ViagensOnlineDb() : base(conexao)
        {
        }

        public DbSet<Destino> Destinos { get; set; }
    }
}