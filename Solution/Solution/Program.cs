using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Diagnostics;

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++)
        {
            int difference = Math.Abs(RoundNumber(grades[i]) - grades[i]);
            if (grades[i] < 38)
            {
                continue;
            } 

            else if (difference < 3)
            {
                grades[i] = RoundNumber(grades[i]);
            }
        }
        return grades;
    }

    public static int RoundNumber(int grade) {

        int roundedGrade = Convert.ToInt32(Math.Round(grade / 5.0) * 5);
        if (roundedGrade < grade)
        {
            roundedGrade = roundedGrade + 5;
        }
        return roundedGrade;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);
    }
}
