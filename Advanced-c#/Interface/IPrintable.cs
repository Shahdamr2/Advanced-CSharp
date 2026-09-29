namespace Advanced_c_.Interface
{
    interface IPrintable
    {
        void Print();
    }

    class GenericPrinter<T> where T : IPrintable
    {
        public void PrintItem(T item)
        {
            item.Print();
        }
    }
}