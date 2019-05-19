using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class myLibrary : Form
    {

        private readonly MyLibraryEntities library = new MyLibraryEntities();
        public myLibrary()
        {
           
            InitializeComponent();
            
            using (var db = new MyLibraryEntities())
            {
                var query = from b in db.Clients orderby b.Name orderby b.Surname orderby b.Email orderby b.Phone select b;
                 Models.Client client = new Models.Client();
                foreach (var item in query)
                {

                    client.Name = item.Name;
                    client.Surname = item.Surname;
                    client.Email = item.Email;
                    client.Phone = item.Phone;
                    client.Status = item.Status;

                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = item.Name;
                    row.Cells[1].Value = item.Surname;
                    row.Cells[2].Value = item.Email;
                    row.Cells[3].Value = item.Phone;
                    row.Cells[4].Value = item.Status;
                    dataGridView1.Rows.Add(row);
                }

            


            }
            using (var db = new MyLibraryEntities())
            {

                var myquery = from a in db.Books orderby a.Name  orderby a.Price select a;
                Book book = new Book();
                foreach (var item2 in myquery)
                {

                    book.Name = item2.Name;
                  
                    book.Price = item2.Price;


                    DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                    row.Cells[0].Value = item2.Name;
                  
                    row.Cells[2].Value = item2.Price;

                    dataGridView1.Rows.Add(row);
                }


            }


        }


        private void ClientBtn_Click(object sender, EventArgs e)
        {

         

                using (var db = new MyLibraryEntities())
            {
                

                string clientSearch = txtClientSearch.Text.ToLower();
                List<Models.Client> client = db.Clients.Where(c => c.Name.ToLower().Contains(clientSearch)).ToList();
                dataGridView1.Rows.Clear();
                foreach (var item in client)
                {
                    dataGridView1.Rows.Add(item.Id, item.Name, item.Surname, item.Email, item.Phone,item.Status);
                }


            }
        }

        private void XcxccToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MyLibraryEntities())
            {


                string bookSearch = txtBookSearch.Text.ToLower();
                List<Models.Book> books = db.Books.Where(c => c.Name.ToLower().Contains(bookSearch)).ToList();
                dataGridView2.Rows.Clear();
                foreach (var item in books)
                {
                    dataGridView2.Rows.Add( item.Name, item.AuthorsBooks, item.Price);
                }


            }
        }
    }
}
