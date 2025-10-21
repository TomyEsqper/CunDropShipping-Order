using CunDropShipping_Order.domain.Entity;
using System.Collections.Generic;

namespace CunDropShipping_Order.application.Service;

public interface IOrderService
{
    List<DomainOrderEntity> GetAllOrders();
    DomainOrderEntity? GetOrderById(int id);
    DomainOrderEntity CreateOrder(DomainOrderEntity order);
}
