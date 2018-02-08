using System;

namespace linkedlist_with_sigle_element
{
    public class Element<T> : IElement<T>
    {
        private T data;
        private IElement<T> next;

        public Element(T data, IElement<T> next)
        {
            this.data = data;
            this.next = next;
        }

        public T GetData()
        {
            return this.data;
        }

        public IElement<T> GetNext()
        {
            return this.next;
        }

        public bool SetData(T data)
        {
            try
            {
                this.data = data;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;

        }

        public bool SetNext(IElement<T> element)
        {
            try
            {
                this.next = element;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }
    }
}
