using Online.Store.Domain.ValueObjects;

namespace Online.Store.Domain.Entities
{
  public class UserEntity
  {
    public UserIdValueObject UserId { get; }
    public UserNameValueObject UserName { get; }

    public UserEntity(string? userName = null)
    {
      UserId = UserIdValueObject.Create();
      UserName = UserNameValueObject.Create(userName);
    }

    public UserEntity Register(string userName)
    {
      UserName = UserNameValueObject.Create(userName);
      return this;
    }
  }
}
