namespace Favourites.Infrastructurer
{
    using Favourites.Core;
    using Favourites.Core.Interfaces;
    using Favourites.Infrastructure;
    using Favourites.Infrastructure.Interfaces;
    using System;
    using System.Collections;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;

    public class FavouriteRepository: IFavouriteRepository
    {
        private CompositionContainer _container;

        [Import(typeof(IFavouriteContext))]
        private IFavouriteContext favouriteContext;

        public FavouriteRepository()
        {
            //An aggregate catalog that combines multiple catalogs  
            var catalog = new AggregateCatalog();
            //Adds all the parts found in the same assembly as the Program class  
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(FavouriteRepository).Assembly));
            catalog.Catalogs.Add(new DirectoryCatalog("D:\\Documents\\Favourites-Repository\\Favourites\\Extensions"));
            //Create the CompositionContainer with the parts in the catalog  
            _container = new CompositionContainer(catalog);

            //Fill the imports of this object  
            try
            {
                this._container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }

            favouriteContext.ConnectionType = "PlainText";
        }

        public void Add(Favourite favourite)
        {
            favouriteContext.Add(favourite);
        }

        public void Edit(Favourite favourite)
        {
            favouriteContext.Edit(favourite);
        }

        public void Remove(string ID)
        {
            favouriteContext.Remove(ID);
        }

        public IEnumerable GetFavourites()
        {
            return favouriteContext.GetFavourites();
        }

        public Favourite FindByID(string ID)
        {
            return favouriteContext.FindByID(ID);
        }
    }
}
