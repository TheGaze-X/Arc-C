using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200689D RID: 26781
	[Token(Token = "0x200689D")]
	public class StageZoneState : StageTabBaseState
	{
		// Token: 0x06026606 RID: 157190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026606")]
		[Address(RVA = "0x2171C70", Offset = "0x2170870", VA = "0x182171C70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x17005A8E RID: 23182
		// (get) Token: 0x06026607 RID: 157191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A8E")]
		public override IStateCacheHandler cacheHandler
		{
			[Token(Token = "0x6026607")]
			[Address(RVA = "0x2173610", Offset = "0x2172210", VA = "0x182173610", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026608 RID: 157192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026608")]
		[Address(RVA = "0x2172290", Offset = "0x2170E90", VA = "0x182172290", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06026609 RID: 157193 RVA: 0x000CAC08 File Offset: 0x000C8E08
		[Token(Token = "0x6026609")]
		[Address(RVA = "0x2172780", Offset = "0x2171380", VA = "0x182172780", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0602660A RID: 157194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602660A")]
		[Address(RVA = "0x2172130", Offset = "0x2170D30", VA = "0x182172130", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602660B RID: 157195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602660B")]
		[Address(RVA = "0x2171CD0", Offset = "0x21708D0", VA = "0x182171CD0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602660C RID: 157196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602660C")]
		[Address(RVA = "0x2172030", Offset = "0x2170C30", VA = "0x182172030", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602660D RID: 157197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602660D")]
		[Address(RVA = "0x2171DC0", Offset = "0x21709C0", VA = "0x182171DC0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602660E RID: 157198 RVA: 0x000CAC20 File Offset: 0x000C8E20
		[Token(Token = "0x602660E")]
		[Address(RVA = "0x21729D0", Offset = "0x21715D0", VA = "0x1821729D0")]
		private long _GetBGMInstId()
		{
			return 0L;
		}

		// Token: 0x0602660F RID: 157199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602660F")]
		[Address(RVA = "0x2172D30", Offset = "0x2171930", VA = "0x182172D30")]
		private void _RefreshBGM()
		{
		}

		// Token: 0x06026610 RID: 157200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026610")]
		[Address(RVA = "0x21727F0", Offset = "0x21713F0", VA = "0x1821727F0")]
		private void _ClearBGM()
		{
		}

		// Token: 0x06026611 RID: 157201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026611")]
		[Address(RVA = "0x2172870", Offset = "0x2171470", VA = "0x182172870")]
		private string _FindMusicId()
		{
			return null;
		}

		// Token: 0x06026612 RID: 157202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026612")]
		[Address(RVA = "0x2171AC0", Offset = "0x21706C0", VA = "0x182171AC0")]
		public void EventOnSwitchMainline(string zoneId)
		{
		}

		// Token: 0x06026613 RID: 157203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026613")]
		[Address(RVA = "0x2171820", Offset = "0x2170420", VA = "0x182171820")]
		public void EventOnOpenDetailInfo()
		{
		}

		// Token: 0x06026614 RID: 157204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026614")]
		[Address(RVA = "0x2171900", Offset = "0x2170500", VA = "0x182171900")]
		public void EventOnPlayRecap()
		{
		}

		// Token: 0x06026615 RID: 157205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026615")]
		[Address(RVA = "0x2171EC0", Offset = "0x2170AC0", VA = "0x182171EC0", Slot = "24")]
		public override void OnMapLoadError(string zoneId)
		{
		}

		// Token: 0x06026616 RID: 157206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026616")]
		[Address(RVA = "0x2171F70", Offset = "0x2170B70", VA = "0x182171F70", Slot = "23")]
		public override void OnMapLoadFinish(string zoneId)
		{
		}

		// Token: 0x06026617 RID: 157207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026617")]
		[Address(RVA = "0x21732D0", Offset = "0x2171ED0", VA = "0x1821732D0")]
		private void _TryShowStoryReadTipsDialog()
		{
		}

		// Token: 0x06026618 RID: 157208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026618")]
		[Address(RVA = "0x2172A30", Offset = "0x2171630", VA = "0x182172A30")]
		private StoryReadTipsData _GetStoryReadTipsInfo()
		{
			return null;
		}

		// Token: 0x06026619 RID: 157209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026619")]
		[Address(RVA = "0x2172CD0", Offset = "0x21718D0", VA = "0x182172CD0")]
		private void _OnSwitchSelectStateEnd()
		{
		}

		// Token: 0x0602661A RID: 157210 RVA: 0x000CAC38 File Offset: 0x000C8E38
		[Token(Token = "0x602661A")]
		[Address(RVA = "0x2172F20", Offset = "0x2171B20", VA = "0x182172F20")]
		private StageZoneState.StateRuntime _SaveToRuntime()
		{
			return default(StageZoneState.StateRuntime);
		}

		// Token: 0x0602661B RID: 157211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602661B")]
		[Address(RVA = "0x2172AE0", Offset = "0x21716E0", VA = "0x182172AE0")]
		private void _LoadFromRuntime(StageZoneState.StateRuntime runtime)
		{
		}

		// Token: 0x0602661C RID: 157212 RVA: 0x000CAC50 File Offset: 0x000C8E50
		[Token(Token = "0x602661C")]
		[Address(RVA = "0x21724A0", Offset = "0x21710A0", VA = "0x1821724A0")]
		public bool SwitchToZone(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x0602661D RID: 157213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602661D")]
		[Address(RVA = "0x21723F0", Offset = "0x2170FF0", VA = "0x1821723F0")]
		public void SwitchToDiff(StageDiffGroup diffGroup)
		{
		}

		// Token: 0x0602661E RID: 157214 RVA: 0x000CAC68 File Offset: 0x000C8E68
		[Token(Token = "0x602661E")]
		[Address(RVA = "0x2172B80", Offset = "0x2171780", VA = "0x182172B80")]
		private bool _LockSwitchZone()
		{
			return default(bool);
		}

		// Token: 0x0602661F RID: 157215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602661F")]
		[Address(RVA = "0x2173550", Offset = "0x2172150", VA = "0x182173550")]
		private void _UnlockSwitchZone()
		{
		}

		// Token: 0x06026620 RID: 157216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026620")]
		[Address(RVA = "0x2173020", Offset = "0x2171C20", VA = "0x182173020")]
		private IEnumerator _SwitchSelectStateCoroutine(string targetZoneId, StageDiffGroup targetDiff = StageDiffGroup.NONE)
		{
			return null;
		}

		// Token: 0x06026621 RID: 157217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026621")]
		[Address(RVA = "0x2172BF0", Offset = "0x21717F0", VA = "0x182172BF0")]
		private void _NotifyZoneLoadedForGuideBook(string zoneId)
		{
		}

		// Token: 0x06026622 RID: 157218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026622")]
		[Address(RVA = "0x2173110", Offset = "0x2171D10", VA = "0x182173110")]
		private void _TriggerRecap(string zoneId)
		{
		}

		// Token: 0x06026623 RID: 157219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026623")]
		[Address(RVA = "0x21735B0", Offset = "0x21721B0", VA = "0x1821735B0")]
		public StageZoneState()
		{
		}

		// Token: 0x06026627 RID: 157223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026627")]
		[Address(RVA = "0x12DC030", Offset = "0x12DAC30", VA = "0x1812DC030")]
		private IStateCacheHandler <>xLuaBaseProxy_get_cacheHandler()
		{
			return null;
		}

		// Token: 0x06026628 RID: 157224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026628")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06026629 RID: 157225 RVA: 0x000CAC80 File Offset: 0x000C8E80
		[Token(Token = "0x6026629")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0602662A RID: 157226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602662A")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602662B RID: 157227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602662B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602662C RID: 157228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602662C")]
		[Address(RVA = "0x216B190", Offset = "0x2169D90", VA = "0x18216B190")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602662D RID: 157229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602662D")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0602662E RID: 157230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602662E")]
		[Address(RVA = "0x216EB00", Offset = "0x216D700", VA = "0x18216EB00")]
		private void <>xLuaBaseProxy_OnMapLoadError(string P0)
		{
		}

		// Token: 0x0602662F RID: 157231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602662F")]
		[Address(RVA = "0x216EB60", Offset = "0x216D760", VA = "0x18216EB60")]
		private void <>xLuaBaseProxy_OnMapLoadFinish(string P0)
		{
		}

		// Token: 0x040360B7 RID: 221367
		[Token(Token = "0x40360B7")]
		private const float SWITCH_ZONE_TIME_OUT = 3f;

		// Token: 0x040360B8 RID: 221368
		[Token(Token = "0x40360B8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private StageStateBean _stateBean;

		// Token: 0x040360B9 RID: 221369
		[Token(Token = "0x40360B9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StageZoneMapContainer _zoneMapContainer;

		// Token: 0x040360BA RID: 221370
		[Token(Token = "0x40360BA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private StageMainZoneMapContainer _mainZoneMapContainer;

		// Token: 0x040360BB RID: 221371
		[Token(Token = "0x40360BB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _switchZoneOut;

		// Token: 0x040360BC RID: 221372
		[Token(Token = "0x40360BC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _switchZoneIn;

		// Token: 0x040360BD RID: 221373
		[Token(Token = "0x40360BD")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _switchAnimTarget;

		// Token: 0x040360BE RID: 221374
		[Token(Token = "0x40360BE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Guide Book")]
		private GameObject _guideBookMainline;

		// Token: 0x040360BF RID: 221375
		[Token(Token = "0x40360BF")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Guide Book")]
		private GameObject _guideBookCampaign;

		// Token: 0x040360C0 RID: 221376
		[Token(Token = "0x40360C0")]
		[FieldOffset(Offset = "0xA8")]
		private StateCacheHandler<StageZoneState.StateRuntime> m_runtimeHandler;

		// Token: 0x040360C1 RID: 221377
		[Token(Token = "0x40360C1")]
		[FieldOffset(Offset = "0xB0")]
		private StagePageGameMusicController m_musicController;

		// Token: 0x040360C2 RID: 221378
		[Token(Token = "0x40360C2")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_mapLoadedCache;

		// Token: 0x040360C3 RID: 221379
		[Token(Token = "0x40360C3")]
		[FieldOffset(Offset = "0xB9")]
		private bool m_switchZoneLock;

		// Token: 0x040360C4 RID: 221380
		[Token(Token = "0x40360C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040360C5 RID: 221381
		[Token(Token = "0x40360C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cacheHandler;

		// Token: 0x040360C6 RID: 221382
		[Token(Token = "0x40360C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x040360C7 RID: 221383
		[Token(Token = "0x40360C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x040360C8 RID: 221384
		[Token(Token = "0x40360C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x040360C9 RID: 221385
		[Token(Token = "0x40360C9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040360CA RID: 221386
		[Token(Token = "0x40360CA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040360CB RID: 221387
		[Token(Token = "0x40360CB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040360CC RID: 221388
		[Token(Token = "0x40360CC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetBGMInstId;

		// Token: 0x040360CD RID: 221389
		[Token(Token = "0x40360CD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RefreshBGM;

		// Token: 0x040360CE RID: 221390
		[Token(Token = "0x40360CE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ClearBGM;

		// Token: 0x040360CF RID: 221391
		[Token(Token = "0x40360CF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__FindMusicId;

		// Token: 0x040360D0 RID: 221392
		[Token(Token = "0x40360D0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnSwitchMainline;

		// Token: 0x040360D1 RID: 221393
		[Token(Token = "0x40360D1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnOpenDetailInfo;

		// Token: 0x040360D2 RID: 221394
		[Token(Token = "0x40360D2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnPlayRecap;

		// Token: 0x040360D3 RID: 221395
		[Token(Token = "0x40360D3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnMapLoadError;

		// Token: 0x040360D4 RID: 221396
		[Token(Token = "0x40360D4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnMapLoadFinish;

		// Token: 0x040360D5 RID: 221397
		[Token(Token = "0x40360D5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TryShowStoryReadTipsDialog;

		// Token: 0x040360D6 RID: 221398
		[Token(Token = "0x40360D6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetStoryReadTipsInfo;

		// Token: 0x040360D7 RID: 221399
		[Token(Token = "0x40360D7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnSwitchSelectStateEnd;

		// Token: 0x040360D8 RID: 221400
		[Token(Token = "0x40360D8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SaveToRuntime;

		// Token: 0x040360D9 RID: 221401
		[Token(Token = "0x40360D9")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__LoadFromRuntime;

		// Token: 0x040360DA RID: 221402
		[Token(Token = "0x40360DA")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_SwitchToZone;

		// Token: 0x040360DB RID: 221403
		[Token(Token = "0x40360DB")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SwitchToDiff;

		// Token: 0x040360DC RID: 221404
		[Token(Token = "0x40360DC")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__LockSwitchZone;

		// Token: 0x040360DD RID: 221405
		[Token(Token = "0x40360DD")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__UnlockSwitchZone;

		// Token: 0x040360DE RID: 221406
		[Token(Token = "0x40360DE")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__SwitchSelectStateCoroutine;

		// Token: 0x040360DF RID: 221407
		[Token(Token = "0x40360DF")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__NotifyZoneLoadedForGuideBook;

		// Token: 0x040360E0 RID: 221408
		[Token(Token = "0x40360E0")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__TriggerRecap;

		// Token: 0x040360E1 RID: 221409
		[Token(Token = "0x40360E1")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200689E RID: 26782
		[Token(Token = "0x200689E")]
		public struct StateRuntime
		{
			// Token: 0x040360E2 RID: 221410
			[Token(Token = "0x40360E2")]
			[FieldOffset(Offset = "0x0")]
			public string selectedZoneId;

			// Token: 0x040360E3 RID: 221411
			[Token(Token = "0x40360E3")]
			[FieldOffset(Offset = "0x8")]
			public StageDiffGroup diffGroup;
		}
	}
}
