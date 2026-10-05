using System;
using Il2CppDummyDll;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005963 RID: 22883
	[Token(Token = "0x2005963")]
	public struct CrisisV2TipsInfo
	{
		// Token: 0x0402D7AD RID: 186285
		[Token(Token = "0x402D7AD")]
		[FieldOffset(Offset = "0x0")]
		public static CrisisV2TipsInfo EMPTY_INFO;

		// Token: 0x0402D7AE RID: 186286
		[Token(Token = "0x402D7AE")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x0402D7AF RID: 186287
		[Token(Token = "0x402D7AF")]
		[FieldOffset(Offset = "0x8")]
		public string desc;

		// Token: 0x0402D7B0 RID: 186288
		[Token(Token = "0x402D7B0")]
		[FieldOffset(Offset = "0x10")]
		public int score;

		// Token: 0x0402D7B1 RID: 186289
		[Token(Token = "0x402D7B1")]
		[FieldOffset(Offset = "0x14")]
		public int dimension;

		// Token: 0x0402D7B2 RID: 186290
		[Token(Token = "0x402D7B2")]
		[FieldOffset(Offset = "0x18")]
		public CrisisV2MapModel.ActionType actionType;
	}
}
