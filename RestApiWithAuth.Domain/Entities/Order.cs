using RestApiWithAuth.Domain.Enums;
using RestApiWithAuth.Domain.ValueObjects;

namespace RestApiWithAuth.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public OrderStatus Status { get; private set; }
        public List<OrderItem> Items { get; private set; }

        public Order(Guid userId, List<OrderItem> items)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            CreatedAt = DateTime.UtcNow;
            Status = OrderStatus.Pending;
            Items = items ?? new();
        }

        public void MarkAsCompleted()
        {
            Status = OrderStatus.Completed;
        }

        public decimal TotalAmount => Items.Sum(x => x.Total);
    }
}
