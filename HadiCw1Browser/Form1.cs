using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HadiCw1Browser
{
    public partial class Form1 : Form
    {

        public static string mainhome = "https://www.hw.ac.uk/";
        public static string url = mainhome;
        public static string title;
       

        //the home page, history and favorites are loaded by default on the 
        //start of the application
        public Form1()
        {
            InitializeComponent();
            GetHistory();
            url = mainhome;
            PageLoad(mainhome);
            GetFav();
        }
        public static Stack Previous = new Stack();
        public static Stack nextfor = new Stack();

        private void Form1_Load(object sender, System.EventArgs e)
        {
           
        }
        public static IDictionary<string, string> his = new Dictionary<string, string>();
        public static Dictionary<string, string> fav = new Dictionary<string, string>();

        //this method is responsible loading page and displaying html req for which the method calls
        //the displayhtmlreq method
        public void PageLoad(string url)
        {
            try
            {
                new Uri(url);
                DisplayHTMLRequest(url);
            }
            catch
            {
                textBoxHtml.Text= "please enter valid url";
            }
        }
        
        // Favorites are loaded from text file. loop is iterated through the file's lenght and displays 
        //the content
        public void GetFav()
        {
            try
            {
                var file = File.ReadAllLines("C:\\favourites.txt");
                for (var i = 0; i < file.Length; i++)
                {
                    fav.Add(file[i], file[i]);
                }
            }
            catch 
            {
                textBoxHtml.Text = "No favorites to load";
            }

        }

        // The method is responsible for loading the history. It reads the history from a text file stored in
        // local directory C. If the directory does'nt exist it shows a message box saying nothing to load
        public void GetHistory()
        {
            try
            {
                var file = File.ReadAllLines("C:\\history.txt");
                for (var i = 0; i < file.Length; i++)
                {
                    his.Add(file[i], file[i]);
                }
            }
            catch (InvalidOperationException)
            {
                textBoxHtml.Text = "No history to load";
            }
        }
        //Displays html request of the given url uses regex pattern matching to find the title 
        public void DisplayHTMLRequest(string url)
        {
            string textHtml = string.Empty;

            HttpWebRequest HTMLReq = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                HttpWebResponse HTMLRes = (HttpWebResponse)HTMLReq.GetResponse();
                Stream st = HTMLRes.GetResponseStream();
                StreamReader readT = new StreamReader(st);
                {
                    textHtml = readT.ReadToEnd();
                }
                title = Regex.Match(textHtml, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>",
                    RegexOptions.IgnoreCase).Groups["Title"].Value;
                Text = title;
                statusbox.Text = HTMLRes.StatusCode.ToString();
                textBoxHtml.Text = textHtml.ToString();
                if (!his.ContainsKey(title))
                    his.Add(title, url);
            }
            catch (WebException h)
            {
                textBoxHtml.Text = String.Empty;
                statusbox.Text = h.Message;
            }
        }
        // The user is redirected to the original page when this function triggers
        public void next()
        {
            string tempp = nextfor.Pop().ToString();
            Previous.Push(tempp);
            if (nextfor.Count == 0)
                FORWARDButton.Enabled = false;
            FORWARDButton.Enabled = true;
            DisplayHTMLRequest(tempp);
        }

        //The user is redirected to the previous page when this function triggers
        public void previous()
        {
            string temp = Previous.Pop().ToString();
            if (Previous.Count == 0)
                BACKWARDButton.Enabled = false;
            nextfor.Push(temp);
            FORWARDButton.Enabled = true;
            DisplayHTMLRequest(temp);
        }

        // The back button on being clicked calls the previous method which implements the functionality 
        //of taking user to previous page.
        private void BACKWARDButton_Click(object sender, EventArgs e)
        {
            previous();
        }

        // This button on being clicked calls the homepage method which is responsible for taking
        //the user to the homepage of the application which is set to heriot watt uni home page by default.
        private void HomeButton_Click(object sender, EventArgs e)
        {
            PageLoad(mainhome);

        }
        // this button on being clicked calls the next method which takes the user back
        //to the original page.
        private void FORWARDButton_Click(object sender, EventArgs e)
        {
            next();
        }
        // this button on being clicked calls the searchpage method which displays the html 
        //for the desired url
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchPage();
        }
        // this method is responsible for going to the specified url and displaying the http request
        public void SearchPage()
        {
            PrevAdd();
            nextfor.Clear();
            FORWARDButton.Enabled = false;
            url = textBoxSearch.Text;
            PageLoad(url);
        }
        //this method pushes the url in the stack so it can be recalled in case
        //user wa nts to go to the previous or next page.
        public void PrevAdd()
        {
            Previous.Push(url);
            BACKWARDButton.Enabled = true;
        }
        //this button on being clicked calls the refresh method which then reloads the page 
        // for the user
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ReloadPage();
        }
        //this method is responsible for refreshing the current page
        public void ReloadPage()
        {
            textBoxHtml.Text = string.Empty;
            PageLoad(url);
        }

        // this button on being clicked calls the showallhistory method which then displays the history
        //for the user
        private void SearchHistoryButton_Click(object sender, EventArgs e)
        {
            ShowAllHistory();
        }

        //this method is responsible for displaying the history of the browser to the user
        public void ShowAllHistory()
        {
            favHisTextbox.Visible = true;
            favHisTextbox.Refresh();
            favHisTextbox.DataSource = new BindingSource(his, null);
            favHisTextbox.DisplayMember = "key";
            favHisTextbox.ValueMember = "value";
          
        }
       
        // this button calls a function which is responsible for adding the title and url to the list of favorites
        private void FavButton_Click(object sender, EventArgs e)
        {
            
            fav.Add(title, url); 
        }

        //This method is responsible for removing a url/title from favorites list
        public void RemoveFromFav(string f)
        {
            var remove = fav.First(rem => rem.Value == f);
            fav.Remove(remove.Key);
            favHisTextbox.Visible = false;
        }
        //this method is responsible for displaying the entire favorites list 
        //when this method is called it intially enables the textbox visibility to true
        //if there are no fav to load then a message is shared which says nothing to load
        public void ShowAllFav()
        {
         
            favHisTextbox.Visible = true;
            favHisTextbox.Refresh();
            if (fav.Count == 0)
            {
                statusbox.Text = "Nothing to load";
                return;
            }
            favHisTextbox.DataSource = new BindingSource(fav, null);
            favHisTextbox.DisplayMember = "key";
            favHisTextbox.ValueMember = "value";
        }
      
   
        // when this button is clicked it calls the method which is responsible for displaying the list 
        //of favorites
        private void ShowFavButton_Click(object sender, EventArgs e)
        {
            ShowAllFav();
        }

        // when this button is clicked it calls the method which is responsible for removing favorite url
        //from the list of favorites
        private void RemoveFavButton_Click_1(object sender, EventArgs e)
        {
           // contextMenuStrip1.Items.Clear();
            RemoveFromFav(favHisTextbox.GetItemText(favHisTextbox.SelectedValue));

        }

        // when this button is cllcked it changes the home page url to current url
        //resulting in updating the homepage url
        private void SetAsHomeButton_Click(object sender, EventArgs e)
        {
            mainhome = url;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private string BulkDownloadRow(string url)
        {
            string res = string.Empty;
            string rawdata = string.Empty;
            System.Net.ServicePointManager.Expect100Continue = true;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                HttpWebResponse ResP = (HttpWebResponse)request.GetResponse();
                Stream stream = ResP.GetResponseStream();
                StreamReader Read = new StreamReader(stream);
                {
                    rawdata = Read.ReadToEnd();
                }
                byte[] b = Encoding.ASCII.GetBytes(rawdata);
                int bytes = b.Length;
                res = "Status : " + (int)ResP.StatusCode + "  Bytes : " + bytes.ToString() + " URL : " + url + "  \n";
            }
            catch (WebException h)
            {
                res = h.Message;
            }
            return res;
        }

        private void bulkDownload_Click(object sender, EventArgs e)
        {
            var bulkArray = File.ReadAllLines("C:\\bulkDownload.txt");
            string bulkd = string.Empty;
            //   siteContent.Clear();
            textBoxHtml.Clear();
            for (int j = 0; j < bulkArray.Length; j++)
            {
                textBoxHtml.AppendText(BulkDownloadRow(bulkArray[j]));
                textBoxHtml.AppendText(Environment.NewLine);
            }
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
