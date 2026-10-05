using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Services
{
	// Token: 0x0200037C RID: 892
	[Token(Token = "0x200037C")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface ITrackingHandler
	{
		// Token: 0x06001D34 RID: 7476
		[Token(Token = "0x6001D34")]
		void DisconnectedObject(object obj);

		// Token: 0x06001D35 RID: 7477
		[Token(Token = "0x6001D35")]
		void MarshaledObject(object obj, ObjRef or);

		// Token: 0x06001D36 RID: 7478
		[Token(Token = "0x6001D36")]
		void UnmarshaledObject(object obj, ObjRef or);
	}
}
