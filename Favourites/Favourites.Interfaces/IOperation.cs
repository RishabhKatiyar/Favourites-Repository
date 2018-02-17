namespace Favourites.Interfaces
{
    using Favourites.Core;
    using System.Collections;

    public interface IOperation
    {
        void Add(Favourite favourite);
        void Edit(Favourite favourite);
        void Remove(string ID);
        IEnumerable GetFavourites();
        Favourite FindByID(string ID);
    }
    public interface IOperationData
    {
        string ConnectionType { get; }
    }
}
