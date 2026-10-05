using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EC9 RID: 7881
	[Token(Token = "0x2001EC9")]
	public class CommonExecutors : AVGComponent, IHotfixable, IFadeTimeRatio, IContainsResRefs
	{
		// Token: 0x0600C348 RID: 49992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C348")]
		[Address(RVA = "0x340AAF0", Offset = "0x34096F0", VA = "0x18340AAF0", Slot = "4")]
		public override IList<ICommandExecutor> GetCommandExecutors()
		{
			return null;
		}

		// Token: 0x0600C349 RID: 49993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C349")]
		[Address(RVA = "0x340B650", Offset = "0x340A250", VA = "0x18340B650", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C34A RID: 49994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C34A")]
		[Address(RVA = "0x340B6D0", Offset = "0x340A2D0", VA = "0x18340B6D0", Slot = "6")]
		public override void OnStoryEnd(Story story)
		{
		}

		// Token: 0x0600C34B RID: 49995 RVA: 0x00047B50 File Offset: 0x00045D50
		[Token(Token = "0x600C34B")]
		[Address(RVA = "0x340A9C0", Offset = "0x34095C0", VA = "0x18340A9C0", Slot = "8")]
		public float CalculateFadetime(float initialFadetime)
		{
			return 0f;
		}

		// Token: 0x0600C34C RID: 49996 RVA: 0x00047B68 File Offset: 0x00045D68
		[Token(Token = "0x600C34C")]
		[Address(RVA = "0x340B5B0", Offset = "0x340A1B0", VA = "0x18340B5B0", Slot = "9")]
		public bool NeedSkipAnimation(float fadetime)
		{
			return default(bool);
		}

		// Token: 0x0600C34D RID: 49997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C34D")]
		[Address(RVA = "0x340D550", Offset = "0x340C150", VA = "0x18340D550")]
		private string _GenAVGSoundChannelName(string rawChannel)
		{
			return null;
		}

		// Token: 0x0600C34E RID: 49998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C34E")]
		[Address(RVA = "0x340BBC0", Offset = "0x340A7C0", VA = "0x18340BBC0")]
		private void _ExecuteDelayCommand(Command command, Action finishCb)
		{
		}

		// Token: 0x0600C34F RID: 49999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C34F")]
		[Address(RVA = "0x340D4C0", Offset = "0x340C0C0", VA = "0x18340D4C0")]
		private void _ForceEndDelayCommand()
		{
		}

		// Token: 0x0600C350 RID: 50000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C350")]
		[Address(RVA = "0x340B770", Offset = "0x340A370", VA = "0x18340B770")]
		private void _ExecuteClickCommand(Command command, Action finishCb)
		{
		}

		// Token: 0x0600C351 RID: 50001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C351")]
		[Address(RVA = "0x340D3E0", Offset = "0x340BFE0", VA = "0x18340D3E0")]
		private void _ForceEndClickCommand()
		{
		}

		// Token: 0x0600C352 RID: 50002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C352")]
		[Address(RVA = "0x340DBD0", Offset = "0x340C7D0", VA = "0x18340DBD0")]
		private void _ResetAudio()
		{
		}

		// Token: 0x0600C353 RID: 50003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C353")]
		[Address(RVA = "0x340C7D0", Offset = "0x340B3D0", VA = "0x18340C7D0")]
		private void _ExecutePlaySoundCommand(Command command, Action finishCb)
		{
		}

		// Token: 0x0600C354 RID: 50004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C354")]
		[Address(RVA = "0x340D0D0", Offset = "0x340BCD0", VA = "0x18340D0D0")]
		private void _ExecuteStopSoundCommand(Command command, Action finishCb)
		{
		}

		// Token: 0x0600C355 RID: 50005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C355")]
		[Address(RVA = "0x340CAF0", Offset = "0x340B6F0", VA = "0x18340CAF0")]
		private void _ExecuteSoundVolumeCommand(Command command, Action finishCb)
		{
		}

		// Token: 0x0600C356 RID: 50006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C356")]
		[Address(RVA = "0x340C520", Offset = "0x340B120", VA = "0x18340C520")]
		private void _ExecutePlayMusicCommand(Command command, Action finishCb)
		{
		}

		// Token: 0x0600C357 RID: 50007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C357")]
		[Address(RVA = "0x340D000", Offset = "0x340BC00", VA = "0x18340D000")]
		private void _ExecuteStopMusicCommand(Command command, Action finishCb)
		{
		}

		// Token: 0x0600C358 RID: 50008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C358")]
		[Address(RVA = "0x340C3E0", Offset = "0x340AFE0", VA = "0x18340C3E0")]
		private void _ExecuteMusicVolumeCommand(Command command, Action finishCb)
		{
		}

		// Token: 0x0600C359 RID: 50009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C359")]
		[Address(RVA = "0x340B900", Offset = "0x340A500", VA = "0x18340B900")]
		private void _ExecuteConsumeGuideOnStoryEndCommand(Command command, Action finishCb)
		{
		}

		// Token: 0x0600C35A RID: 50010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C35A")]
		[Address(RVA = "0x340D2F0", Offset = "0x340BEF0", VA = "0x18340D2F0")]
		private static string _ExtractStrFromCommand(Command command, string paramName)
		{
			return null;
		}

		// Token: 0x0600C35B RID: 50011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C35B")]
		[Address(RVA = "0x340C050", Offset = "0x340AC50", VA = "0x18340C050")]
		private void _ExecuteGotoPageCommand(Command command, Action finishCb)
		{
		}

		// Token: 0x0600C35C RID: 50012 RVA: 0x00047B80 File Offset: 0x00045D80
		[Token(Token = "0x600C35C")]
		[Address(RVA = "0x340DD40", Offset = "0x340C940", VA = "0x18340DD40")]
		private bool _RouteToTarget(UIRouteTarget routeTarget, Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C35D RID: 50013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C35D")]
		[Address(RVA = "0x340E060", Offset = "0x340CC60", VA = "0x18340E060")]
		private void _SignalGotoPageReceiver(Command command)
		{
		}

		// Token: 0x0600C35E RID: 50014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C35E")]
		[Address(RVA = "0x340CC70", Offset = "0x340B870", VA = "0x18340CC70")]
		private void _ExecuteStartBattleCommand(Command command, Action finishCb)
		{
		}

		// Token: 0x0600C35F RID: 50015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C35F")]
		[Address(RVA = "0x340D5E0", Offset = "0x340C1E0", VA = "0x18340D5E0")]
		private void _InvokeStartBattle(string stageId, bool isPractice, Action onProceed, Action onBlock)
		{
		}

		// Token: 0x0600C360 RID: 50016 RVA: 0x00047B98 File Offset: 0x00045D98
		[Token(Token = "0x600C360")]
		[Address(RVA = "0x340E170", Offset = "0x340CD70", VA = "0x18340E170")]
		private bool _TryGetRouteTargetFromGotoDest(AVGGotoPageDest destPage, out UIRouteTarget target)
		{
			return default(bool);
		}

		// Token: 0x0600C361 RID: 50017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C361")]
		[Address(RVA = "0x340BD90", Offset = "0x340A990", VA = "0x18340BD90")]
		private void _ExecuteGotoCharInfoCommand(Command command, Action finishCb)
		{
		}

		// Token: 0x0600C362 RID: 50018 RVA: 0x00047BB0 File Offset: 0x00045DB0
		[Token(Token = "0x600C362")]
		[Address(RVA = "0x340D8A0", Offset = "0x340C4A0", VA = "0x18340D8A0")]
		private static UIPageStackParam _PageStackParamToCharInfo(object charArgs)
		{
			return default(UIPageStackParam);
		}

		// Token: 0x0600C363 RID: 50019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C363")]
		[Address(RVA = "0x340DF50", Offset = "0x340CB50", VA = "0x18340DF50")]
		private void _SignalGotoCharInfoReceiver(Command command)
		{
		}

		// Token: 0x0600C364 RID: 50020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C364")]
		[Address(RVA = "0x340AA60", Offset = "0x3409660", VA = "0x18340AA60", Slot = "11")]
		public virtual AbstractResRefCollecter DontInvoke_PlzImplInternalResRefCollector()
		{
			return null;
		}

		// Token: 0x0600C365 RID: 50021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C365")]
		[Address(RVA = "0x340E3B0", Offset = "0x340CFB0", VA = "0x18340E3B0")]
		public CommonExecutors()
		{
		}

		// Token: 0x0600C366 RID: 50022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C366")]
		[Address(RVA = "0x33E99E0", Offset = "0x33E85E0", VA = "0x1833E99E0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600C367 RID: 50023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C367")]
		[Address(RVA = "0x33F0E80", Offset = "0x33EFA80", VA = "0x1833F0E80")]
		private void <>xLuaBaseProxy_OnStoryEnd(Story P0)
		{
		}

		// Token: 0x0400C578 RID: 50552
		[Token(Token = "0x400C578")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _clickAutoDelay;

		// Token: 0x0400C579 RID: 50553
		[Token(Token = "0x400C579")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _soundDefaultFadeTime;

		// Token: 0x0400C57A RID: 50554
		[Token(Token = "0x400C57A")]
		private const string AVG_SOUND_CHANNEL_FORMAT = "avgsound_{0}";

		// Token: 0x0400C57B RID: 50555
		[Token(Token = "0x400C57B")]
		[FieldOffset(Offset = "0x30")]
		private Action m_onStoryEnd;

		// Token: 0x0400C57C RID: 50556
		[Token(Token = "0x400C57C")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<string> m_allSoundChannels;

		// Token: 0x0400C57D RID: 50557
		[Token(Token = "0x400C57D")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine m_delayCoroutine;

		// Token: 0x0400C57E RID: 50558
		[Token(Token = "0x400C57E")]
		[FieldOffset(Offset = "0x48")]
		private EventPool.EventCallbackDelegate m_onClickCallback;

		// Token: 0x0400C57F RID: 50559
		[Token(Token = "0x400C57F")]
		[FieldOffset(Offset = "0x50")]
		private Action m_gotoFinishCb;

		// Token: 0x0400C580 RID: 50560
		[Token(Token = "0x400C580")]
		[FieldOffset(Offset = "0x58")]
		private string m_gotoWaitForSignal;

		// Token: 0x0400C581 RID: 50561
		[Token(Token = "0x400C581")]
		[FieldOffset(Offset = "0x60")]
		private Action m_gotoCharInfoFinishCb;

		// Token: 0x0400C582 RID: 50562
		[Token(Token = "0x400C582")]
		[FieldOffset(Offset = "0x68")]
		private string m_gotoCharInfoWaitForSignal;

		// Token: 0x0400C583 RID: 50563
		[Token(Token = "0x400C583")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCommandExecutors;

		// Token: 0x0400C584 RID: 50564
		[Token(Token = "0x400C584")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C585 RID: 50565
		[Token(Token = "0x400C585")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStoryEnd;

		// Token: 0x0400C586 RID: 50566
		[Token(Token = "0x400C586")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CalculateFadetime;

		// Token: 0x0400C587 RID: 50567
		[Token(Token = "0x400C587")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NeedSkipAnimation;

		// Token: 0x0400C588 RID: 50568
		[Token(Token = "0x400C588")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenAVGSoundChannelName;

		// Token: 0x0400C589 RID: 50569
		[Token(Token = "0x400C589")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ExecuteDelayCommand;

		// Token: 0x0400C58A RID: 50570
		[Token(Token = "0x400C58A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ForceEndDelayCommand;

		// Token: 0x0400C58B RID: 50571
		[Token(Token = "0x400C58B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ExecuteClickCommand;

		// Token: 0x0400C58C RID: 50572
		[Token(Token = "0x400C58C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ForceEndClickCommand;

		// Token: 0x0400C58D RID: 50573
		[Token(Token = "0x400C58D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResetAudio;

		// Token: 0x0400C58E RID: 50574
		[Token(Token = "0x400C58E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ExecutePlaySoundCommand;

		// Token: 0x0400C58F RID: 50575
		[Token(Token = "0x400C58F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ExecuteStopSoundCommand;

		// Token: 0x0400C590 RID: 50576
		[Token(Token = "0x400C590")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ExecuteSoundVolumeCommand;

		// Token: 0x0400C591 RID: 50577
		[Token(Token = "0x400C591")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ExecutePlayMusicCommand;

		// Token: 0x0400C592 RID: 50578
		[Token(Token = "0x400C592")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ExecuteStopMusicCommand;

		// Token: 0x0400C593 RID: 50579
		[Token(Token = "0x400C593")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ExecuteMusicVolumeCommand;

		// Token: 0x0400C594 RID: 50580
		[Token(Token = "0x400C594")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ExecuteConsumeGuideOnStoryEndCommand;

		// Token: 0x0400C595 RID: 50581
		[Token(Token = "0x400C595")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ExtractStrFromCommand;

		// Token: 0x0400C596 RID: 50582
		[Token(Token = "0x400C596")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ExecuteGotoPageCommand;

		// Token: 0x0400C597 RID: 50583
		[Token(Token = "0x400C597")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__RouteToTarget;

		// Token: 0x0400C598 RID: 50584
		[Token(Token = "0x400C598")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SignalGotoPageReceiver;

		// Token: 0x0400C599 RID: 50585
		[Token(Token = "0x400C599")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ExecuteStartBattleCommand;

		// Token: 0x0400C59A RID: 50586
		[Token(Token = "0x400C59A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__InvokeStartBattle;

		// Token: 0x0400C59B RID: 50587
		[Token(Token = "0x400C59B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__TryGetRouteTargetFromGotoDest;

		// Token: 0x0400C59C RID: 50588
		[Token(Token = "0x400C59C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ExecuteGotoCharInfoCommand;

		// Token: 0x0400C59D RID: 50589
		[Token(Token = "0x400C59D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__PageStackParamToCharInfo;

		// Token: 0x0400C59E RID: 50590
		[Token(Token = "0x400C59E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__SignalGotoCharInfoReceiver;

		// Token: 0x0400C59F RID: 50591
		[Token(Token = "0x400C59F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_DontInvoke_PlzImplInternalResRefCollector;

		// Token: 0x0400C5A0 RID: 50592
		[Token(Token = "0x400C5A0")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001ECA RID: 7882
		[Token(Token = "0x2001ECA")]
		public class InternalSoundRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600C368 RID: 50024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C368")]
			[Address(RVA = "0x34136A0", Offset = "0x34122A0", VA = "0x1834136A0", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x17001760 RID: 5984
			// (get) Token: 0x0600C369 RID: 50025 RVA: 0x00047BC8 File Offset: 0x00045DC8
			[Token(Token = "0x17001760")]
			public override bool useForResBan
			{
				[Token(Token = "0x600C369")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600C36A RID: 50026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C36A")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public InternalSoundRefCollector()
			{
			}
		}

		// Token: 0x02001ECB RID: 7883
		[Token(Token = "0x2001ECB")]
		public class InternalMusicRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600C36B RID: 50027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C36B")]
			[Address(RVA = "0x3412F90", Offset = "0x3411B90", VA = "0x183412F90", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x17001761 RID: 5985
			// (get) Token: 0x0600C36C RID: 50028 RVA: 0x00047BE0 File Offset: 0x00045DE0
			[Token(Token = "0x17001761")]
			public override bool useForResBan
			{
				[Token(Token = "0x600C36C")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600C36D RID: 50029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C36D")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public InternalMusicRefCollector()
			{
			}
		}
	}
}
