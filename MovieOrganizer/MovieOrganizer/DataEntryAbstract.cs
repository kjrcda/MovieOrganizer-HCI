using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieOrganizer
{
    public partial class DataEntryAbstract : Form
    {
        private const uint EM_SETCUEBANNER = 0x1500 + 1;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public DataEntryAbstract(String name)
        {
            InitializeComponent();
            SendMessage(txt_MovieTitle.Handle, EM_SETCUEBANNER, 0, "Movie Title");
            SendMessage(txt_Year.Handle, EM_SETCUEBANNER, 0, "Year");
            SendMessage(txt_Director.Handle, EM_SETCUEBANNER, 0, "Director");
            SendMessage(txt_Actors.Handle, EM_SETCUEBANNER, 0, "Actors");
            SendMessage(txt_Genre.Handle, EM_SETCUEBANNER, 0, "Genre");
            SendMessage(txt_Description.Handle, EM_SETCUEBANNER, 0, "Description");
            SendMessage(txt_Tags.Handle, EM_SETCUEBANNER, 0, "Tags");
            btn_pDataEntry_pLibrary_Save.Focus();
            Text = name;
        }

        private void btn_pDataEntry_pLibrary_Save_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btn_pDataEntry_pLibrary_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

    }
}
