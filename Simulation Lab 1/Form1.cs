using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_Lab_1
{
    public partial class Simulation1 : Form
    {
        public Simulation1()
        {
            InitializeComponent();
        }

        double height;
        double angle;
        double speed;
        double size;
        double weight;
        double stepTime;
        double x;
        double y;
        double vx;
        double vy;
        double cosa;
        double sina;
        double beta;
        double k;
        double maxY = 0;
        int i = 0;
        int m = 0;

        // const double stepTime = (double)numberStep.Value;
        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Вычисления -> Проверка -> Решение -> Переход

            stepTime = (double)numberStep.Value; // Шаг
            height = (double)numberHeight.Value;
            angle = (double)numberAngle.Value;
            speed = (double)numberSpeed.Value;
            size = (double)numberSize.Value;
            weight = (double)numberWeight.Value;

            // Вычисления
            cosa = Math.Cos(angle * Math.PI / 180);
            sina = Math.Sin(angle * Math.PI / 180);

            beta = 0.5 * C * size * rho;
            k = beta/weight;

            x = 0;
            y = height;
            vx = speed * cosa;
            vy = speed * sina;

            // Проверка
            if (dataGrid.Rows.Count == 5) { dataGrid.Rows.RemoveAt(0); chart1.Series[i].Points.Clear(); };

            // Решение (запись в таблицу + построение графика)
            timer1.Start(); // Построение графика
            dataGrid.Rows.Add(chart1.Series[i].Name, stepTime, "", "", "", height, angle, speed, size, weight ); // Построение графика
            //maxY = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = (int)numberInterval.Value;
            
            double root = Math.Sqrt(vx * vx + vy * vy);

            vx = vx - k * vx * root * stepTime;
            vy = vy - (g + k * vy * root) * stepTime;

            x = x + vx * stepTime;
            y = y + vy * stepTime;

            if (y > maxY) maxY = y;

            chart1.Series[i].Points.AddXY(x, y);

            // Переход
            if (y <= 0) 
            { 
                timer1.Stop();

                m = dataGrid.Rows.Count;
                dataGrid.Rows[m - 1].Cells[2].Value = x;
                dataGrid.Rows[m - 1].Cells[3].Value = maxY;
                dataGrid.Rows[m - 1].Cells[4].Value = Math.Sqrt(vx * vx + vy * vy);

                if (i < 4) 
                { 
                    i += 1; 
                } 
                else 
                { 
                    i = 0; 
                }

                maxY = 0;
            };
        }
    }
}
