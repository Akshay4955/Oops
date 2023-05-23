namespace Photo_Album
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to photo album project");

            PhotoAlbum photoAlbum1 = new PhotoAlbum();
            Console.WriteLine(photoAlbum1.GetNumberOfPages());

            PhotoAlbum photoAlbum2 = new PhotoAlbum(24);
            Console.WriteLine(photoAlbum2.GetNumberOfPages());

            BigPhotoAlbum bigPhotoAlbum = new BigPhotoAlbum();
            bigPhotoAlbum.GetNumberOfPages();

        }
    }
}