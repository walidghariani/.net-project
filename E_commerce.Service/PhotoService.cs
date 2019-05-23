using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Data;
using E_commerce.Abstract;

namespace E_commerce.Service
{
    class PhotoService : IPhotoService
    {
        private IRepositorie<Photo> PhotoRepos;

        public bool addPhoto(Photo photo)
        {
            IEnumerable<Photo> users = PhotoRepos.getAll().Where(client => client.emplacement== photo.emplacement);
            if (users.Equals(null))
            {
                return PhotoRepos.Ajouter(photo);
            }
            return false;
        }

        public bool editPhoto(Photo photo)
        {
            return PhotoRepos.Modifier(photo);
        }

        public Photo getPhoto(int id)
        {
            return PhotoRepos.Recherche(id);
        }

        public IQueryable<Photo> getPhotos()
        {
            return PhotoRepos.Table;
        }

        public bool removePhoto(Photo photo)
        {
            return PhotoRepos.Supprimer(photo);
        }
    }
}
