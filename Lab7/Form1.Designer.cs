namespace Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FirstImageBox = new Emgu.CV.UI.ImageBox();
            this.ResultImageBox = new Emgu.CV.UI.ImageBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitrstImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funtionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drowHaractPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stabilizateImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homographyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionSecondPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.briskStabilizateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brislStabilizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.FirstImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImageBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstImageBox
            // 
            this.FirstImageBox.Location = new System.Drawing.Point(12, 63);
            this.FirstImageBox.Name = "FirstImageBox";
            this.FirstImageBox.Size = new System.Drawing.Size(374, 375);
            this.FirstImageBox.TabIndex = 2;
            this.FirstImageBox.TabStop = false;
            // 
            // ResultImageBox
            // 
            this.ResultImageBox.Location = new System.Drawing.Point(414, 63);
            this.ResultImageBox.Name = "ResultImageBox";
            this.ResultImageBox.Size = new System.Drawing.Size(374, 375);
            this.ResultImageBox.TabIndex = 3;
            this.ResultImageBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.funtionToolStripMenuItem,
            this.functionSecondPartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fitrstImageToolStripMenuItem,
            this.secondImageToolStripMenuItem});
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            // 
            // fitrstImageToolStripMenuItem
            // 
            this.fitrstImageToolStripMenuItem.Name = "fitrstImageToolStripMenuItem";
            this.fitrstImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fitrstImageToolStripMenuItem.Text = "Fitrst Image";
            this.fitrstImageToolStripMenuItem.Click += new System.EventHandler(this.fitrstImageToolStripMenuItem_Click);
            // 
            // secondImageToolStripMenuItem
            // 
            this.secondImageToolStripMenuItem.Name = "secondImageToolStripMenuItem";
            this.secondImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secondImageToolStripMenuItem.Text = "Second Image";
            this.secondImageToolStripMenuItem.Click += new System.EventHandler(this.secondImageToolStripMenuItem_Click);
            // 
            // funtionToolStripMenuItem
            // 
            this.funtionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drowHaractPointsToolStripMenuItem,
            this.stabilizateImageToolStripMenuItem,
            this.homographyToolStripMenuItem});
            this.funtionToolStripMenuItem.Name = "funtionToolStripMenuItem";
            this.funtionToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.funtionToolStripMenuItem.Text = "Funtion";
            // 
            // drowHaractPointsToolStripMenuItem
            // 
            this.drowHaractPointsToolStripMenuItem.Name = "drowHaractPointsToolStripMenuItem";
            this.drowHaractPointsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drowHaractPointsToolStripMenuItem.Text = "Drow HaractPoints";
            this.drowHaractPointsToolStripMenuItem.Click += new System.EventHandler(this.drowHaractPointsToolStripMenuItem_Click);
            // 
            // stabilizateImageToolStripMenuItem
            // 
            this.stabilizateImageToolStripMenuItem.Name = "stabilizateImageToolStripMenuItem";
            this.stabilizateImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stabilizateImageToolStripMenuItem.Text = "Lukas Kanade";
            this.stabilizateImageToolStripMenuItem.Click += new System.EventHandler(this.stabilizateImageToolStripMenuItem_Click);
            // 
            // homographyToolStripMenuItem
            // 
            this.homographyToolStripMenuItem.Name = "homographyToolStripMenuItem";
            this.homographyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.homographyToolStripMenuItem.Text = "Homography";
            this.homographyToolStripMenuItem.Click += new System.EventHandler(this.homographyToolStripMenuItem_Click);
            // 
            // functionSecondPartToolStripMenuItem
            // 
            this.functionSecondPartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.briskStabilizateToolStripMenuItem,
            this.brislStabilizatorToolStripMenuItem});
            this.functionSecondPartToolStripMenuItem.Name = "functionSecondPartToolStripMenuItem";
            this.functionSecondPartToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.functionSecondPartToolStripMenuItem.Text = "Function Second Part";
            // 
            // briskStabilizateToolStripMenuItem
            // 
            this.briskStabilizateToolStripMenuItem.Name = "briskStabilizateToolStripMenuItem";
            this.briskStabilizateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.briskStabilizateToolStripMenuItem.Text = "Brisk  Dot Coparator";
            this.briskStabilizateToolStripMenuItem.Click += new System.EventHandler(this.briskStabilizateToolStripMenuItem_Click);
            // 
            // brislStabilizatorToolStripMenuItem
            // 
            this.brislStabilizatorToolStripMenuItem.Name = "brislStabilizatorToolStripMenuItem";
            this.brislStabilizatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brislStabilizatorToolStripMenuItem.Text = "Brisl Stabilizator";
            this.brislStabilizatorToolStripMenuItem.Click += new System.EventHandler(this.brislStabilizatorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultImageBox);
            this.Controls.Add(this.FirstImageBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FirstImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImageBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox FirstImageBox;
        private Emgu.CV.UI.ImageBox ResultImageBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funtionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drowHaractPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitrstImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stabilizateImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homographyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionSecondPartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem briskStabilizateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brislStabilizatorToolStripMenuItem;
    }
}

