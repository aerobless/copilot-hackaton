// Create a user service

using copilot_hackaton.Abstractions;

public class UserService : IUserService
{
    
    // create in-memory list of users
    private readonly List<User> _users = new List<User>();


    public User CreateUser(User user)
    {
        _users.Add(user);
        return user;
    }

    public User DeleteUser(int id)
    {
        // Delete user from list
        var user = _users.FirstOrDefault(x => x.Id == id); 

        _users.Remove(user);
        return user;
    }

    public User GetUser(int id)
    {
        // Get user from list
        var user = _users.FirstOrDefault(x => x.Id == id); 
        return user;
    }

    public IEnumerable<User> GetUsers()
    {
        return _users;
    }

    public User UpdateUser(int id, User user)
    {
        // Update user in list
        var storedUser = _users.FirstOrDefault(x => x.Id == id); 
        storedUser.Name = storedUser.Name;
        storedUser.Email = storedUser.Email;
        storedUser.Password = storedUser.Password;
        return storedUser;
    }
}