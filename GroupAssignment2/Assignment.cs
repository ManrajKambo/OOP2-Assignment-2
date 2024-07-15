using System;

namespace GroupAssignment2
{
    public class Assignment
    {
        public string[] LoadCSV(string fileName)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"..\\..\\..\\..\\..\\Resources\\{fileName}.csv");
            return File.ReadAllLines(path);
        }
    }
}