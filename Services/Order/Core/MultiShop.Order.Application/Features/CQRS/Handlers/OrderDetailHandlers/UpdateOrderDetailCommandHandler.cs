﻿using MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommand;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class UpdateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;
        public UpdateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateOrderDetailCommand updateOrderDetailCommand)
        {
            var value = await _repository.GetByIdAsync(updateOrderDetailCommand.OrderDetailId);
            value.OrderingId = updateOrderDetailCommand.OrderingId;
            value.ProductAmount = updateOrderDetailCommand.ProductAmount;
            value.ProductId = updateOrderDetailCommand.ProductId;
            value.ProductName = updateOrderDetailCommand.ProductName;
            value.ProductPrice = updateOrderDetailCommand.ProductPrice;
            value.ProductTotalPrice = updateOrderDetailCommand.ProductTotalPrice;

            await _repository.UpdateAsync(value);
        }
    }
}
