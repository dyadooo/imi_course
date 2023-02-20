namespace VariousChecks
{
    partial class Form1
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
            this.radioButtonEGN = new System.Windows.Forms.RadioButton();
            this.radioButtonEIK9 = new System.Windows.Forms.RadioButton();
            this.radioButtonEIK13 = new System.Windows.Forms.RadioButton();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.groupBoxItem = new System.Windows.Forms.GroupBox();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.buttonCHECK = new System.Windows.Forms.Button();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.radioButtonLNF = new System.Windows.Forms.RadioButton();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.groupBoxItems.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            this.groupBoxItem.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonEGN
            // 
            this.radioButtonEGN.AutoSize = true;
            this.radioButtonEGN.Checked = true;
            this.radioButtonEGN.Location = new System.Drawing.Point(13, 19);
            this.radioButtonEGN.Name = "radioButtonEGN";
            this.radioButtonEGN.Size = new System.Drawing.Size(46, 17);
            this.radioButtonEGN.TabIndex = 1;
            this.radioButtonEGN.TabStop = true;
            this.radioButtonEGN.Text = "ЕГН";
            this.radioButtonEGN.UseVisualStyleBackColor = true;
            this.radioButtonEGN.CheckedChanged += new System.EventHandler(this.radioButtonEGN_CheckedChanged);
            // 
            // radioButtonEIK9
            // 
            this.radioButtonEIK9.AutoSize = true;
            this.radioButtonEIK9.Location = new System.Drawing.Point(13, 42);
            this.radioButtonEIK9.Name = "radioButtonEIK9";
            this.radioButtonEIK9.Size = new System.Drawing.Size(53, 17);
            this.radioButtonEIK9.TabIndex = 2;
            this.radioButtonEIK9.Text = "ЕИК9";
            this.radioButtonEIK9.UseVisualStyleBackColor = true;
            this.radioButtonEIK9.CheckedChanged += new System.EventHandler(this.radioButtonEIK9_CheckedChanged);
            // 
            // radioButtonEIK13
            // 
            this.radioButtonEIK13.AutoSize = true;
            this.radioButtonEIK13.Location = new System.Drawing.Point(13, 65);
            this.radioButtonEIK13.Name = "radioButtonEIK13";
            this.radioButtonEIK13.Size = new System.Drawing.Size(59, 17);
            this.radioButtonEIK13.TabIndex = 3;
            this.radioButtonEIK13.Text = "ЕИК13";
            this.radioButtonEIK13.UseVisualStyleBackColor = true;
            this.radioButtonEIK13.CheckedChanged += new System.EventHandler(this.radioButtonEIK13_CheckedChanged);
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Controls.Add(this.pictureBoxResult);
            this.groupBoxItems.Controls.Add(this.radioButtonLNF);
            this.groupBoxItems.Controls.Add(this.radioButtonEIK13);
            this.groupBoxItems.Controls.Add(this.radioButtonEGN);
            this.groupBoxItems.Controls.Add(this.radioButtonEIK9);
            this.groupBoxItems.Location = new System.Drawing.Point(12, 12);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(200, 134);
            this.groupBoxItems.TabIndex = 1;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Тип на елемента за проверка";
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Controls.Add(this.textBoxDescription);
            this.groupBoxDescription.Location = new System.Drawing.Point(218, 12);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(200, 134);
            this.groupBoxDescription.TabIndex = 2;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Описание";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(7, 21);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(187, 107);
            this.textBoxDescription.TabIndex = 0;
            // 
            // groupBoxItem
            // 
            this.groupBoxItem.Controls.Add(this.textBoxItem);
            this.groupBoxItem.Location = new System.Drawing.Point(12, 152);
            this.groupBoxItem.Name = "groupBoxItem";
            this.groupBoxItem.Size = new System.Drawing.Size(200, 52);
            this.groupBoxItem.TabIndex = 3;
            this.groupBoxItem.TabStop = false;
            this.groupBoxItem.Text = "Елемент за проверка";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(13, 20);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(181, 20);
            this.textBoxItem.TabIndex = 0;
            // 
            // buttonCHECK
            // 
            this.buttonCHECK.Location = new System.Drawing.Point(7, 17);
            this.buttonCHECK.Name = "buttonCHECK";
            this.buttonCHECK.Size = new System.Drawing.Size(75, 26);
            this.buttonCHECK.TabIndex = 4;
            this.buttonCHECK.Text = "Проверка";
            this.buttonCHECK.UseVisualStyleBackColor = true;
            this.buttonCHECK.Click += new System.EventHandler(this.buttonCHECK_Click);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonEXIT);
            this.groupBoxActions.Controls.Add(this.buttonCHECK);
            this.groupBoxActions.Location = new System.Drawing.Point(218, 152);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(200, 52);
            this.groupBoxActions.TabIndex = 5;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Действия";
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.Location = new System.Drawing.Point(119, 17);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(75, 26);
            this.buttonEXIT.TabIndex = 5;
            this.buttonEXIT.Text = "Изход";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // radioButtonLNF
            // 
            this.radioButtonLNF.AutoSize = true;
            this.radioButtonLNF.Location = new System.Drawing.Point(13, 89);
            this.radioButtonLNF.Name = "radioButtonLNF";
            this.radioButtonLNF.Size = new System.Drawing.Size(49, 17);
            this.radioButtonLNF.TabIndex = 4;
            this.radioButtonLNF.TabStop = true;
            this.radioButtonLNF.Text = "ЛНЧ";
            this.radioButtonLNF.UseVisualStyleBackColor = true;
            this.radioButtonLNF.CheckedChanged += new System.EventHandler(this.radioButtonLNF_CheckedChanged);
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(123, 42);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxResult.TabIndex = 5;
            this.pictureBoxResult.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 216);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxItem);
            this.Controls.Add(this.groupBoxDescription);
            this.Controls.Add(this.groupBoxItems);
            this.Name = "Form1";
            this.Text = "VariousChecks";
            this.groupBoxItems.ResumeLayout(false);
            this.groupBoxItems.PerformLayout();
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            this.groupBoxItem.ResumeLayout(false);
            this.groupBoxItem.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonEIK13;
        private System.Windows.Forms.RadioButton radioButtonEIK9;
        private System.Windows.Forms.RadioButton radioButtonEGN;
        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxItem;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.Button buttonCHECK;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonEXIT;
        private System.Windows.Forms.RadioButton radioButtonLNF;
        private System.Windows.Forms.PictureBox pictureBoxResult;
    }
}

