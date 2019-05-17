using System;
namespace Photo_Schedule_Xamarin
{
    public class EmptyClass
    {
        public int test1 = 10;
        public int test2 = 20;

        public void test3()
        {
            System.Diagnostics.Debug.WriteLine("デバッグ初テスト" + test1);
            System.Diagnostics.Trace.WriteLine("Xamarinもっと簡単にして！" + test2);
            System.Console.WriteLine("Console.WriteLine による出力です");
        }
    }
}