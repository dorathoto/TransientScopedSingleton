using System;

namespace TransientScopedSingleton
{
    public interface ITransientService
    {
        Guid GetOperationID();
    }
}
