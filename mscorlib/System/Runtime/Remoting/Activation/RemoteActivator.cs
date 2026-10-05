using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020003B1 RID: 945
	[Token(Token = "0x20003B1")]
	internal class RemoteActivator : System.MarshalByRefObject, IActivator
	{
		// Token: 0x06001E17 RID: 7703 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E17")]
		[Address(RVA = "0x4B87830", Offset = "0x4B86430", VA = "0x184B87830", Slot = "7")]
		public IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			return null;
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000392")]
		public IActivator NextActivator
		{
			[Token(Token = "0x6001E18")]
			[Address(RVA = "0x4B87AC0", Offset = "0x4B866C0", VA = "0x184B87AC0", Slot = "6")]
			get
			{
				return null;
			}
		}
	}
}
