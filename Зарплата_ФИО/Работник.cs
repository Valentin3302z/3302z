using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Зарплата_ФИО
{
    public class Работник
    {
        readonly int рабНом;
        string фио;
        string адрес;
        private ТипВыплат тип;
        private Методвыплат метод;
        private ГрафикВыплат график;
        private Членство членство;

        public  Членство Членство
        {
            get { return членство; }
            set { членство = value; }
        }
        public ТипВыплат Тип
        {
            get { return тип; }
            set { тип = value;}
        }
        public Методвыплат Метод
        {
            get { return метод; }
            set { метод = value; }
        }
       public  ГрафикВыплат График
        {
            get { return график; }
            set { график = value; }
        }

        public Работник(int рабНом , string  фио , string адрес)
        {
            this.рабНом = рабНом;
            this.фио = фио;
            this.адрес = адрес;
        }

        public string ФИО
        {
            get {return фио; }
            set {фио = value;}
        }
        public string Адресс
        {
            get { return адрес; }
            set { адрес = value; }
        }
        public int РабНом
        {
            get { return рабНом; }
        }
    }
}
