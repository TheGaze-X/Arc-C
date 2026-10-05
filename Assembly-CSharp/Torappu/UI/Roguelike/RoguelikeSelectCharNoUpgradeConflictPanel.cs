using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005483 RID: 21635
	[Token(Token = "0x2005483")]
	public class RoguelikeSelectCharNoUpgradeConflictPanel : RoguelikeSelectCharConflictPanel
	{
		// Token: 0x17004AA8 RID: 19112
		// (get) Token: 0x0601FD60 RID: 130400 RVA: 0x000B3778 File Offset: 0x000B1978
		[Token(Token = "0x17004AA8")]
		public override PanelType panelType
		{
			[Token(Token = "0x601FD60")]
			[Address(RVA = "0x19FCD40", Offset = "0x19FB940", VA = "0x1819FCD40", Slot = "4")]
			get
			{
				return PanelType.SP_CHAR;
			}
		}

		// Token: 0x0601FD61 RID: 130401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD61")]
		[Address(RVA = "0x19FCCA0", Offset = "0x19FB8A0", VA = "0x1819FCCA0")]
		public RoguelikeSelectCharNoUpgradeConflictPanel()
		{
		}

		// Token: 0x0402AE36 RID: 175670
		[Token(Token = "0x402AE36")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0402AE37 RID: 175671
		[Token(Token = "0x402AE37")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
