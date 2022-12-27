﻿using Microsoft.AspNetCore.Http;
using WebRunning.Core.Interfaces;
using WebRunning.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRunning.API.Service.Sys_File
{
    public interface IService: IRepositoryBase<Model.Sys_File>
    {
        Task<List<FileResult>> Upload(List<IFormFile> files, string objectId, string objectType, string savedPath);
        Task<List<FileResult>> GetByObjectId(string objectId, string objectType);
    }
}
