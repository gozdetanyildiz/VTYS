using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtys
{
    public partial class musteritemForm : Form
    {
        public musteritemForm()
        {
            InitializeComponent();
        }
        mustericagrilistesiForm mtfrm = new mustericagrilistesiForm ();
        aylikprimlisteForm aylikprimlisteForm = new aylikprimlisteForm ();
        itirazlarimForm itirazlarim = new itirazlarimForm ();   
        
        private void btnmustericagriliste_Click(object sender, EventArgs e)
        {
            mtfrm.Show();
           
        }

        private void btnaylikprimliste_Click(object sender, EventArgs e)
        {
            aylikprimlisteForm.Show();
        }

        private void btnitirazlarim_Click(object sender, EventArgs e)
        {
            itirazlarim.Show();
        }
    }
}
