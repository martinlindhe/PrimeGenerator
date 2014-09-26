using System;
using System.Diagnostics;

namespace PrimeGenerator
{
	public class App
	{
		public App ()
		{
		}

		public static void Main ()
		{
			Stopwatch timer = new Stopwatch ();

			//old:elapsed ticks: 155318603
			//new elapsed ticks: 1421414

			timer.Start ();
			for (ulong i = 4410699948; i <= ulong.MaxValue; i++) {
				if (IsPrime (i))
					Console.WriteLine (i);
			}

			timer.Stop ();

			Console.WriteLine ("elapsed ticks: " + timer.ElapsedTicks);

		}

		/**
	 	* @return true if n is a prime
	 	*/
		public static bool IsPrime (ulong candidate)
		{
			// TODO add tests on -1, 0,1,2,3 & some high numbers

			// 2 is the only even number prime
			if ((candidate & 1) == 0) {
				if (candidate == 2) {
					return true;
				}

				return false;
			}
		
			for (ulong i = 3; (i * i) <= candidate; i += 2) {
				if ((candidate % i) == 0) {
					return false;
				}
			}

			return candidate != 1;
		}
	}
}
