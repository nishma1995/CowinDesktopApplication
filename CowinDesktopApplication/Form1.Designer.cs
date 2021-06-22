
namespace CowinDesktopApplication
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
            this.btnCall = new System.Windows.Forms.Button();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnClearDistrict = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(441, 109);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(75, 37);
            this.btnCall.TabIndex = 0;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(574, 116);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(212, 24);
            this.comboBoxState.TabIndex = 2;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.comboBoxState_SelectedIndexChanged);
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Location = new System.Drawing.Point(833, 116);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(195, 24);
            this.comboBoxDistrict.TabIndex = 3;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistrict_SelectedIndexChanged);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(787, 702);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 37);
            this.btnClearList.TabIndex = 5;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnClearDistrict
            // 
            this.btnClearDistrict.Location = new System.Drawing.Point(1058, 109);
            this.btnClearDistrict.Name = "btnClearDistrict";
            this.btnClearDistrict.Size = new System.Drawing.Size(75, 37);
            this.btnClearDistrict.TabIndex = 6;
            this.btnClearDistrict.Text = "Clear";
            this.btnClearDistrict.UseVisualStyleBackColor = true;
            this.btnClearDistrict.Click += new System.EventHandler(this.btnClearDistrict_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(441, 188);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(692, 484);
            this.listBox.TabIndex = 7;
            this.listBox.Click += new System.EventHandler(this.listBox_Click);
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(1227, 188);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(248, 220);
            this.richTextBox.TabIndex = 8;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1535, 761);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnClearDistrict);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.comboBoxDistrict);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.btnCall);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vaccination Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnClearDistrict;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

