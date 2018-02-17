namespace Favourites.Core
{
    public class Favourite
    {
        private string _ID;
        private string _ParentID;
        private string _Name;
        private string _Category;
        private string _URL;

        public string ID
        { get; set; }
        public string ParentID
        { get; set; }
        public string Name
        { get; set; }
        public string Category
        { get; set; }
        public string URL
        { get; set; }

    }
}
