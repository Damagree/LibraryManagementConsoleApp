using System;
using System.Collections.Generic;

namespace LibraryManagementConsoleApp {
    class Library {

        private List<Book> books = new List<Book>();

        public void AddBook(string title, string author) {
            books.Add(new Book {
                Title = title,
                Author = author
            });
        }

        public void ListBook() {
            foreach (var book in books) {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
        }
    }
}
