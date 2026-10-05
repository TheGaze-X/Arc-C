using System;
using System.Collections;
using System.Runtime.Remoting.Contexts;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020003B0 RID: 944
	[Token(Token = "0x20003B0")]
	internal class RemoteActivationAttribute : System.Attribute, System.Runtime.Remoting.Contexts.IContextAttribute
	{
		// Token: 0x06001E14 RID: 7700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E14")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public RemoteActivationAttribute(System.Collections.IList contextProperties)
		{
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00012D08 File Offset: 0x00010F08
		[Token(Token = "0x6001E15")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
		public bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, IConstructionCallMessage ctor)
		{
			return default(bool);
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E16")]
		[Address(RVA = "0x4B874C0", Offset = "0x4B860C0", VA = "0x184B874C0", Slot = "7")]
		public void GetPropertiesForNewContext(IConstructionCallMessage ctor)
		{
		}

		// Token: 0x04000FF2 RID: 4082
		[Token(Token = "0x4000FF2")]
		[FieldOffset(Offset = "0x10")]
		private System.Collections.IList _contextProperties;
	}
}
