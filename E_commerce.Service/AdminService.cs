using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Abstract;
using E_commerce.Data;

namespace E_commerce.Service
{
    class AdminService : IAdminService
    {
        private IRepositorie<Admin> AdminRepos;

        public AdminService(IRepositorie<Admin> admin)
        {
            this.AdminRepos = admin;
        }

        public bool addAdmin(Admin user)
        {
            IEnumerable<Admin> users = AdminRepos.getAll().Where(client => client.username == user.username);
            if (users.Equals(null))
            {
                return AdminRepos.Ajouter(user);
            }
            return false;
        }

        public bool editAdmin(Admin user)
        {
            return AdminRepos.Modifier(user);
        }

        public IQueryable<Admin> getAdmins()
        {
            return AdminRepos.Table;
        }

        public Admin getClient(int id)
        {
            return AdminRepos.Recherche(id);
        }

        public bool removeAdmin(Admin user)
        {
            return AdminRepos.Supprimer(user);
        }
    }
}
