using MultiShop.Discount.Dtos.CouponDtos;

namespace MultiShop.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponAsync();
        Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id);
        Task<ResultDiscountCouponDto> GetCodeDetailByCodeAsync(string code);
        int GetDiscountCouponCountRate(string code);
        Task CreateDiscountCoupon(CreateDiscountCouponDto createCouponDto);
        Task UpdateDiscountCoupon(UpdateDiscountCouponDto updateCouponDto);
        Task DeleteDiscountCoupon(int id);
        Task<int> GetDiscountCouponCount();
    }
}
