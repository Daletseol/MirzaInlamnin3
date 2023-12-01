namespace Inlämning3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddCustomer = new Button();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxMoney = new TextBox();
            textBoxPinCode = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listView1 = new ListView();
            buttonUnlock = new Button();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonLoad = new Button();
            SuspendLayout();
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Location = new Point(476, 400);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(299, 34);
            buttonAddCustomer.TabIndex = 6;
            buttonAddCustomer.Text = "Add Customer";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            buttonAddCustomer.Click += button1_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(594, 254);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(181, 31);
            textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(594, 291);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(181, 31);
            textBoxLastName.TabIndex = 3;
            // 
            // textBoxMoney
            // 
            textBoxMoney.Location = new Point(594, 328);
            textBoxMoney.Name = "textBoxMoney";
            textBoxMoney.Size = new Size(181, 31);
            textBoxMoney.TabIndex = 4;
            // 
            // textBoxPinCode
            // 
            textBoxPinCode.Location = new Point(594, 363);
            textBoxPinCode.Name = "textBoxPinCode";
            textBoxPinCode.Size = new Size(181, 31);
            textBoxPinCode.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 254);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 6;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 291);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 7;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 328);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 8;
            label3.Text = "Money";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 363);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 9;
            label4.Text = "Pin Code";
            // 
            // listView1
            // 
            listView1.Location = new Point(37, 12);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(738, 223);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // buttonUnlock
            // 
            buttonUnlock.Location = new Point(37, 254);
            buttonUnlock.Name = "buttonUnlock";
            buttonUnlock.Size = new Size(206, 34);
            buttonUnlock.TabIndex = 11;
            buttonUnlock.Text = "Unlock Selected";
            buttonUnlock.UseVisualStyleBackColor = true;
            buttonUnlock.Click += buttonUnlock_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(37, 400);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(37, 294);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(206, 34);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete Selected";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(164, 400);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(112, 34);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoad);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(buttonUnlock);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPinCode);
            Controls.Add(textBoxMoney);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(buttonAddCustomer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Bank Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddCustomer;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxMoney;
        private TextBox textBoxPinCode;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListView listView1;
        private Button buttonUnlock;
        private Button buttonSave;
        private Button buttonDelete;
        private Button buttonLoad;
    }
}