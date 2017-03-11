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
 *	Description: File Stream Manager.
 *  Date: 2017-03-11
 */

using System.IO;
using System.Text;
using System.Collections;

namespace MatcherSort
{
	class StreamManager
	{
		public static void MatchedStream(string defaultFileName, string targetedFileName)
		{
			ArrayList defaultArray = new ArrayList(File.ReadAllLines(defaultFileName));
			ArrayList targetedArray = new ArrayList(File.ReadAllLines(targetedFileName));

			using (var streamFile = new StreamWriter("_streamed-" + targetedFileName, false, Encoding.UTF8))
			{
				foreach (var currentDefaultLine in defaultArray)
				{
					foreach (var currentTargetedLine in targetedArray)
					{
						if (currentTargetedLine.Equals(currentDefaultLine))
						{
							streamFile.WriteLine(currentTargetedLine);
							break;
						}
					}
				}
			}
		}

		public static void MatchedStream(string defaultFileName, string targetedFileName, string optionalFileName)
		{
			ArrayList defaultArray = new ArrayList(File.ReadAllLines(defaultFileName));
			ArrayList targetedArray = new ArrayList(File.ReadAllLines(targetedFileName));
			ArrayList optionalArray = new ArrayList(File.ReadAllLines(optionalFileName));

			using (var streamFile = new StreamWriter("_streamed-" + optionalFileName, false, Encoding.UTF8))
			{
				foreach (var currentDefaultLine in defaultArray)
				{
					for (int i = 0; i < targetedArray.Count; i++)
					{
						if (targetedArray[i].Equals(currentDefaultLine))
						{
							streamFile.WriteLine(optionalArray[i]);
							break;
						}
					}
				}
			}
		}
	}
}
