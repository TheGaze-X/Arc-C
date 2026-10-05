using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003EA5 RID: 16037
	[Token(Token = "0x2003EA5")]
	public class SpecialOperatorBoardLvlupEvolveTabView : SpecialOperatorBoardLvlupTabView
	{
		// Token: 0x06018E53 RID: 101971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E53")]
		[Address(RVA = "0x118C4A0", Offset = "0x118B0A0", VA = "0x18118C4A0", Slot = "4")]
		public override void Render(SpecialOperatorBoardLvlupModel model, SpecialOperatorBoardLvlupTabView.Param param)
		{
		}

		// Token: 0x06018E54 RID: 101972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E54")]
		[Address(RVA = "0x118C710", Offset = "0x118B310", VA = "0x18118C710")]
		public SpecialOperatorBoardLvlupEvolveTabView()
		{
		}

		// Token: 0x06018E55 RID: 101973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E55")]
		[Address(RVA = "0x1188CF0", Offset = "0x11878F0", VA = "0x181188CF0")]
		private void <>xLuaBaseProxy_Render(SpecialOperatorBoardLvlupModel P0, SpecialOperatorBoardLvlupTabView.Param P1)
		{
		}

		// Token: 0x0401EB3B RID: 125755
		[Token(Token = "0x401EB3B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0401EB3C RID: 125756
		[Token(Token = "0x401EB3C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _level;

		// Token: 0x0401EB3D RID: 125757
		[Token(Token = "0x401EB3D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelCanUpgrade;

		// Token: 0x0401EB3E RID: 125758
		[Token(Token = "0x401EB3E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0401EB3F RID: 125759
		[Token(Token = "0x401EB3F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x0401EB40 RID: 125760
		[Token(Token = "0x401EB40")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _colorCanUpgrade;

		// Token: 0x0401EB41 RID: 125761
		[Token(Token = "0x401EB41")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _infoCanvasGroup;

		// Token: 0x0401EB42 RID: 125762
		[Token(Token = "0x401EB42")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _infoSelectedAlpha;

		// Token: 0x0401EB43 RID: 125763
		[Token(Token = "0x401EB43")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float _infoUnselectedAlpha;

		// Token: 0x0401EB44 RID: 125764
		[Token(Token = "0x401EB44")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401EB45 RID: 125765
		[Token(Token = "0x401EB45")]
		[FieldOffset(Offset = "0xB8")]
		private int m_evolvePhase;

		// Token: 0x0401EB46 RID: 125766
		[Token(Token = "0x401EB46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EB47 RID: 125767
		[Token(Token = "0x401EB47")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
