using System;

namespace TransientScopedSingleton
{
    /// <summary>
    /// Construtor da classe OperationService.
    /// Sempre que um objeto OperationService é criado (ou seja, injetado como um serviço),
    /// um novo Guid é gerado e armazenado no campo id. Isso aconteceria se a classe fosse usada como um serviço de tempo de vida Transient.
    /// 
    /// Scoped, o mesmo objeto OperationService seria compartilhado durante toda a duração de uma solicitação HTTP.
    /// Singleton, apenas um objeto OperationService seria criado durante todo o ciclo de vida da aplicação.
    /// </summary>
    public class OperationService : ITransientService, IScopedService, ISingletonService
    {
        Guid id;
        public OperationService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetOperationID()
        {
            return id;
        }
    }
}
