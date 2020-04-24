using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuimicaOrganica
{
    public partial class frm_Lista : Form
    {
        Thread Principal;
        public frm_Lista()
        {
            InitializeComponent();
        }

        private void frm_Lista_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal = new Thread(LoadPrin);
            Principal.SetApartmentState(ApartmentState.STA);
            Principal.Start();
        }

        private void LoadPrin()
        {
            Application.Run(new frmHidrocarbonetos());
        }
    }
}
