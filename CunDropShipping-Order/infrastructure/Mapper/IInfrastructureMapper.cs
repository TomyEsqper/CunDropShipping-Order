using CunDropShipping_Order.domain.Entity;
using CunDropShipping_Order.infrastructure.Entity;
using System.Collections.Generic;

namespace CunDropShipping_Order.infrastructure.Mapper;

public interface IInfrastructureMapper
{
    OrderEntity ToInfrastructureOrder(DomainOrderEntity domainOrder);
    List<OrderEntity> ToInfrastructureOrderList(List<DomainOrderEntity> domainOrders);
    DomainOrderEntity ToDomainOrder(OrderEntity orderEntity);
}
