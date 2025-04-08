using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;

namespace TempVisual
{
    public class MainViewModel
    {
        public ObservableCollection<clsCircleInfo> Circles { get; set; } = new ObservableCollection<clsCircleInfo>();

        public MainViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            if (!File.Exists("Cell.csv"))
                return;

            StreamReader sr = new StreamReader("Cell.csv");

            while (!sr.EndOfStream)     // 내용이 없을 때까지 실행
            {
                try
                {
                    string line = sr.ReadLine();     // 한 줄씩 읽어 line 에 저장
                    string[] data = line.Split(',');  // ',' 을 제거하고 배열에 저장

                    if (data.Length < 4)
                        continue;

                    GetData gData = new GetData(data);
                    GetColor gColor = new GetColor(gData.temp);

                    Circles.Add(new clsCircleInfo
                    {
                        Left = gData.left,
                        Top = gData.top,
                        Tooltip = $"meter : {gData.meter} temp : {gData.temp}",
                        Fill = new SolidColorBrush(gColor.color)
                    });

                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
