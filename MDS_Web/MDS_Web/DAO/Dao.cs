using MDS_Web.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDS_Web.DAO
{
    
    public class Dao
    {
        Dbcontext db = null;
        public Dao()
        {
            db = new Dbcontext();
        }

        public List<HANGSX> ListAllHang()
        {
            return db.HANGSX.ToList();
        }
    }
}