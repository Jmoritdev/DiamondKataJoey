using System;

namespace DiamondKataJoey {
    public class DiamondCreator {
        public static string CreateDiamond(char middleChar) {
            
            var result = "";

            //go up including middle
            for (char x = 'A'; x <= middleChar; x++) {
                result += CreateLine(x, middleChar);
            }

            //and back down
            for (char x = Convert.ToChar((int)middleChar - 1); x >= 'A'; x--) {
                result += CreateLine(x, middleChar);
            }

            return result;
        }

        private static string CreateLine(char currentChar, char middleChar) {
            string result = "";

            int sideSpaces = middleChar - currentChar;

            if (currentChar == 'A') { //A is the only one written one time per line so we make an exception
                result += "A";
                result = result.PadLeft(sideSpaces + 1, ' ');
                result = result.PadRight(sideSpaces * 2 + 1, ' ');
                return result += '\n';
            }

            //we can calculate the spaces in the middle by subtracting sidespace and letters from total width
            int middleSpaces = GridHeightAndWidth(middleChar) - (2 * sideSpaces) - 2;

            result = result.PadLeft(sideSpaces, ' ');
            result += currentChar;
            result = result.PadRight(middleSpaces + sideSpaces + 1, ' ');
            result += currentChar;
            result = result.PadRight(sideSpaces * 2 + middleSpaces + 2, ' ');

            return result += '\n';
        }

        //calculate width and height of grid
        private static int GridHeightAndWidth(char middleChar)
            => (middleChar - 'A' + 1) * 2 - 1;
    }
}