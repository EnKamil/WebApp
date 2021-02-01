using System;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Repository
{
    public interface IStudents
    {
        public void Add(Student items);
        public void Edit(Student items);
        public List<Student> Get();
        public List<Student> Get(List<Student> items);
    }
}