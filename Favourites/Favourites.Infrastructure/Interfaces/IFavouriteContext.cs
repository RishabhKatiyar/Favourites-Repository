namespace Favourites.Infrastructure.Interfaces
{
    using Favourites.Core;
    using System.Collections;

    public interface IFavouriteContext
    {
        string ConnectionType
        { get; set; }
        void Add(Favourite favourite);
        void Edit(Favourite favourite);
        void Remove(string ID);
        IEnumerable GetFavourites();
        Favourite FindByID(string ID);
    }
}