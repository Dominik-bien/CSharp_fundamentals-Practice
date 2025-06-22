using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public interface IAttacked
    {
        string Name { get; }
        int Health { get; }
        void TakeDamage(int damage);
        bool isAlive();

    }
}
