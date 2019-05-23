using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Abstract;
using E_commerce.Data;

namespace E_commerce.Service
{
    interface IProduitService
    {
        bool addProduit(Produit produit);
        bool editProduit(Produit produit);
        bool removeProduit(Produit produit);
        Produit getProduit(int id);
        IQueryable<Produit> getProduits();
    }
}
