using MultiShop.DtoLayer.DiscountDtos;

namespace MultiShop.WebUI.Services.DiscountServices
{
    public interface IDiscountService
    {
        Task<GetDiscountCodeDetailByCodeDto> GetDiscountCodeAsync(string code);
        Task<int> GetDiscountCouponCountRateAsync(string code);
    }
}
