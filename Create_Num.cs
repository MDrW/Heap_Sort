using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Heap_Sort
{
    /**
    * 获得所要排序的原始数据
    */
    class Create_Num
    {
        //根据用户输入数据由正则表达式获得排序的原数数据，存放在List中返回
        public static List<double> CreateNumByHand(string s)
        {
            List<double> lst = new List<double>();
            string pattern = @"[-|+]{0,1}[0-9]+[.]{0,1}[0-9]*";
            Regex r = new Regex(pattern);
            MatchCollection mc = r.Matches(s);      //利用正则表达式匹配数据
            foreach(Match m in mc)
            {
                string tmp = m.ToString();
                double num;
                if(double.TryParse(tmp,out num))
                    lst.Add(num);                   //解析用户输入的数据，并添加到列表中
            }
            /*char[] ch = { ' ', ',', ';', '\n', '\t', };
            string[] slst = s.Split(ch);
            foreach(string item in slst)
            {
                string num = item.Trim(' ');
                if(num != null && num != "")
                    lst.Add(Convert.ToDouble(item));
            }*/
            return lst;
        }

        //根据用户输入的创建数据的个数随机创建相应的原始数据，存放在List中返回
        public static List<double> CreateNumByRnd(string s)
        {
            List<double> lst = new List<double>();
            int n;
            Random rnd = new Random();
            s = s.Trim();
            if (!int.TryParse(s, out n))
                n = rnd.Next(1000);             //根据用户输入决定产生的随机数个数   
            for(int i = 0;i < n;i++)
            {
                double tmp = rnd.NextDouble() * rnd.Next(1000);
                tmp = Math.Round(tmp, 2);
                int flag = rnd.Next(2);
                if (flag == 1) tmp = -tmp;
                lst.Add(tmp);                   //产生n个随机数
            }
            return lst;
        }
    }
}
