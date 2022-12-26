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
    public partial class ButtonInsertCoins : Button, IInsertCoins
    {
        public event Action<object, EventArgs> InsertedCoins;
        public ButtonInsertCoins()
        {
            InitializeComponent();
        }

        public ButtonInsertCoins(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(InsertedCoins!=null)InsertedCoins(this, EventArgs.Empty);
        }
    }
}
