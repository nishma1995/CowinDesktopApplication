
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
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(356, 58);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(75, 37);
            this.btnCall.TabIndex = 0;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(498, 361);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(571, 370);
            this.richTextBoxResult.TabIndex = 1;
            this.richTextBoxResult.Text = "";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(630, 71);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 24);
            this.comboBoxState.TabIndex = 2;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.comboBoxState_SelectedIndexChanged);
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Location = new System.Drawing.Point(844, 71);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDistrict.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 761);
            this.Controls.Add(this.comboBoxDistrict);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.btnCall);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.ComboBox comboBoxDistrict;
    }
}

