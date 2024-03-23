namespace GaShaApp2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonInsertCoins1 = new GaShaApp2.ButtonInsertCoins(this.components);
            this.buttonDeliverItems1 = new GaShaApp2.ButtonDeliverItems(this.components);
            this.buttonReturnCoins1 = new GaShaApp2.ButtonReturnCoins(this.components);
            this.buttonReturnCoins2 = new GaShaApp2.ButtonReturnCoins(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 60);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 136);
            this.textBox2.TabIndex = 1;
            // 
            // buttonInsertCoins1
            // 
            this.buttonInsertCoins1.Location = new System.Drawing.Point(186, 30);
            this.buttonInsertCoins1.Name = "buttonInsertCoins1";
            this.buttonInsertCoins1.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertCoins1.TabIndex = 2;
            this.buttonInsertCoins1.Text = "投幣";
            this.buttonInsertCoins1.UseVisualStyleBackColor = true;
            // 
            // buttonDeliverItems1
            // 
            this.buttonDeliverItems1.Location = new System.Drawing.Point(186, 202);
            this.buttonDeliverItems1.Name = "buttonDeliverItems1";
            this.buttonDeliverItems1.Size = new System.Drawing.Size(75, 23);
            this.buttonDeliverItems1.TabIndex = 3;
            this.buttonDeliverItems1.Text = "出貨";
            this.buttonDeliverItems1.UseVisualStyleBackColor = true;
            // 
            // buttonReturnCoins1
            // 
            this.buttonReturnCoins1.Location = new System.Drawing.Point(22, 202);
            this.buttonReturnCoins1.Name = "buttonReturnCoins1";
            this.buttonReturnCoins1.Size = new System.Drawing.Size(75, 23);
            this.buttonReturnCoins1.TabIndex = 4;
            this.buttonReturnCoins1.Text = "退幣";
            this.buttonReturnCoins1.UseVisualStyleBackColor = true;
            // 
            // buttonReturnCoins2
            // 
            this.buttonReturnCoins2.Location = new System.Drawing.Point(22, 261);
            this.buttonReturnCoins2.Name = "buttonReturnCoins2";
            this.buttonReturnCoins2.Size = new System.Drawing.Size(75, 23);
            this.buttonReturnCoins2.TabIndex = 5;
            this.buttonReturnCoins2.Text = "退幣";
            this.buttonReturnCoins2.UseVisualStyleBackColor = true;
            this.buttonReturnCoins2.Click += new System.EventHandler(this.buttonReturnCoins2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 364);
            this.Controls.Add(this.buttonReturnCoins2);
            this.Controls.Add(this.buttonReturnCoins1);
            this.Controls.Add(this.buttonDeliverItems1);
            this.Controls.Add(this.buttonInsertCoins1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private ButtonInsertCoins buttonInsertCoins1;
        private ButtonDeliverItems buttonDeliverItems1;
        private ButtonReturnCoins buttonReturnCoins1;
        private ButtonReturnCoins buttonReturnCoins2;
    }
}

