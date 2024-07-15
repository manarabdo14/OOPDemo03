using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo03
{
    internal class TypeD:TypeC
    {


        public int D { get; set; }

        public TypeD(int a, int b, int c, int d):base(a, b, c)
        {
            D = d;
        }

        public new void MyFun01()
        {
            Console.WriteLine($"I am Drevied [Child Grand Clild]");

        }

        //new --- end old sequence
        //new virtual -- end old sequence and start new sequence
        public new virtual void MyFun02()
        {
            Console.WriteLine($"TypeE : A = {A} , B = {B} , C = {C} , D = {D}");
        }
    }
}
