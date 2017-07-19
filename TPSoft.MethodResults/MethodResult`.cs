namespace TPSoft.MethodResults
{
    public class MethodResult<T> : MethodResult
    {
        public MethodResult()
        {
        }

        public MethodResult(string failureMessage)
        {
            AddFailure("", failureMessage);
        }

        public new T Data { get; set; }
    }
}