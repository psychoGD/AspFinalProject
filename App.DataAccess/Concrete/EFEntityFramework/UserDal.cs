﻿using App.Core.DataAccess.EntityFramework;
using App.DataAccess.Abstract;
using App.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Concrete.EFEntityFramework
{
    internal class UserDal:EfEntityRepositoryBase<User,SocialMediaDBContext>,IUserDal
    {
    }
}
