using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005612 RID: 22034
	[Token(Token = "0x2005612")]
	public class RoguelikeSelectCharGetGuidedConflictPanel : RoguelikeSelectCharConflictPanel
	{
		// Token: 0x17004BB7 RID: 19383
		// (get) Token: 0x06020543 RID: 132419 RVA: 0x000B56B0 File Offset: 0x000B38B0
		[Token(Token = "0x17004BB7")]
		public override PanelType panelType
		{
			[Token(Token = "0x6020543")]
			[Address(RVA = "0x1A89510", Offset = "0x1A88110", VA = "0x181A89510", Slot = "4")]
			get
			{
				return PanelType.SP_CHAR;
			}
		}

		// Token: 0x06020544 RID: 132420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020544")]
		[Address(RVA = "0x1A894B0", Offset = "0x1A880B0", VA = "0x181A894B0")]
		public RoguelikeSelectCharGetGuidedConflictPanel()
		{
		}

		// Token: 0x0402BC1E RID: 179230
		[Token(Token = "0x402BC1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0402BC1F RID: 179231
		[Token(Token = "0x402BC1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
