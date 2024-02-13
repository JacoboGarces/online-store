namespace Online.Store.Domain.ValueObjects
{
  public class UserNameValueObject
  {
    private string Value;

    private UserNameValueObject(string value)
    {
      Value = value;
    }

    public static UserNameValueObject Create(string userName)
    {
      if (!Validate(userName))
      {
        throw new ArgumentException("Incorrect user name");
      }

      return new UserNameValueObject(userName);
    }

    public string GetValue()
    {
      return Value;
    }

    private static bool Validate(string userName)
    {
      return userName == null || string.IsNullOrEmpty(userName);
    }
  }
}
