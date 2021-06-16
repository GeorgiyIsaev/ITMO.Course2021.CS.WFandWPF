using System;

namespace ClasswithEvent
{
	//Объявляем делегат по имени EventHandler (Event Handler - oбработчик события)
	public delegate void EventHandlerrr();
	// Создаем класс "Игральная кость".
	class Die
	{
		Random r;
		//Объявляем событие на основе делегата
		public event EventHandlerrr Max;
		//В конструкторе класса объявляем переменную r, генерируемую встроеным объектом Random
		public Die()
		{
			r=new Random();
		}
		//Создаем метод, в котором будет вызываться событие.
		public int random()
		{
			//Случаное число от 1 до 6.
			int res = r.Next(6)+1;
			if(res==6)
			{
				//Вызываем событие.
				Max();
			}
			return res;
		}
	}


	class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{		
		
			//Создаем экземпляр brosok класса 
			Die brosok = new Die();
			//Добавление обработчика события.
            brosok.Max += new EventHandlerrr(Metodobrabotchik);
            brosok.Max += Metodobrabotchik2;
			//Вызов метода, в котором вызывается событие.
			for(int i=0; i<35; i++)
			{
				Console.WriteLine("{0}", brosok.random());
			}

		}
		//Обработчик для события.
		public static void Metodobrabotchik()
		{
			Console.WriteLine("Выпало максимальное количество очков");
		}
        public static void Metodobrabotchik2()
		{
			Console.WriteLine("Выпало очень максимальное количество очков");
		}
	}
}
