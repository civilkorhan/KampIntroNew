
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    internal interface IKampanya
    {
        public int Id { get; set; }
        public string KampanyaName { get; set; }
        public string KampanyaNo { get; set; }
    }
}
