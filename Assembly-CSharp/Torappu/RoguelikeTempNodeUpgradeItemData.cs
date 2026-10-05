using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011B3 RID: 4531
	[Token(Token = "0x20011B3")]
	public class RoguelikeTempNodeUpgradeItemData
	{
		// Token: 0x06006FA0 RID: 28576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTempNodeUpgradeItemData()
		{
		}

		// Token: 0x04006100 RID: 24832
		[Token(Token = "0x4006100")]
		[FieldOffset(Offset = "0x10")]
		public string upgradeId;

		// Token: 0x04006101 RID: 24833
		[Token(Token = "0x4006101")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeEventType nodeType;

		// Token: 0x04006102 RID: 24834
		[Token(Token = "0x4006102")]
		[FieldOffset(Offset = "0x1C")]
		public int sortId;

		// Token: 0x04006103 RID: 24835
		[Token(Token = "0x4006103")]
		[FieldOffset(Offset = "0x20")]
		public string costItemId;

		// Token: 0x04006104 RID: 24836
		[Token(Token = "0x4006104")]
		[FieldOffset(Offset = "0x28")]
		public int costItemCount;

		// Token: 0x04006105 RID: 24837
		[Token(Token = "0x4006105")]
		[FieldOffset(Offset = "0x30")]
		public string desc;
	}
}
