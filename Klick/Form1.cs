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
    public partial class Klick : Form
    {

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, uint dwExtraInf);
       
        [DllImport("user32.dll")]
        
        private static extern bool SetCursorPos(int Posx, int Posy);
        
        public const UInt32 MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const UInt32 MOUSEEVENTF_LEFTUP = 0x0004;

        DataTable dt = new DataTable();

        int Posx,Posy,Loop,Movex,Movey;

        private void btn_Search_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);

            for (int i = 1;  i <= int.Parse(txt_SearchLoop.Text); i++)
            {

                int PosX = Convert.ToInt32(Cursor.Position.X.ToString());
                int PosY = Convert.ToInt32(Cursor.Position.Y.ToString());

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(PosX + " " + PosY);

                DataRow dr = dt.NewRow();
                dr[0] = PosX;
                dr[1] = PosY;
                dt.Rows.Add(dr);

            }
        }

        private void Klick_Load(object sender, EventArgs e)
        {

            dt.Columns.Add("xCord"); 
            dt.Columns.Add("yCord");
            dtDataGridView.DataSource = dt;
        }

        private void btn_Square_Click(object sender, EventArgs e)
        {
            GetText();

        }

        public Klick()
        {
            InitializeComponent();
        }
        
       
        private void btn_Update_Click(object sender, EventArgs e)
        {
            GetText();
            Loops();

        }
        private void Loops ()
        {
            while (true)
            { 
                SetCur();
                Loop--;
                Posx += Movex;
                Posy += Movey;
                txt_X_OLD.Text = Posx.ToString();
                txt_Y_OLD.Text = Posy.ToString();

                
                if (Loop == 0)
                    break;
            }
        }
        private void SetCur()
        {
            SetCursorPos(Posx, Posy);

            System.Threading.Thread.Sleep(1100);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            System.Threading.Thread.Sleep(20);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            System.Threading.Thread.Sleep(1100);
        }   

        private void GetText ()
        {
            Posx = int.Parse(txt_X.Text);
            Posy = int.Parse(txt_Y.Text);
            Loop = int.Parse(txt_LOOP.Text);
            Movex = int.Parse(txt_Xmove.Text);
            Movey = int.Parse(txt_Ymove.Text);
        }
    } 
}
