/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK

*/
using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}",final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[]{"Marshall", "Student","Center"};
            string[] bulls_string2 = new string[]{"MarshallStudent", "Center"};
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch ='c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.

        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"

        Example 2:
        Input: s = "aeiou"
        Output: ""

        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here
                //Creating variable for storing result
                String result = "";
                //Checking constraint
                if (s.Length > 10000 || s.Length < 0)
                {
                    Console.WriteLine("The length of the string is more than 10000 characters");
                }
                else
                {
                    foreach (char c in s)
                    {
                        //Check if vowels exist in string
                        if (!"aeiouAEIOU".Contains(c.ToString()))
                        {
                            result = result + c;
                        }
                    }
                }
                //returning result
                String final_string = result.ToString();
                return final_string;
                //This practice was fairly easy with using buildin function such as .Contains
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false

       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                // write your code here.
                //implementing constaints (Tolower)
                string input1 = (string.Concat(bulls_string1)).ToLower();
                string input2 = (string.Concat(bulls_string2)).ToLower();
                int lengthOfInput1 = input1.Length;
                int lengthOfInput2 = input2.Length;
                //Checking whether the length of 2 strings are equal or not
                if (lengthOfInput1 != lengthOfInput2)
                {
                    return false;
                }
                else
                {
                    //Chicking if the characters in both strings are the same
                    return string.Equals(input1, input2);
                }
                //This practice had some challenges regrading comparsion of 2 different string char by char. it took me 1 hour to solve it.

            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                //Defining needed variables
                int lengthofarray = bull_bucks.Length;
                int[] duplicates = new int[lengthofarray];
                int sum = 0;
                int i = 0;
                int j = 0;
                int counter = 0;
                //Chicking constraint
                if (lengthofarray > 1000 || lengthofarray < 1)
                {
                    Console.WriteLine("The length of input is more than 100 or less than 1");
                }
                else
                {
                    //By creating a new array I can save 1 or more than one in array.
                    //If the associated array is equal to 1 the number is unique and if it is greater than 1 the number is repeated
                    for (i = 0; i < lengthofarray; i++)
                    {
                        duplicates[i] = -1;
                    }
                    for (i = 0; i < lengthofarray; i++)
                    {
                        counter = 1;
                        for (j = i + 1; j < lengthofarray; j++)
                        {
                            if (bull_bucks[i] == bull_bucks[j])
                            {
                                counter++;
                                duplicates[j] = 0;
                            }
                        }
                        if (duplicates[i] != 0)
                        {
                            duplicates[i] = counter;
                        }
                    }
                    //looping over unique values
                    for (i = 0; i < lengthofarray; i++)
                    {
                        if (duplicates[i] == 1)
                        {
                            sum = sum + bull_bucks[i];
                        }
                    }
                }

                return sum;
                //This assignment wes the hardest one and took me a day to figure out how to deal with constraint and the problem solution
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*

        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>

        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                
                    // write your code here.
                    //defining needed variables
                    int sum1 = 0;
                    int sum2 = 0;
                    //Getting array length
                    int arraylength = bulls_grid.GetLength(0);
                    //Checking constraints
                    for (int i = 0; i < arraylength; i++)
                    {
                        for (int j = 0; j < arraylength; j++)
                        {
                            //if row and column of the matrix is equal then we sum values as the primary diagonal
                            if (i == j)
                            {
                                sum1 += bulls_grid[i, j];
                                Console.WriteLine("sum of prim:" + sum1);
                            }
                            //Else if the row + column is equal to number of rows/columns-1 then we sum them up as secondary diagonal
                            else if (i + j == arraylength - 1 && i != j)
                            {
                                sum2 += bulls_grid[i, j];
                                Console.WriteLine("sum of other:" + sum2);

                            }
                        }
                    }
                    //Print out the sum of both diagonals as the final result

                    return sum1 + sum2;
                    //This was a great problem. I learned how to look from different perspective and creatively at a problem
                    //I learned to break down a problem to smaller solutions. it took me 3 hours to solve this one.
                
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.

        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"

        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                // write your code here.
                //Defining needed variables
                int arraylength = indices.Length;
                char[] reversed = new char[arraylength];
                int indexofchar = 0;
                char gotcharacter;

                //Looping over the array to find first index 0 and then find the associated character in string and put it in new array
                for (int i = 0; i <= arraylength - 1; i++)
                {
                    indexofchar = Array.IndexOf(indices, i);
                    gotcharacter = bulls_string[indexofchar];
                    reversed[i] = gotcharacter;

                }
                //print out the result by concatinating the array of characters
                string s = string.Concat(reversed);
                return s;
                //This problem waas fairly easy took me 1 hour to complete it.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.

        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".

        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".

        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                //Defining the needed variables
                int InputStringLength = bulls_string6.Length;
                int counter = 0;
                int indexofchar = 0;
                char[] reversed = new char[InputStringLength];
                int j = 0;
                string LeftOver = "";
                string result = "";

                //Chicking for constraints
                if (InputStringLength > 250 || InputStringLength < 1)
                {
                    Console.WriteLine("The length of the input can not be more than 250 or less than 1 character");
                }
                else
                {
                    //checked to see if the string is lowercase or not
                    if (bulls_string6.Equals(bulls_string6.ToLower()))
                    {
                        //check to see if the character is lowercase or not
                        if (Char.IsUpper(ch))
                        {
                            Console.WriteLine("The character must be lower case");
                        }
                        else
                        {
                            //Finding the associated index of the character inside the string
                            foreach (char c in bulls_string6)
                            {
                                if (c == ch && counter == 0)
                                {
                                    counter = 1;
                                    indexofchar = bulls_string6.IndexOf(ch);

                                }
                            }
                            //Put the characters in reversed order inside an array
                            for (int i = indexofchar; i >= 0; i--)
                            {
                                reversed[j] = bulls_string6[i];
                                j = j + 1;
                            }
                            //Getting whatever left of the string
                            LeftOver = bulls_string6.Remove(0, indexofchar + 1);
                            string s = new string(reversed);
                            //concatinating the string and the reversed string
                            result = s + LeftOver;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Please enter lower case string");
                    }
                }
                String prefix_string = result;
                return prefix_string;

                //As a problem it was intresting to work so much with characters. I learned about new ways to handle my code than using existing methodes
                //It took 4 hours to complete the task
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
