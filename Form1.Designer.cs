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
            this.button_Invert = new System.Windows.Forms.Button();
            this.button_Blue = new System.Windows.Forms.Button();
            this.button_Green = new System.Windows.Forms.Button();
            this.button_Red = new System.Windows.Forms.Button();
            this.button_Grayscale = new System.Windows.Forms.Button();
            this.button_Half = new System.Windows.Forms.Button();
            this.Image2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.button_Open2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_Y = new System.Windows.Forms.Button();
            this.button_HSV = new System.Windows.Forms.Button();
            this.button_GetColor = new System.Windows.Forms.Button();
            this.button_Skin = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
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
            // button_Invert
            // 
            this.button_Invert.Location = new System.Drawing.Point(139, 6);
            this.button_Invert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Invert.Name = "button_Invert";
            this.button_Invert.Size = new System.Drawing.Size(56, 28);
            this.button_Invert.TabIndex = 26;
            this.button_Invert.Text = "Invert";
            this.button_Invert.UseVisualStyleBackColor = true;
            this.button_Invert.Click += new System.EventHandler(this.Button_Invert_Click);
            // 
            // button_Blue
            // 
            this.button_Blue.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Blue.ForeColor = System.Drawing.Color.Blue;
            this.button_Blue.Location = new System.Drawing.Point(111, 6);
            this.button_Blue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Blue.Name = "button_Blue";
            this.button_Blue.Size = new System.Drawing.Size(27, 28);
            this.button_Blue.TabIndex = 35;
            this.button_Blue.Text = "B";
            this.button_Blue.UseVisualStyleBackColor = true;
            this.button_Blue.Click += new System.EventHandler(this.Button_Blue_Click);
            // 
            // button_Green
            // 
            this.button_Green.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Green.ForeColor = System.Drawing.Color.Green;
            this.button_Green.Location = new System.Drawing.Point(82, 6);
            this.button_Green.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Green.Name = "button_Green";
            this.button_Green.Size = new System.Drawing.Size(27, 28);
            this.button_Green.TabIndex = 34;
            this.button_Green.Text = "G";
            this.button_Green.UseVisualStyleBackColor = true;
            this.button_Green.Click += new System.EventHandler(this.Button_Green_Click);
            // 
            // button_Red
            // 
            this.button_Red.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Red.ForeColor = System.Drawing.Color.Red;
            this.button_Red.Location = new System.Drawing.Point(54, 6);
            this.button_Red.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Red.Name = "button_Red";
            this.button_Red.Size = new System.Drawing.Size(27, 28);
            this.button_Red.TabIndex = 33;
            this.button_Red.Text = "R";
            this.button_Red.UseVisualStyleBackColor = true;
            this.button_Red.Click += new System.EventHandler(this.Button_Red_Click);
            // 
            // button_Grayscale
            // 
            this.button_Grayscale.Location = new System.Drawing.Point(197, 6);
            this.button_Grayscale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Grayscale.Name = "button_Grayscale";
            this.button_Grayscale.Size = new System.Drawing.Size(85, 28);
            this.button_Grayscale.TabIndex = 36;
            this.button_Grayscale.Text = "Grayscale";
            this.button_Grayscale.UseVisualStyleBackColor = true;
            this.button_Grayscale.Click += new System.EventHandler(this.Button_Grayscale_Click);
            // 
            // button_Half
            // 
            this.button_Half.Location = new System.Drawing.Point(7, 6);
            this.button_Half.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Half.Name = "button_Half";
            this.button_Half.Size = new System.Drawing.Size(46, 28);
            this.button_Half.TabIndex = 37;
            this.button_Half.Text = "Half";
            this.button_Half.UseVisualStyleBackColor = true;
            this.button_Half.Click += new System.EventHandler(this.button_Half_Click);
            // 
            // Image2
            // 
            this.Image2.BackColor = System.Drawing.Color.White;
            this.Image2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Image2.Location = new System.Drawing.Point(487, 90);
            this.Image2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Image2.Name = "Image2";
            this.Image2.Size = new System.Drawing.Size(302, 186);
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
            // button_Y
            // 
            this.button_Y.Location = new System.Drawing.Point(285, 6);
            this.button_Y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Y.Name = "button_Y";
            this.button_Y.Size = new System.Drawing.Size(72, 28);
            this.button_Y.TabIndex = 68;
            this.button_Y.Text = "YCrCb";
            this.button_Y.UseVisualStyleBackColor = true;
            this.button_Y.Click += new System.EventHandler(this.button_Y_Click);
            // 
            // button_HSV
            // 
            this.button_HSV.Location = new System.Drawing.Point(362, 6);
            this.button_HSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_HSV.Name = "button_HSV";
            this.button_HSV.Size = new System.Drawing.Size(57, 28);
            this.button_HSV.TabIndex = 69;
            this.button_HSV.Text = "HSV";
            this.button_HSV.UseVisualStyleBackColor = true;
            this.button_HSV.Click += new System.EventHandler(this.button_HSV_Click);
            // 
            // button_GetColor
            // 
            this.button_GetColor.Location = new System.Drawing.Point(425, 6);
            this.button_GetColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_GetColor.Name = "button_GetColor";
            this.button_GetColor.Size = new System.Drawing.Size(66, 28);
            this.button_GetColor.TabIndex = 70;
            this.button_GetColor.Text = "색 추출";
            this.button_GetColor.UseVisualStyleBackColor = true;
            this.button_GetColor.Click += new System.EventHandler(this.button_GetColor_Click);
            // 
            // button_Skin
            // 
            this.button_Skin.Location = new System.Drawing.Point(497, 6);
            this.button_Skin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Skin.Name = "button_Skin";
            this.button_Skin.Size = new System.Drawing.Size(87, 28);
            this.button_Skin.TabIndex = 71;
            this.button_Skin.Text = "피부 추출";
            this.button_Skin.UseVisualStyleBackColor = true;
            this.button_Skin.Click += new System.EventHandler(this.button_Skin_Click);
            // 
            // button_equal
            // 
            this.button_equal.Location = new System.Drawing.Point(7, 42);
            this.button_equal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(102, 28);
            this.button_equal.TabIndex = 72;
            this.button_equal.Text = "Equalization";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 682);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_Skin);
            this.Controls.Add(this.button_GetColor);
            this.Controls.Add(this.button_HSV);
            this.Controls.Add(this.button_Y);
            this.Controls.Add(this.button_Open2);
            this.Controls.Add(this.Image2);
            this.Controls.Add(this.button_Half);
            this.Controls.Add(this.button_Grayscale);
            this.Controls.Add(this.button_Blue);
            this.Controls.Add(this.button_Green);
            this.Controls.Add(this.button_Red);
            this.Controls.Add(this.button_Invert);
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
        private System.Windows.Forms.Button button_Invert;
        private System.Windows.Forms.Button button_Blue;
        private System.Windows.Forms.Button button_Green;
        private System.Windows.Forms.Button button_Red;
        private System.Windows.Forms.Button button_Grayscale;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Name;
        private System.Windows.Forms.Button button_Half;
        private OpenCvSharp.UserInterface.PictureBoxIpl Image2;
        private System.Windows.Forms.Button button_Open2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_Y;
        private System.Windows.Forms.Button button_HSV;
        private System.Windows.Forms.Button button_GetColor;
        private System.Windows.Forms.Button button_Skin;
        private System.Windows.Forms.Button button_equal;
    }
}

