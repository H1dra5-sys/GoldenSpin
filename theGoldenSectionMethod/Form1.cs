using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theGoldenSectionMethod {
  public partial class GoldenSection : Form {
    public GoldenSection() {
      InitializeComponent();
    }

    double a, b, originalA, originalB, eArg, x, y, step;

    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e) {
      aBox.Clear();
      bBox.Clear();
      eArgBox.Clear();
      stepBox.Clear();
      Answer.Text = "";
      functionBox.Clear();
    }

    string formulaReplace, formula;
    int iterations, maxIterations;
    NCalc.Expression expression;
    bool divisionByZero;

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e) {
      Answer.Text = "";
      maxIterations = 1000;
      iterations = 0;

      if (!double.TryParse(aBox.Text, out a) || !double.TryParse(bBox.Text, out b) ||
          !double.TryParse(eArgBox.Text, out eArg) || !double.TryParse(stepBox.Text, out step)) {
        MessageBox.Show("Введите корректные числа");
        return;
      }

      if (eArg < 0 || eArg > 15 || eArg % 1 != 0) {
        MessageBox.Show("Количество знаков после запятой (e) должно быть целым числом от 0 до 15");
        return;
      }
      double actualPrecision = Math.Pow(10, -(int)eArg);

      if (a >= b) {
        MessageBox.Show("Значение a должно быть меньше b");
        return;
      }

      originalA = a;
      originalB = b;

      functionGraph.Series[0].Points.Clear();
      functionGraph.ChartAreas[0].AxisX.Minimum = a;
      functionGraph.ChartAreas[0].AxisX.Maximum = b;

      formula = functionBox.Text;
      formulaReplace = formula.Replace("x", "[x]");
      expression = new NCalc.Expression(formulaReplace);

      try {
        expression.Parameters["x"] = a;
        double testA = Convert.ToDouble(expression.Evaluate());
        expression.Parameters["x"] = b;
        double testB = Convert.ToDouble(expression.Evaluate());

        if (double.IsNaN(testA) || double.IsInfinity(testA) || double.IsNaN(testB) || double.IsInfinity(testB)) {
          MessageBox.Show("Функция не определена на концах отрезка.");
          return;
        }
      } catch (Exception) {
        MessageBox.Show("Ошибка в формуле функции.");
        return;
      }

      double tau = (Math.Sqrt(5) - 1) / 2;
      double x1 = b - tau * (b - a);
      double x2 = a + tau * (b - a);

      double f1, f2;

      expression.Parameters["x"] = x1;
      f1 = Convert.ToDouble(expression.Evaluate());

      expression.Parameters["x"] = x2;
      f2 = Convert.ToDouble(expression.Evaluate());

      while (Math.Abs(b - a) > actualPrecision && iterations < maxIterations) {
        if (f1 < f2) {
          b = x2;
          x2 = x1;
          f2 = f1;
          x1 = b - tau * (b - a);

          expression.Parameters["x"] = x1;
          f1 = Convert.ToDouble(expression.Evaluate());
        } else {
          a = x1;
          x1 = x2;
          f1 = f2;
          x2 = a + tau * (b - a);

          expression.Parameters["x"] = x2;
          f2 = Convert.ToDouble(expression.Evaluate());
        }
        iterations++;
      }

      double xMin = (a + b) / 2;

      Answer.Text = xMin.ToString("F" + (int)eArg);

      if (iterations >= maxIterations) {
        MessageBox.Show("Превышено максимальное количество итераций.");
      }

      for (x = originalA; x <= originalB; x += step) {
        expression.Parameters["x"] = x;
        try {
          y = Convert.ToDouble(expression.Evaluate());
        } catch {
          divisionByZero = true;
          continue;
        }

        if (double.IsNaN(y) || double.IsInfinity(y)) {
          divisionByZero = true;
          continue;
        }
        functionGraph.Series[0].Points.AddXY(x, y);
      }

      if (divisionByZero) {
        MessageBox.Show("На графике есть разрывы (деление на 0 или недопустимые значения).");
      }

      expression.Parameters["x"] = xMin;
      double yMin = Convert.ToDouble(expression.Evaluate());
      if (!double.IsNaN(yMin) && !double.IsInfinity(yMin)) {
        functionGraph.Series[0].Points.AddXY(xMin, yMin);
      }

      functionGraph.ChartAreas[0].RecalculateAxesScale();
    }
  }
}
