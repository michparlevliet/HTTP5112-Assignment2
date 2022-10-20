using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace HTTP5112_Assignment2_MichelleParlevliet.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// The method takes two input numbers from a user which represent sides of a die and outputs how many possibile variations would combine to add up to 10
        /// </summary>
        /// <param name="m">The number of sides on die 1</param>
        /// <param name="n">The number of sides on die 2</param>
        /// <returns>"There are a total of x ways to get the sum 10</returns>
        /// <example>
        /// GET: localhost/api/j2/dicegame/6/8 -> "There are a total of 5 ways to get the sum 10"
        /// </example>

        [HttpGet]
        [Route("api/j2/dicegame/{m}/{n}")]

        public IEnumerable<string> DiceGame(int m, int n)
        {
            int DesiredSum = 10;
            int RunningCount = 0;

            /// FOR LOOP LOGIC
            for (int x = 1; x <= m; x++)
            {
                for (int y = 1; y <= n; y++)
                {
                    if (x + y == DesiredSum)
                    {
                        RunningCount++;
                    }
                }
            }

            /// RETURN STATEMENT
            return new string[]
            {
                "There are a total of "+RunningCount+" ways to get the sum "+DesiredSum
            };
        }
    }
}
