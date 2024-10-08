﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CommentDtos;
using MultiShop.WebUI.Services.CommentServices;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    [Route("Admin/Comment")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Ana Sayfa";
            ViewBag.v2 = "Yorumlar";
            ViewBag.v3 = "Yorum Listesi";
            ViewBag.v0 = "Yorum İşlemleri";

            var values = await _commentService.GetAllCommentAsync();
            return View(values);
        }

        [HttpGet]
        [Route("CreateComment")]
        public async Task<IActionResult> CreateComment()
        {
            ViewBag.v1 = "Ana Sayfa";
            ViewBag.v2 = "Kategoriler";
            ViewBag.v3 = "Yeni Kategori Girişi";
            ViewBag.v0 = "Kategori İşlemleri";

            return View();
        }

        [HttpPost]
        [Route("CreateComment")]
        public async Task<IActionResult> CreateComment(CreateCommentDto createCommentDto)
        {
            //var client = _httpClientFactory.CreateClient();
            //var jsonData = JsonConvert.SerializeObject(createCommentDto);
            //StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            //var responseMessage = await client.PostAsync("http://localhost:7175/api/Comments", stringContent);
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    return RedirectToAction("Index", "Comment", new { area = "Admin" });

            //}
            return View();
        }

        [Route("DeleteComment/{id}")]
        public async Task<IActionResult> DeleteComment(string id)
        {
            //var client = _httpClientFactory.CreateClient();
            //var responseMessage = await client.DeleteAsync("http://localhost:7175/api/Comments/" + id);
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    return RedirectToAction("Index", "Comment", new { area = "Admin" });
            //}
            return View();
        }

        [Route("UpdateComment/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateComment(string id)
        {
            ViewBag.v1 = "Ana Sayfa";
            ViewBag.v2 = "Kategoriler";
            ViewBag.v3 = "Kategori Güncelleme";
            ViewBag.v0 = "Kategori İşlemleri";

            //var client = _httpClientFactory.CreateClient();
            //var responseMessage = await client.GetAsync("http://localhost:7175/api/Comments/" + id);
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    var jsonData = await responseMessage.Content.ReadAsStringAsync();
            //    var value = JsonConvert.DeserializeObject<UpdateCommentDto>(jsonData);
            //    return View(value);
            //}
            return View();
        }

        [Route("UpdateComment/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateComment(UpdateCommentDto updateCommentDto)
        {
            //updateCommentDto.Status = true;
            //var client = _httpClientFactory.CreateClient();
            //var jsonData = JsonConvert.SerializeObject(updateCommentDto);
            //StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            //var responseMessage = await client.PutAsync("http://localhost:7175/api/Comments/", stringContent);
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    return RedirectToAction("Index", "Comment", new { area = "Admin" });
            //}
            return View();
        }
    }
}
