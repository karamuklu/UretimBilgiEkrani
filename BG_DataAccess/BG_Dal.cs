using BG_Entities;
using BG_Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BG_DataAccess
{
    public class BG_Dal
    {
        BGContext context = new BGContext();
        public List<MEKANIK_CIZIMLER_MKA> isList()
        {
            return context.MEKANIK_CIZIMLER_MKA.ToList();
        }

    }
}


