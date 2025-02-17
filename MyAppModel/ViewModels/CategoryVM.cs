﻿using Microsoft.AspNetCore.Http;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppModels.ViewModels
{
   public class CategoryVM
    {
        public Category category { get; set; } = new Category();
        public IEnumerable<Category> categories { get; set; } = new List<Category>();
        public IFormFile Photo { get; set; }
        public string ProductImageurl { get; set; }
    }
}
