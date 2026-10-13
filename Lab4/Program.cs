using System.Security.Cryptography;

Console.WriteLine("How many round trip miles are needed? ");
int roundTripMiles = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many miles per gallon are needed? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How is the price per gallon? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());


/* Pizza Party */
Console.WriteLine("How many pizzas are needed? ");
double pizzaCount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the price per pizza? ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());


const int pizzaSlice = '8';
double pizzaCost = pizzaCount * pizzaPrice;

/* Paycheck */
const double taxRate = 0.18;

string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.8};

double nameLength = names.Length;

static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
    
}


double fuel = FuelCost(260, 28, 2.89);
double tripTotal = fuel + pizzaCost;
double pizzaSlices = pizzaCount / pizzaSlice;
double totalCost = tripTotal / nameLength;


Console.WriteLine("=== Part 1: The Trip ===");
Console.WriteLine("Fuel cost: " + fuel);
Console.WriteLine("Pizza cost: " + pizzaPrice);
Console.WriteLine("Trip total: " + tripTotal);
Console.WriteLine("=== Part 2: The Group ===");
Console.WriteLine("People going: " + nameLength);
Console.WriteLine("Slices each: " + pizzaSlices);
Console.WriteLine("Cost per person: " + totalCost);

/* static double TakeHomePay(double hours, double hourlyRate, double taxRate);


static double HoursToCover(double amountOwed, double takeHomePerHour);
*/