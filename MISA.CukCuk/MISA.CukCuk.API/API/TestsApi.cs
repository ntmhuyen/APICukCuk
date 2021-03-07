using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.API.API
{
    [Route("api/v1/tests")]
    [ApiController]
    public class TestsApiController : ControllerBase
    {
        [HttpGet("name")]
        public string GetName()
        {
            return "MISA";
        }

        //[HttpGet("age")]
        //public int GetAge_0(string name)
        //{
        //    return 22;
        //}
        [HttpGet("{age}")]
        public int GetAge(int age)
        {
            return age;
        }

        //[HttpGet("{name}/{age}")]
        //public int GetAge(int age, string name)
        //{
        //    return age;
        //}
        //[HttpGet("name/11")]
        //public int GetAge_11(int age, string name)
        //{
        //    return 111;
        //}
        //[HttpGet("{name}/{age}")]
        //public int GetAge(int age, string name)
        //{
        //    return 12;
        //}

        [HttpGet]
        public int? GetAge(int? age, string name)
        {
            return age;
        }

        [HttpPost]
        public string insert([FromBody] object obj)
        {
            return $"tên của bạn là: {obj}";
        }

        [HttpPost("misa")]
        public int Insert_01()
        {
            return 999999;
        }
        [Route("post-student/{name}")]
        [HttpPost]
        public string PostStudent([FromBody] string name)
        {
            return name;
        }
        
    }
}
