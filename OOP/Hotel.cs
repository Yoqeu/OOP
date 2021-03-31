using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Hotel
    {
        string hotel_name = "Trivago";
        bool free_rooms;
        int number_of_rooms = 100;
        float income, profit;
        
        public string Get_Info()
        {
            return ($"Название отеля: {hotel_name}");
        }


    }
}
