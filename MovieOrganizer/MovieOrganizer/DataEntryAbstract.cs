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
            
            Text = name;
            if (name == "Add Movie")
                btn_pDataEntry_modalConfirmation_DeleteMovie.Visible = false;
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


        private void DataEntryAbstract_Load(object sender, EventArgs e)
        {
            btn_pDataEntry_pLibrary_Save.Select();
        }

    }
}
