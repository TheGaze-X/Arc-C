using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005611 RID: 22033
	[Token(Token = "0x2005611")]
	public class RoguelikeSelectCharGetCandleConflictPanel : RoguelikeSelectCharConflictPanel
	{
		// Token: 0x17004BB6 RID: 19382
		// (get) Token: 0x06020541 RID: 132417 RVA: 0x000B5698 File Offset: 0x000B3898
		[Token(Token = "0x17004BB6")]
		public override PanelType panelType
		{
			[Token(Token = "0x6020541")]
			[Address(RVA = "0x1A72600", Offset = "0x1A71200", VA = "0x181A72600", Slot = "4")]
			get
			{
				return PanelType.SP_CHAR;
			}
		}

		// Token: 0x06020542 RID: 132418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020542")]
		[Address(RVA = "0x1A725A0", Offset = "0x1A711A0", VA = "0x181A725A0")]
		public RoguelikeSelectCharGetCandleConflictPanel()
		{
		}

		// Token: 0x0402BC1C RID: 179228
		[Token(Token = "0x402BC1C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0402BC1D RID: 179229
		[Token(Token = "0x402BC1D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
