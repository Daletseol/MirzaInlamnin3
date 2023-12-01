namespace Inlämning3
{
    partial class FormClient
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
            label1 = new Label();
            textBoxPin = new TextBox();
            label2 = new Label();
            listView1 = new ListView();
            buttonPin = new Button();
            buttonMoney = new Button();
            buttonInsert = new Button();
            buttonWithdraw = new Button();
            textBoxAmount = new TextBox();
            label3 = new Label();
            textBoxInfo = new TextBox();
            label4 = new Label();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(268, 25);
            label1.TabIndex = 1;
            label1.Text = "Select customer that inserts card";
            // 
            // textBoxPin
            // 
            textBoxPin.Location = new Point(505, 40);
            textBoxPin.Name = "textBoxPin";
            textBoxPin.PasswordChar = '*';
            textBoxPin.Size = new Size(100, 31);
            textBoxPin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 40);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 3;
            label2.Text = "Enter Pin";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 40);
            listView1.Name = "listView1";
            listView1.Size = new Size(385, 483);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // buttonPin
            // 
            buttonPin.Location = new Point(611, 40);
            buttonPin.Name = "buttonPin";
            buttonPin.Size = new Size(59, 34);
            buttonPin.TabIndex = 5;
            buttonPin.Text = "OK";
            buttonPin.UseVisualStyleBackColor = true;
            buttonPin.Click += buttonPin_Click;
            // 
            // buttonMoney
            // 
            buttonMoney.Location = new Point(403, 103);
            buttonMoney.Name = "buttonMoney";
            buttonMoney.Size = new Size(385, 34);
            buttonMoney.TabIndex = 6;
            buttonMoney.Text = "View Account Funds";
            buttonMoney.UseVisualStyleBackColor = true;
            buttonMoney.Click += buttonMoney_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(403, 208);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(184, 34);
            buttonInsert.TabIndex = 7;
            buttonInsert.Text = "Insert Amount";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonWithdraw
            // 
            buttonWithdraw.Location = new Point(604, 208);
            buttonWithdraw.Name = "buttonWithdraw";
            buttonWithdraw.Size = new Size(184, 34);
            buttonWithdraw.TabIndex = 8;
            buttonWithdraw.Text = "Withdraw Amount";
            buttonWithdraw.UseVisualStyleBackColor = true;
            buttonWithdraw.Click += buttonWithdraw_Click;
            // 
            // textBoxAmount
            // 
            textBoxAmount.AcceptsReturn = true;
            textBoxAmount.Location = new Point(505, 154);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(283, 31);
            textBoxAmount.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 154);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 10;
            label3.Text = "Amount";
            // 
            // textBoxInfo
            // 
            textBoxInfo.Enabled = false;
            textBoxInfo.Location = new Point(407, 284);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.Size = new Size(381, 239);
            textBoxInfo.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 256);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 12;
            label4.Text = "Info";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(676, 40);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            ControlBox = false;
            Controls.Add(buttonCancel);
            Controls.Add(label4);
            Controls.Add(textBoxInfo);
            Controls.Add(label3);
            Controls.Add(textBoxAmount);
            Controls.Add(buttonWithdraw);
            Controls.Add(buttonInsert);
            Controls.Add(buttonMoney);
            Controls.Add(buttonPin);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(textBoxPin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormClient";
            StartPosition = FormStartPosition.Manual;
            Text = "Bankomat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBoxPin;
        private Label label2;
        private ListView listView1;
        private Button buttonPin;
        private Button buttonMoney;
        private Button buttonInsert;
        private Button buttonWithdraw;
        private TextBox textBoxAmount;
        private Label label3;
        private TextBox textBoxInfo;
        private Label label4;
        private Button buttonCancel;
    }
}