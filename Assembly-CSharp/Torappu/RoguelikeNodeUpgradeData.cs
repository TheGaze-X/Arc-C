using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011B1 RID: 4529
	[Token(Token = "0x20011B1")]
	public class RoguelikeNodeUpgradeData
	{
		// Token: 0x06006F9E RID: 28574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeNodeUpgradeData()
		{
		}

		// Token: 0x040060F5 RID: 24821
		[Token(Token = "0x40060F5")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeEventType nodeType;

		// Token: 0x040060F6 RID: 24822
		[Token(Token = "0x40060F6")]
		[FieldOffset(Offset = "0x14")]
		public int sortId;

		// Token: 0x040060F7 RID: 24823
		[Token(Token = "0x40060F7")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikePermNodeUpgradeItemData> permItemList;

		// Token: 0x040060F8 RID: 24824
		[Token(Token = "0x40060F8")]
		[FieldOffset(Offset = "0x20")]
		public List<RoguelikeTempNodeUpgradeItemData> tempItemList;
	}
}
