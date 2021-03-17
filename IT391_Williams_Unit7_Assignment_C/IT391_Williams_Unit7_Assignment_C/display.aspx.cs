using System;
using System.Xml;

namespace IT391_Williams_Unit7_Assignment_C
{
    public partial class display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //The code to import XML data borrowed from:
            //https://stackoverflow.com/questions/642293/how-do-i-read-and-parse-an-xml-file-in-c

            XmlDocument data = new XmlDocument();
            data.Load("studentGrades.xml");

            int [] grades = new int[24];
            int count = 0;

            foreach (XmlNode node in data.DocumentElement.ChildNodes)
            {
                grades[count] = Int32.Parse(node.InnerText);
                count++;
            }

            String message = "The highest grade: ";
            TextBox1.Text += message + highestGrade(grades).ToString();

            message = "\nThe lowest grade: ";
            TextBox1.Text += message + lowestGrade(grades).ToString();

            message = "\nThe average grade: ";
            TextBox1.Text += message + averageGrade(grades).ToString();
        }

        protected int highestGrade (int [] gradearray)
        {
            int highest = 0;
            
            for (int i = 0; i < gradearray.Length; i++)
            {
                if (highest < gradearray[i])
                    highest = gradearray[i];
            }

            return highest;
        }

        protected int lowestGrade(int[] gradearray)
        {
            int lowest = 101;

            for (int i = 0; i < gradearray.Length; i++)
            {
                if (lowest > gradearray[i])
                    lowest = gradearray[i];
            }

            return lowest;
        }

        protected int averageGrade(int[] gradearray)
        {
            int average = 0;
            int total = 0;

            for (int i = 0; i < gradearray.Length; i++)
            {
                total += gradearray[i];
            }

            average = total / gradearray.Length;

            return average;
        }
    }
}