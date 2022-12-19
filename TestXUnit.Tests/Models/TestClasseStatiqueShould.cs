using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXUnit.Tests.Models
{
    public class TestClasseStatiqueShould
    {
        [Theory]
        [InlineData(2022)]
        public static int Age(int p_date_naissance)
        {
            return DateTime.Now.Year - p_date_naissance;
        }


        [Theory]
        [InlineData(2023, 2018)]
        public static int Dure(int p_date_debut, int p_date_fin)
        {
            return p_date_fin - p_date_debut;
        }
    }
}
