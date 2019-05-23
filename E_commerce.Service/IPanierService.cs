using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Abstract;
using E_commerce.Data;

namespace E_commerce.Service
{
    interface IPanierService
    {
        bool addPanier(Panier panier);
        bool editPanier(Panier panier);
        bool removePanier(Panier panier);
        Panier getPanier(int id);
        IQueryable<Panier> getPaniers();
    }
}
