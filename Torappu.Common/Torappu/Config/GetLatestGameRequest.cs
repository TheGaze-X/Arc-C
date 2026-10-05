using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Config
{
	// Token: 0x0200024C RID: 588
	[Token(Token = "0x200024C")]
	public struct GetLatestGameRequest : IHotfixable
	{
		// Token: 0x06000D5B RID: 3419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D5B")]
		[Address(RVA = "0x55821F0", Offset = "0x5580DF0", VA = "0x1855821F0")]
		public string MakeRequestUrl(string baseUrl)
		{
			return null;
		}

		// Token: 0x04000D76 RID: 3446
		[Token(Token = "0x4000D76")]
		[FieldOffset(Offset = "0x0")]
		public string appcode;

		// Token: 0x04000D77 RID: 3447
		[Token(Token = "0x4000D77")]
		[FieldOffset(Offset = "0x8")]
		public string channel;

		// Token: 0x04000D78 RID: 3448
		[Token(Token = "0x4000D78")]
		[FieldOffset(Offset = "0x10")]
		public string version;

		// Token: 0x04000D79 RID: 3449
		[Token(Token = "0x4000D79")]
		[FieldOffset(Offset = "0x18")]
		public string platform;

		// Token: 0x04000D7A RID: 3450
		[Token(Token = "0x4000D7A")]
		[FieldOffset(Offset = "0x20")]
		public string sub_channel;

		// Token: 0x04000D7B RID: 3451
		[Token(Token = "0x4000D7B")]
		[FieldOffset(Offset = "0x28")]
		public string source;

		// Token: 0x04000D7C RID: 3452
		[Token(Token = "0x4000D7C")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate276 __Hotfix0_MakeRequestUrl;
	}
}
