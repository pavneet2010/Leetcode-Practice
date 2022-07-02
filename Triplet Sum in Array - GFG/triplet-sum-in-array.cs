// { Driver Code Starts
//Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {

                var stringArray = Console.ReadLine().Split(' ');
                int n = int.Parse(stringArray[0]);
                int x = int.Parse(stringArray[1]);
                int[] arr = new int[n];
                stringArray = Console.ReadLine().Split(' ');
                int j = 0;
                for (int i = 0; i < stringArray.Length; i++)
                {
                    if (stringArray[i].CompareTo(" ") != -1)
                    {
                        arr[j] = int.Parse(stringArray[i]);

                        j++;
                    }
                }
                Solution obj = new Solution();
                var res = obj.find3Numbers(arr, n,x);
                Console.WriteLine(res ? 1 : 0);
            }

        }
    }



    
 // } Driver Code Ends
//User function Template for C#

    class Solution
    {
        //Function to find if there exists a triplet in the 
        //array A[] which sums up to X.
        public   bool find3Numbers(int[] arr, int n, int X)
    {
        //code here
        Dictionary<int, int> dict = new Dictionary<int, int>();
        Dictionary<int, int> result = new Dictionary<int, int>();

        foreach (int i in arr)
        {
            if (!dict.ContainsKey(i) && i <= X)
            {
                dict.Add(i, X - i);
            }
        }
        //Console.WriteLine(dict.Count);
        for (int i = 0; i < dict.Count; i++)
        {

            int numberToBeSum = dict.ElementAt(i).Value;
            
            for (int j = i + 1; j < dict.Count; j++)
            {

                int firstNum = dict.ElementAt(j).Key;
                for (int k=j+1;k< dict.Count && firstNum<numberToBeSum; k++)
                {
                    if(firstNum+ dict.ElementAt(k).Key== numberToBeSum)
                    {
                        return true;
                    }
                }
                
            }
        }

        return false;
    }

    }

}

// { Driver Code Starts.  // } Driver Code Ends