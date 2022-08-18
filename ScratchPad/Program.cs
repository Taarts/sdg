using System;
using System.Collections.Generic;
using System.Linq;

namespace ScratchPad
{
    class Program
    {

        public static int FindShort(string s)
        // Simple, given a string of words, return the length of the shortest word(s).

        // String will never be empty and you do not need to account for different data types.

        // given a string
        // work with words
        // Example: "bitcoin take over the world maybe who knows perhaps"
        // - bitcoin
        // -  take
        // -  over 
        // - the
        // -  world 
        //  - maybe
        // - who
        // - knows
        // - perhaps
        {
        var words = s.Split(" ");
        var lengths = words.Select(word => word.Length);
        var smallest = lengths.Min();

            return smallest;
        }
    }
}