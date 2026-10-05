using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000863 RID: 2147
	[Token(Token = "0x2000863")]
	public struct RewardItemModel : ISharedItemModel, IGachaResultHolder
	{
		// Token: 0x060064F9 RID: 25849 RVA: 0x00030618 File Offset: 0x0002E818
		[Token(Token = "0x60064F9")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "4")]
		public ItemType GetItemType()
		{
			return ItemType.NONE;
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FA")]
		[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x00030630 File Offset: 0x0002E830
		[Token(Token = "0x60064FB")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FC")]
		[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0", Slot = "7")]
		public void SetItemCount(int count_)
		{
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FD")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
		public GachaResult GetGachaResult()
		{
			return null;
		}

		// Token: 0x0400317D RID: 12669
		[Token(Token = "0x400317D")]
		[FieldOffset(Offset = "0x0")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType type;

		// Token: 0x0400317E RID: 12670
		[Token(Token = "0x400317E")]
		[FieldOffset(Offset = "0x8")]
		public string id;

		// Token: 0x0400317F RID: 12671
		[Token(Token = "0x400317F")]
		[FieldOffset(Offset = "0x10")]
		public GachaResult charGet;

		// Token: 0x04003180 RID: 12672
		[Token(Token = "0x4003180")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}
}
