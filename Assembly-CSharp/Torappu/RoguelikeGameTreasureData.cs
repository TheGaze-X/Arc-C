using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001233 RID: 4659
	[Token(Token = "0x2001233")]
	public class RoguelikeGameTreasureData
	{
		// Token: 0x06007032 RID: 28722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007032")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameTreasureData()
		{
		}

		// Token: 0x0400648A RID: 25738
		[Token(Token = "0x400648A")]
		[FieldOffset(Offset = "0x10")]
		public string treasureId;

		// Token: 0x0400648B RID: 25739
		[Token(Token = "0x400648B")]
		[FieldOffset(Offset = "0x18")]
		public string groupId;

		// Token: 0x0400648C RID: 25740
		[Token(Token = "0x400648C")]
		[FieldOffset(Offset = "0x20")]
		public int subIndex;

		// Token: 0x0400648D RID: 25741
		[Token(Token = "0x400648D")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x0400648E RID: 25742
		[Token(Token = "0x400648E")]
		[FieldOffset(Offset = "0x30")]
		public string usage;
	}
}
