using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu.Activity
{
	// Token: 0x02006D26 RID: 27942
	[Token(Token = "0x2006D26")]
	public struct RewardItemModel : ISharedItemModel, IGachaResultHolder
	{
		// Token: 0x06027D8D RID: 163213 RVA: 0x000CFA80 File Offset: 0x000CDC80
		[Token(Token = "0x6027D8D")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "4")]
		public ItemType GetItemType()
		{
			return ItemType.NONE;
		}

		// Token: 0x06027D8E RID: 163214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027D8E")]
		[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x06027D8F RID: 163215 RVA: 0x000CFA98 File Offset: 0x000CDC98
		[Token(Token = "0x6027D8F")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x06027D90 RID: 163216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D90")]
		[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0", Slot = "7")]
		public void SetItemCount(int count_)
		{
		}

		// Token: 0x06027D91 RID: 163217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027D91")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
		public GachaResult GetGachaResult()
		{
			return null;
		}

		// Token: 0x040387B4 RID: 231348
		[Token(Token = "0x40387B4")]
		[FieldOffset(Offset = "0x0")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType type;

		// Token: 0x040387B5 RID: 231349
		[Token(Token = "0x40387B5")]
		[FieldOffset(Offset = "0x8")]
		public string id;

		// Token: 0x040387B6 RID: 231350
		[Token(Token = "0x40387B6")]
		[FieldOffset(Offset = "0x10")]
		public GachaResult charGet;

		// Token: 0x040387B7 RID: 231351
		[Token(Token = "0x40387B7")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
