namespace OCV
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Image1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.button_Copy = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Name = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_width = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_etcname = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_etc = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Image2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.button_Open2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_Blend = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Substract = new System.Windows.Forms.Button();
            this.button_Compose = new System.Windows.Forms.Button();
            this.button_Compose2 = new System.Windows.Forms.Button();
            this.button_Match = new System.Windows.Forms.Button();
            this.button_Contour = new System.Windows.Forms.Button();
            this.button_RemoveBG = new System.Windows.Forms.Button();
            this.button_RemoveBG1 = new System.Windows.Forms.Button();
            this.button_Recognition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).BeginInit();
            this.SuspendLayout();
            // 
            // Image1
            // 
            this.Image1.BackColor = System.Drawing.Color.White;
            this.Image1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Image1.Location = new System.Drawing.Point(7, 78);
            this.Image1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(799, 569);
            this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image1.TabIndex = 0;
            this.Image1.TabStop = false;
            // 
            // button_Copy
            // 
            this.button_Copy.Image = ((System.Drawing.Image)(resources.GetObject("button_Copy.Image")));
            this.button_Copy.Location = new System.Drawing.Point(677, 9);
            this.button_Copy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(43, 48);
            this.button_Copy.TabIndex = 23;
            this.button_Copy.UseVisualStyleBackColor = true;
            this.button_Copy.Click += new System.EventHandler(this.Button_Copy_Click);
            // 
            // button_Save
            // 
            this.button_Save.Image = ((System.Drawing.Image)(resources.GetObject("button_Save.Image")));
            this.button_Save.Location = new System.Drawing.Point(720, 9);
            this.button_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(43, 48);
            this.button_Save.TabIndex = 22;
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // button_Close
            // 
            this.button_Close.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.Image = ((System.Drawing.Image)(resources.GetObject("button_Close.Image")));
            this.button_Close.Location = new System.Drawing.Point(763, 9);
            this.button_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(43, 48);
            this.button_Close.TabIndex = 20;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Open
            // 
            this.button_Open.BackColor = System.Drawing.SystemColors.Control;
            this.button_Open.Image = ((System.Drawing.Image)(resources.GetObject("button_Open.Image")));
            this.button_Open.Location = new System.Drawing.Point(590, 9);
            this.button_Open.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(43, 48);
            this.button_Open.TabIndex = 21;
            this.button_Open.UseVisualStyleBackColor = false;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_Name,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_width,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel_Time,
            this.toolStripStatusLabel_etcname,
            this.toolStripStatusLabel_etc,
            this.toolStripStatusLabel8});
            this.statusStrip1.Location = new System.Drawing.Point(0, 653);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(816, 29);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(49, 24);
            this.toolStripStatusLabel2.Text = "Name";
            // 
            // toolStripStatusLabel_Name
            // 
            this.toolStripStatusLabel_Name.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_Name.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel_Name.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel_Name.Name = "toolStripStatusLabel_Name";
            this.toolStripStatusLabel_Name.Size = new System.Drawing.Size(118, 24);
            this.toolStripStatusLabel_Name.Text = "                     ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 24);
            this.toolStripStatusLabel1.Text = "Size";
            // 
            // toolStripStatusLabel_width
            // 
            this.toolStripStatusLabel_width.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_width.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel_width.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel_width.Name = "toolStripStatusLabel_width";
            this.toolStripStatusLabel_width.Size = new System.Drawing.Size(63, 24);
            this.toolStripStatusLabel_width.Text = "          ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(60, 24);
            this.toolStripStatusLabel4.Text = "Time(S)";
            // 
            // toolStripStatusLabel_Time
            // 
            this.toolStripStatusLabel_Time.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_Time.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel_Time.Name = "toolStripStatusLabel_Time";
            this.toolStripStatusLabel_Time.Size = new System.Drawing.Size(63, 24);
            this.toolStripStatusLabel_Time.Text = "          ";
            // 
            // toolStripStatusLabel_etcname
            // 
            this.toolStripStatusLabel_etcname.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel_etcname.Name = "toolStripStatusLabel_etcname";
            this.toolStripStatusLabel_etcname.Size = new System.Drawing.Size(45, 24);
            this.toolStripStatusLabel_etcname.Text = " ETC ";
            // 
            // toolStripStatusLabel_etc
            // 
            this.toolStripStatusLabel_etc.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel_etc.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel_etc.Name = "toolStripStatusLabel_etc";
            this.toolStripStatusLabel_etc.Size = new System.Drawing.Size(63, 24);
            this.toolStripStatusLabel_etc.Text = "          ";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(302, 24);
            this.toolStripStatusLabel8.Spring = true;
            this.toolStripStatusLabel8.Text = " ";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "이미지|*.bmp;*.jpg|모든 파일|*.*";
            this.saveFileDialog1.Title = "이미지 저장";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "이미지|*.bmp;*.jpg;*.png|모든 파일|*.*";
            this.openFileDialog1.Title = "이미지 읽기";
            // 
            // Image2
            // 
            this.Image2.BackColor = System.Drawing.Color.White;
            this.Image2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Image2.Location = new System.Drawing.Point(633, 92);
            this.Image2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Image2.Name = "Image2";
            this.Image2.Size = new System.Drawing.Size(160, 110);
            this.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image2.TabIndex = 66;
            this.Image2.TabStop = false;
            this.Image2.Visible = false;
            this.Image2.Click += new System.EventHandler(this.Image2_Click);
            // 
            // button_Open2
            // 
            this.button_Open2.BackColor = System.Drawing.SystemColors.Control;
            this.button_Open2.Image = ((System.Drawing.Image)(resources.GetObject("button_Open2.Image")));
            this.button_Open2.Location = new System.Drawing.Point(633, 9);
            this.button_Open2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Open2.Name = "button_Open2";
            this.button_Open2.Size = new System.Drawing.Size(43, 48);
            this.button_Open2.TabIndex = 67;
            this.button_Open2.UseVisualStyleBackColor = false;
            this.button_Open2.Click += new System.EventHandler(this.button_Open2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button_Blend
            // 
            this.button_Blend.Location = new System.Drawing.Point(12, 9);
            this.button_Blend.Name = "button_Blend";
            this.button_Blend.Size = new System.Drawing.Size(58, 30);
            this.button_Blend.TabIndex = 68;
            this.button_Blend.Text = "Blend";
            this.button_Blend.UseVisualStyleBackColor = true;
            this.button_Blend.Click += new System.EventHandler(this.button_Blend_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(76, 9);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(58, 30);
            this.button_Add.TabIndex = 69;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Substract
            // 
            this.button_Substract.Location = new System.Drawing.Point(140, 9);
            this.button_Substract.Name = "button_Substract";
            this.button_Substract.Size = new System.Drawing.Size(80, 30);
            this.button_Substract.TabIndex = 70;
            this.button_Substract.Text = "Substract";
            this.button_Substract.UseVisualStyleBackColor = true;
            this.button_Substract.Click += new System.EventHandler(this.button_Substract_Click);
            // 
            // button_Compose
            // 
            this.button_Compose.Location = new System.Drawing.Point(226, 9);
            this.button_Compose.Name = "button_Compose";
            this.button_Compose.Size = new System.Drawing.Size(80, 30);
            this.button_Compose.TabIndex = 71;
            this.button_Compose.Text = "Compose";
            this.button_Compose.UseVisualStyleBackColor = true;
            this.button_Compose.Click += new System.EventHandler(this.button_Compose_Click);
            // 
            // button_Compose2
            // 
            this.button_Compose2.Location = new System.Drawing.Point(312, 9);
            this.button_Compose2.Name = "button_Compose2";
            this.button_Compose2.Size = new System.Drawing.Size(87, 30);
            this.button_Compose2.TabIndex = 72;
            this.button_Compose2.Text = "Compose2";
            this.button_Compose2.UseVisualStyleBackColor = true;
            this.button_Compose2.Click += new System.EventHandler(this.button_Compose2_Click);
            // 
            // button_Match
            // 
            this.button_Match.Location = new System.Drawing.Point(405, 9);
            this.button_Match.Name = "button_Match";
            this.button_Match.Size = new System.Drawing.Size(122, 30);
            this.button_Match.TabIndex = 73;
            this.button_Match.Text = "Match Template";
            this.button_Match.UseVisualStyleBackColor = true;
            this.button_Match.Click += new System.EventHandler(this.button_Match_Click);
            // 
            // button_Contour
            // 
            this.button_Contour.Location = new System.Drawing.Point(12, 43);
            this.button_Contour.Name = "button_Contour";
            this.button_Contour.Size = new System.Drawing.Size(70, 30);
            this.button_Contour.TabIndex = 74;
            this.button_Contour.Text = "Contour";
            this.button_Contour.UseVisualStyleBackColor = true;
            this.button_Contour.Click += new System.EventHandler(this.button_Contour_Click_1);
            // 
            // button_RemoveBG
            // 
            this.button_RemoveBG.Location = new System.Drawing.Point(87, 43);
            this.button_RemoveBG.Name = "button_RemoveBG";
            this.button_RemoveBG.Size = new System.Drawing.Size(96, 30);
            this.button_RemoveBG.TabIndex = 75;
            this.button_RemoveBG.Text = "RemoveBG";
            this.button_RemoveBG.UseVisualStyleBackColor = true;
            this.button_RemoveBG.Click += new System.EventHandler(this.button_RemoveBG_Click);
            // 
            // button_RemoveBG1
            // 
            this.button_RemoveBG1.Location = new System.Drawing.Point(189, 43);
            this.button_RemoveBG1.Name = "button_RemoveBG1";
            this.button_RemoveBG1.Size = new System.Drawing.Size(106, 30);
            this.button_RemoveBG1.TabIndex = 76;
            this.button_RemoveBG1.Text = "RemoveBG1";
            this.button_RemoveBG1.UseVisualStyleBackColor = true;
            this.button_RemoveBG1.Click += new System.EventHandler(this.button_RemoveBG1_Click);
            // 
            // button_Recognition
            // 
            this.button_Recognition.Location = new System.Drawing.Point(301, 43);
            this.button_Recognition.Name = "button_Recognition";
            this.button_Recognition.Size = new System.Drawing.Size(106, 30);
            this.button_Recognition.TabIndex = 77;
            this.button_Recognition.Text = "Recognition";
            this.button_Recognition.UseVisualStyleBackColor = true;
            this.button_Recognition.Click += new System.EventHandler(this.button_Recognition_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 682);
            this.Controls.Add(this.button_Recognition);
            this.Controls.Add(this.button_RemoveBG1);
            this.Controls.Add(this.button_RemoveBG);
            this.Controls.Add(this.button_Contour);
            this.Controls.Add(this.button_Match);
            this.Controls.Add(this.button_Compose2);
            this.Controls.Add(this.button_Compose);
            this.Controls.Add(this.button_Substract);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Blend);
            this.Controls.Add(this.button_Open2);
            this.Controls.Add(this.Image2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.Image1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenCV  Part1 Color       by Induk Univ. 윤형태 (2019.07-2020.02.20)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl Image1;
        private System.Windows.Forms.Button button_Copy;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_width;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_etcname;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_etc;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Name;
        private OpenCvSharp.UserInterface.PictureBoxIpl Image2;
        private System.Windows.Forms.Button button_Open2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_Blend;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Substract;
        private System.Windows.Forms.Button button_Compose;
        private System.Windows.Forms.Button button_Compose2;
        private System.Windows.Forms.Button button_Match;
        private System.Windows.Forms.Button button_Contour;
        private System.Windows.Forms.Button button_RemoveBG;
        private System.Windows.Forms.Button button_RemoveBG1;
        private System.Windows.Forms.Button button_Recognition;
    }
}

