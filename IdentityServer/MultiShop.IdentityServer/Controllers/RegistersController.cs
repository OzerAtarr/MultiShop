﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MultiShop.IdentityServer.Dtos;
using MultiShop.IdentityServer.Models;
using System.Threading.Tasks;

namespace MultiShop.IdentityServer.Controllers
{
    //[Authorize(LocalApi.PolicyName)]
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public RegistersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> UserRegiser(UserRegisterDto userRegisterDto)
        {
            var values = new ApplicationUser()
            {
                UserName = userRegisterDto.UserName,
                Name = userRegisterDto.Name,
                Surname = userRegisterDto.Surname,
                Email = userRegisterDto.Email,
            };
            var result = await _userManager.CreateAsync(values, userRegisterDto.Password);
            if (result.Succeeded)
            {
                return Ok("Kullanıcı başarıyla eklendi.");
            }
            else
            {
                return Ok("Bir hata o luştu tekrar deneyiniz!");
            }
        }
    }
}
