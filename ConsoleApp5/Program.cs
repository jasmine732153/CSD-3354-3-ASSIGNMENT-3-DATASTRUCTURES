using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



//Student Name:-Kajalpreet kaur Dandeyala Student Id:- C0732153

//student Name:- Gagandeep kaur sidhu Student Id:- C0731555

// CSD 3354 Section 2

//Assignment 3



namespace ConsoleApp3



{

    public delegate void Sort_DataStructure();

    class Program

    {

        static void Main(string[] args)

        {

            Student a = new Student();

            a.Announcement();



        }

    }



    class Student

    {

        String Student_name;

        String StudentID;

        double StudentGPA;



        // TODO: change this implementation so that the program pulls names from a Text File:

        // to do this, you must change the container for Student Names from Array to List

        