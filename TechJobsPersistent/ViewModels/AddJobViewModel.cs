﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public List<Skill> Skills { get; set; }

        public AddJobViewModel() { }
        public AddJobViewModel(List<Employer> employers, List<Skill>skills)
        {
            Employers = new List<SelectListItem>();
            Skills = skills;
            foreach (Employer employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }
    }
    
}
