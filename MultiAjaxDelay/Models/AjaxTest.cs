using System;

namespace MultiAjaxDelay.Models
{
    public static class AjaxTest
    {
        public static string Delay0(string begin) => DelayByNum(0, begin);

        public static string Delay5(string begin) => DelayByNum(5, begin);

        public static string DelayByNum(int delay, string begin = "", int seqNo = 0)
        {
            System.Threading.Thread.Sleep(delay * 1000);
            var s = begin == string.Empty ? DateTime.Now.ToString("HH:mm:ss.fff") : DateTime.Now.ToString("HH:mm:ss");
            var num = seqNo == 0 ? string.Empty : $"#{seqNo}";
            var time = begin == string.Empty ? $"at [{s}]" : $"from:[{begin}] to:[{s}]";
            var result = $"AjaxCall {num} Delay {delay}s - {time}";
            return result;
        }
    }
}