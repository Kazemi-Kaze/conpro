using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conpro
{
    class Program
    {
        static void Main(string[] args)
        {

            DataTable data = sqlcn.GetSampleData();
            foreach (DataRow row in data.Rows)
            { 
            Console.WriteLine(row[0].ToString());
            Console.WriteLine();
        }
            Console.ReadKey();

          

        }
        public class medarbejder
        {
            public string fornavn;
            public string efternavn;
            public int id;
            public List<int> tlf;
        }



        public class order
        {
            public string fornavn;
            public string efternavn;
            public int id;
            public List<int> tlf;
        }


        static List<medarbejder> liste = new List<medarbejder> 
        {
            new medarbejder {fornavn = "mark",efternavn = " smith",id=0,tlf = new List<int>{123456,135790}},
             new medarbejder {fornavn = "hans",efternavn = " larsen",id=0,tlf = new List<int>{852852,852369}},
              new medarbejder {fornavn = "jens",efternavn = " jensen",id=0,tlf = new List<int>{741147,789123}},
               new medarbejder {fornavn = "peter",efternavn = " petersen",id=0,tlf = new List<int>{951159,755357}},
                new medarbejder {fornavn = "kim",efternavn = " kimsen",id=0,tlf = new List<int>{751595,753595}},
                 new medarbejder {fornavn = "lasse",efternavn = " las",id=0,tlf = new List<int>{149675,358575}}
        };

        static List<order> order_list = new List<order> 
        {
            new order {fornavn = "mark",efternavn = " smith",id=0,tlf = new List<int>{123456,135790}},
             new order {fornavn = "hans",efternavn = " larsen",id=0,tlf = new List<int>{852852,852369}},
              new order {fornavn = "jens",efternavn = " jensen",id=0,tlf = new List<int>{741147,789123}},
               new order {fornavn = "peter",efternavn = " petersen",id=0,tlf = new List<int>{951159,755357}},
                new order {fornavn = "kim",efternavn = " kimsen",id=0,tlf = new List<int>{751595,753595}},
                 new order {fornavn = "lasse",efternavn = " las",id=0,tlf = new List<int>{149675,358575}}
        };




       



    }
}
