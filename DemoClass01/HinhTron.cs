using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass01
{
    public class HinhTron
    {
        private int bankinh;

        public HinhTron(int bankinh)
        {
            this.bankinh = bankinh;
        }
        public HinhTron()
        {
        }

        public int getBanKinh()
        {
            return this.bankinh;
        }
        public void setBanKinh(int bk)
        {
            this.bankinh=bk;
        }

        public int DuongKinh()
        {
            return bankinh * 2;
        }
    }


}
