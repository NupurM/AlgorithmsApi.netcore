using Microsoft.AspNetCore.Mvc;

namespace Searches.Controllers
{
    [Produces("application/json")]
    [Route("api/BinarySearch")]
    public class BinarySearchController : ControllerBase
    {
        readonly int[] givenArray = { 1, 3, 4, 5, 7, 8, 9 };

        // Get: api/binarysearch
        // Will return the array index
        [HttpGet("{x}")]
        public int FindX(int x)
        {
            int min = 0;
            int max = givenArray.Length - 1;
            int midpoint;
            int currentValue;

            if (x < givenArray[min] || x > givenArray[max]) return -1;

            while (min <= max)
            {
                midpoint = (min + max) / 2;
                currentValue = givenArray[midpoint];
                if (currentValue == x)
                {
                    return midpoint;
                }
                if (x < currentValue)
                {
                    max = midpoint - 1;
                }
                else
                {
                    min = midpoint + 1;
                }
            }

            return 100 + x;
        }
    }
}