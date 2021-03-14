namespace lista_encadeada
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T value)
        {
            Value = value;
            Next = null;
        }        
        public bool HasNext()
        {
            return Value != null;
        }
    }
}