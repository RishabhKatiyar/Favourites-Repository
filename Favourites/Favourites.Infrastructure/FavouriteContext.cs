namespace Favourites.Infrastructure
{
    using Favourites.Core;
    using Favourites.Infrastructure.Interfaces;
    using Favourites.Interfaces;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;

    [Export(typeof(IFavouriteContext))]
    class FavouriteContext : IFavouriteContext
    {
        public string ConnectionType
        { get; set; }

        [ImportMany]
        IEnumerable<Lazy<IOperation, IOperationData>> operations;

        public void Add(Favourite favourite)
        {
            foreach (Lazy<IOperation, IOperationData> op in operations)
            {
                if (op.Metadata.ConnectionType.Equals(ConnectionType))
                {
                    op.Value.Add(favourite);
                }
            }
        }

        public void Edit(Favourite favourite)
        {
            foreach (Lazy<IOperation, IOperationData> op in operations)
            {
                if (op.Metadata.ConnectionType.Equals(ConnectionType))
                {
                    op.Value.Edit(favourite);
                }
            }
        }

        public Favourite FindByID(string ID)
        {
            foreach (Lazy<IOperation, IOperationData> op in operations)
            {
                if (op.Metadata.ConnectionType.Equals(ConnectionType))
                {
                    return op.Value.FindByID(ID);
                }
            }
            return new Favourite { ID = "1", ParentID = "", Name = "facebook", URL = "www.facebook.com" };
        }

        public IEnumerable GetFavourites()
        {
            foreach (Lazy<IOperation, IOperationData> op in operations)
            {
                if (op.Metadata.ConnectionType.Equals(ConnectionType))
                {
                    return op.Value.GetFavourites();
                }
            }

            Favourite[] favourites = new Favourite[]
            {
                new Favourite{ID="1", ParentID="", Name="facebook", URL="www.facebook.com"},
                new Favourite{ID="2", ParentID="", Name="twitter", URL="www.twitter.com"}
            };
            return favourites;
        }

        public void Remove(string ID)
        {
            foreach (Lazy<IOperation, IOperationData> op in operations)
            {
                if (op.Metadata.ConnectionType.Equals(ConnectionType))
                {
                    op.Value.Remove(ID);
                }
            }
        }
    }
}
