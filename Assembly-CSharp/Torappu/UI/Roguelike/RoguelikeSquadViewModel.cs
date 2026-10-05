using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005525 RID: 21797
	[Token(Token = "0x2005525")]
	public class RoguelikeSquadViewModel
	{
		// Token: 0x060200EF RID: 131311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200EF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeSquadViewModel()
		{
		}

		// Token: 0x0402B4B2 RID: 177330
		[Token(Token = "0x402B4B2")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x0402B4B3 RID: 177331
		[Token(Token = "0x402B4B3")]
		[FieldOffset(Offset = "0x14")]
		public int skillIndex;

		// Token: 0x0402B4B4 RID: 177332
		[Token(Token = "0x402B4B4")]
		[FieldOffset(Offset = "0x18")]
		public int skillCount;

		// Token: 0x0402B4B5 RID: 177333
		[Token(Token = "0x402B4B5")]
		[FieldOffset(Offset = "0x20")]
		public string currentEquip;
	}
}
