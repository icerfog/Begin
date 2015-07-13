using System;
/*	Console.WriteLine("Standard Numeric Format Specifiers");
    Console.WriteLine(
        "(C) Currency: . . . . . . . . {0:C}\n" +
        "(D) Decimal:. . . . . . . . . {0:D}\n" +
        "(E) Scientific: . . . . . . . {1:E}\n" +
        "(F) Fixed point:. . . . . . . {1:F}\n" +
        "(G) General:. . . . . . . . . {0:G}\n" +
        "    (default):. . . . . . . . {0} (default = 'G')\n" +
        "(N) Number: . . . . . . . . . {0:N}\n" +
        "(P) Percent:. . . . . . . . . {1:P}\n" +
        "(R) Round-trip: . . . . . . . {1:R}\n" +
        "(X) Hexadecimal:. . . . . . . {0:X}\n",
        -123, -123.45f);*/
namespace MyPractise
{
	class WorkSpace
	{
//==========================================================================================
		static int Day = 2, Count = 16; 	
		static float Scss = Count/10f;
		public static void Main (string[] args)
		{
			Console.WriteLine ("\t\tСегодня {0}й день. \n\tСделано: {1} задач. Твой уровень- {2:0.#}",
				Day, Count, Scss);
			
/*====>>>*/		Begin.B10();	// <<<====

			Console.ReadKey ();
		}
//==========================================================================================
	}

	class Begin
	{
		public static void B1()
		{
			Console.Write ("A = ");
			int a = int.Parse(Console.ReadLine ());
			Console.WriteLine ("Perimetr = {0}", a * 4);
		}
		public static void B2()
		{
			Console.Write ("A = ");
			int a = int.Parse (Console.ReadLine ());
			a = a * a;
			Console.WriteLine ("squere = {0}", a);
		}
		public static void B3()
		{
			Console.Write ("A = ");
			int a = int.Parse (Console.ReadLine ());
			Console.Write ("B = ");
			int b = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Squere = {0}", a * b);
			Console.WriteLine ("Perimetr = {0}", 2 * (a + b));
		}
		public static void B4()
		{
			Console.Write ("D = ");
			float d = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Long = {0}", Math.PI * d);
		}
		public static void B5()
		{
			Console.Write ("A = ");
			float a = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Volume = {0}", a * a * a);
			Console.WriteLine ("Squere = {0}", a * a * 6);
		}
		public static void B6()
		{
			Console.Write ("A = ");
			float a = float.Parse (Console.ReadLine ());
			Console.Write ("B = ");
			float b = float.Parse (Console.ReadLine ());
			Console.Write ("C = ");
			float c = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Volume = {0}", a * b * c);
			Console.WriteLine ("Squere = {0}", 2 * (a * b + b * c + c * a));					
		}
		public static void B7()
		{
			Console.Write ("R = ");
			float r = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Long = {0}", 2 * Math.PI * r);
			Console.WriteLine ("Squere = {0}", Math.PI*r*r);					
		}
		public static void B8()
		{
			Console.Write ("A = ");
			float a = float.Parse (Console.ReadLine ());
			Console.Write ("B = ");
			float b = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Middle = {0}", (a + b) / 2f);				
		}
		public static void B9()
		{
			Console.Write ("A = ");
			float a = float.Parse (Console.ReadLine ());
			Console.Write ("B = ");
			float b = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Middle = {0}", Math.Sqrt(a * b));				
		}
		public static void B10()
		{
			Console.Write ("A = ");
			float a = float.Parse (Console.ReadLine ());
			a = a * a;
			Console.Write ("B = ");
			float b = float.Parse (Console.ReadLine ());
			b = b * b;
			Console.WriteLine ("Sum = {0}", a + b);	
			Console.WriteLine ("Raz = {0}", a - b);	
			Console.WriteLine ("Mul = {0}", a * b);
			if (b != 0f)
				Console.WriteLine ("Div = {0}", a / b);
			else Console.WriteLine("can't div");				
		}
		public static void B11()
		{
			Console.Write ("A = ");
			float a = Math.Abs(float.Parse (Console.ReadLine ()));
			Console.Write ("B = ");
			float b = Math.Abs(float.Parse (Console.ReadLine ()));
			Console.WriteLine ("Sum = {0}", a + b);	
			Console.WriteLine ("Raz = {0}", a - b);	
			Console.WriteLine ("Mul = {0}", a * b);	
			Console.WriteLine ("Div = {0}", a / b);				
		}
		public static void B12()
		{
			Console.Write ("A = ");
			float a = Math.Abs(float.Parse (Console.ReadLine ()));
			Console.Write ("B = ");
			float b = Math.Abs(float.Parse (Console.ReadLine ()));
			double c = Math.Sqrt (a * a + b * b);
			Console.WriteLine ("C = {0}", c);
			Console.WriteLine ("Perimetr = {0}", a + c + b);			
		}
		public static void B13()
		{
			Console.Write ("R1 = ");
			float R = Math.Abs(float.Parse (Console.ReadLine ()));
			Console.Write ("R2 = ");
			float r = Math.Abs(float.Parse (Console.ReadLine ())); 
			double S = Math.PI * R * R;
			double s = Math.PI * r * r;
			Console.WriteLine ("S1 = {0}", S);	
			Console.WriteLine ("S2 = {0}", s);	
			Console.WriteLine ("Ring squere = {0}", S - s);			
		}
		public static void B14()
		{
			Console.Write ("L = ");
			float l = Math.Abs(float.Parse (Console.ReadLine ()));
			double r = l/(2*Math.PI);
			double s = Math.PI * r * r;
			Console.WriteLine ("R = {0}", r);	
			Console.WriteLine ("S = {0}", s);	
		}
		public static void B15()
		{
			Console.Write ("S = ");
			float s = float.Parse (Console.ReadLine ());
			double r = Math.Sqrt (s / Math.PI);
			double l = 2 * Math.PI * r;
			Console.WriteLine ("R = {0}\nLong = {1}", r, l);
		}
		public static void B16()
		{
			Console.Write ("X1 = ");
			float X = float.Parse (Console.ReadLine ());
			Console.Write ("X2 = ");
			float x = float.Parse (Console.ReadLine ());
			Console.WriteLine ("Rass = {0}", Math.Abs (X - x));
		}
	}
}
