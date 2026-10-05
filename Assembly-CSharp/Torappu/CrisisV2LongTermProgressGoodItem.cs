using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FBA RID: 4026
	[Token(Token = "0x2000FBA")]
	public class CrisisV2LongTermProgressGoodItem
	{
		// Token: 0x06006D01 RID: 27905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D01")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2LongTermProgressGoodItem()
		{
		}

		// Token: 0x04005569 RID: 21865
		[Token(Token = "0x4005569")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0400556A RID: 21866
		[Token(Token = "0x400556A")]
		[FieldOffset(Offset = "0x18")]
		public int order;

		// Token: 0x0400556B RID: 21867
		[Token(Token = "0x400556B")]
		[FieldOffset(Offset = "0x1C")]
		public int price;

		// Token: 0x0400556C RID: 21868
		[Token(Token = "0x400556C")]
		[FieldOffset(Offset = "0x20")]
		public string displayName;

		// Token: 0x0400556D RID: 21869
		[Token(Token = "0x400556D")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle item;
	}
}
