using System;

namespace TestProject
{
    public class GetData
    {
        public string meter_;
        public float temp_;
        public int left_;
        public int top_;

        public GetData(string[] data)    // 배열 받아와서 형변환 후 저장
        {
            meter_ = data[0].Replace('M', ' ');
            temp_ = Convert.ToSingle(data[1]);
            left_ = Convert.ToInt32(data[2]);
            top_ = Convert.ToInt32(data[3]);
        }
    }
}
