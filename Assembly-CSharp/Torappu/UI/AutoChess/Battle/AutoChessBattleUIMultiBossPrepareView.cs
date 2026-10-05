using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x0200648B RID: 25739
	[Token(Token = "0x200648B")]
	public class AutoChessBattleUIMultiBossPrepareView : DataBinder<AutoChessBattleUIViewModelProperty>
	{
		// Token: 0x17005765 RID: 22373
		// (get) Token: 0x0602505A RID: 151642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602505B RID: 151643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005765")]
		public AutoReleasableGroup releaseGrp
		{
			[Token(Token = "0x602505A")]
			[Address(RVA = "0x1FECBC0", Offset = "0x1FEB7C0", VA = "0x181FECBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602505B")]
			[Address(RVA = "0x1FECC20", Offset = "0x1FEB820", VA = "0x181FECC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602505C RID: 151644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602505C")]
		[Address(RVA = "0x1FEBF10", Offset = "0x1FEAB10", VA = "0x181FEBF10", Slot = "7")]
		public override void OnValueChanged(AutoChessBattleUIViewModelProperty property)
		{
		}

		// Token: 0x0602505D RID: 151645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602505D")]
		[Address(RVA = "0x1FEC5E0", Offset = "0x1FEB1E0", VA = "0x181FEC5E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602505E RID: 151646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602505E")]
		[Address(RVA = "0x1FEC910", Offset = "0x1FEB510", VA = "0x181FEC910")]
		private void _PlayAnimIfNeed()
		{
		}

		// Token: 0x0602505F RID: 151647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602505F")]
		[Address(RVA = "0x1FEC1D0", Offset = "0x1FEADD0", VA = "0x181FEC1D0")]
		private Tween _CreateAnim(UIAnimationLocation animLoc)
		{
			return null;
		}

		// Token: 0x06025060 RID: 151648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025060")]
		[Address(RVA = "0x1FEC2B0", Offset = "0x1FEAEB0", VA = "0x181FEC2B0")]
		private Tween _CreateEnterAnim()
		{
			return null;
		}

		// Token: 0x06025061 RID: 151649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025061")]
		[Address(RVA = "0x1FECAE0", Offset = "0x1FEB6E0", VA = "0x181FECAE0")]
		public AutoChessBattleUIMultiBossPrepareView()
		{
		}

		// Token: 0x04033D15 RID: 212245
		[Token(Token = "0x4033D15")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x04033D16 RID: 212246
		[Token(Token = "0x4033D16")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animExpand;

		// Token: 0x04033D17 RID: 212247
		[Token(Token = "0x4033D17")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animExit;

		// Token: 0x04033D18 RID: 212248
		[Token(Token = "0x4033D18")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textTotalHp;

		// Token: 0x04033D19 RID: 212249
		[Token(Token = "0x4033D19")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgBossIcon;

		// Token: 0x04033D1A RID: 212250
		[Token(Token = "0x4033D1A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _playerHpAnimDelay;

		// Token: 0x04033D1B RID: 212251
		[Token(Token = "0x4033D1B")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _totalHpAnimDelay;

		// Token: 0x04033D1C RID: 212252
		[Token(Token = "0x4033D1C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _totalHpAnimDuration;

		// Token: 0x04033D1D RID: 212253
		[Token(Token = "0x4033D1D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AutoChessBattleBossPreparePlayerItemView _playerItemPrefab;

		// Token: 0x04033D1E RID: 212254
		[Token(Token = "0x4033D1E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AutoChessBattleUIMultiBossPrepareView.AnimPanelStruct[] _panelAnimList;

		// Token: 0x04033D1F RID: 212255
		[Token(Token = "0x4033D1F")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04033D20 RID: 212256
		[Token(Token = "0x4033D20")]
		[FieldOffset(Offset = "0x84")]
		private AutoChessBattleBossRoundModel.AnimStatus m_cacheAnimStatus;

		// Token: 0x04033D21 RID: 212257
		[Token(Token = "0x4033D21")]
		[FieldOffset(Offset = "0x88")]
		private AutoChessBattleUIViewModel m_viewModel;

		// Token: 0x04033D22 RID: 212258
		[Token(Token = "0x4033D22")]
		[FieldOffset(Offset = "0x90")]
		private List<AutoChessBattleBossPreparePlayerItemView> m_playerItemList;

		// Token: 0x04033D23 RID: 212259
		[Token(Token = "0x4033D23")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_tween;

		// Token: 0x04033D24 RID: 212260
		[Token(Token = "0x4033D24")]
		[FieldOffset(Offset = "0xA0")]
		private GameObject m_usedPanelAnim;

		// Token: 0x04033D25 RID: 212261
		[Token(Token = "0x4033D25")]
		[FieldOffset(Offset = "0xA8")]
		private RectTransform[] m_playerContainerList;

		// Token: 0x04033D27 RID: 212263
		[Token(Token = "0x4033D27")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_releaseGrp;

		// Token: 0x04033D28 RID: 212264
		[Token(Token = "0x4033D28")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_releaseGrp;

		// Token: 0x04033D29 RID: 212265
		[Token(Token = "0x4033D29")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04033D2A RID: 212266
		[Token(Token = "0x4033D2A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033D2B RID: 212267
		[Token(Token = "0x4033D2B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayAnimIfNeed;

		// Token: 0x04033D2C RID: 212268
		[Token(Token = "0x4033D2C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CreateAnim;

		// Token: 0x04033D2D RID: 212269
		[Token(Token = "0x4033D2D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CreateEnterAnim;

		// Token: 0x04033D2E RID: 212270
		[Token(Token = "0x4033D2E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200648C RID: 25740
		[Token(Token = "0x200648C")]
		[Serializable]
		public struct AnimPanelStruct
		{
			// Token: 0x04033D2F RID: 212271
			[Token(Token = "0x4033D2F")]
			[FieldOffset(Offset = "0x0")]
			public int playerCount;

			// Token: 0x04033D30 RID: 212272
			[Token(Token = "0x4033D30")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panelAnim;
		}
	}
}
