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
            // string[] facilities = {"Bus", "Rock Climbing"};
            Park testPark = new Park("Zion",
                                "Utah",
                                "National Park",
                                "Bus, Rock Climbing",
                                500,
                                750000.00,
                                100000,
                                5.00);
            Write(testPark);
            Write(testPark.GetFacilities());
            Write(testPark.GetAnnualReport());
            
        }
    }
}