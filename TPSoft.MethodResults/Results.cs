namespace MethodResults
{
    public static class Results
    {
        public static MethodResult OK()
            => new MethodResult();

        public static MethodResult OK(object data)
            => new MethodResult(data);

        public static MethodResult OK<T>()
            => new MethodResult<T>();

        public static MethodResult OK<T>(T data)
            => new MethodResult<T>(data);


        public static MethodResult Failure(string message)
            => new MethodResult(message);

        public static MethodResult Failure<T>(string message)
            => new MethodResult<T>(message);
    }
}
