using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005613 RID: 22035
	[Token(Token = "0x2005613")]
	public class RoguelikeSelectCharGetNonGuidedConflictPanel : RoguelikeSelectCharConflictPanel
	{
		// Token: 0x17004BB8 RID: 19384
		// (get) Token: 0x06020545 RID: 132421 RVA: 0x000B56C8 File Offset: 0x000B38C8
		[Token(Token = "0x17004BB8")]
		public override PanelType panelType
		{
			[Token(Token = "0x6020545")]
			[Address(RVA = "0x1A895D0", Offset = "0x1A881D0", VA = "0x181A895D0", Slot = "4")]
			get
			{
				return PanelType.SP_CHAR;
			}
		}

		// Token: 0x06020546 RID: 132422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020546")]
		[Address(RVA = "0x1A89570", Offset = "0x1A88170", VA = "0x181A89570")]
		public RoguelikeSelectCharGetNonGuidedConflictPanel()
		{
		}

		// Token: 0x0402BC20 RID: 179232
		[Token(Token = "0x402BC20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0402BC21 RID: 179233
		[Token(Token = "0x402BC21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
