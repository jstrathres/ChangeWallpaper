using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ChangeBackground
{
    class backgroundChanger
    {
        //sets wallpaper
        public const int SPI_SETDESKWALLPAPER = 20;
        public const int SPIF_UPDATEINFILE = 1;
        public const int SPIF_SENDCHANGE = 2;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
        static void Main(string[] args)
        {
            Random random = new Random();
            int index = random.Next(0, 5);
            string[] imageNames = { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg" } ;
            string imagePath = @"C:\EnterYourWallPaperFileHereWithAtLeast5Images\" + imageNames[index];

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imagePath, SPIF_UPDATEINFILE | SPIF_SENDCHANGE);
        }
    }
}
