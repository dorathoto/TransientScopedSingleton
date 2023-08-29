using System;

namespace TransientScopedSingleton
{
    public interface IScopedService
    {
        Guid GetOperationID();
    }
}
