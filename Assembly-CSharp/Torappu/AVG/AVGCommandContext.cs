using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F12 RID: 7954
	[Token(Token = "0x2001F12")]
	public class AVGCommandContext : IHotfixable
	{
		// Token: 0x0600C550 RID: 50512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C550")]
		[Address(RVA = "0x341E360", Offset = "0x341CF60", VA = "0x18341E360")]
		public AVGCommandContext()
		{
		}

		// Token: 0x0400CA03 RID: 51715
		[Token(Token = "0x400CA03")]
		[FieldOffset(Offset = "0x10")]
		public int commandIndex;

		// Token: 0x0400CA04 RID: 51716
		[Token(Token = "0x400CA04")]
		[FieldOffset(Offset = "0x14")]
		public int blockStartIndex;

		// Token: 0x0400CA05 RID: 51717
		[Token(Token = "0x400CA05")]
		[FieldOffset(Offset = "0x18")]
		public int blockEndIndex;

		// Token: 0x0400CA06 RID: 51718
		[Token(Token = "0x400CA06")]
		[FieldOffset(Offset = "0x20")]
		public List<Command> context;

		// Token: 0x0400CA07 RID: 51719
		[Token(Token = "0x400CA07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
