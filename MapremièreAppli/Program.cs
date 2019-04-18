using System;
using System.Collections.Generic;




namespace MapremièreAppli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("j'ai fait une modif");

            Random random = new Random();
            Livre l = new Livre();
            Livre l2 = new Livre("nounours");
            int aleatoire = random.Next(10);
            string titre = "mon livre de math ";

            double chiffre = Math.Pow(aleatoire, aleatoire);
            titre = titre + chiffre.ToString();
            Livre math = new Livre(titre);

            l2.titre = "bienvenue chez les ours";
            l.titre = "toto";

            Livre p = new Periodique("Programmez", 4);

            List<Livre> tab = new List<Livre>();
            tab.Add(l2);
            tab.Add(l);
            tab.Add(math);
            tab.Add(p);

            System.Xml.ConformanceLevel level;

            foreach (Livre x in tab)
            {
                Console.WriteLine(x.titre);
            }
            Console.WriteLine(DateTime.Now);
        }
    }

    class Livre
    {
        private string _titre;

        public Livre()
        {
            Console.WriteLine("constructeur");
        }

        public Livre(string titre)
        {
            this.titre = titre;
        }

        public string titre
        {
            get
            {
                return _titre;
            }
            set
            {
                _titre = value;
            }
        }

        override
        public string ToString()
        {
            return "Votre titre " + _titre;
        }

    }



    class Periodique : Livre
    {
        private string _titre;
        private int _periode;

        public Periodique()
        {
            Console.WriteLine("constructeur");
        }

        public Periodique(string titre, int periode) : base (titre)
        {           
            _periode = periode;
        }

        override
       public string ToString()
        {
            return base.ToString() +" " +  _periode;
        }
    }
}
