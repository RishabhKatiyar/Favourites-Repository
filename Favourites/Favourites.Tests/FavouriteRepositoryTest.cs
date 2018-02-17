namespace Favourites.Tests
{
    using Favourites.Infrastructurer;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    [TestClass]
    public class FavouriteRepositoryTest
    {
        FavouriteRepository Repo;

        [TestInitialize]
        public void TestSetup()
        {
            Repo = new FavouriteRepository();
        }

        [TestMethod]
        public void IsRepoInitialized()
        {
            var result = Repo.GetFavourites();
            Assert.IsNotNull(result);
        }
    }
}
