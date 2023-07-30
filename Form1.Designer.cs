
namespace AI_Chat__C_Framework
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rTxtResult = new System.Windows.Forms.RichTextBox();
            this.txtAskFor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(651, 10);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(202, 62);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rTxtResult
            // 
            this.rTxtResult.Location = new System.Drawing.Point(10, 145);
            this.rTxtResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rTxtResult.Name = "rTxtResult";
            this.rTxtResult.Size = new System.Drawing.Size(596, 203);
            this.rTxtResult.TabIndex = 3;
            this.rTxtResult.Text = "";
            this.rTxtResult.TextChanged += new System.EventHandler(this.rTxtResult_TextChanged);
            // 
            // txtAskFor
            // 
            this.txtAskFor.Location = new System.Drawing.Point(58, 10);
            this.txtAskFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAskFor.Name = "txtAskFor";
            this.txtAskFor.Size = new System.Drawing.Size(548, 20);
            this.txtAskFor.TabIndex = 4;
            this.txtAskFor.TextChanged += new System.EventHandler(this.txtAskFor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ask for";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAskFor);
            this.Controls.Add(this.rTxtResult);
            this.Controls.Add(this.btnGenerate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox rTxtResult;
        private System.Windows.Forms.TextBox txtAskFor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

