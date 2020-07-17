using Common;
using Common.Extensions;
using Nancy.Json;
using System;
using System.Collections.Generic;

namespace CustomIdConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Case 1. Random generated ID */
            CustomId id1 = new CustomId();
            Console.WriteLine($"Generated id: {id1}");
            //CustomID2Int(id1.ToString());

            /* Case 2. Input from user */
            //Console.Write("ID: ");
            //string id2 = Console.ReadLine();
            //CustomID2Int(id2);
        }
        #region Useful methods

        private static void CustomID2Int(string id)
        {
            Console.WriteLine($"Integer result: {HashUtils.ConvertCustomIdToInt(id)}");
        }

        #endregion End Useful methods
    }
}
