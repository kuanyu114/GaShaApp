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

namespace GaShaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static readonly int itemPrice = 50;
        int totalCoins = 0;
        private void button3_Click(object sender, EventArgs e)
        {          
            purchaseItem();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            totalCoins += int.Parse(textBox1.Text);
            checkTotalCoins();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            totalCoins = 0;
            checkTotalCoins();
        }
        /// <summary>
        /// 檢查轉蛋機內幣數
        /// </summary>
        private void checkTotalCoins()
        {
            if (totalCoins == 0)
            {
                textBox2.Text = totalCoins.ToString() + "元";
                MessageBox.Show("已退幣");
                button3.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                if (totalCoins >= itemPrice)
                {
                    button3.Enabled = true;
                }
                textBox2.Text = totalCoins.ToString() + "元";
                button2.Enabled = true;
            }
        }
        /// <summary>
        /// 轉蛋出貨
        /// </summary>
        private void purchaseItem()
        {
            totalCoins -= itemPrice;
            textBox2.Text = totalCoins.ToString() + "元";
            MessageBox.Show("已出貨");
            if (totalCoins < itemPrice)
            {
                button3.Enabled = false;
                if (totalCoins == 0)
                    button2.Enabled = false;
            }
        }
    }
}
