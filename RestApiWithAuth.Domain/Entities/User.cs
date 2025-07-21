using RestApiWithAuth.Domain.Enums;

namespace RestApiWithAuth.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public string FullName { get; private set; }
        public UserRole Role { get; private set; }

        public User(string email, string passwordHash, string fullName, UserRole role = UserRole.User)
        {
            Id = Guid.NewGuid();
            Email = email;
            PasswordHash = passwordHash;
            FullName = fullName;
            Role = role;
        }

        public void ChangeRole(UserRole newRole)
        {
            Role = newRole;
        }
    }
}
