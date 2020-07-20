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
        string[] brandArray = new string[] { "Coke", "Pams", "Pepsi", "Phoenix", "Other" };

        

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            List<int> numsList = new List<int>(); // { 5, 1, 5, 3, 6, 3, 0 };
            int count = 0;

            
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
                        //Extract the values from the list into separate variables
                        age = int.Parse(csvArray[0]);
                        gender = csvArray[1];
                        brand = csvArray[2];

                        //Add the values to the lists
                        ageList.Add(age);
                        genderList.Add(gender);
                        brandList.Add(brand);
                    }
                    catch
                    {
                        MessageBox.Show("Error: " + line);
                    }
                }
                //Close the file
                reader.Close();

                //ShowTotalPercentages(brandList);
                //FindGenderPreference(brandList, genderList);
            }
        }
    }
}
