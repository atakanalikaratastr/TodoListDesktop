using Core.DataAccess.EntityFramework;
using NTier.DataAccess.Abstract;
using NTier.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTier.DataAccess.Concrete.EntityFramework
{
    public class EfTaskDAL : RepositoryBase<Task, NTier_Context>, ITaskDAL
    {
    }
}
