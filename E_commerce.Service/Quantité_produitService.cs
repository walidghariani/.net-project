using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Abstract;
using E_commerce.Data;

namespace E_commerce.Service
{
    class Quantité_produitService:IQuantité_produitService
    {
        private IRepositorie<Quantité_produit> QPRepos;

        public Quantité_produitService(IRepositorie<Quantité_produit> qp)
        {
            this.QPRepos = qp;
        }

        public bool addQuantité_produit(Quantité_produit quantité_produit)
        {
            return this.QPRepos.Ajouter(quantité_produit);
        }

        public bool editQuantité_produitr(Quantité_produit quantité_produit)
        {
            return this.QPRepos.Modifier(quantité_produit);
        }

        public Quantité_produit getQuantité_produit(int id)
        {
            return this.QPRepos.Recherche(id);
        }

        public IQueryable<Quantité_produit> getQuantité_produits()
        {
            return this.QPRepos.Table;
        }

        public bool removeQuantité_produit(Quantité_produit quantité_produit)
        {
            return this.QPRepos.Supprimer(quantité_produit);
        }
    }
}
