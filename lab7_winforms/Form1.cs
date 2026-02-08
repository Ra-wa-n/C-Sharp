using System.Drawing.Drawing2D;
using System.Drawing;

namespace lab7_winforms
{
    public partial class Form1 : Form
    {
        int[] years = { 1988, 1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997 };
        int[] revenue = { 150, 170, 180, 175, 200, 250, 210, 240, 280, 140 };
        Graphics g;
        string com_text;
        Color com_color;
        Point com_point;
        Brush com_brush;
        Font comFont;
        Font tabFont;
        string tab_text;
        Color tab_color;
        Point tab_point;
        Brush tab_brush;
        Pen rectpen;
        Color rectcolor;
        Rectangle rect;
        Pen linepen;
        Point linestart;
        Point lineEnd;
        Pen linex;
        Point linexend;
        Point linexstart;
        Pen liney;
        Point lineyend;
        Point lineystart;
        Color barchartcolor;
        Color linechartcolor;
        Pen chartPen;
        int chartHeight;
        int chartWidth;
        int maxRevenue;
        int yAxisMax;
        float scaleY;
        int barCount;
        int xStep;
        int barWidth;
        public Form1()
        {
            InitializeComponent();
            com_text = "ABC Company";
            com_color = Color.Black;
            com_point = new Point(300, 20);
            com_brush = new SolidBrush(com_color);
            tab_text = "Annual Revenue";
            tab_color = Color.Black;
            tab_point = new Point(340, 65);
            tab_brush = new SolidBrush(tab_color);
            comFont = new Font("Times New Roman", 22, FontStyle.Bold);
            tabFont = new Font("Times New Roman", 14);
            rectcolor = Color.Black;
            rectpen = new Pen(rectcolor, 3);
            rect = new Rectangle(55, 85, 215, 350);
            linepen = new Pen(rectcolor, 3);
            linestart = new Point(155, 85);
            lineEnd = new Point(155, 350 + 85);
            linex = new Pen(Color.Black, 3);
            liney = new Pen(Color.Black, 3);
            lineystart = new Point(500, 120);
            lineyend = new Point(500, 520);
            linexstart = new Point(500, 520);
            linexend = new Point(1200, 520);
            barchartcolor = Color.Red;
            linechartcolor = Color.Blue;
            chartPen = new Pen(linechartcolor, 3);
            chartHeight = lineyend.Y - lineystart.Y;
            chartWidth = linexend.X - linexstart.X;
            maxRevenue = revenue.Max();
            yAxisMax = ((maxRevenue / 50) + 1) * 50;
            scaleY = (float)chartHeight / yAxisMax;
            barCount = years.Length;
            xStep = chartWidth / barCount;
            barWidth = xStep / 2;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.MouseClick += Form1_MouseClick;
            this.Paint += Form1_Paint;
        }

        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            for (int i = 0; i < years.Length; i++)
            {
                int barHeight = (int)(revenue[i] * scaleY);
                int x = linexstart.X + (i * xStep) + (xStep - barWidth) / 2;
                int y = lineyend.Y - barHeight;
                Rectangle barArea = new Rectangle(x, y, barWidth, barHeight);
                if (barArea.Contains(e.Location))
                {
                    MessageBox.Show($"Year: {years[i]}\nRevenue: {revenue[i]}", "Bar Selected");
                    return;
                }
            }
        }
        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.R:
                        linechartcolor = Color.Red;
                        chartPen.Color = Color.Red;
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.G:
                        linechartcolor = Color.Green;
                        chartPen.Color = Color.Green;
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.B:
                        linechartcolor = Color.Blue;
                        chartPen.Color = Color.Blue;
                        e.SuppressKeyPress = true;
                        break;
                }
            }
            Invalidate();
        }
        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawString(com_text, comFont, com_brush, com_point);
            g.DrawString(tab_text, tabFont, tab_brush, tab_point);
            g.DrawRectangle(rectpen, rect);
            g.DrawLine(linepen, linestart, lineEnd);
            DrawDataTable();
            g.DrawLine(linex, linexstart, linexend);
            g.DrawLine(liney, lineystart, lineyend);
            DrawChartElements();
            LineChart();
        }
        private void DrawDataTable()
        {
            int rows = years.Length + 1;
            int rowHeight = rect.Height / rows;
            int yearX = rect.X + 10;
            int revenueX = linestart.X + 10;
            int headerY = rect.Y + (rowHeight - tabFont.Height) / 2;
            for (int i = 1; i < rows; i++)
            {
                int y = rect.Y + (i * rowHeight);
                g.DrawLine(rectpen, rect.X, y, rect.X + rect.Width, y);
            }
            g.DrawString("Year", tabFont, Brushes.Black,
                new Point(yearX, headerY));
            g.DrawString("Revenue", tabFont, Brushes.Black,
                new Point(revenueX, headerY));
            for (int i = 0; i < years.Length; i++)
            {
                int yText = rect.Y + ((i + 1) * rowHeight)
                            + (rowHeight - tabFont.Height) / 2;

                g.DrawString(years[i].ToString(),
                    tabFont, Brushes.Black,
                    new Point(yearX, yText));

                g.DrawString(revenue[i].ToString(),
                    tabFont, Brushes.Black,
                    new Point(revenueX, yText));
            }
        }
        private void DrawChartElements()
        {
            for (int v = 0; v <= yAxisMax; v += 50)
            {
                int yPos = lineyend.Y - (int)(v * scaleY);
                g.DrawString(v.ToString(), tabFont, Brushes.Black, lineystart.X - 45, yPos - 10);
                g.DrawLine(Pens.LightGray, lineystart.X, yPos, linexend.X, yPos);
            }
            using (HatchBrush barBrush = new HatchBrush(HatchStyle.BackwardDiagonal, barchartcolor, Color.Transparent))
            {
                for (int i = 0; i < barCount; i++)
                {
                    int barHeight = (int)(revenue[i] * scaleY);
                    int x = linexstart.X + (i * xStep) + (xStep - barWidth) / 2;
                    int y = lineyend.Y - barHeight;
                    g.FillRectangle(barBrush, x, y, barWidth, barHeight);
                    g.DrawRectangle(Pens.Black, x, y, barWidth, barHeight);
                    g.DrawString(years[i].ToString(), tabFont, Brushes.Black, x - 5, linexstart.Y + 5);
                }
            }
        }
        private void LineChart()
        {
            Point[] points = new Point[barCount];
            for (int i = 0; i < barCount; i++)
            {
                int x = linexstart.X + (i * xStep) + (xStep / 2);
                int y = lineyend.Y - (int)(revenue[i] * scaleY);
                points[i] = new Point(x, y);
            }
            if (points.Length > 1)
            {
                chartPen.LineJoin = LineJoin.Round;
                chartPen.Color = linechartcolor;
                g.DrawLines(chartPen, points);
            }
        }

       
    }
}

