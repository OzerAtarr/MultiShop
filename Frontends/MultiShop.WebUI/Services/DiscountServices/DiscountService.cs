using MultiShop.DtoLayer.DiscountDtos;
using Newtonsoft.Json;

namespace MultiShop.WebUI.Services.DiscountServices
{
    public class DiscountService : IDiscountService
    {
        private readonly HttpClient _httpClient;
        public DiscountService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GetDiscountCodeDetailByCodeDto> GetDiscountCodeAsync(string code)
        {
            var responseMessage = await _httpClient.GetAsync($"discounts/GetCodeDetailByCode/{code}");
            //var jsonData = await responseMessage.Content.ReadAsStringAsync();
            //var value = JsonConvert.DeserializeObject<GetDiscountCodeDetailByCodeDto>(jsonData);
            var value = await responseMessage.Content.ReadFromJsonAsync<GetDiscountCodeDetailByCodeDto>();
            return value;
        }

        public async Task<int> GetDiscountCouponCountRateAsync(string code)
        {
            var responseMessage = await _httpClient.GetAsync($"discounts/GetDiscountCouponCountRate/{code}");
            //var jsonData = await responseMessage.Content.ReadAsStringAsync();
            //var value = JsonConvert.DeserializeObject<GetDiscountCodeDetailByCodeDto>(jsonData);
            var value = await responseMessage.Content.ReadFromJsonAsync<int>();
            return value;
        }
    }
}
