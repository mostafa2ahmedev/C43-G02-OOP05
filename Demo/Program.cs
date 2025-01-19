namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 2.	Override the ToString Function to produce this Output: “Point Coordinates: (10, 10, 10)”.
            //Point3D p = new Point3D(10, 10, 10);
            //Console.WriteLine(p.ToString());
            #endregion



            #region 3. Read from the User the Coordinates for 2 points P1, P2 
            //int userInput1;
            //int userInput2;
            //int userInput3;

            //Point3D p1;
            //Point3D p2;

            //    Console.WriteLine($"Enter the value of x for the First point : ");
            //    int.TryParse(Console.ReadLine(), out userInput1);

            //    Console.WriteLine($"Enter the value of y for the First point : ");
            //    userInput2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"Enter the value of z for the First point : ");
            //    userInput3 = Convert.ToInt32(Console.ReadLine());

            //    p1= new Point3D(userInput1,userInput2,userInput3);

            //    Console.WriteLine($"Enter the value of x for the Second point : ");
            //    int.TryParse(Console.ReadLine(), out userInput1);

            //    Console.WriteLine($"Enter the value of y for the Second point : ");
            //    userInput2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"Enter the value of z for the Second point : ");
            //    userInput3 = Convert.ToInt32(Console.ReadLine());

            //    p2 = new Point3D(userInput1, userInput2, userInput3);









            #endregion

            #region 4.	Try to use ==If(P1 == P2)   Does it work properly? 
            //if (p1 == p2){ // new keyword creates 2 different instances in heap so both references refer to its own object    
            // Console.WriteLine("Equals");
            // }

            #endregion




            #region 5.	Define an array of points and sort this array based on X & Y coordinates.

            //Point3D[] arr = [new Point3D(1,2,3),new Point3D(4, 5, 6)];


            #endregion

            #region Second Project:Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide

            //Console.WriteLine(Maths.Add(1, 2));
            //Console.WriteLine(Maths.Sub(1, 2));
            //Console.WriteLine(Maths.Mul(1, 2));
            //Console.WriteLine(Maths.Div(1, 2));




            #endregion

            #region Third Project 3 Define All Required Constructors to Produce this output:
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());
            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString()); 
            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());
            #endregion


            #region 4.	Implement All required Operators overloading to enable this Code:
            //●	D3=D1+D2
            //Duration D1 = new Duration(1, 10, 15);
            //Duration D2 = new Duration(7800);
            ////Duration D3=D1+ D2;
            //Console.WriteLine(D1);
            //Console.WriteLine(D2);
            //Console.WriteLine(D3);

            ////●	D3=D1 + 7800
            ////D3 = D1 + 7800;

            ////Console.WriteLine(D3);
            ////●	D3=666+D3
            ////D3 = 666 + D3;
            ////Console.WriteLine(D3);

            ////●	D3 = ++D1(Increase One Minute)

            //D3 = ++D1;
            //Console.WriteLine(D3);
            ////●	D3 = --D2(Decrease One Minute)
            //D3 = --D1;
            //Console.WriteLine(D3);
            ////●	D1= D1 -D2
            //D1 = D1 - D2;
            //Console.WriteLine(D1);
            //●	If(D1 > D2)
            //Console.WriteLine(D1 > D2);
            //  ●	If(D1 <= D2)
            //Console.WriteLine(D1 < D2);
            //●	DateTime Obj = (DateTime) D1
            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine(Obj);
            #endregion
        }
    }
}