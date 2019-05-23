using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Data;
using E_commerce.Abstract;

namespace E_commerce.Service
{
    class ClientService : IClientService
    {
        private IRepositorie<Utilisateur> ClientsRepos;

        public ClientService(IRepositorie<Utilisateur> cr)
        {
            this.ClientsRepos = cr;
        }
        public bool addClient(Utilisateur user)
        {
            IEnumerable<Utilisateur> users=ClientsRepos.getAll().Where(client => client.username == user.username);
            if (users.Equals(null))
            {
                return ClientsRepos.Ajouter(user);
            }
            return false;
        }

        public bool editClient(Utilisateur user)
        {
            return ClientsRepos.Modifier(user);
        }

        public Utilisateur getClient(int id)
        {
            return ClientsRepos.Recherche(id);
        }

        public IQueryable<Utilisateur> getClients()
        {
            return ClientsRepos.Table;
        }

        public bool removeClient(Utilisateur user)
        {
            return ClientsRepos.Supprimer(user);
        }
    }
}
