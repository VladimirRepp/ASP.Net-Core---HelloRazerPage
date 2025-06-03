using HelloRazerPages.Models;

namespace HelloRazerPages.Services
{
    public class UserService
    {
        private List<User> _users;
        private int _nextId = 1;

        public UserService()
        {
            _users = new List<User>
            {
                new User { Id = 1, Login = "user1", Password = "pass1" },
                new User { Id = 2, Login = "user2", Password = "pass2" }
            };
        }

        public List<User> GetAll() => _users;

        public User GetById(int id) => _users.FirstOrDefault(u => u.Id == id);

        public void Add(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
        }

        public void Update(User user)
        {
            var existingUser = GetById(user.Id);
            if (existingUser != null)
            {
                existingUser.Login = user.Login;
                existingUser.Password = user.Password;
            }
        }

        public void Delete(int id)
        {
            var user = GetById(id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }
    }
}
