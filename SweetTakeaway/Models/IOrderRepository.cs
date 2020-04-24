namespace SweetTakeaway.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}