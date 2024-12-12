/*
 * Cam Davies
 * 11/20/2024
 * Tech Support File
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_05
{
    public partial class TechnicalSupportForm : Form
    {
        public TechnicalSupportForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
