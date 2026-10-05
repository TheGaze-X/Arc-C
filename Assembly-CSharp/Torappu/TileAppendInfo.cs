using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001360 RID: 4960
	[Token(Token = "0x2001360")]
	[Serializable]
	public class TileAppendInfo
	{
		// Token: 0x06007329 RID: 29481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007329")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TileAppendInfo()
		{
		}

		// Token: 0x04006E16 RID: 28182
		[Token(Token = "0x4006E16")]
		[FieldOffset(Offset = "0x10")]
		public string tileKey;

		// Token: 0x04006E17 RID: 28183
		[Token(Token = "0x4006E17")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04006E18 RID: 28184
		[Token(Token = "0x4006E18")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x04006E19 RID: 28185
		[Token(Token = "0x4006E19")]
		[FieldOffset(Offset = "0x28")]
		public bool isFunctional;
	}
}
