using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200537B RID: 21371
	[Token(Token = "0x200537B")]
	public class RoguelikeScrollReportController : RoguelikeReportController<RoguelikeScrollReportEndingFrameViewModel>
	{
		// Token: 0x0601F7F2 RID: 129010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7F2")]
		[Address(RVA = "0x192F9F0", Offset = "0x192E5F0", VA = "0x18192F9F0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601F7F3 RID: 129011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7F3")]
		[Address(RVA = "0x1932330", Offset = "0x1930F30", VA = "0x181932330")]
		private void _SetupContent(bool playMode)
		{
		}

		// Token: 0x0601F7F4 RID: 129012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7F4")]
		[Address(RVA = "0x1931770", Offset = "0x1930370", VA = "0x181931770")]
		private IList<UIRecycleLayoutAdapter.IVirtualView> _CreateViewList(bool isPlayMode)
		{
			return null;
		}

		// Token: 0x0601F7F5 RID: 129013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7F5")]
		[Address(RVA = "0x1932580", Offset = "0x1931180", VA = "0x181932580")]
		private void _StartPlayCoroutine()
		{
		}

		// Token: 0x0601F7F6 RID: 129014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7F6")]
		[Address(RVA = "0x19321D0", Offset = "0x1930DD0", VA = "0x1819321D0")]
		private IEnumerator _PlayCoroutine()
		{
			return null;
		}

		// Token: 0x0601F7F7 RID: 129015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7F7")]
		[Address(RVA = "0x1932280", Offset = "0x1930E80", VA = "0x181932280")]
		private IEnumerator _ReloadWithLogMode()
		{
			return null;
		}

		// Token: 0x0601F7F8 RID: 129016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7F8")]
		[Address(RVA = "0x19315A0", Offset = "0x19301A0", VA = "0x1819315A0")]
		private RoguelikeScrollReportTitleView.VirtualView _CreateTitleView(float screenHeight)
		{
			return null;
		}

		// Token: 0x0601F7F9 RID: 129017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7F9")]
		[Address(RVA = "0x19306A0", Offset = "0x192F2A0", VA = "0x1819306A0")]
		private RoguelikeScrollReportItemView.VirtualView _CreateEndPadding(float screenHeight)
		{
			return null;
		}

		// Token: 0x0601F7FA RID: 129018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7FA")]
		[Address(RVA = "0x19305C0", Offset = "0x192F1C0", VA = "0x1819305C0")]
		private UIRecycleLayoutAdapter.IVirtualView _CreateCastView(EndingReportDisplayItem item)
		{
			return null;
		}

		// Token: 0x0601F7FB RID: 129019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7FB")]
		[Address(RVA = "0x1930BB0", Offset = "0x192F7B0", VA = "0x181930BB0")]
		private RoguelikeScrollReportItemView.VirtualView _CreateReportInitView(EndingReportDisplayItem item)
		{
			return null;
		}

		// Token: 0x0601F7FC RID: 129020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7FC")]
		[Address(RVA = "0x1930F60", Offset = "0x192FB60", VA = "0x181930F60")]
		private RoguelikeScrollReportItemView.VirtualView _CreateReportSummaryView(EndingReportDisplayItem item)
		{
			return null;
		}

		// Token: 0x0601F7FD RID: 129021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7FD")]
		[Address(RVA = "0x19310B0", Offset = "0x192FCB0", VA = "0x1819310B0")]
		private RoguelikeScrollReportItemView.VirtualView _CreateReportSummaryWithDifficultyView(EndingReportDisplayItem item)
		{
			return null;
		}

		// Token: 0x0601F7FE RID: 129022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7FE")]
		[Address(RVA = "0x1930820", Offset = "0x192F420", VA = "0x181930820")]
		private RoguelikeScrollReportItemView.VirtualView _CreateReportEndFailView(EndingReportDisplayItem item)
		{
			return null;
		}

		// Token: 0x0601F7FF RID: 129023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7FF")]
		[Address(RVA = "0x1931200", Offset = "0x192FE00", VA = "0x181931200")]
		private RoguelikeScrollReportItemView.VirtualView _CreateReportZoneView(EndingReportDisplayItem item)
		{
			return null;
		}

		// Token: 0x0601F800 RID: 129024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F800")]
		[Address(RVA = "0x1930D00", Offset = "0x192F900", VA = "0x181930D00")]
		private RoguelikeScrollReportItemView.VirtualView _CreateReportNodeView(EndingReportDisplayItem item)
		{
			return null;
		}

		// Token: 0x0601F801 RID: 129025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F801")]
		[Address(RVA = "0x1930970", Offset = "0x192F570", VA = "0x181930970")]
		private RoguelikeScrollReportItemView.VirtualView _CreateReportEndView(EndingReportDisplayItem item)
		{
			return null;
		}

		// Token: 0x0601F802 RID: 129026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F802")]
		[Address(RVA = "0x1931A30", Offset = "0x1930630", VA = "0x181931A30")]
		private UIRecycleLayoutAdapter.IVirtualView _CreateZoneOverviewView(EndingReportDisplayItem item)
		{
			return null;
		}

		// Token: 0x0601F803 RID: 129027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F803")]
		[Address(RVA = "0x1931440", Offset = "0x1930040", VA = "0x181931440")]
		private RoguelikeScrollReportItemView.VirtualView _CreateSimpleDescView(EndingReportDisplayItem item, RoguelikeScrollReportItemView prefab)
		{
			return null;
		}

		// Token: 0x0601F804 RID: 129028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F804")]
		[Address(RVA = "0x19303A0", Offset = "0x192EFA0", VA = "0x1819303A0")]
		private string _ConvertDescToString(IList<string> strList)
		{
			return null;
		}

		// Token: 0x0601F805 RID: 129029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F805")]
		[Address(RVA = "0x19328A0", Offset = "0x19314A0", VA = "0x1819328A0")]
		private void _TryInjectReportPlugin(string topicId)
		{
		}

		// Token: 0x0601F806 RID: 129030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F806")]
		[Address(RVA = "0x19320C0", Offset = "0x1930CC0", VA = "0x1819320C0")]
		private void _InjectViewModelPlugin()
		{
		}

		// Token: 0x0601F807 RID: 129031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F807")]
		[Address(RVA = "0x1931D00", Offset = "0x1930900", VA = "0x181931D00")]
		private FadeSwitchTween _GetBackTween()
		{
			return null;
		}

		// Token: 0x0601F808 RID: 129032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F808")]
		[Address(RVA = "0x1931FD0", Offset = "0x1930BD0", VA = "0x181931FD0")]
		private FadeSwitchTween _GetSkipTween()
		{
			return null;
		}

		// Token: 0x0601F809 RID: 129033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F809")]
		[Address(RVA = "0x1931C10", Offset = "0x1930810", VA = "0x181931C10")]
		private FadeSwitchTween _GetBackLogModeTween()
		{
			return null;
		}

		// Token: 0x0601F80A RID: 129034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F80A")]
		[Address(RVA = "0x1931EE0", Offset = "0x1930AE0", VA = "0x181931EE0")]
		private FadeSwitchTween _GetContentMaskTween()
		{
			return null;
		}

		// Token: 0x0601F80B RID: 129035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F80B")]
		[Address(RVA = "0x1931DF0", Offset = "0x19309F0", VA = "0x181931DF0")]
		private FadeSwitchTween _GetBlackLoadingTween()
		{
			return null;
		}

		// Token: 0x0601F80C RID: 129036 RVA: 0x000B21B8 File Offset: 0x000B03B8
		[Token(Token = "0x601F80C")]
		[Address(RVA = "0x19302E0", Offset = "0x192EEE0", VA = "0x1819302E0")]
		private bool _CheckIfPlaying()
		{
			return default(bool);
		}

		// Token: 0x0601F80D RID: 129037 RVA: 0x000B21D0 File Offset: 0x000B03D0
		[Token(Token = "0x601F80D")]
		[Address(RVA = "0x1930340", Offset = "0x192EF40", VA = "0x181930340")]
		private bool _CheckIfSkipValid()
		{
			return default(bool);
		}

		// Token: 0x0601F80E RID: 129038 RVA: 0x000B21E8 File Offset: 0x000B03E8
		[Token(Token = "0x601F80E")]
		[Address(RVA = "0x1930270", Offset = "0x192EE70", VA = "0x181930270")]
		private bool _CheckIfBackValid()
		{
			return default(bool);
		}

		// Token: 0x0601F80F RID: 129039 RVA: 0x000B2200 File Offset: 0x000B0400
		[Token(Token = "0x601F80F")]
		[Address(RVA = "0x1930200", Offset = "0x192EE00", VA = "0x181930200")]
		private bool _CheckIfBackForLogModeAvail()
		{
			return default(bool);
		}

		// Token: 0x0601F810 RID: 129040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F810")]
		[Address(RVA = "0x1932A30", Offset = "0x1931630", VA = "0x181932A30")]
		private void _UpdateButtonStatus()
		{
		}

		// Token: 0x0601F811 RID: 129041 RVA: 0x000B2218 File Offset: 0x000B0418
		[Token(Token = "0x601F811")]
		[Address(RVA = "0x19326B0", Offset = "0x19312B0", VA = "0x1819326B0")]
		private float _TryGetScreenHeight()
		{
			return 0f;
		}

		// Token: 0x0601F812 RID: 129042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F812")]
		[Address(RVA = "0x192FF60", Offset = "0x192EB60", VA = "0x18192FF60")]
		private void _AddDetailViewsToList(IList<UIRecycleLayoutAdapter.IVirtualView> outList)
		{
		}

		// Token: 0x0601F813 RID: 129043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F813")]
		[Address(RVA = "0x192F940", Offset = "0x192E540", VA = "0x18192F940", Slot = "7")]
		protected override void OnClosePage()
		{
		}

		// Token: 0x0601F814 RID: 129044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F814")]
		[Address(RVA = "0x192F520", Offset = "0x192E120", VA = "0x18192F520")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0601F815 RID: 129045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F815")]
		[Address(RVA = "0x192F840", Offset = "0x192E440", VA = "0x18192F840")]
		public void EventOnSkipClicked()
		{
		}

		// Token: 0x0601F816 RID: 129046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F816")]
		[Address(RVA = "0x192F7D0", Offset = "0x192E3D0", VA = "0x18192F7D0")]
		public void EventOnLongPressing()
		{
		}

		// Token: 0x0601F817 RID: 129047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F817")]
		[Address(RVA = "0x192F760", Offset = "0x192E360", VA = "0x18192F760")]
		public void EventOnLongPressCanceled()
		{
		}

		// Token: 0x0601F818 RID: 129048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F818")]
		[Address(RVA = "0x192F630", Offset = "0x192E230", VA = "0x18192F630")]
		public void EventOnBackTop()
		{
		}

		// Token: 0x0601F819 RID: 129049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F819")]
		[Address(RVA = "0x1932E60", Offset = "0x1931A60", VA = "0x181932E60")]
		public RoguelikeScrollReportController()
		{
		}

		// Token: 0x0402A611 RID: 173585
		[Token(Token = "0x402A611")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x0402A612 RID: 173586
		[Token(Token = "0x402A612")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402A613 RID: 173587
		[Token(Token = "0x402A613")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Graphic _longPressBlocker;

		// Token: 0x0402A614 RID: 173588
		[Token(Token = "0x402A614")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _contentMask;

		// Token: 0x0402A615 RID: 173589
		[Token(Token = "0x402A615")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _panelSkip;

		// Token: 0x0402A616 RID: 173590
		[Token(Token = "0x402A616")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _panelBack;

		// Token: 0x0402A617 RID: 173591
		[Token(Token = "0x402A617")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _panelBackForLogMode;

		// Token: 0x0402A618 RID: 173592
		[Token(Token = "0x402A618")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _blackLoading;

		// Token: 0x0402A619 RID: 173593
		[Token(Token = "0x402A619")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Graphic _scrollBlocker;

		// Token: 0x0402A61A RID: 173594
		[Token(Token = "0x402A61A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("ActPlay")]
		private CanvasGroup _panelFinish;

		// Token: 0x0402A61B RID: 173595
		[Token(Token = "0x402A61B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("ActPlay")]
		private float _actPlayDelay;

		// Token: 0x0402A61C RID: 173596
		[Token(Token = "0x402A61C")]
		private const float CONTENT_FADE_DUR = 0.5f;

		// Token: 0x0402A61D RID: 173597
		[Token(Token = "0x402A61D")]
		private const float FINISH_FADE_DUR = 0.8f;

		// Token: 0x0402A61E RID: 173598
		[Token(Token = "0x402A61E")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeScrollReportController.Adapter m_adapter;

		// Token: 0x0402A61F RID: 173599
		[Token(Token = "0x402A61F")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeScrollReportController.ActPlayer m_activePlaying;

		// Token: 0x0402A620 RID: 173600
		[Token(Token = "0x402A620")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeScrollReportPlugin m_reportPlugin;

		// Token: 0x0402A621 RID: 173601
		[Token(Token = "0x402A621")]
		[FieldOffset(Offset = "0xA0")]
		private FadeSwitchTween m_backTween;

		// Token: 0x0402A622 RID: 173602
		[Token(Token = "0x402A622")]
		[FieldOffset(Offset = "0xA8")]
		private FadeSwitchTween m_skipTween;

		// Token: 0x0402A623 RID: 173603
		[Token(Token = "0x402A623")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_finishShowTween;

		// Token: 0x0402A624 RID: 173604
		[Token(Token = "0x402A624")]
		[FieldOffset(Offset = "0xB8")]
		private FadeSwitchTween m_backLogModeTween;

		// Token: 0x0402A625 RID: 173605
		[Token(Token = "0x402A625")]
		[FieldOffset(Offset = "0xC0")]
		private FadeSwitchTween m_contentMaskTween;

		// Token: 0x0402A626 RID: 173606
		[Token(Token = "0x402A626")]
		[FieldOffset(Offset = "0xC8")]
		private FadeSwitchTween m_blackLoaingTween;

		// Token: 0x0402A627 RID: 173607
		[Token(Token = "0x402A627")]
		[FieldOffset(Offset = "0xD0")]
		private StringBuilder m_sharedBuilder;

		// Token: 0x0402A628 RID: 173608
		[Token(Token = "0x402A628")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_isLogMode;

		// Token: 0x0402A629 RID: 173609
		[Token(Token = "0x402A629")]
		[FieldOffset(Offset = "0xE0")]
		private RoguelikeScrollReportTitleView.VirtualView m_titleView;

		// Token: 0x0402A62A RID: 173610
		[Token(Token = "0x402A62A")]
		[FieldOffset(Offset = "0xE8")]
		private List<EndingReportDisplayItem> m_detailList;

		// Token: 0x0402A62B RID: 173611
		[Token(Token = "0x402A62B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402A62C RID: 173612
		[Token(Token = "0x402A62C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetupContent;

		// Token: 0x0402A62D RID: 173613
		[Token(Token = "0x402A62D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CreateViewList;

		// Token: 0x0402A62E RID: 173614
		[Token(Token = "0x402A62E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__StartPlayCoroutine;

		// Token: 0x0402A62F RID: 173615
		[Token(Token = "0x402A62F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayCoroutine;

		// Token: 0x0402A630 RID: 173616
		[Token(Token = "0x402A630")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReloadWithLogMode;

		// Token: 0x0402A631 RID: 173617
		[Token(Token = "0x402A631")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CreateTitleView;

		// Token: 0x0402A632 RID: 173618
		[Token(Token = "0x402A632")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateEndPadding;

		// Token: 0x0402A633 RID: 173619
		[Token(Token = "0x402A633")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CreateCastView;

		// Token: 0x0402A634 RID: 173620
		[Token(Token = "0x402A634")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CreateReportInitView;

		// Token: 0x0402A635 RID: 173621
		[Token(Token = "0x402A635")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CreateReportSummaryView;

		// Token: 0x0402A636 RID: 173622
		[Token(Token = "0x402A636")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CreateReportSummaryWithDifficultyView;

		// Token: 0x0402A637 RID: 173623
		[Token(Token = "0x402A637")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CreateReportEndFailView;

		// Token: 0x0402A638 RID: 173624
		[Token(Token = "0x402A638")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CreateReportZoneView;

		// Token: 0x0402A639 RID: 173625
		[Token(Token = "0x402A639")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CreateReportNodeView;

		// Token: 0x0402A63A RID: 173626
		[Token(Token = "0x402A63A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CreateReportEndView;

		// Token: 0x0402A63B RID: 173627
		[Token(Token = "0x402A63B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CreateZoneOverviewView;

		// Token: 0x0402A63C RID: 173628
		[Token(Token = "0x402A63C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CreateSimpleDescView;

		// Token: 0x0402A63D RID: 173629
		[Token(Token = "0x402A63D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ConvertDescToString;

		// Token: 0x0402A63E RID: 173630
		[Token(Token = "0x402A63E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryInjectReportPlugin;

		// Token: 0x0402A63F RID: 173631
		[Token(Token = "0x402A63F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__InjectViewModelPlugin;

		// Token: 0x0402A640 RID: 173632
		[Token(Token = "0x402A640")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetBackTween;

		// Token: 0x0402A641 RID: 173633
		[Token(Token = "0x402A641")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetSkipTween;

		// Token: 0x0402A642 RID: 173634
		[Token(Token = "0x402A642")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetBackLogModeTween;

		// Token: 0x0402A643 RID: 173635
		[Token(Token = "0x402A643")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GetContentMaskTween;

		// Token: 0x0402A644 RID: 173636
		[Token(Token = "0x402A644")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__GetBlackLoadingTween;

		// Token: 0x0402A645 RID: 173637
		[Token(Token = "0x402A645")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckIfPlaying;

		// Token: 0x0402A646 RID: 173638
		[Token(Token = "0x402A646")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__CheckIfSkipValid;

		// Token: 0x0402A647 RID: 173639
		[Token(Token = "0x402A647")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CheckIfBackValid;

		// Token: 0x0402A648 RID: 173640
		[Token(Token = "0x402A648")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CheckIfBackForLogModeAvail;

		// Token: 0x0402A649 RID: 173641
		[Token(Token = "0x402A649")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__UpdateButtonStatus;

		// Token: 0x0402A64A RID: 173642
		[Token(Token = "0x402A64A")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__TryGetScreenHeight;

		// Token: 0x0402A64B RID: 173643
		[Token(Token = "0x402A64B")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__AddDetailViewsToList;

		// Token: 0x0402A64C RID: 173644
		[Token(Token = "0x402A64C")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnClosePage;

		// Token: 0x0402A64D RID: 173645
		[Token(Token = "0x402A64D")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x0402A64E RID: 173646
		[Token(Token = "0x402A64E")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_EventOnSkipClicked;

		// Token: 0x0402A64F RID: 173647
		[Token(Token = "0x402A64F")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_EventOnLongPressing;

		// Token: 0x0402A650 RID: 173648
		[Token(Token = "0x402A650")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_EventOnLongPressCanceled;

		// Token: 0x0402A651 RID: 173649
		[Token(Token = "0x402A651")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_EventOnBackTop;

		// Token: 0x0402A652 RID: 173650
		[Token(Token = "0x402A652")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200537C RID: 21372
		[Token(Token = "0x200537C")]
		private class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0601F81A RID: 129050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F81A")]
			[Address(RVA = "0x19210F0", Offset = "0x191FCF0", VA = "0x1819210F0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0601F81B RID: 129051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F81B")]
			[Address(RVA = "0x1921150", Offset = "0x191FD50", VA = "0x181921150")]
			public void NotifyRebuild()
			{
			}

			// Token: 0x0601F81C RID: 129052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F81C")]
			[Address(RVA = "0x1921270", Offset = "0x191FE70", VA = "0x181921270")]
			public Adapter()
			{
			}

			// Token: 0x0402A653 RID: 173651
			[Token(Token = "0x402A653")]
			[FieldOffset(Offset = "0x18")]
			public IList<UIRecycleLayoutAdapter.IVirtualView> views;

			// Token: 0x0402A654 RID: 173652
			[Token(Token = "0x402A654")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0402A655 RID: 173653
			[Token(Token = "0x402A655")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_NotifyRebuild;

			// Token: 0x0402A656 RID: 173654
			[Token(Token = "0x402A656")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200537D RID: 21373
		[Token(Token = "0x200537D")]
		private class ActPlayer : IHotfixable, IDisposable
		{
			// Token: 0x0601F81D RID: 129053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F81D")]
			[Address(RVA = "0x1921030", Offset = "0x191FC30", VA = "0x181921030")]
			public ActPlayer(RoguelikeScrollReportController closure)
			{
			}

			// Token: 0x0601F81E RID: 129054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F81E")]
			[Address(RVA = "0x1920FC0", Offset = "0x191FBC0", VA = "0x181920FC0")]
			private void _UpdateScrollSpeed()
			{
			}

			// Token: 0x0601F81F RID: 129055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F81F")]
			[Address(RVA = "0x1920DE0", Offset = "0x191F9E0", VA = "0x181920DE0")]
			public void DoSkip()
			{
			}

			// Token: 0x0601F820 RID: 129056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F820")]
			[Address(RVA = "0x1920EF0", Offset = "0x191FAF0", VA = "0x181920EF0")]
			public void SetFastMode(bool isFastMode)
			{
			}

			// Token: 0x0601F821 RID: 129057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F821")]
			[Address(RVA = "0x1920CC0", Offset = "0x191F8C0", VA = "0x181920CC0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0601F822 RID: 129058 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F822")]
			[Address(RVA = "0x1920E40", Offset = "0x191FA40", VA = "0x181920E40")]
			public IEnumerator PlayCoroutine()
			{
				return null;
			}

			// Token: 0x0402A657 RID: 173655
			[Token(Token = "0x402A657")]
			private const float BASE_SCROLL_PER_FRAME = 1.5f;

			// Token: 0x0402A658 RID: 173656
			[Token(Token = "0x402A658")]
			private const float FAST_SCROLL_PER_FRAME = 8f;

			// Token: 0x0402A659 RID: 173657
			[Token(Token = "0x402A659")]
			[FieldOffset(Offset = "0x10")]
			private RoguelikeScrollReportController m_closure;

			// Token: 0x0402A65A RID: 173658
			[Token(Token = "0x402A65A")]
			[FieldOffset(Offset = "0x18")]
			private float m_scrollSpeed;

			// Token: 0x0402A65B RID: 173659
			[Token(Token = "0x402A65B")]
			[FieldOffset(Offset = "0x1C")]
			private bool m_isFastMode;

			// Token: 0x0402A65C RID: 173660
			[Token(Token = "0x402A65C")]
			[FieldOffset(Offset = "0x1D")]
			private bool m_isSkipMode;

			// Token: 0x0402A65D RID: 173661
			[Token(Token = "0x402A65D")]
			[FieldOffset(Offset = "0x20")]
			private ScreenUtil.UISleepBlocker m_sleepBlocker;

			// Token: 0x0402A65E RID: 173662
			[Token(Token = "0x402A65E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A65F RID: 173663
			[Token(Token = "0x402A65F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__UpdateScrollSpeed;

			// Token: 0x0402A660 RID: 173664
			[Token(Token = "0x402A660")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_DoSkip;

			// Token: 0x0402A661 RID: 173665
			[Token(Token = "0x402A661")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_SetFastMode;

			// Token: 0x0402A662 RID: 173666
			[Token(Token = "0x402A662")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x0402A663 RID: 173667
			[Token(Token = "0x402A663")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_PlayCoroutine;
		}
	}
}
