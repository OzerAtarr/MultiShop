using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CommentDtos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;

namespace MultiShop.WebUI.Controllers
{
    public class ProductListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ProductListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index(string id)
        {
            ViewBag.i = id;
            return View();
        }
        public IActionResult ProductDetail(string id)
        {
            ViewBag.x = id;
            return View();
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]  
        public async Task<IActionResult> AddComment(CreateUserCommentDto createUserCommentDto)
        {
            createUserCommentDto.ImageUrl = "test";
            createUserCommentDto.Rating = 1;
            createUserCommentDto.CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            createUserCommentDto.Status = false;
            createUserCommentDto.ProductId = "66911b560d335a354bed8083";
            ViewBag.x = "66911b560d335a354bed8083";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createUserCommentDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:7175/api/Comments", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("ProductDetail", "ProductList",new {id=ViewBag.x});

            }
            return View();
        }
    }
}
