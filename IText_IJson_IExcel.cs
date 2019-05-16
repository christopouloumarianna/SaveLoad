using System;
using System.Collections.Generic;
using System.Text;

namespace SaveLoad
{
   public interface IText
    {
        void SaveText(string TextFileName);
        bool LoadText(string TextFileName);
    }
    public interface IJson
    {
        void SaveJson(string JsonFileName);

        void LoadJson(string JsonFileName);
    }
public interface IExcel
    {
        bool SaveExcel(string ExcelFileName);

        bool LoadExcel(string ExcelFileName);
    }
}
