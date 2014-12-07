using System.Windows.Forms;

namespace MovieOrganizer
{
    public enum Suggest { RatingBased, RecentBased};
    public partial class Suggest_Modal : Form
    {
        public Suggest suggest;
        public Suggest_Modal()
        {
            InitializeComponent();
            CenterToScreen();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void btn_Rating_Click(object sender, System.EventArgs e)
        {
            suggest = Suggest.RatingBased;
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btn_Recent_Click(object sender, System.EventArgs e)
        {
            suggest = Suggest.RecentBased;
            DialogResult = DialogResult.OK;
            Dispose();
        }
    }
}
