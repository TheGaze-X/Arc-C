using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000362 RID: 866
	[Token(Token = "0x2000362")]
	public abstract class IPAddressInformation
	{
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001835 RID: 6197
		[Token(Token = "0x17000552")]
		public abstract IPAddress Address { [Token(Token = "0x6001835")] get; }

		// Token: 0x06001836 RID: 6198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001836")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected IPAddressInformation()
		{
		}
	}
}
