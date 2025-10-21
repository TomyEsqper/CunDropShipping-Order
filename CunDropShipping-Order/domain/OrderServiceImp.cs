using CunDropShipping_Order.application.Service;
using CunDropShipping_Order.domain.Entity;
using CunDropShipping_Order.infrastructure.DbContext;
using System.Collections.Generic;

namespace CunDropShipping_Order.domain;

public class OrderServiceImp : IOrderService
{
    private readonly Repository _repository;

    public OrderServiceImp(Repository repository)
    {
        _repository = repository;
    }

    public List<DomainOrderEntity> GetAllOrders()
    {
        return _repository.GetAllOrders();
    }

    public DomainOrderEntity? GetOrderById(int id)
    {
        return _repository.GetOrderById(id);
    }

    public DomainOrderEntity CreateOrder(DomainOrderEntity order)
    {
        return _repository.CreateOrder(order);
    }
}
