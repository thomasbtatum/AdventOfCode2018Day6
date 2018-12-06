using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018Day6
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = @"162, 168
86, 253
288, 359
290, 219
145, 343
41, 301
91, 214
166, 260
349, 353
178, 50
56, 79
273, 104
173, 118
165, 47
284, 235
153, 69
116, 153
276, 325
170, 58
211, 328
238, 346
333, 299
119, 328
173, 289
44, 223
241, 161
225, 159
266, 209
293, 95
89, 86
281, 289
50, 253
75, 347
298, 241
88, 158
40, 338
291, 156
330, 88
349, 289
165, 102
232, 131
338, 191
178, 335
318, 107
335, 339
153, 156
88, 119
163, 268
159, 183
162, 134";

            string[] lines = input.Split(
                    new[] { Environment.NewLine },
                    StringSplitOptions.None);

            //var v1 = new Vertex() { X = 1, Y = 1 };
            //var v2 = new Vertex() { X = 7, Y = 7 };

            //bool isTrue = v2.ManhattenDistance(v1) == v1.ManhattenDistance(v2);

            var verticies = lines.Select(v => new Vertex(v)).ToList();

            part1(verticies);
            part2(lines);

            int y = 1;

        }

        private static void part1(List<Vertex> verticies)
        {
            var maxX = verticies.Max(e => e.X);
            var maxY = verticies.Max(e => e.Y);

            var minX = verticies.Min(e => e.X);
            var minY = verticies.Min(e => e.Y);

            for (int i = minX; i < maxX; i++)
            {
                for (int j = minY; j < maxY; j++)
                {
                    



                }
            }
        }

        private static void part2(string[] lines)
        {
            throw new NotImplementedException();
        }
    }
}
