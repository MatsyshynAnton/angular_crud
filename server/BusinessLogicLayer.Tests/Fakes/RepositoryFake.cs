using DataAccessLayer.Models.Abstractions;
using DataAccessLayer.Repositories;
using DataAccessLayer.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Tests.Fakes
{
    public class RepositoryFake<T> : Repository<T>
        where T:BaseEntity
    {
        public RepositoryFake(HomeworkDbContextFake context, IUnitOfWork unitOfWork)
            : base(context, unitOfWork)
        {
            context.Database.EnsureCreated();
        }
    }
}
