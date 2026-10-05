using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006761 RID: 26465
	[Token(Token = "0x2006761")]
	public class HalfIdleUITopStatusView : DataBinder<HalfIdleUITopStatusProperty>
	{
		// Token: 0x06025F84 RID: 155524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F84")]
		[Address(RVA = "0x20F96B0", Offset = "0x20F82B0", VA = "0x1820F96B0", Slot = "7")]
		public override void OnValueChanged(HalfIdleUITopStatusProperty property)
		{
		}

		// Token: 0x06025F85 RID: 155525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F85")]
		[Address(RVA = "0x20F9900", Offset = "0x20F8500", VA = "0x1820F9900")]
		public void Render(HalfIdleUITopStatusViewModel viewModel)
		{
		}

		// Token: 0x06025F86 RID: 155526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F86")]
		[Address(RVA = "0x20FA670", Offset = "0x20F9270", VA = "0x1820FA670")]
		private void _RenderInternal(HalfIdleUITopStatusViewModel viewModel)
		{
		}

		// Token: 0x06025F87 RID: 155527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F87")]
		[Address(RVA = "0x20F9CE0", Offset = "0x20F88E0", VA = "0x1820F9CE0")]
		private void _RenderInitialize(HalfIdleUITopStatusViewModel viewModel)
		{
		}

		// Token: 0x06025F88 RID: 155528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F88")]
		[Address(RVA = "0x20FB060", Offset = "0x20F9C60", VA = "0x1820FB060")]
		private void _SetColorIfNecessary(bool isOverload)
		{
		}

		// Token: 0x06025F89 RID: 155529 RVA: 0x000C9918 File Offset: 0x000C7B18
		[Token(Token = "0x6025F89")]
		[Address(RVA = "0x20F9B70", Offset = "0x20F8770", VA = "0x1820F9B70")]
		private bool _InitIfNot(HalfIdleUITopStatusViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06025F8A RID: 155530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F8A")]
		[Address(RVA = "0x20FB130", Offset = "0x20F9D30", VA = "0x1820FB130")]
		public HalfIdleUITopStatusView()
		{
		}

		// Token: 0x040356B0 RID: 218800
		[Token(Token = "0x40356B0")]
		private const string TIME_FORMAT = "{0}:{1}";

		// Token: 0x040356B1 RID: 218801
		[Token(Token = "0x40356B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _maxEnemyCapacityText;

		// Token: 0x040356B2 RID: 218802
		[Token(Token = "0x40356B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _enemyCapacityText;

		// Token: 0x040356B3 RID: 218803
		[Token(Token = "0x40356B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lossLifeCountDownContainer;

		// Token: 0x040356B4 RID: 218804
		[Token(Token = "0x40356B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _lossLifeCountdownText;

		// Token: 0x040356B5 RID: 218805
		[Token(Token = "0x40356B5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _lossLifeCountdownAnim;

		// Token: 0x040356B6 RID: 218806
		[Token(Token = "0x40356B6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _normalRemainingTimeContainer;

		// Token: 0x040356B7 RID: 218807
		[Token(Token = "0x40356B7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _normalRemainingTimeText;

		// Token: 0x040356B8 RID: 218808
		[Token(Token = "0x40356B8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _countdownRemainingTimeContainer;

		// Token: 0x040356B9 RID: 218809
		[Token(Token = "0x40356B9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _countdownRemainingTimeText;

		// Token: 0x040356BA RID: 218810
		[Token(Token = "0x40356BA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _currentLifePointText;

		// Token: 0x040356BB RID: 218811
		[Token(Token = "0x40356BB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UILifeLostGroup _lifeLostGroup;

		// Token: 0x040356BC RID: 218812
		[Token(Token = "0x40356BC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Scrollbar _levelProgressScrollbar;

		// Token: 0x040356BD RID: 218813
		[Token(Token = "0x40356BD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _enemyRushIconPrefab;

		// Token: 0x040356BE RID: 218814
		[Token(Token = "0x40356BE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _enemyRushIconContainer;

		// Token: 0x040356BF RID: 218815
		[Token(Token = "0x40356BF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Scrollbar _bossIconScrollbar;

		// Token: 0x040356C0 RID: 218816
		[Token(Token = "0x40356C0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _bossOutOfSliderIcon;

		// Token: 0x040356C1 RID: 218817
		[Token(Token = "0x40356C1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _normalColor;

		// Token: 0x040356C2 RID: 218818
		[Token(Token = "0x40356C2")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Color _warningColor;

		// Token: 0x040356C3 RID: 218819
		[Token(Token = "0x40356C3")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIAnimationLocation _bossIconShowAnim;

		// Token: 0x040356C4 RID: 218820
		[Token(Token = "0x40356C4")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIAnimationLocation _stateWarningAnim;

		// Token: 0x040356C5 RID: 218821
		[Token(Token = "0x40356C5")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIAnimationLocation _loseLifePointAnim;

		// Token: 0x040356C6 RID: 218822
		[Token(Token = "0x40356C6")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIAnimationLocation _bossIconLoopAnim;

		// Token: 0x040356C7 RID: 218823
		[Token(Token = "0x40356C7")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private float _bossIconTweenDuration;

		// Token: 0x040356C8 RID: 218824
		[Token(Token = "0x40356C8")]
		[FieldOffset(Offset = "0x10C")]
		private bool m_inited;

		// Token: 0x040356C9 RID: 218825
		[Token(Token = "0x40356C9")]
		[FieldOffset(Offset = "0x110")]
		private Tween m_bossOnSliderTween;

		// Token: 0x040356CA RID: 218826
		[Token(Token = "0x40356CA")]
		[FieldOffset(Offset = "0x118")]
		private Tween m_enemyOverloadTween;

		// Token: 0x040356CB RID: 218827
		[Token(Token = "0x40356CB")]
		[FieldOffset(Offset = "0x120")]
		private Tween m_loseLifePointTween;

		// Token: 0x040356CC RID: 218828
		[Token(Token = "0x40356CC")]
		[FieldOffset(Offset = "0x128")]
		private Tween m_bossIconLoopTween;

		// Token: 0x040356CD RID: 218829
		[Token(Token = "0x40356CD")]
		[FieldOffset(Offset = "0x130")]
		private Tween m_loseLifeCountdownTween;

		// Token: 0x040356CE RID: 218830
		[Token(Token = "0x40356CE")]
		[FieldOffset(Offset = "0x138")]
		private FP m_cachedBossIconProgress;

		// Token: 0x040356CF RID: 218831
		[Token(Token = "0x40356CF")]
		[FieldOffset(Offset = "0x140")]
		private FP m_cachedPlayTime;

		// Token: 0x040356D0 RID: 218832
		[Token(Token = "0x40356D0")]
		[FieldOffset(Offset = "0x148")]
		private int m_cachedLossLifeCountdown;

		// Token: 0x040356D1 RID: 218833
		[Token(Token = "0x40356D1")]
		[FieldOffset(Offset = "0x14C")]
		private int m_cachedCurrentLifePoint;

		// Token: 0x040356D2 RID: 218834
		[Token(Token = "0x40356D2")]
		[FieldOffset(Offset = "0x150")]
		private int m_cachedLostLifePointByEnemyOverload;

		// Token: 0x040356D3 RID: 218835
		[Token(Token = "0x40356D3")]
		[FieldOffset(Offset = "0x154")]
		private int m_cachedLostLifePointByOthers;

		// Token: 0x040356D4 RID: 218836
		[Token(Token = "0x40356D4")]
		[FieldOffset(Offset = "0x158")]
		private bool m_cachedIsEnemyOverload;

		// Token: 0x040356D5 RID: 218837
		[Token(Token = "0x40356D5")]
		[FieldOffset(Offset = "0x160")]
		private List<GameObject> m_enemyRushIcons;

		// Token: 0x040356D6 RID: 218838
		[Token(Token = "0x40356D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040356D7 RID: 218839
		[Token(Token = "0x40356D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040356D8 RID: 218840
		[Token(Token = "0x40356D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderInternal;

		// Token: 0x040356D9 RID: 218841
		[Token(Token = "0x40356D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderInitialize;

		// Token: 0x040356DA RID: 218842
		[Token(Token = "0x40356DA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetColorIfNecessary;

		// Token: 0x040356DB RID: 218843
		[Token(Token = "0x40356DB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040356DC RID: 218844
		[Token(Token = "0x40356DC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
