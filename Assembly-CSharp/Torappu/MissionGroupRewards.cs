using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020007CF RID: 1999
	[Token(Token = "0x20007CF")]
	public struct MissionGroupRewards : ISharedItemModel, IGachaResultHolder
	{
		// Token: 0x06006450 RID: 25680 RVA: 0x00030588 File Offset: 0x0002E788
		[Token(Token = "0x6006450")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "4")]
		public ItemType GetItemType()
		{
			return ItemType.NONE;
		}

		// Token: 0x06006451 RID: 25681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006451")]
		[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x06006452 RID: 25682 RVA: 0x000305A0 File Offset: 0x0002E7A0
		[Token(Token = "0x6006452")]
		[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "6")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x06006453 RID: 25683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006453")]
		[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40", Slot = "7")]
		public void SetItemCount(int count_)
		{
		}

		// Token: 0x06006454 RID: 25684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006454")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "8")]
		public GachaResult GetGachaResult()
		{
			return null;
		}

		// Token: 0x040030DB RID: 12507
		[Token(Token = "0x40030DB")]
		[FieldOffset(Offset = "0x0")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType type;

		// Token: 0x040030DC RID: 12508
		[Token(Token = "0x40030DC")]
		[FieldOffset(Offset = "0x8")]
		public string id;

		// Token: 0x040030DD RID: 12509
		[Token(Token = "0x40030DD")]
		[FieldOffset(Offset = "0x10")]
		public int count;

		// Token: 0x040030DE RID: 12510
		[Token(Token = "0x40030DE")]
		[FieldOffset(Offset = "0x18")]
		public GachaResult charGet;
	}
}
