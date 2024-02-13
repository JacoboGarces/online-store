namespace Online.Store.Domain.ValueObjects
{
  public class UserIdValueObject
  {
    private string Value;

    private UserIdValueObject(string value)
    {
      Value = value;
    }

    public static UserIdValueObject Create()
    {
      return new UserIdValueObject(Guid.NewGuid().ToString());
    }

    public string GetValue()
    {
      return Value;
    }
  }
}
