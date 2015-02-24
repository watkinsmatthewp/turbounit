using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboUnit.Gui
{
    public static class Extensions
    {
        public static ListViewItem ToRow(this TestResult testResult)
        {
            ListViewItem row = new ListViewItem()
            {
                Name = testResult.TestFullyQualitifedName
            };
            row.SubItems[0].Text = testResult.TestClass;
            row.SubItems.Add(testResult.TestName);
            row.SubItems.Add(testResult.ExceptionMessage);
            row.BackColor = testResult.CurrentStatus.GetColor();
            return row;
        }

        public static Color GetColor(this TestStatus status)
        {
            switch (status)
            {
                case TestStatus.Running:
                    return Color.Yellow;
                case TestStatus.Failed:
                case TestStatus.FailedWithException:
                case TestStatus.Timeout:
                    return Color.LightCoral;
                case TestStatus.CompleteButUnknown:
                case TestStatus.Inconclusive:
                case TestStatus.Unknown:
                    return Color.LightGoldenrodYellow;
                case TestStatus.Passed:
                    return Color.PaleGreen;
                case TestStatus.Skipped:
                    return Color.LightGray;
                case TestStatus.AwaitingRun:
                    return Color.White;
                default:
                    throw new Exception("Can't determine the color for " + status.ToString());
            }
        }

        public static int GetListSortOrder(this TestStatus status)
        {
            switch (status)
            {
                case TestStatus.Running:
                    return 0;
                case TestStatus.Failed:
                case TestStatus.FailedWithException:
                case TestStatus.Timeout:
                    return 1;
                case TestStatus.CompleteButUnknown:
                case TestStatus.Inconclusive:
                case TestStatus.Unknown:
                    return 2;
                case TestStatus.Passed:
                    return 3;                
                case TestStatus.Skipped:
                    return 4;
                case TestStatus.AwaitingRun:
                    return 5;
                default:
                    throw new Exception("Can't determine the sort order for " + status.ToString());
            }
        }

        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
            {
                source.Text = value;
            }
            else
            {
                source.AppendText("\r\n" + value);
            }
        }
    }
}
