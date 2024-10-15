using System;
using System.Formats.Asn1;
using System.Reflection.PortableExecutable;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number System

            // int i, j;
            // for (i = 1; i < 9; i++)
            // {
            //     for (j = 1; j <=i; j++)
            //     {
            //         Console.Write(j);
            //     }
            //     Console.WriteLine();
            // }

            //Find largest Number between 3 Number;

            // int a=10;
            // int b=30;
            // int c=29;
            // int max=Math.Max(a,b);
            // int fMax= Math.Max(max,c);
            // Console.WriteLine(fMax);

            // Print Hello: Russel Hassan

            // Console.Write("Hello:");
            // Console.WriteLine(" Russell Hasan");

            //math

            // Console.WriteLine(-1 + 4 * 6);
            // Console.WriteLine((35 + 5) % 7);
            // Console.WriteLine(14 + (-4 * 6) / 11);
            // Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            //number SWAP

            // Console.WriteLine("Enter Value for 'X' and 'Y'");
            // int ch = Convert.ToInt32(Console.ReadLine());
            // int ch_2 = Convert.ToInt32(Console.ReadLine());
            // int t = 0;
            // t = ch;
            // ch = ch_2;
            // ch_2 = t;
            // Console.WriteLine("x={0}", ch);
            // Console.WriteLine("y={0}", ch_2);

            //Table
            // int input = Convert.ToInt32(Console.ReadLine());
            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine("{1} * {0} = {2}",i,input,input * i);
            // }

            //order
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("your age is {0}", age);

            // int a = Convert.ToInt32(Console.ReadLine());
            // int b = Convert.ToInt32(Console.ReadLine());
            // int c = Convert.ToInt32(Console.ReadLine());
            // int equalCount = 0;
            // if (a == b)
            // {
            //     equalCount++;
            // }
            // else if (b == c)
            // {
            //     equalCount++;
            // }
            // else if (c == a)
            // {
            //     equalCount++;
            // }
            // Console.WriteLine(equalCount);

            //Convert Temparature
            // int inpTemp = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Your Entered Temparature is {0}", inpTemp);
            // Console.WriteLine("In Fahrenheit: {0}", ((9 * inpTemp) / 5) + 32);
            // Console.WriteLine("In Kelvin: {0}", (inpTemp + 273.15));

            //Change Position
            // string inp = Console.ReadLine();
            // if (inp.Length <= 1)
            // {
            //     Console.WriteLine(inp);
            // }
            // else
            // {
            //     char firstChar = inp[0];
            //     char lastChar = inp[inp.Length - 1];
            //     string middlePart = inp.Substring(1, inp.Length - 2);
            //     Console.WriteLine("Result is {0}{1}{2}", lastChar, middlePart, firstChar);
            // }

            //Remove Specific Charecter
            // string inp = Console.ReadLine();
            // if (inp.Length <= 1)
            // {
            //     Console.WriteLine(inp);
            // }
            // else
            // {
            //     int pos = Convert.ToInt32(Console.ReadLine());
            //     if (inp.Length < pos && pos <= 0)
            //     {
            //         Console.WriteLine("Operatio Not Possible");
            //     }
            //     else
            //     {
            //         char dChar = inp[pos];
            //         Console.WriteLine(dChar);
            //         string modStr = inp.Remove(pos, 1);
            //         Console.WriteLine("Result is {0}", modStr);
            //     }
            // }

            //#17
            // string inp = Console.ReadLine();
            // if (inp.Length <= 1)
            // {
            //     Console.WriteLine(inp);
            // }
            // else
            // {
            //     char firstChar = inp[0];
            //     Console.WriteLine("Result is: {0}{1}{0}", firstChar, inp);

            // }

            //#18
            // int num_1=Convert.ToInt32(Console.ReadLine());
            // int num_2=Convert.ToInt32(Console.ReadLine());
            // if(num_1<0&&num_2>0||num_1>0&&num_2<0){
            //     Console.WriteLine("True");
            // }else{
            //     Console.WriteLine("false");
            // }

            // //#19
            // int num_1=Convert.ToInt32(Console.ReadLine());
            // int num_2=Convert.ToInt32(Console.ReadLine());
            // if(num_1==num_2){
            //     Console.WriteLine(3*(num_1+num_2));
            // }else{
            //     Console.WriteLine(num_1+num_2);
            // }

            //#20
            // int num_1 = Convert.ToInt32(Console.ReadLine());
            // int num_2 = Convert.ToInt32(Console.ReadLine());
            // int res = num_1 - num_2;
            // if (res < 0)
            // {
            //     int abValue = (-1 * (res));
            //     Console.WriteLine(abValue);
            // }
            // if (num_1 > num_2)
            // {
            //     Console.WriteLine(num_1 - num_2);
            // }

            //21
            //     int num_1 = Convert.ToInt32(Console.ReadLine());
            //     int num_2 = Convert.ToInt32(Console.ReadLine());
            //     if (num_1 + num_2 == 20 || num_1 == 20 || num_2 == 20)
            //     {
            //         Console.WriteLine("True");
            //     }
            //     else
            //     {
            //         Console.WriteLine("False");
            //     }

            //22
            // int num_1 = Convert.ToInt32(Console.ReadLine());
            // if (Math.Abs(num_1 - 100) <= 20 || Math.Abs(num_1 - 200) <= 20)
            // {
            //     Console.WriteLine("true");
            // }else{
            //     Console.WriteLine("false");
            // }

            //23
            // string inp=Console.ReadLine().ToLower();
            // Console.WriteLine(inp);

            //24
            // string inp = Console.ReadLine();
            // string words = inp.Split(new[] { ' ', ',', '.', '?' },);

            //25
            // for (int i = 1; i <= 99; i++)
            // {
            //     Console.WriteLine(i);
            // }

            //26
            // int number = 2;
            // int count = 0;
            // long sum = 0;
            // for (; count < 500; number++)
            // {
            //     bool isPrime = true;
            //     if (number < 2)
            //     {
            //         isPrime = false;
            //     }
            //     else
            //     {
            //         for (int i = 2; i * i <= number; i++)
            //         {
            //             if (number % i == 0)
            //             {
            //                 isPrime = false;
            //                 break;
            //             }
            //         }
            //     }
            //     if (isPrime)
            //     {
            //         sum += number;
            //         count++;
            //     }
            // }
            // Console.WriteLine(sum);

            //24
            // string inp = Console.ReadLine();
            // string[] words = inp.Split(new[] { ' ' }, StringSplitOptions.None);
            // string word = "";
            // int ctr = 0;
            // foreach (String s in words)
            // {
            //     if (s.Length > ctr)
            //     {
            //         word = s;
            //         ctr = s.Length;
            //     }
            // }
            // Console.WriteLine(word);

            //27
            // int num_1=Convert.ToInt32(Console.ReadLine());
            // int sum=0;
            // while(num_1 !=0){
            //     sum+=num_1%10;
            //     num_1/=10;
            // }
            // Console.WriteLine(sum);

            //28
            // string line = Console.ReadLine();
            // string result = "";
            // List<string> wordsList = new List<string>();
            // string[] words = line.Split(new[] { ' ' }, StringSplitOptions.None);

            // for (int i = words.Length - 1; i >= 0; i--)
            // {
            //     result += words[i] + " ";
            // }
            // wordsList.Add(result);

            // foreach (string s in wordsList)
            // {
            //     Console.WriteLine(s);
            // }

            //29
            // FileInfo f = new FileInfo("/home/students/abc.txt");
            // Console.WriteLine("\nSize of a file: " + f.Length.ToString());

            //30
            //string hexval = "4B0";

            // int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);

            // Console.WriteLine("Decimal number: " + decValue);

            //31
            //     int[] first_array = {1, 3, -5, 4};
            // int[] second_array = {1, 4, -5, -2};
            // Console.WriteLine("\nArray1: [{0}]", string.Join(", ", first_array));
            // Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));
            // Console.WriteLine("\nMultiply corresponding elements of two arrays: ");
            // for (int i = 0; i < first_array.Length; i++) {
            //     Console.Write(first_array[i] * second_array[i] + " ");
            // }
            // Console.WriteLine("\n");

            //32
            // string str;
            // int l = 0;
            // Console.Write("Input a string : ");
            // str = Console.ReadLine();
            // if (str.Length > 4)
            // {
            //     Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) +
            //     str.Substring(str.Length - 4) + str.Substring(str.Length - 4) +
            //     str.Substring(str.Length - 4));

            //33
            // Console.WriteLine("\nInput first integer:");

            // int x = Convert.ToInt32(Console.ReadLine());

            // if (x > 0)
            // {
            //     Console.WriteLine(x % 3 == 0 || x % 7 == 0);

            // }

            //34
            //     string str;

            // Console.Write("Input a string : ");

            // str = Console.ReadLine();
            // Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith
            // ("Hello") && str[5] == ' '));

            //35
            // Console.Write("Input a first number(<100): ");

            // // Read user input and convert it to an integer 'm'
            // int m = Convert.ToInt32(Console.ReadLine());

            // // Prompt the user to input the second number greater than 200
            // Console.Write("Input a second number(>200): ");


            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine((m < 100 && n > 200));

            //36
            // Console.Write("Input a first number: ");

            // // Read user input and convert it to an integer 'm'
            // int m = Convert.ToInt32(Console.ReadLine());

            // // Prompt the user to input the second number
            // Console.Write("Input a second number: ");

            // // Read user input and convert it to an integer 'n'
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(((m >= -10 && m <= 10)) || ((n >= -10 && n <= 10)));

            //37
            //     string str = "PHP Tutorial";
            // Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));

            //38
            //  string str1 = "PHP Tutorial";

            // // Initialize an empty string variable 'result' to store the concatenated characters
            // var result = "";

            // // Check if the length of 'str1' is greater than or equal to 1 and if the first character is 'P'
            // if (str1.Length >= 1 && str1[0] == 'P')
            //     // If true, append the first character 'P' to the 'result' string
            //     result += str1[0];

            // // Check if the length of 'str1' is greater than or equal to 2 and if the second character is 'H'
            // if (str1.Length >= 2 && str1[1] == 'H')
            //     // If true, append the second character 'H' to the 'result' string
            //     result += str1[1];

            // // Print the final concatenated string stored in the 'result' variable
            // Console.WriteLine(result);

            //39
            // Console.WriteLine("\nInput first integer:");

            // // Read the input and convert it to an integer 'x'
            // int x = Convert.ToInt32(Console.ReadLine());

            // // Prompt the user to input the second integer
            // Console.WriteLine("Input second integer:");

            // // Read the input and convert it to an integer 'y'
            // int y = Convert.ToInt32(Console.ReadLine());

            // // Prompt the user to input the third integer
            // Console.WriteLine("Input third integer:");

            // // Read the input and convert it to an integer 'z'
            // int z = Convert.ToInt32(Console.ReadLine());

            // // Find and display the largest of the three integers using Math.Max method
            // Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));

            // // Find and display the smallest of the three integers using Math.Min method
            // Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));

            //40
            // Console.WriteLine("\nInput first integer:");

            //         // Read the input and convert it to an integer 'x'
            //         int x = Convert.ToInt32(Console.ReadLine());

            //         // Prompt the user to input the second integer
            //         Console.WriteLine("Input second integer:");

            //         // Read the input and convert it to an integer 'y'
            //         int y = Convert.ToInt32(Console.ReadLine());

            //         // Declare and assign a constant integer 'n' with the value 20
            //         int n = 20;

            //         // Calculate the absolute difference between 'x' and 'n', and store it in 'val1'
            //         var val1 = Math.Abs(x - n);

            //         // Calculate the absolute difference between 'y' and 'n', and store it in 'val2'
            //         var val2 = Math.Abs(y - n);

            //         // Output 0 if 'val1' is equal to 'val2', otherwise output the number closer to 'n' among 'x' and 'y'
            //         Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y)); 

            //41
            //     Console.Write("Input a string (contains at least one 'w' char) : ");

            // // Read the input string and store it in the variable 'str'
            // string str = Console.ReadLine();

            // // Count the occurrences of the character 'w' in the input string and store the count in 'count'
            // var count = str.Count(s => s == 'w');

            // // Display a message indicating the test for the presence of 'w' character between 1 and 3 times
            // Console.WriteLine("Test the string contains 'w' character between 1 and 3 times: ");

            // // Check if the count of 'w' characters is between 1 and 3 (inclusive) and print the result
            // Console.WriteLine(count >= 1 && count <= 3);  

            //42
            // Console.Write("Input a string: ");

            // // Read the input string and store it in the variable 'str'
            // string str = Console.ReadLine();

            // // Check if the length of the input string is less than 4 characters
            // if (str.Length < 4) 
            //     // If the length is less than 4, convert the whole string to uppercase and display it
            //     Console.WriteLine(str.ToUpper());
            // else
            //     // If the length is 4 or greater, convert the first 4 characters to lowercase
            //     // and concatenate the rest of the string as is, then display the modified string
            //     Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4));

            //43
            //     Console.Write("Input a string : ");

            //     // Read the input string and store it in the variable 'str'
            //     string str = Console.ReadLine();

            //     // Call the 'test' method with the input string and output the result
            //     Console.WriteLine(test(str));
            // }
            // public static bool test(string str)
            // {
            //     var ctr = 0; // Initialize a counter variable 'ctr' to count occurrences of 'w'

            //     // Iterate through the characters of the string using a for loop
            //     for (var i = 0; i < str.Length - 1; i++)
            //     {
            //         // Check if the current character is 'w'; if so, increment the counter 'ctr'
            //         if (str[i].Equals('w'))
            //             ctr++;
            //         if (str.Substring(i, 2).Equals("ww") && ctr > 2)
            //             return true; // If the condition is met, return 'true'
            //     }

            //     return false; 

            //44
            // Console.Write("Input a string : ");

            // // Read the input string and store it in the variable 'str'
            // string str = Console.ReadLine();

            // // Initialize an empty string variable 'result' to store the characters at even indices
            // var result = string.Empty;

            // // Iterate through the characters of the input string using a for loop
            // for (var i = 0; i < str.Length; i++) {
            //     // Check if the index 'i' is even (i.e., divisible by 2 without remainder)
            //     // If the index is even, add the character at index 'i' to the 'result' string
            //     if (i % 2 == 0)
            //         result += str[i];
            // }

            // // Output the 'result' string containing characters at even indices from the input string
            // Console.WriteLine(result);

            //45
            // Console.WriteLine("\nInput an integer:");

            // // Read the input integer and store it in the variable 'x'
            // int x = Convert.ToInt32(Console.ReadLine());

            // // Define an array of integers 'nums' with pre-defined values
            // int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};

            // // Display a message indicating the number being searched for in the array
            // Console.WriteLine("Number of " + x + " present in the said array:");

            // // Count the occurrences of the input integer 'x' in the 'nums' array and print the count
            // Console.WriteLine(nums.Count(n => n == x));

            //46
            // Console.WriteLine("\nInput an integer:");

            // // Read the input integer and store it in the variable 'x'
            // int x = Convert.ToInt32(Console.ReadLine());
            // int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
            // Console.WriteLine((nums[0] == x) || (nums[nums.Length - 1] == x));

            //47
            // int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            // Console.WriteLine((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length - 1])));

            //48
            //     int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};

            // // Display the elements of the 'nums' array using string.Join to concatenate them
            // Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));

            // var sum = 0;
            // for (var i = 0; i < nums.Length; i++)
            // {
            //     sum += nums[i]; // Add each element of the array to the 'sum' variable
            // }

            // // Display the sum of all elements in the array
            // Console.WriteLine("Sum: " + sum);

            //49
            // int[] nums1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};

            // // Display the elements of 'nums1' array using string.Join to concatenate them
            // Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums1));

            // // Define another array of integers 'nums2' with pre-defined values
            // int[] nums2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};

            // // Display the elements of 'nums2' array using string.Join to concatenate them
            // Console.WriteLine("\nArray2: [{0}]", string.Join(", ", nums2));
            // Console.WriteLine((nums1[0].Equals(nums2[0])) || (nums1[nums1.Length - 1].Equals
            // (nums2[nums2.Length - 1])));

            //50
            // int[] nums = {1, 2, 8};
            // Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));

            // var temp = nums[0];
            // for (var i = 0; i < nums.Length - 1; i++)
            // {
            //     nums[i] = nums[i + 1]; // Shift each element one place to the left
            // }

            // nums[nums.Length - 1] = temp;
            // Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));

            //51
            // int[] nums = {1, 2, 5, 7, 8};
            // Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            // var h_val = nums[0];
            // for (var i = 0; i < nums.Length; i++)
            // {
            //     if (nums[i] > nums[0])
            //         h_val = nums[i]; // Update the highest value if condition is met
            // }
            // Console.WriteLine("\nHighest value between first and last values of the said array: {0}", h_val);

            //52
            // int[] array1 = {1, 2, 5};
            // Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array1));
            // int[] array2 = {0, 3, 8};
            // Console.WriteLine("\nArray2: [{0}]", string.Join(", ", array2));
            // int[] array3 = {-1, 0, 2};
            // Console.WriteLine("\nArray3: [{0}]", string.Join(", ", array3));
            // int[] new_array = { array1[1], array2[1], array3[1] };
            // Console.WriteLine("\nNew array: [{0}]", string.Join(", ", new_array));

            //53
            //     int[] nums = {2, 4, 7, 8, 6};

            //     // Displaying the original array
            //     Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));

            //     // Checking if the array contains an odd number and displaying the result
            //     Console.WriteLine("Check if an array contains an odd number? " + even_odd(nums));
            // }  

            // // Function to check if the array contains an odd number
            // public static bool even_odd(int[] nums)  
            // {
            //     // Iterating through each element of the array
            //     foreach (var n in nums)
            //     {
            //         // Checking if the element is odd
            //         if (n % 2 != 0) 
            //             return true; // If an odd number is found, return true
            //     }
            //     return false; // If no odd number is found, return false

            //54
            //         Console.WriteLine(centuryFromYear(1799) == 18); // Verifies if the century for year 1799 is 18
            //         Console.WriteLine(centuryFromYear(1900) == 19); // Verifies if the century for year 1900 is 19
            //         Console.WriteLine(centuryFromYear(1901) == 19); // Verifies if the century for year 1901 is 19
            //         Console.WriteLine(centuryFromYear(1901) == 20); // This line seems to have an incorrect expectation (1901 can't be both 19th and 20th century)
            //         Console.WriteLine(centuryFromYear(1806) == 19); // Verifies if the century for year 1806 is 19
            //         Console.WriteLine(centuryFromYear(1568) == 20); // Verifies if the century for year 1568 is 20
            //         Console.WriteLine(centuryFromYear(2010) == 21); // Verifies if the century for year 2010 is 21
            //         public static int centuryFromYear(int year)
            // {
            //     // Calculation of the century by dividing the year by 100 and adding 1 if there's a remainder
            //     return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);

            //55
            //         Console.WriteLine(array_adjacent_elements_product(new int[] { 2, 4, 2, 6, 9, 3 }) == 27);
            //     Console.WriteLine(array_adjacent_elements_product(new int[] { 0, -1, -1, -2 }) == 2);
            //     Console.WriteLine(array_adjacent_elements_product(new int[] { 6, 1, 12, 3, 1, 4 }) == 36);
            //     Console.WriteLine(array_adjacent_elements_product(new int[] { 1, 4, 3, 0 }) == 16);
            //     }
            //     public static int array_adjacent_elements_product(int[] input_array)
            // {
            //     // Initializing variables
            //     int array_index = 0;

            //     // Calculating the product of the first two elements in the array
            //     int product = input_array[array_index] * input_array[array_index + 1];

            //     // Moving to the next element in the array
            //     array_index++;

            //     // Loop to calculate the maximum product of adjacent elements
            //     while (array_index + 1 < input_array.Length)
            //     {
            //         // Checking if the product of the current adjacent elements is greater than the existing product
            //         product = ((input_array[array_index] * input_array[array_index + 1]) > product) ?
            //                    (input_array[array_index] * input_array[array_index + 1]) :
            //                     product;

            //         // Moving to the next pair of adjacent elements in the array
            //         array_index++;
            //     }

            //     // Returning the maximum product of adjacent elements in the array
            //     return product;

            //56
            //  Console.WriteLine(checkPalindrome("aaa"));    // Output: True
            //         Console.WriteLine(checkPalindrome("abc"));    // Output: False
            //         Console.WriteLine(checkPalindrome("madam"));  // Output: True
            //         Console.WriteLine(checkPalindrome("1234"));

            //         }
            //         public static bool checkPalindrome(string inputString)
            //     {
            //         // Convert the input string into a character array
            //         char[] c = inputString.ToCharArray();

            //         // Reverse the character array
            //         Array.Reverse(c);
            //         return new string(c).Equals(inputString);

            //57
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, -3, 4, -5, 1 })); // Output: 20
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, 4, 5, 2 })); // Output: 20
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, -4, 5, 2 })); // Output: 15
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 0, -4, 0, 2 }));
        }
        public static int adjacent_Elements_Product(int[] input_Array)
        {
            // Initialize the maximum product with the product of the first two elements in the array
            int max = input_Array[0] * input_Array[1];

            // Loop through the array to find the maximum product of adjacent elements
            for (int x = 1; x <= input_Array.Length - 2; x++)
            {
                // Update the max variable with the maximum of the current max and the product of the current and next elements
                max = Math.Max(max, input_Array[x] * input_Array[x + 1]);
            }

            // Return the maximum product of adjacent elements
            return max;
        }
    }
}