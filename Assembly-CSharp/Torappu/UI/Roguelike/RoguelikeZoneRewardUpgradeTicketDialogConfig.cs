using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200521A RID: 21018
	[Token(Token = "0x200521A")]
	public class RoguelikeZoneRewardUpgradeTicketDialogConfig : IRoguelikeZoneRewardDialogConfig, IHotfixable
	{
		// Token: 0x17004878 RID: 18552
		// (get) Token: 0x0601F041 RID: 127041 RVA: 0x000B0808 File Offset: 0x000AEA08
		[Token(Token = "0x17004878")]
		public RoguelikeGameItemType showItemType
		{
			[Token(Token = "0x601F041")]
			[Address(RVA = "0x18C40D0", Offset = "0x18C2CD0", VA = "0x1818C40D0", Slot = "4")]
			get
			{
				return RoguelikeGameItemType.NONE;
			}
		}

		// Token: 0x17004879 RID: 18553
		// (get) Token: 0x0601F042 RID: 127042 RVA: 0x000B0820 File Offset: 0x000AEA20
		[Token(Token = "0x17004879")]
		public DialogType dialogType
		{
			[Token(Token = "0x601F042")]
			[Address(RVA = "0x18C4070", Offset = "0x18C2C70", VA = "0x1818C4070", Slot = "5")]
			get
			{
				return DialogType.RELIC;
			}
		}

		// Token: 0x1700487A RID: 18554
		// (get) Token: 0x0601F043 RID: 127043 RVA: 0x000B0838 File Offset: 0x000AEA38
		[Token(Token = "0x1700487A")]
		public int weight
		{
			[Token(Token = "0x601F043")]
			[Address(RVA = "0x18C4130", Offset = "0x18C2D30", VA = "0x1818C4130", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601F044 RID: 127044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F044")]
		[Address(RVA = "0x18C3FA0", Offset = "0x18C2BA0", VA = "0x1818C3FA0", Slot = "7")]
		public string GetDialogPath(string topicId)
		{
			return null;
		}

		// Token: 0x0601F045 RID: 127045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F045")]
		[Address(RVA = "0x18C4010", Offset = "0x18C2C10", VA = "0x1818C4010")]
		public RoguelikeZoneRewardUpgradeTicketDialogConfig()
		{
		}

		// Token: 0x040299A7 RID: 170407
		[Token(Token = "0x40299A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showItemType;

		// Token: 0x040299A8 RID: 170408
		[Token(Token = "0x40299A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dialogType;

		// Token: 0x040299A9 RID: 170409
		[Token(Token = "0x40299A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_weight;

		// Token: 0x040299AA RID: 170410
		[Token(Token = "0x40299AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDialogPath;

		// Token: 0x040299AB RID: 170411
		[Token(Token = "0x40299AB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
