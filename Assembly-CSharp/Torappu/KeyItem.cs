using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001012 RID: 4114
	[Token(Token = "0x2001012")]
	public class KeyItem
	{
		// Token: 0x06006D68 RID: 28008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D68")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public KeyItem()
		{
		}

		// Token: 0x04005766 RID: 22374
		[Token(Token = "0x4005766")]
		[FieldOffset(Offset = "0x10")]
		public string keyId;

		// Token: 0x04005767 RID: 22375
		[Token(Token = "0x4005767")]
		[FieldOffset(Offset = "0x18")]
		public string keyName;

		// Token: 0x04005768 RID: 22376
		[Token(Token = "0x4005768")]
		[FieldOffset(Offset = "0x20")]
		public bool useIcon;

		// Token: 0x04005769 RID: 22377
		[Token(Token = "0x4005769")]
		[FieldOffset(Offset = "0x24")]
		public KeyCodeType keyCodeType;

		// Token: 0x0400576A RID: 22378
		[Token(Token = "0x400576A")]
		[FieldOffset(Offset = "0x28")]
		public List<int> keyCodes;

		// Token: 0x0400576B RID: 22379
		[Token(Token = "0x400576B")]
		[FieldOffset(Offset = "0x30")]
		public bool canBeSetted;
	}
}
