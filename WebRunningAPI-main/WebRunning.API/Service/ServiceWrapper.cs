using Microsoft.Extensions.Configuration;
using WebRunning.API.Infrastructure;
using WebRunning.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRunning.API.Service
{
    public class ServiceWrapper : IServiceWrapper
    {
        private readonly DomainDbContext _context;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IUserProvider _userProvider;
        private Sys_AuthToken.IService _sys_authtoken;
        private Sys_Category.IService _sys_category;
        private Sys_User.IService _sys_user;
        private Sys_Role.IService _sys_role;
        private Sys_Config.IService _sys_config;
        private Sys_Resource.IService _sys_resource;
        private Sys_Organization.IService _sys_organization;
        private Sys_Permission.IService _sys_permission;
        private Sys_File.IService _sys_file;
        private Sys_Notification.IService _sys_notification;
        private Por_Menu.IService _por_menu;
        private Por_NhomTinTuc.IService _por_nhomtintuc;
        private Por_TinTuc.IService _por_tintuc;
        private Por_MonHoc.IService _por_monhoc;
        private Por_KhoaHoc.IService _por_khoahoc;
        private Por_SuKien.IService _por_sukien;
        private Por_DangKyTuVan.IService _por_dangkytuvan;

        public ServiceWrapper(DomainDbContext context, IDateTimeProvider dateTimeProvider, IUserProvider userService, IConfiguration configuration)
        {
            _context = context;
            _dateTimeProvider = dateTimeProvider;
            _userProvider = userService;
        }
        /*Start Portal*/
        public Por_Menu.IService Por_Menu
        {
            get
            {
                if (_por_menu == null)
                {
                    _por_menu = new Por_Menu.Service(_context, _dateTimeProvider, _userProvider);
                }

                return _por_menu;
            }
        }
        /*End Portal*/

        public Por_NhomTinTuc.IService Por_NhomTinTuc
        {
            get
            {
                if (_por_nhomtintuc == null)
                {
                    _por_nhomtintuc = new Por_NhomTinTuc.Service(_context, _dateTimeProvider, _userProvider);
                }

                return _por_nhomtintuc;
            }
        }

        public Por_TinTuc.IService Por_TinTuc
        {
            get
            {
                if(_por_tintuc == null)
                {
                    _por_tintuc = new Por_TinTuc.Service(_context, _dateTimeProvider, _userProvider);
                }

                return _por_tintuc;
            }
        }

        public Por_MonHoc.IService Por_MonHoc
        {
            get
            {
                if(_por_monhoc == null)
                {
                    _por_monhoc = new Por_MonHoc.Service(_context, _dateTimeProvider, _userProvider);
                }
                return _por_monhoc;
            }
        }

        public Por_KhoaHoc.IService Por_KhoaHoc
        {
            get
            {
                if (_por_khoahoc == null)
                {
                    _por_khoahoc = new Por_KhoaHoc.Service(_context, _dateTimeProvider, _userProvider);
                }
                return _por_khoahoc;
            }
        }

        public Por_SuKien.IService Por_SuKien
        {
            get
            {
                if (_por_sukien == null)
                {
                    _por_sukien = new Por_SuKien.Service(_context, _dateTimeProvider, _userProvider);
                }
                return _por_sukien;
            }
        }

        public Por_DangKyTuVan.IService Por_DangKyTuVan
        {
            get
            {
                if(_por_dangkytuvan == null)
                {
                    _por_dangkytuvan = new Por_DangKyTuVan.Service(_context, _dateTimeProvider, _userProvider);
                }
                return _por_dangkytuvan;
            }
        }


        public Sys_Notification.IService Sys_Notification
        {
            get
            {
                if (_sys_notification == null)
                {
                    _sys_notification = new Sys_Notification.Service(_context, _dateTimeProvider, _userProvider);
                }

                return _sys_notification;
            }
        }
        public Sys_AuthToken.IService Sys_AuthToken
        {
            get
            {
                if (_sys_authtoken == null)
                {
                    _sys_authtoken = new Sys_AuthToken.Service(_context, _dateTimeProvider, _userProvider);
                }

                return _sys_authtoken;
            }
        }
        public Sys_File.IService Sys_File
        {
            get
            {
                if (_sys_file == null)
                {
                    _sys_file = new Sys_File.Service(_context, _dateTimeProvider, _userProvider);
                }

                return _sys_file;
            }
        }
        public Sys_Category.IService Sys_Category
        {
            get
            {
                if (_sys_category == null)
                {
                    _sys_category = new Sys_Category.Service(_context, _dateTimeProvider, _userProvider);
                }

                return _sys_category;
            }
        }
        public Sys_User.IService Sys_User
        {
            get
            {
                if (_sys_user == null)
                {
                    _sys_user = new Sys_User.Service(_context, _dateTimeProvider, _userProvider);
                }

                return _sys_user;
            }
        }
        public Sys_Organization.IService Sys_Organization
        {
            get
            {
                if (_sys_organization == null)
                {
                    _sys_organization = new Sys_Organization.Service(_context, _dateTimeProvider, _userProvider);
                }

                return _sys_organization;
            }
        }
        public Sys_Role.IService Sys_Role
        {
            get
            {
                if (_sys_role == null)
                {
                    _sys_role = new Sys_Role.Service(_context, _dateTimeProvider, _userProvider);
                }

                return _sys_role;
            }
        }
        public Sys_Config.IService Sys_Config
        {
            get
            {
                if (_sys_config == null)
                {
                    _sys_config = new Sys_Config.Service(_context, _dateTimeProvider, _userProvider);
                }

                return _sys_config;
            }
        }
        public Sys_Resource.IService Sys_Resource
        {
            get
            {
                if (_sys_resource == null)
                {
                    _sys_resource = new Sys_Resource.Service(_context, _dateTimeProvider, _userProvider);
                }

                return _sys_resource;
            }
        }
        public Sys_Permission.IService Sys_Permission
        {
            get
            {
                if (_sys_permission == null)
                {
                    _sys_permission = new Sys_Permission.Service(_context, _dateTimeProvider, _userProvider);
                }

                return _sys_permission;
            }
        }
    }
}
