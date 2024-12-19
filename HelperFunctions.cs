using System;

namespace LibraryManagementConsoleApp {
    internal class HelperFunctions {

        public static string ReadInput(string prompt) {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

    }
}
