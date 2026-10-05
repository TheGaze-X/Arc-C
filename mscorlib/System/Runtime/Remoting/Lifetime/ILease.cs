using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Lifetime
{
	// Token: 0x02000382 RID: 898
	[Token(Token = "0x2000382")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface ILease
	{
		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001D60 RID: 7520
		[Token(Token = "0x17000363")]
		System.TimeSpan CurrentLeaseTime { [Token(Token = "0x6001D60")] get; }

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001D61 RID: 7521
		[Token(Token = "0x17000364")]
		LeaseState CurrentState { [Token(Token = "0x6001D61")] get; }

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001D62 RID: 7522
		[Token(Token = "0x17000365")]
		System.TimeSpan RenewOnCallTime { [Token(Token = "0x6001D62")] get; }

		// Token: 0x06001D63 RID: 7523
		[Token(Token = "0x6001D63")]
		System.TimeSpan Renew(System.TimeSpan renewalTime);
	}
}
