using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200115B RID: 4443
	[Token(Token = "0x200115B")]
	public class RoguelikeItemBundle : ISharedItemModel
	{
		// Token: 0x06006F36 RID: 28470 RVA: 0x00032580 File Offset: 0x00030780
		[Token(Token = "0x6006F36")]
		[Address(RVA = "0x2111F40", Offset = "0x2110B40", VA = "0x182111F40", Slot = "4")]
		public ItemType GetItemType()
		{
			return ItemType.NONE;
		}

		// Token: 0x06006F37 RID: 28471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F37")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x00032598 File Offset: 0x00030798
		[Token(Token = "0x6006F38")]
		[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "6")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F39")]
		[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20", Slot = "7")]
		public void SetItemCount(int count)
		{
		}

		// Token: 0x06006F3A RID: 28474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F3A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeItemBundle()
		{
		}

		// Token: 0x04005F30 RID: 24368
		[Token(Token = "0x4005F30")]
		[FieldOffset(Offset = "0x10")]
		public int sub;

		// Token: 0x04005F31 RID: 24369
		[Token(Token = "0x4005F31")]
		[FieldOffset(Offset = "0x18")]
		public string id;

		// Token: 0x04005F32 RID: 24370
		[Token(Token = "0x4005F32")]
		[FieldOffset(Offset = "0x20")]
		public int count;
	}
}
