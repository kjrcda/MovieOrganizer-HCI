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
        private List<List<MovieEntry>> userList = new List<List<MovieEntry>>(3);
        private ToolStripMenuItem current = null;
        protected int newMovieIndex;

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            ReadXML();
            if (movieList.Count == 0)
                newMovieIndex = 1;
            else
                newMovieIndex = movieList[movieList.Count - 1].ID + 1;

            toolItems.Add(tlStrp_Genre);
            toolItems.Add(tlStrp_Director);
            toolItems.Add(tlStrp_Actor);
            toolItems.Add(tlStrp_Rating);
            toolItems.Add(tlStrp_RecentlyViewed);
            toolItems.Add(tlStrp_TimesWatched);
            toolItems.Add(tlStrp_Year);

            TagPanel.Hide();
            LibraryPanel.Hide();
            LoginPanel.Show();
            MainMenuPanel.Show();
            NavigationPanel.Hide();
            DrawList(panel_MovieListing);
            UpdateTags();
        }

        private void link_pMain_pLibrary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TagPanel.Hide();
            MainMenuPanel.Hide();
            LibraryPanel.Show();
            NavigationPanel.Show();
        }

        private void link_pMain_pDataEntry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var form = new AddMovie())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var record = form.movie;
                    record.ID = newMovieIndex++;
                    movieList.Add(record);
                    link_pMain_pLibrary_LinkClicked(sender, e);
                }
            }
            DrawList(panel_MovieListing);
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
            var listReader = new XmlSerializer(typeof(List<List<MovieEntry>>));
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
            catch (FileNotFoundException fnfe)
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
            catch (FileNotFoundException fnfe)
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
                userList = (List<List<MovieEntry>>)list;
            }
            catch (FileNotFoundException fnfe)
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
            var listWriter = new XmlSerializer(typeof(List<List<MovieEntry>>));
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
            ToolStripMenuItem temp = (ToolStripMenuItem)sender;
            if (temp == tlStrp_Rating || current == temp)
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

        private void link_pMain_frmSuggest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var form = new Suggest_Modal())
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

                        DrawList(panel_MovieListing, toShow);
                    }
                    else
                        MessageBox.Show("You have not watched any movies recently");
                    link_pMain_pLibrary_LinkClicked(sender, e);
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
                pan.Controls.Add(entry);
                pos += 105;
            }
        }

        private void lnk_AddMovie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link_pMain_pDataEntry_LinkClicked(sender, e);
        }

        private void lnk_Suggest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link_pMain_frmSuggest_LinkClicked(sender, e);
        }

        private void lnk_Library_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!LibraryPanel.Visible)
            {
                TagPanel.Hide();
                LibraryPanel.Show();
            }
        }

        private void lnk_TagSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!TagPanel.Visible)
            {
                LibraryPanel.Hide();
                TagPanel.Show();
            }
        }

        private void link_pMain_pTaggedSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainMenuPanel.Hide();
            NavigationPanel.Show();
            lnk_TagSearch_LinkClicked(sender, e);
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            String txtInput = ((TextBox)sender).Text;
            if (txtInput.Length == 0)
            {
                DrawList(panel_MovieListing);
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
            else if (current == tlStrp_Genre)
            {
                foreach (var item in movieList)
                {
                    if (StringMatch.match(item.Genre, txtInput))
                        toShow.Add(item.ID);
                }
            }
            else if (current == tlStrp_Actor)
            {
                foreach (var item in movieList)
                {
                    if (StringMatch.match(item.Actors, txtInput))
                        toShow.Add(item.ID);
                }
            }
            else if (current == tlStrp_Director)
            {
                foreach (var item in movieList)
                {
                    if (StringMatch.match(item.Director, txtInput))
                        toShow.Add(item.ID);
                }
            }
            else if (current == tlStrp_Year)
            {
                foreach (var item in movieList)
                {
                    if (StringMatch.match((""+item.Year), txtInput))
                        toShow.Add(item.ID);
                }
            }
            else
                MessageBox.Show("Unable to Search");

            DrawList(panel_MovieListing,toShow);
        }

        private void tool_5Stars_Click(object sender, EventArgs e)
        {
            StarSearch(Rating.Five);
        }

        private void tool_4Stars_Click(object sender, EventArgs e)
        {
            StarSearch(Rating.Four);
        }

        private void tool_3Stars_Click(object sender, EventArgs e)
        {
            StarSearch(Rating.Three);
        }

        private void tool_2Stars_Click(object sender, EventArgs e)
        {
            StarSearch(Rating.Two);
        }

        private void tool_1Stars_Click(object sender, EventArgs e)
        {
            StarSearch(Rating.One);
        }

        private void tool_0Stars_Click(object sender, EventArgs e)
        {
            StarSearch(Rating.Zero);
        }

        private void tool_AllStars_Click(object sender, EventArgs e)
        {
            DrawList(panel_MovieListing);
        }

        private void StarSearch(Rating looking)
        {
            List<int> toShow = new List<int>();
            foreach (var item in movieList)
            {
                if (item.Rate == looking)
                    toShow.Add(item.ID);
            }
            DrawList(panel_MovieListing, toShow);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(list_availableTags.SelectedItems.Count >0)
            {
                String temp = list_availableTags.SelectedItem.ToString();
                tagList.Remove(temp);
                tagSelected.Remove(temp);
                UpdateTags();
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
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
            list_availableTags.Items.Clear();
            list_availableTags.Items.AddRange(tagList.ToArray());

            list_ToSearch.Items.Clear();
            list_ToSearch.Items.AddRange(tagSelected.ToArray());
        }

        private void btn_Add_Tag_Click(object sender, EventArgs e)
        {
            if(list_availableTags.SelectedItems.Count >0)
            {
                String temp = list_availableTags.SelectedItem.ToString();
                if(!tagSelected.Contains(temp))
                {
                    tagSelected.Add(temp);
                    UpdateTags();
                }
            }
        }

        private void btn_Remove_Tag_Click(object sender, EventArgs e)
        {
            if (list_ToSearch.SelectedItems.Count > 0)
            {
                tagSelected.Remove(list_ToSearch.SelectedItem.ToString());
                UpdateTags();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tagSelected.Count == 0)
            {
                DrawList(panel_MovieListing);
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
                DrawList(panel_MovieListing, toShow);
            }
            TagPanel.Hide();
            LibraryPanel.Show();
        }

        private void lnk_WatchNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
