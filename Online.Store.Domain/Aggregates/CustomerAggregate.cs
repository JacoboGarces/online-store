using Online.Store.Domain.Entities;
using Online.Store.Domain.Events;
using Online.Store.Domain.Events.Interfaces;

namespace Online.Store.Domain.Aggregates
{
  public class CustomerAggregate
  {
    private readonly IEvent eventEmitter;

    public CustomerAggregate(IEvent eventEmitter)
    {
      this.eventEmitter = eventEmitter;
    }

    public UserEntity CreateCustomer(string customerName)
    {
      var user = new UserEntity(customerName);
      var userEvent = new UserEvent(eventEmitter);
      return userEvent.Created(user);
    }
  }
}
