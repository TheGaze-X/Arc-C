using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Config
{
	// Token: 0x0200024A RID: 586
	[Token(Token = "0x200024A")]
	public struct DynConfigRequest : IHotfixable
	{
		// Token: 0x06000D50 RID: 3408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x5580710", Offset = "0x557F310", VA = "0x185580710")]
		public string MakeRequestUrl(string rootUrl, string split)
		{
			return null;
		}

		// Token: 0x04000D6C RID: 3436
		[Token(Token = "0x4000D6C")]
		[FieldOffset(Offset = "0x0")]
		public int appid;

		// Token: 0x04000D6D RID: 3437
		[Token(Token = "0x4000D6D")]
		[FieldOffset(Offset = "0x8")]
		public string env;

		// Token: 0x04000D6E RID: 3438
		[Token(Token = "0x4000D6E")]
		[FieldOffset(Offset = "0x10")]
		public string platform;

		// Token: 0x04000D6F RID: 3439
		[Token(Token = "0x4000D6F")]
		[FieldOffset(Offset = "0x18")]
		public string channel;

		// Token: 0x04000D70 RID: 3440
		[Token(Token = "0x4000D70")]
		[FieldOffset(Offset = "0x20")]
		public string configName;

		// Token: 0x04000D71 RID: 3441
		[Token(Token = "0x4000D71")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate275 __Hotfix0_MakeRequestUrl;
	}
}
