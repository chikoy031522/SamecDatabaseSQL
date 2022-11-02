using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamecProject
{
    class GetSetClass
    {
        static string mid,mln,mfn, mmn, mbd, mbp, mdd, mtl,mea;
        public static string memid { get { return mid; } set { mid = value; } }
        public static string memlname { get { return mln; } set { mln = value; } }
        public static string memfname { get { return mfn; } set { mfn = value; } }       
        public static string memmname { get { return mmn; } set { mmn = value; } }
        public static string membd { get { return mbd; } set { mbd = value; } }
        public static string membp { get { return mbp; } set { mbp = value; } }
        public static string meminid { get { return mdd; } set { mdd = value; } }
        public static string memtel { get { return mtl; } set { mtl = value; } }
        public static string memea { get { return mea; } set { mea = value; } }
    }
}
