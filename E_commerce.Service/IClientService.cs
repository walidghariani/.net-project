using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Abstract;
using E_commerce.Data;

namespace E_commerce.Service
{
    interface IClientService
    {
        bool addClient(Utilisateur user);
        bool editClient(Utilisateur user);
        bool removeClient(Utilisateur user);
        Utilisateur getClient(int id);
        IQueryable<Utilisateur> getClients();
    }
}
