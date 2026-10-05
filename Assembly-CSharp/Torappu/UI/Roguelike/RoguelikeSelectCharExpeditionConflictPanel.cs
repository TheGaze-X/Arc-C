using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200547E RID: 21630
	[Token(Token = "0x200547E")]
	public class RoguelikeSelectCharExpeditionConflictPanel : RoguelikeSelectCharConflictPanel
	{
		// Token: 0x17004AA7 RID: 19111
		// (get) Token: 0x0601FD5A RID: 130394 RVA: 0x000B3748 File Offset: 0x000B1948
		[Token(Token = "0x17004AA7")]
		public override PanelType panelType
		{
			[Token(Token = "0x601FD5A")]
			[Address(RVA = "0x19FC6A0", Offset = "0x19FB2A0", VA = "0x1819FC6A0", Slot = "4")]
			get
			{
				return PanelType.SP_CHAR;
			}
		}

		// Token: 0x0601FD5B RID: 130395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD5B")]
		[Address(RVA = "0x19FC600", Offset = "0x19FB200", VA = "0x1819FC600")]
		public RoguelikeSelectCharExpeditionConflictPanel()
		{
		}

		// Token: 0x0402AE26 RID: 175654
		[Token(Token = "0x402AE26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0402AE27 RID: 175655
		[Token(Token = "0x402AE27")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
