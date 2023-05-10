using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Models;

namespace Library.Business
{
    public class Logic
    {

        private SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB; Database=librarynew; Integrated Security=true;");
        /// <summary>
        /// Creates new instance of the database and adds the username, password and the name of the user in it. 
        /// The user has a unique autoincremented number attached to them. 
        /// </summary>
        public void SignUp(string name, string username, string password)
        {
            librarynewContext context = new librarynewContext();
            var user = new Users();
            user.Name = name;
            user.Username = username;
            user.Password = password;
            context.Add(user);
            context.SaveChanges();
        }
        /// <summary>
        /// Creates a new instance of the database and checks if the username
        /// and password in the textboxes match any of those of the users in the table
        /// </summary>
        public bool Login(string username, string password)
        {
            librarynewContext context = new librarynewContext();
            bool success;
            var user = context.Users.SingleOrDefault(x => x.Username == username && x.Password == password);
            if (user == null)
            {
                MessageBox.Show("Incorrect username or password! Please try again!");
                success = false;
            }
            else
            {
                success = true;
            }
            return success;
        }
        /// <summary>
        /// Adds a book with its details into the database
        /// </summary>
        public void AddBook(string name, string isbn, string author, string genre)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into books values (@name, @isbn, @author, @category);", connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@isbn", isbn);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@category", genre);
            command.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Adds the book to the personal list of the user
        /// </summary>
        public void AddBookToUser(Books book, Users user)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into rating (userId,bookId) values (@userId, @bookId);", connection);
            command.Parameters.AddWithValue("@userId", user.UserId);
            command.Parameters.AddWithValue("@bookId", book.BookId);
            command.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Deletes the book from the personal list of the user
        /// </summary>
        public void DeleteBookFromUser(Books book, Users user)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from rating where userId = @userId and bookId = @bookId;", connection);
            command.Parameters.AddWithValue("@userId", user.UserId);
            command.Parameters.AddWithValue("@bookId", book.BookId);
            command.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Selects all books and returns them in a list, which can help with visualising the database
        /// </summary>
        public List<Books> GetList()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from books;", connection);
            List<Books> books = new List<Books>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Books book = new Books();
                    book.Name = reader["name"].ToString();
                    book.Author = reader["author"].ToString();
                    book.Category = reader["category"].ToString();
                    books.Add(book);
                }
            }
            connection.Close();
            return books;
        }
        /// <summary>
        /// This method helps with searching and filtering
        /// </summary>
        public List<Books> SearchInList(string searched, string categorised)
        {
            connection.Open();
            SqlCommand command = new SqlCommand();
            //This statement returns a matching list of books with what the user has put in
            if (categorised == "No category" && searched != "")
            {
                command = new SqlCommand("SELECT name, author, category from books where CHARINDEX(@name, name) > 0", connection);
                command.Parameters.AddWithValue("@name", searched);
            }
            //This if-statement checks the category which has been selected 
            //and the name of the book that is searched for and returns only the matching books
            else if (categorised != "No category" && searched != "")
            {
                command = new SqlCommand("SELECT name, author, category from books where CHARINDEX(@name, name) > 0 and category = @category", connection);
                command.Parameters.AddWithValue("@name", searched);
                command.Parameters.AddWithValue("@category", categorised);
            }
            //This if-statement returns a list of books with a matching category 
            //with that put in by the user
            else if (categorised != "No category" && searched == "")
            {
                command = new SqlCommand("SELECT name, author, category from books where category = @category", connection);
                command.Parameters.AddWithValue("@category", categorised);
            }
            //This if-statement returns the full list of books if nothing is selected
            else
            {
                command = new SqlCommand("select * from books", connection);
            }
            //After all these checks have been passed, the matching books are put into a list
            //and displayed
            List<Books> books = new List<Books>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Books book = new Books();
                    book.Name = reader["name"].ToString();
                    book.Author = reader["author"].ToString();
                    book.Category = reader["category"].ToString();
                    books.Add(book);
                }
            }
            connection.Close();
            return books;
        }
        /// <summary>
        /// Returns the book's details coresponding to its name
        /// </summary>
        public Books Find(string index)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from books where name = @name", connection);
            command.Parameters.AddWithValue("@name", index);
            Books book = null;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.Read())
                {
                    connection.Close();
                    throw new ArgumentNullException("There is no user with that id!", new NullReferenceException());
                }
                book = new Books();
                book.BookId = Convert.ToInt32(reader["bookId"]);
                book.Isbn = reader["isbn"].ToString();
                book.Name = reader["name"].ToString();
                book.Author = reader["author"].ToString();
                book.Category = reader["category"].ToString();
                connection.Close();

                return book;
            }
        }
        /// <summary>
        /// Returns the user with their matching name and password
        /// </summary>
        public Users FindUser(string username, string password)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from users where username = @username and password = @password", connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            Users user = null;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.Read())
                {
                    connection.Close();
                    throw new ArgumentNullException("There is no user with that id!", new NullReferenceException());
                }
                user = new Users();
                user.UserId = Convert.ToInt32(reader["userId"]);
                user.Name = reader["name"].ToString();
                user.Username = reader["username"].ToString();
                user.Password = reader["password"].ToString();
                connection.Close();

                return user;
            }
        }
        /// <summary>
        /// Returns the list of books added by a specific user
        /// </summary>
        public List<Books> SelectBookForUser(Users user)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select books.name, books.author , books.category , rating.rating from books join rating on books.bookId = rating.bookId where userId = @userId; ", connection);
            command.Parameters.AddWithValue("@userId", user.UserId);
            List<Books> books = new List<Books>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    Books book = new Books();
                    book.Name = reader["name"].ToString();
                    book.Author = reader["author"].ToString();
                    book.Category = reader["category"].ToString();
                    if (reader["rating"].Equals(System.DBNull.Value))
                    {
                        book.UserRating = 0;
                    }
                    else
                    {
                        book.UserRating = Convert.ToInt32(reader["rating"]);
                    }
                   
                    books.Add(book);
                }
            }
            connection.Close();
            return books;
        }
        /// <summary>
        /// Adds a rating
        /// </summary>
        public void AddRating(Books book, Users user, int rating)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update rating set rating = @rating where userId = @userId and bookId = @bookId;", connection);
            command.Parameters.AddWithValue("@userId", user.UserId);
            command.Parameters.AddWithValue("@bookId", book.BookId);
            command.Parameters.AddWithValue("@rating", rating);
            command.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Returns true if the user has already added selected book to their list
        /// </summary>
        public bool IsBookAdded(Users user , Books bookCheck)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select books.name, books.author , books.category , rating.rating from books join rating on books.bookId = rating.bookId where userId = @userId and books.bookId = @bookId; ", connection);
            command.Parameters.AddWithValue("@userId", user.UserId);
            command.Parameters.AddWithValue("@bookId", bookCheck.BookId);
            Books book = new Books();
            bool check = false;
            using (SqlDataReader reader = command.ExecuteReader())
            {

                if (!reader.Read())
                {
                    connection.Close();
                    return check;
                }
                else
                {
                    connection.Close();
                    check = true;
                    return check;
                }     
            }
        }
        /// <summary>
        /// Returns the average rating (calculated from all ratings of all users) of a book
        /// </summary>
        public float BookAvgRating(Books book)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT name, AVG(Cast (rating as float)) AS average FROM books B JOIN rating R ON B.bookId = R.bookId where name = @bookname GROUP By B.name ORDER BY average DESC", connection);
            command.Parameters.AddWithValue("@bookname", book.Name);
            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.Read())
                {
                    connection.Close();
                    return 0;
                }
                else
                {
                    if (reader["average"].Equals(System.DBNull.Value))
                    {
                        connection.Close();
                        return 0;
                    }
                    else
                    {
                        float a = float.Parse(String.Format("{0:0.00}", float.Parse(reader["average"].ToString())));
                        connection.Close();
                        return a;
                    }
                }
            }
        }
    }
}
