using Online.Store.Domain.Entities;
using Online.Store.Domain.Events.Interfaces;

namespace Online.Store.Domain.Events
{
  public class UserEvent
  {
    private readonly IEvent EventEmitter;

    public UserEvent(IEvent eventEmitter)
    {
      EventEmitter = eventEmitter;
    }

    public UserEntity Created(UserEntity userEntity)
    {
      return this.EventEmitter.Emit(userEntity, "created-user");
    }
  }
}
