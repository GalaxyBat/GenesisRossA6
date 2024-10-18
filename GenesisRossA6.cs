using System.Globalization;
using GenesisRossA6.Models;
using System.Text;
using System.Text.Json;

namespace GenesisRossA6;

public partial class GenesisRossA6 : Form
{

    private List<Book>? _books;
    public GenesisRossA6()
    {
        InitializeComponent();
        _books = [];
    }

    private void chooseFileBTN_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog();
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            var bookData = File.ReadAllText(openFileDialog.FileName);
            _books = JsonSerializer.Deserialize<List<Book>>(bookData);
            if (_books != null) ShowNumberOfBooks(_books.Count.ToString());
        }
    }

    private void ExportCSVBTN_Click(object sender, EventArgs e)
    {
        if (_books == null || !_books.Any()) return;

        var saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = @"CSV file|*.csv";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            var csv = new StringBuilder();
            csv.AppendLine("Title,Author,Page Length,Genre,Year Published,MSRP");

            foreach (var book in _books)
            {
                var title = CleanData(book.Title);
                var author = CleanData(book.Author);
                var pageLength = book.PageLength.ToString();
                var genre = CleanData(book.Genre);
                var yearPublished = book.YearPublished.ToString();
                var msrp = book.Msrp.ToString(CultureInfo.InvariantCulture);

                csv.AppendLine($"{title},{author},{pageLength},{genre},{yearPublished},{msrp}");
            }

            // Write to the file with UTF-8 encoding
            File.WriteAllText(saveFileDialog.FileName, csv.ToString(), Encoding.UTF8);
        }
    }

    

    private void ExportJSONBTN_Click(object sender, EventArgs e)
    {
        if (_books == null || !_books.Any()) return;

        foreach (var book in _books)
        {
            book.Title = CleanData(book.Title);
            book.Author = CleanData(book.Author);
            book.Genre = CleanData(book.Genre);
           
        }

        var saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = @"JSON file|*.json";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonData = JsonSerializer.Serialize(_books, options);
            File.WriteAllText(saveFileDialog.FileName, jsonData, Encoding.UTF8);
        }
    }
    private string CleanData(string? data)
    {
        if (string.IsNullOrEmpty(data)) return string.Empty;

        // Remove or replace unwanted characters
        // Replace newlines, carriage returns, quotes, tabs, and any other problematic characters
        var cleanData = data
            .Replace("\n", " ")
            .Replace("\r", " ")
            .Replace("\"", "\\\"")
            .Replace("\t", " ")
            .Trim();

        // Use regex to remove any non-printable or control characters
        cleanData = System.Text.RegularExpressions.Regex.Replace(cleanData, @"[^\u0020-\u007E]", string.Empty);

        return cleanData;
    }

    private static void ShowNumberOfBooks(string bookNum)
    {
        const string caption = "The number of books";
        const MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBox.Show(bookNum, caption, buttons );
    }


}