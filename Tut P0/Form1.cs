using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tut_P0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //An array to store all the brands in the survey
        string[] brandArray = new string[] { "Coke", "Pams", "Pepsi", "Phoenix", "Other" };

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            List<int> numsList = new List<int>() { 5, 1, 5, 3, 6, 3, 0 };
            int count = 0;
            //Check if the list is empty
            if (numsList.Count > 0)
            {
                //Set count to 1 to include the first number in the count
                count = 1;
                //FOR each value from 2nd value to end of the list
                for (int i = 1; i < numsList.Count; i++)
                {
                    //Check if current value in list matches the first value in list
                    if (numsList[0] == numsList[i])
                    {
                        count++;
                    }
                }
                MessageBox.Show("The number " + numsList[0].ToString() + " occurred " + count.ToString() + " times.");
            }
            else
            {
                MessageBox.Show("The list is empty");
            }
        }

        /// <summary>
        /// Calculates the percentage of people that bought the given brand.
        /// </summary>
        /// <param name="bList">The list of all the brands that have been bought</param>
        /// <param name="brand">The brand to caluclate the percentage for</param>
        /// <returns>The percentage of people that bought the given brand</returns>
        private double CalcBrandPercentage(List<string> bList, string brand)
        {
            int count = 0;
            //FOR each brand in the list
            for (int i = 0; i < bList.Count; i++)
            {
                //Check if the current brand matches the brand given
                if (bList[i] == brand)
                {
                    count++;
                } 
            }
            //Calulate and return the percentage
            return (double)count / bList.Count;
        }

        /// <summary>
        /// Show the percentage of people that bought each brand.
        /// </summary>
        /// <param name="bList">The list of all the brands</param>
        private void ShowTotalPercentages(List<string> bList)
        {
            double percent = 0;
            //FOR each brand in the brand array
            for (int i = 0; i < brandArray.Length; i++)
            {
                //Calculate the percentage for the current brand and display in listbox
                percent = CalcBrandPercentage(bList, brandArray[i]);
                listBoxDisplay.Items.Add(brandArray[i] + ": " + percent.ToString("p"));
            }

        }

        /// <summary>
        /// Calculate the percentage of people that bought the given brand of the given gender.
        /// </summary>
        /// <param name="bList">The list of all the brands that have been bought</param>
        /// <param name="gList">The list of the gender that bought each brand</param>
        /// <param name="brand">The brand to calculate the percentage for</param>
        /// <param name="gender">The gender to calculate the percentage for</param>
        /// <returns>The percentage of people that bought the given brand of the given gender</returns>
        private double CalcBrandPercentageByGender(List<string> bList, List<string> gList, string brand, string gender)
        {
            int count = 0;
            //FOR each brand in the list
            for (int i = 0; i < bList.Count; i++)
            {
                //Check if the current brand mathes the given brand and the current gender
                //matches the given gender
                if (bList[i] == brand && gList[i] == gender)
                {
                    count++;
                }
            }
            //Calculate and return back the percentage
            return (double)count / bList.Count;
        }

        /// <summary>
        /// Calculates the name of the brand which has the highest
        /// percentage of people that bought it
        /// </summary>
        /// <param name="percentArray">An array that stores the percentage of people that bought the current brand</param>
        /// <returns>The name of the brand that had the highest percentage</returns>
        private string GetBrand(double[] percentArray)
        {
            //Set the maximum value to the first percentage value
            double max = percentArray[0];
            int maxIndex = 0;
            //FOR each percentage value from 2nd to end of the array
            for (int i = 1; i < percentArray.Length; i++)
            {
                //Check if the current value in the array is greater than the max
                if (max < percentArray[i])
                {
                    //Set max to the current value in array
                    max = percentArray[i];
                    //Change the max index value to the current position
                    maxIndex = i;
                }
            }
            //Return back the name of teh brand at the max index position
            return brandArray[maxIndex];
        }

        /// <summary>
        /// Displays the preferred brand for each gender.
        /// </summary>
        /// <param name="bList">The list of all the brands that have been bought</param>
        /// <param name="gList">The list of the genders that bought each brand</param>
        private void FindGenderPreference(List<string> bList, List<string> gList)
        {
            //Create arrays to store the percentage of people that bought each type of brand
            double[] malePercentArray = new double[5];
            double[] femalePercentArray = new double[5];
            //FOR each brand in the brand array
            for (int i = 0; i < brandArray.Length; i++)
            {
                //Calculate the percentage of male and females that bought the current brand
                malePercentArray[i] = CalcBrandPercentageByGender(bList, gList, brandArray[i], "m");
                femalePercentArray[i] = CalcBrandPercentageByGender(bList, gList, brandArray[i], "f");
            }
            //Display the brand peferred by males and females
            listBoxDisplay.Items.Add("Male: " + GetBrand(malePercentArray));
            listBoxDisplay.Items.Add("Female: " + GetBrand(femalePercentArray));
        }

        /// <summary>
        /// Calculates the percentage of people who bought the given brand and are within
        /// the given age limits.
        /// </summary>
        /// <param name="bList">The list of all teh brands that have been bought</param>
        /// <param name="ageList">The age of the person that bought a brand</param>
        /// <param name="brand">The brand to calculate the percentage for</param>
        /// <param name="minAge">The minimum age the person must be</param>
        /// <param name="maxAge">The maximum age the person must be</param>
        /// <returns>The percentage of people that bought the given brand and are within the given age limits</returns>
        private double CalcBrandPercentageByAgeRange(List<string> bList, List<int> ageList, string brand, int minAge, int maxAge)
        {
            int count = 0;
            //FOR each brand in the list
            for (int i = 0; i < bList.Count; i++)
            {
                //Check if the current brand mathes the given brand and the current gender
                //matches the given gender
                if (bList[i] == brand && ageList[i] >= minAge && ageList[i] <= maxAge)
                {
                    count++;
                }
            }
            //Calculate and return back the percentage
            return (double)count / bList.Count;
        }

        /// <summary>
        /// Displays the preferred brand for the given age range.
        /// </summary>
        /// <param name="bList">The list of all the brands that have been bought</param>
        /// <param name="ageList">The age of the person that bought a brand</param>
        /// <param name="minAge">The minimum age of the person</param>
        /// <param name="maxAge">The maximum age of the person</param>
        private void DisplayAgePreference(List<string> bList, List<int> ageList, int minAge, int maxAge)
        {
            double[] percentArray = new double[5];

            //FOR each brand in the brand array
            for (int i = 0; i < brandArray.Length; i++)
            {
                //Calculate the percentage of people that bought the current brand within the given age range
                percentArray[i] = CalcBrandPercentageByAgeRange(bList, ageList, brandArray[i], minAge, maxAge);
            }
            //Display the preferred brand
            listBoxDisplay.Items.Add("Age " + minAge.ToString() + " to " + maxAge.ToString() + ": " + GetBrand(percentArray));
        }

        /// <summary>
        /// Display the preferred brand for different age limits.
        /// </summary>
        /// <param name="bList">The list of all the brands that have been bought</param>
        /// <param name="ageList">The age of the person that bought a brand</param>
        private void FindAgePreference(List<string> bList, List<int> ageList)
        {
            DisplayAgePreference(bList, ageList, 19, 99);
            DisplayAgePreference(bList, ageList, 1, 10);
            DisplayAgePreference(bList, ageList, 22, 24);
        }

        private void buttonEx2_Click(object sender, EventArgs e)
        {
            List<int> ageList = new List<int>();
            List<string> genderList = new List<string>();
            List<string> brandList = new List<string>();

            StreamReader reader;
            string line = "";
            string[] csvArray;
            int age = 0;
            string gender = "";
            string brand = "";

            //Set the filter for the dialog control
            openFileDialog1.Filter = "CSV Files|*.csv|All Files|*.*";
            //Get the name of the file and check if the Open button was clicked
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the selected file
                reader = File.OpenText(openFileDialog1.FileName);

                //WHILE not the end of the file
                while (!reader.EndOfStream)
                {
                    try
                    {
                        //Read an entire line from the file
                        line = reader.ReadLine();
                        //Split the line storing values in an array
                        csvArray = line.Split(',');
                        //Check if the array has the correct number of elements
                        if (csvArray.Length == 3)
                        {
                            //Extract the values from the list into separate variables
                            age = int.Parse(csvArray[0]);
                            gender = csvArray[1];
                            brand = csvArray[2];

                            //Add the values to the lists
                            ageList.Add(age);
                            genderList.Add(gender);
                            brandList.Add(brand);
                        }
                        else
                        {
                            Console.WriteLine("Error: " + line);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error: " + line);
                    }
                }
                //Close the file
                reader.Close();

                ShowTotalPercentages(brandList);
                FindGenderPreference(brandList, genderList);
                FindAgePreference(brandList, ageList);
            }
        }
    }
}
