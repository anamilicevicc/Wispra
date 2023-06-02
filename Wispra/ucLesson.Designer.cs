
namespace Wispra
{
    partial class ucLesson
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
            this.lblLessonName = new System.Windows.Forms.Label();
            this.lblLessonDesc = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLessonName
            // 
            this.lblLessonName.AutoSize = true;
            this.lblLessonName.Font = new System.Drawing.Font("Aegean", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLessonName.Location = new System.Drawing.Point(16, 24);
            this.lblLessonName.Name = "lblLessonName";
            this.lblLessonName.Size = new System.Drawing.Size(103, 19);
            this.lblLessonName.TabIndex = 0;
            this.lblLessonName.Text = "Lesson name";
            // 
            // lblLessonDesc
            // 
            this.lblLessonDesc.Font = new System.Drawing.Font("Aegean", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLessonDesc.Location = new System.Drawing.Point(16, 56);
            this.lblLessonDesc.Name = "lblLessonDesc";
            this.lblLessonDesc.Size = new System.Drawing.Size(112, 64);
            this.lblLessonDesc.TabIndex = 1;
            this.lblLessonDesc.Text = "Lesson desc";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProgress.Location = new System.Drawing.Point(64, 120);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(27, 20);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "0%";
            // 
            // ucLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(192)))), ((int)(((byte)(152)))));
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblLessonDesc);
            this.Controls.Add(this.lblLessonName);
            this.Name = "ucLesson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLessonName;
        private System.Windows.Forms.Label lblLessonDesc;
        private System.Windows.Forms.Label lblProgress;
    }
}
