
using basics.Models;
using Microsoft.AspNetCore.Mvc;
namespace basics.Controllers;

public class CourseController:Controller{

    public IActionResult Index(){
        var kurs=new Course();
        kurs.Id=1;
        kurs.Title="ASP.NET KURSU";
        kurs.Description="çok iyi bir kurs";
        kurs.Image="1.png";

        return View(kurs);
    }
    public IActionResult Details(int id){
        
        var kurs=Repository.GetById(id);

        return View(kurs);
    }
    public IActionResult List(){

           
        return View(Repository.Courses);
    }






}