using App.Core.DataAccess;
using App.Core.Entities;
using App.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAcccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
    }
}
