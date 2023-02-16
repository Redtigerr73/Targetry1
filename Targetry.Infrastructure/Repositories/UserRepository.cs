using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Targetry.Application.Common.Exceptions;
using Targetry.Application.Common.Interfaces;
using Targetry.Application.Users.Models;
using Targetry.Domain.Entities;
using Targetry.Infrastructure.Persistence;

namespace Targetry.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TargetryContext _context;
        private readonly IMapper _mapper;
        public UserRepository(TargetryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> GetAllUsersAsync(CancellationToken cancellationToken)
        {
            try
            {
                var users = await _context.Users
                    //.Include(u => u.Role)
                    .AsNoTracking()
                    .ToListAsync(cancellationToken);

                return _mapper.Map<List<UserDto>>(users);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserDto> GetUserById(int id, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
            if (user == null)
            {
                throw new NotFoundException(nameof(User), id);
            }

            return _mapper.Map<UserDto>(user);
        }

        public async Task<int> CreateUser(CreateUserDto dto, CancellationToken cancellationToken)
        {
            var newUser = _mapper.Map<User>(dto);
            await _context.Users.AddAsync(newUser, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return newUser.Id;
        }

        public Task<int> UpdateUser(int id, UpdateUserDto dto, CancellationToken cancellationToken)
        {
            var userTopUpdate = _mapper.Map<User>(dto);
            userTopUpdate.Id = id;
            _context.Users.Update(userTopUpdate);
            return _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<int> DeleteUser(int id, CancellationToken cancellationToken)
        {
            //var userToDelete = _mapper.Map<User>(new UserDto { Id = id });
            var userToDelete = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (userToDelete is not null) { 
                _context.Users.Remove(userToDelete);
                return await _context.SaveChangesAsync(cancellationToken);
            }

            return await Task.FromResult(0);
        }
    }
}
