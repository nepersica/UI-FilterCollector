using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Filter
{
    public class Data_th
    {
        int canny_th1 = 50; int canny_th2 = 150;
        int gauss_kernel = 9; int gauss_sigma = 1;
        int sharp_sigma = 1; double sharp_th1 = 1.5; double sharp_th2 = 0.5;
        int med_kernel = 3;
        int sobel_x = 0; int sobel_y= 1;
        
        public void Initialize()
        {
            canny_th1 = 50; canny_th2 = 150;
            gauss_kernel = 9;   gauss_sigma = 1;
            sharp_sigma = 1;    sharp_th1 = 1.5;    sharp_th2 = -0.5;
            med_kernel = 3;
            sobel_x = 0;    sobel_y = 1;
        }

        public void Set_Cth1(int th1)
        {
            this.canny_th1 = th1;
        }
        public void Set_Cth2(int th2)
        {
            this.canny_th2 = th2;
        }
        public int Get_Cth1()
        {
            return this.canny_th1;
        }
        public int Get_Cth2()
        {
            return this.canny_th2;
        }
        
        public void Set_Gkernel(int kernel)
        {
            this.gauss_kernel = kernel;
        }
        public void Set_Gsigma(int sigma)
        {
            this.gauss_sigma = sigma;
        }
        public int Get_Gkernel()
        {
            return this.gauss_kernel;
        }
        public int Get_Gsigma()
        {
            return this.gauss_sigma;
        }
        
        public void Set_Shsigma(int sigma)
        {
            this.sharp_sigma = sigma;
        }
        public void Set_Shth1(double th1)
        {
            this.sharp_th1 = th1;
        }
        public void Set_Shth2(double th2)
        {
            this.sharp_th2 = th2;
        }
        public int Get_Shsigma()
        {
            return this.sharp_sigma;
        }
        public double Get_Shth1()
        {
            return this.sharp_th1;
        }
        public double GetShth2()
        {
            return this.sharp_th2;
        }

        public void Set_Mth(int kernel)
        {
            this.med_kernel = kernel;
        }
        public int Get_Mth()
        {
            return this.med_kernel;
        }

        public void Set_Sbx(int x)
        {
            this.sobel_x = x;
        }
        public void Set_Sby(int y)
        {
            this.sobel_y = y;
        }
        public int Get_Sbx()
        {
            return this.sobel_x;
        }
        public int Get_Sby()
        {
            return this.sobel_y;
        }

        

    }
}
