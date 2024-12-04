//Conrad Nobert - Assignment 04 - Fall 2024
class Program
{
    static void Main(string[] args)
    {
        bool displayMenu = true;
        string mainMenuChoice = "";
        List<Customer> customers = new List<Customer>();

        //todo: call the "LoadCustomersFromFile()" method
        DisplayIntro();

        do
        {
            DisplayMainMenu();
            mainMenuChoice = PromptString("Enter MAIN MENU option: ").ToUpper();
            switch(mainMenuChoice)
            {
                case "D":
                    break;
                case "S":
                    break;
                case "A":
                    AddNewCustomer(customers);
                    break;
                case "E":
                    break;
                case "R":
                    break;
                case "V":
                    break;
                case "Q":
                    break;
                default:
                    break;

            }
        }while(displayMenu);
    }

    static void DisplayIntro()
    {
        Console.WriteLine(
            "\n\n\n\n\n\n\n\n\n\nAssignment 04 " + 
            "Written by Conrad Nobert - Fall 2024\n"
        );
    }

    static void DisplayMainMenu()
    {
        //todo: print the main menu to the console
        Console.WriteLine(
            "[D]isplay Customers\n" + 
            "[S]earch Customers\n" + 
            "[A]dd New Customer\n" + 
            "[E]dit Customer\n" + 
            "[R]emove Customer\n" + 
            "[V]iew Customer Details\n" + 
            "[Q]uit\n"
        );
    }

    //todo: declare AddNewCustomer
    //prompt the user for customer data
    //create a customer with that data
    //add the customer to the list
    static void AddNewCustomer(List<Customer> customers)
    {
        //if this was coded, it would be pretty sweet.
    }
    
    #region prompt methods
    static string PromptString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
    static int PromptInt(string prompt)
    {
        int theInt = 0;
        bool validInt = false;
        do
        {
            try
            {
                Console.Write(prompt);
                theInt = int.Parse(Console.ReadLine());
                validInt = true;
            }
            catch
            {
                Console.Write("Please enter a whole number. Try again: ");
            }
        }
        while (!validInt);

        return theInt;
    }
    
    static double PromptDouble(string prompt)
    {
        double theDouble = 0;
        bool validDouble = false;
        do
        {
            try
            {
                Console.Write(prompt);
                theDouble = double.Parse(Console.ReadLine());
                validDouble = true;
            }
            catch
            {
                Console.Write("Please enter a valid number. Try again: ");
            }
        }
        while (!validDouble);
        
        return theDouble;
    }
    #endregion

}
class Customer
{
    #region fields
    private string _firstName;
    private string _lastName;
    private int _orderCount;
    private double _totalSales;
    #endregion

    #region properties
    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            if(string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new Exception("First name cannot be empty.");
            }
            _firstName = value.Trim();
        }
    }
    public string LastName
    {
        get 
        { 
            return _lastName; 
        }
        set 
        { 
            //data validation goes here
            _lastName = value; 
        }
    }

    public int OrderCount
    {
        get 
        { 
            return _orderCount; 
        }
        set 
        { 
            _orderCount = value; 
        }
    }

    public double TotalSales
    {
        get 
        { 
            return _totalSales; 
        }
        set 
        { 
            _totalSales = value; 
        }
    }
    
    //TODO: write the AverageOrder property -it's read only, it returns the average order
    //and it does not blow up if there are zero orders

    public double AverageOrder
    {
        get
        {
            double theAverage = 0;
            if(OrderCount == 0)
            {
                ;
            }
            else
            {
                //here the actually compute the average
            }
            return theAverage;
        }
    }
    
    public string FullName
    {
        get
        {
            //return as a string the customer's full name in the format LastName,FirstName.
            return "placeholder";
        }
    }
    
    #endregion

    #region methods
    public Customer(string firstName, string lastName, int orderCount, double totalSales)
    {
        //assign each of the four parameters to the fields, using the properties
    }


    #endregion
}