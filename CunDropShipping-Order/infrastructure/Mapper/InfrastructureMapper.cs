using CunDropShipping_Order.domain.Entity;
using CunDropShipping_Order.infrastructure.Entity;
using System.Collections.Generic;

namespace CunDropShipping_Order.infrastructure.Mapper;

public class InfrastructureMapper : IInfrastructureMapper
{
    public OrderEntity ToInfrastructureOrder(DomainOrderEntity domainOrder)
    {
        // Asumimos domainOrder no nulo en uso normal
        return new OrderEntity
        {
            Id = domainOrder.Id,
            OrderDate = domainOrder.OrderDate,
            Total = domainOrder.Total,
            IdUser = domainOrder.IdUser
        };
    }

    public List<OrderEntity> ToInfrastructureOrderList(List<DomainOrderEntity> domainOrders)
    {
        var list = new List<OrderEntity>();
        if (domainOrders == null) return list;
        foreach (var d in domainOrders)
        {
            list.Add(ToInfrastructureOrder(d));
        }
        return list;
    }

    public DomainOrderEntity ToDomainOrder(OrderEntity orderEntity)
    {
        // Asumimos orderEntity no nulo en uso normal
        return new DomainOrderEntity
        {
            Id = orderEntity.Id,
            OrderDate = orderEntity.OrderDate,
            Total = orderEntity.Total,
            IdUser = orderEntity.IdUser
        };
    }
}
