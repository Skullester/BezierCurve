using Bezier._2;
using Point = Bezier._2.Point;

namespace BezierCurve;

public partial class MainForm : Form
{
    private Bezier._2.BezierCurve bezierCurve = null!;
    private double tParameter;
    private HashSet<Point> points = new();
    public MainForm()
    {
        InitializeComponent();
        Initialize();
    }

    private void Initialize()
    {
        trackBar1.ValueChanged += OnTrackBarChanged;
    }
    private void OnTrackBarChanged(object o, EventArgs e)
    {
        if (!Validate())
            return;
        var value = trackBar1.Value;
        var doubleValue = value / 100d;
        tParameter = doubleValue;
        if (bezierCurve is not null)
        {
            Reset(2);
            bezierCurve.tParameter = tParameter;
            DrawBezierCurve();
        }
        labelParameter.Text = "t: " + tParameter;
    }
    private void DrawGraph(double x, double y)
    {
        chart1.Series[0].Points.AddXY(x, y);
    }

    private void DrawBezierCurve()
    {
        var point = bezierCurve!.GetValue();
        var pointCollection = chart1.Series[1].Points;
        if (!points.Contains(point))
        {
            var p = BuildHelpLines(bezierCurve.Points);
            points.Add(point);
            chart1.Series[^1].Points.AddXY(p.X, p.Y);
            pointCollection.AddXY(p.X, p.Y);
        }
    }
    private Point BuildHelpLines(IReadOnlyList<Point> points = default, int index = 0)
    {
        Point point = default;
        var list = new List<Point>();
        for (var i = 0; i < points.Count - 1; i++)
        {
            var currentPoint = points[i];
            var nextPoint = points[i + 1];
            var vector = nextPoint - currentPoint;
            var newPoint = currentPoint + vector * tParameter;
            point = newPoint;
            list.Add(newPoint);
            chart1.Series[2 + index].Points.AddXY(newPoint.X, newPoint.Y);
        }

        if (list.Count > 1)
            return BuildHelpLines(list, ++index);
        return point;
    }

    private new bool Validate()
    {
        var cond = labelFirstPoint is null || labelSecondPoint is null || labelThirdPoint is null;
        if (cond)
        {
            MessageBox.Show("Сначала заполните координаты точек!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return !cond;
    }

    private async void BuildGraph(object sender, EventArgs e)
    {
        Reset();
        var count = int.Parse(numericUpDown1.Text);
        if (count < 2)
        {
            throw new ArgumentException("Минимальное количество точек: 2");
        }
        var listBoxes = new List<TextBox>();
        TextBox[] textBoxes = [textBoxFirstPoint, textBoxSecondPoint, textBoxThirdPoint, textBoxFourthPoint, textBoxFifthPoint, textBoxSixth, textBoxSeventh, textBoxEighthPoint, textBoxNinthPoint, textBoxTenthPoint];
        for (var i = 0; i < count; i++)
        {
            listBoxes.Add(textBoxes[i]);
        }
        await Task.Run(() =>
        {
            List<Point> list = new();
            foreach (var box in listBoxes)
            {
                var coordinates = box.Text.Split(";").Select(int.Parse).ToArray();
                var point = new Point(coordinates[0], coordinates[1]);
                DrawGraph(point.X, point.Y);
                list.Add(point);
            }
            bezierCurve = new MultiBezierCurve(list);
        });
        DrawBezierCurve();
        Reset(2);
    }

    private void Reset(int i = 0)
    {
        for (var j = i; j < chart1.Series.Count; j++)
        {
            chart1.Series[j].Points.Clear();
        }
        if (i == 0)
        {
            trackBar1.Value = 0;
            points.Clear();
        }
    }

    private void Restart(object sender, EventArgs e)
    {
        Application.Restart();
    }
}

