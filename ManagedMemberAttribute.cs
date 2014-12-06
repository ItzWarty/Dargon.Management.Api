using System;

namespace Dargon.Management {
   public abstract class ManagedMemberAttribute : Attribute {
      protected ManagedMemberAttribute() { }

      public string Description { get; set; }
   }
}