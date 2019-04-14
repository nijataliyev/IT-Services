namespace IT_Services
{
    partial class GenerateCarts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_addCart = new System.Windows.Forms.Button();
            this.txbx_cartNumber = new System.Windows.Forms.TextBox();
            this.txbx_cartPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(300, 62);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addCart
            // 
            this.btn_addCart.Location = new System.Drawing.Point(171, 104);
            this.btn_addCart.Name = "btn_addCart";
            this.btn_addCart.Size = new System.Drawing.Size(75, 23);
            this.btn_addCart.TabIndex = 1;
            this.btn_addCart.Text = "Add Cart";
            this.btn_addCart.UseVisualStyleBackColor = true;
            this.btn_addCart.Click += new System.EventHandler(this.btn_addCart_Click);
            // 
            // txbx_cartNumber
            // 
            this.txbx_cartNumber.Location = new System.Drawing.Point(88, 64);
            this.txbx_cartNumber.Name = "txbx_cartNumber";
            this.txbx_cartNumber.Size = new System.Drawing.Size(158, 20);
            this.txbx_cartNumber.TabIndex = 2;
            // 
            // txbx_cartPrice
            // 
            this.txbx_cartPrice.Location = new System.Drawing.Point(88, 104);
            this.txbx_cartPrice.Name = "txbx_cartPrice";
            this.txbx_cartPrice.Size = new System.Drawing.Size(38, 20);
            this.txbx_cartPrice.TabIndex = 3;
            // 
            // Register_LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 436);
            this.Controls.Add(this.txbx_cartPrice);
            this.Controls.Add(this.txbx_cartNumber);
            this.Controls.Add(this.btn_addCart);
            this.Controls.Add(this.btn_generate);
            this.Name = "Register_LoginForm";
            this.Text = "Register_LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_addCart;
        private System.Windows.Forms.TextBox txbx_cartNumber;
        private System.Windows.Forms.TextBox txbx_cartPrice;
    }
}