using System;

namespace ClasswithEvent
{
    class KubEventArgs : EventArgs
    {
        public int Count { get; set; }
        public KubEventArgs(int Count)
        {
            this.Count = Count;
        }
    }

    public delegate void EventHandlerrr();

    class Die
    {

        Random r;
        public event EventHandler KubPlay;
        public event EventHandlerrr KubMax;

        //� ������������ ������ ��������� ���������� r, ������������ ��������� �������� Random
        public Die()
        {
            r = new Random();
        }
        //������� �����, � ������� ����� ���������� �������.
        public void random()
        {
            int res = r.Next(6) + 1;
            KubEventArgs kubInPlay = new KubEventArgs (res);//�������� ����� �� 1 �� 6.

            if (KubPlay != null)
                KubPlay(this, kubInPlay);

            if (res == 6)
            {
                KubMax();
            }
        }
    }

    class Pit
    {
        public Pit(Die kub)
        {
            kub.KubPlay += kub_KubPlay;
            kub.KubMax += kub_KubMax;
        }

        void kub_KubMax()
        {
            ShowKub(); 
        }

        void kub_KubPlay(object sender, EventArgs e)
        {
            if (e is KubEventArgs)
            {
                KubEventArgs kubEventArgs = e as KubEventArgs;
                ShowKub(kubEventArgs.Count);
            }
        }

        public void ShowKub(int p)
        {
            Console.WriteLine("��������! ������ ���������� ����� {0} ", p);
        }

        public void ShowKub()
        {
            Console.WriteLine("��������! ������ ������������ ���������� ����� 6");
        }


        class Gamer
        {
            public string Name { get; set; }
            Die seans;

            public Gamer(string name, Die seans)
            {
                Name = name;
                this.seans = seans;
                seans.KubPlay += seans_KubPlay;
            }


            public void SeansGame()
            {
                seans.random();
            }


            private void seans_KubPlay(object sender, EventArgs e)
            {
                if (e is KubEventArgs)
                {
                    KubEventArgs kubEventArgs = e as KubEventArgs;
                    ShowKubG(kubEventArgs.Count);
                }
            }



            private void ShowKubG(int p)
            {
                Console.WriteLine($"������ {Name} ������ ���������� ����� {p}");

            }

            public override string ToString() => Name;
            //{
            //    return Name;
            //}
        }


        class Program
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main(string[] args)
            {

                Die brosok = new Die();

                Gamer g1 = new Gamer("Niko", brosok);
                Pit p1 = new Pit(brosok);
              
                for (int i = 1; i <= 10; i++) 
                    g1.SeansGame();
            }
        }
    }
}

