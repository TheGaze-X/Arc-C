using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Stage.MixStory;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069AB RID: 27051
	[Token(Token = "0x20069AB")]
	public class StageZoneMixStoryGroupPanel : StageZoneGroupPanel
	{
		// Token: 0x17005B6B RID: 23403
		// (set) Token: 0x06026B64 RID: 158564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B6B")]
		public string skipFocusedStorySetId
		{
			[Token(Token = "0x6026B64")]
			[Address(RVA = "0x21CAD50", Offset = "0x21C9950", VA = "0x1821CAD50")]
			set
			{
			}
		}

		// Token: 0x06026B65 RID: 158565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B65")]
		[Address(RVA = "0x21CA370", Offset = "0x21C8F70", VA = "0x1821CA370")]
		private void _Tutorial_WaitToTriggerSignalIfNeed()
		{
		}

		// Token: 0x06026B66 RID: 158566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026B66")]
		[Address(RVA = "0x21CA2C0", Offset = "0x21C8EC0", VA = "0x1821CA2C0")]
		private IEnumerator _Tutorial_WaitToTriggerSignalCoroutine()
		{
			return null;
		}

		// Token: 0x06026B67 RID: 158567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B67")]
		[Address(RVA = "0x21C9B80", Offset = "0x21C8780", VA = "0x1821C9B80")]
		private void _Tutorial_FocusSelectStorylineIfNeed()
		{
		}

		// Token: 0x06026B68 RID: 158568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B68")]
		[Address(RVA = "0x21CA0F0", Offset = "0x21C8CF0", VA = "0x1821CA0F0")]
		private void _Tutorial_RegisterStorylineVirtualViewAndTriggerSignal(StageMixStoryStorylineView.VirtualView virtualView)
		{
		}

		// Token: 0x06026B69 RID: 158569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B69")]
		[Address(RVA = "0x21CA230", Offset = "0x21C8E30", VA = "0x1821CA230")]
		private void _Tutorial_TriggerSelectStorylineSwitchEnd()
		{
		}

		// Token: 0x06026B6A RID: 158570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B6A")]
		[Address(RVA = "0x21C7A60", Offset = "0x21C6660", VA = "0x1821C7A60")]
		public void OnOpenOverallEvent()
		{
		}

		// Token: 0x06026B6B RID: 158571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B6B")]
		[Address(RVA = "0x21C7B10", Offset = "0x21C6710", VA = "0x1821C7B10")]
		public void OnSwitchStorylineSelection(bool on)
		{
		}

		// Token: 0x06026B6C RID: 158572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B6C")]
		[Address(RVA = "0x21C7950", Offset = "0x21C6550", VA = "0x1821C7950")]
		public void OnFocusLastVisitedStorySetEvent()
		{
		}

		// Token: 0x06026B6D RID: 158573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B6D")]
		[Address(RVA = "0x21C7670", Offset = "0x21C6270", VA = "0x1821C7670", Slot = "8")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06026B6E RID: 158574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B6E")]
		[Address(RVA = "0x21C6E70", Offset = "0x21C5A70", VA = "0x1821C6E70", Slot = "9")]
		protected override void OnDataUpdated(ZoneGroupViewProperty prop)
		{
		}

		// Token: 0x06026B6F RID: 158575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B6F")]
		[Address(RVA = "0x21C87F0", Offset = "0x21C73F0", VA = "0x1821C87F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026B70 RID: 158576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B70")]
		[Address(RVA = "0x21CA9E0", Offset = "0x21C95E0", VA = "0x1821CA9E0")]
		private void _UpdateStorylines(MixStoryZoneGroupViewModel model, bool dataRefreshed)
		{
		}

		// Token: 0x06026B71 RID: 158577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B71")]
		[Address(RVA = "0x21CA740", Offset = "0x21C9340", VA = "0x1821CA740")]
		private void _UpdateLocations(MixStoryZoneGroupViewModel model, bool dataRefreshed)
		{
		}

		// Token: 0x06026B72 RID: 158578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B72")]
		[Address(RVA = "0x21C8070", Offset = "0x21C6C70", VA = "0x1821C8070")]
		private void _GenerateStorylineViews(List<StageStorylineViewModel> storylines)
		{
		}

		// Token: 0x06026B73 RID: 158579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B73")]
		[Address(RVA = "0x21C7C30", Offset = "0x21C6830", VA = "0x1821C7C30")]
		private void _GenerateLocationViews(StageStorylineViewModel lineViewModel)
		{
		}

		// Token: 0x06026B74 RID: 158580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B74")]
		[Address(RVA = "0x21C9880", Offset = "0x21C8480", VA = "0x1821C9880")]
		private void _RenderFocusedStorylineItem(MixStoryZoneGroupViewModel model)
		{
		}

		// Token: 0x06026B75 RID: 158581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B75")]
		[Address(RVA = "0x21C9580", Offset = "0x21C8180", VA = "0x1821C9580")]
		private void _ReactOnStorylineSelectSwitch(bool on)
		{
		}

		// Token: 0x06026B76 RID: 158582 RVA: 0x000CC150 File Offset: 0x000CA350
		[Token(Token = "0x6026B76")]
		[Address(RVA = "0x21C8520", Offset = "0x21C7120", VA = "0x1821C8520")]
		private float _GetStorylineNormalizedPosition(StageStorylineViewModel storyline, out StageMixStoryStorylineView.VirtualView focusedVirtualView)
		{
			return 0f;
		}

		// Token: 0x06026B77 RID: 158583 RVA: 0x000CC168 File Offset: 0x000CA368
		[Token(Token = "0x6026B77")]
		[Address(RVA = "0x21C8240", Offset = "0x21C6E40", VA = "0x1821C8240")]
		private float _GetFocusedStorySetNormalizedPosition()
		{
			return 0f;
		}

		// Token: 0x06026B78 RID: 158584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B78")]
		[Address(RVA = "0x21CA5F0", Offset = "0x21C91F0", VA = "0x1821CA5F0")]
		private void _UpdateLastVisitedState(MixStoryZoneGroupViewModel model)
		{
		}

		// Token: 0x06026B79 RID: 158585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B79")]
		[Address(RVA = "0x21C9080", Offset = "0x21C7C80", VA = "0x1821C9080")]
		private void _OnItemLayoutStart()
		{
		}

		// Token: 0x06026B7A RID: 158586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B7A")]
		[Address(RVA = "0x21C91D0", Offset = "0x21C7DD0", VA = "0x1821C91D0")]
		private void _OnItemLayout(UIRecycleLayoutAdapter.IVirtualView view, float pos, float size)
		{
		}

		// Token: 0x06026B7B RID: 158587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B7B")]
		[Address(RVA = "0x21C9020", Offset = "0x21C7C20", VA = "0x1821C9020")]
		private void _OnItemLayoutEnd()
		{
		}

		// Token: 0x06026B7C RID: 158588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B7C")]
		[Address(RVA = "0x21CABD0", Offset = "0x21C97D0", VA = "0x1821CABD0")]
		public StageZoneMixStoryGroupPanel()
		{
		}

		// Token: 0x06026B7D RID: 158589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B7D")]
		[Address(RVA = "0x21BDE90", Offset = "0x21BCA90", VA = "0x1821BDE90")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06026B7E RID: 158590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026B7E")]
		[Address(RVA = "0x21BDE30", Offset = "0x21BCA30", VA = "0x1821BDE30")]
		private void <>xLuaBaseProxy_OnDataUpdated(ZoneGroupViewProperty P0)
		{
		}

		// Token: 0x04036A49 RID: 223817
		[Token(Token = "0x4036A49")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StageMixStoryBackgroundView _backgroundView;

		// Token: 0x04036A4A RID: 223818
		[Token(Token = "0x4036A4A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _focusedStorylineMainlinePanel;

		// Token: 0x04036A4B RID: 223819
		[Token(Token = "0x4036A4B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _focusedStorylineOtherPanel;

		// Token: 0x04036A4C RID: 223820
		[Token(Token = "0x4036A4C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _focusedStorylineLogoImage;

		// Token: 0x04036A4D RID: 223821
		[Token(Token = "0x4036A4D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _focusedStorylineAbbrImage;

		// Token: 0x04036A4E RID: 223822
		[Token(Token = "0x4036A4E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _focusedStorylineNameText;

		// Token: 0x04036A4F RID: 223823
		[Token(Token = "0x4036A4F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _focusLastVisitedPanel;

		// Token: 0x04036A50 RID: 223824
		[Token(Token = "0x4036A50")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private StageMixStoryLocationLayoutGroup _locationRecycleGroup;

		// Token: 0x04036A51 RID: 223825
		[Token(Token = "0x4036A51")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIWrappedScrollRect _locationScrollRect;

		// Token: 0x04036A52 RID: 223826
		[Token(Token = "0x4036A52")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UILayoutDimensionListener _locationContentDimensionListener;

		// Token: 0x04036A53 RID: 223827
		[Token(Token = "0x4036A53")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _storylineRecycleGroup;

		// Token: 0x04036A54 RID: 223828
		[Token(Token = "0x4036A54")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIWrappedScrollRect _storylineScrollRect;

		// Token: 0x04036A55 RID: 223829
		[Token(Token = "0x4036A55")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UILayoutDimensionListener _storylineContentDimensionListener;

		// Token: 0x04036A56 RID: 223830
		[Token(Token = "0x4036A56")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float _storylineFocusPosition;

		// Token: 0x04036A57 RID: 223831
		[Token(Token = "0x4036A57")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Transform _storylineItemTrackPointHolder;

		// Token: 0x04036A58 RID: 223832
		[Token(Token = "0x4036A58")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private RectTransform _storylineItemRect;

		// Token: 0x04036A59 RID: 223833
		[Token(Token = "0x4036A59")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RectTransform _storylineItemRootRect;

		// Token: 0x04036A5A RID: 223834
		[Token(Token = "0x4036A5A")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _storylineItemMoveDuration;

		// Token: 0x04036A5B RID: 223835
		[Token(Token = "0x4036A5B")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private Ease _storylineItemMoveEase;

		// Token: 0x04036A5C RID: 223836
		[Token(Token = "0x4036A5C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIAnimationLocation _storylinesSelectAnimation;

		// Token: 0x04036A5D RID: 223837
		[Token(Token = "0x4036A5D")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIAnimationLocation _locationsSwitchAnimation;

		// Token: 0x04036A5E RID: 223838
		[Token(Token = "0x4036A5E")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private List<GameObject> _overallLockedObjects;

		// Token: 0x04036A5F RID: 223839
		[Token(Token = "0x4036A5F")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private List<GameObject> _overallUnlockObjects;

		// Token: 0x04036A60 RID: 223840
		[Token(Token = "0x4036A60")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _tutorialStorylineItemPanel;

		// Token: 0x04036A61 RID: 223841
		[Token(Token = "0x4036A61")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _tutorialLocationGroupPanel;

		// Token: 0x04036A62 RID: 223842
		[Token(Token = "0x4036A62")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _tutorialSelectStorylineButton;

		// Token: 0x04036A63 RID: 223843
		[Token(Token = "0x4036A63")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _tutorialOverallButton;

		// Token: 0x04036A64 RID: 223844
		[Token(Token = "0x4036A64")]
		[FieldOffset(Offset = "0x140")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04036A65 RID: 223845
		[Token(Token = "0x4036A65")]
		[FieldOffset(Offset = "0x150")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04036A66 RID: 223846
		[Token(Token = "0x4036A66")]
		[FieldOffset(Offset = "0x160")]
		private StageMixStoryRecycleList m_locationRecycleList;

		// Token: 0x04036A67 RID: 223847
		[Token(Token = "0x4036A67")]
		[FieldOffset(Offset = "0x168")]
		private StageMixStoryRecycleList m_storylineRecycleList;

		// Token: 0x04036A68 RID: 223848
		[Token(Token = "0x4036A68")]
		[FieldOffset(Offset = "0x170")]
		private bool m_hasInited;

		// Token: 0x04036A69 RID: 223849
		[Token(Token = "0x4036A69")]
		[FieldOffset(Offset = "0x178")]
		private ILoadAsset m_iLoadAsset;

		// Token: 0x04036A6A RID: 223850
		[Token(Token = "0x4036A6A")]
		[FieldOffset(Offset = "0x180")]
		private StageMixStoryActView m_actView;

		// Token: 0x04036A6B RID: 223851
		[Token(Token = "0x4036A6B")]
		[FieldOffset(Offset = "0x188")]
		private StageMixStoryActOtherLineView m_otherLineView;

		// Token: 0x04036A6C RID: 223852
		[Token(Token = "0x4036A6C")]
		[FieldOffset(Offset = "0x190")]
		private StageMixStoryMainlineSplitView m_splitView;

		// Token: 0x04036A6D RID: 223853
		[Token(Token = "0x4036A6D")]
		[FieldOffset(Offset = "0x198")]
		private StageMixStoryStorylineView m_storylineView;

		// Token: 0x04036A6E RID: 223854
		[Token(Token = "0x4036A6E")]
		[FieldOffset(Offset = "0x1A0")]
		private StageMixStoryStorylineItemSyncHandler m_storylineItemSyncHandler;

		// Token: 0x04036A6F RID: 223855
		[Token(Token = "0x4036A6F")]
		[FieldOffset(Offset = "0x1A8")]
		private Tween m_storylineItemMoveTween;

		// Token: 0x04036A70 RID: 223856
		[Token(Token = "0x4036A70")]
		[FieldOffset(Offset = "0x1B0")]
		private AnimationSwitchTween m_selectStorylineSwitchTween;

		// Token: 0x04036A71 RID: 223857
		[Token(Token = "0x4036A71")]
		[FieldOffset(Offset = "0x1B8")]
		private AnimationSwitchTween m_selectLocationSwitchTween;

		// Token: 0x04036A72 RID: 223858
		[Token(Token = "0x4036A72")]
		[FieldOffset(Offset = "0x1C0")]
		private GameObject m_storylineItemTrackPoint;

		// Token: 0x04036A73 RID: 223859
		[Token(Token = "0x4036A73")]
		[FieldOffset(Offset = "0x1C8")]
		private bool m_focusStorylineRequired;

		// Token: 0x04036A74 RID: 223860
		[Token(Token = "0x4036A74")]
		[FieldOffset(Offset = "0x1CC")]
		private int m_dataSequence;

		// Token: 0x04036A75 RID: 223861
		[Token(Token = "0x4036A75")]
		[FieldOffset(Offset = "0x1D0")]
		private List<UIRecycleLayoutAdapter.IVirtualView> m_locationViews;

		// Token: 0x04036A76 RID: 223862
		[Token(Token = "0x4036A76")]
		[FieldOffset(Offset = "0x1D8")]
		private List<UIRecycleLayoutAdapter.IVirtualView> m_storylineViews;

		// Token: 0x04036A77 RID: 223863
		[Token(Token = "0x4036A77")]
		[FieldOffset(Offset = "0x1E0")]
		private StageStorylineViewModel m_cachedFocusedStoryline;

		// Token: 0x04036A78 RID: 223864
		[Token(Token = "0x4036A78")]
		[FieldOffset(Offset = "0x1E8")]
		private StageStorylineStorySetLocationViewModel m_cachedFocusedLocation;

		// Token: 0x04036A79 RID: 223865
		[Token(Token = "0x4036A79")]
		[FieldOffset(Offset = "0x1F0")]
		private bool m_isLastVisitedStoryline;

		// Token: 0x04036A7A RID: 223866
		[Token(Token = "0x4036A7A")]
		[FieldOffset(Offset = "0x1F8")]
		private string m_lastVisitedStorySetId;

		// Token: 0x04036A7B RID: 223867
		[Token(Token = "0x4036A7B")]
		[FieldOffset(Offset = "0x200")]
		private string m_cachedLogoId;

		// Token: 0x04036A7C RID: 223868
		[Token(Token = "0x4036A7C")]
		[FieldOffset(Offset = "0x208")]
		private string m_cachedAbbrIconId;

		// Token: 0x04036A7D RID: 223869
		[Token(Token = "0x4036A7D")]
		[FieldOffset(Offset = "0x210")]
		private string m_skipFocusedStorySetId;

		// Token: 0x04036A7E RID: 223870
		[Token(Token = "0x4036A7E")]
		[FieldOffset(Offset = "0x218")]
		private bool m_skipLayoutFocus;

		// Token: 0x04036A7F RID: 223871
		[Token(Token = "0x4036A7F")]
		[FieldOffset(Offset = "0x21C")]
		private float m_tempFocusPosition;

		// Token: 0x04036A80 RID: 223872
		[Token(Token = "0x4036A80")]
		[FieldOffset(Offset = "0x220")]
		private GameObject m_firstVisibleStorySet;

		// Token: 0x04036A81 RID: 223873
		[Token(Token = "0x4036A81")]
		[FieldOffset(Offset = "0x228")]
		private StageMixStoryStorylineView.VirtualView m_selectedVirtualView;

		// Token: 0x04036A82 RID: 223874
		[Token(Token = "0x4036A82")]
		[FieldOffset(Offset = "0x230")]
		private bool m_waitForStableViews;

		// Token: 0x04036A83 RID: 223875
		[Token(Token = "0x4036A83")]
		[FieldOffset(Offset = "0x238")]
		private Coroutine m_signalCoroutine;

		// Token: 0x04036A84 RID: 223876
		[Token(Token = "0x4036A84")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_skipFocusedStorySetId;

		// Token: 0x04036A85 RID: 223877
		[Token(Token = "0x4036A85")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Tutorial_WaitToTriggerSignalIfNeed;

		// Token: 0x04036A86 RID: 223878
		[Token(Token = "0x4036A86")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Tutorial_WaitToTriggerSignalCoroutine;

		// Token: 0x04036A87 RID: 223879
		[Token(Token = "0x4036A87")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Tutorial_FocusSelectStorylineIfNeed;

		// Token: 0x04036A88 RID: 223880
		[Token(Token = "0x4036A88")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Tutorial_RegisterStorylineVirtualViewAndTriggerSignal;

		// Token: 0x04036A89 RID: 223881
		[Token(Token = "0x4036A89")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Tutorial_TriggerSelectStorylineSwitchEnd;

		// Token: 0x04036A8A RID: 223882
		[Token(Token = "0x4036A8A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnOpenOverallEvent;

		// Token: 0x04036A8B RID: 223883
		[Token(Token = "0x4036A8B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSwitchStorylineSelection;

		// Token: 0x04036A8C RID: 223884
		[Token(Token = "0x4036A8C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnFocusLastVisitedStorySetEvent;

		// Token: 0x04036A8D RID: 223885
		[Token(Token = "0x4036A8D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04036A8E RID: 223886
		[Token(Token = "0x4036A8E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04036A8F RID: 223887
		[Token(Token = "0x4036A8F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036A90 RID: 223888
		[Token(Token = "0x4036A90")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateStorylines;

		// Token: 0x04036A91 RID: 223889
		[Token(Token = "0x4036A91")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateLocations;

		// Token: 0x04036A92 RID: 223890
		[Token(Token = "0x4036A92")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GenerateStorylineViews;

		// Token: 0x04036A93 RID: 223891
		[Token(Token = "0x4036A93")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenerateLocationViews;

		// Token: 0x04036A94 RID: 223892
		[Token(Token = "0x4036A94")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RenderFocusedStorylineItem;

		// Token: 0x04036A95 RID: 223893
		[Token(Token = "0x4036A95")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ReactOnStorylineSelectSwitch;

		// Token: 0x04036A96 RID: 223894
		[Token(Token = "0x4036A96")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetStorylineNormalizedPosition;

		// Token: 0x04036A97 RID: 223895
		[Token(Token = "0x4036A97")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetFocusedStorySetNormalizedPosition;

		// Token: 0x04036A98 RID: 223896
		[Token(Token = "0x4036A98")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateLastVisitedState;

		// Token: 0x04036A99 RID: 223897
		[Token(Token = "0x4036A99")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnItemLayoutStart;

		// Token: 0x04036A9A RID: 223898
		[Token(Token = "0x4036A9A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnItemLayout;

		// Token: 0x04036A9B RID: 223899
		[Token(Token = "0x4036A9B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnItemLayoutEnd;

		// Token: 0x04036A9C RID: 223900
		[Token(Token = "0x4036A9C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069AC RID: 27052
		[Token(Token = "0x20069AC")]
		private class StorylineFocusAction : UILayoutDimensionListener.IAction, IHotfixable
		{
			// Token: 0x06026B7F RID: 158591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026B7F")]
			[Address(RVA = "0x21CFFE0", Offset = "0x21CEBE0", VA = "0x1821CFFE0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x06026B80 RID: 158592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026B80")]
			[Address(RVA = "0x21D0060", Offset = "0x21CEC60", VA = "0x1821D0060")]
			public StorylineFocusAction()
			{
			}

			// Token: 0x04036A9D RID: 223901
			[Token(Token = "0x4036A9D")]
			[FieldOffset(Offset = "0x10")]
			public StageZoneMixStoryGroupPanel closure;

			// Token: 0x04036A9E RID: 223902
			[Token(Token = "0x4036A9E")]
			[FieldOffset(Offset = "0x18")]
			public float position;

			// Token: 0x04036A9F RID: 223903
			[Token(Token = "0x4036A9F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DoAction;

			// Token: 0x04036AA0 RID: 223904
			[Token(Token = "0x4036AA0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020069AD RID: 27053
		[Token(Token = "0x20069AD")]
		private class StorylineTutorialSignalAction : UILayoutDimensionListener.IAction, IHotfixable
		{
			// Token: 0x06026B81 RID: 158593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026B81")]
			[Address(RVA = "0x21D00C0", Offset = "0x21CECC0", VA = "0x1821D00C0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x06026B82 RID: 158594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026B82")]
			[Address(RVA = "0x21D01C0", Offset = "0x21CEDC0", VA = "0x1821D01C0")]
			public StorylineTutorialSignalAction()
			{
			}

			// Token: 0x04036AA1 RID: 223905
			[Token(Token = "0x4036AA1")]
			[FieldOffset(Offset = "0x10")]
			public StageMixStoryStorylineView.VirtualView focusedVirtualView;

			// Token: 0x04036AA2 RID: 223906
			[Token(Token = "0x4036AA2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DoAction;

			// Token: 0x04036AA3 RID: 223907
			[Token(Token = "0x4036AA3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020069AE RID: 27054
		[Token(Token = "0x20069AE")]
		private class LocationFocusAction : UILayoutDimensionListener.IAction, IHotfixable
		{
			// Token: 0x06026B83 RID: 158595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026B83")]
			[Address(RVA = "0x21BA680", Offset = "0x21B9280", VA = "0x1821BA680", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x06026B84 RID: 158596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026B84")]
			[Address(RVA = "0x21BA720", Offset = "0x21B9320", VA = "0x1821BA720")]
			public LocationFocusAction()
			{
			}

			// Token: 0x04036AA4 RID: 223908
			[Token(Token = "0x4036AA4")]
			[FieldOffset(Offset = "0x10")]
			public StageZoneMixStoryGroupPanel closure;

			// Token: 0x04036AA5 RID: 223909
			[Token(Token = "0x4036AA5")]
			[FieldOffset(Offset = "0x18")]
			public float position;

			// Token: 0x04036AA6 RID: 223910
			[Token(Token = "0x4036AA6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DoAction;

			// Token: 0x04036AA7 RID: 223911
			[Token(Token = "0x4036AA7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
