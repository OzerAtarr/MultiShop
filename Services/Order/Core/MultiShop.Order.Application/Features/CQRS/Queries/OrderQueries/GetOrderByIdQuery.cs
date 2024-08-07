using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Queries.OrderQueries
{
    public class GetOrderByIdQuery
    {
        public int Id { get; set; }
        public GetOrderByIdQuery(int id)
        {
            Id = id;
        }
    }
}
