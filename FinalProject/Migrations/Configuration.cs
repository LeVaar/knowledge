
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace FinalProject.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<FinalProject.ViewModel.BaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}