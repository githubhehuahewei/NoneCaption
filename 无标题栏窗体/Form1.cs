using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace 无标题栏窗体
{
   
 
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                if(e.Y<30)
                { 
                //这里一定要判断鼠标左键按下状态，否则会出现一个很奇葩的BUG，不信邪可以试一下~~
                    ReleaseCapture();
                    SendMessage(Handle, 0x00A1, 2, 0);
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
