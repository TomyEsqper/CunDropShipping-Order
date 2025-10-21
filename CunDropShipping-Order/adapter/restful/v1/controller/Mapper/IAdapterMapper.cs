namespace CunDropShipping_Order.adapter.restful.v1.controller.Mapper;

using CunDropShipping_Order.adapter.restful.v1.controller.Entity;
using CunDropShipping_Order.domain.Entity;
using System.Collections.Generic;

public interface IAdapterMapper
{
    AdapterOrderEntity ToAdapterOrder(DomainOrderEntity domainOrder);
    List<AdapterOrderEntity> ToAdapterOrderList(List<DomainOrderEntity> domainOrders);
    DomainOrderEntity ToDomainOrder(AdapterOrderEntity adapterOrder);
}
