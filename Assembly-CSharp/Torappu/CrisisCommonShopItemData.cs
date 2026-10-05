using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006D9 RID: 1753
	[Token(Token = "0x20006D9")]
	public class CrisisCommonShopItemData
	{
		// Token: 0x06006328 RID: 25384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006328")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisCommonShopItemData()
		{
		}

		// Token: 0x04002ED9 RID: 11993
		[Token(Token = "0x4002ED9")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04002EDA RID: 11994
		[Token(Token = "0x4002EDA")]
		[FieldOffset(Offset = "0x18")]
		public string displayName;

		// Token: 0x04002EDB RID: 11995
		[Token(Token = "0x4002EDB")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle item;

		// Token: 0x04002EDC RID: 11996
		[Token(Token = "0x4002EDC")]
		[FieldOffset(Offset = "0x28")]
		public string progressGoodId;

		// Token: 0x04002EDD RID: 11997
		[Token(Token = "0x4002EDD")]
		[FieldOffset(Offset = "0x30")]
		public int price;

		// Token: 0x04002EDE RID: 11998
		[Token(Token = "0x4002EDE")]
		[FieldOffset(Offset = "0x34")]
		public int availCount;

		// Token: 0x04002EDF RID: 11999
		[Token(Token = "0x4002EDF")]
		[FieldOffset(Offset = "0x38")]
		public long itemSupplyTime;
	}
}
