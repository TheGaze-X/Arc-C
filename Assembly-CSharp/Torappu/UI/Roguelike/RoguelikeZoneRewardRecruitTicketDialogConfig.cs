using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005218 RID: 21016
	[Token(Token = "0x2005218")]
	public class RoguelikeZoneRewardRecruitTicketDialogConfig : IRoguelikeZoneRewardDialogConfig, IHotfixable
	{
		// Token: 0x17004872 RID: 18546
		// (get) Token: 0x0601F037 RID: 127031 RVA: 0x000B0778 File Offset: 0x000AE978
		[Token(Token = "0x17004872")]
		public RoguelikeGameItemType showItemType
		{
			[Token(Token = "0x601F037")]
			[Address(RVA = "0x18C3CF0", Offset = "0x18C28F0", VA = "0x1818C3CF0", Slot = "4")]
			get
			{
				return RoguelikeGameItemType.NONE;
			}
		}

		// Token: 0x17004873 RID: 18547
		// (get) Token: 0x0601F038 RID: 127032 RVA: 0x000B0790 File Offset: 0x000AE990
		[Token(Token = "0x17004873")]
		public DialogType dialogType
		{
			[Token(Token = "0x601F038")]
			[Address(RVA = "0x18C3C90", Offset = "0x18C2890", VA = "0x1818C3C90", Slot = "5")]
			get
			{
				return DialogType.RELIC;
			}
		}

		// Token: 0x17004874 RID: 18548
		// (get) Token: 0x0601F039 RID: 127033 RVA: 0x000B07A8 File Offset: 0x000AE9A8
		[Token(Token = "0x17004874")]
		public int weight
		{
			[Token(Token = "0x601F039")]
			[Address(RVA = "0x18C3D50", Offset = "0x18C2950", VA = "0x1818C3D50", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601F03A RID: 127034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F03A")]
		[Address(RVA = "0x18C3BC0", Offset = "0x18C27C0", VA = "0x1818C3BC0", Slot = "7")]
		public string GetDialogPath(string topicId)
		{
			return null;
		}

		// Token: 0x0601F03B RID: 127035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F03B")]
		[Address(RVA = "0x18C3C30", Offset = "0x18C2830", VA = "0x1818C3C30")]
		public RoguelikeZoneRewardRecruitTicketDialogConfig()
		{
		}

		// Token: 0x0402999D RID: 170397
		[Token(Token = "0x402999D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showItemType;

		// Token: 0x0402999E RID: 170398
		[Token(Token = "0x402999E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dialogType;

		// Token: 0x0402999F RID: 170399
		[Token(Token = "0x402999F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_weight;

		// Token: 0x040299A0 RID: 170400
		[Token(Token = "0x40299A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDialogPath;

		// Token: 0x040299A1 RID: 170401
		[Token(Token = "0x40299A1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
