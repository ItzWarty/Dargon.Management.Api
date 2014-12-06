using System;
using System.Collections.Generic;

namespace Dargon.Management.Client {
   public interface IRemoteMobDescription {
      Guid Guid { get; }
      string Name { get; }
   }

   public interface IRemoteMobOperationsDescription {
      Guid Guid { get; }
      IReadOnlyList<IRemoteMobOperationDescription> Operations { get; }
   }

   public interface IRemoteMobOperationDescription {
      string Name { get; }
      IReadOnlyList<IRemoteMobOperationParameter> Parameters { get; }
      int ReturnPofTypeId { get; }
   }

   public interface IRemoteMobOperationParameter {
      string Name { get; }
      int PofTypeId { get; }
   }
}
