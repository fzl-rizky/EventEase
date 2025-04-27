// UserSessionService.cs
public class UserSessionService
{
    public string UserName { get; set; }
    public bool IsRegistered { get; set; } = false;

    public void Register(string name)
    {
        UserName = name;
        IsRegistered = true;
    }
}
