﻿namespace GroupAssignment2.Code
{
    public class Assignment
    {
        internal string[] LoadCSV(string fileName)
        {
            string path = $"..\\..\\..\\..\\..\\Resources\\{fileName}.csv";
			string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
            return File.ReadAllLines(fullPath);
        }
    }
}