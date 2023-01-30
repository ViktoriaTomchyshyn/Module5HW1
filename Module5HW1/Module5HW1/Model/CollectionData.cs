using System.Collections.Generic;

namespace Module5HW1.Model;

public class CollectionData<T> : Validation
{
    public IReadOnlyCollection<T> Data { get; init; }
}