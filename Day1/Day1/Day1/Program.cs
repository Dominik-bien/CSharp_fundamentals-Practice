﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {


            ////example - byte (0-255)
            //byte number = 255;
            //Console.WriteLine(number);
            ////error number = 256;

            //Console.WriteLine(number);
            //int number1 = 9999;
            //Console.WriteLine(number1);
            //var number2 = number + number1;
            //Console.WriteLine(number2);

            //double number3 = 123.45;

            //Console.WriteLine(number3);

            //decimal number4 = 31.12M;
            //Console.WriteLine(number4);

            //string name = "Programmer";
            //char sign = '+';
            //DateTime today = DateTime.Now;
            //Console.WriteLine(today);

            //Exercise exercise = new Exercise();

            //List<int> list = new List<int>() { 1,2,3};

            //list.Add(4);
            //list.Remove(1);
            //Console.WriteLine(list[0]);

            //int age = 20;
            //string myAge = "30";
            //age = int.Parse(myAge);
            //myAge = age.ToString();



            //exercise.PollExercise();

            //var cake = "Cheesecake";

            //Console.WriteLine(cake);
            //Exercise exercise2 = new Exercise();
            //exercise2.sayHallo();

            //var getTime = exercise2.GetCurrentDate();
            //exercise.Name = "Exercise nr 1";

            //Console.WriteLine(exercise.Name);


            ////Exercise 2

            //Exercise2 Rectangle = new Exercise2();
            //Rectangle.SetDimensions(5, 10);
            //Console.WriteLine("Area: " + Rectangle.CalculateArea());
            //Console.WriteLine("Perimeter: " + Rectangle.CalculatePerimeter());

            //var sum = Example.Sum(1, 8);
            //Console.WriteLine(sum);

            //var minAge = 10;
            //var maxAge = 20;
            //minAge = maxAge;
            //maxAge = 21;
            //Console.WriteLine(minAge);

            //var minAge = 10;
            //var maxAge = 20;

            //Console.WriteLine("Please Enter your Age");
            //var myAge = int.Parse(Console.ReadLine());

            //if (myAge >= minAge && myAge <= maxAge)
            //{
            //    Console.WriteLine("You can Enter to Club");
            //}
            //else
            //{
            //    Console.WriteLine("You can not enter to Club");
            //}

            //var number = int.Parse(Console.ReadLine());


            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("you choose: " + number);
            //        break;
            //    case 2:
            //        Console.WriteLine("You choose: " + number);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid number or I can not recognise this value");
            //        break;

            //}



            //Exercise 3

            //Console.WriteLine("Choose Converter type:\n1 - temperature\n 2 - Distance");
            //var choise = int.Parse(Console.ReadLine());

            //switch (choise)
            //{
            //    case 1:
            //        Console.WriteLine("Temperature conversion: \n 1 - Celsius to Fahrenheit \n2 - Fahrenheit to Celsius");
            //        var temperatureChoise = int.Parse(Console.ReadLine());
            //        switch (temperatureChoise)
            //        {
            //            case 1:
            //                Console.WriteLine("Enter a temperature in Celsius: ");
            //                double temperatureCelsius = Convert.ToDouble((Console.ReadLine()));
            //                Console.WriteLine("Temperature in Fahrenheit: " + TemperatureConverter.CelsiusToFahrenheit(temperatureCelsius));
            //             break;
            //            case 2:
            //                Console.WriteLine("Enter a temperature in Fahrenheit: ");
            //                var temperatureFahrenheit = Convert.ToDouble((Console.ReadLine()));
            //                Console.WriteLine("Temperature in Celsius: " + TemperatureConverter.FahrenheitToCelsius(temperatureFahrenheit));
            //                break;
            //            default:
            //                Console.WriteLine("I can not recognize value");
            //                break;
            //        }
            //        break;
            //    case 2:
            //        Console.WriteLine("Distance Conversion:\n 1 - Kilometers to Miles\n2 - Miles to Kilometers");
            //        var DistanceChoise = int.Parse(Console.ReadLine());

            //        switch (DistanceChoise)
            //        {
            //            case 1:
            //                Console.WriteLine("Enter a kilometre: ");
            //                var kilometreValue = Convert.ToDouble((Console.ReadLine()));
            //                Console.WriteLine("Miles in kilometres: " + DistanceConverter.KilometersToMiles(kilometreValue));
            //                break;
            //            case 2:
            //                Console.WriteLine("Enter a Miles: ");
            //                var milesValue = Convert.ToDouble((Console.ReadLine()));
            //                Console.WriteLine("Kilometres in miles: " + DistanceConverter.MilesToKilometers(milesValue));
            //                break;
            //            default:
            //                Console.WriteLine("I can not recognize value");
            //                break;
            //        }
            //        break;



            //var i = 0;

            //while (i <= 100)
            //{
            //    if (i == 39)
            //    {
            //        i++; 
            //        continue;
            //    }

            //    Console.WriteLine(i + " ");
            //    i++;
            //}
            //int j = 0;
            //do
            //{
            //    Console.WriteLine(j + " ");
            //    j++;
            //} while (j < 10);

            //for (int k = 0; k < 20; k++)
            //{
            //    Console.WriteLine(k + " ");
            //}


            //var numbers = new List <int>();
            //Console.WriteLine("Enter 5 number.");

            //for (int i = 0; i < 5; i++)
            //{
            //    numbers.Add(int.Parse(Console.ReadLine()));
            //}

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Exercise 4

            //var random = new Random();
            //var guessHistory = new List<int>();
            //bool isGameRunning = true;

            //while (isGameRunning)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Welcome to game: Guess The number");
            //    Console.WriteLine("1 - New Game\n2 - Show history game\n3 - Exit the game");
            //    var choise = int.Parse(Console.ReadLine());

            //    switch (choise)
            //    {
            //        case 1:
            //            int numberToGuess = random.Next(1, 101);
            //            int userGuess = 0;
            //            int attempts = 0;


            //            for(int i = 7; i > 0; i--)
            //            {
            //                Console.WriteLine("Enter your guess. \nYou have: " + i + " Attempts");
            //                userGuess = int.Parse(Console.ReadLine());
            //                if (userGuess > numberToGuess)
            //                {
            //                    Console.WriteLine("Too high");
            //                    attempts++;
            //                }
            //                else if (userGuess < numberToGuess)
            //                {
            //                    Console.WriteLine("Too low");
            //                    attempts++;
            //                }
            //                else if (userGuess == numberToGuess)
            //                {
            //                    Console.WriteLine($"Gratulations :D\nYour Guess: {userGuess}\nGuess number: {numberToGuess}\nAttempts: {attempts}");
            //                    break;
            //                }
            //                else if (i == 0)
            //                {
            //                    Console.WriteLine($"You did not guess the number. You lose\n Guess number: {numberToGuess}");
            //                    break;
            //                }


            //            }


            //            guessHistory.Add(attempts);

            //            Console.ReadKey();
            //            break;

            //        case 2:
            //            foreach (var guess in guessHistory)
            //            {
            //                Console.WriteLine("Attepts: " + guess + " ");
            //            }
            //            Console.ReadKey();
            //            break;

            //        case 3:
            //            Console.WriteLine("Thanks for playing this game :)");
            //            isGameRunning = false;
            //            break;
            //    }





            //try
            //{
            //    Console.WriteLine("Divinding two numbers.\nEnter a divinend");

            //    var divinend = decimal.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter a divider");

            //    var divider = decimal.Parse(Console.ReadLine());

            //    var result = divinend / divider;

            //    Console.WriteLine("Quoitent: " + result);
            //}
            //catch (DivideByZeroException ex)
            //{

            //    Console.WriteLine("Divider donot be 0");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Invalid value");
            //}


            //Exercise 5 - Finish Tomorrow


            var random = new Random();
            var guessHistory = new List<int>();
            bool isGameRunning = true;

            while (isGameRunning)
            {
                // Clear the console at the start of the loop for a better user experience
                Console.Clear();
                Console.WriteLine("Welcome to game: Guess The number");
                Console.WriteLine("1 - New Game\n2 - Show history game\n3 - Exit the game");

                int choice = 0; // It's good practice to declare the variable closer to where it's used.

                try
                {
                    // We try to parse the input.
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException) // You don't need the 'ex' variable if you don't use it.
                {
                    Console.WriteLine("Error. Value is not a number. Please choose: 1, 2 or 3");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    continue; // FIX #1: Skip the switch statement and restart the loop.
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Your number is too large. Please enter a value between 1-3");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    continue; // FIX #1: Skip the switch statement and restart the loop.
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    continue; // FIX #1: Skip the switch statement and restart the loop.
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        int numberToGuess = random.Next(1, 101);
                        int attempts = 0;
                        bool guessedCorrectly = false;

                        for (int i = 7; i > 0; i--)
                        {
                            int userGuess = 0;
                            try
                            {
                                Console.WriteLine($"Enter your guess. You have {i} attempt(s) left.");
                                userGuess = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid format. Please enter a whole number.");
                                i++; 
                                Console.WriteLine("Press any key to try again...");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("Your number is too big or small. Please enter a value between 1-100.");
                                i++; 
                                Console.WriteLine("Press any key to try again...");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }

                  
                            attempts++;
                            if (userGuess > numberToGuess)
                            {
                                Console.WriteLine("Too high");
                            }
                            else if (userGuess < numberToGuess)
                            {
                                Console.WriteLine("Too low");
                            }
                            else
                            {
                                Console.WriteLine($"Congratulations! You guessed it :D");
                                Console.WriteLine($"The number was: {numberToGuess}");
                                Console.WriteLine($"It took you {attempts} attempts in this round.");
                                guessedCorrectly = true;
                                break;
                            }
                        }

                        if (!guessedCorrectly)
                        {
                            Console.WriteLine($"You ran out of attempts. You lose.");
                            Console.WriteLine($"The correct number was: {numberToGuess}");
                        }

                        guessHistory.Add(attempts);
                        Console.WriteLine("Press any key to return to the main menu...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        if (guessHistory.Count == 0)
                        {
                            Console.WriteLine("No game history yet. Play a game first!");
                        }
                        else
                        {
                            Console.WriteLine("--- Game History (Attempts per game) ---");
                            for (int gameNumber = 0; gameNumber < guessHistory.Count; gameNumber++)
                            {
                                Console.WriteLine($"Game {gameNumber + 1}: {guessHistory[gameNumber]} attempts");
                            }
                        }
                        Console.WriteLine("\nPress any key to return to the main menu...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Thanks for playing this game :)");
                        isGameRunning = false;
                        break;

                    default:
                        Console.WriteLine("Unknown option. Please choose 1, 2, or 3.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }




            // }










        }
        }

            }
    
    
    
