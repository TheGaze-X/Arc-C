using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005488 RID: 21640
	[Token(Token = "0x2005488")]
	public class RoguelikeSelectCharTravelConflictPanel : RoguelikeSelectCharConflictPanel
	{
		// Token: 0x17004AAC RID: 19116
		// (get) Token: 0x0601FD6F RID: 130415 RVA: 0x000B37A8 File Offset: 0x000B19A8
		[Token(Token = "0x17004AAC")]
		public override PanelType panelType
		{
			[Token(Token = "0x601FD6F")]
			[Address(RVA = "0x19FD710", Offset = "0x19FC310", VA = "0x1819FD710", Slot = "4")]
			get
			{
				return PanelType.SP_CHAR;
			}
		}

		// Token: 0x0601FD70 RID: 130416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD70")]
		[Address(RVA = "0x19FD670", Offset = "0x19FC270", VA = "0x1819FD670")]
		public RoguelikeSelectCharTravelConflictPanel()
		{
		}

		// Token: 0x0402AE4D RID: 175693
		[Token(Token = "0x402AE4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0402AE4E RID: 175694
		[Token(Token = "0x402AE4E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
