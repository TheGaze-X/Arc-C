using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054B3 RID: 21683
	[Token(Token = "0x20054B3")]
	public class RoguelikeCharCardComparer
	{
		// Token: 0x0601FE51 RID: 130641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE51")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeCharCardComparer()
		{
		}

		// Token: 0x0402B052 RID: 176210
		[Token(Token = "0x402B052")]
		public const int HIGHEST_PRIORITY = 0;

		// Token: 0x0402B053 RID: 176211
		[Token(Token = "0x402B053")]
		public const int SECOND_HIGH_PRIORITY = 5;

		// Token: 0x0402B054 RID: 176212
		[Token(Token = "0x402B054")]
		[FieldOffset(Offset = "0x10")]
		public Comparer comparer;

		// Token: 0x0402B055 RID: 176213
		[Token(Token = "0x402B055")]
		[FieldOffset(Offset = "0x18")]
		public int priority;
	}
}
