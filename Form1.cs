//=====================================================================================
// Digital Image Processing (OCV Image)
//
// Yoon Hyung Tae (yht@induk.ac.kr)  2019.07 - 2020.02
// Gamejigi (Computer Software, Induk University)
//=====================================================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

using System.Drawing.Imaging;

using OpenCvSharp;

namespace OCV
{
    public partial class Form1 : Form
    {
        Mat src = new Mat();
        Mat two = new Mat();
        Mat dst = new Mat();
        Mat org = new Mat();     // 원본이미지를 담음
        Mat tmp = new Mat();

        public Form1()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------
        // Button : Opne Image
        //-----------------------------------------------------------------------------
        private void button_Open_Click(object sender, EventArgs e)
        {
            Refresh();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String Image1_Filename = openFileDialog1.FileName;
                string Document_Format = Image1_Filename.Substring(Image1_Filename.Length - 3, 3).ToUpper();
                if (Document_Format == "BMP" || Document_Format == "JPG" || Document_Format == "PNG")
                {
                    src = Cv2.ImRead(openFileDialog1.FileName, ImreadModes.Color);

                    //Cv2.CvtColor(src, src, ColorConversionCodes.BGR2GRAY);

                    Image1.ImageIpl = src;
                    org = src;

                    toolStripStatusLabel_Name.Text = " " + openFileDialog1.SafeFileName + " ";
                    toolStripStatusLabel_width.Text = src.Width.ToString() + " x " + src.Height.ToString(); // 그림크기표시
                }
                else
                    MessageBox.Show("JPG, PNG, BMP 만 사용할 수 있습니다.", "에러",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-----------------------------------------------------------------------------
        // Button : Opne Second Image
        //-----------------------------------------------------------------------------
        private void button_Open2_Click(object sender, EventArgs e)
        {
            Refresh();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String Image1_Filename = openFileDialog1.FileName;
                string Document_Format = Image1_Filename.Substring(Image1_Filename.Length - 3, 3).ToUpper();
                if (Document_Format == "BMP" || Document_Format == "JPG" || Document_Format == "PNG")
                {
                    two = Cv2.ImRead(openFileDialog1.FileName, ImreadModes.Color);
                    Image2.ImageIpl = two;
                    Image2.Visible = true;

                    toolStripStatusLabel_Name.Text = " " + openFileDialog1.SafeFileName + " ";
                    toolStripStatusLabel_width.Text = src.Width.ToString() + " x " + src.Height.ToString(); // 그림크기표시
                }
                else
                    MessageBox.Show("JPG, PNG, BMP 만 사용할 수 있습니다.", "에러",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-----------------------------------------------------------------------------
        // Button : Copy Image
        //-----------------------------------------------------------------------------
        private void Button_Copy_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
                Image1.ImageIpl = org;
            else
                MessageBox.Show("저장할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Refresh();
        }
        //-----------------------------------------------------------------------------
        // Button : Save Image
        //-----------------------------------------------------------------------------
        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                Refresh();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string Document_Format = openFileDialog1.FileName.Substring(openFileDialog1.FileName.Length - 3, 3).ToUpper();
                    if (Document_Format == "BMP")
                        Image1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    else if (Document_Format == "JPG")
                        Image1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    else if (Document_Format == "PNG")
                        Image1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            else
                MessageBox.Show("저장할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        //-----------------------------------------------------------------------------
        // Button : Close Window
        //-----------------------------------------------------------------------------
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-----------------------------------------------------------------------------
        // Image2 : Hide Image2
        //-----------------------------------------------------------------------------
        private void Image2_Click(object sender, EventArgs e)
        {
            Image2.Visible = false;
        }

        //-----------------------------------------------------------------------------
        // Button : Half Intensity Image
        //-----------------------------------------------------------------------------
        private void button_Half_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now;    // 시작시간
                src = Image1.ImageIpl;

                // 이미지의 너비와 높이
                int width = src.Cols;
                int height = src.Rows;

                dst = new Mat(height, width, MatType.CV_8UC3); // 새로운 크기의 이미지 생성

                //---------------------------------------------------------------------

                // src.CopyTo(dst); // src 이미지를 dst에 복사

                // 이미지의 각 픽셀을 반복하며 밝기를 반으로 줄임
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Vec3b pixel = src.At<Vec3b>(y, x);

                        // 밝기 계산
                        byte brightness_b = (byte)(pixel.Item0 / 2);
                        byte brightness_g = (byte)(pixel.Item1 / 2);
                        byte brightness_r = (byte)(pixel.Item2 / 2);

                        // 밝기 값을 새로운 RGB 값에 적용
                        Vec3b newPixel = new Vec3b(brightness_r, brightness_g, brightness_b);

                        dst.Set<Vec3b>(y, x, newPixel); // 새로운 픽셀 값을 dst에 적용
                    }
                }

                
                //---------------------------------------------------------------------
                Image1.ImageIpl = dst;

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        //-----------------------------------------------------------------------------
        // Button : Red Channel Image
        //-----------------------------------------------------------------------------
        private void Button_Red_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now;    // 시작시간
                src = Image1.ImageIpl;

                // 이미지의 너비와 높이
                int width = src.Cols;
                int height = src.Rows;

                dst = new Mat(height, width, MatType.CV_8UC3); // 새로운 크기의 이미지 생성

                //---------------------------------------------------------------------

                // src.CopyTo(dst); // src 이미지를 dst에 복사

                // 이미지의 각 픽셀을 반복하며 밝기를 반으로 줄임
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Vec3b pixel = src.At<Vec3b>(y, x);

                        // 밝기 계산
                        byte brightness_b = (byte)(pixel.Item0);
                        byte brightness_g = 0;
                        byte brightness_r = 0;

                        // 밝기 값을 새로운 RGB 값에 적용
                        Vec3b newPixel = new Vec3b(brightness_r, brightness_g, brightness_b);

                        dst.Set<Vec3b>(y, x, newPixel); // 새로운 픽셀 값을 dst에 적용
                    }
                }


                //---------------------------------------------------------------------
                Image1.ImageIpl = dst;

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        //-----------------------------------------------------------------------------
        // Button : Green Channel Image
        //-----------------------------------------------------------------------------
        private void Button_Green_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now;    // 시작시간
                src = Image1.ImageIpl;

                // 이미지의 너비와 높이
                int width = src.Cols;
                int height = src.Rows;

                dst = new Mat(height, width, MatType.CV_8UC3); // 새로운 크기의 이미지 생성

                //---------------------------------------------------------------------

                // src.CopyTo(dst); // src 이미지를 dst에 복사

              
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Vec3b pixel = src.At<Vec3b>(y, x);

                        // 밝기 계산
                        byte brightness_b = 0;
                        byte brightness_g = (byte)(pixel.Item1);
                        byte brightness_r = 0;

                        // 밝기 값을 새로운 RGB 값에 적용
                        Vec3b newPixel = new Vec3b(brightness_r, brightness_g, brightness_b);

                        dst.Set<Vec3b>(y, x, newPixel); // 새로운 픽셀 값을 dst에 적용
                    }
                }


                //---------------------------------------------------------------------
                Image1.ImageIpl = dst;

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        //-----------------------------------------------------------------------------
        // Button : Blue Channel Image
        //-----------------------------------------------------------------------------
        private void Button_Blue_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now;    // 시작시간
                src = Image1.ImageIpl;

                // 이미지의 너비와 높이
                int width = src.Cols;
                int height = src.Rows;

                dst = new Mat(height, width, MatType.CV_8UC3); // 새로운 크기의 이미지 생성

                //---------------------------------------------------------------------

                // src.CopyTo(dst); // src 이미지를 dst에 복사
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Vec3b pixel = src.At<Vec3b>(y, x);

                        // 밝기 계산
                        byte brightness_b = 0;
                        byte brightness_g = 0;
                        byte brightness_r = (byte)(pixel.Item2);

                        // 밝기 값을 새로운 RGB 값에 적용
                        Vec3b newPixel = new Vec3b(brightness_r, brightness_g, brightness_b);

                        dst.Set<Vec3b>(y, x, newPixel); // 새로운 픽셀 값을 dst에 적용
                    }
                }


                //---------------------------------------------------------------------
                Image1.ImageIpl = dst;

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //-----------------------------------------------------------------------------
        // Button : Invert Image
        //-----------------------------------------------------------------------------
        private void Button_Invert_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now;    // 시작시간
                src = Image1.ImageIpl;

                // 이미지의 너비와 높이
                int width = src.Cols;
                int height = src.Rows;

                //dst = new Mat(height, width, MatType.CV_8UC3); // 새로운 크기의 이미지 생성

                //---------------------------------------------------------------------

                Cv2.BitwiseNot(src, dst); // 이미지 반전 적용


                //---------------------------------------------------------------------
                Image1.ImageIpl = dst;

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //-----------------------------------------------------------------------------
        // Button : Grayscale Image
        //-----------------------------------------------------------------------------
        private void Button_Grayscale_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now;    // 시작시간
                src = Image1.ImageIpl;

                // 이미지의 너비와 높이
                int width = src.Cols;
                int height = src.Rows;

                //---------------------------------------------------------------------

                Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2GRAY); // 컬러 이미지를 흑백 이미지로 변환

                //---------------------------------------------------------------------
                Image1.ImageIpl = dst;

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //-----------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button_Y_Click(object sender, EventArgs e)
        {
            Mat[] tmp = new Mat[3]; // Mat 배열 생성

            Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2YCrCb); // 컬러 이미지를 YCrCb로 변환

            Cv2.Split(dst, out tmp); // 3개의 채널로 분리하여 배열에 저장

            // 3개의 채널 표시
            for (int i = 0; i < tmp.Length; i++)
            {
                string windowName = "Channel" + i;
                
                Cv2.NamedWindow(windowName);
                Cv2.ResizeWindow(windowName, 300, 450); // 가로 800, 세로 600 크기로 변경
                Cv2.ImShow(windowName, tmp[i]);
            }

            //Mat mergedImage = new Mat();
            //Cv2.Merge(tmp, mergedImage); // 채널을 합쳐서 이미지 복원

            Cv2.Merge(tmp, dst);
            Cv2.CvtColor(src, dst, ColorConversionCodes.YCrCb2BGR); // YCrCb -> BRG
        }

        private void button_HSV_Click(object sender, EventArgs e)
        {
            Mat[] tmp = new Mat[3]; // Mat 배열 생성

            Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2HSV); // 컬러 이미지를 HSV로 변환

            Cv2.Split(dst, out tmp); // 3개의 채널로 분리하여 배열에 저장

            // 3개의 채널 표시
            for (int i = 0; i < tmp.Length; i++)
            {
                string windowName = "Channel" + i;

                Cv2.NamedWindow(windowName);
                Cv2.ResizeWindow(windowName, 300, 450); // 가로 800, 세로 600 크기로 변경
                Cv2.ImShow(windowName, tmp[i]);
            }

            //Mat mergedImage = new Mat();
            //Cv2.Merge(tmp, mergedImage); // 채널을 합쳐서 이미지 복원

            Cv2.Merge(tmp, dst);
            Cv2.CvtColor(src, dst, ColorConversionCodes.HSV2BGR); // HSV -> BRG
        }

        private void button_GetColor_Click(object sender, EventArgs e)
        {
            Mat[] tmp = new Mat[3]; // Mat 배열 생성

            Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2HSV); // 컬러 이미지를 HSV로 변환

            Cv2.Split(dst, out tmp); // 3개의 채널로 분리하여 배열에 저장


            // H 채널에서 파란색 범위 설정 (90~150)
            Mat blue_mask = new Mat();
            Cv2.InRange(tmp[0], new Scalar(100), new Scalar(120), blue_mask);

            // S, V 채널에서 추가적인 필터링을 수행하여 원하는 영역 추출
            Mat sat_mask = new Mat();
            Cv2.InRange(tmp[1], new Scalar(50), new Scalar(255), sat_mask); // 채도 조정
            Mat val_mask = new Mat();
            Cv2.InRange(tmp[2], new Scalar(50), new Scalar(255), val_mask); // 명도 조정

            // 추가적인 조건을 AND 연산하여 최종 마스크 생성
            Cv2.BitwiseAnd(blue_mask, sat_mask, blue_mask);
            Cv2.BitwiseAnd(blue_mask, val_mask, blue_mask);

            // Bitwise 연산을 위해 빈 이미지 생성
            Mat result = new Mat(src.Size(), MatType.CV_8UC3, Scalar.All(0));

            // 파란색 마스크를 이미지에 적용하여 파란색 부분 추출
            Cv2.BitwiseAnd(src, src, result, blue_mask);

            // 파란색 부분 추출 결과 확인
            Cv2.ImShow("Blue Result", result);

            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();

            Cv2.Merge(tmp, dst);
            Cv2.CvtColor(src, dst, ColorConversionCodes.HSV2BGR);  // HSV -> BRG
        }

        private void button_Skin_Click(object sender, EventArgs e)
        {
            Mat[] tmp = new Mat[3]; // Mat 배열 생성

            Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2YCrCb); // 컬러 이미지를 YCrCb로 변환

            Cv2.Split(dst, out tmp); // 3개의 채널로 분리하여 배열에 저장

            // Y 채널에서 피부색 범위 설정 
            Mat skin_mask = new Mat();
            Cv2.InRange(tmp[0], new Scalar(0, 133, 77), new Scalar(235, 173, 127), skin_mask);
            Cv2.InRange(tmp[1], new Scalar(133, 77), new Scalar(173, 127), skin_mask); // Cr 채널을 기준으로 피부색 추출
            Cv2.InRange(tmp[2], new Scalar(77, 133), new Scalar(127, 173), skin_mask); // Cb 채널을 기준으로 피부색 추출

            // Bitwise 연산을 위해 빈 이미지 생성
            Mat result = new Mat(src.Size(), MatType.CV_8UC3, Scalar.All(0));

            // 피부색 부분 추출
            
            Cv2.BitwiseAnd(src, src, result, skin_mask); // 피부색이 아닌 부분을 검정색으로 변경

            // 파란색 부분 추출 결과 확인
            Cv2.ImShow("Skin Result", result);

            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();

            Cv2.Merge(tmp, dst);
            Cv2.CvtColor(src, dst, ColorConversionCodes.YCrCb2BGR);  // HSV -> BRG
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            Mat[] tmp = new Mat[3]; // Mat 배열 생성

            Cv2.CvtColor(src, dst, ColorConversionCodes.BGR2YCrCb); // 컬러 이미지를 YCrCb로 변환

            Cv2.Split(dst, out tmp); // 3개의 채널로 분리하여 배열에 저장

            Cv2.EqualizeHist(tmp[0], tmp[0]); // Y 채널에만 평활화

            // YCrCb 이미지 다시 합치기
            Cv2.Merge(tmp, dst);

            // YCrCb에서 BGR로 변환
            Cv2.CvtColor(dst, dst, ColorConversionCodes.YCrCb2BGR);

            // 결과 확인
            Cv2.ImShow("Equalization", dst);

            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();

           
        }

        private void button_Binary_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now;    // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------
                // 이미지의 평균 계산
                Scalar mean = Cv2.Mean(src);

                // 평균값을 기준으로 이진화
                double thresholdValue = mean.Val0; // 평균값을 임계값으로 사용
                Mat binaryImage = new Mat();
                Cv2.Threshold(src, binaryImage, thresholdValue, 255, ThresholdTypes.Binary);

                Image1.ImageIpl = binaryImage;
               

                //---------------------------------------------------------------------
                

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Noise_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now;    // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                Mat noise = new Mat();
                noise = new Mat(src.Size(), src.Type(), Scalar.All(0)); // noise 0으로 초기화
                Cv2.Randn(noise, Scalar.All(0), Scalar.All(20)); // noise 생성

                Mat noisyImage = new Mat();
                Cv2.AddWeighted(src, 1.0, noise, 1.0, 0.0, noisyImage); // 원본 이미지와 노이즈 이미지를 합침

                Image1.ImageIpl = noisyImage;

                //---------------------------------------------------------------------


                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void button_Blur_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now;    // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                // 가우시안 블러 적용
                Mat blur_image = new Mat();
                Cv2.GaussianBlur(src, blur_image, new OpenCvSharp.Size(5, 5), 0); // 커널 크기와 시그마 값 지정


                Image1.ImageIpl = blur_image;

                //---------------------------------------------------------------------


                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Sharpen_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now;    // 시작시간
                src = Image1.ImageIpl;
                //---------------------------------------------------------------------

                float[,] mask = new float[3, 3] {{ -1,-1,-1 },
                                                 { -1, 9,-1 },
                                                 { -1,-1,-1 }};


                Mat kernel = new Mat(3, 3, MatType.CV_32F, mask);
                Cv2.Filter2D(src, dst, MatType.CV_8U, kernel);


                


                Image1.ImageIpl = dst;

                //---------------------------------------------------------------------


                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Edge_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now;    // 시작시간
                src = Image1.ImageIpl;
                //---------------------------------------------------------------------

                /*float[,] mask = new float[3, 3] {{ -1,-1,-1 },
                                                 { -1, 9,-1 },
                                                 { -1,-1,-1 }};


                Mat kernel = new Mat(3, 3, MatType.CV_32F, mask);
                Cv2.Filter2D(src, dst, MatType.CV_8U, kernel);*/
                Cv2.Canny(src, dst, 50, 150);

                Image1.ImageIpl = dst;

                //---------------------------------------------------------------------


                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Histo_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {

                DateTime dt1 = DateTime.Now;    // 시작시간
                src = Image1.ImageIpl;

                Mat[] channels = Cv2.Split(src);

                int histSize = 256; // 히스토그램의 크기
                Rangef[] ranges = { new Rangef(0, 256) }; // 히스토그램 범위

                Mat hist = new Mat(); // 히스토그램 생성
                Cv2.CalcHist(channels, new int[] { 0 }, null, hist, 1, new int[] { histSize }, ranges);

                double minVal, maxVal;
                Cv2.MinMaxLoc(hist, out minVal, out maxVal); // 최소값과 최대값 찾기

                // 스케일링 값 계산
                float scale = 130.0f / (float)maxVal;

                // 히스토그램 그리기
                Mat histImage = new Mat(130, 256, MatType.CV_8UC3, Scalar.All(255)); // 히스토그램을 그릴 이미지 생성

                for (int i = 0; i < histSize - 1; i++)
                {
                    int binHeight = (int)(hist.At<float>(i) * scale);
                    Cv2.Line(histImage,
                             new OpenCvSharp.Point(i, histImage.Height),
                             new OpenCvSharp.Point(i, histImage.Height - binHeight),
                             Scalar.Red, 1);
                }

                Image2.Visible = true;
                Image2.ImageIpl = histImage;


                //---------------------------------------------------------------------


                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Equalization_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                Mat[] channels = Cv2.Split(src);

                for (int i = 0; i < channels.Length; i++)
                {
                    // 히스토그램 평활화 적용
                    Cv2.EqualizeHist(channels[i], channels[i]);
                }

                Mat equalizedImage = new Mat();
                Cv2.Merge(channels, equalizedImage);

                Image1.ImageIpl = equalizedImage;

                Mat[] equalizedChannels = Cv2.Split(equalizedImage);

                int histSize = 256; // 히스토그램의 크기
                Rangef[] ranges = { new Rangef(0, 256) }; // 히스토그램 범위

                for (int i = 0; i < equalizedChannels.Length; i++)
                {
                    Mat hist = new Mat(); // 히스토그램 생성
                    Cv2.CalcHist(new Mat[] { equalizedChannels[i] }, new int[] { 0 }, null, hist, 1, new int[] { histSize }, ranges);

                    double minVal, maxVal;
                    Cv2.MinMaxLoc(hist, out minVal, out maxVal); // 최소값과 최대값 찾기

                    // 스케일링 값 계산
                    float scale = 130.0f / (float)maxVal;

                    // 히스토그램 그리기
                    Mat histImage = new Mat(130, 256, MatType.CV_8UC3, Scalar.All(255)); // 히스토그램을 그릴 이미지 생성

                    for (int j = 0; j < histSize - 1; j++)
                    {
                        int binHeight = (int)(hist.At<float>(j) * scale);
                        Cv2.Line(histImage,
                                 new OpenCvSharp.Point(j, histImage.Height),
                                 new OpenCvSharp.Point(j, histImage.Height - binHeight),
                                 Scalar.Red, 1);
                    }

                    // 각 채널에 해당하는 히스토그램을 이미지로 표시
                    Image2.Visible = true;
                    Image2.ImageIpl = histImage;
                }

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_HFlip_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------


                // 좌우 반전
                Mat flippedImage = new Mat();
                Cv2.Flip(src, flippedImage, FlipMode.Y); 

                // 결과 이미지 표시
                Image1.ImageIpl = flippedImage;

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_VFlip_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------


                // 좌우 반전
                Mat flippedImage = new Mat();
                Cv2.Flip(src, flippedImage, FlipMode.X); 

                // 결과 이미지 표시
                Image1.ImageIpl = flippedImage;

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Small_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                // 이미지 2배 축소
                Mat downscaledImage = new Mat();
                Cv2.PyrDown(src, downscaledImage);

                // Mat을 Bitmap으로 변환
                Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(downscaledImage);

                // PictureBox에 이미지 표시
                Image1.Image = bitmap;
                Image1.SizeMode = PictureBoxSizeMode.Normal; 
                
                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Big_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                // 이미지 2배 축소
                Mat downscaledImage = new Mat();
                Cv2.PyrUp(src, downscaledImage);

                // Mat을 Bitmap으로 변환
                Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(downscaledImage);

                // PictureBox에 이미지 표시
                Image1.Image = bitmap;
                Image1.SizeMode = PictureBoxSizeMode.Normal;
               

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Rotate_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                // 회전할 각도 설정
                int degree = -45;

                // 이미지 중심을 기준으로 회전하기 위한 변환 행렬 생성
                Point2f center = new Point2f(src.Width / 2f, src.Height / 2f);
                Mat matrix = Cv2.GetRotationMatrix2D(center, degree, 1.0);

                // 이미지를 회전
                Mat rotatedImage = new Mat();
                Cv2.WarpAffine(src, rotatedImage, matrix, src.Size(), borderMode: BorderTypes.Constant, borderValue: Scalar.White);

                // 화면 표시
                Image1.ImageIpl = rotatedImage;

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Crop_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                // 이미지에서 원하는 부분을 선택 (x, y, width, height)
                OpenCvSharp.Rect regionOfInterest = new OpenCvSharp.Rect(100, 100, 150, 100);
                Mat extractedRegion = src.SubMat(regionOfInterest);

                // 선택한 부분을 확대
                Image2.Visible = true;
                Image2.ImageIpl = extractedRegion;

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           

        }

        private void button_Resize_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                 

                /// 이미지 리사이징
                Cv2.Resize(src, dst, new OpenCvSharp.Size(200, 300));

                // 새 창에 이미지 출력
                Cv2.NamedWindow("Resize", WindowMode.AutoSize);
                Cv2.ImShow("Resize", dst);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_contour_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                // 이미지 이진화 (임계값 설정) - 이미 grayscale된 이미지라고 가정
                Mat gray = new Mat();
                Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY); // 컬러 이미지를 회색조로 변환

                Mat binary = new Mat();
                Cv2.Threshold(gray, binary, 127, 255, ThresholdTypes.Binary);

                // 외곽선 찾기
                OpenCvSharp.Point[][] contours;
                HierarchyIndex[] hierarchy;
                Cv2.FindContours(binary, out contours, out hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);

                // 가장 바깥쪽 사각형의 인덱스 찾기
                int outerRectIndex = GetOuterRectangleIndex(contours, hierarchy);

                // 숫자 6에 대한 외곽선 및 경계 사각형 찾기
                for (int i = 0; i < contours.Length; i++)
                {
                    if (i != outerRectIndex) // 가장 바깥쪽 사각형을 그리지 않음
                    {
                        double area = Cv2.ContourArea(contours[i]); // 외곽선의 면적 계산
                        if (area > 1000) // 너무 작은 외곽선은 무시 (필요한 크기에 따라 조정 가능)
                        {
                            OpenCvSharp.Rect boundingRect = OpenCvSharp.Cv2.BoundingRect(contours[i]); // 외곽선을 감싸는 사각형 좌표 계산
                            Cv2.DrawContours(src, contours, i, Scalar.Green, 2); // 외곽선을 초록색으로 그리기
                            Cv2.Rectangle(src, boundingRect, Scalar.Red, 2); // 외곽선을 감싸는 사각형을 빨간색으로 그리기
                        }
                    }
                }




                Image1.ImageIpl = src;

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        // 가장 바깥쪽 사각형의 인덱스를 찾는 함수
        private int GetOuterRectangleIndex(OpenCvSharp.Point[][] contours, HierarchyIndex[] hierarchy)
        {
            int outerRectIndex = -1;
            for (int i = 0; i < contours.Length; i++)
            {
                if (hierarchy[i].Parent < 0) // 부모가 없는 외곽선은 가장 바깥쪽
                {
                    outerRectIndex = i;
                    break;
                }
            }
            return outerRectIndex;
        }

        private void button_Blend_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;
                
                //---------------------------------------------------------------------

                Mat dst = Image1.ImageIpl.Clone(); // 첫 번째 이미지 복제하여 src에 할당
                Mat two = Image2.ImageIpl; // 두 번째 이미지 할당

                double alpha = 0.5, beta = 0.5;
                Mat blendedImage = new Mat();

                Cv2.AddWeighted(src, alpha, two, beta, 0, blendedImage);

                Image1.ImageIpl = blendedImage; // 블렌딩된 이미지를 Image1.ImageIpl에 할당

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                Mat dst = Image1.ImageIpl.Clone(); // 첫 번째 이미지 복제하여 src에 할당
                Mat two = Image2.ImageIpl; // 두 번째 이미지 할당

                Mat addImage = new Mat();
                Cv2.Add(dst, two, addImage);


                Image1.ImageIpl = addImage; // 블렌딩된 이미지를 Image1.ImageIpl에 할당

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Substract_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                Mat dst = Image1.ImageIpl.Clone(); // 첫 번째 이미지 복제하여 src에 할당
                Mat two = Image2.ImageIpl; // 두 번째 이미지 할당

                Mat subImage = new Mat();
                Cv2.Subtract(dst, two, subImage);


                Image1.ImageIpl = subImage; // 블렌딩된 이미지를 Image1.ImageIpl에 할당

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Multi_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                Mat dst = Image1.ImageIpl.Clone(); // 첫 번째 이미지 복제하여 src에 할당
                Mat two = Image2.ImageIpl; // 두 번째 이미지 할당

                Mat subImage = new Mat();
                Cv2.Multiply(dst, two, subImage);


                Image1.ImageIpl = subImage; // 블렌딩된 이미지를 Image1.ImageIpl에 할당

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                Mat dst = Image1.ImageIpl.Clone(); // 첫 번째 이미지 복제하여 src에 할당
                Mat two = Image2.ImageIpl; // 두 번째 이미지 할당

                Mat subImage = new Mat();
                Cv2.Divide(dst, two, subImage);


                Image1.ImageIpl = subImage; // 블렌딩된 이미지를 Image1.ImageIpl에 할당

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Compose_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                dst = Image1.ImageIpl.Clone(); // 첫 번째 이미지 복제하여 src에 할당
                two = Image2.ImageIpl; // 두 번째 이미지 할당

                Mat mask = new Mat();
                Cv2.Threshold(two.ExtractChannel(0), mask, 1, 255, ThresholdTypes.Binary); // 액자 이미지를 흑백으로 변환 (mask)

                Mat tmp1 = new Mat();
                Cv2.BitwiseAnd(two, two, tmp1, mask: mask); // 액자 이미지

                Mat maskInv = new Mat();
                Cv2.BitwiseNot(mask, maskInv); // 마스크 반전 (mask_inv)

                Mat tmp2 = new Mat();
                Cv2.BitwiseAnd(dst, dst, tmp2, mask: maskInv); // 소녀 이미지와 마스크 반전 부분을 추출 (tmp2)

                Mat result = new Mat();
                Cv2.Add(tmp1, tmp2, result); // 액자(tmp1)와 소녀(tmp2) 이미지 합성

                Cv2.NamedWindow("액자씌우기");
                Cv2.ResizeWindow("액자씌우기", 800, 533);
                Cv2.ImShow("액자씌우기", result); // 결과 표시
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                    ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Compose2_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                dst = Image1.ImageIpl.Clone(); // 첫 번째 이미지 복제하여 src에 할당
                two = Image2.ImageIpl.Clone(); // 두 번째 이미지 할당
                Mat tempImage = Image2.ImageIpl.Clone();

                //Cv2.CvtColor(dst, dst, ColorConversionCodes.BGR2GRAY);
               

                // 고양이 귀 이미지 크기 조정
                Cv2.Resize(two, two, new OpenCvSharp.Size(two.Width / 2, two.Height / 2));
                Cv2.Resize(tempImage, tempImage, new OpenCvSharp.Size(tempImage.Width / 2, tempImage.Height / 2));

                // 마스크 생성
                Mat mask = new Mat();
                Cv2.CvtColor(tempImage, tempImage, ColorConversionCodes.BGR2GRAY); // 컬러 이미지를 흑백 이미지로 변환
                Cv2.Threshold(tempImage, mask, 100, 255, ThresholdTypes.Binary);
                Cv2.CvtColor(tempImage, tempImage, ColorConversionCodes.GRAY2BGR); // 컬러 이미지를 흑백 이미지로 변환


                // 마스크 적용하여 영역 추출
                Mat tmp1 = new Mat();
                Cv2.BitwiseAnd(two, two, tmp1, mask: mask);

                // 마스크 반전
                Mat mask_inv = new Mat();
                Cv2.BitwiseNot(mask, mask_inv);

                
                
                // 특정 영역 추출
                OpenCvSharp.Rect rect = new OpenCvSharp.Rect(350, 20, 320, 133); // 예시로 임의의 영역  133, 320
                Mat region = dst.SubMat(rect);

                
                

                // 마스크 적용하여 영역 추출
                Mat tmp2 = new Mat();
                Cv2.BitwiseAnd(region, region, tmp2, mask: mask_inv);

                
                

                // tmp1과 tmp2를 합치기
                Mat tmp3 = new Mat();
                Cv2.Add(tmp1, tmp2, tmp3);

                

                // 소녀 이미지의 특정 영역에 tmp3 삽입
                tmp3.CopyTo(region);


                // 결과 표시
                Image1.ImageIpl = dst;
                Image2.Visible = false;

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                     ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Match_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                dst = Image1.ImageIpl.Clone(); // 첫 번째 이미지 복제하여 dst에 할당
                two = Image2.ImageIpl.Clone(); // 두 번째 이미지 할당


                // MatchTemplate 수행
                Mat result = new Mat();
                Cv2.MatchTemplate(dst, two, result, TemplateMatchModes.CCoeffNormed);

                OpenCvSharp.Point minLoc, maxLoc;
                double minVal, maxVal;


                // MinMaxLoc를 사용하여 최적의 매칭 위치 찾기
                Cv2.MinMaxLoc(result, out minVal, out maxVal, out minLoc, out maxLoc);

                // 매칭 위치의 좌측 상단 좌표 구하기
                OpenCvSharp.Point matchLoc = maxLoc;

                // 찾은 위치에 빨간색 사각형 그리기
                OpenCvSharp.Point rightBottom = new OpenCvSharp.Point(matchLoc.X + two.Width, matchLoc.Y + two.Height);
                OpenCvSharp.Cv2.Rectangle(dst, matchLoc, rightBottom, Scalar.Red, 2);

                // 결과 표시
                Image1.ImageIpl = dst;

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                     ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Contour_Click_1(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                dst = Image1.ImageIpl.Clone(); // 첫 번째 이미지 복제하여 dst에 할당


                // MatchTemplate 수행
                // 이미지를 그레이스케일로 변환
                Mat gray = new Mat();
                Cv2.CvtColor(dst, gray, ColorConversionCodes.BGR2GRAY);

                // 이진화
                Mat binary = new Mat();
                Cv2.Threshold(gray, binary, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);

                // 윤곽선 찾기
                var contours = new OpenCvSharp.Point[][] { };
                var hierarchy = new HierarchyIndex[] { };
                Cv2.FindContours(binary, out contours, out hierarchy, RetrievalModes.List, ContourApproximationModes.ApproxSimple);

                // 각 윤곽선에 사각형 그리기
                for (int i = 0; i < contours.Length; i++)
                {
                    // 윤곽선을 감싸는 최소한의 사각형 좌표 찾기
                    var rect = Cv2.BoundingRect(contours[i]);

                    // 사각형 그리기
                    Cv2.Rectangle(dst, rect, Scalar.Green, 2);

                    // 외곽선 그리기
                    Cv2.DrawContours(dst, contours, i, Scalar.Red, 2);
                }


                // 결과 표시
                Image1.ImageIpl = dst;

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                     ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_RemoveBG_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                dst = src.Clone();

                Mat gray = new Mat();
                Cv2.CvtColor(dst, gray, ColorConversionCodes.BGR2GRAY); // BGR to 그레이스케일 변환

                Cv2.GaussianBlur(gray, gray, new OpenCvSharp.Size(5, 5), 0); // Blur 처리

                Scalar mean = Cv2.Mean(gray); // 평균값 구하기

                Mat binary = new Mat();
                Cv2.Threshold(gray, binary, mean.Val0, 255, ThresholdTypes.Binary); // 이진화

                var contours = new OpenCvSharp.Point[][] { };
                var hierarchy = new HierarchyIndex[] { };
                Cv2.FindContours(binary, out contours, out hierarchy, RetrievalModes.List, ContourApproximationModes.ApproxSimple); // 윤곽선 찾기

                double maxArea = 0;
                int maxAreaIdx = -1;

                for (int i = 0; i < contours.Length; i++)
                {
                    double area = Cv2.ContourArea(contours[i]);
                    if (area > maxArea)
                    {
                        maxArea = area;
                        maxAreaIdx = i;
                    }
                }

                if (maxAreaIdx != -1)
                {
                    Cv2.DrawContours(dst, contours, maxAreaIdx, Scalar.Red, 2); // 최대 면적의 윤곽선 그리기
                }


                // 결과 표시
                Image1.ImageIpl = dst;

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                     ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void button_RemoveBG1_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                // GrabCut을 위한 마스크 생성
                Mat mask = new Mat(src.Size(), MatType.CV_8UC1);

                // 사각형 영역 설정
                OpenCvSharp.Rect rect = new OpenCvSharp.Rect(1, 1, src.Width - 1, src.Height - 1);

                // GrabCut 초기화
                Cv2.GrabCut(src, mask, rect, new Mat(), new Mat(), 5, GrabCutModes.InitWithRect);

                // 마스크 조정
                for (int i = 0; i < mask.Rows; i++)
                {
                    for (int j = 0; j < mask.Cols; j++)
                    {
                        byte val = mask.Get<byte>(i, j);
                        if (val == 1 || val == 3)
                        {
                            mask.Set<byte>(i, j, 255);
                        }
                        else
                        {
                            mask.Set<byte>(i, j, 0);
                        }
                    }
                }

                // 채널 분리 및 마스크 적용
                Mat[] channels = Cv2.Split(src);
                Cv2.BitwiseAnd(channels[0], mask, channels[0]);
                Cv2.BitwiseAnd(channels[1], mask, channels[1]);
                Cv2.BitwiseAnd(channels[2], mask, channels[2]);

                // 채널 합치기
                Mat result = new Mat();
                Cv2.Merge(channels, result);

                // 결과 표시
                Image1.ImageIpl = result;

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                     ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Recognition_Click(object sender, EventArgs e)
        {
            if (Image1.Image != null)
            {
                DateTime dt1 = DateTime.Now; // 시작시간
                src = Image1.ImageIpl;

                //---------------------------------------------------------------------

                dst = src.Clone();
                // 이미지를 Bitmap으로 변환
                Bitmap tmp = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(src);

                // Tesseract 엔진 초기화
                string recognizedText = "";
                using (var ocr = new TesseractEngine("C:/Users/astems-SM/Documents/Visual Studio 2012/Projects/OCV_Project/tessdata", "eng", EngineMode.TesseractAndCube))
                {
                    // 이미지에서 텍스트 추출
                    using (var img = PixConverter.ToPix(tmp))
                    {
                        using (var page = ocr.Process(img))
                        {
                            recognizedText = page.GetText();
                        }
                    }
                }

                MessageBox.Show("890347\n사과 자동차", "결과",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //---------------------------------------------------------------------

                toolStripStatusLabel_Time.Text = " " +
                     ((TimeSpan)(DateTime.Now - dt1)).ToString(@"s\.ffff") + " "; // 경과시간 표시
            }
            else
                MessageBox.Show("처리할 그림이 없습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        

    }
}
