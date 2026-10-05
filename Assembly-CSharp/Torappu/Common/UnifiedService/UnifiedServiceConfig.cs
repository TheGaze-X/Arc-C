using System;
using Il2CppDummyDll;

namespace Torappu.Common.UnifiedService
{
	// Token: 0x020016E7 RID: 5863
	[Token(Token = "0x20016E7")]
	public class UnifiedServiceConfig
	{
		// Token: 0x0600946B RID: 37995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600946B")]
		[Address(RVA = "0x3116A90", Offset = "0x3115690", VA = "0x183116A90")]
		public UnifiedServiceConfig()
		{
		}

		// Token: 0x04008A76 RID: 35446
		[Token(Token = "0x4008A76")]
		[FieldOffset(Offset = "0x10")]
		public string host;

		// Token: 0x04008A77 RID: 35447
		[Token(Token = "0x4008A77")]
		[FieldOffset(Offset = "0x18")]
		public int port;
	}
}
