using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004323 RID: 17187
	[Token(Token = "0x2004323")]
	public class SandboxV2HomeView : DataBinder<SandboxV2HomeModelProperty>, IHotfixable
	{
		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x0601A689 RID: 108169 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A68A RID: 108170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003EAB")]
		public Action onEnterGameAction
		{
			[Token(Token = "0x601A689")]
			[Address(RVA = "0x1354CB0", Offset = "0x13538B0", VA = "0x181354CB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A68A")]
			[Address(RVA = "0x1355110", Offset = "0x1353D10", VA = "0x181355110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x0601A68B RID: 108171 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A68C RID: 108172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003EAC")]
		public Action onEnterMonthAction
		{
			[Token(Token = "0x601A68B")]
			[Address(RVA = "0x1354D10", Offset = "0x1353910", VA = "0x181354D10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A68C")]
			[Address(RVA = "0x1355190", Offset = "0x1353D90", VA = "0x181355190")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x0601A68D RID: 108173 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A68E RID: 108174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003EAD")]
		public Action onEnterArchiveAction
		{
			[Token(Token = "0x601A68D")]
			[Address(RVA = "0x1354BF0", Offset = "0x13537F0", VA = "0x181354BF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A68E")]
			[Address(RVA = "0x1355010", Offset = "0x1353C10", VA = "0x181355010")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x0601A68F RID: 108175 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A690 RID: 108176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003EAE")]
		public Action onEnterShopAction
		{
			[Token(Token = "0x601A68F")]
			[Address(RVA = "0x1354D70", Offset = "0x1353970", VA = "0x181354D70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A690")]
			[Address(RVA = "0x1355210", Offset = "0x1353E10", VA = "0x181355210")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003EAF RID: 16047
		// (get) Token: 0x0601A691 RID: 108177 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A692 RID: 108178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003EAF")]
		public Action onOpenMedalGroupAction
		{
			[Token(Token = "0x601A691")]
			[Address(RVA = "0x1354EF0", Offset = "0x1353AF0", VA = "0x181354EF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A692")]
			[Address(RVA = "0x1355410", Offset = "0x1354010", VA = "0x181355410")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x0601A693 RID: 108179 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A694 RID: 108180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003EB0")]
		public Action onOpenGuideAction
		{
			[Token(Token = "0x601A693")]
			[Address(RVA = "0x1354E90", Offset = "0x1353A90", VA = "0x181354E90")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A694")]
			[Address(RVA = "0x1355390", Offset = "0x1353F90", VA = "0x181355390")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x0601A695 RID: 108181 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A696 RID: 108182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003EB1")]
		public Action<bool> onToggleChallengeAction
		{
			[Token(Token = "0x601A695")]
			[Address(RVA = "0x1354FB0", Offset = "0x1353BB0", VA = "0x181354FB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A696")]
			[Address(RVA = "0x1355510", Offset = "0x1354110", VA = "0x181355510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x0601A697 RID: 108183 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A698 RID: 108184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003EB2")]
		public Action onEnterChallengeAction
		{
			[Token(Token = "0x601A697")]
			[Address(RVA = "0x1354C50", Offset = "0x1353850", VA = "0x181354C50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A698")]
			[Address(RVA = "0x1355090", Offset = "0x1353C90", VA = "0x181355090")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003EB3 RID: 16051
		// (get) Token: 0x0601A699 RID: 108185 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A69A RID: 108186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003EB3")]
		public Action onSettleChallengeAction
		{
			[Token(Token = "0x601A699")]
			[Address(RVA = "0x1354F50", Offset = "0x1353B50", VA = "0x181354F50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A69A")]
			[Address(RVA = "0x1355490", Offset = "0x1354090", VA = "0x181355490")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003EB4 RID: 16052
		// (get) Token: 0x0601A69B RID: 108187 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A69C RID: 108188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003EB4")]
		public Action onOpenChallengeRewardDialogAction
		{
			[Token(Token = "0x601A69B")]
			[Address(RVA = "0x1354E30", Offset = "0x1353A30", VA = "0x181354E30")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A69C")]
			[Address(RVA = "0x1355310", Offset = "0x1353F10", VA = "0x181355310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003EB5 RID: 16053
		// (get) Token: 0x0601A69D RID: 108189 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A69E RID: 108190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003EB5")]
		public Action onExploreModeClickAction
		{
			[Token(Token = "0x601A69D")]
			[Address(RVA = "0x1354DD0", Offset = "0x13539D0", VA = "0x181354DD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A69E")]
			[Address(RVA = "0x1355290", Offset = "0x1353E90", VA = "0x181355290")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003EB6 RID: 16054
		// (get) Token: 0x0601A69F RID: 108191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EB6")]
		public Canvas[] needBindCanvas
		{
			[Token(Token = "0x601A69F")]
			[Address(RVA = "0x1354B30", Offset = "0x1353730", VA = "0x181354B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003EB7 RID: 16055
		// (get) Token: 0x0601A6A0 RID: 108192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EB7")]
		public UICommonPageEffectHolder[] needBindEffectHolders
		{
			[Token(Token = "0x601A6A0")]
			[Address(RVA = "0x1354B90", Offset = "0x1353790", VA = "0x181354B90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A6A1 RID: 108193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6A1")]
		[Address(RVA = "0x1353CB0", Offset = "0x13528B0", VA = "0x181353CB0", Slot = "7")]
		public override void OnValueChanged(SandboxV2HomeModelProperty property)
		{
		}

		// Token: 0x0601A6A2 RID: 108194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A6A2")]
		[Address(RVA = "0x1354220", Offset = "0x1352E20", VA = "0x181354220")]
		public Coroutine StartShowEffect(bool fastMode, bool backFromBattle)
		{
			return null;
		}

		// Token: 0x0601A6A3 RID: 108195 RVA: 0x000A1C40 File Offset: 0x0009FE40
		[Token(Token = "0x601A6A3")]
		[Address(RVA = "0x1353BE0", Offset = "0x13527E0", VA = "0x181353BE0")]
		public SandboxPermHomePage.DisplayTweenConfig GetDisplayTweenConfig(bool fastMode)
		{
			return default(SandboxPermHomePage.DisplayTweenConfig);
		}

		// Token: 0x0601A6A4 RID: 108196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6A4")]
		[Address(RVA = "0x13540F0", Offset = "0x1352CF0", VA = "0x1813540F0")]
		public void SetEffectEnable(bool isEnable)
		{
		}

		// Token: 0x0601A6A5 RID: 108197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6A5")]
		[Address(RVA = "0x1354440", Offset = "0x1353040", VA = "0x181354440")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A6A6 RID: 108198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A6A6")]
		[Address(RVA = "0x1354590", Offset = "0x1353190", VA = "0x181354590")]
		private IEnumerator _ShowEffectCoroutine(bool fastMode, bool backFromBattle)
		{
			return null;
		}

		// Token: 0x0601A6A7 RID: 108199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6A7")]
		[Address(RVA = "0x1354790", Offset = "0x1353390", VA = "0x181354790")]
		private void _TryToTriggerAvg(string topicId, Action nextStep)
		{
		}

		// Token: 0x0601A6A8 RID: 108200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6A8")]
		[Address(RVA = "0x1353320", Offset = "0x1351F20", VA = "0x181353320")]
		public void EventOnEnterGame()
		{
		}

		// Token: 0x0601A6A9 RID: 108201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6A9")]
		[Address(RVA = "0x1353430", Offset = "0x1352030", VA = "0x181353430")]
		public void EventOnEnterMonth()
		{
		}

		// Token: 0x0601A6AA RID: 108202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6AA")]
		[Address(RVA = "0x1353100", Offset = "0x1351D00", VA = "0x181353100")]
		public void EventOnEnterArchive()
		{
		}

		// Token: 0x0601A6AB RID: 108203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6AB")]
		[Address(RVA = "0x1353540", Offset = "0x1352140", VA = "0x181353540")]
		public void EventOnEnterShop()
		{
		}

		// Token: 0x0601A6AC RID: 108204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6AC")]
		[Address(RVA = "0x1353A00", Offset = "0x1352600", VA = "0x181353A00")]
		public void EventOnOpenMedalGroup()
		{
		}

		// Token: 0x0601A6AD RID: 108205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6AD")]
		[Address(RVA = "0x13538F0", Offset = "0x13524F0", VA = "0x1813538F0")]
		public void EventOnOpenGuide()
		{
		}

		// Token: 0x0601A6AE RID: 108206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6AE")]
		[Address(RVA = "0x13537E0", Offset = "0x13523E0", VA = "0x1813537E0")]
		public void EventOnOpenChallenge()
		{
		}

		// Token: 0x0601A6AF RID: 108207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6AF")]
		[Address(RVA = "0x1352FF0", Offset = "0x1351BF0", VA = "0x181352FF0")]
		public void EventOnCloseChallenge()
		{
		}

		// Token: 0x0601A6B0 RID: 108208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6B0")]
		[Address(RVA = "0x1353210", Offset = "0x1351E10", VA = "0x181353210")]
		public void EventOnEnterChallenge()
		{
		}

		// Token: 0x0601A6B1 RID: 108209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6B1")]
		[Address(RVA = "0x1353B10", Offset = "0x1352710", VA = "0x181353B10")]
		public void EventOnSettleChallenge()
		{
		}

		// Token: 0x0601A6B2 RID: 108210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6B2")]
		[Address(RVA = "0x1353710", Offset = "0x1352310", VA = "0x181353710")]
		public void EventOnOpenChallengeRewardDialog()
		{
		}

		// Token: 0x0601A6B3 RID: 108211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6B3")]
		[Address(RVA = "0x1353650", Offset = "0x1352250", VA = "0x181353650")]
		public void EventOnExploreModeClicked()
		{
		}

		// Token: 0x0601A6B4 RID: 108212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6B4")]
		[Address(RVA = "0x1354990", Offset = "0x1353590", VA = "0x181354990")]
		private void _TryTriggerTutorial()
		{
		}

		// Token: 0x0601A6B5 RID: 108213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6B5")]
		[Address(RVA = "0x1354670", Offset = "0x1353270", VA = "0x181354670")]
		private void _TryRaiseAvgSignal()
		{
		}

		// Token: 0x0601A6B6 RID: 108214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A6B6")]
		[Address(RVA = "0x13543D0", Offset = "0x1352FD0", VA = "0x1813543D0")]
		public GameObject TutorialOnly_GetChallengeModeEntryBtnGo()
		{
			return null;
		}

		// Token: 0x0601A6B7 RID: 108215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6B7")]
		[Address(RVA = "0x1354A70", Offset = "0x1353670", VA = "0x181354A70")]
		public SandboxV2HomeView()
		{
		}

		// Token: 0x040218A0 RID: 137376
		[Token(Token = "0x40218A0")]
		private const string SANDBOX_V2_ENTRY_AVG_TRIGGER = "ra_entry";

		// Token: 0x040218A1 RID: 137377
		[Token(Token = "0x40218A1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2HomeGameEntryView _gameEntryView;

		// Token: 0x040218A2 RID: 137378
		[Token(Token = "0x40218A2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2HomeMonthEntryView _monthEntryView;

		// Token: 0x040218A3 RID: 137379
		[Token(Token = "0x40218A3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SandboxV2HomeShopEntryView _shopEntryView;

		// Token: 0x040218A4 RID: 137380
		[Token(Token = "0x40218A4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SandboxV2HomeChallengeEntryView _challengeEntryView;

		// Token: 0x040218A5 RID: 137381
		[Token(Token = "0x40218A5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation[] _enterAnims;

		// Token: 0x040218A6 RID: 137382
		[Token(Token = "0x40218A6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation[] _loopAnims;

		// Token: 0x040218A7 RID: 137383
		[Token(Token = "0x40218A7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICommonPageEffectHolder[] _effectHolders;

		// Token: 0x040218A8 RID: 137384
		[Token(Token = "0x40218A8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Canvas[] _canvases;

		// Token: 0x040218A9 RID: 137385
		[Token(Token = "0x40218A9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SandboxPermHomePage.DisplayTweenConfig _topCanvasDisplayConfig;

		// Token: 0x040218AA RID: 137386
		[Token(Token = "0x40218AA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UICommonTrackPoint _trackPointArchive;

		// Token: 0x040218AB RID: 137387
		[Token(Token = "0x40218AB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Tooltip("Optional/Nullable")]
		private SandboxV2HomeExploreModeView _exploreModeView;

		// Token: 0x040218AC RID: 137388
		[Token(Token = "0x40218AC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SandboxV2HomeChallengeModeView _challengeModeView;

		// Token: 0x040218AD RID: 137389
		[Token(Token = "0x40218AD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _challengeViewShowAnim;

		// Token: 0x040218B9 RID: 137401
		[Token(Token = "0x40218B9")]
		[FieldOffset(Offset = "0xE8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040218BA RID: 137402
		[Token(Token = "0x40218BA")]
		[FieldOffset(Offset = "0xF8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040218BB RID: 137403
		[Token(Token = "0x40218BB")]
		[FieldOffset(Offset = "0x108")]
		private UITwoStepAnimation m_animPlayer;

		// Token: 0x040218BC RID: 137404
		[Token(Token = "0x40218BC")]
		[FieldOffset(Offset = "0x110")]
		private Coroutine m_showEffectCoroutine;

		// Token: 0x040218BD RID: 137405
		[Token(Token = "0x40218BD")]
		[FieldOffset(Offset = "0x118")]
		private TrackPointViewProperty m_trackPointArchive;

		// Token: 0x040218BE RID: 137406
		[Token(Token = "0x40218BE")]
		[FieldOffset(Offset = "0x120")]
		private bool m_hasInited;

		// Token: 0x040218BF RID: 137407
		[Token(Token = "0x40218BF")]
		[FieldOffset(Offset = "0x128")]
		private string m_topicId;

		// Token: 0x040218C0 RID: 137408
		[Token(Token = "0x40218C0")]
		[FieldOffset(Offset = "0x130")]
		private UISwitchTween m_challengeViewShowTween;

		// Token: 0x040218C1 RID: 137409
		[Token(Token = "0x40218C1")]
		[FieldOffset(Offset = "0x138")]
		private int m_cachedInitSeq;

		// Token: 0x040218C2 RID: 137410
		[Token(Token = "0x40218C2")]
		[FieldOffset(Offset = "0x140")]
		private SandboxV2HomeModel m_cachedViewModel;

		// Token: 0x040218C3 RID: 137411
		[Token(Token = "0x40218C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onEnterGameAction;

		// Token: 0x040218C4 RID: 137412
		[Token(Token = "0x40218C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onEnterGameAction;

		// Token: 0x040218C5 RID: 137413
		[Token(Token = "0x40218C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onEnterMonthAction;

		// Token: 0x040218C6 RID: 137414
		[Token(Token = "0x40218C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onEnterMonthAction;

		// Token: 0x040218C7 RID: 137415
		[Token(Token = "0x40218C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onEnterArchiveAction;

		// Token: 0x040218C8 RID: 137416
		[Token(Token = "0x40218C8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onEnterArchiveAction;

		// Token: 0x040218C9 RID: 137417
		[Token(Token = "0x40218C9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onEnterShopAction;

		// Token: 0x040218CA RID: 137418
		[Token(Token = "0x40218CA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onEnterShopAction;

		// Token: 0x040218CB RID: 137419
		[Token(Token = "0x40218CB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_onOpenMedalGroupAction;

		// Token: 0x040218CC RID: 137420
		[Token(Token = "0x40218CC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_onOpenMedalGroupAction;

		// Token: 0x040218CD RID: 137421
		[Token(Token = "0x40218CD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_onOpenGuideAction;

		// Token: 0x040218CE RID: 137422
		[Token(Token = "0x40218CE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_onOpenGuideAction;

		// Token: 0x040218CF RID: 137423
		[Token(Token = "0x40218CF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_onToggleChallengeAction;

		// Token: 0x040218D0 RID: 137424
		[Token(Token = "0x40218D0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_onToggleChallengeAction;

		// Token: 0x040218D1 RID: 137425
		[Token(Token = "0x40218D1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_onEnterChallengeAction;

		// Token: 0x040218D2 RID: 137426
		[Token(Token = "0x40218D2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_onEnterChallengeAction;

		// Token: 0x040218D3 RID: 137427
		[Token(Token = "0x40218D3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_onSettleChallengeAction;

		// Token: 0x040218D4 RID: 137428
		[Token(Token = "0x40218D4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_onSettleChallengeAction;

		// Token: 0x040218D5 RID: 137429
		[Token(Token = "0x40218D5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_onOpenChallengeRewardDialogAction;

		// Token: 0x040218D6 RID: 137430
		[Token(Token = "0x40218D6")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_onOpenChallengeRewardDialogAction;

		// Token: 0x040218D7 RID: 137431
		[Token(Token = "0x40218D7")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_onExploreModeClickAction;

		// Token: 0x040218D8 RID: 137432
		[Token(Token = "0x40218D8")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_onExploreModeClickAction;

		// Token: 0x040218D9 RID: 137433
		[Token(Token = "0x40218D9")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_needBindCanvas;

		// Token: 0x040218DA RID: 137434
		[Token(Token = "0x40218DA")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_needBindEffectHolders;

		// Token: 0x040218DB RID: 137435
		[Token(Token = "0x40218DB")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040218DC RID: 137436
		[Token(Token = "0x40218DC")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_StartShowEffect;

		// Token: 0x040218DD RID: 137437
		[Token(Token = "0x40218DD")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetDisplayTweenConfig;

		// Token: 0x040218DE RID: 137438
		[Token(Token = "0x40218DE")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_SetEffectEnable;

		// Token: 0x040218DF RID: 137439
		[Token(Token = "0x40218DF")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040218E0 RID: 137440
		[Token(Token = "0x40218E0")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ShowEffectCoroutine;

		// Token: 0x040218E1 RID: 137441
		[Token(Token = "0x40218E1")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__TryToTriggerAvg;

		// Token: 0x040218E2 RID: 137442
		[Token(Token = "0x40218E2")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_EventOnEnterGame;

		// Token: 0x040218E3 RID: 137443
		[Token(Token = "0x40218E3")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_EventOnEnterMonth;

		// Token: 0x040218E4 RID: 137444
		[Token(Token = "0x40218E4")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_EventOnEnterArchive;

		// Token: 0x040218E5 RID: 137445
		[Token(Token = "0x40218E5")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_EventOnEnterShop;

		// Token: 0x040218E6 RID: 137446
		[Token(Token = "0x40218E6")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_EventOnOpenMedalGroup;

		// Token: 0x040218E7 RID: 137447
		[Token(Token = "0x40218E7")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_EventOnOpenGuide;

		// Token: 0x040218E8 RID: 137448
		[Token(Token = "0x40218E8")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_EventOnOpenChallenge;

		// Token: 0x040218E9 RID: 137449
		[Token(Token = "0x40218E9")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_EventOnCloseChallenge;

		// Token: 0x040218EA RID: 137450
		[Token(Token = "0x40218EA")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_EventOnEnterChallenge;

		// Token: 0x040218EB RID: 137451
		[Token(Token = "0x40218EB")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_EventOnSettleChallenge;

		// Token: 0x040218EC RID: 137452
		[Token(Token = "0x40218EC")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_EventOnOpenChallengeRewardDialog;

		// Token: 0x040218ED RID: 137453
		[Token(Token = "0x40218ED")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_EventOnExploreModeClicked;

		// Token: 0x040218EE RID: 137454
		[Token(Token = "0x40218EE")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorial;

		// Token: 0x040218EF RID: 137455
		[Token(Token = "0x40218EF")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__TryRaiseAvgSignal;

		// Token: 0x040218F0 RID: 137456
		[Token(Token = "0x40218F0")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetChallengeModeEntryBtnGo;

		// Token: 0x040218F1 RID: 137457
		[Token(Token = "0x40218F1")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
