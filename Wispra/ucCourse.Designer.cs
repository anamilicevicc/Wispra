
namespace Wispra
{
    partial class ucCourse
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCourseName = new System.Windows.Forms.Label();
            this.pbxFlag = new System.Windows.Forms.PictureBox();
            this.btnDunge = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Aegean", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCourseName.Location = new System.Drawing.Point(72, 40);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(80, 15);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "course name";
            // 
            // pbxFlag
            // 
            this.pbxFlag.Location = new System.Drawing.Point(8, 8);
            this.pbxFlag.Name = "pbxFlag";
            this.pbxFlag.Size = new System.Drawing.Size(64, 48);
            this.pbxFlag.TabIndex = 1;
            this.pbxFlag.TabStop = false;
            // 
            // btnDunge
            // 
            this.btnDunge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(110)))), ((int)(((byte)(179)))));
            this.btnDunge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(192)))), ((int)(((byte)(152)))));
            this.btnDunge.Location = new System.Drawing.Point(120, 0);
            this.btnDunge.Name = "btnDunge";
            this.btnDunge.Size = new System.Drawing.Size(32, 32);
            this.btnDunge.TabIndex = 2;
            this.btnDunge.Text = "X";
            this.btnDunge.UseVisualStyleBackColor = false;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Aegean", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(16, 72);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(120, 48);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Course description";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProgress.Location = new System.Drawing.Point(64, 120);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(24, 18);
            this.lblProgress.TabIndex = 4;
            this.lblProgress.Text = "0%";
            // 
            // ucCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(192)))), ((int)(((byte)(152)))));
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnDunge);
            this.Controls.Add(this.pbxFlag);
            this.Controls.Add(this.lblCourseName);
            this.Name = "ucCourse";
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.PictureBox pbxFlag;
        private System.Windows.Forms.Button btnDunge;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblProgress;
    }
}
