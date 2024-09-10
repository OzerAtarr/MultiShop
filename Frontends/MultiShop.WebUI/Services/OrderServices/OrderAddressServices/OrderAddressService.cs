using MultiShop.DtoLayer.OrderDtos.OrderAdressDtos;

namespace MultiShop.WebUI.Services.OrderServices.OrderAddressServices
{
    public class OrderAddressService : IOrderAddressService
    {
        private readonly HttpClient _httpClient;
        public OrderAddressService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task CreateOrderAdressAsync(CreateOrderAddressDto createOrderAdressDto)
        {
            await _httpClient.PostAsJsonAsync<CreateOrderAddressDto>("addresses", createOrderAdressDto);
        }
    }
}
