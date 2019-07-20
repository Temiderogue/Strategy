using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }
    }
}
