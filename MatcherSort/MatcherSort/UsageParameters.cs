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
 *	StreamManager.cs
 *	Author: Lucas Cota (BrasileiroGamer)
 *	Description: Usage Parameters Explanations.
 *  Date: 2017-03-11
 */

using System;

namespace MatcherSort
{
	class UsageParameters
	{
		public static void ShowHelp()
		{
			Console.Clear();
			Console.WriteLine("MatcherSort v2017.1\n");
			Console.WriteLine("[defaultFile] The template file.");
			Console.WriteLine("[targetedFile] The file to be sorted according to the template file.");
			Console.WriteLine("[optionalFile] The file to be sorted according to the template file, on line based of targeted file.\n");
			Console.WriteLine("Usage: MatcherSort [defaultFile] [targetedFile] [[optionalFile]]");
		}
	}
}
