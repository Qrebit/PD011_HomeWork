using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boards
{
    class Chalk:BaseBoard
    {
        string Type = "Меловая";
        bool Status = false;
        public void State()
        {
            List?.Invoke($"Тип - {Type}");
            if (Status == false)
            {
                List?.Invoke("Доска чиста");
            }
            else
            {
                List?.Invoke("Доска изрисована");
            }
        }
        public void Draw()
        {
            if (Status == false)
            {
                Status = true;
                Info?.Invoke("Доска изрисована");
            }
            else
            {
                Error?.Invoke("Доска уже изрисована");
            }
        }
        public void Clear()
        {
            if (Status == true)
            {
                Status = false;
                Info?.Invoke("Доска очищена");
            }
            else
            {
                Error?.Invoke("Доска уже чиста");
            }
        }
    }
}
