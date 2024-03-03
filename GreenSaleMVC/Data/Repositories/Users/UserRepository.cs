using GreenSaleMVC.Data.Entities.Users;
using GreenSaleMVC.Data.Interfaces;

namespace GreenSaleMVC.Data.Repositories;

public class UserRepository(AppDbContext appDb) 
                : Repository<User>(appDb) , 
                    IUser
{ }
