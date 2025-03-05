using CleanArchitecture.Domain.Users;

namespace CleanArchitecture.Infrastructure.Repositories;

internal sealed class UserRepository : Repository<User,UserId>, IUserRepository
{
    public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    //public Task<User?> GetByIdAsync(UserId id, CancellationToken cancellationToken = default)
    //{
    //    throw new NotImplementedException();
    //}
}