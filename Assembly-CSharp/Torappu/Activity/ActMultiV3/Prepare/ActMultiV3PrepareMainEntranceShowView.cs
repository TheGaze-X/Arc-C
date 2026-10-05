using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200705D RID: 28765
	[Token(Token = "0x200705D")]
	public class ActMultiV3PrepareMainEntranceShowView : DataBinder<ActMultiV3PrepareMainEntranceShowProperty>, IHotfixable
	{
		// Token: 0x17006093 RID: 24723
		// (get) Token: 0x06028D93 RID: 167315 RVA: 0x000D3410 File Offset: 0x000D1610
		[Token(Token = "0x17006093")]
		public bool isPlayingExit
		{
			[Token(Token = "0x6028D93")]
			[Address(RVA = "0x243A010", Offset = "0x2438C10", VA = "0x18243A010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006094 RID: 24724
		// (get) Token: 0x06028D94 RID: 167316 RVA: 0x000D3428 File Offset: 0x000D1628
		[Token(Token = "0x17006094")]
		public int playingExitSeqNum
		{
			[Token(Token = "0x6028D94")]
			[Address(RVA = "0x243A080", Offset = "0x2438C80", VA = "0x18243A080")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006095 RID: 24725
		// (get) Token: 0x06028D95 RID: 167317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006095")]
		public GameObject entranceShowRoot
		{
			[Token(Token = "0x6028D95")]
			[Address(RVA = "0x2439FB0", Offset = "0x2438BB0", VA = "0x182439FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028D96 RID: 167318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D96")]
		[Address(RVA = "0x24389E0", Offset = "0x24375E0", VA = "0x1824389E0")]
		public void InitIfNot()
		{
		}

		// Token: 0x06028D97 RID: 167319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D97")]
		[Address(RVA = "0x2438DF0", Offset = "0x24379F0", VA = "0x182438DF0", Slot = "7")]
		public override void OnValueChanged(ActMultiV3PrepareMainEntranceShowProperty property)
		{
		}

		// Token: 0x06028D98 RID: 167320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D98")]
		[Address(RVA = "0x2438F30", Offset = "0x2437B30", VA = "0x182438F30")]
		public void Render(ActMultiV3PrepareMainEntranceShowViewModel viewModel)
		{
		}

		// Token: 0x06028D99 RID: 167321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028D99")]
		[Address(RVA = "0x2439D00", Offset = "0x2438900", VA = "0x182439D00")]
		private Tween _GenShowMapConfirmTween()
		{
			return null;
		}

		// Token: 0x06028D9A RID: 167322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028D9A")]
		[Address(RVA = "0x2439500", Offset = "0x2438100", VA = "0x182439500")]
		private Tween _GenPlayerShowAndExitTween()
		{
			return null;
		}

		// Token: 0x06028D9B RID: 167323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028D9B")]
		[Address(RVA = "0x2439950", Offset = "0x2438550", VA = "0x182439950")]
		private Tween _GenResetTween()
		{
			return null;
		}

		// Token: 0x06028D9C RID: 167324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D9C")]
		[Address(RVA = "0x2439E70", Offset = "0x2438A70", VA = "0x182439E70")]
		private void _SetGameObjectsActive(GameObject[] gameObjs, bool value)
		{
		}

		// Token: 0x06028D9D RID: 167325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028D9D")]
		[Address(RVA = "0x2438E80", Offset = "0x2437A80", VA = "0x182438E80")]
		public IEnumerator PlayerShowCoroutine()
		{
			return null;
		}

		// Token: 0x06028D9E RID: 167326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D9E")]
		[Address(RVA = "0x2439F40", Offset = "0x2438B40", VA = "0x182439F40")]
		public ActMultiV3PrepareMainEntranceShowView()
		{
		}

		// Token: 0x0403A430 RID: 238640
		[Token(Token = "0x403A430")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _invertObjs;

		// Token: 0x0403A431 RID: 238641
		[Token(Token = "0x403A431")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _entranceShowRoot;

		// Token: 0x0403A432 RID: 238642
		[Token(Token = "0x403A432")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _selfEffectIcon;

		// Token: 0x0403A433 RID: 238643
		[Token(Token = "0x403A433")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _partnerEffectIcon;

		// Token: 0x0403A434 RID: 238644
		[Token(Token = "0x403A434")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _seasonIconImg2;

		// Token: 0x0403A435 RID: 238645
		[Token(Token = "0x403A435")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _selfEffectNameTxt;

		// Token: 0x0403A436 RID: 238646
		[Token(Token = "0x403A436")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _partnerEffectNameTxt;

		// Token: 0x0403A437 RID: 238647
		[Token(Token = "0x403A437")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _partnerReadyToggle;

		// Token: 0x0403A438 RID: 238648
		[Token(Token = "0x403A438")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _confirmBtnToggle;

		// Token: 0x0403A439 RID: 238649
		[Token(Token = "0x403A439")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ActMultiV3ShortNameCardView _nameCardPrefab;

		// Token: 0x0403A43A RID: 238650
		[Token(Token = "0x403A43A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActMultiV3StageDetailView _stageDetailPrefab;

		// Token: 0x0403A43B RID: 238651
		[Token(Token = "0x403A43B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _selfNameCardContainer;

		// Token: 0x0403A43C RID: 238652
		[Token(Token = "0x403A43C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _partnerNameCardContainer;

		// Token: 0x0403A43D RID: 238653
		[Token(Token = "0x403A43D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _selfAssitIllustContainer;

		// Token: 0x0403A43E RID: 238654
		[Token(Token = "0x403A43E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _partnerAssitIllustContainer;

		// Token: 0x0403A43F RID: 238655
		[Token(Token = "0x403A43F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _stageDetailContainer;

		// Token: 0x0403A440 RID: 238656
		[Token(Token = "0x403A440")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _bottomBarContainer;

		// Token: 0x0403A441 RID: 238657
		[Token(Token = "0x403A441")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _normEnterAnim;

		// Token: 0x0403A442 RID: 238658
		[Token(Token = "0x403A442")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIAnimationLocation _flipEnterAnim;

		// Token: 0x0403A443 RID: 238659
		[Token(Token = "0x403A443")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIAnimationLocation _showExitAnim;

		// Token: 0x0403A444 RID: 238660
		[Token(Token = "0x403A444")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIAnimationLocation _mapConfirmEnterAnim;

		// Token: 0x0403A445 RID: 238661
		[Token(Token = "0x403A445")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIAnimationLocation _mapConfirmExitAnim;

		// Token: 0x0403A446 RID: 238662
		[Token(Token = "0x403A446")]
		[FieldOffset(Offset = "0xF8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403A447 RID: 238663
		[Token(Token = "0x403A447")]
		[FieldOffset(Offset = "0x108")]
		private bool m_isInited;

		// Token: 0x0403A448 RID: 238664
		[Token(Token = "0x403A448")]
		[FieldOffset(Offset = "0x110")]
		private string m_actId;

		// Token: 0x0403A449 RID: 238665
		[Token(Token = "0x403A449")]
		[FieldOffset(Offset = "0x118")]
		private int m_cachedEnterSeqNum;

		// Token: 0x0403A44A RID: 238666
		[Token(Token = "0x403A44A")]
		[FieldOffset(Offset = "0x11C")]
		private int m_cachedPlayerShowEnterSeqNum;

		// Token: 0x0403A44B RID: 238667
		[Token(Token = "0x403A44B")]
		[FieldOffset(Offset = "0x120")]
		private int m_cachedExitSeqNum;

		// Token: 0x0403A44C RID: 238668
		[Token(Token = "0x403A44C")]
		[FieldOffset(Offset = "0x128")]
		private ActMultiV3PrepareMainEntranceShowViewModel m_cachedViewModel;

		// Token: 0x0403A44D RID: 238669
		[Token(Token = "0x403A44D")]
		[FieldOffset(Offset = "0x130")]
		private ActMultiV3StageDetailView m_stageDetailView;

		// Token: 0x0403A44E RID: 238670
		[Token(Token = "0x403A44E")]
		[FieldOffset(Offset = "0x138")]
		private ActMultiV3ShortNameCardView m_selfNameCardView;

		// Token: 0x0403A44F RID: 238671
		[Token(Token = "0x403A44F")]
		[FieldOffset(Offset = "0x140")]
		private ActMultiV3ShortNameCardView m_partnerNameCardView;

		// Token: 0x0403A450 RID: 238672
		[Token(Token = "0x403A450")]
		[FieldOffset(Offset = "0x148")]
		private ActMultiV3CommonBottomBar m_botBarView;

		// Token: 0x0403A451 RID: 238673
		[Token(Token = "0x403A451")]
		[FieldOffset(Offset = "0x150")]
		private UIStateTransitionTween<ActMultiV3PrepareMainEntranceShowView.TransState> m_transTween;

		// Token: 0x0403A452 RID: 238674
		[Token(Token = "0x403A452")]
		[FieldOffset(Offset = "0x158")]
		private UIAnimationTween.Builder m_animTweenBuilder;

		// Token: 0x0403A453 RID: 238675
		[Token(Token = "0x403A453")]
		[FieldOffset(Offset = "0x180")]
		private UIAnimationLocation m_lastPlayerShowEnterAnim;

		// Token: 0x0403A454 RID: 238676
		[Token(Token = "0x403A454")]
		[FieldOffset(Offset = "0x190")]
		private Tween m_cachedExitTween;

		// Token: 0x0403A455 RID: 238677
		[Token(Token = "0x403A455")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isPlayingExit;

		// Token: 0x0403A456 RID: 238678
		[Token(Token = "0x403A456")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_playingExitSeqNum;

		// Token: 0x0403A457 RID: 238679
		[Token(Token = "0x403A457")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_entranceShowRoot;

		// Token: 0x0403A458 RID: 238680
		[Token(Token = "0x403A458")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0403A459 RID: 238681
		[Token(Token = "0x403A459")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403A45A RID: 238682
		[Token(Token = "0x403A45A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A45B RID: 238683
		[Token(Token = "0x403A45B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenShowMapConfirmTween;

		// Token: 0x0403A45C RID: 238684
		[Token(Token = "0x403A45C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenPlayerShowAndExitTween;

		// Token: 0x0403A45D RID: 238685
		[Token(Token = "0x403A45D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenResetTween;

		// Token: 0x0403A45E RID: 238686
		[Token(Token = "0x403A45E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetGameObjectsActive;

		// Token: 0x0403A45F RID: 238687
		[Token(Token = "0x403A45F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_PlayerShowCoroutine;

		// Token: 0x0403A460 RID: 238688
		[Token(Token = "0x403A460")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200705E RID: 28766
		[Token(Token = "0x200705E")]
		public enum TransState
		{
			// Token: 0x0403A462 RID: 238690
			[Token(Token = "0x403A462")]
			HIDE,
			// Token: 0x0403A463 RID: 238691
			[Token(Token = "0x403A463")]
			MAP_CONFIRM,
			// Token: 0x0403A464 RID: 238692
			[Token(Token = "0x403A464")]
			PLAYER_SHOW_AND_EXIT
		}
	}
}
