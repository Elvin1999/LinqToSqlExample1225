using LinqToSqlExample.Model;
using LinqToSqlExample.ModelExtention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LinqToSqlExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataClasses1DataContext context = new DataClasses1DataContext();

            //var result = from b in context.Books
            //             select b;

            //mydataGrid.ItemsSource = result;



            //var result = from b in context.Books
            //             where b.Pages > 450
            //             select b;

            //mydataGrid.ItemsSource = result;



            //var result = context.Books.Where(b => b.Pages > 450);
            //mydataGrid.ItemsSource = result;




            //var result = from b in context.Books
            //             where b.Pages == (context.Books.Max(i => i.Pages))
            //             select b;

            //mydataGrid.ItemsSource = result;



            //var result = from b in context.Books
            //             where b.Pages == (context.Books.Max(i => i.Pages))
            //             select new { Name = b.Name, Page = b.Pages };

            //mydataGrid.ItemsSource = result;



            //var result = from b in context.Books
            //             where b.Pages == (context.Books.Max(i => i.Pages))
            //             select new BookModel{ Name = b.Name, Page = b.Pages };

            //mydataGrid.ItemsSource = result;



            //var result = from a in context.Authors
            //             where a.Id == 1
            //             select a;

            //mydataGrid.ItemsSource = result;


            //var result = from a in context.Authors
            //             where a.FirstName.Contains("a")
            //             orderby a.FirstName descending
            //             select a;

            //mydataGrid.ItemsSource = result;



            //var result = from sc in context.S_Cards
            //             group sc by sc.Id_Book into mygroup
            //             select new { mygroup.Key, mygroup.First().Book.Name, MyCount = mygroup.Count() };
            //mydataGrid.ItemsSource = result;


            //var result = from sc in context.S_Cards
            //             group sc by sc.Id_Book into mygroup
            //             select mygroup;
            ////mydataGrid.ItemsSource = result;


            //StringBuilder sb = new StringBuilder();
            //foreach (var item in result)
            //{
            //    sb.Append(item.Key+" - "+item.First().Book.Name);
            //    foreach (var i in item)
            //    {
            //        sb.Append("\t\t\n" + i.Student.FirstName);
            //    }
            //    sb.AppendLine();
            //}

            //mylabel.Content = sb.ToString();


            //var result = from b in context.Books
            //             join a in context.Authors on b.Id_Author equals a.Id
            //             join c in context.Categories on b.Id_Category equals c.Id
            //             select new {BookName=b.Name,AuthorName=a.FirstName,CategoryName=c.Name};

            //mydataGrid.ItemsSource = result;

            //var author = new Author
            //{
            //    Id = 223,
            //    FirstName = "Togrul",
            //    LastName = "Eliyev",
            //};
            //context.Authors.InsertOnSubmit(author);
            //context.SubmitChanges();


            //var result = from a in context.Authors
            //             select a;

            //mydataGrid.ItemsSource = result;


            //var book = context.Books.FirstOrDefault(b => b.Id == 1);
            //book.Name = "I updated";

            //context.SubmitChanges();

            //var result = from b in context.Books
            //             select b;

            //mydataGrid.ItemsSource = result;

            //var book = context.Books.FirstOrDefault(b => b.Id == 1);
            //context.Books.DeleteOnSubmit(book);
            //context.SubmitChanges();

            //var result = from b in context.Books
            //             select b;

            //mydataGrid.ItemsSource = result;

        }
    }
}
