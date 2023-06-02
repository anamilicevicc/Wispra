
namespace Wispra
{
    partial class frmIncorrect
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
            this.lblThatWasNot = new System.Windows.Forms.Label();
            this.lblTheRightOne = new System.Windows.Forms.Label();
            this.lblCorrection = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThatWasNot
            // 
            this.lblThatWasNot.Font = new System.Drawing.Font("Aegean", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThatWasNot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblThatWasNot.Location = new System.Drawing.Point(16, 16);
            this.lblThatWasNot.Name = "lblThatWasNot";
            this.lblThatWasNot.Size = new System.Drawing.Size(248, 56);
            this.lblThatWasNot.TabIndex = 0;
            this.lblThatWasNot.Text = "That was not the correct answer.";
            // 
            // lblTheRightOne
            // 
            this.lblTheRightOne.AutoSize = true;
            this.lblTheRightOne.Font = new System.Drawing.Font("Aegean", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTheRightOne.Location = new System.Drawing.Point(16, 80);
            this.lblTheRightOne.Name = "lblTheRightOne";
            this.lblTheRightOne.Size = new System.Drawing.Size(209, 19);
            this.lblTheRightOne.TabIndex = 1;
            this.lblTheRightOne.Text = "The correct answer was:";
            // 
            // lblCorrection
            // 
            this.lblCorrection.Font = new System.Drawing.Font("Aegean", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCorrection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCorrection.Location = new System.Drawing.Point(16, 112);
            this.lblCorrection.Name = "lblCorrection";
            this.lblCorrection.Size = new System.Drawing.Size(232, 32);
            this.lblCorrection.TabIndex = 2;
            this.lblCorrection.Text = "correct answer";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnNext.Font = new System.Drawing.Font("Aegean", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(96, 152);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 40);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // frmIncorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.ControlBox = false;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblCorrection);
            this.Controls.Add(this.lblTheRightOne);
            this.Controls.Add(this.lblThatWasNot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmIncorrect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIncorrect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThatWasNot;
        private System.Windows.Forms.Label lblTheRightOne;
        private System.Windows.Forms.Label lblCorrection;
        private System.Windows.Forms.Button btnNext;
    }
}