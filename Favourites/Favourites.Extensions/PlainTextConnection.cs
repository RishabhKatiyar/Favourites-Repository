namespace Favourites.Extensions
{
    using Favourites.Core;
    using Favourites.Interfaces;
    using System.Collections;
    using System.ComponentModel.Composition;

    [Export(typeof(IOperation))]
    [ExportMetadata("ConnectionType", "PlainText")]
    class PlainTextConnection : IOperation
    {
        public void Add(Favourite favourite)
        {

        }

        public void Edit(Favourite favourite)
        {

        }

        public Favourite FindByID(string ID)
        {
            return new Favourite { ID = "1", ParentID = "", Name = "facebook", URL = "www.facebook.com" };
        }

        public IEnumerable GetFavourites()
        {
            Favourite[] favourites = new Favourite[]
            {
                new Favourite{ID="1", ParentID="", Name="facebook", URL="www.facebook.com"},
                new Favourite{ID="2", ParentID="", Name="twitter", URL="www.twitter.com"}
            };
            return favourites;
        }

        public void Remove(string ID)
        {

        }
    }
}
