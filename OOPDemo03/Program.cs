namespace OOPDemo03
{
    internal class Program
    {

        #region overloading
        static int sum(int x , int y)
        {
            return x + y;
        }
        static int sum(int x , int y , int z)
        {
            return x + y + z;
        }
        static double sum(double x , double y)
        {
            return x + y;
        }
        #endregion
        static void Main(string[] args)
        {
            //int result = sum(1, 2);
            //Console.WriteLine(result);

            //double result1 = sum(1.5, 2.7);
            //Console.WriteLine(result1);

            //int result2 = sum(1, 2 , 5);
            //Console.WriteLine(result2);


            #region overriding only useing class

            //TypeA typeA = new TypeA(3);
            //typeA.A = 60;
            //typeA.MyFun01();
            //typeA.MyFun02();
            //Console.WriteLine("-----------------------------------");
            //TypeB typeB = new TypeB(10,30);
            //typeB.A = 70;
            //typeB.B = 90;
            //typeB.MyFun01();
            //typeB.MyFun02();
            #endregion


            #region Binding 
            //ref from parent => obj from child
            //TypeA refBase;

            //refBase = new TypeB(20, 30);
            //refBase.A  = 1;
            //refBase.MyFun01(); //new 
            //refBase.MyFun02(); //virtual

            #endregion



            #region Not Binding 

            //TypeB ChildRef = (TypeB) new TypeA(4); //casting

            #endregion


            #region Binding Example


            //TypeA REF = new TypeC(1, 2, 3);
            //REF.A = 1;
            //REF.MyFun01();
            //REF.MyFun02();

            //TypeB REF2 = new TypeC(1, 2, 3);
            //REF2.A = 20;
            //REF2.B = 20;
            //REF2.MyFun01();
            //REF2.MyFun02();



            //Console.WriteLine("---------------INDirect--------------------");
            //TypeA REF = new TypeE(1, 2, 3,4,5);
            //REF.MyFun02();
            //Console.WriteLine("---------------INDirect--------------------");
            //TypeB REF2 = new TypeE(1, 2, 3, 4, 5);
            //REF2.MyFun02();
            //Console.WriteLine("-----------------INDirect------------------");
            //TypeC REF3 = new TypeE(1, 2, 3, 4, 5); // end with new
            //REF3.MyFun02();
            //Console.WriteLine("-------------------Direct----------------");
            //TypeD REF4 = new TypeE(1, 2, 3, 4, 5); // strart with new virtual
            //REF4.MyFun02();
            //Console.WriteLine("-------------------Direct----------------");
            //TypeE REF5 = new TypeE(1, 2, 3, 4, 5);
            //REF5.MyFun02();



            #endregion
        }
    }
}
