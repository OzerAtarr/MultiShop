using MultiShop.DtoLayer.OrderDtos.OrderAdressDtos;

namespace MultiShop.WebUI.Services.OrderServices.OrderAddressServices
{
    public interface IOrderAddressService
    {
        //Task<List<ResultOrderAdressDto>> GetAllOrderAdressAsync();
        Task CreateOrderAdressAsync(CreateOrderAddressDto createOrderAdressDto);
        //Task UpdateOrderAdressAsync(UpdateOrderAdressDto updateOrderAdressDto);
        //Task DeleteOrderAdressAsync(string id);
        //Task<UpdateOrderAdressDto> GetByIdOrderAdressAsync(string id);
    }
}
