using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005558 RID: 21848
	[Token(Token = "0x2005558")]
	public class RoguelikeRedrawCopperRequest
	{
		// Token: 0x060201F6 RID: 131574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201F6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeRedrawCopperRequest()
		{
		}

		// Token: 0x0402B655 RID: 177749
		[Token(Token = "0x402B655")]
		[FieldOffset(Offset = "0x10")]
		public List<string> freezeIndexes;
	}
}
