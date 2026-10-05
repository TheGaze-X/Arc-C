using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BBD RID: 19389
	[Token(Token = "0x2004BBD")]
	public class ActivityTopBarHolder : PageComponent
	{
		// Token: 0x0601D233 RID: 119347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D233")]
		[Address(RVA = "0x16B1270", Offset = "0x16AFE70", VA = "0x1816B1270")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D234 RID: 119348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D234")]
		[Address(RVA = "0x16B0AB0", Offset = "0x16AF6B0", VA = "0x1816B0AB0")]
		public void Render(List<string> unfinishedActs, List<string> finishedActs)
		{
		}

		// Token: 0x0601D235 RID: 119349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D235")]
		[Address(RVA = "0x16B09C0", Offset = "0x16AF5C0", VA = "0x1816B09C0")]
		public void ExpandSide(bool expand)
		{
		}

		// Token: 0x0601D236 RID: 119350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D236")]
		[Address(RVA = "0x16B0940", Offset = "0x16AF540", VA = "0x1816B0940")]
		public void ExpandBottom(bool expand)
		{
		}

		// Token: 0x0601D237 RID: 119351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D237")]
		[Address(RVA = "0x16B1880", Offset = "0x16B0480", VA = "0x1816B1880")]
		private void _OnActClicked(string actId)
		{
		}

		// Token: 0x0601D238 RID: 119352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D238")]
		[Address(RVA = "0x16B1920", Offset = "0x16B0520", VA = "0x1816B1920")]
		private void _OnSwitchTweenEnd()
		{
		}

		// Token: 0x0601D239 RID: 119353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D239")]
		[Address(RVA = "0x16B1990", Offset = "0x16B0590", VA = "0x1816B1990")]
		private void _OnSwitchTweenStart()
		{
		}

		// Token: 0x0601D23A RID: 119354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D23A")]
		[Address(RVA = "0x16B0A50", Offset = "0x16AF650", VA = "0x1816B0A50")]
		private void OnDisable()
		{
		}

		// Token: 0x0601D23B RID: 119355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D23B")]
		[Address(RVA = "0x16B34C0", Offset = "0x16B20C0", VA = "0x1816B34C0")]
		private void _UpdateEntryViews(List<string> unfinishedActs, List<string> finishedActs)
		{
		}

		// Token: 0x0601D23C RID: 119356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D23C")]
		[Address(RVA = "0x16B1EC0", Offset = "0x16B0AC0", VA = "0x1816B1EC0")]
		private void _RecomputeConfigList(List<string> unfinishedActs, List<string> finishedActs)
		{
		}

		// Token: 0x0601D23D RID: 119357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D23D")]
		[Address(RVA = "0x16B15A0", Offset = "0x16B01A0", VA = "0x1816B15A0")]
		private void _LoadConfigsFromActList(List<string> actList, bool isFinished, int offset, ref int cnt)
		{
		}

		// Token: 0x0601D23E RID: 119358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D23E")]
		[Address(RVA = "0x16B19F0", Offset = "0x16B05F0", VA = "0x1816B19F0")]
		private void _RebuildEntryListIfNeeded(List<string> unfinishedActs, List<string> finishedActs)
		{
		}

		// Token: 0x0601D23F RID: 119359 RVA: 0x000AAB08 File Offset: 0x000A8D08
		[Token(Token = "0x601D23F")]
		[Address(RVA = "0x16B0F60", Offset = "0x16AFB60", VA = "0x1816B0F60")]
		private bool _DiffEntryConfigLists(List<string> unfinishedActs, List<string> finishedActs)
		{
			return default(bool);
		}

		// Token: 0x0601D240 RID: 119360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D240")]
		[Address(RVA = "0x16B30C0", Offset = "0x16B1CC0", VA = "0x1816B30C0")]
		private void _SetProperPrefabs()
		{
		}

		// Token: 0x0601D241 RID: 119361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D241")]
		[Address(RVA = "0x16B3330", Offset = "0x16B1F30", VA = "0x1816B3330")]
		private ActivityTopBarView _TryLoadProperPrefab(string actId, int entryCount)
		{
			return null;
		}

		// Token: 0x0601D242 RID: 119362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D242")]
		[Address(RVA = "0x16B2370", Offset = "0x16B0F70", VA = "0x1816B2370")]
		private void _RenderActivities(bool fastMode)
		{
		}

		// Token: 0x0601D243 RID: 119363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D243")]
		[Address(RVA = "0x16B2110", Offset = "0x16B0D10", VA = "0x1816B2110")]
		private void _RenderActivitiesDirectly(List<ActShowType> showTypeList, int startI, int endI, bool fastMode, ref int showTypeI)
		{
		}

		// Token: 0x0601D244 RID: 119364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D244")]
		[Address(RVA = "0x16B1FF0", Offset = "0x16B0BF0", VA = "0x1816B1FF0")]
		private IEnumerator _RenderActivitiesCoroutine(List<ActShowType> showTypeList, int startI, int endI, bool fastMode, int showTypeI)
		{
			return null;
		}

		// Token: 0x0601D245 RID: 119365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D245")]
		[Address(RVA = "0x16B29D0", Offset = "0x16B15D0", VA = "0x1816B29D0")]
		private void _RenderExpandBtns(bool hasCollapsibleAct, bool hasUnfinishedAct)
		{
		}

		// Token: 0x0601D246 RID: 119366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D246")]
		[Address(RVA = "0x16B2AF0", Offset = "0x16B16F0", VA = "0x1816B2AF0")]
		private void _SetExpandBtnsPos(bool fastMode, int newShowCount)
		{
		}

		// Token: 0x0601D247 RID: 119367 RVA: 0x000AAB20 File Offset: 0x000A8D20
		[Token(Token = "0x601D247")]
		[Address(RVA = "0x16B0D00", Offset = "0x16AF900", VA = "0x1816B0D00")]
		private float _CalculateHeight(int activeCount)
		{
			return 0f;
		}

		// Token: 0x0601D248 RID: 119368 RVA: 0x000AAB38 File Offset: 0x000A8D38
		[Token(Token = "0x601D248")]
		[Address(RVA = "0x16B13E0", Offset = "0x16AFFE0", VA = "0x1816B13E0")]
		private ActShowType _JudgeShowType(ActivityTopBarHolder.EntryConfig config, out bool inCollapsedList)
		{
			return ActShowType.NONE;
		}

		// Token: 0x0601D249 RID: 119369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D249")]
		[Address(RVA = "0x16B0E60", Offset = "0x16AFA60", VA = "0x1816B0E60")]
		private void _ClearVerticalExpandAnim()
		{
		}

		// Token: 0x0601D24A RID: 119370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D24A")]
		[Address(RVA = "0x16B3560", Offset = "0x16B2160", VA = "0x1816B3560")]
		public ActivityTopBarHolder()
		{
		}

		// Token: 0x040263D9 RID: 156633
		[Token(Token = "0x40263D9")]
		private const int MAX_SHOW_ACT = 3;

		// Token: 0x040263DA RID: 156634
		[Token(Token = "0x40263DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIStringEvent _clickEvent;

		// Token: 0x040263DB RID: 156635
		[Token(Token = "0x40263DB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Default prefab used for home acts")]
		private ActivityTopBarView _actViewPrefab;

		// Token: 0x040263DC RID: 156636
		[Token(Token = "0x40263DC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _actScrollView;

		// Token: 0x040263DD RID: 156637
		[Token(Token = "0x40263DD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _actViewContainer;

		// Token: 0x040263DE RID: 156638
		[Token(Token = "0x40263DE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Expand")]
		private TwoStateToggle _actExpandToggleBottom;

		// Token: 0x040263DF RID: 156639
		[Token(Token = "0x40263DF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Expand")]
		private TwoStateToggle _actExpandToggleSide;

		// Token: 0x040263E0 RID: 156640
		[Token(Token = "0x40263E0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Expand")]
		private UICommonTrackPoint _actExpandTrackPoint;

		// Token: 0x040263E1 RID: 156641
		[Token(Token = "0x40263E1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Animation")]
		private CanvasGroup _expandGroup;

		// Token: 0x040263E2 RID: 156642
		[Token(Token = "0x40263E2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _expandSideAnimLocation;

		// Token: 0x040263E3 RID: 156643
		[Token(Token = "0x40263E3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _collapseSideAnimLocation;

		// Token: 0x040263E4 RID: 156644
		[Token(Token = "0x40263E4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Animation")]
		private float _verticalExpandItemShowDelay;

		// Token: 0x040263E5 RID: 156645
		[Token(Token = "0x40263E5")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		[Group("Animation")]
		private float _verticalExpandBtnShowBaseDuration;

		// Token: 0x040263E6 RID: 156646
		[Token(Token = "0x40263E6")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x040263E7 RID: 156647
		[Token(Token = "0x40263E7")]
		[FieldOffset(Offset = "0x89")]
		private bool m_showCollapsedAct;

		// Token: 0x040263E8 RID: 156648
		[Token(Token = "0x40263E8")]
		[FieldOffset(Offset = "0x8C")]
		private int m_unfinishedActCount;

		// Token: 0x040263E9 RID: 156649
		[Token(Token = "0x40263E9")]
		[FieldOffset(Offset = "0x90")]
		private int m_finishedActCount;

		// Token: 0x040263EA RID: 156650
		[Token(Token = "0x40263EA")]
		[FieldOffset(Offset = "0x94")]
		private float m_viewHeight;

		// Token: 0x040263EB RID: 156651
		[Token(Token = "0x40263EB")]
		[FieldOffset(Offset = "0x98")]
		private float m_firstViewWidth;

		// Token: 0x040263EC RID: 156652
		[Token(Token = "0x40263EC")]
		[FieldOffset(Offset = "0xA0")]
		private List<ActivityTopBarHolder.EntryConfig> m_oldConfigList;

		// Token: 0x040263ED RID: 156653
		[Token(Token = "0x40263ED")]
		[FieldOffset(Offset = "0xA8")]
		private List<ActivityTopBarHolder.EntryConfig> m_newConfigList;

		// Token: 0x040263EE RID: 156654
		[Token(Token = "0x40263EE")]
		[FieldOffset(Offset = "0xB0")]
		private List<ActivityTopBarView> m_entryList;

		// Token: 0x040263EF RID: 156655
		[Token(Token = "0x40263EF")]
		[FieldOffset(Offset = "0xB8")]
		private TrackPointViewProperty m_expandRedPoint;

		// Token: 0x040263F0 RID: 156656
		[Token(Token = "0x40263F0")]
		[FieldOffset(Offset = "0xC0")]
		private ActivityTopBarHolder.ExpandSwitchTween m_switchTween;

		// Token: 0x040263F1 RID: 156657
		[Token(Token = "0x40263F1")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_bottomExpandBtnTween;

		// Token: 0x040263F2 RID: 156658
		[Token(Token = "0x40263F2")]
		[FieldOffset(Offset = "0xD0")]
		private int m_showActCount;

		// Token: 0x040263F3 RID: 156659
		[Token(Token = "0x40263F3")]
		[FieldOffset(Offset = "0xD8")]
		private Coroutine m_bottomExpandBtnCoroutine;

		// Token: 0x040263F4 RID: 156660
		[Token(Token = "0x40263F4")]
		[FieldOffset(Offset = "0xE0")]
		private int m_playingExpandItemNum;

		// Token: 0x040263F5 RID: 156661
		[Token(Token = "0x40263F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040263F6 RID: 156662
		[Token(Token = "0x40263F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040263F7 RID: 156663
		[Token(Token = "0x40263F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ExpandSide;

		// Token: 0x040263F8 RID: 156664
		[Token(Token = "0x40263F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ExpandBottom;

		// Token: 0x040263F9 RID: 156665
		[Token(Token = "0x40263F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnActClicked;

		// Token: 0x040263FA RID: 156666
		[Token(Token = "0x40263FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSwitchTweenEnd;

		// Token: 0x040263FB RID: 156667
		[Token(Token = "0x40263FB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSwitchTweenStart;

		// Token: 0x040263FC RID: 156668
		[Token(Token = "0x40263FC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x040263FD RID: 156669
		[Token(Token = "0x40263FD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateEntryViews;

		// Token: 0x040263FE RID: 156670
		[Token(Token = "0x40263FE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RecomputeConfigList;

		// Token: 0x040263FF RID: 156671
		[Token(Token = "0x40263FF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadConfigsFromActList;

		// Token: 0x04026400 RID: 156672
		[Token(Token = "0x4026400")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RebuildEntryListIfNeeded;

		// Token: 0x04026401 RID: 156673
		[Token(Token = "0x4026401")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DiffEntryConfigLists;

		// Token: 0x04026402 RID: 156674
		[Token(Token = "0x4026402")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetProperPrefabs;

		// Token: 0x04026403 RID: 156675
		[Token(Token = "0x4026403")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryLoadProperPrefab;

		// Token: 0x04026404 RID: 156676
		[Token(Token = "0x4026404")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RenderActivities;

		// Token: 0x04026405 RID: 156677
		[Token(Token = "0x4026405")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RenderActivitiesDirectly;

		// Token: 0x04026406 RID: 156678
		[Token(Token = "0x4026406")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RenderActivitiesCoroutine;

		// Token: 0x04026407 RID: 156679
		[Token(Token = "0x4026407")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__RenderExpandBtns;

		// Token: 0x04026408 RID: 156680
		[Token(Token = "0x4026408")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SetExpandBtnsPos;

		// Token: 0x04026409 RID: 156681
		[Token(Token = "0x4026409")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CalculateHeight;

		// Token: 0x0402640A RID: 156682
		[Token(Token = "0x402640A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__JudgeShowType;

		// Token: 0x0402640B RID: 156683
		[Token(Token = "0x402640B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ClearVerticalExpandAnim;

		// Token: 0x0402640C RID: 156684
		[Token(Token = "0x402640C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BBE RID: 19390
		[Token(Token = "0x2004BBE")]
		private struct EntryConfig : IHotfixable
		{
			// Token: 0x0402640D RID: 156685
			[Token(Token = "0x402640D")]
			[FieldOffset(Offset = "0x0")]
			public string actId;

			// Token: 0x0402640E RID: 156686
			[Token(Token = "0x402640E")]
			[FieldOffset(Offset = "0x8")]
			public ActivityTable.HomeActivityConfig homeActConfig;

			// Token: 0x0402640F RID: 156687
			[Token(Token = "0x402640F")]
			[FieldOffset(Offset = "0x10")]
			public ActivityTopBarView prefab;

			// Token: 0x04026410 RID: 156688
			[Token(Token = "0x4026410")]
			[FieldOffset(Offset = "0x18")]
			public int index;

			// Token: 0x04026411 RID: 156689
			[Token(Token = "0x4026411")]
			[FieldOffset(Offset = "0x1C")]
			public bool isFinished;
		}

		// Token: 0x02004BBF RID: 19391
		[Token(Token = "0x2004BBF")]
		private class ExpandSwitchTween : UISwitchTween
		{
			// Token: 0x0601D24B RID: 119371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D24B")]
			[Address(RVA = "0x16B7CC0", Offset = "0x16B68C0", VA = "0x1816B7CC0")]
			public ExpandSwitchTween(ActivityTopBarHolder closure)
			{
			}

			// Token: 0x0601D24C RID: 119372 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D24C")]
			[Address(RVA = "0x16B7910", Offset = "0x16B6510", VA = "0x1816B7910", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601D24D RID: 119373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D24D")]
			[Address(RVA = "0x16B77B0", Offset = "0x16B63B0", VA = "0x1816B77B0", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0601D24E RID: 119374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D24E")]
			[Address(RVA = "0x16B7730", Offset = "0x16B6330", VA = "0x1816B7730", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601D24F RID: 119375 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D24F")]
			[Address(RVA = "0x16B7AD0", Offset = "0x16B66D0", VA = "0x1816B7AD0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601D250 RID: 119376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D250")]
			[Address(RVA = "0x16B7850", Offset = "0x16B6450", VA = "0x1816B7850", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601D253 RID: 119379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D253")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0601D254 RID: 119380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D254")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601D255 RID: 119381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D255")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x04026412 RID: 156690
			[Token(Token = "0x4026412")]
			[FieldOffset(Offset = "0x48")]
			private ActivityTopBarHolder m_closure;

			// Token: 0x04026413 RID: 156691
			[Token(Token = "0x4026413")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026414 RID: 156692
			[Token(Token = "0x4026414")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04026415 RID: 156693
			[Token(Token = "0x4026415")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x04026416 RID: 156694
			[Token(Token = "0x4026416")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04026417 RID: 156695
			[Token(Token = "0x4026417")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04026418 RID: 156696
			[Token(Token = "0x4026418")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;
		}
	}
}
