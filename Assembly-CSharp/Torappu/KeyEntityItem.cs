using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200052F RID: 1327
	[Token(Token = "0x200052F")]
	public class KeyEntityItem
	{
		// Token: 0x06004FB0 RID: 20400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public KeyEntityItem()
		{
		}

		// Token: 0x0400143B RID: 5179
		[Token(Token = "0x400143B")]
		[FieldOffset(Offset = "0x10")]
		public string funcId;

		// Token: 0x0400143C RID: 5180
		[Token(Token = "0x400143C")]
		[FieldOffset(Offset = "0x18")]
		public string keyId;

		// Token: 0x0400143D RID: 5181
		[Token(Token = "0x400143D")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x0400143E RID: 5182
		[Token(Token = "0x400143E")]
		[FieldOffset(Offset = "0x28")]
		public bool canBeSet;
	}
}
