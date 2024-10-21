Console.WriteLine("\n\n\n\n\n\n\n");

int[] ages; //declare the array variable
ages = new int[5]; //instantiates the array ("new" keyword)

//initialize the array
ages[0] = 11;
ages[1] = 32;
ages[2] = 55;
ages[3] = 90;
ages[4] = 1;

// for(int c = 0; c < ages.Length; c++)
// {
//     Console.Write($"The person in the {c} ");
//     Console.WriteLine($"slot of the array is {ages[c]} years old.");
// }
//exercise: print the values of the arry from the 4th slot to the 0th slot
// for(int c = ages.Length - 1; c >= 0; c--)
// {
//     Console.Write($"The person in the {c} ");
//     Console.WriteLine($"slot of the array is {ages[c]} years old.");
// }
double[] marks = new double[5];
marks[0] = 79.2;
marks[1] = 84.5;
marks[2] = 65;
marks[3] = 91;
marks[4] = 74;

//exercise: calculate the average of the marks in the array
double sumOfMarks = 0;
// sumOfMarks = marks[0] + marks[1] + marks[2] + marks[3] + marks[4];
// Console.WriteLine($"The average is {sumOfMarks / 5}.");
// for(int c = 0; c < marks.Length; c++)
// {
//     sumOfMarks += marks[c]; //sumOfMarks = sumOfMarks + marks[c];
// }
// Console.WriteLine($"The average is {sumOfMarks / marks.Length}.");

//exercise: print out the biggest mark in the array
double biggestMark = 0;
// for(int c = 0; c < marks.Length; c++)
// {
//     if(marks[c] > biggestMark)
//     {
//         biggestMark = marks[c];
//     }
// }
Array.Sort(marks);
if(marks.Length > 1)
    biggestMark = marks[marks.Length - 1];
}
Console.WriteLine($"The biggest mark is {biggestMark}.");