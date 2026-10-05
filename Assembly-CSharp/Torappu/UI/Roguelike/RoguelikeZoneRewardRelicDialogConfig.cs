using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005219 RID: 21017
	[Token(Token = "0x2005219")]
	public class RoguelikeZoneRewardRelicDialogConfig : IRoguelikeZoneRewardDialogConfig, IHotfixable
	{
		// Token: 0x17004875 RID: 18549
		// (get) Token: 0x0601F03C RID: 127036 RVA: 0x000B07C0 File Offset: 0x000AE9C0
		[Token(Token = "0x17004875")]
		public RoguelikeGameItemType showItemType
		{
			[Token(Token = "0x601F03C")]
			[Address(RVA = "0x18C3EE0", Offset = "0x18C2AE0", VA = "0x1818C3EE0", Slot = "4")]
			get
			{
				return RoguelikeGameItemType.NONE;
			}
		}

		// Token: 0x17004876 RID: 18550
		// (get) Token: 0x0601F03D RID: 127037 RVA: 0x000B07D8 File Offset: 0x000AE9D8
		[Token(Token = "0x17004876")]
		public DialogType dialogType
		{
			[Token(Token = "0x601F03D")]
			[Address(RVA = "0x18C3E80", Offset = "0x18C2A80", VA = "0x1818C3E80", Slot = "5")]
			get
			{
				return DialogType.RELIC;
			}
		}

		// Token: 0x17004877 RID: 18551
		// (get) Token: 0x0601F03E RID: 127038 RVA: 0x000B07F0 File Offset: 0x000AE9F0
		[Token(Token = "0x17004877")]
		public int weight
		{
			[Token(Token = "0x601F03E")]
			[Address(RVA = "0x18C3F40", Offset = "0x18C2B40", VA = "0x1818C3F40", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601F03F RID: 127039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F03F")]
		[Address(RVA = "0x18C3DB0", Offset = "0x18C29B0", VA = "0x1818C3DB0", Slot = "7")]
		public string GetDialogPath(string topicId)
		{
			return null;
		}

		// Token: 0x0601F040 RID: 127040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F040")]
		[Address(RVA = "0x18C3E20", Offset = "0x18C2A20", VA = "0x1818C3E20")]
		public RoguelikeZoneRewardRelicDialogConfig()
		{
		}

		// Token: 0x040299A2 RID: 170402
		[Token(Token = "0x40299A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showItemType;

		// Token: 0x040299A3 RID: 170403
		[Token(Token = "0x40299A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dialogType;

		// Token: 0x040299A4 RID: 170404
		[Token(Token = "0x40299A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_weight;

		// Token: 0x040299A5 RID: 170405
		[Token(Token = "0x40299A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDialogPath;

		// Token: 0x040299A6 RID: 170406
		[Token(Token = "0x40299A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
