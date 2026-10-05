using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001141 RID: 4417
	[Token(Token = "0x2001141")]
	public class ReturnItemData : ISharedItemModel, IComparable
	{
		// Token: 0x06006F17 RID: 28439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F17")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ReturnItemData()
		{
		}

		// Token: 0x06006F18 RID: 28440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F18")]
		[Address(RVA = "0x210FD40", Offset = "0x210E940", VA = "0x18210FD40")]
		public ReturnItemData(string itemId, ItemType type, int count, int sortId)
		{
		}

		// Token: 0x06006F19 RID: 28441 RVA: 0x000324D8 File Offset: 0x000306D8
		[Token(Token = "0x6006F19")]
		[Address(RVA = "0x210FC70", Offset = "0x210E870", VA = "0x18210FC70", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06006F1A RID: 28442 RVA: 0x000324F0 File Offset: 0x000306F0
		[Token(Token = "0x6006F1A")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x06006F1B RID: 28443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F1B")]
		[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0", Slot = "7")]
		public void SetItemCount(int count)
		{
		}

		// Token: 0x06006F1C RID: 28444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F1C")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x06006F1D RID: 28445 RVA: 0x00032508 File Offset: 0x00030708
		[Token(Token = "0x6006F1D")]
		[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "4")]
		public ItemType GetItemType()
		{
			return ItemType.NONE;
		}

		// Token: 0x04005EB4 RID: 24244
		[Token(Token = "0x4005EB4")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005EB5 RID: 24245
		[Token(Token = "0x4005EB5")]
		[FieldOffset(Offset = "0x18")]
		public int count;

		// Token: 0x04005EB6 RID: 24246
		[Token(Token = "0x4005EB6")]
		[FieldOffset(Offset = "0x1C")]
		public ItemType type;

		// Token: 0x04005EB7 RID: 24247
		[Token(Token = "0x4005EB7")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;
	}
}
