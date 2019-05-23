using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Abstract;
using E_commerce.Data;

namespace E_commerce.Service
{
    interface IQuantité_produitService
    {
        bool addQuantité_produit(Quantité_produit quantité_produit);
        bool editQuantité_produitr(Quantité_produit quantité_produit);
        bool removeQuantité_produit(Quantité_produit quantité_produit);
        Quantité_produit getQuantité_produit(int id);
        IQueryable<Quantité_produit> getQuantité_produits();
    }
}
