using System;

namespace Dargon.Management.Client {
   public interface IManagementClient {
      void Initialize();

      event RemoteManageableObjectEventHandler RemoteManageableObjectAdded;
      event RemoteManageableObjectEventHandler RemoteManageableObjectRemoved;
      event RemoteManagementObjectOperationsEventHandler RemoteManageableObjectOperationsResult;
      event RemoteManagementObjectInvocationResultHandler InvocationResult;

      void RequestMobOperations(Guid mobGuid);
      void RequestInvocation(Guid mobGuid, string name, object[] parameters);
   }

   public delegate void RemoteManageableObjectEventHandler(IManagementClient client, IRemoteMobDescription description);
   public delegate void RemoteManagementObjectOperationsEventHandler(IManagementClient client, IRemoteMobOperationsDescription description);
   public delegate void RemoteManagementObjectInvocationResultHandler(IManagementClient client, object result);
}
