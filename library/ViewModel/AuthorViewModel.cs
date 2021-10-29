using System;
using System.Collections.ObjectModel;
using library.Model;

namespace library.ViewModel
{
    public class AuthorViewModel
    {
        public ObservableCollection<Author> ListAuthor { get; set; } =
        new ObservableCollection<Author>();
        public AuthorViewModel()
        {
            this.ListAuthor.Add(
            new Author
            {
                Id = 1,
                LastName = "Пушкин",
                FirstName = "Александр"
            });
            this.ListAuthor.Add(
            new Author
            {
                Id = 2,
                LastName = "Николай",
                FirstName = "Гоголь"
            });
            this.ListAuthor.Add(
            new Author
            {
                Id = 3,
                LastName = "Лев",
                FirstName = "Толстой"
            });
            this.ListAuthor.Add(
            new Author
            {
                Id = 4,
                LastName = "Федор",
                FirstName = "Достоевский"
            });
            this.ListAuthor.Add(
            new Author
            {
                Id = 5,
                LastName = "Михаил",
                FirstName = "Булгаков"
            });
        }
    }
}
