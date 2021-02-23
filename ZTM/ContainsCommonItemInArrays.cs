namespace DATASTRUCTURES.ZTM
{
    using System;
    using System.Collections.Generic;

    public class ContainsCommonItemInArrays
    {
        public bool CheckCommonItemInArrays(char[] array1, char[] array2)
        {
            HashSet<char> LookUps = new HashSet<char>();

            foreach (var item in array1)
            {
                if(!LookUps.Contains(item))
                {
                    LookUps.Add(item);
                }
            }

            foreach (var item in array2)
            {
                if(LookUps.Contains(item))
                {
                    return true;
                }
            }
            
            return false;
        }

        public static void MainMethod()
        {
            char[] array1 = new char[] { 'a', 'b', 'c', 'd' };
            char[] array2 = new char[] { 'p', 'e', 'f', 'g' };
            ContainsCommonItemInArrays containsCommonItemInArrays = new ContainsCommonItemInArrays();
            bool found = containsCommonItemInArrays.CheckCommonItemInArrays(array1, array2);
            Console.WriteLine(found);
        }
    }
}


