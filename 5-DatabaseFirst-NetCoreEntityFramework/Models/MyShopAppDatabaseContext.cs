using Castle.Components.DictionaryAdapter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _5_DatabaseFirst_NetCoreEntityFramework.Models
{
    public  class MyShopAppDatabaseContext:MyShopAppContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies();
                //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MyShopApp;Trusted_Connection=True");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}