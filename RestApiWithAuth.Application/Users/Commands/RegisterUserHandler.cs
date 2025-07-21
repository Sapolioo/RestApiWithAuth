using MediatR;
using RestApiWithAuth.Application.Common.Interfaces;
using RestApiWithAuth.Domain.Entities;

namespace RestApiWithAuth.Application.Users.Commands
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, Guid>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;

        public RegisterUserHandler(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }

        internal IPasswordHasher PasswordHasher => _passwordHasher;

        public async Task<Guid> Handle(RegisterUserCommand command, CancellationToken cancellationToken)
        {
            var hashedPassword = PasswordHasher.Hash(command.Password);
            var user = new User(command.Email, hashedPassword, command.FullName);

            await _userRepository.AddAsync(user);
            return user.Id;
        }
    }
}
