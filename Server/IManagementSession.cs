using System;
using System.Collections.Generic;

namespace Dargon.Management.Server {
   public interface IManagementSession : IDisposable {
      void SendInitialContexts(IReadOnlyList<IManagementContext> added, IReadOnlyList<IManagementContext> removed);

      void SendContextRegistered(IManagementContext context);
      void SendContextUnregistered(IManagementContext context);
   }
}