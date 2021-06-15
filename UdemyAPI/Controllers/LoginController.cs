﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyAPI.Models;
using UdemyAPI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using UdemyAPI.Authentication;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace UdemyAPI.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        IDB _db;

        public LoginController(IDB db)
        {
            _db = db;

        }

        [HttpPost]
        public   IActionResult login([FromBody]UserModel model)
        {
            
            if (ModelState.IsValid)
            {
                return Ok( _db.Login(model));
           
               
            }
                return BadRequest("Ckeck you account plz");
        }
   
     

    }
}
