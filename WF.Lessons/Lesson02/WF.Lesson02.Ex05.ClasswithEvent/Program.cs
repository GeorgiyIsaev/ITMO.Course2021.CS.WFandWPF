using System;

namespace ClasswithEvent
{
	//��������� ������� �� ����� EventHandler (Event Handler - o��������� �������)
	public delegate void EventHandlerrr();
	// ������� ����� "��������� �����".
	class Die
	{
		Random r;
		//��������� ������� �� ������ ��������
		public event EventHandlerrr Max;
		//� ������������ ������ ��������� ���������� r, ������������ ��������� �������� Random
		public Die()
		{
			r=new Random();
		}
		//������� �����, � ������� ����� ���������� �������.
		public int random()
		{
			//�������� ����� �� 1 �� 6.
			int res = r.Next(6)+1;
			if(res==6)
			{
				//�������� �������.
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
		
			//������� ��������� brosok ������ 
			Die brosok = new Die();
			//���������� ����������� �������.
            brosok.Max += new EventHandlerrr(Metodobrabotchik);
            brosok.Max += Metodobrabotchik2;
			//����� ������, � ������� ���������� �������.
			for(int i=0; i<35; i++)
			{
				Console.WriteLine("{0}", brosok.random());
			}

		}
		//���������� ��� �������.
		public static void Metodobrabotchik()
		{
			Console.WriteLine("������ ������������ ���������� �����");
		}
        public static void Metodobrabotchik2()
		{
			Console.WriteLine("������ ����� ������������ ���������� �����");
		}
	}
}
