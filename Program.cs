namespace LibraryManagementConsoleApp {
    internal class Program {
        static void Main(string[] args) {

            Library library = new Library();
            library.AddBook("C# for beginners", "John Doe");
            library.ListBook();

        }
    }
}
