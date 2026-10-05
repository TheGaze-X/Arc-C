using System;
using Il2CppDummyDll;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033BE RID: 13246
	[Token(Token = "0x20033BE")]
	public class BattleSandboxConstructItemListModel
	{
		// Token: 0x06015234 RID: 86580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015234")]
		[Address(RVA = "0xD81D00", Offset = "0xD80900", VA = "0x180D81D00")]
		public void Reset()
		{
		}

		// Token: 0x06015235 RID: 86581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015235")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleSandboxConstructItemListModel()
		{
		}

		// Token: 0x04019341 RID: 103233
		[Token(Token = "0x4019341")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, int> itemList;

		// Token: 0x04019342 RID: 103234
		[Token(Token = "0x4019342")]
		[FieldOffset(Offset = "0x18")]
		public int repairCost;

		// Token: 0x04019343 RID: 103235
		[Token(Token = "0x4019343")]
		[FieldOffset(Offset = "0x20")]
		public string topicId;

		// Token: 0x04019344 RID: 103236
		[Token(Token = "0x4019344")]
		[FieldOffset(Offset = "0x28")]
		public bool canUpgrade;

		// Token: 0x04019345 RID: 103237
		[Token(Token = "0x4019345")]
		[FieldOffset(Offset = "0x29")]
		public bool isUnlock;

		// Token: 0x04019346 RID: 103238
		[Token(Token = "0x4019346")]
		[FieldOffset(Offset = "0x2A")]
		public bool resCostEnough;

		// Token: 0x04019347 RID: 103239
		[Token(Token = "0x4019347")]
		[FieldOffset(Offset = "0x2B")]
		public bool repairCostEnough;
	}
}
