using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAStack
{
    public class MyStack
    {
        private readonly List<object> _stack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You can not add a null");
            else
                _stack.Add(obj);
        }

        public string Pop()
        {
            if (_stack.Count > 0)
            {
                int removeValue = _stack.Count - 1;
                string result = _stack[removeValue].ToString();
                _stack.RemoveAt(removeValue);
                return result;
            }
            else
                throw new InvalidOperationException("Can not clear nothing");
        }

        public void Clear()
        {
            _stack.Clear();
        }

        public void Display()
        {
            foreach (var obj in _stack)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
