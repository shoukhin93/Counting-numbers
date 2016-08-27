using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Counting_numbers
{
    public partial class horror : Form
    {
        public horror()
        {
            InitializeComponent();
        }

        
            
        private void horror_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.unnamed__1_;

            SoundPlayer sp = new SoundPlayer(Properties.Resources.horror);

            sp.Play();
        }
        
    }
}
