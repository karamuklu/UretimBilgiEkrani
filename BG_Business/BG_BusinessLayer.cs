using BG_DataAccess;
using BG_Entities.Entities;
using System.Collections.Generic;

namespace BG_Business
{
    public class BG_BusinessLayer
    {
        private BG_Dal bg_dal = new BG_Dal();
        public List<MEKANIK_CIZIMLER_MKA> isList()
        {
            return bg_dal.isList();
        }

    }
}