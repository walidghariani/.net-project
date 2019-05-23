using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Abstract;
using E_commerce.Data;

namespace E_commerce.Service
{
    class CommandeService:ICommandeService
    {
        private IRepositorie<Commande> CommandeRepos;

        public CommandeService(IRepositorie<Commande> cmd)
        {
            this.CommandeRepos = cmd;
        }

        public bool addCommande(Commande commande)
        {
            return this.CommandeRepos.Ajouter(commande);
        }

        public bool editCommande(Commande commande)
        {
            return this.CommandeRepos.Modifier(commande);
        }

        public Commande getCommande(int id)
        {
            return this.CommandeRepos.Recherche(id);
        }

        public IQueryable<Commande> getCommandes()
        {
            return this.CommandeRepos.Table;
        }

        public bool removeCommande(Commande commande)
        {
            return this.CommandeRepos.Supprimer(commande);
        }
    }
}
