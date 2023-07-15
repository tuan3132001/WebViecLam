﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebViecLam.Models;

namespace WebViecLam.Data
{
    public class WebViecLamContext : DbContext
    {
        public WebViecLamContext (DbContextOptions<WebViecLamContext> options)
            : base(options)
        {
        }

        public DbSet<WebViecLam.Models.User> User { get; set; } = default!;
    }
}
