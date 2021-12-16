using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TASfe.Models;

namespace TASfe.Services
{
    public class StudentService : IStudentService
    {
        private HttpClient _httpClient;
        public StudentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<Student>>("/api/Student");
            return result;
        }

        public async Task<Student> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Student>($"api/Student/{id}");
            return result;
        }
    }
}