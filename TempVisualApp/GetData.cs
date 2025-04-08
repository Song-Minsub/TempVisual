using System;

namespace TempVisual
{
    public class GetData
    {
        public string meter;
        public float temp;
        public int left;
        public int top;

        public GetData(string[] data)    // 배열 받아와서 형변환 후 저장
        {
            meter = data[0].Replace('M', ' ');
            temp = Convert.ToSingle(data[1]);
            left = Convert.ToInt32(data[2]);
            top = Convert.ToInt32(data[3]);
        }
    }
}
