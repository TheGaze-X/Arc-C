using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FB4 RID: 20404
	[Token(Token = "0x2004FB4")]
	public class EnemyDuelMileStoneWidget : TemplateActivityMilestoneWidget
	{
		// Token: 0x0601E508 RID: 124168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E508")]
		[Address(RVA = "0x1806A50", Offset = "0x1805650", VA = "0x181806A50", Slot = "4")]
		public override void Render(TemplateActivityMilestoneGroupViewModel milestoneViewModel)
		{
		}

		// Token: 0x0601E509 RID: 124169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E509")]
		[Address(RVA = "0x1806E10", Offset = "0x1805A10", VA = "0x181806E10")]
		private void _LoadRewardIfNecessary(string actId)
		{
		}

		// Token: 0x0601E50A RID: 124170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E50A")]
		[Address(RVA = "0x1806FD0", Offset = "0x1805BD0", VA = "0x181806FD0")]
		public EnemyDuelMileStoneWidget()
		{
		}

		// Token: 0x040287A6 RID: 165798
		[Token(Token = "0x40287A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _progressTextCurrent;

		// Token: 0x040287A7 RID: 165799
		[Token(Token = "0x40287A7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _progressTextTotal;

		// Token: 0x040287A8 RID: 165800
		[Token(Token = "0x40287A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider _progressBar;

		// Token: 0x040287A9 RID: 165801
		[Token(Token = "0x40287A9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _curLevelText;

		// Token: 0x040287AA RID: 165802
		[Token(Token = "0x40287AA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _isMaxTag;

		// Token: 0x040287AB RID: 165803
		[Token(Token = "0x40287AB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelLevel;

		// Token: 0x040287AC RID: 165804
		[Token(Token = "0x40287AC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _mileStoneName;

		// Token: 0x040287AD RID: 165805
		[Token(Token = "0x40287AD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _rewardName;

		// Token: 0x040287AE RID: 165806
		[Token(Token = "0x40287AE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _rewardText;

		// Token: 0x040287AF RID: 165807
		[Token(Token = "0x40287AF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _rewardContainer;

		// Token: 0x040287B0 RID: 165808
		[Token(Token = "0x40287B0")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040287B1 RID: 165809
		[Token(Token = "0x40287B1")]
		[FieldOffset(Offset = "0x78")]
		private UIItemViewModel m_avatarItemViewModel;

		// Token: 0x040287B2 RID: 165810
		[Token(Token = "0x40287B2")]
		[FieldOffset(Offset = "0x80")]
		private GameObject m_rewardGameObject;

		// Token: 0x040287B3 RID: 165811
		[Token(Token = "0x40287B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040287B4 RID: 165812
		[Token(Token = "0x40287B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadRewardIfNecessary;

		// Token: 0x040287B5 RID: 165813
		[Token(Token = "0x40287B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
