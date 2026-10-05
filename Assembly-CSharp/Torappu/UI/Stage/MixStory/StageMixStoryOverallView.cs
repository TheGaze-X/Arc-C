using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A99 RID: 27289
	[Token(Token = "0x2006A99")]
	public class StageMixStoryOverallView : DataBinder<ZoneGroupViewProperty>
	{
		// Token: 0x17005C3F RID: 23615
		// (get) Token: 0x060270AB RID: 159915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C3F")]
		public StageMixStoryOverallItemStateHandler itemStateHandler
		{
			[Token(Token = "0x60270AB")]
			[Address(RVA = "0x22450B0", Offset = "0x2243CB0", VA = "0x1822450B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060270AC RID: 159916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270AC")]
		[Address(RVA = "0x2242B80", Offset = "0x2241780", VA = "0x182242B80", Slot = "7")]
		public override void OnValueChanged(ZoneGroupViewProperty property)
		{
		}

		// Token: 0x060270AD RID: 159917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270AD")]
		[Address(RVA = "0x2242AE0", Offset = "0x22416E0", VA = "0x182242AE0")]
		public void OnSwitchSortModeEvent()
		{
		}

		// Token: 0x060270AE RID: 159918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270AE")]
		[Address(RVA = "0x22428C0", Offset = "0x22414C0", VA = "0x1822428C0")]
		public void OnSwitchDisplayFeatureToDefault()
		{
		}

		// Token: 0x060270AF RID: 159919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270AF")]
		[Address(RVA = "0x22427B0", Offset = "0x22413B0", VA = "0x1822427B0")]
		public void OnSwitchDisplayFeatureToCoreReward()
		{
		}

		// Token: 0x060270B0 RID: 159920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270B0")]
		[Address(RVA = "0x22429D0", Offset = "0x22415D0", VA = "0x1822429D0")]
		public void OnSwitchDisplayFeatureToStageProgress()
		{
		}

		// Token: 0x060270B1 RID: 159921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270B1")]
		[Address(RVA = "0x2243E00", Offset = "0x2242A00", VA = "0x182243E00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060270B2 RID: 159922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270B2")]
		[Address(RVA = "0x2244DB0", Offset = "0x22439B0", VA = "0x182244DB0")]
		private void _UpdateWithFade()
		{
		}

		// Token: 0x060270B3 RID: 159923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270B3")]
		[Address(RVA = "0x2244C60", Offset = "0x2243860", VA = "0x182244C60")]
		private void _UpdateView()
		{
		}

		// Token: 0x060270B4 RID: 159924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270B4")]
		[Address(RVA = "0x2244900", Offset = "0x2243500", VA = "0x182244900")]
		private void _UpdateStorylineViewsIfNeed()
		{
		}

		// Token: 0x060270B5 RID: 159925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270B5")]
		[Address(RVA = "0x22441B0", Offset = "0x2242DB0", VA = "0x1822441B0")]
		private void _UpdateReleaseYearViewsIfNeed()
		{
		}

		// Token: 0x060270B6 RID: 159926 RVA: 0x000CD5D8 File Offset: 0x000CB7D8
		[Token(Token = "0x60270B6")]
		[Address(RVA = "0x2244040", Offset = "0x2242C40", VA = "0x182244040")]
		private static int _SortReleaseYearList(KeyValuePair<int, List<StageStorylineStorySetViewModel>> x, KeyValuePair<int, List<StageStorylineStorySetViewModel>> y)
		{
			return 0;
		}

		// Token: 0x060270B7 RID: 159927 RVA: 0x000CD5F0 File Offset: 0x000CB7F0
		[Token(Token = "0x60270B7")]
		[Address(RVA = "0x22440E0", Offset = "0x2242CE0", VA = "0x1822440E0")]
		private static int _SortStorySetWithinYear(StageStorylineStorySetViewModel x, StageStorylineStorySetViewModel y)
		{
			return 0;
		}

		// Token: 0x060270B8 RID: 159928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270B8")]
		[Address(RVA = "0x2243200", Offset = "0x2241E00", VA = "0x182243200")]
		private void _AddStorySetsForVirtualView(List<UIRecycleLayoutAdapter.IVirtualView> target, List<StageStorylineStorySetViewModel> storySets)
		{
		}

		// Token: 0x060270B9 RID: 159929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270B9")]
		[Address(RVA = "0x2243700", Offset = "0x2242300", VA = "0x182243700")]
		private void _AppendRowVirtualView(List<UIRecycleLayoutAdapter.IVirtualView> target, out List<StageStorylineStorySetViewModel> list)
		{
		}

		// Token: 0x060270BA RID: 159930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270BA")]
		[Address(RVA = "0x2243900", Offset = "0x2242500", VA = "0x182243900")]
		private void _FocusStorySetIfNeed()
		{
		}

		// Token: 0x060270BB RID: 159931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270BB")]
		[Address(RVA = "0x2244F40", Offset = "0x2243B40", VA = "0x182244F40")]
		public StageMixStoryOverallView()
		{
		}

		// Token: 0x040373E2 RID: 226274
		[Token(Token = "0x40373E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIWrappedScrollRect _layoutScroll;

		// Token: 0x040373E3 RID: 226275
		[Token(Token = "0x40373E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _layoutGroup;

		// Token: 0x040373E4 RID: 226276
		[Token(Token = "0x40373E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UILayoutDimensionListener _layoutDimensionListener;

		// Token: 0x040373E5 RID: 226277
		[Token(Token = "0x40373E5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _focusPositionFix;

		// Token: 0x040373E6 RID: 226278
		[Token(Token = "0x40373E6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private StageMixStoryOverallGroupHeadComp _headCompPrefab;

		// Token: 0x040373E7 RID: 226279
		[Token(Token = "0x40373E7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StageMixStoryOverallGroupRowComp _rowCompPrefab;

		// Token: 0x040373E8 RID: 226280
		[Token(Token = "0x40373E8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _switchGroup;

		// Token: 0x040373E9 RID: 226281
		[Token(Token = "0x40373E9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _switchHalfDuration;

		// Token: 0x040373EA RID: 226282
		[Token(Token = "0x40373EA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<StageMixStoryOverallView.DisplayFeatureSwitch> _featureSwitches;

		// Token: 0x040373EB RID: 226283
		[Token(Token = "0x40373EB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _sortModeSwitchAnimation;

		// Token: 0x040373EC RID: 226284
		[Token(Token = "0x40373EC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _featureFadeHalfDuration;

		// Token: 0x040373ED RID: 226285
		[Token(Token = "0x40373ED")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_finder;

		// Token: 0x040373EE RID: 226286
		[Token(Token = "0x40373EE")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public StageMixStoryOverallView.OverallViewStatus status;

		// Token: 0x040373EF RID: 226287
		[Token(Token = "0x40373EF")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x040373F0 RID: 226288
		[Token(Token = "0x40373F0")]
		[FieldOffset(Offset = "0xB0")]
		private StageMixStoryOverallView.Adapter m_adapter;

		// Token: 0x040373F1 RID: 226289
		[Token(Token = "0x40373F1")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_scrollPosTween;

		// Token: 0x040373F2 RID: 226290
		[Token(Token = "0x40373F2")]
		[FieldOffset(Offset = "0xC0")]
		private AnimationSwitchTween m_sortModeSwitch;

		// Token: 0x040373F3 RID: 226291
		[Token(Token = "0x40373F3")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_displayFeatureSwitch;

		// Token: 0x040373F4 RID: 226292
		[Token(Token = "0x40373F4")]
		[FieldOffset(Offset = "0xD0")]
		private StageMixStoryOverallItemStateHandler m_itemStateHandler;

		// Token: 0x040373F5 RID: 226293
		[Token(Token = "0x40373F5")]
		[FieldOffset(Offset = "0xD8")]
		private readonly List<UIRecycleLayoutAdapter.IVirtualView> m_storylineViews;

		// Token: 0x040373F6 RID: 226294
		[Token(Token = "0x40373F6")]
		[FieldOffset(Offset = "0xE0")]
		private readonly ListDict<int, List<StageStorylineStorySetViewModel>> m_releaseYearListDict;

		// Token: 0x040373F7 RID: 226295
		[Token(Token = "0x40373F7")]
		[FieldOffset(Offset = "0xE8")]
		private readonly List<UIRecycleLayoutAdapter.IVirtualView> m_releaseYearViews;

		// Token: 0x040373F8 RID: 226296
		[Token(Token = "0x40373F8")]
		[FieldOffset(Offset = "0xF0")]
		private MixStoryZoneGroupViewModel m_cachedModel;

		// Token: 0x040373F9 RID: 226297
		[Token(Token = "0x40373F9")]
		[FieldOffset(Offset = "0xF8")]
		private int m_currentDataSequence;

		// Token: 0x040373FA RID: 226298
		[Token(Token = "0x40373FA")]
		[FieldOffset(Offset = "0xFC")]
		private int m_storylineDataSequence;

		// Token: 0x040373FB RID: 226299
		[Token(Token = "0x40373FB")]
		[FieldOffset(Offset = "0x100")]
		private int m_releaseYearDataSequence;

		// Token: 0x040373FC RID: 226300
		[Token(Token = "0x40373FC")]
		[FieldOffset(Offset = "0x104")]
		private StageMixStoryOverallView.OverallSortMode m_displayingSortMode;

		// Token: 0x040373FD RID: 226301
		[Token(Token = "0x40373FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemStateHandler;

		// Token: 0x040373FE RID: 226302
		[Token(Token = "0x40373FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040373FF RID: 226303
		[Token(Token = "0x40373FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSwitchSortModeEvent;

		// Token: 0x04037400 RID: 226304
		[Token(Token = "0x4037400")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSwitchDisplayFeatureToDefault;

		// Token: 0x04037401 RID: 226305
		[Token(Token = "0x4037401")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSwitchDisplayFeatureToCoreReward;

		// Token: 0x04037402 RID: 226306
		[Token(Token = "0x4037402")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSwitchDisplayFeatureToStageProgress;

		// Token: 0x04037403 RID: 226307
		[Token(Token = "0x4037403")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037404 RID: 226308
		[Token(Token = "0x4037404")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateWithFade;

		// Token: 0x04037405 RID: 226309
		[Token(Token = "0x4037405")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x04037406 RID: 226310
		[Token(Token = "0x4037406")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateStorylineViewsIfNeed;

		// Token: 0x04037407 RID: 226311
		[Token(Token = "0x4037407")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateReleaseYearViewsIfNeed;

		// Token: 0x04037408 RID: 226312
		[Token(Token = "0x4037408")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SortReleaseYearList;

		// Token: 0x04037409 RID: 226313
		[Token(Token = "0x4037409")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SortStorySetWithinYear;

		// Token: 0x0403740A RID: 226314
		[Token(Token = "0x403740A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__AddStorySetsForVirtualView;

		// Token: 0x0403740B RID: 226315
		[Token(Token = "0x403740B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__AppendRowVirtualView;

		// Token: 0x0403740C RID: 226316
		[Token(Token = "0x403740C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__FocusStorySetIfNeed;

		// Token: 0x0403740D RID: 226317
		[Token(Token = "0x403740D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A9A RID: 27290
		[Token(Token = "0x2006A9A")]
		public enum OverallSortMode
		{
			// Token: 0x0403740F RID: 226319
			[Token(Token = "0x403740F")]
			STORYLINE,
			// Token: 0x04037410 RID: 226320
			[Token(Token = "0x4037410")]
			RELEASE_YEAR
		}

		// Token: 0x02006A9B RID: 27291
		[Token(Token = "0x2006A9B")]
		[Flags]
		public enum OverallDisplayFeature
		{
			// Token: 0x04037412 RID: 226322
			[Token(Token = "0x4037412")]
			NONE = 0,
			// Token: 0x04037413 RID: 226323
			[Token(Token = "0x4037413")]
			DEFAULT = 1,
			// Token: 0x04037414 RID: 226324
			[Token(Token = "0x4037414")]
			CORE_REWARD = 2,
			// Token: 0x04037415 RID: 226325
			[Token(Token = "0x4037415")]
			PROGRESS = 8,
			// Token: 0x04037416 RID: 226326
			[Token(Token = "0x4037416")]
			ALL = 11
		}

		// Token: 0x02006A9C RID: 27292
		[Token(Token = "0x2006A9C")]
		public struct OverallViewStatus
		{
			// Token: 0x04037417 RID: 226327
			[Token(Token = "0x4037417")]
			[FieldOffset(Offset = "0x0")]
			public bool initShow;

			// Token: 0x04037418 RID: 226328
			[Token(Token = "0x4037418")]
			[FieldOffset(Offset = "0x4")]
			public StageMixStoryOverallView.OverallSortMode sortMode;

			// Token: 0x04037419 RID: 226329
			[Token(Token = "0x4037419")]
			[FieldOffset(Offset = "0x8")]
			public StageMixStoryOverallView.OverallDisplayFeature displayFeature;

			// Token: 0x0403741A RID: 226330
			[Token(Token = "0x403741A")]
			[FieldOffset(Offset = "0x10")]
			public string skipFocusStorySetId;
		}

		// Token: 0x02006A9D RID: 27293
		[Token(Token = "0x2006A9D")]
		private class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x060270BC RID: 159932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60270BC")]
			[Address(RVA = "0x2236440", Offset = "0x2235040", VA = "0x182236440")]
			public Adapter(StageMixStoryOverallView closure)
			{
			}

			// Token: 0x060270BD RID: 159933 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60270BD")]
			[Address(RVA = "0x2235CF0", Offset = "0x22348F0", VA = "0x182235CF0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x060270BE RID: 159934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60270BE")]
			[Address(RVA = "0x2235D70", Offset = "0x2234970", VA = "0x182235D70")]
			public void NotifyRebuild()
			{
			}

			// Token: 0x0403741B RID: 226331
			[Token(Token = "0x403741B")]
			[FieldOffset(Offset = "0x18")]
			private readonly StageMixStoryOverallView m_closure;

			// Token: 0x0403741C RID: 226332
			[Token(Token = "0x403741C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403741D RID: 226333
			[Token(Token = "0x403741D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0403741E RID: 226334
			[Token(Token = "0x403741E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_NotifyRebuild;
		}

		// Token: 0x02006A9E RID: 27294
		[Token(Token = "0x2006A9E")]
		[Serializable]
		public class DisplayFeatureSwitch : IHotfixable
		{
			// Token: 0x060270BF RID: 159935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60270BF")]
			[Address(RVA = "0x2238490", Offset = "0x2237090", VA = "0x182238490")]
			public void SetSelected(StageMixStoryOverallView.OverallDisplayFeature current, bool fastMode)
			{
			}

			// Token: 0x060270C0 RID: 159936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60270C0")]
			[Address(RVA = "0x2238680", Offset = "0x2237280", VA = "0x182238680")]
			private void _InitIfNot()
			{
			}

			// Token: 0x060270C1 RID: 159937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60270C1")]
			[Address(RVA = "0x22387A0", Offset = "0x22373A0", VA = "0x1822387A0")]
			public DisplayFeatureSwitch()
			{
			}

			// Token: 0x0403741F RID: 226335
			[Token(Token = "0x403741F")]
			[FieldOffset(Offset = "0x10")]
			public StageMixStoryOverallView.OverallDisplayFeature feature;

			// Token: 0x04037420 RID: 226336
			[Token(Token = "0x4037420")]
			[FieldOffset(Offset = "0x18")]
			public CanvasGroup unselectedGroup;

			// Token: 0x04037421 RID: 226337
			[Token(Token = "0x4037421")]
			[FieldOffset(Offset = "0x20")]
			public CanvasGroup selectedGroup;

			// Token: 0x04037422 RID: 226338
			[Token(Token = "0x4037422")]
			[FieldOffset(Offset = "0x28")]
			private FadeSwitchTween m_unselectedTween;

			// Token: 0x04037423 RID: 226339
			[Token(Token = "0x4037423")]
			[FieldOffset(Offset = "0x30")]
			private FadeSwitchTween m_selectedTween;

			// Token: 0x04037424 RID: 226340
			[Token(Token = "0x4037424")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetSelected;

			// Token: 0x04037425 RID: 226341
			[Token(Token = "0x4037425")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__InitIfNot;

			// Token: 0x04037426 RID: 226342
			[Token(Token = "0x4037426")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006A9F RID: 27295
		[Token(Token = "0x2006A9F")]
		private struct FocusAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x060270C2 RID: 159938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60270C2")]
			[Address(RVA = "0x2239C90", Offset = "0x2238890", VA = "0x182239C90", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x04037427 RID: 226343
			[Token(Token = "0x4037427")]
			[FieldOffset(Offset = "0x0")]
			public StageMixStoryOverallView closure;

			// Token: 0x04037428 RID: 226344
			[Token(Token = "0x4037428")]
			[FieldOffset(Offset = "0x8")]
			public float position;
		}
	}
}
