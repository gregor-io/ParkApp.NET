/*
 * Filename: ParkApp.cs
 * Author: Tyler Gregory
 * Date: September 2023
*/

using Parkapp;
using static System.Console;

namespace ParkApp
{
    public class ParkApp 
    {
        static void Main()
        {
            Park testPark = new Park("Zion",
                                "Utah",
                                "National Park",
                                ["Tram", "Bus", "Rock Climbing"],
                                500,
                                750000.00,
                                100,000,
                                5.00);
            Write("Hello?");
            
        }
    }
}