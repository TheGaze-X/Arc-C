using System;
using Il2CppDummyDll;

namespace Torappu.UI.Monopoly
{
	// Token: 0x0200482C RID: 18476
	[Token(Token = "0x200482C")]
	public class MonopolyMoveRequest
	{
		// Token: 0x0601BEC7 RID: 114375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEC7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MonopolyMoveRequest()
		{
		}

		// Token: 0x0402467A RID: 149114
		[Token(Token = "0x402467A")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0402467B RID: 149115
		[Token(Token = "0x402467B")]
		[FieldOffset(Offset = "0x18")]
		public int index;
	}
}
