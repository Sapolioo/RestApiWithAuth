using RestApiWithAuth.Domain.Entities;

namespace RestApiWithAuth.Application.Common.Interfaces
{
    public interface IUserRepository
    {
        public Task AddAsync(User user);
    }
}
