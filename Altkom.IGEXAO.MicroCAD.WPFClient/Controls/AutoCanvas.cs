using System.Windows;
using System.Windows.Controls;

namespace Altkom.IGEXAO.MicroCAD.WPFClient.Controls
{
    public class AutoCanvas : Canvas
    {
        protected override Size MeasureOverride(Size availableSize)
        {
            Size size = base.MeasureOverride(availableSize);

            foreach (UIElement elem in Children)
            {
                if (elem.DesiredSize.Height + Canvas.GetTop(elem) > size.Height)
                    size.Height = elem.DesiredSize.Height + Canvas.GetTop(elem);
                if (elem.DesiredSize.Width + Canvas.GetLeft(elem) > size.Width)
                    size.Width = elem.DesiredSize.Width + Canvas.GetLeft(elem);
            }

            return size;
        }
    }
}
