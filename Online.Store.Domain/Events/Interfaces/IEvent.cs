namespace Online.Store.Domain.Events.Interfaces
{
  public interface IEvent
  {
    public T Emit<T>(T payload, string channel);
  }
}
