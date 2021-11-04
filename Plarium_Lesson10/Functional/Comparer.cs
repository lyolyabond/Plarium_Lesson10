using System;
using System.Collections.Generic;
using System.Text;

namespace Plarium_Lesson10
{
    //Компаратор объектов Souvenir
    class ComparerBySouvenirName : IComparer<Souvenir>
    {
        /// <summary>
        /// Сравнивает объекты в зависимости от названия сувенира(чтобы отсортировать в алфавитном порядке)
        /// </summary>
        /// <param name="souvenir1"></param>
        /// <param name="souvenir2"></param>
        /// <returns></returns>
        public int Compare(Souvenir souvenir1, Souvenir souvenir2) => 
            String.Compare(souvenir1.SouvenirName, souvenir2.SouvenirName, StringComparison.CurrentCultureIgnoreCase);
    }
}
