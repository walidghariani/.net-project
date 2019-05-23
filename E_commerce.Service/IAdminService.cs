using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Abstract;
using E_commerce.Data;

namespace E_commerce.Service
{
    interface IAdminService
    {
        bool addAdmin(Admin user);
        bool editAdmin(Admin user);
        bool removeAdmin(Admin user);
        Admin getClient(int id);
        IQueryable<Admin> getAdmins();
    }
}
