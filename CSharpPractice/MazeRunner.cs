using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CSharpPractice
{
    /// <summary>
    /// A mad scientist with tenure has created an experiment tracking
    /// mice in a maze. Several mazes have been randomly generated, and
    /// you've been tasked with writing a program to determine the
    /// mazes in which it's possible for the mouse to reach the cheesy
    /// endpoint. Write a function which accepts a maze in the form of
    /// a collection of rows, each row is a string where:
    /// 
    /// spaces represent areas where the mouse can walk freely
    /// hashes (#) represent walls where the mouse can not walk
    /// M represents the mouse's starting point
    /// C represents the cheese which the mouse must reach
    ///
    /// The mouse is not allowed to travel diagonally in the maze (only
    /// up/down/left/right), nor can he escape the edge of the maze.
    /// Your function must return true if the maze is solvable by the mouse.
    /// 
    /// Source: http://www.4clojure.com/problem/117
    /// License: EPL v 1.0  https://www.eclipse.org/legal/epl-v10.html
    /// </summary>
    [TestFixture]
    [Hard]
    public class MazeRunner
    {
        private bool IsMazeSolvable( string[] maze )
        {
            throw new NotImplementedException();
        }

        [Test]
        [TestCaseSource(nameof(Mazes))]
        public void TestMaze( string[] maze, bool shouldBeSolvable )
        {
            var solvable = IsMazeSolvable(maze);

            Assert.That(solvable, Is.EqualTo(shouldBeSolvable));
        }

        public static IEnumerable<TestCaseData> Mazes
        {
            get
            {
                yield return new TestCaseData(
                    new []{ "M   C" },
                    true
                );

                yield return new TestCaseData(
                    new []{ "M # C" },
                    false
                );

                yield return new TestCaseData(
                    new [] {
                        "#######",
                        "#     #",
                        "#  #  #",
                        "#M # C#",
                        "#######"
                    },
                    true
                );

                yield return new TestCaseData(
                    new [] {
                        "########",
                        "#M  #  #",
                        "#   #  #",
                        "# # #  #",
                        "#   #  #",
                        "#  #   #",
                        "#  # # #",
                        "#  #   #",
                        "#  #  C#",
                        "########"
                    },
                    false
                );

                yield return new TestCaseData(
                    new [] { 
                        "M     ",
                        "      ",
                        "      ",
                        "      ",
                        "    ##",
                        "    #C"
                    },
                    false
                );

                yield return new TestCaseData(
                    new [] {
                        "C######",
                        " #     ",
                        " #   # ",
                        " #   #M",
                        "     # "
                    },
                    true
                );

                yield return new TestCaseData(
                    new [] {
                        "C# # # #",
                        "        ",
                        "# # # # ",
                        "        ",
                        " # # # #",
                        "        ",
                        "# # # #M"
                    },
                    true
                );
            }
        }
    }
}

