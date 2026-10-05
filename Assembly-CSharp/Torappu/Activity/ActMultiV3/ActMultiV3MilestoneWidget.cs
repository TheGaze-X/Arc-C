using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F44 RID: 28484
	[Token(Token = "0x2006F44")]
	public class ActMultiV3MilestoneWidget : TemplateActivityMilestoneWidget
	{
		// Token: 0x06028741 RID: 165697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028741")]
		[Address(RVA = "0x23CCBF0", Offset = "0x23CB7F0", VA = "0x1823CCBF0", Slot = "4")]
		public override void Render(TemplateActivityMilestoneGroupViewModel viewModel)
		{
		}

		// Token: 0x06028742 RID: 165698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028742")]
		[Address(RVA = "0x23CCA00", Offset = "0x23CB600", VA = "0x1823CCA00")]
		public void RenderSeason(ActMultiV3MilestoneViewModel viewModel)
		{
		}

		// Token: 0x06028743 RID: 165699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028743")]
		[Address(RVA = "0x23CCE80", Offset = "0x23CBA80", VA = "0x1823CCE80")]
		private void _InitIfNot(string actId)
		{
		}

		// Token: 0x06028744 RID: 165700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028744")]
		[Address(RVA = "0x23CCFB0", Offset = "0x23CBBB0", VA = "0x1823CCFB0")]
		public ActMultiV3MilestoneWidget()
		{
		}

		// Token: 0x040398A1 RID: 235681
		[Token(Token = "0x40398A1")]
		private const string MAX_FORMAT = "/{0}";

		// Token: 0x040398A2 RID: 235682
		[Token(Token = "0x40398A2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bg;

		// Token: 0x040398A3 RID: 235683
		[Token(Token = "0x40398A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _isMaxGo;

		// Token: 0x040398A4 RID: 235684
		[Token(Token = "0x40398A4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lvlTextHolder;

		// Token: 0x040398A5 RID: 235685
		[Token(Token = "0x40398A5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _lvlNumText;

		// Token: 0x040398A6 RID: 235686
		[Token(Token = "0x40398A6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _progress;

		// Token: 0x040398A7 RID: 235687
		[Token(Token = "0x40398A7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _progObj;

		// Token: 0x040398A8 RID: 235688
		[Token(Token = "0x40398A8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _curPointText;

		// Token: 0x040398A9 RID: 235689
		[Token(Token = "0x40398A9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _maxPointText;

		// Token: 0x040398AA RID: 235690
		[Token(Token = "0x40398AA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _mainRewardContent;

		// Token: 0x040398AB RID: 235691
		[Token(Token = "0x40398AB")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040398AC RID: 235692
		[Token(Token = "0x40398AC")]
		[FieldOffset(Offset = "0x70")]
		private ActMultiV3MilestoneMainRewardView m_mainRewardView;

		// Token: 0x040398AD RID: 235693
		[Token(Token = "0x40398AD")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x040398AE RID: 235694
		[Token(Token = "0x40398AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040398AF RID: 235695
		[Token(Token = "0x40398AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderSeason;

		// Token: 0x040398B0 RID: 235696
		[Token(Token = "0x40398B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040398B1 RID: 235697
		[Token(Token = "0x40398B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
