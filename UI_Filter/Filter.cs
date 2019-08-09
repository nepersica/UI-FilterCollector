using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;    
using OpenCvSharp;              

namespace UI_Filter
{
    class Filter
    {
        Threshold th = new Threshold();
        

        public Filter()
        {
        }

        public Bitmap Applied_Filters(Data data)
        {

            Bitmap Applied_pic = (Bitmap)data.Get_Orgpic().Clone();
            Mat picture = OpenCvSharp.Extensions.BitmapConverter.ToMat(Applied_pic);
            
            List<string> list = data.Get_List();
            list.Sort();

            Mat result = Mat.Zeros(new OpenCvSharp.Size(picture.Cols, picture.Rows), MatType.CV_8UC3);

            foreach (string filter in list)
            {
                switch (filter)
                {
                    case "Canny":
                        picture = Canny(picture, result).Clone();
                        break;
                    case "Gaussian":
                        picture = Gaussian(picture, result).Clone();
                        break;
                    case "Sharpening":
                        picture = Sharpening(picture, result).Clone();
                        break;
                    case "Median":
                        picture = Median(picture, result).Clone();
                        break;
                    case "Sobel":
                        picture = Sobel(picture, result).Clone();
                        break;
                    case "Laplacian":
                        picture = Laplacian(picture, result).Clone();
                        break;
                    case "Flip":
                        picture = Flip(picture, result).Clone();
                        break;
                }
            }
            Applied_pic = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(picture);
            return Applied_pic;
        }

        public void Control_Threshold()
        {
            th.ShowDialog();

        }

        private Mat Canny(Mat picture, Mat result)
        {
            Data_th th_data = th.Get_Data();
            Cv2.Canny(picture, result, th_data.Get_Cth1(), th_data.Get_Cth2());    // 임계값 1이하에 포함되는 가장자리는 제외, 2이상 포함되는 가장자리는 가장자리로 간주.
            return result;
        }

        private Mat Gaussian(Mat picture, Mat result)
        {
            Data_th th_data = th.Get_Data();
            Cv2.GaussianBlur(picture, result, new OpenCvSharp.Size(th_data.Get_Gkernel(), th_data.Get_Gkernel()), 1);   // sigma: 흐려지는 정도
            return result;
        }

        private Mat Sharpening(Mat picture, Mat result)
        {
            Data_th th_data = th.Get_Data();
            Mat tmp = Mat.Zeros(new OpenCvSharp.Size(picture.Cols, picture.Rows), MatType.CV_8UC3);
            Cv2.GaussianBlur(picture, tmp, new OpenCvSharp.Size(9, 9), th_data.Get_Shsigma());
            Cv2.AddWeighted(picture, th_data.Get_Shth1(), tmp, -th_data.GetShth2(), 7.5, result);
            return result;
        }

        private Mat Median(Mat picture, Mat result)
        {
            Data_th th_data = th.Get_Data();
            Cv2.MedianBlur(picture, result, th_data.Get_Gkernel());
            return result;
        }

        private Mat Sobel(Mat picture, Mat result)
        {
            Data_th th_data = th.Get_Data();
            if (picture.Channels() != 1)
                Cv2.CvtColor(picture, picture, ColorConversionCodes.BGR2GRAY);
            Cv2.Sobel(picture, result, MatType.CV_8U, th_data.Get_Sbx(), th_data.Get_Sby());
            return result;
        }

        private Mat Laplacian(Mat picture, Mat result)
        {
            Cv2.Laplacian(picture, result, MatType.CV_8U);
            return result;
        }

        private Mat Flip(Mat picture, Mat result)
        {
            Cv2.Flip(picture, result, FlipMode.Y);
            return result;
        }

    }
}
