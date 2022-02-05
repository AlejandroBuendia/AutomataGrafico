using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Automata_Grafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int time = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen lapiz= new Pen(Color.Black,3);

            //Circulo q0
            Rectangle q0 = new Rectangle(100, 100, 100, 100);
            g.DrawEllipse(lapiz,q0);
            //a
            g.DrawLine(lapiz, 200, 150, 300, 150);
            g.DrawLine(lapiz, 290, 140, 300, 150);
            g.DrawLine(lapiz, 290, 160, 300, 150);
            //bc
            g.DrawLine(lapiz, 150, 200, 150, 300);
            g.DrawLine(lapiz, 140, 290, 150, 300);
            g.DrawLine(lapiz, 160, 290, 150, 300);

            //Circulo q1
            Rectangle q1 = new Rectangle(300, 100, 100, 100);
            g.DrawEllipse(lapiz, q1);
            //a
            g.DrawLine(lapiz, 350, 200, 500, 350);
            g.DrawLine(lapiz, 490, 360, 500, 350);
            g.DrawLine(lapiz, 495, 335, 500, 350);
            //b
            Rectangle b1 = new Rectangle(330,52, 50, 100);
            g.DrawArc(lapiz, b1, 180, 190);
            g.DrawLine(lapiz, 380, 110, 395, 95);
            g.DrawLine(lapiz, 380, 110, 365, 95);
            //c
            g.DrawLine(lapiz, 400, 150, 500, 150);
            g.DrawLine(lapiz, 490, 140, 500, 150);
            g.DrawLine(lapiz, 490, 160, 500, 150);

            //Circulo q2
            Rectangle q2 = new Rectangle(500, 100, 100, 100);
            g.DrawEllipse(lapiz, q2);
            //a
            g.DrawLine(lapiz, 600, 150, 750, 200);
            g.DrawLine(lapiz, 730, 200, 750, 200);
            g.DrawLine(lapiz, 750, 185, 750, 200);
            //bc
            Rectangle bc2 = new Rectangle(530, 52, 50, 100);
            g.DrawArc(lapiz, bc2, 180, 190);
            g.DrawLine(lapiz, 580, 110, 595, 95);
            g.DrawLine(lapiz, 580, 110, 565, 95);
            //Circulo q3
            Rectangle q3 = new Rectangle(100, 300, 100, 100);
            g.DrawEllipse(lapiz, q3);
            //abc
            Rectangle abc3 = new Rectangle(152, 328, 100, 50);
            g.DrawArc(lapiz, abc3, 260, 210);
            g.DrawLine(lapiz, 198, 328, 210, 320);
            g.DrawLine(lapiz, 198, 328, 210, 335);
            //Circulo q4
            Rectangle q4 = new Rectangle(500, 300, 100, 100);
            g.DrawEllipse(lapiz, q4);
            //a
            g.DrawLine(lapiz, 550, 300, 385, 185);
            g.DrawLine(lapiz, 400, 185, 385, 185);
            g.DrawLine(lapiz, 385, 200, 385, 185);
            //b
            g.DrawLine(lapiz, 590, 325, 700, 250);
            g.DrawLine(lapiz, 685, 240, 700, 250);
            g.DrawLine(lapiz, 695, 270, 700, 250);
            //c
            Rectangle c4 = new Rectangle(522, 345, 50, 100);
            g.DrawArc(lapiz, c4, 360, 180);
            g.DrawLine(lapiz, 522, 395, 510, 410);
            g.DrawLine(lapiz, 522, 395, 535, 410);
            //Circulo q5
            Rectangle q5 = new Rectangle(700, 200, 100, 100);
            g.DrawEllipse(lapiz, q5);
            Rectangle q51 = new Rectangle(710, 210, 80, 80);
            g.DrawEllipse(lapiz, q51);
            //ab
            Rectangle ab5 = new Rectangle(745, 230, 100, 50);
            g.DrawArc(lapiz, ab5, 270, 190);
            g.DrawLine(lapiz, 790, 280, 805, 270);
            g.DrawLine(lapiz, 790, 280, 805, 290);
            //c
            g.DrawLine(lapiz, 750, 300, 600, 350);
            g.DrawLine(lapiz, 610, 335, 600, 350);
            g.DrawLine(lapiz, 615, 360, 600, 350);
        }

        public void l0(char a)
        {
            Graphics g = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Red, 3);

            switch (a)
            {
                case 'a':
                    for (int i = 0; i < 2; i++)
                    {
                        //a
                        g.DrawLine(lapiz, 200, 150, 300, 150);
                        g.DrawLine(lapiz, 290, 140, 300, 150);
                        g.DrawLine(lapiz, 290, 160, 300, 150);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }
                    break;
                case 'b':
                    for (int i = 0; i < 2; i++)
                    {
                        g.DrawLine(lapiz, 150, 200, 150, 300);
                        g.DrawLine(lapiz, 140, 290, 150, 300);
                        g.DrawLine(lapiz, 160, 290, 150, 300);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }

                    break;
                case 'c':
                    for (int i = 0; i < 2; i++)
                    {
                        g.DrawLine(lapiz, 150, 200, 150, 300);
                        g.DrawLine(lapiz, 140, 290, 150, 300);
                        g.DrawLine(lapiz, 160, 290, 150, 300);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }
                    break;
            }
        }
   
        public void l1(char a)
        {
            Graphics g = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Red, 3);
            switch (a)
            {
                case 'a' :
                    for (int i = 0; i < 2; i++)
                    {
                        //a
                        g.DrawLine(lapiz, 350, 200, 500, 350);
                        g.DrawLine(lapiz, 490, 360, 500, 350);
                        g.DrawLine(lapiz, 495, 335, 500, 350);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }
                    break;
                case 'b' :
                    for (int i = 0; i < 2; i++)
                    {
                                Rectangle b1 = new Rectangle(330,52, 50, 100);
                                g.DrawArc(lapiz, b1, 180, 190);
                                g.DrawLine(lapiz, 380, 110, 395, 95);
                                g.DrawLine(lapiz, 380, 110, 365, 95);
                                Thread.Sleep(time);
                                lapiz = new Pen(Color.Black, 3);
                    }
                    break;
                case 'c' :
                    for (int i = 0; i < 2; i++)
                    {

                        g.DrawLine(lapiz, 400, 150, 500, 150);
                        g.DrawLine(lapiz, 490, 140, 500, 150);
                        g.DrawLine(lapiz, 490, 160, 500, 150);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }
                    break;
            }

        }

        public void l2(char a)
        {
            Graphics g = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Red, 3);
            switch (a)
            {
                case 'a':
                    for (int i = 0; i < 2; i++)
                    {
                        //a
                        g.DrawLine(lapiz, 600, 150, 750, 200);
                        g.DrawLine(lapiz, 730, 200, 750, 200);
                        g.DrawLine(lapiz, 750, 185, 750, 200);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }
                    break;
                case 'b':
                    for (int i = 0; i < 2; i++)
                    {
                        //b
                                Rectangle bc2 = new Rectangle(530, 52, 50, 100);
                                g.DrawArc(lapiz, bc2, 180, 190);
                                g.DrawLine(lapiz, 580, 110, 595, 95);
                                g.DrawLine(lapiz, 580, 110, 565, 95);
                                Thread.Sleep(time);
                                lapiz = new Pen(Color.Black, 3);
                    }
                    break;
                case 'c':
                    for (int i = 0; i < 2; i++)
                    {
                        //c
                        Rectangle bc2 = new Rectangle(530, 52, 50, 100);
                        g.DrawArc(lapiz, bc2, 180, 190);
                        g.DrawLine(lapiz, 580, 110, 595, 95);
                        g.DrawLine(lapiz, 580, 110, 565, 95);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }

                    break;
            }
        }

        public void l3(char a)
        {
            Graphics g = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Red, 3);
     
            switch (a)
            {
                case 'a':
                    for (int i = 0; i < 2; i++)
                    {
                        //a
                        Rectangle abc3 = new Rectangle(152, 328, 100, 50);
                        g.DrawArc(lapiz, abc3, 260, 210);
                        g.DrawLine(lapiz, 198, 328, 210, 320);
                        g.DrawLine(lapiz, 198, 328, 210, 335);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }
                    break;
                case 'b':
                    for (int i = 0; i < 2; i++)
                    {
                        //b
                        Rectangle abc3 = new Rectangle(152, 328, 100, 50);
                        g.DrawArc(lapiz, abc3, 260, 210);
                        g.DrawLine(lapiz, 198, 328, 210, 320);
                        g.DrawLine(lapiz, 198, 328, 210, 335);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }
                    break;
                case 'c':
                    for (int i = 0; i < 2; i++)
                    {
                        //c
                        Rectangle abc3 = new Rectangle(152, 328, 100, 50);
                        g.DrawArc(lapiz, abc3, 260, 210);
                        g.DrawLine(lapiz, 198, 328, 210, 320);
                        g.DrawLine(lapiz, 198, 328, 210, 335);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }
                    break;
            }
        }

        public void l4(char a)
        {
            Graphics g = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Red, 3);
     
            switch (a)
            {
                case 'a':
                    for (int i = 0; i < 2; i++)
                    {
                        //a
                        g.DrawLine(lapiz, 550, 300, 385, 185);
                        g.DrawLine(lapiz, 400, 185, 385, 185);
                        g.DrawLine(lapiz, 385, 200, 385, 185);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }
                    break;
                case 'b':
                    for (int i = 0; i < 2; i++)
                    {
                        g.DrawLine(lapiz, 590, 325, 700, 250);
                        g.DrawLine(lapiz, 685, 240, 700, 250);
                        g.DrawLine(lapiz, 695, 270, 700, 250);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }
                    break;
                case 'c':
                    for (int i = 0; i < 2; i++)
                    {
                                Rectangle c4 = new Rectangle(522, 345, 50, 100);
                                g.DrawArc(lapiz, c4, 360, 180);
                                g.DrawLine(lapiz, 522, 395, 510, 410);
                                g.DrawLine(lapiz, 522, 395, 535, 410);
                                Thread.Sleep(time);
                                lapiz = new Pen(Color.Black, 3);
                    }
                    break;
            }
        }

        public void l5(char a)
        {
            Graphics g = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Red, 3);
            switch (a)
            {
                case 'a':
                    for (int i = 0; i < 2; i++)
                    {
                        //a
                        Rectangle ab5 = new Rectangle(745, 230, 100, 50);
                        g.DrawArc(lapiz, ab5, 270, 190);
                        g.DrawLine(lapiz, 790, 280, 805, 270);
                        g.DrawLine(lapiz, 790, 280, 805, 290);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }
                    break;
                case 'b':
                    for (int i = 0; i < 2; i++)
                    {
                        //b
                        Rectangle ab5 = new Rectangle(745, 230, 100, 50);
                        g.DrawArc(lapiz, ab5, 270, 190);
                        g.DrawLine(lapiz, 790, 280, 805, 270);
                        g.DrawLine(lapiz, 790, 280, 805, 290);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }
                    break;
                case 'c':
                    for (int i = 0; i < 2; i++)
                    {
                        //c
                        g.DrawLine(lapiz, 750, 300, 600, 350);
                        g.DrawLine(lapiz, 610, 335, 600, 350);
                        g.DrawLine(lapiz, 615, 360, 600, 350);
                        Thread.Sleep(time);
                        lapiz = new Pen(Color.Black, 3);
                    }
                    break;
            }
        }

        public void p0() {
            Graphics g = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Red, 3);
            for (int i = 0; i < 2; i++)
            {
                Rectangle q0 = new Rectangle(100, 100, 100, 100);
                g.DrawEllipse(lapiz, q0);
                Thread.Sleep(time);
                lapiz = new Pen(Color.Black, 3);
            }
        }

        public void p1()
        {
            Graphics g = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Red, 3);
            for (int i = 0; i < 2; i++)
            {
                Rectangle q1 = new Rectangle(300, 100, 100, 100);
                g.DrawEllipse(lapiz, q1);
                Thread.Sleep(time);
                lapiz = new Pen(Color.Black, 3);
            }
        }

        public void p2()
        {
            Graphics g = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Red, 3);
            for (int i = 0; i < 2; i++)
            {
                Rectangle q2 = new Rectangle(500, 100, 100, 100);
                g.DrawEllipse(lapiz, q2);
                Thread.Sleep(time);
                lapiz = new Pen(Color.Black, 3);
            }
        }

        public void p3()
        {
            Graphics g = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Red, 3);
            for (int i = 0; i < 2; i++)
            {
                Rectangle q3 = new Rectangle(100, 300, 100, 100);
                g.DrawEllipse(lapiz, q3);
                Thread.Sleep(time);
                lapiz = new Pen(Color.Black, 3);
            }
        }

        public void p4()
        {
            Graphics g = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Red, 3);
            for (int i = 0; i < 2; i++)
            {
                Rectangle q4 = new Rectangle(500, 300, 100, 100);
                g.DrawEllipse(lapiz, q4);
                Thread.Sleep(time);
                lapiz = new Pen(Color.Black, 3);
            }
        }

        public void p5()
        {
            Graphics g = this.CreateGraphics();
            Pen lapiz = new Pen(Color.Red, 3);
            for (int i = 0; i < 2; i++)
            {
                Rectangle q5 = new Rectangle(700, 200, 100, 100);
                g.DrawEllipse(lapiz, q5);
                Rectangle q51 = new Rectangle(710, 210, 80, 80);
                g.DrawEllipse(lapiz, q51);
                Thread.Sleep(time);
                lapiz = new Pen(Color.Black, 3);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            time = 1000;
            String cadena;
            cadena = TB1.Text;


            int y;
            int[,] b ={
            { 1, 4, 5, 3, 1, 5},
            { 3, 1, 2, 3, 5, 5},
            { 3, 2, 2, 3, 4, 4}};
            
            char[] a = cadena.ToArray();

            //Validar abc
            Boolean Validar = true;
            for (int i=0;i<a.Length;i++) {
                if (a[i] != 'a') {
                    if (a[i] != 'b') {
                        if (a[i] != 'c') {
                            Validar = false;
                        }
                    }
                }
            }

            if (Validar == true)
            {
                L1.Text = "Comprobando " + cadena;
                int j = 0, k = 0;

                for (int i = 0; i < cadena.Length; i++)
                {
                    int temp = 0;
                    switch (a[i])
                    {
                        case 'a':
                            k = 0;
                            break;
                        case 'b':
                            k = 1;
                            break;
                        case 'c':
                            k = 2;
                            break;
                    }

                    switch (j)
                    {
                        case 0:
                            l0(a[i]);
                            break;
                        case 1:
                            l1(a[i]);
                            break;
                        case 2:
                            l2(a[i]);
                            break;
                        case 3:
                            l3(a[i]);
                            break;
                        case 4:
                            l4(a[i]);
                            break;
                        case 5:
                            l5(a[i]);
                            break;
                    }
                    temp = b[k, j];
                    j = temp;

                }

                switch (j)
                {
                    case 0:
                        p0();
                        L1.Text = ("Cadena ")+cadena+(" no aceptada");
                        break;

                    case 1:
                        p1();
                        L1.Text = ("Cadena ") + cadena + (" no aceptada");
                        break;

                    case 2:
                        p2();
                        L1.Text = ("Cadena ") + cadena + (" no aceptada");
                        break;
                    case 3:
                        p3();
                        L1.Text = ("Cadena ") + cadena + (" no aceptada");
                        break;
                    case 4:
                        p4();
                        L1.Text = ("Cadena ") + cadena + (" no aceptada");
                        break;
                    case 5:
                        p5();
                        L1.Text = ("Cadena ") + cadena + (" aceptada");
                        break;
                }
            }
            else {
                L1.Text = "Caracteres No Validos";
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void L1_Click(object sender, EventArgs e)
        {

        }
    }
}
