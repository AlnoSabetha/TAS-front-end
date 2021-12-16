using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASfe.Models;
using TASfe.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace TASfe.Pages
{
    public partial class DetailStudent
    {
        [Parameter]
        public string studentID { get; set; }
        public Student Student { get; set; } = new Student();
    }
}