using System;

namespace EssentialTraining
{
    public class FlowControl
    {
        public bool IsYourFavoriteColorBlue(string color)
        {
            if (color.ToLower() == "blue")
            {
                return true;
            }
            return false;
        }

        public bool IsYourFavoriteColorRed(string color)
        {
            if (color.ToLower() == "red") return true;
            return false;
        }

        public bool IsYourFavoriteColorGreen(string color)
        {
            return (color.ToLower() == "green") ? true : false;
        }

        public bool IsYourFavoriteColorYellow(string color)
        {
            return color.ToLower() == "yellow";
        }

        public string PrimaryOrSecondary(string color)
        {
            var result = "Secondary";

            if(color.ToLower() == "red") { result = "Primary"; }
            else if (color.ToLower() == "blue") { result = "Primary"; }
            else if (color.ToLower() == "yellow") { result = "Primary"; }

            return result;
        }

        public string SecondaryOrPrimary(string color)
        {
            var result = "";
            switch(color.ToLower())
            {
                case "red": result = "Primary"; break;
                case "yellow": result = "Primary"; break;
                case "blue": result = "Primary"; break;
                default: result = "Secondary"; break;
            }
            return result;
        }

        public string PrimaryOrSecondaryCompound(string color)
        {
            if (color.ToLower() == "red" || color.ToLower() == "blue" || color.ToLower() == "yellow")
            {
                return "Primary";
            }
            return "Secondary";
        }

        public string GradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score > 79 && score < 90)
            {
                return "B";
            }
            else if (score >= 70 && score <= 79)
            {
                return "C";
            }
            return "F";
        }

        public string IsYourNameNotBruce(string yourName)
        {
            if (yourName.ToLower() != "bruce")
            {
                return "Can we call you Bruce for the sake of simplicity?";
            }
            return "G'day, Bruce.";
        }
    }
}
