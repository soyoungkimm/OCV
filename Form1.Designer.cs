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
            this.Image2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.button_Open2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_Binary = new System.Windows.Forms.Button();
            this.button_Noise = new System.Windows.Forms.Button();
            this.button_Blur = new System.Windows.Forms.Button();
            this.button_Sharpen = new System.Windows.Forms.Button();
            this.button_Edge = new System.Windows.Forms.Button();
            this.button_Histo = new System.Windows.Forms.Button();
            this.button_Equalization = new System.Windows.Forms.Button();
            this.button_HFlip = new System.Windows.Forms.Button();
            this.button_VFlip = new System.Windows.Forms.Button();
            this.button_Small = new System.Windows.Forms.Button();
            this.button_Big = new System.Windows.Forms.Button();
            this.button_Rotate = new System.Windows.Forms.Button();
            this.button_Crop = new System.Windows.Forms.Button();
            this.button_Resize = new System.Windows.Forms.Button();
            this.button_contour = new System.Windows.Forms.Button();
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
            this.button_Invert.Location = new System.Drawing.Point(12, 9);
            this.button_Invert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Invert.Name = "button_Invert";
            this.button_Invert.Size = new System.Drawing.Size(56, 28);
            this.button_Invert.TabIndex = 26;
            this.button_Invert.Text = "Invert";
            this.button_Invert.UseVisualStyleBackColor = true;
            this.button_Invert.Click += new System.EventHandler(this.Button_Invert_Click);
            // 
            // Image2
            // 
            this.Image2.BackColor = System.Drawing.Color.White;
            this.Image2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Image2.Location = new System.Drawing.Point(528, 94);
            this.Image2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Image2.Name = "Image2";
            this.Image2.Size = new System.Drawing.Size(250, 180);
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
            // button_Binary
            // 
            this.button_Binary.Location = new System.Drawing.Point(74, 9);
            this.button_Binary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Binary.Name = "button_Binary";
            this.button_Binary.Size = new System.Drawing.Size(56, 28);
            this.button_Binary.TabIndex = 68;
            this.button_Binary.Text = "Binary";
            this.button_Binary.UseVisualStyleBackColor = true;
            this.button_Binary.Click += new System.EventHandler(this.button_Binary_Click);
            // 
            // button_Noise
            // 
            this.button_Noise.Location = new System.Drawing.Point(136, 9);
            this.button_Noise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Noise.Name = "button_Noise";
            this.button_Noise.Size = new System.Drawing.Size(56, 28);
            this.button_Noise.TabIndex = 69;
            this.button_Noise.Text = "Noise";
            this.button_Noise.UseVisualStyleBackColor = true;
            this.button_Noise.Click += new System.EventHandler(this.button_Noise_Click);
            // 
            // button_Blur
            // 
            this.button_Blur.Location = new System.Drawing.Point(198, 9);
            this.button_Blur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Blur.Name = "button_Blur";
            this.button_Blur.Size = new System.Drawing.Size(56, 28);
            this.button_Blur.TabIndex = 70;
            this.button_Blur.Text = "Blur";
            this.button_Blur.UseVisualStyleBackColor = true;
            this.button_Blur.Click += new System.EventHandler(this.button_Blur_Click);
            // 
            // button_Sharpen
            // 
            this.button_Sharpen.Location = new System.Drawing.Point(260, 9);
            this.button_Sharpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Sharpen.Name = "button_Sharpen";
            this.button_Sharpen.Size = new System.Drawing.Size(73, 28);
            this.button_Sharpen.TabIndex = 71;
            this.button_Sharpen.Text = "Sharpen";
            this.button_Sharpen.UseVisualStyleBackColor = true;
            this.button_Sharpen.Click += new System.EventHandler(this.button_Sharpen_Click);
            // 
            // button_Edge
            // 
            this.button_Edge.Location = new System.Drawing.Point(339, 9);
            this.button_Edge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Edge.Name = "button_Edge";
            this.button_Edge.Size = new System.Drawing.Size(56, 28);
            this.button_Edge.TabIndex = 72;
            this.button_Edge.Text = "Edge";
            this.button_Edge.UseVisualStyleBackColor = true;
            this.button_Edge.Click += new System.EventHandler(this.button_Edge_Click);
            // 
            // button_Histo
            // 
            this.button_Histo.Location = new System.Drawing.Point(401, 9);
            this.button_Histo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Histo.Name = "button_Histo";
            this.button_Histo.Size = new System.Drawing.Size(85, 28);
            this.button_Histo.TabIndex = 73;
            this.button_Histo.Text = "Histogram";
            this.button_Histo.UseVisualStyleBackColor = true;
            this.button_Histo.Click += new System.EventHandler(this.button_Histo_Click);
            // 
            // button_Equalization
            // 
            this.button_Equalization.Location = new System.Drawing.Point(12, 42);
            this.button_Equalization.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Equalization.Name = "button_Equalization";
            this.button_Equalization.Size = new System.Drawing.Size(100, 28);
            this.button_Equalization.TabIndex = 74;
            this.button_Equalization.Text = "Equalization";
            this.button_Equalization.UseVisualStyleBackColor = true;
            this.button_Equalization.Click += new System.EventHandler(this.button_Equalization_Click);
            // 
            // button_HFlip
            // 
            this.button_HFlip.Location = new System.Drawing.Point(118, 42);
            this.button_HFlip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_HFlip.Name = "button_HFlip";
            this.button_HFlip.Size = new System.Drawing.Size(55, 28);
            this.button_HFlip.TabIndex = 75;
            this.button_HFlip.Text = "HFlip";
            this.button_HFlip.UseVisualStyleBackColor = true;
            this.button_HFlip.Click += new System.EventHandler(this.button_HFlip_Click);
            // 
            // button_VFlip
            // 
            this.button_VFlip.Location = new System.Drawing.Point(179, 42);
            this.button_VFlip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_VFlip.Name = "button_VFlip";
            this.button_VFlip.Size = new System.Drawing.Size(55, 28);
            this.button_VFlip.TabIndex = 76;
            this.button_VFlip.Text = "VFlip";
            this.button_VFlip.UseVisualStyleBackColor = true;
            this.button_VFlip.Click += new System.EventHandler(this.button_VFlip_Click);
            // 
            // button_Small
            // 
            this.button_Small.Location = new System.Drawing.Point(240, 42);
            this.button_Small.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Small.Name = "button_Small";
            this.button_Small.Size = new System.Drawing.Size(55, 28);
            this.button_Small.TabIndex = 77;
            this.button_Small.Text = "Small";
            this.button_Small.UseVisualStyleBackColor = true;
            this.button_Small.Click += new System.EventHandler(this.button_Small_Click);
            // 
            // button_Big
            // 
            this.button_Big.Location = new System.Drawing.Point(300, 42);
            this.button_Big.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Big.Name = "button_Big";
            this.button_Big.Size = new System.Drawing.Size(55, 28);
            this.button_Big.TabIndex = 78;
            this.button_Big.Text = "Big";
            this.button_Big.UseVisualStyleBackColor = true;
            this.button_Big.Click += new System.EventHandler(this.button_Big_Click);
            // 
            // button_Rotate
            // 
            this.button_Rotate.Location = new System.Drawing.Point(361, 42);
            this.button_Rotate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Rotate.Name = "button_Rotate";
            this.button_Rotate.Size = new System.Drawing.Size(64, 28);
            this.button_Rotate.TabIndex = 79;
            this.button_Rotate.Text = "Rotate";
            this.button_Rotate.UseVisualStyleBackColor = true;
            this.button_Rotate.Click += new System.EventHandler(this.button_Rotate_Click);
            // 
            // button_Crop
            // 
            this.button_Crop.Location = new System.Drawing.Point(431, 42);
            this.button_Crop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Crop.Name = "button_Crop";
            this.button_Crop.Size = new System.Drawing.Size(55, 28);
            this.button_Crop.TabIndex = 80;
            this.button_Crop.Text = "Crop";
            this.button_Crop.UseVisualStyleBackColor = true;
            this.button_Crop.Click += new System.EventHandler(this.button_Crop_Click);
            // 
            // button_Resize
            // 
            this.button_Resize.Location = new System.Drawing.Point(492, 42);
            this.button_Resize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Resize.Name = "button_Resize";
            this.button_Resize.Size = new System.Drawing.Size(62, 28);
            this.button_Resize.TabIndex = 81;
            this.button_Resize.Text = "Resize";
            this.button_Resize.UseVisualStyleBackColor = true;
            this.button_Resize.Click += new System.EventHandler(this.button_Resize_Click);
            // 
            // button_contour
            // 
            this.button_contour.Location = new System.Drawing.Point(492, 9);
            this.button_contour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_contour.Name = "button_contour";
            this.button_contour.Size = new System.Drawing.Size(71, 28);
            this.button_contour.TabIndex = 82;
            this.button_contour.Text = "contour";
            this.button_contour.UseVisualStyleBackColor = true;
            this.button_contour.Click += new System.EventHandler(this.button_contour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 682);
            this.Controls.Add(this.button_contour);
            this.Controls.Add(this.button_Resize);
            this.Controls.Add(this.button_Crop);
            this.Controls.Add(this.button_Rotate);
            this.Controls.Add(this.button_Big);
            this.Controls.Add(this.button_Small);
            this.Controls.Add(this.button_VFlip);
            this.Controls.Add(this.button_HFlip);
            this.Controls.Add(this.button_Equalization);
            this.Controls.Add(this.button_Histo);
            this.Controls.Add(this.button_Edge);
            this.Controls.Add(this.button_Sharpen);
            this.Controls.Add(this.button_Blur);
            this.Controls.Add(this.button_Noise);
            this.Controls.Add(this.button_Binary);
            this.Controls.Add(this.button_Open2);
            this.Controls.Add(this.Image2);
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Name;
        private OpenCvSharp.UserInterface.PictureBoxIpl Image2;
        private System.Windows.Forms.Button button_Open2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_Binary;
        private System.Windows.Forms.Button button_Noise;
        private System.Windows.Forms.Button button_Blur;
        private System.Windows.Forms.Button button_Sharpen;
        private System.Windows.Forms.Button button_Edge;
        private System.Windows.Forms.Button button_Histo;
        private System.Windows.Forms.Button button_Equalization;
        private System.Windows.Forms.Button button_HFlip;
        private System.Windows.Forms.Button button_VFlip;
        private System.Windows.Forms.Button button_Small;
        private System.Windows.Forms.Button button_Big;
        private System.Windows.Forms.Button button_Rotate;
        private System.Windows.Forms.Button button_Crop;
        private System.Windows.Forms.Button button_Resize;
        private System.Windows.Forms.Button button_contour;
    }
}

