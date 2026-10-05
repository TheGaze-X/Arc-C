using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000364 RID: 868
	[Token(Token = "0x2000364")]
	public abstract class IPInterfaceProperties
	{
		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600183B RID: 6203
		[Token(Token = "0x17000554")]
		public abstract UnicastIPAddressInformationCollection UnicastAddresses { [Token(Token = "0x600183B")] get; }

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600183C RID: 6204
		[Token(Token = "0x17000555")]
		public abstract GatewayIPAddressInformationCollection GatewayAddresses { [Token(Token = "0x600183C")] get; }

		// Token: 0x0600183D RID: 6205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected IPInterfaceProperties()
		{
		}
	}
}
