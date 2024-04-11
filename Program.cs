using poe_part1._0;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        string userInput;
        do
        {
            // DECLARATION OF GLOBAL VARIABLES
            int numIngrediant=0;
            int numSteps=0;
            bool isValid = false;
            while (!isValid) // error handling for entering numbers of number of ingrediants and number of steps
            {
                try
                {
                    Console.WriteLine("***WELCOME TO RECIPE SYSTEM***");
                    Console.WriteLine("Please enter the details of your first RECIPE");
                    // user is prompted to enter number of ingrediants and number of steps
                    Console.Write($"Please enter the number of ingrediants >> ");
                    numIngrediant = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter the number of steps >> ");
                    numSteps = Convert.ToInt32(Console.ReadLine());
                    isValid = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("ERROR! ENTER NUMBERS ONLY");
                }
            }
           
            // array of ingrediant and step objects

            Ingrediant[] ingrediant = new Ingrediant[numIngrediant]; 
            Step[] step = new Step[numSteps];


            int j = 1;

            // for loop that will prompt the user to enter the details for each recipe ingredient
            for (int i = 0; i < numIngrediant; i++)
            {
                string nameIngrediant;
                string unit;
                double qty;
                ingrediant[i] = new Ingrediant(); // new ingredient object declared every time the loop iterates

                Console.WriteLine($"****************ENTER INGREDIENT {i+1} DETAILS*******************");

                Console.Write($"Please enter name of ingrediant {j} >> ");
                ingrediant[i].Name = Console.ReadLine();

                bool isValid2 = false;
                while (!isValid2)
                {
                    try // catching format exception for quantity of ingredients
                    {
                        Console.Write($"Please enter the quantity of Ingrediant {j} >> ");
                        qty = Convert.ToDouble(Console.ReadLine());
                        ingrediant[i].Quantity = qty;
                        isValid2 = true;
                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine("ERROR! ENTRE NUMBERS ONLY");
                    }
                }

                Console.Write($"Please enter the unit of measure of Ingrediant {j} >> ");
                ingrediant[i].MeasureUnit = Console.ReadLine();

                j++; // incrementing counter variable for ingrediants 

            }


            Console.WriteLine();
            int m = 1;
            Console.WriteLine("***************** ENTER STEPS *****************");

            // for loop to enter the steps for the recipe
            for (int i = 0; i < numIngrediant; i++)
            {
                step[i] = new Step();
                Console.Write($"Please enter step number {m} >> ");
                step[i].S_step = Console.ReadLine();
                m++;
            }
            isValid = false;
            int option=0;
            while (!isValid)
            {
                try //catching format exception for the option number that the user chooses
                {
                    // menu presenting options to the user once they have entered the recipe
                    Console.WriteLine("*********************** Menu ***********************\n" +
                              "1. Display at original Scale\n" +
                              "2. Display at double Scale\n" +
                              "3. Display at triple Scale\n" +
                              "4. Display at half Scale\n" +
                              "5. Exit/ Enter another Recipe");
                    Console.WriteLine("***************** END OF MENU **********************");
                    Console.WriteLine();

                    option = Convert.ToInt32(Console.ReadLine());
                    while (option <= 0 || option > 5)
                    {
                        Console.Write("Please enter only numbers between 1 and 5 >> ");
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                    isValid = true;
                }
                catch(FormatException e)
                {
                    Console.WriteLine("ERROR!! Enter only numbers.");
                }
            }
            Console.WriteLine();
            
            while (option != 5) // while loop will check the option chosen and will not stop until the user chooses option 5
            {
                switch (option)
                {
                    case 1: // case 1 will display the recipe details using the original scale of measurement
                        Console.WriteLine("******************** Recipe (Original scale)************");
                        Console.WriteLine("****************Ingrediants of Recipe*******************");
                        Console.WriteLine();
                        // for loop to display the details of the recipe
                        for (int i = 0; i < numIngrediant; i++)
                        {
                            double qty1 = ingrediant[i].Quantity * 1;
                            Console.WriteLine($"Ingredient {i + 1} >> {qty1} {ingrediant[i].MeasureUnit} {ingrediant[i].Name}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("****************** Steps of Recipe **********************");

                        // for loop displaying the steps of each recipe
                        for (int l = 0; l < numSteps; l++)
                        {
                            Console.WriteLine($"Step {l + 1} >> {step[l].S_step}");
                        }
                        Console.WriteLine("***********************End of Recipe*********************");
                        Console.WriteLine();
                        bool isValid6 = false;
                        while (!isValid6) // format exception handling for the option chosen by the user.
                        {
                            try
                            {
                                Console.WriteLine("********************* Menu *******************\n" +
                              "1. Display at original Scale\n" +
                              "2. Display at double Scale\n" +
                              "3. Display at triple Scale\n" +
                              "4. Display at half Scale\n" +
                              "5. Exit/ Enter another Recepi");
                                Console.WriteLine("***************** END OF MENU *******************");

                                option = Convert.ToInt32(Console.ReadLine());
                                while (option <= 0 || option > 5)
                                {
                                    Console.Write("Please enter only numbers between 1 and 5 >> ");
                                    option = Convert.ToInt32(Console.ReadLine());
                                }
                                isValid6 = true;
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("ERROR!! Enter only Numbers");
                            }
                        }
                        
                        break;

                    case 2: // case 2 shows the recipe at double the original scale
                        Console.WriteLine("******************* Recepi (Double Scale) **************");
                        Console.WriteLine("****************Ingrediants of Recipe*******************");
                        for (int i = 0; i < numIngrediant; i++)
                        {
                            double qty1 = ingrediant[i].Quantity * 2; // multiplying the quantity of ingredients by a scale of 2
                            Console.WriteLine($"Ingredient {i + 1} >> {qty1} {ingrediant[i].MeasureUnit} {ingrediant[i].Name}");
                        }
                        Console.WriteLine("******************Steps of Recipe********************");

                        for (int l = 0; l < numSteps; l++)
                        {
                            Console.WriteLine($"Step {l + 1} >> {step[l].S_step}");
                        }
                        Console.WriteLine("********************End of Recipe*********************");
                        Console.WriteLine();
                        bool isValid3 = false;
                        while (!isValid3)
                        {
                            try
                            { // format exception error handling
                                Console.WriteLine("******************** Menu ************************\n" +
                              "1. Display at original Scale\n" +
                              "2. Display at double Scale\n" +
                              "3. Display at triple Scale\n" +
                              "4. Display at half Scale\n" +
                              "5. Exit/ Enter another Recepi");
                                Console.WriteLine("***************** END OF MENU ********************");


                                option = Convert.ToInt32(Console.ReadLine());

                                while(option <= 0 || option > 5)
                                {
                                    Console.Write("Please enter only numbers between 1 and 5 >> ");
                                    option = Convert.ToInt32(Console.ReadLine());
                                }
                                isValid3 = true;
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("ERROR!! Enter only Numbers");
                            }
                        }
                        
                        break;

                    case 3: // case 3 shows the recipe at triple the original scale
                        Console.WriteLine("******************** Recepi (Triple Scale)****************");
                        Console.WriteLine("**************** Ingrediants of Recipe *******************");
                        Console.WriteLine();
                        for (int i = 0; i < numIngrediant; i++)
                        {
                            double qty1 = ingrediant[i].Quantity * 3;
                            Console.WriteLine($"Ingredient {i + 1} >> {qty1} {ingrediant[i].MeasureUnit} {ingrediant[i].Name}");
                        }
                        Console.WriteLine() ;   
                        Console.WriteLine("****************** Steps of Recipe *************************");

                        for (int l = 0; l < numSteps; l++)
                        {
                            Console.WriteLine($"Step {l + 1} >> {step[l].S_step}");
                        }
                        Console.WriteLine("**************** End of Recipe *******************************");
                        Console.WriteLine();
                        bool isValid4 = false;
                        while (!isValid4)
                        {
                            try //error handling for option chosen by user
                            {
                                Console.WriteLine("****************** Menu ******************************\n" +
                             "1. Display at original Scale\n" +
                             "2. Display at double Scale\n" +
                             "3. Display at triple Scale\n" +
                             "4. Display at half Scale\n" +
                             "5. Exit/ Enter another Recepi");
                                Console.WriteLine("***************** END OF MENU *************************");

                                option = Convert.ToInt32(Console.ReadLine());
                                while (option <= 0 || option > 5)
                                {
                                    Console.Write("Please enter only numbers between 1 and 5 >> ");
                                    option = Convert.ToInt32(Console.ReadLine());
                                }
                                isValid4 = true;
                                
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("ERROR!! Enter only Numbers");
                            }
                        }
                        break;
                       

                    case 4: // case 4 shows the recipe at half the original scale
                        Console.WriteLine("********************Recepi******************************");
                        Console.WriteLine("****************Ingrediants of Recipe*******************");
                        Console.WriteLine();
                        for (int i = 0; i < numIngrediant; i++)
                        {
                            double qty1 = ingrediant[i].Quantity * 0.5;
                            Console.WriteLine($"Ingredient {i + 1} >> {qty1} {ingrediant[i].MeasureUnit} {ingrediant[i].Name}");
                        }
                        Console.WriteLine() ;
                        Console.WriteLine("******************Steps of Recipe********************");

                        for (int l = 0; l < numSteps; l++)
                        {
                            Console.WriteLine($"Step {l + 1} >> {step[l].S_step}");
                        }
                        Console.WriteLine("*******************End of Recipe*********************");
                        Console.WriteLine();
                        bool isValid5 = false;
                        while (!isValid5)
                        {
                            try // error handling for the option chosen by the user.
                            {
                                Console.WriteLine("********************** Menu **********************\n" +
                                                  "1. Display at original Scale\n" +
                                                  "2. Display at double Scale\n" +
                                                  "3. Display at triple Scale\n" +
                                                  "4. Display at half Scale\n" +
                                                  "5. Exit/ Enter another Recepi");
                                Console.WriteLine("***************** END OF MENU *********************");

                                option = Convert.ToInt32(Console.ReadLine());
                                while (option <= 0 || option > 5)
                                {
                                    Console.Write("Please enter only numbers between 1 and 5 >> ");
                                    option = Convert.ToInt32(Console.ReadLine());
                                }
                                isValid5 = true;
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("ERROR!! Enter only Numbers");
                            }
                        }
                        
                        break;

                    default:
                        option = 5;
                        break;
                }
            }
            
            // prompting the user if they want to add another recipe or if they would like to exit the application
            Console.Write("Would you like to clear old data and enter another recipe? (Y/N) >> ");
            userInput = Console.ReadLine().ToUpper();
            while (userInput != "Y" && userInput != "N")
            {
                Console.WriteLine("Indicate Y OR N only!");
                userInput = Console.ReadLine().ToUpper();
            }
        } while (userInput == "Y");
        
        
    }
}