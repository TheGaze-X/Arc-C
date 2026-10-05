using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x02000383 RID: 899
	[Token(Token = "0x2000383")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface ISponsor
	{
		// Token: 0x06001D64 RID: 7524
		[Token(Token = "0x6001D64")]
		System.TimeSpan Renewal(ILease lease);
	}
}
