namespace Photo_Album
{
    public class PhotoAlbum
    {
        protected int numberOfPages;

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int n)
        {
            numberOfPages = n;
        }
    }
}