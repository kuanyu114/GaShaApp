using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaShaApp2
{
    public partial class ButtonReturnCoins : Button, IReturnCoins
    {
        public ButtonReturnCoins()
        {
            InitializeComponent();
        }

        public ButtonReturnCoins(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
