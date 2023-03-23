using System;

namespace Multi_Dimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D Array
            string[,] matriz;

            //3D array
            int[,,] threeD;

            //two dimensional array 
            int[,] array2D = new int[,]
            {
                {1, 2, 3,}, //row 0
                {4, 5, 6,}, //row 1
                {7, 8, 9,}  //row 2
            };

            Console.WriteLine("Central value is: " + array2D[1, 1]);
            // First parameter: Row
            // Second parameter: Column


            // three dimensional array
            // depth, height and length
            string[,,] array3D = new string[,,]
        {
            {
                {"Gustavo", "Manuel", "Ricardo"},
                {"Leonardo", "Lobos", "Tomás"},
                {"Jeopardo", "Drummond", "Kubitscheck" }
            },
            {
                {"Amanda", "Silva", "Juliano"},
                {"Raíssa", "dos Santos", "Letícia" },
                {"Null", "Hugo", "Fernanda" }
            }
        };
            Console.WriteLine("Value is: " + array3D[0, 2, 0]);
            // First value: depth
            string[,] array2DString = new string[3, 2]
            {
                {"one", "two" },
                {"three", "four" },
                {"five", "six" }
            };

            array2DString[1, 1] = "Chicken";
            Console.WriteLine(array2DString[1,1]);
            // Returns the dimensions of an array
            int dimensions = array2DString.Rank;
            Console.WriteLine(dimensions);


            //non-specified rank array
            //doesn't need the "new int" statement
            int[,] array2D2 = { { 1, 2 }, { 3, 4 }, };
        }
    }
}
