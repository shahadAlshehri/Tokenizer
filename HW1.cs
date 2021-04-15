using System;
using System.Collections.Generic;
namespace Tokenizer
{


        class Program
        {


            static void Main(string[] args)
            {

                string tweet = Console.ReadLine();
                List<string> found = new List<string>();

                foreach (var item in tweet.Split(' '))
                {
                    if (item.StartsWith("#") || item.StartsWith("@"))
                    {
                        found.Add(item);
                    }

                }
                foreach (var item in found)

                {
                    if (item.StartsWith('#'))
                    {
                        Console.WriteLine("hashtag: {0}", item);

                    }
                    else if (item.StartsWith('@'))
                    {

                        Console.WriteLine("user: {0}", item);

                    }
                }

                countTweet(found);


            }
            static void countTweet(List<string> arr)
            {
                int count_h = 0;
                int count_m = 0;

                foreach (var item in arr)
                {
                    if (item.StartsWith("#"))
                    {
                        count_h++;
                    }
                    else if (item.StartsWith("@"))
                    {
                        count_m++;

                    }
                }
                Console.WriteLine("The number of hashtags: " + count_h);
                Console.WriteLine("The number of mentions: " + count_m);
            }
        }

    }
