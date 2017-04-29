using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProSpiro.Enuns;

namespace WebAppProSpiro.ListEnum
{
    public static class ListEnum
    {
        public static List<SelectListItem> ListSimNao()
        {
            var list = new List<SelectListItem>()
            {
                new SelectListItem { Value = "0", Text = EnumSimNao.Sim.ToString() },
                new SelectListItem { Value = "1", Text = EnumSimNao.Não.ToString() }
            };

            return list;
        }

        public static List<SelectListItem> ListGenero()
        {
            var list = new List<SelectListItem>()
            {
                new SelectListItem { Value = "0", Text = EnumGenero.Masculino.ToString() },
                new SelectListItem { Value = "1", Text = EnumGenero.Feminino.ToString() }
            };

            return list;
        }
    }
    
}
