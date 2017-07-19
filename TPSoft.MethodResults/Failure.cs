using System.Collections.Generic;
using System.Linq;

namespace TPSoft.MethodResults
{
    public class Failure
    {
        private readonly List<string> _messages = new List<string>();

        public Failure(string propertyName)
        {
            PropertyName = propertyName;
        }

        public Failure(string propertyName, string message)
        {
            PropertyName = propertyName;
            _messages.Add(message);
        }

        public string PropertyName { get; }

        public IReadOnlyList<string> Messages => _messages;

        public void Add(string message)
        {
            if (_messages.All(failure => failure.NotEqualsIgnoreCase(message)))
                _messages.Add(message);
        }

        public void Add(params string[] messages)
        {
            foreach (var failureMessage in messages)
                if (_messages.All(failure => failure.NotEqualsIgnoreCase(failureMessage)))
                    _messages.Add(failureMessage);
        }

        public void Add(IEnumerable<string> messages)
        {
            foreach (var message in messages)
                if (_messages.All(failure => failure.NotEqualsIgnoreCase(message)))
                    _messages.Add(message);
        }

        public void CopyFrom(Failure failure)
        {
            Add(failure.Messages);
        }
    }
}