using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000360 RID: 864
	[Token(Token = "0x2000360")]
	public abstract class GatewayIPAddressInformation
	{
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001828 RID: 6184
		[Token(Token = "0x1700054F")]
		public abstract IPAddress Address { [Token(Token = "0x6001828")] get; }

		// Token: 0x06001829 RID: 6185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001829")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected GatewayIPAddressInformation()
		{
		}
	}
}
