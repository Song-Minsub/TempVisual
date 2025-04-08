using System.Windows.Media;

namespace TempVisual
{
    public class GetColor
    {
        public Color color;
        public GetColor(float temp)
        {
            if (temp == 0)
            {
                color = Color.FromRgb(0, 0, 0);
            }
            else if (temp <= 3)
            {
                color = Color.FromRgb(0, 0, 130);
            }
            else if (temp <= 7)
            {
                color = Color.FromRgb(0, 0, 180);
            }
            else if (temp <= 12)
            {
                color = Color.FromRgb(0, 0, 240);
            }
            else if (temp <= 15)
            {
                color = Color.FromRgb(100, 100, 240);
            }
            else if (temp <= 17)
            {
                color = Color.FromRgb(150, 150, 220);
            }
            else if (temp <= 20)
            {
                color = Color.FromRgb(200, 200, 170);
            }
            else if (temp <= 24)
            {
                color = Color.FromRgb(235, 235, 100);
            }
            else if (temp <= 27)
            {
                color = Color.FromRgb(250, 250, 0);
            }
            else if (temp <= 37)
            {
                color = Color.FromRgb(255, 190, 0);
            }
            else if (temp <= 40)
            {
                color = Color.FromRgb(255, 175, 0);
            }
            else if (temp <= 43)
            {
                color = Color.FromRgb(255, 140, 0);
            }
            else if (temp <= 46)
            {
                color = Color.FromRgb(255, 120, 0);
            }
            else if (temp <= 48)
            {
                color = Color.FromRgb(255, 100, 0);
            }
            else if (temp <= 49)
            {
                color = Color.FromRgb(255, 60, 0);
            }
            else
            {
                color = Color.FromRgb(255, 40, 0);
            }
        }
    }
}
