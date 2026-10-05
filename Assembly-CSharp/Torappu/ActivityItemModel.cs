using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000604 RID: 1540
	[Token(Token = "0x2000604")]
	public struct ActivityItemModel : ISharedItemModel, IGachaResultHolder
	{
		// Token: 0x06006227 RID: 25127 RVA: 0x00030240 File Offset: 0x0002E440
		[Token(Token = "0x6006227")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "4")]
		public ItemType GetItemType()
		{
			return ItemType.NONE;
		}

		// Token: 0x06006228 RID: 25128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006228")]
		[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x00030258 File Offset: 0x0002E458
		[Token(Token = "0x6006229")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x0600622A RID: 25130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600622A")]
		[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0", Slot = "7")]
		public void SetItemCount(int count_)
		{
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600622B")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
		public GachaResult GetGachaResult()
		{
			return null;
		}

		// Token: 0x04002D81 RID: 11649
		[Token(Token = "0x4002D81")]
		[FieldOffset(Offset = "0x0")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType type;

		// Token: 0x04002D82 RID: 11650
		[Token(Token = "0x4002D82")]
		[FieldOffset(Offset = "0x8")]
		public string id;

		// Token: 0x04002D83 RID: 11651
		[Token(Token = "0x4002D83")]
		[FieldOffset(Offset = "0x10")]
		public GachaResult charGet;

		// Token: 0x04002D84 RID: 11652
		[Token(Token = "0x4002D84")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
