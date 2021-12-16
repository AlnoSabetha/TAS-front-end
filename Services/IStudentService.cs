using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TASfe.Models;

namespace TASfe.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetById(int id);
    }
}