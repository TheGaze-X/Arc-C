using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020007A8 RID: 1960
	[Token(Token = "0x20007A8")]
	[Serializable]
	public struct MailGet : ISharedItemModel, IGachaResultHolder
	{
		// Token: 0x06006426 RID: 25638 RVA: 0x00030558 File Offset: 0x0002E758
		[Token(Token = "0x6006426")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "4")]
		public ItemType GetItemType()
		{
			return ItemType.NONE;
		}

		// Token: 0x06006427 RID: 25639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006427")]
		[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x06006428 RID: 25640 RVA: 0x00030570 File Offset: 0x0002E770
		[Token(Token = "0x6006428")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x06006429 RID: 25641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006429")]
		[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0", Slot = "7")]
		public void SetItemCount(int count_)
		{
		}

		// Token: 0x0600642A RID: 25642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600642A")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
		public GachaResult GetGachaResult()
		{
			return null;
		}

		// Token: 0x04003098 RID: 12440
		[Token(Token = "0x4003098")]
		[FieldOffset(Offset = "0x0")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType type;

		// Token: 0x04003099 RID: 12441
		[Token(Token = "0x4003099")]
		[FieldOffset(Offset = "0x8")]
		public string id;

		// Token: 0x0400309A RID: 12442
		[Token(Token = "0x400309A")]
		[FieldOffset(Offset = "0x10")]
		public GachaResult charGet;

		// Token: 0x0400309B RID: 12443
		[Token(Token = "0x400309B")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
