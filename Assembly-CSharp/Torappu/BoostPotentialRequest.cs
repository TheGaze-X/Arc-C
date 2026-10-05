using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006B7 RID: 1719
	[Token(Token = "0x20006B7")]
	public class BoostPotentialRequest
	{
		// Token: 0x06006300 RID: 25344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006300")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BoostPotentialRequest()
		{
		}

		// Token: 0x04002EA4 RID: 11940
		[Token(Token = "0x4002EA4")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x04002EA5 RID: 11941
		[Token(Token = "0x4002EA5")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x04002EA6 RID: 11942
		[Token(Token = "0x4002EA6")]
		[FieldOffset(Offset = "0x20")]
		public int targetRank;
	}
}
