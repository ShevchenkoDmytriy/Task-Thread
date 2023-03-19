using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Thread2
{

    public  partial class MainWindow : Window
    {
        Random random = new Random();   
        int[] mass;
        public  MainWindow()
        {
            InitializeComponent();
            Task[] tasks1 = new Task[3]
            {
    new Task(() =>  PrintW()),
    new Task(() => PrintN()),
    new Task(() => PrintS())
            };
            foreach (var t in tasks1)
                t.Start();
        }
        void PrintW()
        {
            mass=new int[15];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(30);
                lab1.Content += $"{mass[i]} ";
            }

        }
        void PrintN()
        {
            string s = "";
            for (int i = 0; i <20; i++)
            {
                s+= (char)(random.Next(1040, 1104));
            }
            lab1.Content += $"\n{s} ";
        }
        void PrintS()
        {

        }
    }
}
