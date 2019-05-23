using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Abstract;
using E_commerce.Data;

namespace E_commerce.Service
{
    interface ICategorieService
    {
        bool addCataloge(Cataloge user);
        bool editCataloge(Cataloge user);
        bool removeCataloge(Cataloge user);
        Cataloge getCataloge(int id);
        IQueryable<Cataloge> getCataloges();
    }
}
