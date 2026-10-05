using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003EA4 RID: 16036
	[Token(Token = "0x2003EA4")]
	public class SpecialOperatorBoardLvlupCommonTabView : SpecialOperatorBoardLvlupTabView
	{
		// Token: 0x06018E4F RID: 101967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E4F")]
		[Address(RVA = "0x1188AE0", Offset = "0x11876E0", VA = "0x181188AE0", Slot = "4")]
		public override void Render(SpecialOperatorBoardLvlupModel model, SpecialOperatorBoardLvlupTabView.Param param)
		{
		}

		// Token: 0x06018E50 RID: 101968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E50")]
		[Address(RVA = "0x1188D20", Offset = "0x1187920", VA = "0x181188D20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018E51 RID: 101969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E51")]
		[Address(RVA = "0x1188E20", Offset = "0x1187A20", VA = "0x181188E20")]
		public SpecialOperatorBoardLvlupCommonTabView()
		{
		}

		// Token: 0x06018E52 RID: 101970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E52")]
		[Address(RVA = "0x1188CF0", Offset = "0x11878F0", VA = "0x181188CF0")]
		private void <>xLuaBaseProxy_Render(SpecialOperatorBoardLvlupModel P0, SpecialOperatorBoardLvlupTabView.Param P1)
		{
		}

		// Token: 0x0401EB35 RID: 125749
		[Token(Token = "0x401EB35")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _trackPointHolder;

		// Token: 0x0401EB36 RID: 125750
		[Token(Token = "0x401EB36")]
		[FieldOffset(Offset = "0x60")]
		private bool m_inited;

		// Token: 0x0401EB37 RID: 125751
		[Token(Token = "0x401EB37")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_trackPoint;

		// Token: 0x0401EB38 RID: 125752
		[Token(Token = "0x401EB38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EB39 RID: 125753
		[Token(Token = "0x401EB39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EB3A RID: 125754
		[Token(Token = "0x401EB3A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
