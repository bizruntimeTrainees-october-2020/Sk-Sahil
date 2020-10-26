using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private async void buttton1_click(object sender, EventArgs e)
        {
            label1.Text = "please wait...";

            int num = await MyLongFunctionAsync();
            label1.Text = num.ToString();


        }

        Task<int> MyLongFunctionAsync()
        {

            //creating task
            Task<int> task = new Task<int>(
             () =>
             {
                 Thread.Sleep(3000);
                 Random random = new Random();
                 int num = random.Next(1, 10);
                 return num;
             });
            task.Start();  //start it

            return task;   //returning it

        }





        // without async 


        //private void buttton1_click(object sender, EventArgs e)
        //{
        //    label1.Text = "please wait...";

        //    int num = myLonFunction();
        //    label1.Text = num.ToString();


        //}
        int myLonFunction()
        {
            Thread.Sleep(3000);
            Random random = new Random();
            int num = random.Next(1, 10);
            return num;
        }
    }
}
