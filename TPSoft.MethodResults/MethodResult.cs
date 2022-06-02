using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MethodResults
{
    public class MethodResult
    {
        private readonly IList<Failure> _failures = new List<Failure>();

        public MethodResult() { }

        public MethodResult(object data)
            => Data = data;

        public MethodResult(string message)
        {
            if (message.AnyChar())
                _failures.Add(new Failure("", message));
        }

        public bool Success => _failures.IsEmpty();
        public bool Failed => _failures.Any();

        public virtual object Data { get; }

        public IReadOnlyCollection<Failure> Failures => new ReadOnlyCollection<Failure>(_failures);

        public void AddFailure(string memberName, string message)
        {
            if (message.IsEmpty())
                return;

            var member = _failures.SingleOrDefault(m => m.PropertyName.EqualsIgnoreCase(memberName));
            if (member == null)
            {
                _failures.Add(new Failure(memberName, message));
            }
            else
            {
                member.Add(message);
            }
        }
    }
}