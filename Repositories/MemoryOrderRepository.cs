using System;
using System.Collections.Generic;
using System.Linq;
using SampleAPI.Models;

namespace SampleAPI.Repositories
{
    public class MemoryOrderRepository: IOrderRepository
    {
        private IList<Order> _orders {get;set;}

        public MemoryOrderRepository()
        {
            _orders = new List<Order>();
        }

        public IEnumerable<Order> Get() => _orders.Where(o => !o.IsInactive).ToList();

            public Order Get(Guid orderId)
            {
                return  _orders
                    .Where(o => ! o.IsInactive)
                    .FirstOrDefault(o => o.Id == orderId);
            } 

            public void Add(Order order)
            {
                _orders.Add(order);
            }

            public void Update(Guid orderId, Order order)
            {
                var result = _orders.FirstOrDefault(o => o.Id == orderId);

                if(result != null) result.ItemsIds = order.ItemsIds;
            }

            public Order Delete(Guid orderId)
            {
                var target = _orders
                .FirstOrDefault(o => o.Id == orderId);
                target.IsInactive = true;   
                Update(orderId,target); // Soft-delete
              //  _orders.Remove(target); // Hard-delete
                return target;
            }
            
    }
}