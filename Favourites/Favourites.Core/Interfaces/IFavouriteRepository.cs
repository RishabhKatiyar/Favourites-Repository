namespace Favourites.Core.Interfaces
{
    using System.Collections;
    public interface IFavouriteRepository
    {
        void Add(Favourite favourite);
        void Edit(Favourite favourite);
        void Remove(string ID);
        IEnumerable GetFavourites();
        Favourite FindByID(string ID);
    }
}
