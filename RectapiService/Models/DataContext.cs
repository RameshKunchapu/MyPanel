﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RectapiService.Models
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var builder = new ConfigurationBuilder()
            //                .SetBasePath
            //                (Directory.GetCurrentDirectory())
            //                            .AddJsonFile("appsettings.json");
            //var configuration = builder.Build();
            //optionsBuilder.UseSqlServer(configuration
            //    ["ConnectionStrings: DefaultConnection"]);

            optionsBuilder.UseSqlServer("Server=(localdb)\\MyInstance;Database=RECRUITMENT;Trusted_Connection=True;") ;
        }
            public DbSet<Requirement> Requirement { get; set; }
        }
    }

