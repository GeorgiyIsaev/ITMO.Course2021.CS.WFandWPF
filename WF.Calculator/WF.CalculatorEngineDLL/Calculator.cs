using System.Reflection;

namespace Calculator
{

	using System;

	public class CalcEngine
	{
		//
		// Operation Constants.
		//
		public enum Operator:int
		{
			eUnknown = 0,
			eAdd = 1,
			eSubtract = 2,
			eMultiply = 3,
			eDivide = 4,
			eReverse = 5,
			eyFactorial = 6,
			eSQrtY = 7,
			eSQrt = 8,
			ePowY = 9,
			ePow = 10
		}

		//
		// Module-Level Constants
		//

		private static double negativeConverter = -1;	
		private static string versionInfo = "Calculator v3.0.1.1";

		//
		// Module-level Variables.
		//
	
		private static double numericAnswer;
		private static string stringAnswer;
		private static Operator calcOperation;
		private static double firstNumber;
		private static double secondNumber;
		private static bool secondNumberAdded;
		private static bool decimalAdded;
 
		//
		// Class Constructor.
		//

		public CalcEngine ()
		{
			decimalAdded = false;
			secondNumberAdded = false;
		}

		//
		// Returns the custom version string to the caller.
		//

		public static string GetVersion ()
		{
			return (versionInfo);
		}
		//
		// Called when the Date key is pressed.
		//

		public static string GetDate ()
		{
			DateTime curDate = new DateTime();
			curDate = DateTime.Now;

			stringAnswer = String.Concat (curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

			return (stringAnswer);
		}

		//
		// Called when a number key is pressed on the keypad.
		//

		public static string CalcNumber (string KeyNumber)
		{
			if (stopInput)
            {
				stringAnswer = "";
				stopInput = false;

			}
			stringAnswer = stringAnswer + KeyNumber;			
			return (stringAnswer);
		}

		//
		// Called when an operator is selected (+, -, *, /)
		//

		public static string CalcOperation (Operator calcOper)
		{
			if (firstNumber != 0)
				stringAnswer = CalcEqual();

			if (stringAnswer != "" /*&& !secondNumberAdded*/)
			{
				firstNumber = System.Convert.ToDouble (stringAnswer);
				calcOperation = calcOper;
				//stringAnswer = "";
				decimalAdded = false;			
			}
			stopInput = true;
			return stringAnswer;
		}

		//
		// Called when the +/- key is pressed.
		//

		public static string CalcSign ()
		{
			double numHold;

			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble (stringAnswer);
				stringAnswer = System.Convert.ToString(numHold * negativeConverter);
			}
		
			return (stringAnswer);
		}

		//
		// Called when the . key is pressed.
		//

		public static string CalcDecimal ()
		{
			if (!decimalAdded && !secondNumberAdded)
			{
				if (stringAnswer != "")
					stringAnswer = stringAnswer + ".";
				else
					stringAnswer = "0.";

				decimalAdded = true;
			}

			return (stringAnswer);
		}

		//
		// Called when = is pressed.
		//

		public static string CalcEqual ()
		{
			bool validEquation = false;

			if (stringAnswer != "")
			{
				secondNumber = System.Convert.ToDouble (stringAnswer);
				secondNumberAdded = true;

				switch (calcOperation)
				{
					case Operator.eUnknown:
						validEquation = false;
						//secondNumberAdded = false;
						//stopInput = true;
						//firstNumber = secondNumber;
						//stringAnswer = "";
						break;

					case Operator.eAdd:
						numericAnswer = firstNumber + secondNumber;
						validEquation = true;
						break;

					case Operator.eSubtract:
						numericAnswer = firstNumber - secondNumber;
						validEquation = true;
						break;

					case Operator.eMultiply:
						numericAnswer = firstNumber * secondNumber;
						validEquation = true;
						break;

					case Operator.eDivide:
						numericAnswer = firstNumber / secondNumber;
						validEquation = true;
						break;				
					case Operator.ePowY:
						numericAnswer = Math.Pow(firstNumber, secondNumber);
						validEquation = true;
						break;
					default:
						validEquation = false;
						break;
				}

				if (validEquation)
					stringAnswer = System.Convert.ToString (numericAnswer);
			}
			
			return (stringAnswer);
		}

		//
		// Resets the various module-level variables for the next calculation.
		//

		public static void CalcReset ()
		{
			numericAnswer = 0;
			firstNumber = 0;
			secondNumber = 0;
			stringAnswer = "";
			calcOperation = Operator.eUnknown;
			decimalAdded = false;
			secondNumberAdded = false;			
		}


		/*Выполнение новых операций, которые будут добавлены в кейс*/
		static bool stopInput = false; //оповещает о конце числа
		static bool ifNotClear()
        {
			if (stringAnswer == "бесконечность" || stringAnswer == "Nan")
				return false;
			return true;

		}
		public static string CalcPow()
		{			
			if (Double.TryParse(stringAnswer, out firstNumber) && ifNotClear())
			{
				firstNumber = Math.Pow(firstNumber, 2);
				stringAnswer=  System.Convert.ToString(firstNumber);
				stopInput = true;
			}
			else
			{
				stringAnswer = "0";
			}
			return (stringAnswer);
		}

		public static string CalcSqrt()
		{			
			double numHold;
			if (Double.TryParse(stringAnswer, out numHold) && ifNotClear())
			{				
				numHold = Math.Sqrt(numHold);
				stringAnswer = System.Convert.ToString(numHold);
				stopInput = true;
			}
			else
			{
				stringAnswer = "0";
			}
			return (stringAnswer);
		}

		public static string CalcSqrtY()
		{			
			double numHold;
			if (Double.TryParse(stringAnswer, out numHold) && ifNotClear())
			{
				numHold = Math.Round(Math.Pow(numHold, 1 / 3f), 2);
				stringAnswer = System.Convert.ToString(numHold);
				stopInput = true;
			}
			else
			{
				stringAnswer = "0";
			}
			return (stringAnswer);
		}

		public static string CalcFactorial()
		{
			double numHold;
			double numHoldTemp;
			if (Double.TryParse(stringAnswer, out numHoldTemp) && ifNotClear())
			{				
				if (numHoldTemp > 0)
				{
					numHold = 1;
					for (int i = 1; i < numHoldTemp + 1; i++)
					{
						numHold *= i;
					}
					stringAnswer = System.Convert.ToString(numHold);
					stopInput = true;
				}
                else
                {
					stringAnswer = "NaN";
					CalcReset();
				}				
			}
			else
			{
				stringAnswer = "0";
			}
			return (stringAnswer);			
		}

		public static string CalcReverse()
		{
			double numHold;
			if (Double.TryParse(stringAnswer, out numHold) && ifNotClear())
			{				
				numHold = 1 / numHold;	
				numHold = Math.Round(Math.Pow(numHold, 1 / 3f), 2);
				stringAnswer = System.Convert.ToString(numHold);
				stopInput = true;
			}
            else
            {
				stringAnswer = "0";
			}
			return (stringAnswer);
		}



	}
}