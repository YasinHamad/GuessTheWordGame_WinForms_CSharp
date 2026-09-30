using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace GuessTheWordGame_WinForms_CSharp
{
    public static class Globals
    {
        public static Dictionary<String, Color> Colors = new Dictionary<string, Color>
        {
            //#153e69 
            { "DarkBlue", Color.FromArgb(21, 62, 105) },
            //#2f7ee9
            { "MainBlue", Color.FromArgb(47, 126, 233) },
            //#c9dbf0
            { "LightBlue", Color.FromArgb(201, 219, 240) },

            //#0a874c
            { "DarkGreen", Color.FromArgb(10, 135, 76) },
            //#A7FDDA
            { "MiddleGreen", Color.FromArgb(167, 253, 218) },
            //#cbf8ed
            { "LightGreen", Color.FromArgb(203, 248, 237) },

            //#e83c42
            { "Red", Color.FromArgb(232, 60, 66) },
            //#ffd7e2
            { "LightRed", Color.FromArgb(255, 215, 226) },

            //#FF8800
            { "Orange", Color.FromArgb(255, 136, 0) }
        };

        public enum Level {
            Easy = 3, Medium = 5, Hard = 7
        };
        public enum enCategory
        {
            Animals = 0, Food, Countries, Technology
        };

        public static Level Difficulty;
        public static enCategory Category;
        public static int NumberOfAttempts;
        public static string Word;
        public static bool RefreshPlayingForm;

        public interface Choosable
        {
            string GetRandomWord(Level level);
        };
        public class Animal : Choosable
        {
            List<string> animalsEasy = new List<string>()
            {
                "Cat", "Dog", "Cow", "Pig", "Fox"
            };

            List<string> animalsMiddle = new List<string>()
            {
                "Horse", "Tiger", "Zebra", "Panda", "Sheep"
            };

            List<string> animalsHard = new List<string>()
            {
                "Giraffe", "Dolphin", "Penguin", "Leopard", "Hamster"
            };
            public string GetRandomWord(Level level)
            {
                switch (level)
                {
                    case Level.Easy: return (animalsEasy[(new Random()).Next(1, 5)]);
                    case Level.Medium: return (animalsMiddle[(new Random()).Next(1, 5)]);
                    default:  return (animalsHard[(new Random()).Next(1, 5)]);
                }
            }

        };

        public class Food : Choosable
        {
            List<string> foodEasy = new List<string> ()
            {
                "Egg", "Ham", "Pie", "Bun", "Nut"
            };

            List<string> foodMiddle = new List<string> ()
            {
                "Pizza", "Bread", "Apple", "Bacon", "Pasta"
            };

            List<string> foodHard = new List<string>()
            {
                "Chicken", "Sausage", "Pancake", "Avocado", "Popcorn"
            };
            public string GetRandomWord(Level level)
            {
                switch (level)
                {
                    case Level.Easy: return (foodEasy[(new Random()).Next(1, 5)]);
                    case Level.Medium: return (foodMiddle[(new Random()).Next(1, 5)]);
                    default:  return (foodHard[(new Random()).Next(1, 5)]);
                }
            }
        };

        public class Country : Choosable
        {
            List<string> countriesEasy = new List<string> ()
            {
                "USA", "UAE", "KSA", "SYR"
            };

            List<string> countriesMiddle = new List<string> ()
            {
                "Egypt", "Japan", "China", "India", "Italy"
            };

            List<string> countriesHard = new List<string> ()
            {
                "Germany", "Nigeria", "Ukraine", "Tunisia", "Morocco"
            };
            public string GetRandomWord(Level level)
            {
                switch (level)
                {
                    case Level.Easy: return (countriesEasy[(new Random()).Next(1, 5)]);
                    case Level.Medium: return (countriesMiddle[(new Random()).Next(1, 5)]);
                    default:  return (countriesHard[(new Random()).Next(1, 5)]);
                }
            }
        };
        public class Technology : Choosable
        {
            List<string> technologyEasy = new List<string> ()
            {
                "RAM", "CPU", "USB", "App", "API"
            };

            List<string> technologyMiddle = new List<string> ()
            {
                "Mouse", "Linux", "Cloud", "Apple", "Robot"
            };

            List<string> technologyHard = new List<string> ()
            {
                "Python", "Browser", "Android", "Network", "Laptop"
            };
            public string GetRandomWord(Level level)
            {
                switch (level)
                {
                    case Level.Easy: return (technologyEasy[(new Random()).Next(1, 5)]);
                    case Level.Medium: return (technologyMiddle[(new Random()).Next(1, 5)]);
                    default:  return (technologyHard[(new Random()).Next(1, 5)]);
                }
            }
        };


        public static string GetRandomWord(Choosable choosable, Level level)
        {
            return choosable.GetRandomWord(level);
        }
    }
}
