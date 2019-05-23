using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Abstract;
using E_commerce.Data;

namespace E_commerce.Service
{
    interface ICommandeService
    {
        bool addCommande(Commande commande);
        bool editCommande(Commande commande);
        bool removeCommande(Commande commande);
        Commande getCommande(int id);
        IQueryable<Commande> getCommandes();
    }
}
