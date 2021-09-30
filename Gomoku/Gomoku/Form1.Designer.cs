
namespace Gomoku
{
    partial class 五子棋
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(五子棋));
            this.SuspendLayout();
            // 
            // 五子棋
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(754, 733);
            this.Name = "五子棋";
            this.Text = "五子棋";
            this.Load += new System.EventHandler(this.五子棋_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.五子棋_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.五子棋_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

