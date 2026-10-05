using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005484 RID: 21636
	[Token(Token = "0x2005484")]
	public class RoguelikeSelectCharSpConflictPanel : RoguelikeSelectCharConflictPanel
	{
		// Token: 0x17004AA9 RID: 19113
		// (get) Token: 0x0601FD62 RID: 130402 RVA: 0x000B3790 File Offset: 0x000B1990
		[Token(Token = "0x17004AA9")]
		public override PanelType panelType
		{
			[Token(Token = "0x601FD62")]
			[Address(RVA = "0x19FCEE0", Offset = "0x19FBAE0", VA = "0x1819FCEE0", Slot = "4")]
			get
			{
				return PanelType.SP_CHAR;
			}
		}

		// Token: 0x0601FD63 RID: 130403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD63")]
		[Address(RVA = "0x19FCDA0", Offset = "0x19FB9A0", VA = "0x1819FCDA0")]
		public void Render(string conflictSpChar)
		{
		}

		// Token: 0x0601FD64 RID: 130404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FD64")]
		[Address(RVA = "0x19FCE40", Offset = "0x19FBA40", VA = "0x1819FCE40")]
		public RoguelikeSelectCharSpConflictPanel()
		{
		}

		// Token: 0x0402AE38 RID: 175672
		[Token(Token = "0x402AE38")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _conflictSpCharId;

		// Token: 0x0402AE39 RID: 175673
		[Token(Token = "0x402AE39")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0402AE3A RID: 175674
		[Token(Token = "0x402AE3A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AE3B RID: 175675
		[Token(Token = "0x402AE3B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
