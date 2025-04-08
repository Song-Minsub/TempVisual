using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TestProject
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("Cell.csv");  

            while (!sr.EndOfStream)     // 내용이 없을 때까지 실행
            {
                string line = sr.ReadLine();     // 한 줄씩 읽어 line 에 저장
                string[] data = line.Split(',');  // ',' 을 제거하고 배열에 저장

                GetData gData = new GetData(data);      
                GetColor gColor = new GetColor(gData.temp_);

                Ellipse ell = new Ellipse()             // 원 생성
                {
                    Width = 20,
                    Height = 20,
                    Fill = new SolidColorBrush(gColor.color_)
                };
                Canvas.SetLeft(ell, gData.left_);   
                Canvas.SetTop(ell, gData.top_);
                myCanvas.Children.Add(ell);    // 원을 Canvas에 추가
                ell.ToolTip = $"meter : {gData.meter_} temp : {gData.temp_}";  // 말풍선
            }
        }
    }
}
