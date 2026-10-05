using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000363 RID: 867
	[Token(Token = "0x2000363")]
	public abstract class IPGlobalProperties
	{
		// Token: 0x06001837 RID: 6199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001837")]
		[Address(RVA = "0x509D980", Offset = "0x509C580", VA = "0x18509D980")]
		public static IPGlobalProperties GetIPGlobalProperties()
		{
			return null;
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001838")]
		[Address(RVA = "0x509D980", Offset = "0x509C580", VA = "0x18509D980")]
		internal static IPGlobalProperties InternalGetIPGlobalProperties()
		{
			return null;
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001839 RID: 6201
		[Token(Token = "0x17000553")]
		public abstract string DomainName { [Token(Token = "0x6001839")] get; }

		// Token: 0x0600183A RID: 6202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected IPGlobalProperties()
		{
		}
	}
}
