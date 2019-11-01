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
    class Data
    {
        Bitmap org_picture; Bitmap applied_picture;
        List<string> list = new List<string>();

        public void Set_Orgpic(Bitmap picture)
        {
            this.org_picture = picture;
        }

        public Bitmap Get_Orgpic()
        {
            return org_picture;
        }

        public bool IsOrgpicNull()
        {
            if (Get_Orgpic() == null)
            {
                MessageBox.Show("   사진을 먼저 선택해 주세요!   ");
                return true;
            }
            else
                return false;
        }

        public void Set_Aplpic(Bitmap picture)
        {
            this.applied_picture = picture;
        }

        public Bitmap Get_Aplpic()
        {
            return applied_picture;
        }

        public void Add_Item(string item)
        {
            list.Add(item);
        }

        public void Trash_Item(string item)
        {
            list.Remove(item);
        }

        public List<string> Get_List()
        {
            return list;
        }

        public void Init_List()
        {
            list.Clear();
            WriteLine("No Items");
        }

        public void Print_List()
        {
            list.ForEach(Console.WriteLine);
        }


    }
}

//namespace UI_Filter
//{
//    interface Data<T>
//    {
//        void add(T book);

//        void delete();

//        T get();
//    }

 
//    class List : Data<string>
//    {
//        string book;
//        public void add(string book)
//        {
//            this.book = book;
//        }

//        public void delete()
//        {
//            this.book = default(string);
//        }

//        public string get()
//        {
//            return this.book;
//        }
//    }

//    class Image : Data<Bitmap>
//    {
//        Bitmap img;
//        public void add(Bitmap img)
//        {
//            this.img = img;
//        }

//        public void delete()
//        {
//            this.img = default(Bitmap);
//        }

//        public Bitmap get()
//        {
//            return this.img;
//        }
//    }    
//}

