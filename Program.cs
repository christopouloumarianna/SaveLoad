using System;

namespace SaveLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Basket();



            document.FillWithDummyData();



            document.SaveExcel("list.xlsx");

            document.LoadExcel("list.xlsx");



            //document.SaveText("list.txt");

            //document.LoadText("list.txt");



            //document.SaveJson("Jsondata.txt");

            //document.LoadJson("Jsondata.txt");



            Console.ReadLine();
        }
    }
}
