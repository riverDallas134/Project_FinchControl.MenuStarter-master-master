using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;


namespace Finch_Project_One
{
    // **************************************************
    //
    // Title: Finch Control - Menu Starter
    // Description: Starter solution with the helper methods,
    //              opening and closing screens, and the menu
    // Application Type: Console
    // Author: Dallas, River
    // Dated Created: 2/15/2020
    // Last Modified: 3/1/2020 
    //
    // **************************************************

    class Program
    {
        //
        //Startup 
        //
        static void Main(string[] args)
        {
            SetTheme();
            OpeningScreen();
            MenuDisplay();
            EndingDisplay();
        }
        //
        //Theme
        //
        static void SetTheme()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        //
        //Menu
        //
        static void MenuDisplay()
        {
            bool quitApplication = false;
            string menuChoice;
            Console.CursorVisible = true;
            Finch finchRobot = new Finch();
            do
            {
                DisplayScreenHeader("Central Menu");
                Console.WriteLine("\ta) Connect Finch Robot To Computer");
                Console.WriteLine();
                Console.WriteLine("\tb) Talent Show");
                Console.WriteLine();
                Console.WriteLine("\tc) Data Recorder");
                Console.WriteLine();
                Console.WriteLine("\td) Alarm System");
                Console.WriteLine();
                Console.WriteLine("\te) User Programming");
                Console.WriteLine();
                Console.WriteLine("\tf) Disconnect Finch Robot");
                Console.WriteLine();
                Console.WriteLine("\tq) Quit");
                Console.WriteLine();
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();
                //
                //User Choice Letter Select
                //
                switch (menuChoice)
                {
                    case "a":
                        ConnectingFinchRobot(finchRobot);
                        break;
                    case "b":
                        TalentShowMenu(finchRobot);
                        break;
                    case "c":
                        DataRecorderMenu(finchRobot);
                        break;
                    case "d":
                        break;
                    case "e":
                        break;
                    case "f":
                        DisconnectFinchRobot(finchRobot);
                        break;
                    case "q":
                        DisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Enter one letter to go to the corresponding menu.");
                        ContinuePrompt();
                        break;
                }
            } while (!quitApplication);
        }
        //
        //Talent Show Menu
        //
        static void TalentShowMenu(Finch myFinch)
        {
            bool quitTalentShow = false;
            string menuChoice;
            Console.CursorVisible = true;
            do
            {
                DisplayScreenHeader("Menu: Talent Show");
                //
                //user menu choise
                //                
                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) Song Player");
                Console.WriteLine("\tc) Dance");
                Console.WriteLine("\td) Mixing It Up");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();
                switch (menuChoice)
                {
                    case "a":
                        LightAndSound(myFinch);
                        break;
                    case "b":
                        MusicPlayer(myFinch);
                        break;
                    case "c":
                        FinchDance(myFinch);
                        break;
                    case "d":
                        MixingItUp(myFinch);
                        break;
                    case "q":
                        quitTalentShow = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Enter a letter to go to the corresponding menu.");
                        ContinuePrompt();
                        break;
                }

            } while (!quitTalentShow);
        }
        //
        //Light and Sound Talent Show
        //
        static void LightAndSound(Finch finchRobot)
        {
            Console.CursorVisible = false;
            DisplayScreenHeader("Light and Sound");
            Console.WriteLine("The Finch robot will show you a light show");
            ContinuePrompt();
            finchRobot.setLED(0, 0, 255);
            finchRobot.noteOn(10);
            finchRobot.wait(2000);
            finchRobot.noteOff();
            finchRobot.setLED(0, 255, 0);
            finchRobot.noteOn(500);
            finchRobot.wait(2000);
            finchRobot.noteOff();
            finchRobot.setLED(255, 0, 0);
            finchRobot.noteOn(1000);
            finchRobot.wait(000);
            finchRobot.noteOff();
            finchRobot.setLED(0, 0, 0);
            ContinuePrompt();
            DisplayMenuPrompt("Talent Show Menu");
        }
        //
        //Music
        //
        static void MusicPlayer(Finch finchRobot)
        {
            Console.CursorVisible = false;
            DisplayScreenHeader("Light and Sound");
            Console.WriteLine("The Finch robot will now play you Twinkle Twinkle Little Star");
            ContinuePrompt();
            finchRobot.noteOn(800);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOn(800);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOn(600);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOn(600);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOn(660);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOn(660);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOn(600);
            finchRobot.wait(1000);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOn(500);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOn(500);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOn(1000);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOn(1000);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOn(900);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOn(900);
            finchRobot.wait(500);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOn(800);
            finchRobot.wait(1000);
            finchRobot.noteOff();
            finchRobot.wait(300);
            finchRobot.noteOff();
            ContinuePrompt();
            DisplayMenuPrompt("Talent Show Menu");
        }
        //
        //
        //
        //
        //
        //Dance Talent Show
        //
        static void FinchDance(Finch finchRobot)
        {
            Console.CursorVisible = false;
            DisplayScreenHeader("Light and Sound");
            Console.WriteLine("The Finch robot will show you a dance move and move in a square");
            ContinuePrompt();
            for (int loop = 0; loop < 8; loop++)
            {
                finchRobot.setMotors(255, 255);
                finchRobot.wait(1000);
                finchRobot.setMotors(100, 0);
                finchRobot.wait(1000);
                finchRobot.setMotors(0, 0);
            }
            for (int looptwo = 0; looptwo < 4; looptwo++)
            {
                finchRobot.setMotors(100, 255);
                finchRobot.wait(1000);
                finchRobot.setMotors(-255, -100);
                finchRobot.wait(1000);
                finchRobot.setMotors(0, 0);
            }
            int squareSize;
            string input;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What is your name user?");
            Console.WriteLine();
            Console.WriteLine();
            string userResponse;
            userResponse = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("It is good to meet you " + userResponse + ".");
            Console.WriteLine();
            Console.WriteLine("How big would do you think the square that was made by the robot would be in square feet?");
            Console.WriteLine();
            Console.WriteLine("Enter Choice:");
            input = Console.ReadLine();
            if (Int32.TryParse(input, out squareSize))
            {
                Console.WriteLine();
                Console.WriteLine(userResponse + " you guessed " + squareSize + "and it was actually around one foot squared. Good estimate!");
            }
        }
        //
        //
        //Mixingitup
        //
        //
        static void MixingItUp(Finch finchRobot)
        {
            Console.CursorVisible = false;
            DisplayScreenHeader("Light and Sound");
            Console.WriteLine("The Finch robot will show you a pattern with light, sound, and movement");
            ContinuePrompt();
            for (int looptwo = 0; looptwo < 8; looptwo++)
            {
                finchRobot.setMotors(100, 255);
                finchRobot.setLED(0, 255, 0);
                finchRobot.noteOn(50);
                finchRobot.wait(1000);
                finchRobot.noteOff();
                finchRobot.noteOn(500);
                finchRobot.setMotors(-255, -100);
                finchRobot.setLED(255, 0, 0);
                finchRobot.wait(1000);
                finchRobot.noteOff();
                finchRobot.setMotors(0, 0);
                finchRobot.setLED(0, 0, 0);
            }

        }
        //Data Recorder
        //
        //
        //
        //
        //
        static void DataRecorderMenu(Finch finch)
        {
            double[] temperatures = null;
            double[] fahrenheitTemperatures = null;
            double[] lightLevelRight = null;
            double[] lightLevelLeft = null;
            int amountOfDataPoints = 0;
            double dataPointFrequency = 0;
            bool quitMenu = false;
            string menuChoice;
            Console.CursorVisible = true;
            do
            {
                DisplayScreenHeader("Menu: Data Recorder");
                //
                //user menu choise
                //                
                Console.WriteLine("\ta) Data Point Ammount");
                Console.WriteLine("\tb) Data Point Frequency");
                Console.WriteLine("\tc) Get Data");
                Console.WriteLine("\td) Display Data");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();
                switch (menuChoice)
                {
                    case "a":
                        amountOfDataPoints = DataRecorderGetAmountOfDataPoints();
                        break;
                    case "b":
                        dataPointFrequency = DataRecorderGetDataPointFrequency();
                        break;
                    case "c":
                        temperatures = DataRecorderGetData(amountOfDataPoints, dataPointFrequency, finch);
                        fahrenheitTemperatures = DataRecorderGetFahrenheit(amountOfDataPoints, dataPointFrequency, finch);
                        lightLevelRight = DataRecorderGetDataLightRight(amountOfDataPoints, dataPointFrequency, finch);
                        lightLevelLeft = DataRecorderGetDataLightLeft(amountOfDataPoints, dataPointFrequency, finch);
                        break;
                    case "d":
                        DataRecorderShowData(temperatures);
                        DataRecorderShowDataFahrenheit(fahrenheitTemperatures);
                        DataRecorderShowDataLightsRight(lightLevelRight);
                        DataRecorderShowDataLightLeft(lightLevelLeft);
                        break;
                    case "q":
                        quitMenu = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Enter a letter to go to the corresponding menu.");
                        ContinuePrompt();
                        break;
                }

            } while (!quitMenu);
        }
        //
        //Light Get
        //
        static double[] DataRecorderGetDataLightRight(int amountOfDataPoints, double dataPointFrequency, Finch finchRobot)
        {
            double[] lightLevelRight = new double[amountOfDataPoints];
            DisplayScreenHeader("Get Data");
            Console.WriteLine($"Amount of data points provided: {amountOfDataPoints}");
            Console.WriteLine();
            Console.WriteLine($"Data Point Frequency Provided provided: {dataPointFrequency}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The Finch Robot is ready to record data based on the given parameters.");
            ContinuePrompt();

            for (int index = 0; index < amountOfDataPoints; index++)
            {
                lightLevelRight[index] = finchRobot.getRightLightSensor();
                Console.WriteLine($"\tReading {index + 1}: {lightLevelRight[index].ToString("n1")}" + " Right light level");
                int waitTimeSeconds = (int)(dataPointFrequency * 1000);
                finchRobot.wait(waitTimeSeconds);
            }
            ContinuePrompt();
            return lightLevelRight;
        }
        static double[] DataRecorderGetDataLightLeft(int amountOfDataPoints, double dataPointFrequency, Finch finchRobot)
        {
            double[] lightLevelLeft = new double[amountOfDataPoints];
            DisplayScreenHeader("Get Data");
            Console.WriteLine($"Amount of data points provided: {amountOfDataPoints}");
            Console.WriteLine();
            Console.WriteLine($"Data Point Frequency Provided provided: {dataPointFrequency}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The Finch Robot is ready to record data based on the given parameters.");
            ContinuePrompt();

            for (int index = 0; index < amountOfDataPoints; index++)
            {
                lightLevelLeft[index] = finchRobot.getLeftLightSensor();
                Console.WriteLine($"\tReading {index + 1}: {lightLevelLeft[index].ToString("n1")}" + " Left light level");
                int waitTimeSeconds = (int)(dataPointFrequency * 1000);
                finchRobot.wait(waitTimeSeconds);
            }
            ContinuePrompt();
            return lightLevelLeft;
        }
        //
        //Light Display
        //Right
        static void DataRecorderShowDataLightsRight(double[] lightLevelRight)
        {
            DisplayScreenHeader("Display Data");
            DataRecorderTableLightRight(lightLevelRight);
            ContinuePrompt();
        }
        static void DataRecorderTableLightRight(double[] lightLevelRight)
        {
            {
                //
                //Table Headers
                //
                Console.WriteLine(
                    "Recording Number".PadLeft(20) +
                    "Light Level.".PadLeft(20)
                    );
                Console.WriteLine(
                    "----------------".PadLeft(20) +
                    "----------------".PadLeft(20)
                    );
                //
                //table data
                //
                for (int index = 0; index < lightLevelRight.Length; index++)
                {
                    Console.WriteLine(
                    (index + 1).ToString().PadLeft(20) +
                    lightLevelRight[index].ToString("n1").PadLeft(20) + " light level right"
                    );
                }
            }
        }
        //
        //Light Display
        //Left
        static void DataRecorderShowDataLightLeft(double[] lightLevelLeft)
        {
            DisplayScreenHeader("Display Data");
            DataRecorderTableLightLeft(lightLevelLeft);
            ContinuePrompt();
        }
        static void DataRecorderTableLightLeft(double[] lightLevelLeft)
        {
            {
                //
                //Table Headers
                //
                Console.WriteLine(
                    "Recording Number".PadLeft(20) +
                    "Light Level.".PadLeft(20)
                    );
                Console.WriteLine(
                    "----------------".PadLeft(20) +
                    "----------------".PadLeft(20)
                    );
                //
                //table data
                //
                for (int index = 0; index < lightLevelLeft.Length; index++)
                {
                    Console.WriteLine(
                    (index + 1).ToString().PadLeft(20) +
                    lightLevelLeft[index].ToString("n1").PadLeft(20) + " light level left"
                    );
                }
            }
        }
        //
        //Celcius Display
        //
        static void DataRecorderShowData(double[] temperatures)
        {
            DisplayScreenHeader("Display Data");
            DataRecorderTable(temperatures);
            ContinuePrompt();
        }
        static void DataRecorderTable(double[] temperatures)
        {
            {
                //
                //Table Headers
                //
                Console.WriteLine(
                    "Recording Number".PadLeft(20) +
                    "Temp.".PadLeft(20)
                    );
                Console.WriteLine(
                    "----------------".PadLeft(20) +
                    "----------------".PadLeft(20)
                    );
                //
                //table data
                //
                for (int index = 0; index < temperatures.Length; index++)
                {
                    Console.WriteLine(
                    (index + 1).ToString().PadLeft(20) +
                    temperatures[index].ToString("n1").PadLeft(20) + " degrees celcius"
                    );
                }
            }
        }

        //
        //fahrenheit Display
        //
        static void DataRecorderShowDataFahrenheit(double[] fahrenheitTemperatures)
        {
            DisplayScreenHeader("Display Data");
            DataRecorderTableFahrenheit(fahrenheitTemperatures);
            ContinuePrompt();
        }
        static void DataRecorderTableFahrenheit(double[] fahrenheitTemperatures)
        {
            {
                //
                //Table Headers
                //
                Console.WriteLine(
                    "Recording Number".PadLeft(20) +
                    "Temp.".PadLeft(20)
                    );
                Console.WriteLine(
                    "----------------".PadLeft(20) +
                    "----------------".PadLeft(20)
                    );
                //
                //table data
                //
                for (int index = 0; index < fahrenheitTemperatures.Length; index++)
                {
                    Console.WriteLine(
                    (index + 1).ToString().PadLeft(20) +
                    fahrenheitTemperatures[index].ToString("n1").PadLeft(20) + " degrees fahrenheit"
                    );
                }
            }
        }
        //
        //CelciusTemperatures
        //
        static double[] DataRecorderGetData(int amountOfDataPoints, double dataPointFrequency, Finch finchRobot)
        {
            double[] temperatures = new double[amountOfDataPoints];
            DisplayScreenHeader("Get Data");
            Console.WriteLine($"Amount of data points provided: {amountOfDataPoints}");
            Console.WriteLine();
            Console.WriteLine($"Data Point Frequency Provided provided: {dataPointFrequency}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The Finch Robot is ready to record data based on the given parameters.");
            ContinuePrompt(); 

            for (int index = 0; index < amountOfDataPoints; index++)
            {
                temperatures[index] = finchRobot.getTemperature();
                Console.WriteLine($"\tReading {index + 1}: {temperatures[index].ToString("n1")}" + " degrees celcius");
                int waitTimeSeconds = (int)(dataPointFrequency * 1000);
                finchRobot.wait(waitTimeSeconds);
            }
            ContinuePrompt();
            return temperatures;
        }
        //
        //fahrenheitTemperatures
        //
        //
        //
        //
        //
        //
        static double[] DataRecorderGetFahrenheit(int amountOfDataPoints, double dataPointFrequency, Finch finchRobot)
        {
            double[] fahrenheitTemperatures = new double[amountOfDataPoints];
            DisplayScreenHeader("Get Data");
            Console.WriteLine($"Amount of data points provided: {amountOfDataPoints}");
            Console.WriteLine();
            Console.WriteLine($"Data Point Frequency Provided provided: {dataPointFrequency}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The Finch Robot is ready to record data based on the given parameters.");
            ContinuePrompt();

            for (int index = 0; index < amountOfDataPoints; index++)
            {
                double inputTemp;
                double finalTemp;
                inputTemp = Convert.ToDouble(finchRobot.getTemperature());
                finalTemp = (inputTemp * 1.8) + 32;
                fahrenheitTemperatures[index] = finalTemp;
                Console.WriteLine($"\tReading {index + 1}: {fahrenheitTemperatures[index].ToString("n1")}" + " degrees fahrenheit");
                int waitTimeSeconds = (int)(dataPointFrequency * 1000);
                finchRobot.wait(waitTimeSeconds);
            }
            ContinuePrompt();
            return fahrenheitTemperatures;
        }
        //
        //Frequency of Data Points
        //
        static double DataRecorderGetDataPointFrequency()
        {
            double frequencyOfData;
            string userResponse;
            //
            //Validate User Input
            //
            do
            {
                DisplayScreenHeader("Data Points Frequency");
                Console.Write("Please enter the desired frequency of data points in seconds in numerical form between 0 and 100 and click enter. Enter number here: ");
                userResponse = Console.ReadLine();
                double.TryParse(userResponse, out frequencyOfData);
                if (frequencyOfData >= 0 && frequencyOfData <= 99)
                {
                    Console.WriteLine("You have entered a correct value for the frequency of data points.The number you entered is " + frequencyOfData + " seconds.");
                    ContinuePrompt();
                    return frequencyOfData;
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect response, please retry by entering a number ranging from 0-100 here: ");
                    userResponse = Console.ReadLine();
                    double.TryParse(userResponse, out frequencyOfData);
                    ContinuePrompt();
                }
            }
            while (frequencyOfData >= 0 && frequencyOfData <= 99);
            double.TryParse(userResponse, out frequencyOfData);
            return frequencyOfData;
        }
        //
        //Amount of Data Points
        //
        static int DataRecorderGetAmountOfDataPoints()
        {
            int amountOfDataPoints;
            string userResponse;
            //
            //Validate User Input
            //
            do
            {
                DisplayScreenHeader("Data Points Number");
                Console.Write("Please enter the desired amount of data points in numerical form between 0 and 100 and click enter. Enter number here: ");
                userResponse = Console.ReadLine();
                int.TryParse(userResponse, out amountOfDataPoints);
                if (amountOfDataPoints >= 0 && amountOfDataPoints <= 99)
                {
                    Console.WriteLine("You have entered a correct value for the amount of data points.The number you entered is " + amountOfDataPoints);
                    ContinuePrompt();
                    return amountOfDataPoints;
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect response, please retry by entering a number ranging from 0-100 here: ");
                    userResponse = Console.ReadLine();
                    int.TryParse(userResponse, out amountOfDataPoints);
                    ContinuePrompt();
                }
            }
            while (amountOfDataPoints >= 0 && amountOfDataPoints <= 99);
            int.TryParse(userResponse, out amountOfDataPoints);
            return amountOfDataPoints;
        }

        //Disconnect Finch robot
        //
        //
        //
        //
        //
        //
        static void DisconnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Disconnect Finch Robot");

            Console.WriteLine("\tAbout to disconnect from the Finch robot.");
            ContinuePrompt();

            finchRobot.disConnect();

            Console.WriteLine("\tThe Finch robot is now disconnect.");

            DisplayMenuPrompt("Main Menu");
        }
        //Connect Finch Robot
        //
        static bool ConnectingFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("Connect Finch Robot");
            Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
            ContinuePrompt();

            robotConnected = finchRobot.connect();

            // TODO test connection and provide user feedback - text, lights, sounds

            DisplayMenuPrompt("Main Menu");

            //
            // reset finch robot
            //
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            return robotConnected;
        }
        //
        //Opening Screen
        //
        static void OpeningScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFinch Control");
            Console.WriteLine();

            ContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        /// </summary>
        static void EndingDisplay()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Finch Control! ");
            Console.WriteLine();

            ContinuePrompt();
        }

        //
        //display continue prompt
        //
        static void ContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display menu prompt
        /// </summary>
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }
    }


}
