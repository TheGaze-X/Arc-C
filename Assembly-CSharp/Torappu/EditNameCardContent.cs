using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200073B RID: 1851
	[Token(Token = "0x200073B")]
	public class EditNameCardContent : IJsonSerializeHandler
	{
		// Token: 0x060063A5 RID: 25509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EditNameCardContent()
		{
		}

		// Token: 0x04002FAA RID: 12202
		[Token(Token = "0x4002FAA")]
		[FieldOffset(Offset = "0x10")]
		public string skinId;

		// Token: 0x04002FAB RID: 12203
		[Token(Token = "0x4002FAB")]
		[FieldOffset(Offset = "0x18")]
		public List<string> component;

		// Token: 0x04002FAC RID: 12204
		[Token(Token = "0x4002FAC")]
		[FieldOffset(Offset = "0x20")]
		public PlayerNameCardMisc misc;

		// Token: 0x04002FAD RID: 12205
		[Token(Token = "0x4002FAD")]
		[FieldOffset(Offset = "0x28")]
		public int skinTmpl;
	}
}
