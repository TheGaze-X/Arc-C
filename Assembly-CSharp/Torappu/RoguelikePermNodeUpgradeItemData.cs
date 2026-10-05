using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011B2 RID: 4530
	[Token(Token = "0x20011B2")]
	public class RoguelikePermNodeUpgradeItemData
	{
		// Token: 0x06006F9F RID: 28575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikePermNodeUpgradeItemData()
		{
		}

		// Token: 0x040060F9 RID: 24825
		[Token(Token = "0x40060F9")]
		[FieldOffset(Offset = "0x10")]
		public string upgradeId;

		// Token: 0x040060FA RID: 24826
		[Token(Token = "0x40060FA")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeEventType nodeType;

		// Token: 0x040060FB RID: 24827
		[Token(Token = "0x40060FB")]
		[FieldOffset(Offset = "0x1C")]
		public int nodeLevel;

		// Token: 0x040060FC RID: 24828
		[Token(Token = "0x40060FC")]
		[FieldOffset(Offset = "0x20")]
		public string costItemId;

		// Token: 0x040060FD RID: 24829
		[Token(Token = "0x40060FD")]
		[FieldOffset(Offset = "0x28")]
		public int costItemCount;

		// Token: 0x040060FE RID: 24830
		[Token(Token = "0x40060FE")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		// Token: 0x040060FF RID: 24831
		[Token(Token = "0x40060FF")]
		[FieldOffset(Offset = "0x38")]
		public string nodeName;
	}
}
