using copilot_hackaton.Abstractions;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService _userService;

    public UserController(ILogger<UserController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpGet(Name = "GetUsers")]
    public IEnumerable<User> Get()
    {
        return _userService.GetUsers();
    }

    [HttpGet("{id}", Name = "GetUser")]
    public User Get(int id)
    {
        return _userService.GetUser(id);
    }

    [HttpPost(Name = "CreateUser")]
    public User Post([FromBody] User user)
    {
        return _userService.CreateUser(user);
    }

    [HttpPut("{id}", Name = "UpdateUser")]
    public User Put(int id, [FromBody] User user)
    {
        return _userService.UpdateUser(id, user);
    }

    [HttpDelete("{id}", Name = "DeleteUser")]
    public User Delete(int id)
    {
        return _userService.DeleteUser(id);
    }
}