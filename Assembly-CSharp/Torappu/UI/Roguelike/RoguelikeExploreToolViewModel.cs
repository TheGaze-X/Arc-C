using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051D9 RID: 20953
	[Token(Token = "0x20051D9")]
	public class RoguelikeExploreToolViewModel : IRoguelikeRelicViewModel, IHotfixable
	{
		// Token: 0x0601EF25 RID: 126757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF25")]
		[Address(RVA = "0x18B9A40", Offset = "0x18B8640", VA = "0x1818B9A40", Slot = "4")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x0601EF26 RID: 126758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF26")]
		[Address(RVA = "0x18B99E0", Offset = "0x18B85E0", VA = "0x1818B99E0", Slot = "5")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x0601EF27 RID: 126759 RVA: 0x000B03A0 File Offset: 0x000AE5A0
		[Token(Token = "0x601EF27")]
		[Address(RVA = "0x18B9AA0", Offset = "0x18B86A0", VA = "0x1818B9AA0", Slot = "6")]
		public RoguelikeMenuRelicItemType GetRelicItemType()
		{
			return RoguelikeMenuRelicItemType.RELIC;
		}

		// Token: 0x0601EF28 RID: 126760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF28")]
		[Address(RVA = "0x18B9670", Offset = "0x18B8270", VA = "0x1818B9670")]
		public static RoguelikeExploreToolViewModel Create(string topicId, PlayerRoguelikeV2.CurrentData.ExploreTool exploreTool)
		{
			return null;
		}

		// Token: 0x0601EF29 RID: 126761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF29")]
		[Address(RVA = "0x18B9830", Offset = "0x18B8430", VA = "0x1818B9830")]
		public static RoguelikeExploreToolViewModel Create(string topicId, string exploreToolId, long ts = -1L)
		{
			return null;
		}

		// Token: 0x0601EF2A RID: 126762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF2A")]
		[Address(RVA = "0x18B9B00", Offset = "0x18B8700", VA = "0x1818B9B00")]
		public RoguelikeExploreToolViewModel()
		{
		}

		// Token: 0x0402987E RID: 170110
		[Token(Token = "0x402987E")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0402987F RID: 170111
		[Token(Token = "0x402987F")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x04029880 RID: 170112
		[Token(Token = "0x4029880")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04029881 RID: 170113
		[Token(Token = "0x4029881")]
		[FieldOffset(Offset = "0x28")]
		public string usage;

		// Token: 0x04029882 RID: 170114
		[Token(Token = "0x4029882")]
		[FieldOffset(Offset = "0x30")]
		public string subIcon;

		// Token: 0x04029883 RID: 170115
		[Token(Token = "0x4029883")]
		[FieldOffset(Offset = "0x38")]
		public long ts;

		// Token: 0x04029884 RID: 170116
		[Token(Token = "0x4029884")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetItemId;

		// Token: 0x04029885 RID: 170117
		[Token(Token = "0x4029885")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetId;

		// Token: 0x04029886 RID: 170118
		[Token(Token = "0x4029886")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetRelicItemType;

		// Token: 0x04029887 RID: 170119
		[Token(Token = "0x4029887")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04029888 RID: 170120
		[Token(Token = "0x4029888")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_Create;

		// Token: 0x04029889 RID: 170121
		[Token(Token = "0x4029889")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
