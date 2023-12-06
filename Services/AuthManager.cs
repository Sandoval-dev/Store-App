using AutoMapper;
using Entities.Dtos;
using Microsoft.AspNetCore.Identity;
using Services.Contracts;

namespace Services
{
    public class AuthManager : IAuthService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AuthManager(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IEnumerable<IdentityRole> Roles => _roleManager.Roles;

        public Task<IdentityResult> CreateUser(UserDtoForCreation userDto)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteOneUser(string userName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IdentityUser> GetAllUsers()
        {
            return _userManager.Users.ToList();
        }

        public Task<IdentityUser> GetOneUser(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<UserDtoForUpdate> GetOneUserForUpdate(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> ResetPassword(ResetPasswordDto model)
        {
            throw new NotImplementedException();
        }

        public Task Update(UserDtoForUpdate userDto)
        {
            throw new NotImplementedException();
        }
    }
}