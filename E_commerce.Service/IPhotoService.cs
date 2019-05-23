using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Abstract;
using E_commerce.Data;

namespace E_commerce.Service
{
    interface IPhotoService
    {
        bool addPhoto(Photo photo);
        bool editPhoto(Photo photo);
        bool removePhoto(Photo photo);
        Photo getPhoto(int id);
        IQueryable<Photo> getPhotos();
    }
}
