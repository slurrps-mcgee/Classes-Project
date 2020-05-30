
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DiverClassTest
{
/* Author: Kenneth Lamb
 * Purpose: This class contains the definition of DiverClass. It contains 2 private data member and 6 public methods
 * PDM's are NUM_DIVERS, and diversArr
 * 
 * A summary of the methods appears below:
 * 
 * Assumptions: File supplied will be correctly formatted
 * 
 * Exception Handline: Will check to make sure the incomming data is formatted properly for the data types
 * 
 * 
 * Summary of Methods
 * 2 PDM's
 * 6 Methods
 * 
 * FillArray() used to fill the array from a file that is inputed
 * Sort(int type) used to sort the array. Takes in a int to evaluate which sort to do
 * PrintArray(int n, int type) used to print out the array for both the combo box and the reports
 * CountDivers() used to count the drivers in the array
 * CalculateDive(int n, int index) used to calculate the dive score of a diver by taking in the int n for the number of the dive and the index of the array for the diver
 * totalScore(int index) used to calculate the total score of the divers dives by taking in the index of the array for the diver chosen.
 */
    class DiverClass
    {
        

        //struct to hold diver names
        public struct diverName
        {
            public string firstName;
            public string lastName;
        }
        // struct for dive 1
        public struct dive1
        {
            public float difficulty;
            public float judge1;
            public float judge2;
            public float judge3;
            public float judge4;
            public float judge5;
            public float judge6;
            public float judge7;
            public float judge8;
            public float judge9;
        }
        //struct for dive2
        public struct dive2
        {
            public float difficulty;
            public float judge1;
            public float judge2;
            public float judge3;
            public float judge4;
            public float judge5;
            public float judge6;
            public float judge7;
            public float judge8;
            public float judge9;
        }
        // struct for dive 3
        public struct dive3
        {
            public float difficulty;
            public float judge1;
            public float judge2;
            public float judge3;
            public float judge4;
            public float judge5;
            public float judge6;
            public float judge7;
            public float judge8;
            public float judge9;
        }
        //Struct to hold all the individual diver details
        public struct divers
        {
            public diverName name;
            public dive1 round1;
            public dive2 round2;
            public dive3 round3;
        }

        //PDMS______________________________________________________________________________
        private const int NUM_DIVERS = 25;
        //Array to hold all of the diver structs
        private divers[] diversArr;
        //___________________________________________________________________________________

        public float[] totalList;
        public string[] diverNames;

        //Default Constructor
        public DiverClass()
        {

        }

        public DiverClass(string file)
        {
            
            FillArray(file);
        }

        //Use to fill the array from a file
        public void FillArray(string fileName)
        {
            
            //Create the streamreader iSR
            StreamReader iSR;
            //Variables
            string strLine = ""; //Hold the string from the streamreader
            int lineNum = 0; //Hold the line numbers of the file

            //Check for the file in the program
            if (File.Exists(fileName))
            {
                //Initialize iSR to the file employeesLast.dat
                iSR = new StreamReader(fileName);
                //initial read
                strLine = iSR.ReadLine();

                diversArr = new divers[NUM_DIVERS];
                                
                //While loop to go through the file to gather the names
                while (strLine != null)
                {
                    int pos = strLine.IndexOf(" ");

                    //Set the string to the array at the line number and column 0
                    diversArr[lineNum].name.firstName = strLine.Substring(0, pos);
                    strLine = strLine.Remove(0, pos + 1);

                    diversArr[lineNum].name.lastName = strLine;

                    strLine = iSR.ReadLine(); //Modify LCV

                    //Go through each part of the string and grab the float out of each then remove it from the string. If it is not formatted correctly throw an error
                    try
                    {
                        //Dive 1---------------------------------------------------------------------
                        pos = strLine.IndexOf(" ");

                        diversArr[lineNum].round1.difficulty = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round1.judge1 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round1.judge2 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round1.judge3 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round1.judge4 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round1.judge5 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round1.judge6 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round1.judge7 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round1.judge8 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round1.judge9 = float.Parse(strLine.Substring(0, pos));

                        //Dive 2---------------------------------------------------------------------
                        strLine = iSR.ReadLine(); //Modify LCV
                        pos = strLine.IndexOf(" ");

                        diversArr[lineNum].round2.difficulty = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round2.judge1 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round2.judge2 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round2.judge3 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round2.judge4 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round2.judge5 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round2.judge6 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round2.judge7 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round2.judge8 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round2.judge9 = float.Parse(strLine.Substring(0, pos));

                        //Dive 3--------------------------------------------------------------------
                        strLine = iSR.ReadLine(); //Modify LCV
                        pos = strLine.IndexOf(" ");

                        diversArr[lineNum].round3.difficulty = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round3.judge1 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round3.judge2 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round3.judge3 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round3.judge4 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round3.judge5 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round3.judge6 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round3.judge7 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round3.judge8 = float.Parse(strLine.Substring(0, pos));
                        strLine = strLine.Remove(0, pos + 1);

                        diversArr[lineNum].round3.judge9 = float.Parse(strLine.Substring(0, pos));
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine("This is not a valid float number");
                    }

                    lineNum++;//Increase line number
                    strLine = iSR.ReadLine(); //Modify LCV

                }
            }
            else
            {
                //If program cannot find the file throw an error
                Console.WriteLine("Error file not found");
            }
        }

        //Use to bubble sort the array
        public void Sort(int type)
        {
            int smallest;

            //do the following if the type is = 1
            if (type == 1)
            {
                //Create a temp array here to hold one value
                divers[] temp = new divers[1];
                
                //For loop to go though the array and sort them with a bubble sort to sort through each of the strings in the array
                for (int i = 0; i < NUM_DIVERS - 1; i++)
                {
                    smallest = i;
                    //This loop will be comparing every two elements together and swapping accordingly
                    for (int j = i + 1; j < NUM_DIVERS - 1; j++)
                    {
                        //Check if the array object is null
                        if (diversArr[j].name.firstName == null && diversArr[j].name.lastName == null)
                        {

                        }
                        else
                        {
                            //Here we will compare the strings and sort them if the first array is lower than the second array
                            if (string.Compare(diversArr[j].name.firstName + diversArr[j].name.lastName, diversArr[smallest].name.firstName + diversArr[smallest].name.lastName) < 0)
                            {
                                smallest = j;
                                
                            }

                        }
                    }
                    //Set the temp to equal the position in the array + 1
                    temp[0] = diversArr[smallest];
                    //set the position + 1 to equal the position in the loop
                    diversArr[smallest] = diversArr[i];
                    //set the position in the loop to equal the temp
                    diversArr[i] = temp[0];

                }
            }
            else if(type == 2)
            {
                //Else do this code if the type is not 1
                //Create a temp array here to hold one value
                divers[] temp = new divers[1];

                //For loop to go though the array and sort them with a bubble sort to sort through each of the strings in the array
                for (int i = 0; i < NUM_DIVERS - 1; i++)
                {
                    smallest = i;
                    //This loop will be comparing every two elements together and swapping accordingly
                    for (int j = i + 1; j < NUM_DIVERS - 1; j++)
                    {
                        //Check if the array object is null
                        if (diversArr[j].name.firstName == null && diversArr[j].name.lastName == null)
                        {

                        }
                        else
                        {
                            //Here we will compare the strings and sort them if the first array is lower than the second array
                            if (string.Compare(diversArr[j].name.lastName + diversArr[j].name.firstName, diversArr[smallest].name.lastName + diversArr[smallest].name.firstName) < 0)
                            {
                                smallest = j;

                            }

                        }
                    }
                    //Set the temp to equal the position in the array + 1
                    temp[0] = diversArr[smallest];
                    //set the position + 1 to equal the position in the loop
                    diversArr[smallest] = diversArr[i];
                    //set the position in the loop to equal the temp
                    diversArr[i] = temp[0];

                }
            }
            else
            {
                //Selection Sort

                //Set a temp array and find the smallest point
                float[] temp = new float[NUM_DIVERS];
                //For loop to go though the array and sort them with a bubble sort to sort through each of the strings in the array
                for (int i = 0; i < NUM_DIVERS - 1; i++)
                {
                    //Set the smallest to 0
                    smallest = i;
                    //This loop will be comparing every two elements together and swapping accordingly
                    for (int j = i + 1; j < NUM_DIVERS - 1; j++)
                    {
                        //Check if the array object is null
                        if (totalList[j + 1] == 0.0 && diverNames[j + 1] == null)
                        {

                        }
                        else
                        {
                            //Here we will compare the strings and sort them if the first array is lower than the second array
                            if (totalList[j] > totalList[smallest])
                            {
                                //set the smallest point to i + 1
                                smallest = j;
                                
                            }
                        }
                    }
                    //Set the temp to equal the position in the array + 1
                    temp[0] = totalList[smallest];
                    //set the position + 1 to equal the position in the loop
                    totalList[smallest] = totalList[i];
                    //set the position in the loop to equal the temp
                    totalList[i] = temp[0];
                }
            }
            
        }

        //Use to test the array
        public string PrintArray(int n, int type)
        {
            //Set a string variable to hold the output
            string list = "";
            string firstLetter;
            //If type == 1 do function below
            if(type == 1)
            {
               //Get the list of names of the divers sorted
                list = list + diversArr[n].name.firstName + " " + diversArr[n].name.lastName;
            }
            else if(type == 2)
            {
                //Use the second sort method
                Sort(2);
                //Set the list to be null
                list = null;
                //For loop to print the first report listing the name and the 3 dive scores
                for(int i = 0; i < NUM_DIVERS; i++)
                {
                    //If name is null do nothing
                    if(diversArr[i].name.firstName == null && diversArr[i].name.lastName == null)
                    {

                    }
                    else
                    {
                        //Else get the first letter of the first name
                        firstLetter = diversArr[i].name.firstName.Substring(0, 1);
                        //Format and print out the name and the dives of all of the divers
                        list = list + string.Format("{0, -25} {1, 25} {2, 25} {3, 25}", diversArr[i].name.lastName + ", " + firstLetter, CalculateDive(1, i).ToString("0.00"), CalculateDive(2, i).ToString("0.00"), CalculateDive(3, i).ToString("0.00") + Environment.NewLine);
                    }
                    
                }
                
            }
            else
            {
                //Set the list string to equal null
                list = null;
                //Arrays to hold the total and names
                totalList = new float[NUM_DIVERS];
                diverNames = new string[NUM_DIVERS];
                
                //Fill the array
                for(int i = 0; i < NUM_DIVERS; i++)
                {
                    totalList[i] = totalScore(i);
                    diverNames[i] = diversArr[i].name.firstName + ", " + diversArr[i].name.lastName;
                }
                //Use Sort 3 of the method Sort
                Sort(3);
                //Loop to print out the results for the second report listing the total score and names
                for (int i = 0; i < NUM_DIVERS; i++)
                {
                    if(totalList[i] == null)
                    {

                    }
                    else
                    {
                        //Format the second report
                        list = list + string.Format("{0, 12} {1, -21}", totalList[i].ToString(), diverNames[i].ToString()) + Environment.NewLine;
                    }
                    
                }
            }  
            return list;
        }
        
        //use to count the divers
        public int CountDivers()
        {
            //Set the count to 0
            int count = 0;
            //for loop to count how many divers are in the array
            for(int i = 0; i < NUM_DIVERS; i ++)
            {
                if(diversArr[i].name.firstName != null)
                {
                    count++;
                }
                else
                {

                }

            }
            //Return count
            return count;
        }

        //Calculate the dive selected
        public float CalculateDive(int n, int index)
        {
            //Set the variables needed in the method
            float dive1, dive2, dive3, judge1, judge2, judge3, judge4, judge5, judge6, judge7, judge8, judge9, difficulty;

            //Check which diver will be calculated
            if(n == 1)
            {
                //Grab the scores from the array at the given index
                difficulty = diversArr[index].round1.difficulty;
                judge1 = diversArr[index].round1.judge1;
                judge2 = diversArr[index].round1.judge2;
                judge3 = diversArr[index].round1.judge3;
                judge4 = diversArr[index].round1.judge4;
                judge5 = diversArr[index].round1.judge5;
                judge6 = diversArr[index].round1.judge6;
                judge7 = diversArr[index].round1.judge7;
                judge8 = diversArr[index].round1.judge8;
                judge9 = diversArr[index].round1.judge9;
                //Calculate the dive
                dive1 = (judge1 + judge2 + judge3 + judge4 + judge5 + judge6 + judge7 + judge8 + judge9) * difficulty;
                //Return the dive
                return dive1;
            }
            else if(n == 2)
            {
                //Grab the scores from the array at the given index
                difficulty = diversArr[index].round2.difficulty;
                judge1 = diversArr[index].round2.judge1;
                judge2 = diversArr[index].round2.judge2;
                judge3 = diversArr[index].round2.judge3;
                judge4 = diversArr[index].round2.judge4;
                judge5 = diversArr[index].round2.judge5;
                judge6 = diversArr[index].round2.judge6;
                judge7 = diversArr[index].round2.judge7;
                judge8 = diversArr[index].round2.judge8;
                judge9 = diversArr[index].round2.judge9;
                //Calculate the dive
                dive2 = (judge1 + judge2 + judge3 + judge4 + judge5 + judge6 + judge7 + judge8 + judge9) * difficulty;
                //Return the dive
                return dive2;
            }
            else
            {
                //Grab the scores from the array at the given index
                difficulty = diversArr[index].round3.difficulty;
                judge1 = diversArr[index].round3.judge1;
                judge2 = diversArr[index].round3.judge2;
                judge3 = diversArr[index].round3.judge3;
                judge4 = diversArr[index].round3.judge4;
                judge5 = diversArr[index].round3.judge5;
                judge6 = diversArr[index].round3.judge6;
                judge7 = diversArr[index].round3.judge7;
                judge8 = diversArr[index].round3.judge8;
                judge9 = diversArr[index].round3.judge9;
                //Calculate the dive
                dive3 = (judge1 + judge2 + judge3 + judge4 + judge5 + judge6 + judge7 + judge8 + judge9) * difficulty;
                //Return the dive
                return dive3;
            }
        }

        //totalScore calculation of all three dives
        public float totalScore(int index)
        {
            //set the total score and dives for the calculation
            float totalScore;
            float dive1, dive2, dive3;

            //Call the CalculateDive method for each dive
            dive1 = CalculateDive(1, index);
            dive2 = CalculateDive(2, index);
            dive3 = CalculateDive(3, index);

            //Calculate the totalScore
            totalScore = dive1 + dive2 + dive3;

            //Return the totalScore
            return totalScore;
        }


    }


   
}
