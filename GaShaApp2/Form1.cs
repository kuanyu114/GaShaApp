using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaShaApp2
{
    
    public partial class Form1 : Form
    {
        public static int totalCoins = 0;
        Mediator mediator;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mediator = new Mediator(this.buttonInsertCoins1, this.buttonReturnCoins1, this.buttonDeliverItems1);
        }
    }
    /// <summary>
    /// 協調者
    /// </summary>
    public class Mediator
    {
        private readonly IInsertCoins _insertCoins;
        private readonly IReturnCoins _returnCoins;
        private readonly IDeliverItems _deliverItems;
        private Button buttonInsertCoins, buttonReturnCoins, buttonDeliverItems;
        public Mediator(IInsertCoins insertCoins, IReturnCoins returnCoins, IDeliverItems deliverItems)
        {
            _insertCoins = insertCoins;
            _returnCoins = returnCoins;
            _deliverItems = deliverItems;

            _insertCoins.InsertedCoins += _insertCoins_InsertedCoins;

            this.buttonInsertCoins = (Button)insertCoins;
            this.buttonReturnCoins = (Button)returnCoins;
            this.buttonDeliverItems = (Button)deliverItems;
            DefultStatus();
            
        }

        private void _insertCoins_InsertedCoins(object arg1, EventArgs arg2)
        {
            CanReturnStatus();
        }

        private void DefultStatus()
        {
            buttonReturnCoins.Enabled = buttonDeliverItems.Enabled = false;
        }
        private void CanReturnStatus()
        {
            buttonReturnCoins.Enabled = true;
        }
        private void CanDeliverStatus()
        {
            buttonDeliverItems.Enabled = true;
        }
    }
}
