using WebRunning.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRunning.API.Service
{
    public interface IServiceWrapper
    {
        Sys_AuthToken.IService Sys_AuthToken { get; }
        Sys_File.IService Sys_File { get; }
        Sys_User.IService Sys_User { get; }
        Sys_Category.IService Sys_Category { get; }
        Sys_Organization.IService Sys_Organization { get; }
        Sys_Role.IService Sys_Role { get; }
        Sys_Config.IService Sys_Config { get; }
        Sys_Permission.IService Sys_Permission { get; }
        Sys_Resource.IService Sys_Resource { get; }
        Sys_Notification.IService Sys_Notification { get; }
        Por_Menu.IService Por_Menu { get; }
        
        Por_NhomTinTuc.IService Por_NhomTinTuc { get; }

        Por_TinTuc.IService Por_TinTuc { get; }

        Por_MonHoc.IService Por_MonHoc { get; }

        Por_KhoaHoc.IService Por_KhoaHoc { get; }

        Por_SuKien.IService Por_SuKien { get; }

        Por_DangKyTuVan.IService Por_DangKyTuVan { get; }
    }
}
