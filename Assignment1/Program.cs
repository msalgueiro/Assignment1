
using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment1
    {
        class Program
        {
            static void Main(string[] args)
            {

                //Question 1
                Console.WriteLine("Q1 : Enter the number of rows for the triangle:");
                int n = Convert.ToInt32(Console.ReadLine());
                printTriangle(n);
                Console.WriteLine();

                //Question 2:
                Console.WriteLine("Q2 : Enter the number of terms in the Pell Series:");
                int n2 = Convert.ToInt32(Console.ReadLine());
                printPellSeries(n2);
                Console.WriteLine();

                //Question 3:
                Console.WriteLine("Q3 : Enter the number to check if squareSums exist:");
                int n3 = Convert.ToInt32(Console.ReadLine());
                bool flag = squareSums(n3);
                if (flag)
                {
                    Console.WriteLine("Yes, the number can be expressed as a sum of squares of 2 integers");
                }
                else
                {
                    Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
                }

                //Question 4:
                int[] arr = { 3, 1, 4, 1, 5 };
                Console.WriteLine("Q4: Enter the absolute difference to check");
                int k = Convert.ToInt32(Console.ReadLine());
                int n4 = diffPairs(arr, k);
                Console.WriteLine("There exists {0} pairs with the given difference", n4);

                //Question 5:
                List<string> emails = new List<string>();
                emails.Add("dis.email + bull@usf.com");
                emails.Add("dis.e.mail+bob.cathy@usf.com");
                emails.Add("disemail+david@us.f.com");
                int ans5 = UniqueEmails(emails);
                Console.WriteLine("Q5");
                Console.WriteLine("The number of unique emails is " + ans5);

                //Quesiton 6:
                string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                        { "Delhi", "London" } };
                string destination = DestCity(paths);
                Console.WriteLine("Q6");
                Console.WriteLine("Destination city is " + destination);

            }

            /// <summary>
            ///Print a pattern with n rows given n as input
            ///n – number of rows for the pattern, integer (int)
            ///This method prints a triangle pattern.
            ///For example n = 5 will display the output as: 
            ///     *
            ///    ***
            ///   *****
            ///   *******
            ///  *********
            ///returns      : N/A
            ///return type  : void
            /// </summary>
            /// <param name="n"></param>
            private static void printTriangle(int n)
            {
                try
                {
                              
                    for (int i = 1; i <= n; i++) // Loops through the number of rows to be created.
                    {
                        for (int x = 1; x <= n - i; x++) // Loops through each column to add the spaces(" ").
                        {
                            Console.Write(" "); // This writes a space if the above condition (x<=n-i) is met.
                        }
                        for (int x = 1; x <= 2 * i - 1; x++) // Loops through each column to add the starts("*").
                    {
                            Console.Write("*"); //This writes a star if the above condition(x<=2*i-1) is met.
                    }
                        Console.Write("\n"); // After each row is created it moves to the next line.
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                /* Comments for Question 1:Took me a lot of time to understand the logic of how to build that triangled structure but then the 
                 coding part was had elemetns which synthax I already knew so it was only hard to figure out how to perfom the logic 
                into conde. */
            }

            /// <summary>
            ///<para>
            ///In mathematics, the Pell numbers are an infinite sequence of integers.
            ///The sequence of Pell numbers starts with 0 and 1, and then each Pell number is the sum of twice of the previous Pell number and 
            ///the Pell number before that.:thus, 70 is the companion to 29, and 70 = 2 × 29 + 12 = 58 + 12. The first few terms of the sequence are :
            ///0, 1, 2, 5, 12, 29, 70, 169, 408, 985, 2378, 5741, 13860,… 
            ///Write a method that prints first n numbers of the Pell series
            /// Returns : N/A
            /// Return type: void
            ///</para>
            /// </summary>
            /// <param name="n2"></param>
            private static void printPellSeries(int n2)
            {
                try
                {
                    int i = 1, next = 0, pell = 0;
                    if (n2 == 0) // If input provided is 0 , meaning 0 numbers from the Pell series then it returns (" ").
                    {
                        Console.WriteLine(" "); // Prints space
                    }
                    else if (n2 == 1) // If input provided is 1 , meaning the first number from the Pell series then it returns ("0").
                    {
                        Console.WriteLine("0"); // Prints 0.
                    }
                    else if (n2 == 2) //  If input provided is 2 , meaning the 1st and 2nd numbers from the Pell series then it returns the bellow:
                    {
                        Console.Write(0 + "\t"); // Prints 0 and adds line.
                        Console.Write(i + "\t"); // Prints the value of 'i' which is set to 1 and adds line.
                    }
                    else // For all other scenarios where input is 3 or more, meaning the first 3 or more numbers from the Pell series then it returns the bellow:
                    {
                        Console.Write(0 + "\t"); // Prints 0 and adds line.
                        Console.Write(i + "\t"); // Prints the value of 'i' which is set to 1 and adds line.
                        next = (2 * i) + 0; // We use this formula to calculate the next term in the Pell series with the logic being the next term would be equal 2 times the second term plus the first.
                        Console.Write(next + "\t");  // Prints the value of 'next' which would be the thrid term ('2') and adds line.
                        for (int k = 0; k < (n2 - 3); k++) // Runs a loop for through k numbers starting at 0 until number input given -3. Incrementing k by 1 after each loop.
                        {
                            pell = (2 * next) + i; // Similarly we use the same logic that the next term would be equal 2 times the term before plus the term before the before term.
                            Console.Write(pell + "\t"); // We print the following pell series term and add a line. 
                            i = next; // After the next term is calculated, we assing the previos number to reset the loop assign the value that before was next to i.
                            next = pell;  // Similarly, We reset the value of next to be the pell term just printed, this is for the next loop to have different values in its calculation of the next pell term.   
                        }
                    }

                }
                catch (Exception)
                {

                    throw;
                }
                /* Comments for Question 2:Similarly took me about one hour to figure it out, but was not among the hardest of the 6 as a lot of it 
                was based on if statements. */
        }


        /// <summary>
        ///Given a non-negative integer c, decide whether there're two integers a and b such that a^2 + b^2 = c.
        ///For example:
        ///Input: C = 5 will return the output: true (1*1 + 2*2 = 5)
        ///Input: A = 3 will return the output : false
        ///Input: A = 4 will return the output: true
        ///Input: A = 1 will return the output : true
        ///Note: You cannot use inbuilt Math Class functions.
        /// </summary>
        /// <param name="n3"></param>
        /// <returns>True or False</returns>

        private static bool squareSums(int n3)
            {
                try
                {
                    for (int a = 0; a <= n3; a++) // First we loop through all possible integer a values.
                    {
                        for (int b = 0; b <= n3; b++) // Then we loop through all possible integer b values.
                        {
                            if (((a * a) + (b * b) == n3)) //This formlua indicates the condition, If numbers met the a^2 + b^2 = c logic. We could consider adding  "&&(a != b))"condition asumming a and b can not be the same numbers, but this is never told. 
                            {
                                return true; // If the logic or condition above is satisfied(a^2 + b^2 = c), then the this fucntion will return a true value.
                            }
                        }
                    }
                    return false; // For the rest of the scnearios where the logic or condition above is NOT satisfied(a^2 + b^2 is NOT= c), this funtion will return a false value.
                }

                catch (Exception)
                {
                    throw;
                }
                /* Comments for Question 3: Took me a while to figure it out but out of the 6 I can say this one 
                 was the less harder.*/
        }

        /// <summary>
        /// Given an array of integers and an integer n, you need to find the number of unique
        /// n-diff pairs in the array.Here a n-diff pair is defined as an integer pair (i, j),
        ///where i and j are both numbers in the array and their absolute difference is n.
        ///Example 1:
        ///Input: [3, 1, 4, 1, 5], k = 2
        ///Output: 2
        ///Explanation: There are two 2-diff pairs in the array, (1, 3) and(3, 5).
        ///Although we have two 1s in the input, we should only return the number of unique   
        ///pairs.
        ///Example 2:
        ///Input:[1, 2, 3, 4, 5], k = 1
        ///Output: 4
        ///Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and
        ///(4, 5).
        ///Example 3:
        ///Input: [1, 3, 1, 5, 4], k = 0
        ///Output: 1
        ///Explanation: There is one 0-diff pair in the array, (1, 1).
        ///Note : The pairs(i, j) and(j, i) count as same.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns>Number of pairs in the array with the given number as difference</returns>
        private static int diffPairs(int[] nums, int k)
            {
                try
                {
                    int[] dist = nums.Distinct().ToArray(); //Create a new array with all the distint numbers.
                    int x = dist.Length; // assing to x the value of this dist lenght
                    
                    if (k == 0) // When k is 0, we count similar elements
                    {
                        return (nums.Length - x); // return the number of similar elements, original lenght of the array minus the elemetns moved to array dist
                    }
                    
                    if (x == 1 && nums.Length >= 2) // if all elements are the same then 1 must be returned.
                    { 
                        return 1;  // return 1 as output.
                    }  

                    int count = 0; // we set count to 0.
                    for (int i = 0; i < x; i++) // For the rest we are going to run a loop where i starts as 0 and runs as iti is less than the lenght of dist.
                    {
                        for (int j = i + 1; j < x; j++) // We are going to the the same but instead of i we are going to run a loop for i+1 which would be j. 
                        {
                            if (Math.Abs(dist[i] - dist[j]) == k) // Now we check if the absolute different of each i and i+1 number in dist array is equal to k. If so execute the below statement. 
                                {
                                    count++; // We increment the count if the above condition is met. 
                                }
                            
                        }
                            
                    }

                    return count; // retunr as output the count.
                }
                catch (Exception e)
                {

                    Console.WriteLine("An error occured: " + e.Message);
                    throw;
                }
                /* Comments for Question 4: For me this one was one was the most difficult as I started trying to 
                 compare the highest values with lowest that did not work as I became stuck. Later thought of
                 this simpler apprach. */
        }

        /// <summary>
        /// An Email has two parts, local name and domain name. 
        /// Eg: rocky @usf.edu – local name : rocky, domain name : usf.edu
        /// Besides lowercase letters, these emails may contain '.'s or '+'s.
        /// If you add periods ('.') between some characters in the local name part of an email address, mail sent there will be forwarded to the same address without dots in the local name.
        /// For example, "bulls.z@usf.com" and "bullsz@leetcode.com" forward to the same email address.  (Note that this rule does not apply for domain names.)
        /// If you add a plus('+') in the local name, everything after the first plus sign will be ignored.This allows certain emails to be filtered, for example ro.cky+bulls @usf.com will be forwarded to rocky@email.com.  (Again, this rule does not apply for domain names.)
        /// It is possible to use both of these rules at the same time.
        /// Given a list of emails, we send one email to each address in the list.Return, how many different addresses actually receive mails?
        /// Eg:
        /// Input: ["dis.email+bull@usf.com","dis.e.mail+bob.cathy@usf.com","disemail+david@us.f.com"]
        /// Output: 2
        /// Explanation: "disemail@usf.com" and "disemail@us.f.com" actually receive mails
        /// </summary>
        /// <param name="emails"></param>
        /// <returns>The number of unique emails in the given list</returns>

        private static int UniqueEmails(List<string> emails)
            {
                try
                {
                    List<string> rightemails = new List<string>();
                    for (int x = 0; x < emails.Count; x++)
                    {
                        string str = emails[x];  // We copy each mail to a separte string

                        int atsymbol = str.IndexOf("@"); // Stores in atsymbol the index or position of the "@" symbol.
                        string adress = str.Substring(0, atsymbol); // Stores in adress the first part of the email adress before the "@" symbol, without the domain.
                        atsymbol++;
                        string domain = str.Substring(atsymbol); // Stores the domain section of the email(everyhting after the "@" symbol). 

                        int plussymbol = adress.IndexOf("+"); // Stores in plussymbol the index or position of the "+" symbol.
                        adress = adress.Substring(0, plussymbol); // Stores in adress the a string that only includes the splitted first part of the adress string before the "+" symbol.

                        int dot = adress.IndexOf("."); // Stores in dot the index or position of the "." symbol.
                        
                        while (dot > -1 ) // Loop will run until no more "." exist in adress, index of -1 means the character is not in the string.
                        {
                            adress = adress.Remove(dot, 1); // Remove the "." character alone in the adress string and the rest stays the same.
                            dot = adress.IndexOf("."); // After the "." is removed from adress, we search again to see if there are any more "." symbols in the remaining string adress. If there are it will return the index and continue looping, if no more "." exist it will return -1 and stop looping
                    }
                    int space = adress.IndexOf(" "); // Similarly we identify if there are any spaces left in the adress string after doing all this operations to it. If there are it will store the index if not it will store -1.
                    while (space > -1) // Runs a loop until all " " are removed form the adress string, only if string does not have " " sapces it will give a -1 value,to stop the loop.
                    {
                        adress = adress.Remove(space, 1); // Remove the " " sacpes in the adress string and the rest stays the same.
                        space = adress.IndexOf(" "); // After any " " spaces removed from the adress string , we search again to see if there are any more " " spaces in the remaining string adress. If there are it will return the index and continue looping, if no more "." exist it will return -1 and stop looping.
                    }
                    string finaladress = adress + "@" + domain; // We add the modified and filtered adress string to the @ character and the domain part before extracted.
                        rightemails.Add(finaladress); // Now we add the newly created finalemails to the list created at the beggining.
                }
                    List<string> UniqueEmails = rightemails.Distinct().ToList(); // We will store the unique emails in another list, this method analyzes the rightemails list and only moves to the new list the one of each unique email, if there are repated only one would be selected. 
                    int differentemails = 0; // We set the differentemails counter to 0 to start. 
                    foreach (string email in UniqueEmails) // For each email in the unique list the bellow would happen
                    {
                        differentemails++; // The differentemails counter will increment each time a email is unique.
                    }
                    return differentemails; // Finally the number of different emails will be returned.
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
                /* Comments for Question 5: One of the hardest of the 6. I am sure there might be easier ways of doing 
                it than just this manual going modification fo strings. */
            }

            /// <summary>
            /// You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi. Return the destination city, that is, the city without any path outgoing to another city.
            /// It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
            /// Example 1:
            /// Input: paths = [["London", "New York"], ["New York","Tampa"], ["Delhi","London"]]
            /// Output: "Tampa" 
            /// Explanation: Starting at "Delhi" city you will reach "Tampa" city which is the destination city.Your trip consist of: "Delhi" -> "London" -> "New York" -> "Tampa".
            /// Input: paths = [["B","C"],["D","B"],["C","A"]]
            /// Output: "A"
            /// Explanation: All possible trips are: 
            /// "D" -> "B" -> "C" -> "A". 
            /// "B" -> "C" -> "A". 
            /// "C" -> "A". 
            /// "A". 
            /// Clearly the destination city is "A".
            /// </summary>
            /// <param name="paths"></param>
            /// <returns>The destination city string</returns>
            private static string DestCity(string[,] paths)
            {
                try
                {
                    int flights = paths.GetLength(0); // Stored in flights the number of flights
                    string finaldestination= null; // Created an empty string for the final destination value to be stored at the end.
                    for (int i = 0; i < flights; i++) // We loop through the rows until all origins are covered.
                    {
                        for (int j = 0; j < flights; j++) // We loop through the rows until all destinations are covered.
                    {
                            if (paths[j, 1] != paths[i, 0] && i != j)  //This conditional identifies from the destination cities the one that does not have a origin corresponding to it, meaning it does not have any connection and thus is the final destination.
                            {
                                finaldestination = paths[j, 1];  // Stores as a string the final destination or unique destination city that does not have an origin city corresponding to it.
                            }
                        }
                    }
                    return finaldestination; // Returns the final destination value stored.


                }
                catch (Exception)
                {
                    throw;
                }

                /* Comments for Question 6: Hard difficulty problem for me considering my level. Took me about an hour.
                Must improve in timing.  */

        }


    }
    }

/* After doing the assignment my major concern is time. I am new to the C# language and I have found that
it takes an incredible amount of time to be able to understand how to put the logic and ideas into code. 

For some parts of this assingment I required a lot of back and forward to the begginers book and internet searches to
be able to get the correct synthax for what I was doing.

As part of the learning curve I will continue practicing more of the Katis exercises and once I feel more confortable 
with the language I will start doing those exercises timed with a certain restriction to simulate the time constraint 
and stress that I will be facing in the exam. 

I struggled a lot in this first assigment and would say I am behind the curve with the class as I still learning C#. 

Online tutorial videos have been usefull but have found less documentation and blogs about this language than 
when compared to others I have used before like Python.

My personal recommendation is to have the types of assignments as early in the course so that students that are new 
to this language and coding like me start struggling early and have enough time to practice before the exam.
I am just concerned that for each of this problems it took me a while to solve them and in the exam not sure how I
will deal with that time constraint.

Overall I found the exercises hard since I am beginner but will try to throught exercising get to this level as 
soon as possible.*/

