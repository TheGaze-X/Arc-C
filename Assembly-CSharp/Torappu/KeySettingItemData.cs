using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001018 RID: 4120
	[Token(Token = "0x2001018")]
	public class KeySettingItemData
	{
		// Token: 0x06006D6B RID: 28011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public KeySettingItemData()
		{
		}

		// Token: 0x04005786 RID: 22406
		[Token(Token = "0x4005786")]
		[FieldOffset(Offset = "0x10")]
		public string funcId;

		// Token: 0x04005787 RID: 22407
		[Token(Token = "0x4005787")]
		[FieldOffset(Offset = "0x18")]
		public string funcName;

		// Token: 0x04005788 RID: 22408
		[Token(Token = "0x4005788")]
		[FieldOffset(Offset = "0x20")]
		public bool canBeSet;

		// Token: 0x04005789 RID: 22409
		[Token(Token = "0x4005789")]
		[FieldOffset(Offset = "0x28")]
		public string defaultKeyId;

		// Token: 0x0400578A RID: 22410
		[Token(Token = "0x400578A")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;
	}
}
