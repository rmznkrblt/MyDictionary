using System;
using System.Collections;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> dictionary=new MyDictionary<string, string>();

            dictionary.Add("txt", "notepad.exe");
            dictionary.Add("bmp", "paint.exe");
            dictionary.Add("rtf", "wordpad.exe");
            dictionary.Add("dib", "paint.exe");
            dictionary.Items();
        }
    }
}
