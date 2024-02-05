using EventStorePoC.Domain.Entities;
using EventStorePoC.Shared.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventStorePoC.Domain.Events;

public record CustomerUpdated(Customer c, Object updatedfield) : IDomainEvent;
