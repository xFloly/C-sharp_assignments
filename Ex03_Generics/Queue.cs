using System.Collections;

namespace Ex03_Generics
{


    internal class Queue : ArrayList
    {
        public void Enqueue(Object value) {
            this.Add(value);
        }
        public Object? Dequeue() { 
            if(this.Count > 0)
            {
                Object value = this[0]!;
                this.RemoveAt(0);
                return value;
            }
            return null;
        }
    }


    internal class QueueComposition
    {
        private readonly ArrayList _arrayList = new();

        public void Enqueue(Object value)
        {
            _arrayList.Add(value);
        }

        public Object? Dequeue()
        {
            if (_arrayList.Count > 0)
            {
                Object value = _arrayList[0]!;
                _arrayList.RemoveAt(0);
                return value;
            }
            return null;
        }
    }
}
