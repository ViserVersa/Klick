using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;   // User.dll and import

namespace Klick
{
    public partial class Form1 : Form
    {
        public const UInt32 MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const UInt32 MOUSEEVENTF_LEFTUP = 0x0004;
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, uint dwExtraInf);
        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int Posx, int Posy);

        int Posx;
        int Posy;
        int PosxNext;
        int Loop;
       

        public Form1()
        {
            InitializeComponent(); 
        }
        
       
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Posx = int.Parse(txt_X.Text);
            Posy = int.Parse(txt_Y.Text);
            PosxNext = int.Parse(txt_LOOP.Text);

            Loop = int.Parse(txt_LOOP.Text);

            Loops();

            
              
        }
        private void Loops ()
        {
            
            while (true)
            {
                System.Threading.Thread.Sleep(350);
                SetCursorPos(Posx, Posy);
                System.Threading.Thread.Sleep(350);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(350);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(250);
                lbl_Update.Text = "Updated " + Posx + "  <X Y>  " + Posy;
                System.Threading.Thread.Sleep(250);
                Loop--;
                System.Threading.Thread.Sleep(250);
                Posx = (Posx + 35);

                System.Threading.Thread.Sleep(350);

                if (Loop == 0)
                    break;
            }

      

        }




    }
    
}
