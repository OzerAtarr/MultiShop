﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.IdentityDtos.LoginDtos;
using MultiShop.WebUI.Models;
using MultiShop.WebUI.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace MultiShop.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IIdentityService _identityService;
        public LoginController(IHttpClientFactory httpClientFactory, IIdentityService identityService)
        {
            _httpClientFactory = httpClientFactory;
            _identityService = identityService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SignInDto signInDto)
        {
            await _identityService.SignIn(signInDto);
            return RedirectToAction("Index", "User");
        }


        #region eski kod
        //[HttpPost]
        //public async Task<IActionResult> Index(CreateLoginDto createLoginDto)
        //{
        //    var id = _loginService.GetUserId;
        //    var client = _httpClientFactory.CreateClient();
        //    var content = new StringContent(JsonSerializer.Serialize(createLoginDto), Encoding.UTF8, "application/json");
        //    var response = await client.PostAsync("http://localhost:5001/api/Logins", content);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var jsonData = await response.Content.ReadAsStringAsync();
        //        var tokenModel = JsonSerializer.Deserialize<JwtResponseModel>(jsonData, new JsonSerializerOptions
        //        {
        //            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        //        });

        //        if (tokenModel != null)
        //        {
        //            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
        //            var token = handler.ReadJwtToken(tokenModel.Token);
        //            var claims = token.Claims.ToList();
        //            if (claims != null)
        //            {
        //                claims.Add(new Claim("multishoptoken", tokenModel.Token));
        //                var claimsIdentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);
        //                var authProps = new AuthenticationProperties
        //                {
        //                    ExpiresUtc = tokenModel.ExpireDate,
        //                    IsPersistent = true,
        //                };

        //                await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProps);
        //                return RedirectToAction("Index", "Default");
        //            }
        //            return View();
        //        }
        //    }


        //    return RedirectToAction("Index", "User");
        //}

        //public async Task<IActionResult> Index(CreateLoginDto createLoginDto)
        //{
        //    return View();
        //}
        #endregion


    }
}
