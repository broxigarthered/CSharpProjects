using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._0TorrentPIrate
{
    class Program
    {
        static void Main(string[] args)
        {
            double download = double.Parse(Console.ReadLine()); // megabytesInTotal
            double cinema = double.Parse(Console.ReadLine());// how much would cost the cinema
            double wife = double.Parse(Console.ReadLine()); // money per hour for wife

            double hoursInTheMall = download / 2 / 60 / 60;
            double priceForDownload = hoursInTheMall * wife;
            double priceForDownloadResult = Math.Round(priceForDownload, 2);
            double numberOfMoviesDownloaded = download / 1500;
            double cinemaPrice = numberOfMoviesDownloaded * cinema;

            //0 ? 0 : 1;

            if (cinemaPrice<priceForDownloadResult)
            {
                Console.WriteLine("cinema -> {0:F2}lv",cinemaPrice);
            }
            else
            {
                Console.WriteLine("mall -> {0:F2}lv",priceForDownloadResult);
            }

            //string omg = priceForDownload.ToString("#.##");
            //Console.WriteLine(omg);
            //Console.WriteLine("{0:F2}",priceForDownloadResult);
        }

    }
}
