using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Discount.Dtos.CouponDtos;
using MultiShop.Discount.Services;

namespace MultiShop.Discount.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public async Task<IActionResult> DiscountCouponList()
        {
            var values = await _discountService.GetAllDiscountCouponAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountCouponById(int id)
        {
            var value = await _discountService.GetByIdDiscountCouponAsync(id);
            return Ok(value);
        }

        [HttpGet("GetCodeDetailByCode/{code}")]
        public async Task<IActionResult> GetCodeDetailByCode(string code)
        {
            var value = await _discountService.GetCodeDetailByCodeAsync(code);
            return Ok(value);
        }

        [HttpGet("GetDiscountCouponCountRate/{code}")]
        public IActionResult GetDiscountCouponCountRate(string code)
        {
            var value = _discountService.GetDiscountCouponCountRate(code);
            return Ok(value);
        }

        [HttpGet("GetDiscountCouponCount")]
        public async Task<IActionResult> GetDiscountCouponCount()
        {
            var value = await _discountService.GetDiscountCouponCount();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscountCoupon(CreateDiscountCouponDto createCouponDto)
        {
            await _discountService.CreateDiscountCoupon(createCouponDto);
            return Ok("İndirim Kuponu başarıyla oluşturuldu.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDto updateCouponDto)
        {
            await _discountService.UpdateDiscountCoupon(updateCouponDto);
            return Ok("İndirim Kuponu başarıyla güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountService.DeleteDiscountCoupon(id);
            return Ok("İndirim Kuponu başarıyla silindi.");
        }
    }
}
