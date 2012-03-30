using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HDNMeetup
{
    public class BinaryChopper
    {
        public static int Chop(int searchingFor, int[] searchArray)
        {
            if (null == searchArray || searchArray.Length == 0)
                return -1;

            if (searchArray.Length == 1)
            {
                if (searchArray[0] == searchingFor) return 0;
                return -1;
            }

            int midPointIndex = searchArray.Length / 2;

            int midPointValue = searchArray[midPointIndex];

            if (midPointValue > searchingFor)
            {
                return Chop(searchingFor, searchArray.ToList().GetRange(0, midPointIndex).ToArray());
            }

            var result = Chop(searchingFor, searchArray.ToList().GetRange(midPointIndex, searchArray.Length - midPointIndex).ToArray());
            return result < 0 ? result : midPointIndex + result;

        }

    }
}
