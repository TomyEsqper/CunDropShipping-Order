using System.Collections.Generic;
using System.Linq;
using CunDropShipping_Order.domain.Entity;
using CunDropShipping_Order.infrastructure.Entity;
using CunDropShipping_Order.infrastructure.Mapper;

namespace CunDropShipping_Order.infrastructure.DbContext;

public class Repository
{
    private readonly AppDbContext _context;
    private readonly IInfrastructureMapper _mapper;

    public Repository(AppDbContext context, IInfrastructureMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public List<DomainOrderEntity> GetAllOrders()
    {
        var entities = _context.Orders.ToList();
        var list = new List<DomainOrderEntity>();
        foreach (var e in entities)
        {
            list.Add(_mapper.ToDomainOrder(e));
        }
        return list;
    }

    public DomainOrderEntity? GetOrderById(int id)
    {
        var entity = _context.Orders.FirstOrDefault(o => o.Id == id);
        if (entity == null) return null;
        return _mapper.ToDomainOrder(entity);
    }

    public DomainOrderEntity CreateOrder(DomainOrderEntity order)
    {
        var newEntity = _mapper.ToInfrastructureOrder(order);
        var added = _context.Orders.Add(newEntity);
        _context.SaveChanges();
        return _mapper.ToDomainOrder(added.Entity);
    }
}
