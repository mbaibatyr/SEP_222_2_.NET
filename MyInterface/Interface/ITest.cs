using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface.Interface
{
    internal interface ISale<T, V, Plkjljl>
    {
        void ToSale(T item);
        void ToReSale(List<T> list);
        T Delete(int id);

        V Create(Plkjljl staff);
    }

    internal interface IBoss
    {
        void ToManage();
    }

    internal interface IAccount
    {
        void ToCalculate();
    }

    internal interface IDrive
    {
        void ToDrive();
    }

    class Staff_1 : IBoss, IAccount, IDrive
    {
        public void ToCalculate()
        {
            Console.WriteLine("Staff_1 Calculate");
        }

        public void ToDrive()
        {
            Console.WriteLine("Staff_1 Drive");
        }

        public void ToManage()
        {
            Console.WriteLine("Staff_1 Manage");
        }
    }

    class Staff_CEO : IBoss
    {
        public void ToManage()
        {
            ;
        }
    }

}
