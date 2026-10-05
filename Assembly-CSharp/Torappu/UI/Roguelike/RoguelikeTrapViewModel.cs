using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051D6 RID: 20950
	[Token(Token = "0x20051D6")]
	public class RoguelikeTrapViewModel : IRoguelikeRelicViewModel, IHotfixable
	{
		// Token: 0x0601EF08 RID: 126728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF08")]
		[Address(RVA = "0x18C3540", Offset = "0x18C2140", VA = "0x1818C3540", Slot = "4")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x0601EF09 RID: 126729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF09")]
		[Address(RVA = "0x18C34D0", Offset = "0x18C20D0", VA = "0x1818C34D0", Slot = "5")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x0601EF0A RID: 126730 RVA: 0x000B0340 File Offset: 0x000AE540
		[Token(Token = "0x601EF0A")]
		[Address(RVA = "0x18C35A0", Offset = "0x18C21A0", VA = "0x1818C35A0", Slot = "6")]
		public RoguelikeMenuRelicItemType GetRelicItemType()
		{
			return RoguelikeMenuRelicItemType.RELIC;
		}

		// Token: 0x0601EF0B RID: 126731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF0B")]
		[Address(RVA = "0x18C3310", Offset = "0x18C1F10", VA = "0x1818C3310")]
		public static RoguelikeTrapViewModel Create(string topicId, PlayerRoguelikeV2.CurrentData.Trap trap)
		{
			return null;
		}

		// Token: 0x0601EF0C RID: 126732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF0C")]
		[Address(RVA = "0x18C3160", Offset = "0x18C1D60", VA = "0x1818C3160")]
		public static RoguelikeTrapViewModel Create(string topicId, string trapId, long ts = -1L)
		{
			return null;
		}

		// Token: 0x0601EF0D RID: 126733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF0D")]
		[Address(RVA = "0x18C3600", Offset = "0x18C2200", VA = "0x1818C3600")]
		public RoguelikeTrapViewModel()
		{
		}

		// Token: 0x04029844 RID: 170052
		[Token(Token = "0x4029844")]
		private const string TRAP_ID = "ROGUELIKE_MENU_TRAP_ITEM";

		// Token: 0x04029845 RID: 170053
		[Token(Token = "0x4029845")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04029846 RID: 170054
		[Token(Token = "0x4029846")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x04029847 RID: 170055
		[Token(Token = "0x4029847")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04029848 RID: 170056
		[Token(Token = "0x4029848")]
		[FieldOffset(Offset = "0x28")]
		public string usage;

		// Token: 0x04029849 RID: 170057
		[Token(Token = "0x4029849")]
		[FieldOffset(Offset = "0x30")]
		public string subIcon;

		// Token: 0x0402984A RID: 170058
		[Token(Token = "0x402984A")]
		[FieldOffset(Offset = "0x38")]
		public bool canSacrifice;

		// Token: 0x0402984B RID: 170059
		[Token(Token = "0x402984B")]
		[FieldOffset(Offset = "0x40")]
		public long ts;

		// Token: 0x0402984C RID: 170060
		[Token(Token = "0x402984C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetItemId;

		// Token: 0x0402984D RID: 170061
		[Token(Token = "0x402984D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetId;

		// Token: 0x0402984E RID: 170062
		[Token(Token = "0x402984E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetRelicItemType;

		// Token: 0x0402984F RID: 170063
		[Token(Token = "0x402984F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04029850 RID: 170064
		[Token(Token = "0x4029850")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_Create;

		// Token: 0x04029851 RID: 170065
		[Token(Token = "0x4029851")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
