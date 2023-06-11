// create IUserService.cs in Abstractions folder

namespace copilot_hackaton.Abstractions
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);
        User CreateUser(User user);
        User UpdateUser(int id, User user);
        User DeleteUser(int id);
    }
}