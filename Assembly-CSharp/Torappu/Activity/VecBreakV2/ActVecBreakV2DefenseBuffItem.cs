using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E0F RID: 28175
	[Token(Token = "0x2006E0F")]
	public class ActVecBreakV2DefenseBuffItem : ActVecBreakV2DefenseStageBaseItem
	{
		// Token: 0x060281B8 RID: 164280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281B8")]
		[Address(RVA = "0x235E280", Offset = "0x235CE80", VA = "0x18235E280", Slot = "4")]
		public override void Render(ActVecBreakV2DefenseStageBaseItem.InputParam input)
		{
		}

		// Token: 0x060281B9 RID: 164281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281B9")]
		[Address(RVA = "0x235E820", Offset = "0x235D420", VA = "0x18235E820")]
		private void _RegisterTutorialGOIfNeed(ActVecBreakV2DefenseStageBuffItemModel buffItemModel)
		{
		}

		// Token: 0x060281BA RID: 164282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281BA")]
		[Address(RVA = "0x235E990", Offset = "0x235D590", VA = "0x18235E990")]
		private static void _RenderBGPanel(ActVecBreakV2DefenseStageBuffItemModel model, ActVecBreakV2DefenseStageBaseItem.InputParam input, ActVecBreakV2DefenseBuffBackgroundPanel panel, ActVecBreakV2DefenseStageBaseItem.BackgroundType bgType)
		{
		}

		// Token: 0x060281BB RID: 164283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281BB")]
		[Address(RVA = "0x235E710", Offset = "0x235D310", VA = "0x18235E710")]
		public void SelectStage()
		{
		}

		// Token: 0x060281BC RID: 164284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281BC")]
		[Address(RVA = "0x235EAD0", Offset = "0x235D6D0", VA = "0x18235EAD0")]
		public ActVecBreakV2DefenseBuffItem()
		{
		}

		// Token: 0x04038E9F RID: 233119
		[Token(Token = "0x4038E9F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActVecBreakV2DefenseBuffBackgroundPanel _singlePanel;

		// Token: 0x04038EA0 RID: 233120
		[Token(Token = "0x4038EA0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActVecBreakV2DefenseBuffBackgroundPanel _groupLeftPanel;

		// Token: 0x04038EA1 RID: 233121
		[Token(Token = "0x4038EA1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActVecBreakV2DefenseBuffBackgroundPanel _groupMiddlePanel;

		// Token: 0x04038EA2 RID: 233122
		[Token(Token = "0x4038EA2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ActVecBreakV2DefenseBuffBackgroundPanel _groupRightPanel;

		// Token: 0x04038EA3 RID: 233123
		[Token(Token = "0x4038EA3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _buffIcon;

		// Token: 0x04038EA4 RID: 233124
		[Token(Token = "0x4038EA4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _buffNotCompleteColor;

		// Token: 0x04038EA5 RID: 233125
		[Token(Token = "0x4038EA5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _buffCompleteNotSelectColor;

		// Token: 0x04038EA6 RID: 233126
		[Token(Token = "0x4038EA6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _buffCompleteSelectColor;

		// Token: 0x04038EA7 RID: 233127
		[Token(Token = "0x4038EA7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _buffFullSelectConflictColor;

		// Token: 0x04038EA8 RID: 233128
		[Token(Token = "0x4038EA8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool _hasFullSelectConflict;

		// Token: 0x04038EA9 RID: 233129
		[Token(Token = "0x4038EA9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _tutorialBtn;

		// Token: 0x04038EAA RID: 233130
		[Token(Token = "0x4038EAA")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04038EAB RID: 233131
		[Token(Token = "0x4038EAB")]
		[FieldOffset(Offset = "0xA8")]
		private string m_stageId;

		// Token: 0x04038EAC RID: 233132
		[Token(Token = "0x4038EAC")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasRegisterInTutorial;

		// Token: 0x04038EAD RID: 233133
		[Token(Token = "0x4038EAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038EAE RID: 233134
		[Token(Token = "0x4038EAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGOIfNeed;

		// Token: 0x04038EAF RID: 233135
		[Token(Token = "0x4038EAF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderBGPanel;

		// Token: 0x04038EB0 RID: 233136
		[Token(Token = "0x4038EB0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SelectStage;

		// Token: 0x04038EB1 RID: 233137
		[Token(Token = "0x4038EB1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
