using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200707F RID: 28799
	[Token(Token = "0x200707F")]
	public class ActMultiV3PrepareMainStageChooseView : DataBinder<ActMultiV3PrepareMainStageChooseProperty>
	{
		// Token: 0x170060B7 RID: 24759
		// (get) Token: 0x06028E6F RID: 167535 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028E6E RID: 167534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060B7")]
		public Action onModeToggleClick
		{
			[Token(Token = "0x6028E6F")]
			[Address(RVA = "0x2460870", Offset = "0x245F470", VA = "0x182460870")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028E6E")]
			[Address(RVA = "0x24608D0", Offset = "0x245F4D0", VA = "0x1824608D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06028E70 RID: 167536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E70")]
		[Address(RVA = "0x245F090", Offset = "0x245DC90", VA = "0x18245F090", Slot = "7")]
		public override void OnValueChanged(ActMultiV3PrepareMainStageChooseProperty property)
		{
		}

		// Token: 0x06028E71 RID: 167537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E71")]
		[Address(RVA = "0x2460130", Offset = "0x245ED30", VA = "0x182460130")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028E72 RID: 167538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E72")]
		[Address(RVA = "0x2460490", Offset = "0x245F090", VA = "0x182460490")]
		private void _PlayEnterAnim(ActMultiV3PrepareMainStageChooseViewModel viewModel)
		{
		}

		// Token: 0x06028E73 RID: 167539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E73")]
		[Address(RVA = "0x2460730", Offset = "0x245F330", VA = "0x182460730")]
		private void _SetGameObjectsActive(GameObject[] gameObjs, bool value)
		{
		}

		// Token: 0x06028E74 RID: 167540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E74")]
		[Address(RVA = "0x2460800", Offset = "0x245F400", VA = "0x182460800")]
		public ActMultiV3PrepareMainStageChooseView()
		{
		}

		// Token: 0x0403A57A RID: 238970
		[Token(Token = "0x403A57A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _roomIdText;

		// Token: 0x0403A57B RID: 238971
		[Token(Token = "0x403A57B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _mapCodeText;

		// Token: 0x0403A57C RID: 238972
		[Token(Token = "0x403A57C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _mapModeText;

		// Token: 0x0403A57D RID: 238973
		[Token(Token = "0x403A57D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ActMultiV3DifficultyIconView _mapDiffIconViewPrefab;

		// Token: 0x0403A57E RID: 238974
		[Token(Token = "0x403A57E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _mapDiffIconViewContainer;

		// Token: 0x0403A57F RID: 238975
		[Token(Token = "0x403A57F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ActMultiV3InverseToggleView _inverseToggleViewPrefab;

		// Token: 0x0403A580 RID: 238976
		[Token(Token = "0x403A580")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _inverseToggleViewContainer;

		// Token: 0x0403A581 RID: 238977
		[Token(Token = "0x403A581")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _mapDiffScale;

		// Token: 0x0403A582 RID: 238978
		[Token(Token = "0x403A582")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject[] _emptyMapObjs;

		// Token: 0x0403A583 RID: 238979
		[Token(Token = "0x403A583")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _emptyMapRoot;

		// Token: 0x0403A584 RID: 238980
		[Token(Token = "0x403A584")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject[] _selectedMapObjs;

		// Token: 0x0403A585 RID: 238981
		[Token(Token = "0x403A585")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject[] _ownerObjs;

		// Token: 0x0403A586 RID: 238982
		[Token(Token = "0x403A586")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject[] _guestObjs;

		// Token: 0x0403A587 RID: 238983
		[Token(Token = "0x403A587")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TwoStateToggle _randomMapToggle;

		// Token: 0x0403A588 RID: 238984
		[Token(Token = "0x403A588")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TwoStateToggle _ownerGusetToggle;

		// Token: 0x0403A589 RID: 238985
		[Token(Token = "0x403A589")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TwoStateToggle _guestBtnAvailToggle;

		// Token: 0x0403A58A RID: 238986
		[Token(Token = "0x403A58A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TwoStateToggle _guestPreparedCancelBtnToggle;

		// Token: 0x0403A58B RID: 238987
		[Token(Token = "0x403A58B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TwoStateToggle _ownerPreparBtnAvailToggle;

		// Token: 0x0403A58C RID: 238988
		[Token(Token = "0x403A58C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _ownerWatingStatusTxt;

		// Token: 0x0403A58D RID: 238989
		[Token(Token = "0x403A58D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _guestWatingStatusTxt;

		// Token: 0x0403A58E RID: 238990
		[Token(Token = "0x403A58E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Image _stageBigPreviewImg;

		// Token: 0x0403A58F RID: 238991
		[Token(Token = "0x403A58F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIAnimationLocation _ownerInAnim;

		// Token: 0x0403A590 RID: 238992
		[Token(Token = "0x403A590")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIAnimationLocation _guestInAnim;

		// Token: 0x0403A591 RID: 238993
		[Token(Token = "0x403A591")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIAnimationLocation _guestMapDetailInAnim;

		// Token: 0x0403A592 RID: 238994
		[Token(Token = "0x403A592")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIAnimationLocation _topMenuNormToFlipAnim;

		// Token: 0x0403A593 RID: 238995
		[Token(Token = "0x403A593")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIAnimationLocation _topMeunFlipToNormAnim;

		// Token: 0x0403A594 RID: 238996
		[Token(Token = "0x403A594")]
		[FieldOffset(Offset = "0x118")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403A595 RID: 238997
		[Token(Token = "0x403A595")]
		[FieldOffset(Offset = "0x128")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403A596 RID: 238998
		[Token(Token = "0x403A596")]
		[FieldOffset(Offset = "0x138")]
		private bool m_isInited;

		// Token: 0x0403A597 RID: 238999
		[Token(Token = "0x403A597")]
		[FieldOffset(Offset = "0x140")]
		private string m_cachedActId;

		// Token: 0x0403A598 RID: 239000
		[Token(Token = "0x403A598")]
		[FieldOffset(Offset = "0x148")]
		private string m_cacheStagePicId;

		// Token: 0x0403A599 RID: 239001
		[Token(Token = "0x403A599")]
		[FieldOffset(Offset = "0x150")]
		private ActMultiV3DifficultyIconView m_mapDiffIconView;

		// Token: 0x0403A59A RID: 239002
		[Token(Token = "0x403A59A")]
		[FieldOffset(Offset = "0x158")]
		private ActMultiV3InverseToggleView m_inverseToggleView;

		// Token: 0x0403A59B RID: 239003
		[Token(Token = "0x403A59B")]
		[FieldOffset(Offset = "0x160")]
		private AnimationSwitchTween m_guestMapDetailSwitchTween;

		// Token: 0x0403A59C RID: 239004
		[Token(Token = "0x403A59C")]
		[FieldOffset(Offset = "0x168")]
		private UIStateTransitionTween<ActMultiV3PrepareMainStageChooseView.GameMode> m_topMenuTransTween;

		// Token: 0x0403A59D RID: 239005
		[Token(Token = "0x403A59D")]
		[FieldOffset(Offset = "0x170")]
		private GameObject m_prepareLoopAnimObj;

		// Token: 0x0403A59E RID: 239006
		[Token(Token = "0x403A59E")]
		[FieldOffset(Offset = "0x178")]
		private int m_cacheEnterSeqNum;

		// Token: 0x0403A59F RID: 239007
		[Token(Token = "0x403A59F")]
		[FieldOffset(Offset = "0x17C")]
		private int m_cacheModeChangeSeqNum;

		// Token: 0x0403A5A0 RID: 239008
		[Token(Token = "0x403A5A0")]
		[FieldOffset(Offset = "0x180")]
		private int m_cachePartnerInSeqNum;

		// Token: 0x0403A5A1 RID: 239009
		[Token(Token = "0x403A5A1")]
		[FieldOffset(Offset = "0x184")]
		private int m_cacheMapChangeSeqNum;

		// Token: 0x0403A5A3 RID: 239011
		[Token(Token = "0x403A5A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onModeToggleClick;

		// Token: 0x0403A5A4 RID: 239012
		[Token(Token = "0x403A5A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onModeToggleClick;

		// Token: 0x0403A5A5 RID: 239013
		[Token(Token = "0x403A5A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403A5A6 RID: 239014
		[Token(Token = "0x403A5A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A5A7 RID: 239015
		[Token(Token = "0x403A5A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x0403A5A8 RID: 239016
		[Token(Token = "0x403A5A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetGameObjectsActive;

		// Token: 0x0403A5A9 RID: 239017
		[Token(Token = "0x403A5A9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007080 RID: 28800
		[Token(Token = "0x2007080")]
		private enum GameMode
		{
			// Token: 0x0403A5AB RID: 239019
			[Token(Token = "0x403A5AB")]
			NORMAL,
			// Token: 0x0403A5AC RID: 239020
			[Token(Token = "0x403A5AC")]
			FLIP
		}
	}
}
