using System;
using System.ComponentModel.DataAnnotations;


namespace WebApp.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        
        public string Firstname { get; set; }
        
        public string Lastname { get; set; }
        
        public string Patronymic { get; set; }
        
        public Group Group { get; set; }
    }
}