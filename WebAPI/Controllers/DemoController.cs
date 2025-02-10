﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {

        private static List<Student> _list = new List<Student>() { 
            new Student () { Student_Id = 1, First_Name = "Charifa", Last_Name = "Znifech" },
            new Student () { Student_Id = 2, First_Name = "Khaoula", Last_Name = "Ayari" },
            new Student () { Student_Id = 3, First_Name = "Jessica", Last_Name = "Conrad" },
            new Student () { Student_Id = 4, First_Name = "Mélusine", Last_Name = "Christophe" },
            new Student () { Student_Id = 5, First_Name = "Dorothée", Last_Name = "Valentyn" },
            new Student () { Student_Id = 6, First_Name = "Jenny", Last_Name = "Fernandez Garcia" },
            new Student () { Student_Id = 7, First_Name = "Marwa", Last_Name = "Chanu" },
            new Student () { Student_Id = 8, First_Name = "Anaïs", Last_Name = "Aerts" },
            new Student () { Student_Id = 9, First_Name = "Amalia", Last_Name = "Langlet Tessaro" },
            new Student () { Student_Id = 10, First_Name = "Leslie", Last_Name = "Habimana" },
            new Student () { Student_Id = 11, First_Name = "Debby", Last_Name = "Clerckx" },
            new Student () { Student_Id = 12, First_Name = "Émilie", Last_Name = "Blanckaert" }
        };

        [HttpGet]
        public ActionResult<List<Student>> Get() {
            List<Student> model = _list;
            return Ok(model);
        }

        [HttpGet("{id}")]
        [ProducesResponseType<Student>(200)]
        [ProducesResponseType(404)]
        public IActionResult Get(int id) {
            Student model = _list.Where(st => st.Student_Id == id).SingleOrDefault();
            if(model is not null)
            {
                return Ok(model);
            }
            //return NotFound();
            return StatusCode(404);
        }
    }
}
