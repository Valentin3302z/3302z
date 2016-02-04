using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Зарплата_ФИО
{
    class БазаДанных
    {
        private static Hashtable работники = new Hashtable();
        public static void ДобавитьРаботника(int ном, Работник работник )
        {
            работники[ном] = работник;

        }
        public static Работник ВернутьРаботника(int ном)
        {
            return работники [ном] as Работник;
        }
    }
}
