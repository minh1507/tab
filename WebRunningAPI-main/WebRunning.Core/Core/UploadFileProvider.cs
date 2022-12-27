﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using WebRunning.Core.Interfaces;
using WebRunning.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebRunning.Core.Core
{
    public class UploadFileProvider: IUploadFileProvider
    {
        public string BuildSavePathYYYYMMDD(string savePath)
        {
            string path = string.Empty;
            try
            {                
                DateTime now = DateTime.Now;
                path = Path.Combine(savePath, now.Year.ToString(), now.Month.ToString(), now.Day.ToString());
                if (!File.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch { }
            return path;
        }
     
    }
}
