namespace MeetingApp1.Models;

public static class Repository
{
    private static List<UserInfo> _users = new();

    static Repository()
    {
        _users.Add(new UserInfo() {Id = 1, Name = "Melisa", Email = "melisa@gmail.com", Phone = "123456798", WillAttend = true});
        _users.Add(new UserInfo() {Id = 2, Name = "Mustafa", Email = "mustafa@gmail.com", Phone = "123456789", WillAttend = false});
        _users.Add(new UserInfo() {Id = 3, Name = "Meral", Email = "meral@gmail.com", Phone = "213456789", WillAttend = true});
    }

    public static List<UserInfo> Users
    {
        get {
            return _users;
        }
    }

    public static void CreateUser(UserInfo user)
    {
        user.Id = Users.Count() + 1;
        _users.Add(user);
    }

    public static UserInfo? GetById(int id)
    {
        return _users.FirstOrDefault(user => user.Id == id);
    }
}