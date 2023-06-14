using System;
using System.Text.Json.Serialization;

namespace EventBus.Events
{
    public record IntegrationEvent
    {
        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        [JsonConstructor]
        public IntegrationEvent(Guid id, DateTime createdDate)
        {
            Id = id;
            CreationDate = createdDate;
        }

        public Guid Id { get; private init; }

        public DateTime CreationDate { get; private set; }
    }
}