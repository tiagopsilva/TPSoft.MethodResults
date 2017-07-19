using System.Collections.Generic;
using System.Linq;

namespace TPSoft.MethodResults
{
    public class MethodResult
    {
        private readonly List<Failure> _failures = new List<Failure>();

        public MethodResult()
        {
        }

        public MethodResult(string message)
        {
            if (message.AnyChar())
                _failures.Add(new Failure("", message));
        }

        public bool Success => _failures.IsEmpty();
        public bool Failed => _failures.Any();

        public IReadOnlyList<Failure> Failures => _failures;

        public object Data { get; set; }

        public void AddFailure(string memberName, string message)
        {
            if (message.IsEmpty())
                return;

            var member = _failures.SingleOrDefault(m => m.PropertyName.EqualsIgnoreCase(memberName));
            if (member == null)
                _failures.Add(new Failure(memberName, message));
            else
                member.Add(message);
        }
    }
}