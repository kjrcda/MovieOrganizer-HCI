using System.Windows.Forms;

namespace MovieOrganizer
{
    public enum Suggest { RatingBased, RecentBased};
    public partial class SuggestModal : Form
    {
        public Suggest suggest;
        public SuggestModal()
        {
            InitializeComponent();
            CenterToScreen();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void btnRating_Click(object sender, System.EventArgs e)
        {
            suggest = Suggest.RatingBased;
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btnRecent_Click(object sender, System.EventArgs e)
        {
            suggest = Suggest.RecentBased;
            DialogResult = DialogResult.OK;
            Dispose();
        }
    }
}
