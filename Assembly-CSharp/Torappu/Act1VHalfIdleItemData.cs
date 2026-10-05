using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C8A RID: 3210
	[Token(Token = "0x2000C8A")]
	public class Act1VHalfIdleItemData
	{
		// Token: 0x06006962 RID: 26978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006962")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleItemData()
		{
		}

		// Token: 0x0400418C RID: 16780
		[Token(Token = "0x400418C")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0400418D RID: 16781
		[Token(Token = "0x400418D")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x0400418E RID: 16782
		[Token(Token = "0x400418E")]
		[FieldOffset(Offset = "0x20")]
		public Act1VHalfIdleItemType itemType;

		// Token: 0x0400418F RID: 16783
		[Token(Token = "0x400418F")]
		[FieldOffset(Offset = "0x28")]
		public string itemName;

		// Token: 0x04004190 RID: 16784
		[Token(Token = "0x4004190")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;

		// Token: 0x04004191 RID: 16785
		[Token(Token = "0x4004191")]
		[FieldOffset(Offset = "0x38")]
		public string iconId;

		// Token: 0x04004192 RID: 16786
		[Token(Token = "0x4004192")]
		[FieldOffset(Offset = "0x40")]
		public string funcDesc;

		// Token: 0x04004193 RID: 16787
		[Token(Token = "0x4004193")]
		[FieldOffset(Offset = "0x48")]
		public string flavorDesc;

		// Token: 0x04004194 RID: 16788
		[Token(Token = "0x4004194")]
		[FieldOffset(Offset = "0x50")]
		public string obtainApproach;

		// Token: 0x04004195 RID: 16789
		[Token(Token = "0x4004195")]
		[FieldOffset(Offset = "0x58")]
		public bool showInInventory;
	}
}
