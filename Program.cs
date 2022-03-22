using System;

namespace A5CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuInput = null;
            string nameStr;
            string newNameStr = null;
            int ageInt = 0;
            int newAgeInt = 0;
            string addressStr;
            string newAddressStr = null;
            Student student1;

            student1 = new Student(); //create student1 as new empty student object to prevent crashes

        Before_Menu:
                        

            if (menuInput == "B" || menuInput == "b")
            {
                student1.EditStudentInformation(newNameStr, newAgeInt, newAddressStr);
                nameStr = student1.GetStudentName();
                ageInt = student1.GetStudentAge();
                addressStr = student1.GetStudentAddress();
            }

            Console.Clear();
            Console.WriteLine("Please input a letter (from A to D) to select your action:");
            Console.WriteLine("A - Add Student Record");
            Console.WriteLine("B - Edit Student Record");
            Console.WriteLine("C - Display the name, age, and address of the student");
            Console.WriteLine("D - Exit the program");

            //user input to choose action
            menuInput = Console.ReadLine().Trim();

            switch (menuInput)
            {
                case "A":
                case "a":
                    Console.Clear();
                    if (!String.IsNullOrEmpty(student1.GetStudentName()))
                    {
                        Console.WriteLine("Student record (name) already exists. Press any key to go back to the menu.");
                        Console.ReadKey();
                        break;
                    }
                    else if (ageInt != 0)
                    {
                        Console.WriteLine("Student record (age) already exists. Press any key to go back to the menu.");
                        Console.ReadKey();
                        break;
                    }
                    else if (!String.IsNullOrEmpty(student1.GetStudentAddress()))
                    {
                        Console.WriteLine("Student record (address) already exists. Press any key to go back to the menu.");
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine("Please input the student's name:");
                    nameStr = Console.ReadLine().Trim(); //get name string and trim white space

                Before_Age:
                    Console.WriteLine("Please input the student's age (must not be 0):");
                    string ageString = Console.ReadLine();
                    if (String.IsNullOrEmpty(ageString) || ageString == "0")
                    {
                        Console.WriteLine("0 is not a valid age, press any key to try again.");
                        Console.ReadKey();
                        goto Before_Age;
                    }
                    else try
                    {
                        ageInt = Int32.Parse(ageString); //try to get age as int
                    }
                    catch
                    {
                        Console.WriteLine("Your input was invalid, press any key to try again."); //if age input is not number then retry
                        Console.ReadKey();
                        goto Before_Age;
                    }

                    Console.WriteLine("Please input the student's address:");
                    addressStr = Console.ReadLine(); //get address string


                    student1 = new Student(nameStr, ageInt, addressStr); //reconstruct student1 instance with user input instead of empty values
                    Console.WriteLine("Student record created. Press any key to return to menu.");
                    Console.ReadKey();
                    break;

                case "B":
                case "b":
                    Console.Clear();
                    Console.WriteLine(student1.DisplayStudentInformation());
                    Console.WriteLine("Please input new information for each field.");
                    //new info inputs
                    Console.WriteLine("New name (leave blank to not change): ");
                    newNameStr = Console.ReadLine().Trim(); //get new name and trim white space

                New_Age_Input:
                    Console.WriteLine("New age (enter 0 or leave blank to not change): "); //get new age
                    string newAgeString = Console.ReadLine().Trim();
                    if (String.IsNullOrEmpty(newAgeString))
                    {
                        newAgeInt = 0;
                    }
                    else try
                    {
                        newAgeInt = Int32.Parse(newAgeString); //try to get age as int
                    }
                    catch
                    {
                        Console.WriteLine("Your input was invalid, press any key to try again."); //if age input is not number then retry
                        Console.ReadKey();
                        goto New_Age_Input;
                    }

                    Console.WriteLine("New address (leave blank to not change): ");
                    newAddressStr = Console.ReadLine(); //get new address


                    Console.WriteLine("Student information has been updated.");
                    Console.WriteLine("Press any key to go back to the menu.");
                    Console.ReadKey();

                    break;
                case "C":
                case "c":
                    Console.Clear();
                    Console.WriteLine("Student 1 information is as follows:\n" + student1.DisplayStudentInformation());
                    Console.WriteLine("Press any key to go back to the menu.");
                    Console.ReadKey();

                    break;
                case "D":
                case "d":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid selection, press any key to try again.");
                    Console.ReadKey();
                    break;
            }
            goto Before_Menu;
        }
    }
}
