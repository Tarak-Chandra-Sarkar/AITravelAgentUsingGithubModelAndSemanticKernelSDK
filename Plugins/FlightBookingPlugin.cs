using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FlightBookingPlugin
{
    [KernelFunction, Description("Book a Flight")]
    public static string book_flight()
    {
        return "Flight Booked!";
    }
}
