using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoang_815
{
    public partial class Form2 : Form
    {
        private bool isDrawing = false;
        private Point lastPoint = Point.Empty;
        private Color currentColor = Color.Black;
        private int penWidth = 1;
        private List<Point> points = new List<Point>();
        public Form2()
        {
            InitializeComponent();
            panel1.BackColor = Color.White;
            comboBox1.SelectedIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            penWidth = int.Parse(comboBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isDrawing = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentColor = panel1.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            points.Clear();
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                using (Pen pen = new Pen(currentColor, penWidth))
                {
                    for (int i = 1; i < points.Count; i++)
                    {
                        g.DrawLine(pen, points[i - 1], points[i]);
                    }
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                points.Add(e.Location);
                panel1.Invalidate(); // Yêu cầu Panel vẽ lại
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
        private void LoadDrawing(string filePath)
        {
            if (File.Exists(filePath))
            {
                points.Clear();
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] coordinates = line.Split(',');
                    int x = int.Parse(coordinates[0]);
                    int y = int.Parse(coordinates[1]);
                    points.Add(new Point(x, y));
                }
                panel1.Refresh();
            }
            else
            {
                MessageBox.Show("File không tồn tại.");
            }
        }
        private void SaveDrawing(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Point point in points)
                {
                    writer.WriteLine($"{point.X},{point.Y}");
                }
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadDrawing(filePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveDrawing(filePath);
            }
        }
    }
}
