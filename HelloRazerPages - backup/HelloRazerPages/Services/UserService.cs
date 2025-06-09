using HelloRazerPages.Models;

namespace HelloRazorPages.Services
{
    public class UserService
    {
        private List<User> _users;
        private int _lastId = 0;

        public UserService()
        {
            _users = new();
        }

        public void GetDataFromSource()
        {
            _users.Add(new User() { Id = GetCurrentNextId(), Login = "log1", Password = "1111" });
            _users.Add(new User() { Id = GetCurrentNextId(), Login = "log2", Password = "2222" });
        }

        private int GetCurrentNextId() => _lastId++;

        public List<User> GetAll() => _users;

        public User GetById(int id) => _users.FirstOrDefault(x => x.Id == id);

        public User Add(User user)
        {
            user.Id = GetCurrentNextId();
            _users.Add(user);

            return user;
        }

        public bool Update(User user)
        {
            var found = _users.FirstOrDefault(x => x.Id == user.Id);

            if (found == null)
            {
                return false;
            }

            found.Login = user.Login;
            found.Password = user.Password;
            return true;
        }

        public bool Delete(int id)
        {
            var found = _users.FirstOrDefault(x => x.Id == id);

            if (found == null)
            {
                return false;
            }

            _users.Remove(found);
            return true;
        }
    }
}
