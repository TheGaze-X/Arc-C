using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200078C RID: 1932
	[Token(Token = "0x200078C")]
	[Serializable]
	public struct ItemGet : ISharedItemModel, IGachaResultHolder
	{
		// Token: 0x06006408 RID: 25608 RVA: 0x00030528 File Offset: 0x0002E728
		[Token(Token = "0x6006408")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "4")]
		public ItemType GetItemType()
		{
			return ItemType.NONE;
		}

		// Token: 0x06006409 RID: 25609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006409")]
		[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x0600640A RID: 25610 RVA: 0x00030540 File Offset: 0x0002E740
		[Token(Token = "0x600640A")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x0600640B RID: 25611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640B")]
		[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0", Slot = "7")]
		public void SetItemCount(int count_)
		{
		}

		// Token: 0x0600640C RID: 25612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600640C")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
		public GachaResult GetGachaResult()
		{
			return null;
		}

		// Token: 0x04003051 RID: 12369
		[Token(Token = "0x4003051")]
		[FieldOffset(Offset = "0x0")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType type;

		// Token: 0x04003052 RID: 12370
		[Token(Token = "0x4003052")]
		[FieldOffset(Offset = "0x8")]
		public string id;

		// Token: 0x04003053 RID: 12371
		[Token(Token = "0x4003053")]
		[FieldOffset(Offset = "0x10")]
		public GachaResult charGet;

		// Token: 0x04003054 RID: 12372
		[Token(Token = "0x4003054")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
