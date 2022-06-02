namespace MethodResults
{
    public class MethodResult<T> : MethodResult
    {
        public MethodResult() { }

        public MethodResult(T data)
            : base(data) { }

        public MethodResult(string message)
            : base(message) { }

        public new T Data { get; }
    }
}