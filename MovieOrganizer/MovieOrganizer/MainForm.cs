using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MovieOrganizer
{
    public partial class MainForm : Form
    {
        public static List<MovieEntry> movieList = new List<MovieEntry>();
        private List<ToolStripMenuItem> toolItems = new List<ToolStripMenuItem>();
        private List<String> tagList = new List<String>();
        private List<String> tagSelected = new List<String>();
        public static List<List<int>> userList = new List<List<int>>(3);
        private ToolStripMenuItem current = null;
        public static LinkLabel currentList = null;
        protected int newMovieIndex;

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            for (int i = 0; i < 3;i++ )
                userList.Add(new List<int>());
            ReadXML();
            if (movieList.Count == 0)
                newMovieIndex = 1;
            else
                newMovieIndex = movieList[movieList.Count - 1].ID + 1;

            toolItems.Add(tlsGenre);
            toolItems.Add(tlsDirector);
            toolItems.Add(tlsActor);
            toolItems.Add(tlsRating);
            toolItems.Add(tlsRecentlyViewed);
            toolItems.Add(tlsTimesWatched);
            toolItems.Add(tlsYear);

            TagPanel.Hide();
            LibraryPanel.Hide();
            LoginPanel.Show();
            MainMenuPanel.Show();
            NavigationPanel.Hide();
            DrawList(MovieListingPanel);
            UpdateTags();
        }

        private void lnkMainLibrary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TagPanel.Hide();
            MainMenuPanel.Hide();
            LibraryPanel.Show();
            NavigationPanel.Show();
        }

        private void lnkMainDataEntry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var form = new AddMovie())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var record = form.movie;
                    record.ID = newMovieIndex++;
                    movieList.Add(record);
                    lnkMainLibrary_LinkClicked(sender, e);
                }
            }
            DrawList(MovieListingPanel);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            WriteXML();
        }

        private void ReadXML()
        {
            var reader = new XmlSerializer(typeof(List<MovieEntry>));
            var tagReader = new XmlSerializer(typeof(List<String>));
            var listReader = new XmlSerializer(typeof(List<List<int>>));
            StreamReader file = null;
            StreamReader tags = null;
            StreamReader lists = null;

            //load entries
            try
            {
                file = new StreamReader("file.xml");
                var list = reader.Deserialize(file);
                movieList = (List<MovieEntry>)list;
            }
            catch (FileNotFoundException)
            {
                //keep going the file hasnt been created yet
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading file\n" + e.Message);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }

            //load tags
            try
            {
                tags = new StreamReader("tags.xml");
                var list = tagReader.Deserialize(tags);
                tagList = (List<String>)list;
            }
            catch (FileNotFoundException)
            {
                //keep going the file hasnt been created yet
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading tags\n" + e.Message);
            }
            finally
            {
                if (tags != null)
                    tags.Close();
            }

            //load lists
            try
            {
                lists = new StreamReader("lists.xml");
                var list = listReader.Deserialize(lists);
                userList = (List<List<int>>)list;
            }
            catch (FileNotFoundException)
            {
                //keep going the file hasnt been created yet
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading lists\n" + e.Message);
            }
            finally
            {
                if (lists != null)
                    lists.Close();
            }
        }

        private void WriteXML()
        {
            var writer = new XmlSerializer(typeof(List<MovieEntry>));
            var tagWriter = new XmlSerializer(typeof(List<String>));
            var listWriter = new XmlSerializer(typeof(List<List<int>>));
            StreamWriter file = null;
            StreamWriter tags = null;
            StreamWriter lists = null;

            //write entries
            try
            {
                file = new StreamWriter("file.xml", false);
                writer.Serialize(file, movieList);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error writing to file\n" + e.Message);
            }
            finally
            {
                if(file !=null)
                    file.Close();
            }

            //write tags
            try
            {
                tags = new StreamWriter("tags.xml", false);
                tagWriter.Serialize(tags, tagList);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error writing to tags\n"+e.Message);
            }
            finally
            {
                if (tags != null)
                    tags.Close();
            }

            //write lists
            try
            {
                lists = new StreamWriter("lists.xml", false);
                listWriter.Serialize(lists, userList);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error writing to lists\n" + e.Message);
            }
            finally
            {
                if (lists != null)
                    lists.Close();
            }
        }

        private void tlStrp_Click(object sender, EventArgs e)
        {
            if (currentList != null)
            {
                currentList.LinkColor = SystemColors.ControlText;
                currentList.BackColor = SystemColors.Control;
                currentList = null;
            }

            ToolStripMenuItem temp = (ToolStripMenuItem)sender;
            if (temp == tlsRating || current == temp)
            {
                if (current != null)
                {
                    current.ForeColor = SystemColors.ControlText;
                    current.BackColor = SystemColors.Control;
                    current = null;
                }
            }
            else if(current == null)
            {
                temp.BackColor = SystemColors.ControlDark;
                temp.ForeColor = SystemColors.ControlLightLight;
                current = temp;
            }
            
            else
            {
                current.BackColor = SystemColors.Control;
                current.ForeColor = SystemColors.ControlText;
                temp.BackColor = SystemColors.ControlDark;
                temp.ForeColor = SystemColors.ControlLightLight;
                current = temp;
            }
        }

        private void lnkMainSuggest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var form = new SuggestModal())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.suggest == Suggest.RatingBased)
                    {
                        List<int> toShow = new List<int>();

                        for (int i = 0; i < 6; i++ )
                        {
                            var rate = Rating.Five-i;
                            foreach (var item in movieList)
                            {
                                if (item.Rate == rate)
                                {
                                    toShow.Add(item.ID);
                                    if (toShow.Count == 5)
                                        break;
                                }
                            }
                            if (toShow.Count == 5)
                                break;
                        }

                        DrawList(MovieListingPanel, toShow);
                    }
                    else
                        MessageBox.Show("You have not watched any movies recently");
                    lnkMainLibrary_LinkClicked(sender, e);
                }
            }
        }

        public static void DrawList(Panel pan)
        {
            DrawList(pan, null);            
        }

        public static void DrawList(Panel pan, List<int> toShow)
        {
            int pos = 3;
            pan.Controls.Clear();
            if(toShow == null)
            {
                toShow = new List<int>();
                foreach(var item in movieList)
                    toShow.Add(item.ID);
            }
            
            foreach (var item in toShow)
            {
                MovieEntryPanel entry = new MovieOrganizer.MovieEntryPanel();
                entry.Location = new System.Drawing.Point(1, pos);
                entry.Name = "" + item;
                entry.Size = new System.Drawing.Size(465, 105);
                entry.TabIndex = 12;
                entry.setMovie(item);
                if (currentList != null)
                    entry.SetRemove(true);
                pan.Controls.Add(entry);
                pos += 105;
            }
        }

        private void lnkLibrary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!LibraryPanel.Visible)
            {
                TagPanel.Hide();
                LibraryPanel.Show();
            }
        }

        private void lnkTaggedSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!TagPanel.Visible)
            {
                LibraryPanel.Hide();
                TagPanel.Show();
            }
        }

        private void lnkMainTaggedSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainMenuPanel.Hide();
            NavigationPanel.Show();
            lnkTaggedSearch_LinkClicked(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String txtInput = ((TextBox)sender).Text;
            if (txtInput.Length == 0)
            {
                DrawList(MovieListingPanel);
                return;
            }

            List<int> toShow = new List<int>();
            if (current == null)
            {
                foreach (var item in movieList)
                {
                    if (StringMatch.match(item.Title, txtInput))
                        toShow.Add(item.ID);
                }
            }
            else if (current == tlsGenre)
            {
                foreach (var item in movieList)
                {
                    if (StringMatch.match(item.Genre, txtInput))
                        toShow.Add(item.ID);
                }
            }
            else if (current == tlsActor)
            {
                foreach (var item in movieList)
                {
                    if (StringMatch.match(item.Actors, txtInput))
                        toShow.Add(item.ID);
                }
            }
            else if (current == tlsDirector)
            {
                foreach (var item in movieList)
                {
                    if (StringMatch.match(item.Director, txtInput))
                        toShow.Add(item.ID);
                }
            }
            else if (current == tlsYear)
            {
                foreach (var item in movieList)
                {
                    if (StringMatch.match((""+item.Year), txtInput))
                        toShow.Add(item.ID);
                }
            }
            else
                MessageBox.Show("Unable to Search");

            DrawList(MovieListingPanel,toShow);
        }

        private void tl5Stars_Click(object sender, EventArgs e)
        {
            StarSearch(Rating.Five);
        }

        private void tl4Stars_Click(object sender, EventArgs e)
        {
            StarSearch(Rating.Four);
        }

        private void tl3Stars_Click(object sender, EventArgs e)
        {
            StarSearch(Rating.Three);
        }

        private void tl2Stars_Click(object sender, EventArgs e)
        {
            StarSearch(Rating.Two);
        }

        private void tl1Stars_Click(object sender, EventArgs e)
        {
            StarSearch(Rating.One);
        }

        private void tl0Stars_Click(object sender, EventArgs e)
        {
            StarSearch(Rating.Zero);
        }

        private void tlAllStars_Click(object sender, EventArgs e)
        {
            DrawList(MovieListingPanel);
        }

        private void StarSearch(Rating looking)
        {
            List<int> toShow = new List<int>();
            foreach (var item in movieList)
            {
                if (item.Rate == looking)
                    toShow.Add(item.ID);
            }
            DrawList(MovieListingPanel, toShow);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstTagsAvailable.SelectedItems.Count >0)
            {
                String temp = lstTagsAvailable.SelectedItem.ToString();
                tagList.Remove(temp);
                tagSelected.Remove(temp);
                UpdateTags();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using(var form = new AddTag())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK && form.newTag !="" && !tagList.Contains(form.newTag.ToUpper()))
                {
                    tagList.Add(form.newTag.ToUpper());
                    UpdateTags();
                }
            }
        }

        public void UpdateTags()
        {
            lstTagsAvailable.Items.Clear();
            lstTagsAvailable.Items.AddRange(tagList.ToArray());

            lstToSearch.Items.Clear();
            lstToSearch.Items.AddRange(tagSelected.ToArray());
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            if(lstTagsAvailable.SelectedItems.Count >0)
            {
                String temp = lstTagsAvailable.SelectedItem.ToString();
                if(!tagSelected.Contains(temp))
                {
                    tagSelected.Add(temp);
                    UpdateTags();
                }
            }
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            if (lstToSearch.SelectedItems.Count > 0)
            {
                tagSelected.Remove(lstToSearch.SelectedItem.ToString());
                UpdateTags();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tagSelected.Count == 0)
            {
                DrawList(MovieListingPanel);
            }
            else
            {
                List<int> toShow = new List<int>();
                foreach (var str in tagSelected)
                {
                    foreach (var item in movieList)
                    {
                        if (StringMatch.match(item.Tags, str) && !toShow.Contains(item.ID))
                            toShow.Add(item.ID);
                    }
                }
                DrawList(MovieListingPanel, toShow);
            }
            TagPanel.Hide();
            LibraryPanel.Show();
        }

        private void lnkWatchNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListLink_Clicked(sender, 0);
        }

        private void lnkGive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListLink_Clicked(sender, 1);
        }

        private void lnkWishlist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListLink_Clicked(sender, 2);
        }

        private void ListLink_Clicked(object sender, int list)
        {
            var temp = (LinkLabel)sender;
            tlStrp_Click(current, new EventArgs());
            currentList = temp;
            temp.LinkColor = SystemColors.ControlLightLight;
            temp.BackColor = SystemColors.ControlDark; 
            DrawList(MovieListingPanel, userList[list]);
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.AutoPopDelay = 5000;
            tip.InitialDelay = 1200;
            tip.ReshowDelay = 500;

            tip.ShowAlways = true;

            tip.SetToolTip(txtSearch, "Enter the words you want to search for here. You can filter by the criterion on the left.");
            tip.SetToolTip(lnkAddMovie, "Add a movie to your library");
            tip.SetToolTip(lnkLibrary, "Go and view your movie library");
            tip.SetToolTip(lnkSuggest, "Get a suggestion for a movie to watch");
            tip.SetToolTip(lnkTaggedSearch, "Perform an advanced search here");
            tip.SetToolTip(lnkMainDataEntry, "Add a movie to your library");
            tip.SetToolTip(lnkMainLibrary, "Go and view your movie library");
            tip.SetToolTip(lnkMainSuggest, "Get a suggestion for a movie to watch");
            tip.SetToolTip(lnkMainTaggedSearch, "Perform an advanced search here");
            tip.SetToolTip(lstTagsAvailable, "These are the available tags to filter search by");
            tip.SetToolTip(lstToSearch, "These are the tags you have selected to search by");
        }
    }
}
