namespace Dargon.Management.Server {
   public interface ILocalManagementRegistry {
      IManagementContext RegisterInstance(object obj);
      void RegisterContext(IManagementContext managementContext);
   }

   public delegate void ManagementContextRegistered(ILocalManagementRegistry registry, IManagementContext context);
}
