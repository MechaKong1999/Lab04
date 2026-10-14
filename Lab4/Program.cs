using System.Security.Cryptography;

// the trip
Console.WriteLine("How many round trip miles are needed? ");
int roundTripMiles = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many miles per gallon are needed? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How is the price per gallon? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

// pizza party
Console.WriteLine("How many pizzas are needed? ");
double pizzaCount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the price per pizza? ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());


// pizza variables
const int pizzaSlice = 8;
double pizzaCost = pizzaCount * pizzaPrice;

// tax rate for paycheck
const double taxRate = 0.18;

//arrays 
string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.8};

// number of total people attending
double nameLength = names.Length;

// calculating fuel cost
static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
    
}

// calculating take home pay after tax
static double TakeHomePay(double[] hoursWorked, double[] hourlyRates, double taxRate)
{
    for(int i = 0; i < hoursWorked.Length; i++)
    {
        if ((i + 1 ) == 1)
        {
            double grossPay = hoursWorked[1] * hourlyRates[1];
            double taxWithheld = grossPay * taxRate;
            return grossPay - taxWithheld;
        }
        else if ((i + 1) == 2)
        {
            double grossPay = hoursWorked[2] * hourlyRates[2];
            double taxWithheld = grossPay * taxRate;
            return grossPay - taxWithheld;
        }
        else if ((i + 1) == 3)
        {
            double grossPay = hoursWorked[3] * hourlyRates[3];
            double taxWithheld = grossPay * taxRate;
            return grossPay - taxWithheld;
        }
        else if ((i + 1) == 4)
        {
            double grossPay = hoursWorked[4] * hourlyRates[4];
            double taxWithheld = grossPay * taxRate;
            return grossPay - taxWithheld;
        }

    }
    
}

// calculating hours needed
static double HoursToCover(double totalCost, double takeHomePerHour)
{
    for(int i = 0; i < 5; i++)
    {
        if ((i + 1 ) == 1)
        {
            double totalHours = totalCost * takeHomePerHour;
            return totalHours;
        }

    }
    
}


double fuel = FuelCost(260, 28, 2.89);
double tripTotal = fuel + pizzaCost;
double pizzaSlices = pizzaCount / pizzaSlice;
double totalCost = tripTotal / nameLength;
double takeHomePerHour = TakeHomePay(hoursWorked, hourlyRates, taxRate);

Console.WriteLine("=== Part 1: The Trip ===");
Console.WriteLine("Fuel cost: " + fuel.ToString("C"));
Console.WriteLine("Pizza cost: " + pizzaPrice.ToString("C"));
Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
Console.WriteLine("=== Part 2: The Group ===");
Console.WriteLine("People going: " + nameLength);
Console.WriteLine("Slices each: " + pizzaSlices);
Console.WriteLine("Cost per person: " + totalCost.ToString("C"));
Console.WriteLine("=== Part 3: Who Works How Long? ===");
Console.WriteLine();


