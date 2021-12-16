using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASfe.Models;
using TASfe.Services;
using Microsoft.AspNetCore.Components;

namespace TASfe.Pages
{
    public partial class StudentPage
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public IStudentService StudentService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Students = (await StudentService.GetAll()).ToList();
        }
    }
}