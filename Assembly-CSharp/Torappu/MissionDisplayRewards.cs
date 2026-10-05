using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200110E RID: 4366
	[Token(Token = "0x200110E")]
	public struct MissionDisplayRewards : ISharedItemModel
	{
		// Token: 0x06006ED0 RID: 28368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED0")]
		[Address(RVA = "0x21080E0", Offset = "0x2106CE0", VA = "0x1821080E0")]
		public MissionDisplayRewards(ItemType type_, string id_, int count_)
		{
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x00032310 File Offset: 0x00030510
		[Token(Token = "0x6006ED1")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "4")]
		public ItemType GetItemType()
		{
			return ItemType.NONE;
		}

		// Token: 0x06006ED2 RID: 28370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ED2")]
		[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "5")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x06006ED3 RID: 28371 RVA: 0x00032328 File Offset: 0x00030528
		[Token(Token = "0x6006ED3")]
		[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "6")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x06006ED4 RID: 28372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED4")]
		[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40", Slot = "7")]
		public void SetItemCount(int count_)
		{
		}

		// Token: 0x04005D91 RID: 23953
		[Token(Token = "0x4005D91")]
		[FieldOffset(Offset = "0x0")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType type;

		// Token: 0x04005D92 RID: 23954
		[Token(Token = "0x4005D92")]
		[FieldOffset(Offset = "0x8")]
		public string id;

		// Token: 0x04005D93 RID: 23955
		[Token(Token = "0x4005D93")]
		[FieldOffset(Offset = "0x10")]
		public int count;
	}
}
