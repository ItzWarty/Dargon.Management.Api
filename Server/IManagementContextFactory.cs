namespace Dargon.Management.Server {
   public interface IManagementContextFactory {
      IManagementContext CreateFromObject(object obj);
   }
}
