using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;
using System.Drawing.Drawing2D;

using System.IO;
using System.Drawing.Imaging;


namespace WindowsFormsApplication1

{
    public partial class Form1 : Form
    {
        private uEye.Camera Camera;
        IntPtr displayHandle = IntPtr.Zero;
        IntPtr displayHandle2 = IntPtr.Zero;
        public long pixelCount = 0;
        public long pixelCount2 = 0;
        private bool bLive = false;
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap cloneBitmap = null;
        private Bitmap calibrateMap = null;
        private Bitmap resultBitmap = null;
        private double distancePerPixel = 1;
        private bool stillImage = false;
        
        

        class Line
        {
            public Point Start { get; set; }
            public Point End { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            displayHandle = DisplayWindow.Handle;
            InitCamera();
            Line line = null;
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;
            double hypotenuse = 0;


                DisplayWindow.MouseMove += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        line.End = e.Location;
                        DisplayWindow.Invalidate();
                    }
                };

                DisplayWindow.MouseDown += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                        line = new Line { Start = e.Location, End = e.Location };

                    pixelCounts.Items.Add(line.Start);
                    x1 = line.Start.X;
                    y1 = line.Start.Y;

                };

                var lines = new List<Line>();
                //DisplayWindow.MouseUp += (s, e) =>
                DisplayWindow.MouseUp += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        lines.Add(line);
                        pixelCounts.Items.Add(line.End);
                        x2 = line.End.X;
                        y2 = line.End.Y;
                        hypotenuse = Math.Sqrt(Math.Pow(Math.Abs(x2 - x1), 2) + Math.Pow(Math.Abs(y2 - y1), 2));
                        pixelCounts2.Items.Add(hypotenuse);
                    }

                     dragDistance.Text = Math.Round(hypotenuse * distancePerPixel).ToString();
                   //dragDistance.Text = (hypotenuse * distancePerPixel).ToString();

                };

                DisplayWindow.Paint += (s, e) =>
                {
                   
                    if (dragDistanceEnable.Checked == true)
                    {
                       // DisplayWindow.Image = previewBitmap;
                       //dragDistance.Text = Math.Round(hypotenuse * distancePerPixel).ToString();
                       // dragDistance.Text = (hypotenuse * distancePerPixel).ToString();
                        if (line != null)
                        {
                            e.Graphics.DrawLine(Pens.Red, line.Start, line.End);

                        }

                    }
                };
            


            foreach (String s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
                comboBox2.Items.Add(s);
            }

            zoomSettings.Items.Add("20x");
            zoomSettings.Items.Add("20x - 1.6x");
            zoomSettings.Items.Add("40x");
            zoomSettings.Items.Add("40x - 1.6x");
            zoomSettings.Items.Add("60x");
            zoomSettings.Items.Add("60x - 1.6x");

            scaleBar.Hide();
            Scale.Hide();


        }

        private void InitCamera()
        // -------------------------- FUNCTION FOR INITIALISING THE CAMERA (UEYE)  -------------------------- // 
        {
            Camera = new uEye.Camera();

            uEye.Defines.Status statusRet = 0;

            // Open Camera
            statusRet = Camera.Init();
            if (statusRet != uEye.Defines.Status.Success)
            {
                MessageBox.Show("Camera initializing failed");
                Environment.Exit(-1);
            }

            // Set Color Format
            uEye.Types.SensorInfo SensorInfo;
            statusRet = Camera.Information.GetSensorInfo(out SensorInfo);

            if (SensorInfo.SensorColorMode == uEye.Defines.SensorColorMode.Bayer)
            {
                statusRet = Camera.PixelFormat.Set(uEye.Defines.ColorMode.BGR8Packed);
            }
            else
            {
                statusRet = Camera.PixelFormat.Set(uEye.Defines.ColorMode.Mono8);
            }

            // Allocate Memory
            statusRet = Camera.Memory.Allocate();
            if (statusRet != uEye.Defines.Status.Success)
            {
                MessageBox.Show("Allocate Memory failed");
                Environment.Exit(-1);
            }

            // Start Live Video
            statusRet = Camera.Acquisition.Capture();
            if (statusRet != uEye.Defines.Status.Success)
            {
                MessageBox.Show("Start Live Video failed");
            }
            else
            {
                bLive = true;
            }

            // Connect Event
            Camera.EventFrame += onFrameEvent;


        }

        private void onFrameEvent(object sender, EventArgs e)
        // -------------------------- FUNCTION FOR HANDLING CAMERA FRAME INTERRUPTS -------------------------- // 
        {
            uEye.Camera Camera = sender as uEye.Camera;

            Int32 s32MemID;
            Camera.Memory.GetActive(out s32MemID);

            Camera.Display.Render(s32MemID, displayHandle, uEye.Defines.DisplayRenderMode.FitToWindow);
        }

        private void connectStage1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void connectStage2_Click(object sender, EventArgs e)
        {
            serialPort2.Open();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = (string)comboBox1.SelectedItem;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort2.Close();
            serialPort2.PortName = (string)comboBox2.SelectedItem;
        }

        private void moveStage1(int x, int y, int z, char j)
        {
            string test;

            if (j == 'L')
            {
                serialPort1.Write(String.Format("M:W" + "-P{0}" + "-P{1}" + "-P{2}\r\n", Math.Abs(x), Math.Abs(y), Math.Abs(z))); // MOVES THE MOTORISED STAGE UP BY 2 MICROMETERS (166 FOR 1 MICRO METER)
                Console.WriteLine(String.Format("M:W" + "P{0}" + "P{1}" + "P{2}\r\n", Math.Abs(x), Math.Abs(y), Math.Abs(z))); // DISPLAYS MOVEMENT TO CONSOLE
            }

            if (j == 'R')
            {
                serialPort1.Write(String.Format("M:W" + "+P{0}" + "+P{1}" + "+P{2}\r\n", Math.Abs(x), Math.Abs(y), Math.Abs(z))); // MOVES THE MOTORISED STAGE DOWN BY 2 MICROMETERS (166 FOR 1 MICRO METER)
                Console.WriteLine(String.Format("M:W" + "P{0}" + "P{1}" + "P{2}\r\n", Math.Abs(x), Math.Abs(y), Math.Abs(z))); // DISPLAYS MOVEMENT TO CONSOLE
            }



            try
            {
                test = serialPort1.ReadLine(); // READS MOTORISED STAGE DRIVER FOR COMMAND CONFIRMATION
                stage1Status.Text = test; // DISPLAYS CONFIRMATION
            }

            catch { Console.WriteLine("timeout coarse"); } // ERROR

            serialPort1.Write("G:\r\n"); // TELLS STAGE TO BEGIN MOVING

            try
            {
                Console.WriteLine(serialPort1.ReadLine());
            }

            catch { Console.WriteLine("timeout coarse"); } // ERROR
        }

        private void moveStage2(int x, int y, int z, char j)
        {
            string test;

            if (j == 'L')
            {
                serialPort2.Write(String.Format("M:W" + "-P{0}" + "-P{1}" + "-P{2}\r\n", Math.Abs(x), Math.Abs(y), Math.Abs(z))); // MOVES THE MOTORISED STAGE UP BY 2 MICROMETERS (166 FOR 1 MICRO METER)
                Console.WriteLine(String.Format("M:W" + "P{0}" + "P{1}" + "P{2}\r\n", Math.Abs(x), Math.Abs(y), Math.Abs(z))); // DISPLAYS MOVEMENT TO CONSOLE
            }

            if (j == 'R')
            {
                serialPort2.Write(String.Format("M:W" + "+P{0}" + "+P{1}" + "+P{2}\r\n", Math.Abs(x), Math.Abs(y), Math.Abs(z))); // MOVES THE MOTORISED STAGE UP BY 2 MICROMETERS (166 FOR 1 MICRO METER)
                Console.WriteLine(String.Format("M:W" + "P{0}" + "P{1}" + "P{2}\r\n", Math.Abs(x), Math.Abs(y), Math.Abs(z))); // DISPLAYS MOVEMENT TO CONSOLE
            }



            try
            {
                test = serialPort2.ReadLine(); // READS MOTORISED STAGE DRIVER FOR COMMAND CONFIRMATION
                stage2Status.Text = test; // DISPLAYS CONFIRMATION
            }

            catch { Console.WriteLine("timeout coarse"); } // ERROR

            serialPort2.Write("G:\r\n"); // TELLS STAGE TO BEGIN MOVING

            try
            {
                Console.WriteLine(serialPort2.ReadLine());
            }

            catch { Console.WriteLine("timeout coarse"); } // ERROR
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            foreach (String s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
        }
        private void serialPort2Refresh_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            foreach (String s in SerialPort.GetPortNames())
            {
                comboBox2.Items.Add(s);
            }
        }

        private void axis1Left_Click(object sender, EventArgs e)
        {
            if (Axis1.Text != null)
                moveStage1(Convert.ToInt32(Axis1.Text), 0, 0, 'L');
            else
                moveStage1(0, 0, 0, 'L');
        }

        private void axis1Right_Click(object sender, EventArgs e)
        {
            if (Axis1.Text != null)
                moveStage1(Convert.ToInt32(Axis1.Text), 0, 0, 'R');
            else
                moveStage1(0, 0, 0, 'R');
        }

        private void axis2Left_Click(object sender, EventArgs e)
        {
            if (Axis2.Text != null)
                moveStage1(0, Convert.ToInt32(Axis2.Text), 0, 'L');
            else
                moveStage1(0, 0, 0, 'L');
        }

        private void axis2Right_Click(object sender, EventArgs e)
        {
            if (Axis2.Text != null)
                moveStage1(0, Convert.ToInt32(Axis2.Text), 0, 'R');
            else
                moveStage1(0, 0, 0, 'R');
        }

        private void axis3Down_Click(object sender, EventArgs e)
        {
            if (Axis3.Text != null)
                moveStage1(0, 0, Convert.ToInt32(Axis3.Text), 'L');
            else
                moveStage1(0, 0, 0, 'L');

        }

        private void axis3Up_Click(object sender, EventArgs e)
        {
            if (Axis3.Text != null)
                moveStage1(0, 0, Convert.ToInt32(Axis3.Text), 'R');
            else
                moveStage1(0, 0, 0, 'R');
        }

        private void stage2Axis1Left_Click(object sender, EventArgs e)
        {
            if (stage2Axis1.Text != null)
                moveStage2(Convert.ToInt32(stage2Axis1.Text), 0, 0, 'L');
            else
                moveStage2(0, 0, 0, 'L');
        }

        private void stage2Axis1Right_Click(object sender, EventArgs e)
        {
            if (stage2Axis1.Text != null)
                moveStage2(Convert.ToInt32(stage2Axis1.Text), 0, 0, 'R');
            else
                moveStage2(0, 0, 0, 'R');
        }

        private void stage2Axis2Left_Click(object sender, EventArgs e)
        {
            if (stage2Axis2.Text != null)
                moveStage2(0, Convert.ToInt32(stage2Axis2.Text), 0, 'L');
            else
                moveStage2(0, 0, 0, 'L');
        }

        private void stage2Axis2Right_Click(object sender, EventArgs e)
        {
            if (stage2Axis2.Text != null)
                moveStage2(0, Convert.ToInt32(stage2Axis2.Text), 0, 'R');
            else
                moveStage2(0, 0, 0, 'R');
        }

        private void stage2Axis3Down_Click(object sender, EventArgs e)
        {
            if (stage2Axis3.Text != null)
                moveStage2(0, 0, Convert.ToInt32(stage2Axis3.Text), 'L');
            else
                moveStage2(0, 0, 0, 'L');
        }

        private void stage2Axis3Up_Click(object sender, EventArgs e)
        {
            if (stage2Axis3.Text != null)
                moveStage2(0, 0, Convert.ToInt32(stage2Axis3.Text), 'R');
            else
                moveStage2(0, 0, 0, 'R');
        }

        private void ApplyFilter(bool preview)
        // -------------------------- FUNCTION FOR APPLING GRADIENT FILTER  -------------------------- // 
        {
            Stopwatch stopwatch = new Stopwatch(); // CREATES TIMER TO TIME THE IMAGE TRANSFORMATION PROCESS
            stopwatch.Start(); // CONVERSION TIMER START

            if (previewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }

            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;

            if (preview == true)
            {
                selectedSource = previewBitmap; // SELECTED SOURCE IS THE IMAGE WHICH WILL BE TRANSFORMED. PREVIEW BITMAP IS THE DISPLAY IMAGE BOX FROM THE GUI
            }
            else
            {
                selectedSource = originalBitmap;
            }

            if (selectedSource != null)
            {
                if (cmbEdgeDetection.SelectedItem.ToString() == "None")
                {
                    bitmapResult = selectedSource;


                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3") // SELECTED ITEM IS THE GRADIENT FUNCTION AND IS CHOSEN BY THE USER THROUGH THE POP UP MENU
                {
                    bitmapResult = selectedSource.Laplacian3x3Filter(); // SINCE THE SELECTED ITEM HERE WAS "LAPLACIAN 3X3" THE TRANSFORMATION OF THE SELECTED SOURCE (IMAGE) WILL NOW BE A LAPLACE 3X3 FILTER
                }                                                       // THE SAME GOES FOR THE BELOW GRADIENT FILTERS

                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 Grayscale")
                {
                    bitmapResult = selectedSource.Laplacian3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5")
                {
                    bitmapResult = selectedSource.Laplacian5x5Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 Grayscale")
                {
                    bitmapResult = selectedSource.Laplacian5x5Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian of Gaussian")
                {
                    bitmapResult = selectedSource.LaplacianOfGaussianFilter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 of Gaussian 3x3")
                {
                    bitmapResult = selectedSource.Laplacian3x3OfGaussian3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 of Gaussian 5x5 - 1")
                {
                    bitmapResult = selectedSource.Laplacian3x3OfGaussian5x5Filter1();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 of Gaussian 5x5 - 2")
                {
                    bitmapResult = selectedSource.Laplacian3x3OfGaussian5x5Filter2();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 of Gaussian 3x3")
                {
                    bitmapResult = selectedSource.Laplacian5x5OfGaussian3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 of Gaussian 5x5 - 1")
                {
                    bitmapResult = selectedSource.Laplacian5x5OfGaussian5x5Filter1();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 of Gaussian 5x5 - 2")
                {
                    bitmapResult = selectedSource.Laplacian5x5OfGaussian5x5Filter2();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Sobel 3x3")
                {
                    bitmapResult = selectedSource.Sobel3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Sobel 3x3 Grayscale")
                {
                    bitmapResult = selectedSource.Sobel3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Prewitt")
                {
                    bitmapResult = selectedSource.PrewittFilter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Prewitt Grayscale")
                {
                    bitmapResult = selectedSource.PrewittFilter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Kirsch")
                {
                    bitmapResult = selectedSource.KirschFilter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Kirsch Grayscale")
                {
                    bitmapResult = selectedSource.KirschFilter();
                }
            }

            if (bitmapResult != null) // HAS TRANSFOR FINISHED
            {
                if (preview == true)
                {
                    DisplayWindow.Image = bitmapResult; // SET THE TRANSFORMED IMAGE DISPLAY BOX TO THE NEW IMAGE
                }
                else
                {
                    //resultBitmap = bitmapResult;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stillImage == false)
            {


                uEye.Defines.Status statusRet = 0;

                // Get last image memory
                Int32 s32LastMemId;
                Int32 s32Width;
                Int32 s32Height;
                statusRet = Camera.Memory.GetLast(out s32LastMemId);
                statusRet = Camera.Memory.Lock(s32LastMemId);
                statusRet = Camera.Memory.GetSize(s32LastMemId, out s32Width, out s32Height);


                //Camera.Display.Render(s32LastMemId, displayHandle2, uEye.Defines.DisplayRenderMode.FitToWindow);
                Bitmap MyBitmap;
                statusRet = Camera.Memory.ToBitmap(s32LastMemId, out MyBitmap);
                bLive = false;

                // clone bitmap
                Rectangle cloneRect = new Rectangle(0, 0, s32Width, s32Height);
                System.Drawing.Imaging.PixelFormat format = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
                cloneBitmap = MyBitmap.Clone(cloneRect, format);

                // unlock image buffer
                statusRet = Camera.Memory.Unlock(s32LastMemId);

                // text on Bitmap

                PointF firstLocation = new PointF(10f, 10f);
                // image on Bitmap

                PointF secondLocation = new PointF(10f, 120f);

                Camera.Exit();


                stillImage = true;
            }

            if (showScale1.Checked == true)
            {
               // previewBitmap = DisplayWindow.Image();


            }

            DisplayWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            DisplayWindow.Image = cloneBitmap; // SETS THE CAMERA FRAME IMAGE DISPLAY BOX WITH THE CAPTURE CAMERA FRAME

            Bitmap newImage = new Bitmap(DisplayWindow.Image); // CREATE NEW IMAGE FOR TRANSFORMING
            previewBitmap = newImage.CopyToSquareCanvas(DisplayWindow.Width); // SET THE DISPLAY BOX TO THE WIDTH OF THE NEW IMAGE
            DisplayWindow.Image = previewBitmap; // SET THE DISPLAY BOX WITH THE DESIRED IMAGE FOR TRANSFORMING

            ApplyFilter(true);
        }

        private void getBitmap()
        {
            if (stillImage == false)
            {


                uEye.Defines.Status statusRet = 0;

                // Get last image memory
                Int32 s32LastMemId;
                Int32 s32Width;
                Int32 s32Height;
                statusRet = Camera.Memory.GetLast(out s32LastMemId);
                statusRet = Camera.Memory.Lock(s32LastMemId);
                statusRet = Camera.Memory.GetSize(s32LastMemId, out s32Width, out s32Height);


                //Camera.Display.Render(s32LastMemId, displayHandle2, uEye.Defines.DisplayRenderMode.FitToWindow);
                Bitmap MyBitmap;
                statusRet = Camera.Memory.ToBitmap(s32LastMemId, out MyBitmap);
                bLive = false;

                // clone bitmap
                Rectangle cloneRect = new Rectangle(0, 0, s32Width, s32Height);
                System.Drawing.Imaging.PixelFormat format = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
                cloneBitmap = MyBitmap.Clone(cloneRect, format);

                // unlock image buffer
                statusRet = Camera.Memory.Unlock(s32LastMemId);

                // text on Bitmap

                PointF firstLocation = new PointF(10f, 10f);
                // image on Bitmap

                PointF secondLocation = new PointF(10f, 120f);

                Camera.Exit();


                stillImage = true;
            }

            DisplayWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            DisplayWindow.Image = cloneBitmap; // SETS THE CAMERA FRAME IMAGE DISPLAY BOX WITH THE CAPTURE CAMERA FRAME

            Bitmap newImage = new Bitmap(DisplayWindow.Image); // CREATE NEW IMAGE FOR TRANSFORMING
            previewBitmap = newImage.CopyToSquareCanvas(DisplayWindow.Width); // SET THE DISPLAY BOX TO THE WIDTH OF THE NEW IMAGE
            DisplayWindow.Image = previewBitmap; // SET THE DISPLAY BOX WITH THE DESIRED IMAGE FOR TRANSFORMING

            ApplyFilter(true);
        }
    

        private void camStart_Click(object sender, EventArgs e)
        {
            InitCamera();
            dragDistanceEnable.Checked = false;
            stillImage = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // VARIABLES USED
            calibrateMap = new Bitmap(DisplayWindow.Image);

            int maxHeight = calibrateMap.Height;
            int maxWidth = calibrateMap.Width - 1;
            int j = 0;
            int i = 0;
            int y = 0;
            int middlePixels = 0;
            int startPixel = 0;
            int count = 0;
            int countPixels = 0;
            float currentWhiteLevel = 0;
            float currentWhiteLevel1 = 0;

            bool foundLine = false;
            bool foundBlack = false;
            bool begin = false;
            bool onWhite = false;
            bool onBlack = false;



            Color pixelColor;
            Color pixelColor1;

            pixelColor1 = calibrateMap.GetPixel(maxWidth / 2, maxHeight / 2); // GET THE COLOUR OF THE CURRENT PIXEL IN RGB                   
            currentWhiteLevel1 = (pixelColor1.R + pixelColor1.G + pixelColor1.B) / 3; // GET THE CURRENT PIXEL WHITE LEVEL ONLY
            pixelCounts2.Items.Add(currentWhiteLevel1);

            if (currentWhiteLevel1 < 100)
            {
                y = maxHeight / 2;


                for (int x = maxWidth / 2; x < maxWidth; x++) // SCAN ACROSS EACH X PIXEL IN THE CURRENT Y ROW
                {
                    pixelColor = calibrateMap.GetPixel(x, y); // GET THE COLOUR OF THE CURRENT PIXEL IN RGB                   
                    currentWhiteLevel = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // GET THE CURRENT PIXEL WHITE LEVEL ONLY
                    count = count + 1;


                    if (currentWhiteLevel > 100)
                    {
                        foundLine = true;
                        j = x;
                        break;
                    }
                }
            }

            if (foundLine == true)
            {
                for (int x = j; x < maxWidth; x++) // SCAN ACROSS EACH X PIXEL IN THE CURRENT Y ROW
                {
                    pixelColor = calibrateMap.GetPixel(x, y); // GET THE COLOUR OF THE CURRENT PIXEL IN RGB                   
                    currentWhiteLevel = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // GET THE CURRENT PIXEL WHITE LEVEL ONLY
                    count = count + 1;

                    if (currentWhiteLevel < 100)
                    {
                        i = x;
                        foundLine = false;
                        foundBlack = true;
                        break;
                    }
                }
            }

            if (foundBlack == true)
            {
                for (int x = i; x < maxWidth; x++) // SCAN ACROSS EACH X PIXEL IN THE CURRENT Y ROW
                {
                    pixelColor = calibrateMap.GetPixel(x, y); // GET THE COLOUR OF THE CURRENT PIXEL IN RGB                   
                    currentWhiteLevel = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // GET THE CURRENT PIXEL WHITE LEVEL ONLY   
                                                                                          // count = count + 1;

                    if (currentWhiteLevel > 100)
                    {
                        startPixel = (maxWidth / 2) + count - (middlePixels / 2);
                        foundBlack = false;
                        begin = true;
                        break;
                    }

                    middlePixels = middlePixels + 1;
                }
            }

            if (begin == true)
            {

                pixelCounts.Items.Add(startPixel);
                for (int x = startPixel; x < maxWidth; x++) // SCAN ACROSS EACH X PIXEL IN THE CURRENT Y ROW
                {
                    pixelColor = calibrateMap.GetPixel(x, y); // GET THE COLOUR OF THE CURRENT PIXEL IN RGB                   
                    currentWhiteLevel = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // GET THE CURRENT PIXEL WHITE LEVEL ONLY             

                    if (currentWhiteLevel > 100)
                    {
                        j = x;
                        begin = false;
                        onWhite = true;
                        break;
                    }

                    calibrateMap.SetPixel(x, maxHeight / 2, Color.Red);
                    countPixels = countPixels + 1;
                }

            }

            if (onWhite == true)
            {
                for (int x = j; x < maxWidth; x++) // SCAN ACROSS EACH X PIXEL IN THE CURRENT Y ROW
                {
                    pixelColor = calibrateMap.GetPixel(x, y); // GET THE COLOUR OF THE CURRENT PIXEL IN RGB                   
                    currentWhiteLevel = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // GET THE CURRENT PIXEL WHITE LEVEL ONLY             

                    if (currentWhiteLevel < 100)
                    {
                        i = x;
                        onBlack = true;
                        onWhite = false;
                        break;
                    }

                    calibrateMap.SetPixel(x, maxHeight / 2, Color.Red);
                    countPixels = countPixels + 1;
                }


            }

            if (onBlack == true)
            {
                for (int x = i; x < maxWidth; x++) // SCAN ACROSS EACH X PIXEL IN THE CURRENT Y ROW
                {
                    pixelColor = calibrateMap.GetPixel(x, y); // GET THE COLOUR OF THE CURRENT PIXEL IN RGB                   
                    currentWhiteLevel = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // GET THE CURRENT PIXEL WHITE LEVEL ONLY             

                    if (currentWhiteLevel > 100)
                    {
                        j = x;
                        onWhite = true;
                        onBlack = false;
                        break;
                    }

                    calibrateMap.SetPixel(x, maxHeight / 2, Color.Red);
                    countPixels = countPixels + 1;
                }



            }

            if (onWhite == true)
            {
                for (int x = j; x < maxWidth; x++) // SCAN ACROSS EACH X PIXEL IN THE CURRENT Y ROW
                {
                    pixelColor = calibrateMap.GetPixel(x, y); // GET THE COLOUR OF THE CURRENT PIXEL IN RGB                   
                    currentWhiteLevel = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // GET THE CURRENT PIXEL WHITE LEVEL ONLY             

                    if (currentWhiteLevel < 100)
                    {
                        i = x;
                        break;
                    }

                    calibrateMap.SetPixel(x, maxHeight / 2, Color.Red);
                    countPixels = countPixels + 1;
                }
            }

            for (int x = i; x < i + (middlePixels / 2); x++) // SCAN ACROSS EACH X PIXEL IN THE CURRENT Y ROW
            {
                pixelColor = calibrateMap.GetPixel(x, y); // GET THE COLOUR OF THE CURRENT PIXEL IN RGB                   
                currentWhiteLevel = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // GET THE CURRENT PIXEL WHITE LEVEL ONLY             

                calibrateMap.SetPixel(x, maxHeight / 2, Color.Red);
                countPixels = countPixels + 1;
            }


            pixelCounts2.Items.Add(countPixels);

            countPixels = countPixels + (middlePixels / 2);


            DisplayWindow.Image = calibrateMap;

        }

        private void setScale_Click(object sender, EventArgs e)
        {
            calibrateMap = new Bitmap(DisplayWindow.Image);

            scaleBar.Width = 101;
            scaleBar.Height = 20;
        
            DisplayWindow.Image = calibrateMap;
        }


        private void showScale1_CheckedChanged(object sender, EventArgs e)
        {


            if (showScale1.Checked == true)
            {
              //getBitmap();
                scaleBar.Show();
                Scale.Text = "16um";
                Scale.Show();
              //stillImage = true;

              /*scaleBar2 = new Bitmap(DisplayWindow.Image);
                for (int y = 380; y < 405; y++) // SCAN ACROSS THE Y DIRECTION OF THE IMAGE
                {
                    for (int x = 450; x < 550; x++) // SCAN ACROSS EACH X PIXEL IN THE CURRENT Y ROW
                    {
                        scaleBar2.SetPixel(x, y, Color.Red);

                    }
                }*/

               // DisplayWindow.Image = scaleBar2;

            }

            if (showScale1.Checked == false)
            {
                scaleBar.Hide();
                Scale.Hide();
                InitCamera();
                dragDistanceEnable.Checked = false;
                stillImage = false;
            }
        }
        private void zoomSettings_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (zoomSettings.SelectedIndex == 0)
            {
                Scale.Text = "71 um";
                distancePerPixel = 0.71;
            }

            if (zoomSettings.SelectedIndex == 1)
            {
                Scale.Text = "43 um";
                distancePerPixel = 0.43;
            }

            if (zoomSettings.SelectedIndex == 2)
            {
                Scale.Text = "36 um";
                distancePerPixel = 0.36;
            }

            if (zoomSettings.SelectedIndex == 3)
            {
                Scale.Text = "23 um";
                distancePerPixel = 0.23;
            }

            if (zoomSettings.SelectedIndex == 4)
            {
                Scale.Text = "23 um";
                distancePerPixel = 0.23;
            }

            if (zoomSettings.SelectedIndex == 5)
            {
                Scale.Text = "14 um";
                distancePerPixel = 0.145;
            }

        }

        private void dragDistanceEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(dragDistanceEnable.Checked == true)
            {

                if (stillImage == false)
                {
                    uEye.Defines.Status statusRet = 0;

                    // Get last image memory
                    Int32 s32LastMemId;
                    Int32 s32Width;
                    Int32 s32Height;
                    statusRet = Camera.Memory.GetLast(out s32LastMemId);
                    statusRet = Camera.Memory.Lock(s32LastMemId);
                    statusRet = Camera.Memory.GetSize(s32LastMemId, out s32Width, out s32Height);


                    //Camera.Display.Render(s32LastMemId, displayHandle2, uEye.Defines.DisplayRenderMode.FitToWindow);
                    Bitmap MyBitmap;
                    statusRet = Camera.Memory.ToBitmap(s32LastMemId, out MyBitmap);
                    bLive = false;

                    // clone bitmap
                    Rectangle cloneRect = new Rectangle(0, 0, s32Width, s32Height);
                    System.Drawing.Imaging.PixelFormat format = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
                    cloneBitmap = MyBitmap.Clone(cloneRect, format);

                    // unlock image buffer
                    statusRet = Camera.Memory.Unlock(s32LastMemId);

                    // text on Bitmap

                    PointF firstLocation = new PointF(10f, 10f);
                    // image on Bitmap

                    PointF secondLocation = new PointF(10f, 120f);

                    Camera.Exit();

                    DisplayWindow.SizeMode = PictureBoxSizeMode.StretchImage;
                    DisplayWindow.Image = cloneBitmap; // SETS THE CAMERA FRAME IMAGE DISPLAY BOX WITH THE CAPTURE CAMERA FRAME

                    Bitmap newImage = new Bitmap(DisplayWindow.Image); // CREATE NEW IMAGE FOR TRANSFORMING

                    previewBitmap = newImage.CopyToSquareCanvas(DisplayWindow.Width); // SET THE DISPLAY BOX TO THE WIDTH OF THE NEW IMAGE
                    DisplayWindow.Image = previewBitmap; // SET THE DISPLAY BOX WITH THE DESIRED IMAGE FOR TRANSFORMING
                    stillImage = true;
                }
            }

            if (dragDistanceEnable.Checked == false)
            {
                InitCamera();
                stillImage = false;
            }

        }

        private void saveImage_Click(object sender, EventArgs e)
        {

            if (stillImage == false)
            {
                ApplyFilter(false);

                uEye.Defines.Status statusRet = 0;

                // Get last image memory
                Int32 s32LastMemId;
                Int32 s32Width;
                Int32 s32Height;
                statusRet = Camera.Memory.GetLast(out s32LastMemId);
                statusRet = Camera.Memory.Lock(s32LastMemId);
                statusRet = Camera.Memory.GetSize(s32LastMemId, out s32Width, out s32Height);


                //Camera.Display.Render(s32LastMemId, displayHandle2, uEye.Defines.DisplayRenderMode.FitToWindow);
                Bitmap MyBitmap;
                statusRet = Camera.Memory.ToBitmap(s32LastMemId, out MyBitmap);

                // clone bitmap
                Rectangle cloneRect = new Rectangle(0, 0, s32Width, s32Height);
                System.Drawing.Imaging.PixelFormat format = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
                cloneBitmap = MyBitmap.Clone(cloneRect, format);

                // unlock image buffer
                statusRet = Camera.Memory.Unlock(s32LastMemId);

                // text on Bitmap

                PointF firstLocation = new PointF(10f, 10f);
                // image on Bitmap

                PointF secondLocation = new PointF(10f, 120f);
            }

            if(stillImage == true)
            {
                cloneBitmap = new Bitmap(DisplayWindow.Image);
            }

            if (cloneBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog(); // OPEN FILE DIALOG FOR SAVE PATH
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
                sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png; // DEFAULT FILE EXTENSION IS .PNG. CAN BE CHANGED TO .BMP OR .JPEG

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp; // IMAGE FORMAT .BMP
                    }
                    else if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg; // IMAGE FORMAT .JPEG
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    cloneBitmap.Save(streamWriter.BaseStream, imgFormat); // SAVE IMAGE
                    streamWriter.Flush();
                    streamWriter.Close();

                    cloneBitmap = null; // DELETE OLD BITMAP USED FOR SAVING
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveStage2(0, 800, 0, 'R');
            moveStage1(0, 500, 0, 'L');
        }

        private void DisplayWindow_Click(object sender, EventArgs e)
        {

        }

        private void cmbEdgeDetection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


