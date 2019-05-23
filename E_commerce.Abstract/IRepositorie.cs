using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Abstract
{
    public interface IRepositorie<Tentite>
    {
        Tentite Recherche(int TPk);
        bool Ajouter(Tentite entity);
        bool Modifier(Tentite entity);
        bool Supprimer(Tentite entity);
        IQueryable<Tentite> Table { get; }
        IQueryable<Tentite> getAll();
    }
}
