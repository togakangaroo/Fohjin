using System;
using System.Collections.Generic;

namespace Fohjin.DDD.EventStore
{
    public interface IEntityEventProvider 
    {
        void Clear();
        void LoadFromHistory(IEnumerable<IDomainEvent> domainEvents);
        void HookUpVersionProvider(Func<int> versionProvider);
        IEnumerable<IDomainEvent> GetChanges();
        Guid Id { get; }
    }
}