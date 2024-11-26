using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OOP_lab12
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                GPALog.WriteLogInfo();
                GPADiskInfo.GetDiskInfo();
                GPAFileInfo.GetFileInfo();
                GPADirInfo.GetDirInfo();
                GPAFileManager.GetList(@"E:\");
                GPAFileManager.CreateDir(@"E:\1LABS\ООП\12\OOP_lab12\GPAInspect");
                GPAFileManager.CreateFile(@"E:\1LABS\ООП\12\OOP_lab12\GPAInspect\gpadirinfo.txt");
                GPAFileManager.CopyFile(@"E:\1LABS\ООП\12\OOP_lab12\GPAInspect\gpadirinfo.txt", @"E:\1LABS\ООП\12\OOP_lab12\GPAInspect\gpadirinfo_copy.txt");
                GPAFileManager.CopyFiles(@"E:\1LABS\ООП", @"E:\1LABS\ООП\12\OOP_lab12\GPAFiles", @"E:\1LABS\ООП\12\OOP_lab12\GPAInspect");
                GPAFileManager.ZipFiles(@"E:\1LABS\ООП\12\OOP_lab12\GPAInspect\GPAFiles", @"E:\1LABS\ООП\12\OOP_lab12\GPAFiles.zip", @"E:\1LABS\ООП\12\OOP_lab12\ForZip");
                GPALog.Count();
                /* GPALog.ReadLog();
                 GPALog.SearchLog();*/
                GPALog.FindLogInfo("GPAFileManager");
                GPALog.FindLogInfoDay(new DateTime(2022, 11, 20, 0, 14, 29));
                GPALog.FindLogInfoTime(new DateTime(2022, 11, 20, 0, 14, 29), new DateTime(2022, 11, 20, 0, 18, 38));
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine("Ошибка! Директорий не найден.\n" + e.Message);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Ошибка! Файл уже существует или используется другим процессом.\n" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Непредвиденная ошибка!\n" + e.Message);
            }


        }
       
       
        }
    }

