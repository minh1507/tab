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
    public class Por_TinTucController : ApiControllerBase<Por_TinTuc>
    {
        private readonly IServiceWrapper _service;
        private readonly ILogger<Por_TinTucController> _logger;
        public Por_TinTucController(IServiceWrapper service, ILogger<Por_TinTucController> logger) :base(service, logger)
        {
            _service = service;
            _logger = logger;
        }
    }
}
