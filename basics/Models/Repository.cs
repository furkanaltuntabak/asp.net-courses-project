using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses=new List<Course>();

        static Repository(){

            _courses=new List<Course>(){

                    new Course { Id = 1,
                        Title = "ASP.NET Core",
                        Description = "Backend geliştirme kursu",
                        Image="1.png",
                        Tags=new string[]{"kurs tag1","kurs tag 2"},
                        IsActive=true,
                        IsHome=true},
                    new Course { Id = 2, 
                        Title = "C# Temelleri", 
                        Description = "C# programlamaya giriş",
                        Image="2.jpg" ,
                        Tags=new string[]{"kurs tag c#","kurs tag 2"},
                        IsActive=true,
                        IsHome=true},
                    new Course { Id = 3, 
                        Title = "Entity Framework", 
                        Description = "Veritabanı yönetimi",
                        Image="3.jpg",
                        Tags=new string[]{"kurs tag Entity","kurs tag 2"},
                        IsActive=true,
                        IsHome=false},
                    new Course { Id = 4, 
                        Title = "JAVA Temelleri", 
                        Description = "Veritabanı yönetimi",
                        Image="2.jpg",
                        Tags=new string[]{"kurs tag Java    ","kurs tag 2"},
                        IsActive=false,
                        IsHome=true },

            };
        }
        public static  List<Course> Courses 
        {
            get{
                return _courses;
            }

        }

        public static Course? GetById(int id)
        {
            return _courses.FirstOrDefault(c=>c.Id==id);
        }

    }
}