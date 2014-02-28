using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Given two arrays that have numbers that are sorted
// and do not repeat, get the intersection and union of 
// these two sets

namespace UnionAndIntersectionArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1, 2, 3, 5, 6, 99, 100, 101};

            int[] arr2 = { 2, 4, 6, 8, 100, 1000 };

            var intersection = GetIntersection(arr1, arr2);

            Console.WriteLine("Intersection of two given arrays is");

            for (int i = 0; i < intersection.Count; i++)
            {
                Console.Write(intersection[i] + " ");
            }

            Console.WriteLine("Union of two arrays is");

            var union = GetUnion(arr1, arr2);

            for (int i = 0; i < union.Count; i++)
            {
                Console.Write(union[i] + " ");
            }
        }

        // O(n) time 
        // Space complexity - O(size of output)
        static List<int> GetIntersection(int[] arr1, int[] arr2)
        {
            int i = 0;
            int j = 0;

            List<int> result = new List<int>();

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] == arr2[j])
                {
                    result.Add(arr1[i]);
                    i++;
                    j++;
                }
                else if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return result;
        }

        static List<int> GetUnion(int[] arr1, int[] arr2)
        {
            int i = 0;
            int j = 0;

            List<int> result = new List<int>();

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] == arr2[j])
                {
                    result.Add(arr1[i]);
                    i++;
                    j++;
                }
                else if (arr1[i] < arr2[j])
                {
                    result.Add(arr1[i]);
                    i++;
                }
                else
                {
                    result.Add(arr2[j]);
                    j++;
                }
            }

            while (i < arr1.Length)
            {
                result.Add(arr1[i]);
                i++;
            }

            while (j < arr2.Length)
            {
                result.Add(arr2[j]);
                j++;
            }

            return result;
        }
    }
}

