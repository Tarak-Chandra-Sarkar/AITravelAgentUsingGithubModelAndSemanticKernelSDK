using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HotelBookingPlugin
{
    [KernelFunction, Description("Book a Hotel")]
    public static string book_hotel()
    {
        return "Hotel Booked!";
    }
}
