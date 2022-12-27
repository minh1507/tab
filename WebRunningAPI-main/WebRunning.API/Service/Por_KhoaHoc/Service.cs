using Microsoft.EntityFrameworkCore;
using WebRunning.API.Infrastructure;
using WebRunning.Core.Constant;
using WebRunning.Core.Helpers;
using WebRunning.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRunning.API.Service.Por_KhoaHoc
{
    public class Service:RepositoryBase<Model.Por_KhoaHoc>, Por_KhoaHoc.IService
    {
        private readonly DomainDbContext _dbContext;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IUserProvider _userProvider;
        public Service(DomainDbContext dbContext, IDateTimeProvider dateTimeProvider, IUserProvider userService):base(dbContext, dateTimeProvider, userService)
        {
            _dbContext = dbContext;
            _dateTimeProvider = dateTimeProvider;
            _userProvider = userService;
        }
    }
}
