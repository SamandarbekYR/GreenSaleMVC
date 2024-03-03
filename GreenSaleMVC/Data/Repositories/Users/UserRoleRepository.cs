using GreenSaleMVC.Data.Entities;
using GreenSaleMVC.Data.Entities.Users;
using GreenSaleMVC.Data.Interfaces;

namespace GreenSaleMVC.Data.Repositories;

public class UserRoleRepository(AppDbContext appDb) 
                : Repository<UserRole>(appDb), 
                    IUserRole
{ }
