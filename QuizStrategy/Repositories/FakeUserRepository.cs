using QuizStrategy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizStrategy.Repositories
{
    public class FakeUserRepository
    {
        private readonly List<User> _users = new List<User>
        {
            new User { Login = "test", Password = "12345" }
        };

        public async Task<bool> AuthenticateUserAsync(string login, string password)
        {
            await Task.Delay(500); // Имитация задержки
            return _users.Any(u => u.Login == login && u.Password == password);
        }
    }
}
