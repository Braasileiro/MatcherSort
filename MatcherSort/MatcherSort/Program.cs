/*
    MatcherSort: A program to organize two identical files but with their contents in different order.

    Copyright (C) 2017  Lucas Cota (BrasileiroGamer)
    lucasbrunocota@live.com
    <http://www.github.com/BrasileiroGamer/>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

/*
 *	Program.cs
 *	Author: Lucas Cota (BrasileiroGamer)
 *	Description: Main Method.
 *  Date: 2017-03-11
 */

using System;
using System.IO;

namespace MatcherSort
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				if (args.Length < 2 || args.Length > 3)
				{
					throw new IndexOutOfRangeException();
				}
				else if (args.Length == 2)
				{
					if (!File.Exists(args[0]) || !File.Exists(args[1]))
					{
						throw new FileNotFoundException();
					}
					StreamManager.MatchedStream(args[0], args[1]);
				}
				else if (args.Length == 3)
				{
					if (!File.Exists(args[0]) || !File.Exists(args[1]) || !File.Exists(args[2]))
					{
						throw new FileNotFoundException();
					}
					StreamManager.MatchedStream(args[0], args[1], args[2]);
				}
			}
			catch (IndexOutOfRangeException)
			{
				UsageParameters.ShowHelp();
			}
			catch (FileNotFoundException)
			{
				Console.WriteLine("[Error] Invalid input files.");
			}
			catch (ArgumentOutOfRangeException)
			{
				Console.WriteLine("[Error] The optional file '" + args[2] + "' does not have the same number of rows in the file '" + args[1] + "'.");
			}
			catch (Exception)
			{
				Console.WriteLine("[Error] Fatal unhandled exception.");
			}
		}
    }
}
