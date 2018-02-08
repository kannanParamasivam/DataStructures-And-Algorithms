namespace linkedlist_with_sigle_element
{
    public interface IElement<T>
    {
        T GetData();
        bool SetData(T data);
        IElement<T> GetNext();
        bool SetNext(IElement<T> element);

    }
}