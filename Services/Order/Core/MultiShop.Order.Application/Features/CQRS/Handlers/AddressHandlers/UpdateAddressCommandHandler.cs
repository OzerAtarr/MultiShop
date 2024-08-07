using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;
        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAdressCommand updateAdressCommand)
        {
            var value = await _repository.GetByIdAsync(updateAdressCommand.AddressId);
            value.Detail = updateAdressCommand.Detail;
            value.District = updateAdressCommand.District;
            value.City = updateAdressCommand.City;
            value.UserId = updateAdressCommand.UserId;

            await _repository.UpdateAsync(value);
        }
    }
}
