using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011B9 RID: 4537
	[Token(Token = "0x20011B9")]
	public class RoguelikeCopperData
	{
		// Token: 0x06006FA3 RID: 28579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeCopperData()
		{
		}

		// Token: 0x0400611D RID: 24861
		[Token(Token = "0x400611D")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400611E RID: 24862
		[Token(Token = "0x400611E")]
		[FieldOffset(Offset = "0x18")]
		public string groupId;

		// Token: 0x0400611F RID: 24863
		[Token(Token = "0x400611F")]
		[FieldOffset(Offset = "0x20")]
		public string gildTypeId;

		// Token: 0x04006120 RID: 24864
		[Token(Token = "0x4006120")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeCopperLuckyLevel luckyLevel;

		// Token: 0x04006121 RID: 24865
		[Token(Token = "0x4006121")]
		[FieldOffset(Offset = "0x2C")]
		public RoguelikeCopperBuffType buffType;

		// Token: 0x04006122 RID: 24866
		[Token(Token = "0x4006122")]
		[FieldOffset(Offset = "0x30")]
		public string layerCntDesc;

		// Token: 0x04006123 RID: 24867
		[Token(Token = "0x4006123")]
		[FieldOffset(Offset = "0x38")]
		public List<string> poemList;

		// Token: 0x04006124 RID: 24868
		[Token(Token = "0x4006124")]
		[FieldOffset(Offset = "0x40")]
		public bool alwaysShowCountDown;

		// Token: 0x04006125 RID: 24869
		[Token(Token = "0x4006125")]
		[FieldOffset(Offset = "0x48")]
		public List<string> buffItemIdList;

		// Token: 0x04006126 RID: 24870
		[Token(Token = "0x4006126")]
		[FieldOffset(Offset = "0x50")]
		public bool isAllLuckyLevel;
	}
}
