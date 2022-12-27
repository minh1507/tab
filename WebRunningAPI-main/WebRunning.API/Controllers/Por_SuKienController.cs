using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebRunning.API.Infrastructure.Authorization;
using WebRunning.API.Service;
using WebRunning.API.Controllers;
using WebRunning.API.Model;
using WebRunning.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRunning.API.Controllers
{
    public class Por_SuKienController : ApiControllerBase<Por_SuKien>
    {
        private readonly IServiceWrapper _service;
        private readonly ILogger<Por_SuKienController> _logger;
        public Por_SuKienController(IServiceWrapper service, ILogger<Por_SuKienController> logger) :base(service, logger)
        {
            _service = service;
            _logger = logger;
        }
    }
}
