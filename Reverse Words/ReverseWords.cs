using System;
using System.IO;

namespace ReverseWords
{
    class ReverseWords
    {
        static int Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (null == line) continue;

                    string[] numberBlocks = line.Split(' ');

                    string output = "";

                    for (int index = numberBlocks.Length - 1; 0 <= index; --index)
                    {
                        output += numberBlocks[index] + " ";
                    }

                    output.Trim();

                    if (output != "")
                    {
                        Console.WriteLine(output);
                    }
                }
            }

            return 0;
        }
    }
}
