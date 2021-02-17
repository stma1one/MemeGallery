using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyNewApp
{
    public partial class MainPage : ContentPage
    {
       private int pos;
        private List<string> ls;
        private string imgDefault;

        public MainPage()
        {
            InitializeComponent();
            ls = new List<string>();
            imgDefault = "https://scontent.fsdv1-2.fna.fbcdn.net/v/t1.0-0/s526x395/12189549_1677535729157321_8663535178654075247_n.jpg?_nc_cat=100&ccb=3&_nc_sid=09cbfe&_nc_ohc=vvB4Q45ILd8AX8PfdC_&_nc_ht=scontent.fsdv1-2.fna&tp=7&oh=465d7d32b12e389f04bea59ddb80bf9c&oe=605247C5";
            imgCurr.Source = imgDefault;

            //usually the image sources will be loaded from the Database....
            ls.Add("https://scontent.fsdv1-2.fna.fbcdn.net/v/t1.0-9/14907158_1821472054763687_8606339119556360229_n.jpg?_nc_cat=103&ccb=3&_nc_sid=9267fe&_nc_ohc=dtRLOSaQjhYAX87TiCF&_nc_ht=scontent.fsdv1-2.fna&oh=84a30aa1daa41caecdd7b7f7e0b286dd&oe=6052ABCC");
            ls.Add("https://scontent.fsdv1-2.fna.fbcdn.net/v/t1.0-9/27868144_2070127203231503_5039999664905074855_n.jpg?_nc_cat=105&ccb=3&_nc_sid=8bfeb9&_nc_ohc=tBTht7R0n0EAX8dORlB&_nc_ht=scontent.fsdv1-2.fna&oh=ecb39752a0d0a6d4b0bb8e4d24d3d0c8&oe=6051EA47");
            ls.Add("https://i.imgflip.com/hpgmp.jpg");
        }

        private void BtnUp_Clicked(object sender, EventArgs e)
        {
            
           
            if (pos < ls.Count)
            {
                

                    btnDown.IsEnabled = true;
                    btnDown.BackgroundColor = btnUp.BackgroundColor;
                    imgCurr.Source = ls[pos];
                    pos++;

                
                
            }


            if (pos == ls.Count)
            {
                Button b = (Button)sender;
                b.IsEnabled = false;
                b.BackgroundColor = Color.DimGray;
                pos--;

                
            }
            
        }

        private void BtnDown_Clicked(object sender, EventArgs e)
        {
            
            if (pos > 0)
            {
                pos--;
                btnUp.IsEnabled = true;
                btnUp.BackgroundColor = btnDown.BackgroundColor;
                imgCurr.Source = ls[pos];
                


            }


           else
            {
                Button b = (Button)sender;
                b.IsEnabled = false;
                b.BackgroundColor = Color.DimGray;
               imgCurr.Source = imgDefault;
               
                               
            }
        }
    }
}
