using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002D7 RID: 727
	[Token(Token = "0x20002D7")]
	internal class ServiceNameStore
	{
		// Token: 0x06001429 RID: 5161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001429")]
		[Address(RVA = "0x505C280", Offset = "0x505AE80", VA = "0x18505C280")]
		public ServiceNameStore()
		{
		}

		// Token: 0x04000AE6 RID: 2790
		[Token(Token = "0x4000AE6")]
		[FieldOffset(Offset = "0x10")]
		private List<string> serviceNames;

		// Token: 0x04000AE7 RID: 2791
		[Token(Token = "0x4000AE7")]
		[FieldOffset(Offset = "0x18")]
		private ServiceNameCollection serviceNameCollection;
	}
}
