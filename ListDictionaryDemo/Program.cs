namespace ListDictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables to control the loop and check for validity.
            string cont = "Y";
            bool check = false;

            //initiating 5 objects.
            Country C1 = new Country("Sweden", "swe", "Stockholm") ;
            Country C2 = new Country("Canada", "can", "Ottawa");
            Country C3 = new Country("Norge", "nor", "Oslo");
            Country C4 = new Country("Syrien", "Syr", "Damascus");
            Country C5 = new Country("Algeriet", "DZA", "Alger");

            //Creating a list of the 5 objects.
            List<Country> countries = new List<Country>()
            {
                C1, C2, C3, C4, C5
            };
            
            //Loop that runs based on user input.
            while (cont != "N")
            {
                Console.WriteLine("Write a country code: ");
                string input = Console.ReadLine().ToUpper();
                
                //foreach to iterate through the list.
                foreach (Country country in countries)
                {
                    //if the user input exists:
                    if (country.Code.Contains(input))
                    {
                        //print the name and the capital of the country.
                        Console.WriteLine(country.Name + " " + country.Capital);
                        //check is false to prevent the if-statement below from running.
                        check = false;
                        //breaks out of the foreach-iteration.
                        break;
                    }
                    //if user input does not exist:
                    if (!country.Code.Contains(input))
                    {
                        //check will be set to true so the next if-statement runs.
                        check = true;
                    }
                }

                //this will only run if user input did not exist within the list.
                if (check)
                {
                    Console.WriteLine("Code not valid.");
                }

                //check if user wants to try again through a variable that controls the while-loop.
                Console.WriteLine("Do you want to try again? Y or N");
                cont = Console.ReadLine().ToUpper();
            }
        }
    }
}