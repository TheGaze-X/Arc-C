using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000762 RID: 1890
	[Token(Token = "0x2000762")]
	public struct HandBookMissionReward : ISharedItemModel, IGachaResultHolder
	{
		// Token: 0x060063CC RID: 25548 RVA: 0x00030438 File Offset: 0x0002E638
		[Token(Token = "0x60063CC")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "4")]
		public ItemType GetItemType()
		{
			return ItemType.NONE;
		}

		// Token: 0x060063CD RID: 25549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063CD")]
		[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x060063CE RID: 25550 RVA: 0x00030450 File Offset: 0x0002E650
		[Token(Token = "0x60063CE")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x060063CF RID: 25551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CF")]
		[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0", Slot = "7")]
		public void SetItemCount(int count_)
		{
		}

		// Token: 0x060063D0 RID: 25552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063D0")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
		public GachaResult GetGachaResult()
		{
			return null;
		}

		// Token: 0x04002FEF RID: 12271
		[Token(Token = "0x4002FEF")]
		[FieldOffset(Offset = "0x0")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType type;

		// Token: 0x04002FF0 RID: 12272
		[Token(Token = "0x4002FF0")]
		[FieldOffset(Offset = "0x8")]
		public string id;

		// Token: 0x04002FF1 RID: 12273
		[Token(Token = "0x4002FF1")]
		[FieldOffset(Offset = "0x10")]
		public GachaResult charGet;

		// Token: 0x04002FF2 RID: 12274
		[Token(Token = "0x4002FF2")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
