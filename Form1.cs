using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;

namespace lab3_2
{
    public partial class Form1 : Form
    {
        private static readonly int MIN_LENGTH = 5;
        private static readonly string BINARY_FILTER = "Binary files (*.dat)|*.dat|All files (*.*)|*.*";
        private static readonly string SOAP_FILTER = "Soap files (*.soap)|*.soap|All files (*.*)|*.*";
        private HomeLibrary _homeLibrary;
        private IFormatter _formatter;

        public Form1()
        {
            InitializeComponent();
            InitializeTable();
            _homeLibrary = new HomeLibrary();
            _formatter = new BinaryFormatter();
        }

        private void ResetControls()
        {
            ButtonPanel.Hide<Panel>();
            DataPanel.Hide<Control>();
            this.ClearTextBoxes();
        }

        private void InitializeTable() => typeof(Book).GetProperties().Select(p => p.Name).ToList().ForEach(p => dataGridView1.Columns.Add(p, p));

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            ResetControls();
            AddPanel.Show();
            DescriptionTextBox.Show();
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            ResetControls();
            DeletePanel.Show();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            BookComboBox.Items.Clear();
            BookComboBox.Items.AddRange(_homeLibrary.Books.Select(b => b.Name).ToArray());
        }

        private void ViewButton_Click(object sender, System.EventArgs e)
        {
            ResetControls();
            dataGridView1.Show();
            UpdateTable(_homeLibrary.Books);
        }

        private void UpdateTable(List<Book> books)
        {
            dataGridView1.Rows.Clear();
            books.ForEach(b => dataGridView1.Rows.Add(b.ToObjectArray()));
        }

        private void EditButton_Click(object sender, System.EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = _formatter is BinaryFormatter ? BINARY_FILTER : SOAP_FILTER
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                ErrorBox.Show("Не выбран файл для открытия");
                return;
            }

            _homeLibrary = HomeLibrary.FromFile(openFileDialog.FileName, _formatter);
            ViewButton_Click(sender, e);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog()
            {
                Filter = _formatter is BinaryFormatter ? BINARY_FILTER : SOAP_FILTER
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                ErrorBox.Show("Не выбран файл для сохранения");
                return;
            }

            _homeLibrary.Save(saveFileDialog.FileName, _formatter);
        }

        private void AddBookButton_Click(object sender, System.EventArgs e)
        {
            if (!TryParseAddData(out var book))
            {
                ErrorBox.Show($"Минимальная длина имени, автора или описания должна быть не менее {MIN_LENGTH} символов");
                return;
            }

            _homeLibrary.Add(book);
            ResetControls();
        }

        private bool TryParseAddData(out Book book)
        {
            var name = NameTextBox.Text.Trim();
            var author = AuthorTextBox.Text.Trim();
            var description = DescriptionTextBox.Text.Trim();
            book = new Book(name, author, description);
            return name.Length >= MIN_LENGTH && author.Length >= MIN_LENGTH && description.Length >= MIN_LENGTH;
        }

        private void бинарныйToolStripMenuItem_Click(object sender, System.EventArgs e) => _formatter = new BinaryFormatter();

        private void soapToolStripMenuItem_Click(object sender, System.EventArgs e) => _formatter = new SoapFormatter();

        private void RemoveBookButton_Click(object sender, System.EventArgs e)
        {
            if (!TryGetBook(out var book))
            {
                ErrorBox.Show("Не выбрана книга");
                return;
            }

            _homeLibrary.Remove(book);
            ResetControls();
        }

        private bool TryGetBook(out Book book)
        {
            if (BookComboBox.SelectedIndex == -1)
            {
                book = default;
                return false;
            }

            book = _homeLibrary.Books.First(b => b.Name == BookComboBox.SelectedItem.ToString());
            return true;
        }

        private void SearchBookTextBox_TextChanged(object sender, System.EventArgs e)
        {
            var text = SearchBookTextBox.Text.Trim();
            var books = _homeLibrary.Books
                .Where(b => b.Guid.ToString().Contains(text) ||
                            b.Name.Contains(text) || 
                            b.Author.Contains(text) ||
                            b.Description.Contains(text))
                .ToList();
            UpdateTable(books);
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            ResetControls();
            dataGridView1.Show();
            SearchPanel.Show();
        }
    }
}
