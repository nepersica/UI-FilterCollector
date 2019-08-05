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
    class Applying
    {
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
                        Cv2.Canny(picture, result, 50, 150);
                        picture = result.Clone();
                        break;
                    case "Gaussian":
                        Cv2.GaussianBlur(picture, result, new OpenCvSharp.Size(9,9),1);
                        picture = result.Clone();
                        break;
                    case "Sharpening":
                        Mat tmp = Mat.Zeros(new OpenCvSharp.Size(picture.Cols, picture.Rows), MatType.CV_8UC3);
                        Cv2.GaussianBlur(picture, tmp, new OpenCvSharp.Size(9, 9), 1);
                        Cv2.AddWeighted(picture, 1.5, tmp, -0.5, 7.5, result);
                        picture = result.Clone();
                        break;
                    case "Median":
                        Cv2.MedianBlur(picture, result, 3);
                        picture = result.Clone();
                        break;
                    case "Sobel":
                        if(picture.Channels()!=1)
                            Cv2.CvtColor(picture, picture, ColorConversionCodes.BGR2GRAY);
                        Cv2.Sobel(picture, result, MatType.CV_8U, 0, 1);
                        picture = result.Clone();
                        break;
                    case "Laplacian":
                        Cv2.Laplacian(picture, result, MatType.CV_8U);
                        picture = result.Clone();
                        break;
                    case "Flip":
                        Cv2.Flip(picture, result, FlipMode.Y);
                        picture = result.Clone();
                        break;
                }
            }
            Applied_pic = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(picture);
            return Applied_pic;
        }
    }
    
}
