using System;

namespace TransientScopedSingleton
{
    public interface ISingletonService
    {
        Guid GetOperationID();
    }
}
