using System;
using System.Collections.Generic;
using Dargon.Management.Client;

namespace Dargon.Management.Server {
   public interface IManagementContext {
      Guid Guid { get; }
      string Name { get; }
   }
}
