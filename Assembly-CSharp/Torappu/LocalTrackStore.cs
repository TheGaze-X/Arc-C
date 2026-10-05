using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Torappu.LocalTrack;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x0200050E RID: 1294
	[Token(Token = "0x200050E")]
	public class LocalTrackStore : Singleton<LocalTrackStore>, IDisposable
	{
		// Token: 0x06004EF9 RID: 20217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF9")]
		[Address(RVA = "0x188B490", Offset = "0x188A090", VA = "0x18188B490")]
		public void NotifyPlayerDataChanged(PlayerDataDelta delta, PlayerDataModel prevData, PlayerDataModel curData)
		{
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EFA")]
		[Address(RVA = "0x188B210", Offset = "0x1889E10", VA = "0x18188B210")]
		public static void NotifyEnteringMainGame()
		{
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EFB")]
		[Address(RVA = "0x188B000", Offset = "0x1889C00", VA = "0x18188B000")]
		public static void NotifyCrossDay()
		{
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x0002E278 File Offset: 0x0002C478
		[Token(Token = "0x6004EFC")]
		[Address(RVA = "0x188ACD0", Offset = "0x18898D0", VA = "0x18188ACD0")]
		public bool DoTrackTrigger(string type, string id)
		{
			return default(bool);
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x0002E290 File Offset: 0x0002C490
		[Token(Token = "0x6004EFD")]
		[Address(RVA = "0x188A6A0", Offset = "0x18892A0", VA = "0x18188A6A0")]
		public bool ConsumeTrack(string type, string id)
		{
			return default(bool);
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x0002E2A8 File Offset: 0x0002C4A8
		[Token(Token = "0x6004EFE")]
		[Address(RVA = "0x188A440", Offset = "0x1889040", VA = "0x18188A440")]
		public bool CheckTrack(string type, string id)
		{
			return default(bool);
		}

		// Token: 0x06004EFF RID: 20223 RVA: 0x0002E2C0 File Offset: 0x0002C4C0
		[Token(Token = "0x6004EFF")]
		[Address(RVA = "0x188A980", Offset = "0x1889580", VA = "0x18188A980")]
		public bool ConsumeTracksByType(string type)
		{
			return default(bool);
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x0002E2D8 File Offset: 0x0002C4D8
		[Token(Token = "0x6004F00")]
		[Address(RVA = "0x188A580", Offset = "0x1889180", VA = "0x18188A580")]
		public bool CheckTracksByType(string type)
		{
			return default(bool);
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F01")]
		[Address(RVA = "0x188AF30", Offset = "0x1889B30", VA = "0x18188AF30")]
		public IEnumerator<string> GetTracksByType(string type)
		{
			return null;
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F02")]
		[Address(RVA = "0x188B6C0", Offset = "0x188A2C0", VA = "0x18188B6C0")]
		public void RemoveTrackVer(string type)
		{
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F03")]
		[Address(RVA = "0x188AB80", Offset = "0x1889780", VA = "0x18188AB80", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06004F04 RID: 20228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F04")]
		[Address(RVA = "0x188C3D0", Offset = "0x188AFD0", VA = "0x18188C3D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x0002E2F0 File Offset: 0x0002C4F0
		[Token(Token = "0x6004F05")]
		[Address(RVA = "0x188BD60", Offset = "0x188A960", VA = "0x18188BD60")]
		private bool _DoTrackTrigger(TrackTrigger trigger)
		{
			return default(bool);
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x0002E308 File Offset: 0x0002C508
		[Token(Token = "0x6004F06")]
		[Address(RVA = "0x188C320", Offset = "0x188AF20", VA = "0x18188C320")]
		private long _GetTrackTypeVersion(string type)
		{
			return 0L;
		}

		// Token: 0x06004F07 RID: 20231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F07")]
		[Address(RVA = "0x188CE00", Offset = "0x188BA00", VA = "0x18188CE00")]
		private void _NotifyEnteringMainGame()
		{
		}

		// Token: 0x06004F08 RID: 20232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F08")]
		[Address(RVA = "0x188CC50", Offset = "0x188B850", VA = "0x18188CC50")]
		private void _NotifyCrossDay()
		{
		}

		// Token: 0x06004F09 RID: 20233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F09")]
		[Address(RVA = "0x188B820", Offset = "0x188A420", VA = "0x18188B820")]
		private void _AddTrigger(TrackTrigger trigger)
		{
		}

		// Token: 0x06004F0A RID: 20234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F0A")]
		[Address(RVA = "0x188B990", Offset = "0x188A590", VA = "0x18188B990")]
		private static void _BeforeSceneLoadingStart(string fromScene, string toScene)
		{
		}

		// Token: 0x06004F0B RID: 20235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F0B")]
		[Address(RVA = "0x188C7A0", Offset = "0x188B3A0", VA = "0x18188C7A0")]
		private static IDisposable _LockStoreDataWrite()
		{
			return null;
		}

		// Token: 0x06004F0C RID: 20236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F0C")]
		[Address(RVA = "0x188C1D0", Offset = "0x188ADD0", VA = "0x18188C1D0")]
		private LocalTrackStore.Data _GetStoreData()
		{
			return null;
		}

		// Token: 0x06004F0D RID: 20237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F0D")]
		[Address(RVA = "0x188D050", Offset = "0x188BC50", VA = "0x18188D050")]
		private void _SaveStoreDataImmediately()
		{
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F0E")]
		[Address(RVA = "0x188D160", Offset = "0x188BD60", VA = "0x18188D160")]
		private void _SaveStoreDataWithDelay()
		{
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F0F")]
		[Address(RVA = "0x188CFA0", Offset = "0x188BBA0", VA = "0x18188CFA0")]
		private IEnumerator _SaveStoreCoroutine()
		{
			return null;
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F10")]
		[Address(RVA = "0x188BC40", Offset = "0x188A840", VA = "0x18188BC40")]
		private void _CancelSaveStoreRequest()
		{
		}

		// Token: 0x06004F11 RID: 20241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F11")]
		[Address(RVA = "0x188D740", Offset = "0x188C340", VA = "0x18188D740")]
		private LocalTrackStore()
		{
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F12")]
		[Address(RVA = "0x188A380", Offset = "0x1888F80", VA = "0x18188A380")]
		public void BindLocalTrackPoint(LocalTrackStore.TrackPointBinderKey binderKey, LocalTrackStore.IBindLocalTrackStore binder)
		{
		}

		// Token: 0x06004F13 RID: 20243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F13")]
		[Address(RVA = "0x188B790", Offset = "0x188A390", VA = "0x18188B790")]
		public void UnBindLocalTrackPoint(LocalTrackStore.IBindLocalTrackStore trackPoint)
		{
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x0002E320 File Offset: 0x0002C520
		[Token(Token = "0x6004F14")]
		[Address(RVA = "0x188CAF0", Offset = "0x188B6F0", VA = "0x18188CAF0")]
		private bool _MatchPrefixCondition(string trackId, string conditionPattern, bool exclude)
		{
			return default(bool);
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x0002E338 File Offset: 0x0002C538
		[Token(Token = "0x6004F15")]
		[Address(RVA = "0x188CBA0", Offset = "0x188B7A0", VA = "0x18188CBA0")]
		private bool _MatchSuffixCondition(string trackId, string conditionPattern, bool exclude)
		{
			return default(bool);
		}

		// Token: 0x06004F16 RID: 20246 RVA: 0x0002E350 File Offset: 0x0002C550
		[Token(Token = "0x6004F16")]
		[Address(RVA = "0x188C8D0", Offset = "0x188B4D0", VA = "0x18188C8D0")]
		private bool _MatchByTypeRule(string rulePattern, List<LocalTrackStore.MatchCondition> conditions)
		{
			return default(bool);
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F17")]
		[Address(RVA = "0x188BE10", Offset = "0x188AA10", VA = "0x18188BE10")]
		private LocalTrackStore.MatchConditionDelegate _GetConditionDelegate(LocalTrackStore.MatchConditionType conditionType)
		{
			return null;
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F18")]
		[Address(RVA = "0x188BFB0", Offset = "0x188ABB0", VA = "0x18188BFB0")]
		private LocalTrackStore.MatchRuleDelegate _GetRuleDelegate(LocalTrackStore.MatchRuleType ruleType)
		{
			return null;
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F19")]
		[Address(RVA = "0x188D4E0", Offset = "0x188C0E0", VA = "0x18188D4E0")]
		private void _TryMatch(HashSet<string> tracks, List<LocalTrackStore.MatchCondition> conditions, List<string> matchedRes)
		{
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x0002E368 File Offset: 0x0002C568
		[Token(Token = "0x6004F1A")]
		[Address(RVA = "0x188A890", Offset = "0x1889490", VA = "0x18188A890")]
		public bool ConsumeTracksByMatchRule(LocalTrackStore.MatchRule rule)
		{
			return default(bool);
		}

		// Token: 0x0400136A RID: 4970
		[Token(Token = "0x400136A")]
		private const int SAVE_DELAY_FRAMES = 1;

		// Token: 0x0400136B RID: 4971
		[Token(Token = "0x400136B")]
		private const long SAVE_TIMEOUT_TICKS = 10000000L;

		// Token: 0x0400136C RID: 4972
		[Token(Token = "0x400136C")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<ITrackTriggerHolder> TRIGGER_HOLDERS;

		// Token: 0x0400136D RID: 4973
		[Token(Token = "0x400136D")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Type, ITrackTriggerHolder> m_triggerToHolder;

		// Token: 0x0400136E RID: 4974
		[Token(Token = "0x400136E")]
		[FieldOffset(Offset = "0x20")]
		private List<IPlayerTrackTriggerHolder> m_playerTrackHolders;

		// Token: 0x0400136F RID: 4975
		[Token(Token = "0x400136F")]
		[FieldOffset(Offset = "0x28")]
		private List<IVersionTrackTriggerHolder> m_versionTrackHolders;

		// Token: 0x04001370 RID: 4976
		[Token(Token = "0x4001370")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04001371 RID: 4977
		[Token(Token = "0x4001371")]
		[FieldOffset(Offset = "0x38")]
		private LocalTrackStore.TrackObserverCenter m_observerCenter;

		// Token: 0x04001372 RID: 4978
		[Token(Token = "0x4001372")]
		[FieldOffset(Offset = "0x40")]
		private LocalTrackStore.TrackBinderMgr m_binderMgr;

		// Token: 0x04001373 RID: 4979
		[Token(Token = "0x4001373")]
		[FieldOffset(Offset = "0x48")]
		private Coroutine m_saveCoroutine;

		// Token: 0x04001374 RID: 4980
		[Token(Token = "0x4001374")]
		[FieldOffset(Offset = "0x50")]
		private long m_saveStartTick;

		// Token: 0x04001375 RID: 4981
		[Token(Token = "0x4001375")]
		[FieldOffset(Offset = "0x58")]
		private MemUserDataStore.Data<LocalTrackStore.Data> m_memData;

		// Token: 0x04001376 RID: 4982
		[Token(Token = "0x4001376")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NotifyPlayerDataChanged;

		// Token: 0x04001377 RID: 4983
		[Token(Token = "0x4001377")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NotifyEnteringMainGame;

		// Token: 0x04001378 RID: 4984
		[Token(Token = "0x4001378")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_NotifyCrossDay;

		// Token: 0x04001379 RID: 4985
		[Token(Token = "0x4001379")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoTrackTrigger;

		// Token: 0x0400137A RID: 4986
		[Token(Token = "0x400137A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConsumeTrack;

		// Token: 0x0400137B RID: 4987
		[Token(Token = "0x400137B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckTrack;

		// Token: 0x0400137C RID: 4988
		[Token(Token = "0x400137C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ConsumeTracksByType;

		// Token: 0x0400137D RID: 4989
		[Token(Token = "0x400137D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckTracksByType;

		// Token: 0x0400137E RID: 4990
		[Token(Token = "0x400137E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetTracksByType;

		// Token: 0x0400137F RID: 4991
		[Token(Token = "0x400137F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RemoveTrackVer;

		// Token: 0x04001380 RID: 4992
		[Token(Token = "0x4001380")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04001381 RID: 4993
		[Token(Token = "0x4001381")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04001382 RID: 4994
		[Token(Token = "0x4001382")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DoTrackTrigger;

		// Token: 0x04001383 RID: 4995
		[Token(Token = "0x4001383")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetTrackTypeVersion;

		// Token: 0x04001384 RID: 4996
		[Token(Token = "0x4001384")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__NotifyEnteringMainGame;

		// Token: 0x04001385 RID: 4997
		[Token(Token = "0x4001385")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__NotifyCrossDay;

		// Token: 0x04001386 RID: 4998
		[Token(Token = "0x4001386")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__AddTrigger;

		// Token: 0x04001387 RID: 4999
		[Token(Token = "0x4001387")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__BeforeSceneLoadingStart;

		// Token: 0x04001388 RID: 5000
		[Token(Token = "0x4001388")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__LockStoreDataWrite;

		// Token: 0x04001389 RID: 5001
		[Token(Token = "0x4001389")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetStoreData;

		// Token: 0x0400138A RID: 5002
		[Token(Token = "0x400138A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SaveStoreDataImmediately;

		// Token: 0x0400138B RID: 5003
		[Token(Token = "0x400138B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SaveStoreDataWithDelay;

		// Token: 0x0400138C RID: 5004
		[Token(Token = "0x400138C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SaveStoreCoroutine;

		// Token: 0x0400138D RID: 5005
		[Token(Token = "0x400138D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CancelSaveStoreRequest;

		// Token: 0x0400138E RID: 5006
		[Token(Token = "0x400138E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400138F RID: 5007
		[Token(Token = "0x400138F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_BindLocalTrackPoint;

		// Token: 0x04001390 RID: 5008
		[Token(Token = "0x4001390")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_UnBindLocalTrackPoint;

		// Token: 0x04001391 RID: 5009
		[Token(Token = "0x4001391")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__MatchPrefixCondition;

		// Token: 0x04001392 RID: 5010
		[Token(Token = "0x4001392")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__MatchSuffixCondition;

		// Token: 0x04001393 RID: 5011
		[Token(Token = "0x4001393")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__MatchByTypeRule;

		// Token: 0x04001394 RID: 5012
		[Token(Token = "0x4001394")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__GetConditionDelegate;

		// Token: 0x04001395 RID: 5013
		[Token(Token = "0x4001395")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__GetRuleDelegate;

		// Token: 0x04001396 RID: 5014
		[Token(Token = "0x4001396")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__TryMatch;

		// Token: 0x04001397 RID: 5015
		[Token(Token = "0x4001397")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_ConsumeTracksByMatchRule;

		// Token: 0x0200050F RID: 1295
		[Token(Token = "0x200050F")]
		protected class Data : IHotfixable
		{
			// Token: 0x06004F1B RID: 20251 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004F1B")]
			[Address(RVA = "0x1880000", Offset = "0x187EC00", VA = "0x181880000")]
			public static IDisposable LockWrite(LocalTrackStore.Data data)
			{
				return null;
			}

			// Token: 0x06004F1C RID: 20252 RVA: 0x0002E380 File Offset: 0x0002C580
			[Token(Token = "0x6004F1C")]
			[Address(RVA = "0x18800A0", Offset = "0x187ECA0", VA = "0x1818800A0")]
			public bool RecordTrack(TrackTrigger trigger)
			{
				return default(bool);
			}

			// Token: 0x06004F1D RID: 20253 RVA: 0x0002E398 File Offset: 0x0002C598
			[Token(Token = "0x6004F1D")]
			[Address(RVA = "0x18803D0", Offset = "0x187EFD0", VA = "0x1818803D0")]
			public bool RecordTrack(string type, string id)
			{
				return default(bool);
			}

			// Token: 0x06004F1E RID: 20254 RVA: 0x0002E3B0 File Offset: 0x0002C5B0
			[Token(Token = "0x6004F1E")]
			[Address(RVA = "0x18805B0", Offset = "0x187F1B0", VA = "0x1818805B0")]
			public bool RemoveTrack(string type, string id)
			{
				return default(bool);
			}

			// Token: 0x06004F1F RID: 20255 RVA: 0x0002E3C8 File Offset: 0x0002C5C8
			[Token(Token = "0x6004F1F")]
			[Address(RVA = "0x1880730", Offset = "0x187F330", VA = "0x181880730")]
			public bool RemoveTracksInGivenIdList(string type, List<string> trackIdToRemoveList)
			{
				return default(bool);
			}

			// Token: 0x06004F20 RID: 20256 RVA: 0x0002E3E0 File Offset: 0x0002C5E0
			[Token(Token = "0x6004F20")]
			[Address(RVA = "0x18809B0", Offset = "0x187F5B0", VA = "0x1818809B0")]
			public bool RemoveTracks(string type)
			{
				return default(bool);
			}

			// Token: 0x06004F21 RID: 20257 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
			[Token(Token = "0x6004F21")]
			[Address(RVA = "0x187FDB0", Offset = "0x187E9B0", VA = "0x18187FDB0")]
			public bool CheckTrack(string type, string id)
			{
				return default(bool);
			}

			// Token: 0x06004F22 RID: 20258 RVA: 0x0002E410 File Offset: 0x0002C610
			[Token(Token = "0x6004F22")]
			[Address(RVA = "0x187FEA0", Offset = "0x187EAA0", VA = "0x18187FEA0")]
			public bool CheckTracks(string type)
			{
				return default(bool);
			}

			// Token: 0x06004F23 RID: 20259 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004F23")]
			[Address(RVA = "0x187FF70", Offset = "0x187EB70", VA = "0x18187FF70")]
			public ICollection<string> GetTracks(string type)
			{
				return null;
			}

			// Token: 0x06004F24 RID: 20260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F24")]
			[Address(RVA = "0x1880B10", Offset = "0x187F710", VA = "0x181880B10")]
			private static void _ThrowInvalidWriteOperation()
			{
			}

			// Token: 0x06004F25 RID: 20261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F25")]
			[Address(RVA = "0x1880BE0", Offset = "0x187F7E0", VA = "0x181880BE0")]
			public Data()
			{
			}

			// Token: 0x04001398 RID: 5016
			[Token(Token = "0x4001398")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, HashSet<string>> tracks;

			// Token: 0x04001399 RID: 5017
			[Token(Token = "0x4001399")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, long> trackVers;

			// Token: 0x0400139A RID: 5018
			[Token(Token = "0x400139A")]
			[FieldOffset(Offset = "0x20")]
			[JsonIgnore]
			[NonSerialized]
			private LocalTrackStore.Data.WritableLock m_writableLock;

			// Token: 0x0400139B RID: 5019
			[Token(Token = "0x400139B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LockWrite;

			// Token: 0x0400139C RID: 5020
			[Token(Token = "0x400139C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RecordTrack;

			// Token: 0x0400139D RID: 5021
			[Token(Token = "0x400139D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix1_RecordTrack;

			// Token: 0x0400139E RID: 5022
			[Token(Token = "0x400139E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RemoveTrack;

			// Token: 0x0400139F RID: 5023
			[Token(Token = "0x400139F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RemoveTracksInGivenIdList;

			// Token: 0x040013A0 RID: 5024
			[Token(Token = "0x40013A0")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RemoveTracks;

			// Token: 0x040013A1 RID: 5025
			[Token(Token = "0x40013A1")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CheckTrack;

			// Token: 0x040013A2 RID: 5026
			[Token(Token = "0x40013A2")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_CheckTracks;

			// Token: 0x040013A3 RID: 5027
			[Token(Token = "0x40013A3")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_GetTracks;

			// Token: 0x040013A4 RID: 5028
			[Token(Token = "0x40013A4")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__ThrowInvalidWriteOperation;

			// Token: 0x040013A5 RID: 5029
			[Token(Token = "0x40013A5")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02000510 RID: 1296
			[Token(Token = "0x2000510")]
			private class WritableLock : IDisposable
			{
				// Token: 0x17000244 RID: 580
				// (get) Token: 0x06004F26 RID: 20262 RVA: 0x0002E428 File Offset: 0x0002C628
				// (set) Token: 0x06004F27 RID: 20263 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17000244")]
				public bool isLocked
				{
					[Token(Token = "0x6004F26")]
					[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
					[CompilerGenerated]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x6004F27")]
					[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
					[CompilerGenerated]
					private set
					{
					}
				}

				// Token: 0x06004F28 RID: 20264 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004F28")]
				[Address(RVA = "0x1896E30", Offset = "0x1895A30", VA = "0x181896E30")]
				public IDisposable Lock()
				{
					return null;
				}

				// Token: 0x06004F29 RID: 20265 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004F29")]
				[Address(RVA = "0x13A5FA0", Offset = "0x13A4BA0", VA = "0x1813A5FA0", Slot = "4")]
				public void Dispose()
				{
				}

				// Token: 0x06004F2A RID: 20266 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004F2A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public WritableLock()
				{
				}
			}
		}

		// Token: 0x02000511 RID: 1297
		[Token(Token = "0x2000511")]
		public class HolderHandler : IHotfixable
		{
			// Token: 0x06004F2B RID: 20267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F2B")]
			[Address(RVA = "0x18890D0", Offset = "0x1887CD0", VA = "0x1818890D0")]
			public HolderHandler(LocalTrackStore store)
			{
			}

			// Token: 0x06004F2C RID: 20268 RVA: 0x0002E440 File Offset: 0x0002C640
			[Token(Token = "0x6004F2C")]
			[Address(RVA = "0x1888EA0", Offset = "0x1887AA0", VA = "0x181888EA0")]
			public bool DoTrackTrigger(TrackTrigger trigger)
			{
				return default(bool);
			}

			// Token: 0x06004F2D RID: 20269 RVA: 0x0002E458 File Offset: 0x0002C658
			[Token(Token = "0x6004F2D")]
			[Address(RVA = "0x1888FD0", Offset = "0x1887BD0", VA = "0x181888FD0")]
			public long GetTrackTypeVersion(string type)
			{
				return 0L;
			}

			// Token: 0x040013A7 RID: 5031
			[Token(Token = "0x40013A7")]
			[FieldOffset(Offset = "0x10")]
			private LocalTrackStore m_store;

			// Token: 0x040013A8 RID: 5032
			[Token(Token = "0x40013A8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040013A9 RID: 5033
			[Token(Token = "0x40013A9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DoTrackTrigger;

			// Token: 0x040013AA RID: 5034
			[Token(Token = "0x40013AA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetTrackTypeVersion;
		}

		// Token: 0x02000512 RID: 1298
		[Token(Token = "0x2000512")]
		public interface IBindLocalTrackStore
		{
			// Token: 0x06004F2E RID: 20270
			[Token(Token = "0x6004F2E")]
			void OnStateChanged(ITrackPointStatus status);
		}

		// Token: 0x02000513 RID: 1299
		[Token(Token = "0x2000513")]
		public struct TrackPointBinderKey : IHotfixable
		{
			// Token: 0x06004F2F RID: 20271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F2F")]
			[Address(RVA = "0x18932A0", Offset = "0x1891EA0", VA = "0x1818932A0")]
			public TrackPointBinderKey(string type, string trackId)
			{
			}

			// Token: 0x06004F30 RID: 20272 RVA: 0x0002E470 File Offset: 0x0002C670
			[Token(Token = "0x6004F30")]
			[Address(RVA = "0x18930A0", Offset = "0x1891CA0", VA = "0x1818930A0")]
			public MixedID CreateUniqueId()
			{
				return default(MixedID);
			}

			// Token: 0x06004F31 RID: 20273 RVA: 0x0002E488 File Offset: 0x0002C688
			[Token(Token = "0x6004F31")]
			[Address(RVA = "0x1893160", Offset = "0x1891D60", VA = "0x181893160")]
			public bool Equals(LocalTrackStore.TrackPointBinderKey obj)
			{
				return default(bool);
			}

			// Token: 0x06004F32 RID: 20274 RVA: 0x0002E4A0 File Offset: 0x0002C6A0
			[Token(Token = "0x6004F32")]
			[Address(RVA = "0x1893210", Offset = "0x1891E10", VA = "0x181893210")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x040013AB RID: 5035
			[Token(Token = "0x40013AB")]
			[FieldOffset(Offset = "0x0")]
			public string type;

			// Token: 0x040013AC RID: 5036
			[Token(Token = "0x40013AC")]
			[FieldOffset(Offset = "0x8")]
			public string trackId;

			// Token: 0x040013AD RID: 5037
			[Token(Token = "0x40013AD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040013AE RID: 5038
			[Token(Token = "0x40013AE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateUniqueId;

			// Token: 0x040013AF RID: 5039
			[Token(Token = "0x40013AF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Equals;

			// Token: 0x040013B0 RID: 5040
			[Token(Token = "0x40013B0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_IsValid;
		}

		// Token: 0x02000514 RID: 1300
		[Token(Token = "0x2000514")]
		private class TrackBinderMgr : IHotfixable
		{
			// Token: 0x06004F33 RID: 20275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F33")]
			[Address(RVA = "0x1890EC0", Offset = "0x188FAC0", VA = "0x181890EC0")]
			public TrackBinderMgr(LocalTrackStore.TrackObserverCenter observerCenter)
			{
			}

			// Token: 0x06004F34 RID: 20276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F34")]
			[Address(RVA = "0x188FE40", Offset = "0x188EA40", VA = "0x18188FE40")]
			public void BindLocalTrackPoint(LocalTrackStore.TrackPointBinderKey binderKey, LocalTrackStore.IBindLocalTrackStore binder)
			{
			}

			// Token: 0x06004F35 RID: 20277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F35")]
			[Address(RVA = "0x1890420", Offset = "0x188F020", VA = "0x181890420")]
			public void UnBindLocalTrackPoint(LocalTrackStore.IBindLocalTrackStore trackPoint)
			{
			}

			// Token: 0x06004F36 RID: 20278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F36")]
			[Address(RVA = "0x18907B0", Offset = "0x188F3B0", VA = "0x1818907B0")]
			private void _AddBindedTrackPointToDict(LocalTrackStore.TrackPointBinderKey binderKey, LocalTrackStore.IBindLocalTrackStore binder)
			{
			}

			// Token: 0x06004F37 RID: 20279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F37")]
			[Address(RVA = "0x1890BE0", Offset = "0x188F7E0", VA = "0x181890BE0")]
			private void _RemoveBindedTrackPointFromDict(LocalTrackStore.TrackPointBinderKey binderKey, LocalTrackStore.IBindLocalTrackStore binder)
			{
			}

			// Token: 0x06004F38 RID: 20280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F38")]
			[Address(RVA = "0x1890930", Offset = "0x188F530", VA = "0x181890930")]
			private void _AddTrackPointObserverForBinder(LocalTrackStore.TrackBinderMgr.BinderMeta meta)
			{
			}

			// Token: 0x06004F39 RID: 20281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F39")]
			[Address(RVA = "0x1890A70", Offset = "0x188F670", VA = "0x181890A70")]
			private void _ReleaseTrackPointMeta(LocalTrackStore.TrackBinderMgr.BinderMeta meta)
			{
			}

			// Token: 0x06004F3A RID: 20282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F3A")]
			[Address(RVA = "0x1890CE0", Offset = "0x188F8E0", VA = "0x181890CE0")]
			private void _UpdateTrackPointBinderCallback(bool isShow, object rawMeta)
			{
			}

			// Token: 0x040013B1 RID: 5041
			[Token(Token = "0x40013B1")]
			[FieldOffset(Offset = "0x10")]
			private LocalTrackStore.TrackObserverCenter m_observerCenter;

			// Token: 0x040013B2 RID: 5042
			[Token(Token = "0x40013B2")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<string, ListSet<LocalTrackStore.IBindLocalTrackStore>> m_bindedTrackPoints;

			// Token: 0x040013B3 RID: 5043
			[Token(Token = "0x40013B3")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<LocalTrackStore.IBindLocalTrackStore, LocalTrackStore.TrackBinderMgr.BinderMeta> m_trackBinderMetaDict;

			// Token: 0x040013B4 RID: 5044
			[Token(Token = "0x40013B4")]
			[FieldOffset(Offset = "0x28")]
			private LocalTrackStore.TrackBinderMgr.BinderSetter m_trackPointBinderSetter;

			// Token: 0x040013B5 RID: 5045
			[Token(Token = "0x40013B5")]
			[FieldOffset(Offset = "0x30")]
			private LocalGenericPool<LocalTrackStore.TrackBinderMgr.BinderMeta> m_metaPool;

			// Token: 0x040013B6 RID: 5046
			[Token(Token = "0x40013B6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040013B7 RID: 5047
			[Token(Token = "0x40013B7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_BindLocalTrackPoint;

			// Token: 0x040013B8 RID: 5048
			[Token(Token = "0x40013B8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UnBindLocalTrackPoint;

			// Token: 0x040013B9 RID: 5049
			[Token(Token = "0x40013B9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__AddBindedTrackPointToDict;

			// Token: 0x040013BA RID: 5050
			[Token(Token = "0x40013BA")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__RemoveBindedTrackPointFromDict;

			// Token: 0x040013BB RID: 5051
			[Token(Token = "0x40013BB")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__AddTrackPointObserverForBinder;

			// Token: 0x040013BC RID: 5052
			[Token(Token = "0x40013BC")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__ReleaseTrackPointMeta;

			// Token: 0x040013BD RID: 5053
			[Token(Token = "0x40013BD")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__UpdateTrackPointBinderCallback;

			// Token: 0x02000515 RID: 1301
			[Token(Token = "0x2000515")]
			private class BinderSetter : ITrackPointStatus
			{
				// Token: 0x06004F3B RID: 20283 RVA: 0x0002E4B8 File Offset: 0x0002C6B8
				[Token(Token = "0x6004F3B")]
				[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "4")]
				public bool IsShow()
				{
					return default(bool);
				}

				// Token: 0x06004F3C RID: 20284 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004F3C")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public BinderSetter()
				{
				}

				// Token: 0x040013BE RID: 5054
				[Token(Token = "0x40013BE")]
				[FieldOffset(Offset = "0x10")]
				public bool isShow;
			}

			// Token: 0x02000516 RID: 1302
			[Token(Token = "0x2000516")]
			private class BinderMeta : IHotfixable
			{
				// Token: 0x06004F3D RID: 20285 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004F3D")]
				[Address(RVA = "0x187E8C0", Offset = "0x187D4C0", VA = "0x18187E8C0")]
				public static void Reset(LocalTrackStore.TrackBinderMgr.BinderMeta inst)
				{
				}

				// Token: 0x06004F3E RID: 20286 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004F3E")]
				[Address(RVA = "0x187E940", Offset = "0x187D540", VA = "0x18187E940")]
				public BinderMeta()
				{
				}

				// Token: 0x040013BF RID: 5055
				[Token(Token = "0x40013BF")]
				[FieldOffset(Offset = "0x10")]
				public LocalTrackStore.IBindLocalTrackStore binder;

				// Token: 0x040013C0 RID: 5056
				[Token(Token = "0x40013C0")]
				[FieldOffset(Offset = "0x18")]
				public LocalTrackStore.TrackPointBinderKey key;

				// Token: 0x040013C1 RID: 5057
				[Token(Token = "0x40013C1")]
				[FieldOffset(Offset = "0x28")]
				public LocalTrackStore.TrackObserverCenter.IDObserver observer;

				// Token: 0x040013C2 RID: 5058
				[Token(Token = "0x40013C2")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_Reset;

				// Token: 0x040013C3 RID: 5059
				[Token(Token = "0x40013C3")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}

		// Token: 0x02000517 RID: 1303
		[Token(Token = "0x2000517")]
		public enum MatchConditionType
		{
			// Token: 0x040013C5 RID: 5061
			[Token(Token = "0x40013C5")]
			NONE,
			// Token: 0x040013C6 RID: 5062
			[Token(Token = "0x40013C6")]
			PREFIX,
			// Token: 0x040013C7 RID: 5063
			[Token(Token = "0x40013C7")]
			SUFFIX
		}

		// Token: 0x02000518 RID: 1304
		[Token(Token = "0x2000518")]
		public struct MatchCondition : IHotfixable
		{
			// Token: 0x06004F3F RID: 20287 RVA: 0x0002E4D0 File Offset: 0x0002C6D0
			[Token(Token = "0x6004F3F")]
			[Address(RVA = "0x188E030", Offset = "0x188CC30", VA = "0x18188E030")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x040013C8 RID: 5064
			[Token(Token = "0x40013C8")]
			[FieldOffset(Offset = "0x0")]
			public LocalTrackStore.MatchConditionType conditionType;

			// Token: 0x040013C9 RID: 5065
			[Token(Token = "0x40013C9")]
			[FieldOffset(Offset = "0x8")]
			public string conditionPattern;

			// Token: 0x040013CA RID: 5066
			[Token(Token = "0x40013CA")]
			[FieldOffset(Offset = "0x10")]
			public bool exclude;

			// Token: 0x040013CB RID: 5067
			[Token(Token = "0x40013CB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsValid;
		}

		// Token: 0x02000519 RID: 1305
		// (Invoke) Token: 0x06004F41 RID: 20289
		[Token(Token = "0x2000519")]
		private delegate bool MatchConditionDelegate(string trackId, string conditionPattern, bool exclude);

		// Token: 0x0200051A RID: 1306
		[Token(Token = "0x200051A")]
		public enum MatchRuleType
		{
			// Token: 0x040013CD RID: 5069
			[Token(Token = "0x40013CD")]
			NONE,
			// Token: 0x040013CE RID: 5070
			[Token(Token = "0x40013CE")]
			MATCH_BY_TYPE
		}

		// Token: 0x0200051B RID: 1307
		[Token(Token = "0x200051B")]
		public struct MatchRule : IHotfixable
		{
			// Token: 0x06004F44 RID: 20292 RVA: 0x0002E4E8 File Offset: 0x0002C6E8
			[Token(Token = "0x6004F44")]
			[Address(RVA = "0x188E0C0", Offset = "0x188CCC0", VA = "0x18188E0C0")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x040013CF RID: 5071
			[Token(Token = "0x40013CF")]
			[FieldOffset(Offset = "0x0")]
			public LocalTrackStore.MatchRuleType ruleType;

			// Token: 0x040013D0 RID: 5072
			[Token(Token = "0x40013D0")]
			[FieldOffset(Offset = "0x8")]
			public string rulePattern;

			// Token: 0x040013D1 RID: 5073
			[Token(Token = "0x40013D1")]
			[FieldOffset(Offset = "0x10")]
			public List<LocalTrackStore.MatchCondition> conditions;

			// Token: 0x040013D2 RID: 5074
			[Token(Token = "0x40013D2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsValid;
		}

		// Token: 0x0200051C RID: 1308
		// (Invoke) Token: 0x06004F46 RID: 20294
		[Token(Token = "0x200051C")]
		private delegate bool MatchRuleDelegate(string rulePattern, List<LocalTrackStore.MatchCondition> conditions);

		// Token: 0x0200051D RID: 1309
		[Token(Token = "0x200051D")]
		private class TrackObserverCenter : IHotfixable
		{
			// Token: 0x06004F49 RID: 20297 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004F49")]
			[Address(RVA = "0x1891360", Offset = "0x188FF60", VA = "0x181891360")]
			public LocalTrackStore.TrackObserverCenter.IDObserver AllocIDObserver(string type, string id, LocalTrackStore.TrackObserverCenter.IDObserver.TrackChangeCallback callback, object context)
			{
				return null;
			}

			// Token: 0x06004F4A RID: 20298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F4A")]
			[Address(RVA = "0x18921D0", Offset = "0x1890DD0", VA = "0x1818921D0")]
			public void ReleaseIDObserver(LocalTrackStore.TrackObserverCenter.IDObserver inst)
			{
			}

			// Token: 0x06004F4B RID: 20299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F4B")]
			[Address(RVA = "0x1891650", Offset = "0x1890250", VA = "0x181891650")]
			public void NotifyTrackChanged(string type, string id, bool exists)
			{
			}

			// Token: 0x06004F4C RID: 20300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F4C")]
			[Address(RVA = "0x1891B90", Offset = "0x1890790", VA = "0x181891B90")]
			public void NotifyTrackTypeRemoved(string type, ICollection<string> idSet)
			{
			}

			// Token: 0x06004F4D RID: 20301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F4D")]
			[Address(RVA = "0x18910C0", Offset = "0x188FCC0", VA = "0x1818910C0")]
			public void AddObserver(LocalTrackStore.TrackObserverCenter.ITrackObserver observer)
			{
			}

			// Token: 0x06004F4E RID: 20302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F4E")]
			[Address(RVA = "0x1892260", Offset = "0x1890E60", VA = "0x181892260")]
			public void RemoveObserver(LocalTrackStore.TrackObserverCenter.ITrackObserver observer)
			{
			}

			// Token: 0x06004F4F RID: 20303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F4F")]
			[Address(RVA = "0x1892500", Offset = "0x1891100", VA = "0x181892500")]
			private void _AddIDObserver(LocalTrackStore.TrackObserverCenter.IDObserver observer)
			{
			}

			// Token: 0x06004F50 RID: 20304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F50")]
			[Address(RVA = "0x1892C30", Offset = "0x1891830", VA = "0x181892C30")]
			private void _RemoveIDObserver(LocalTrackStore.TrackObserverCenter.IDObserver observer)
			{
			}

			// Token: 0x06004F51 RID: 20305 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004F51")]
			[Address(RVA = "0x1892990", Offset = "0x1891590", VA = "0x181892990")]
			private ListSet<LocalTrackStore.TrackObserverCenter.IDObserver> _GetIDObservers(string type, string id, bool autoCreate)
			{
				return null;
			}

			// Token: 0x06004F52 RID: 20306 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004F52")]
			[Address(RVA = "0x18927D0", Offset = "0x18913D0", VA = "0x1818927D0")]
			private ListSet<LocalTrackStore.TrackObserverCenter.ITrackObserver> _GetGeneralObservers(string type, bool autoCreate)
			{
				return null;
			}

			// Token: 0x06004F53 RID: 20307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F53")]
			[Address(RVA = "0x1892F00", Offset = "0x1891B00", VA = "0x181892F00")]
			public TrackObserverCenter()
			{
			}

			// Token: 0x040013D3 RID: 5075
			[Token(Token = "0x40013D3")]
			[FieldOffset(Offset = "0x10")]
			private LocalGenericPool<LocalTrackStore.TrackObserverCenter.IDObserver> m_idObserverPool;

			// Token: 0x040013D4 RID: 5076
			[Token(Token = "0x40013D4")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<string, Dictionary<string, ListSet<LocalTrackStore.TrackObserverCenter.IDObserver>>> m_idObservers;

			// Token: 0x040013D5 RID: 5077
			[Token(Token = "0x40013D5")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<string, ListSet<LocalTrackStore.TrackObserverCenter.ITrackObserver>> m_generalObservers;

			// Token: 0x040013D6 RID: 5078
			[Token(Token = "0x40013D6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_AllocIDObserver;

			// Token: 0x040013D7 RID: 5079
			[Token(Token = "0x40013D7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ReleaseIDObserver;

			// Token: 0x040013D8 RID: 5080
			[Token(Token = "0x40013D8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_NotifyTrackChanged;

			// Token: 0x040013D9 RID: 5081
			[Token(Token = "0x40013D9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_NotifyTrackTypeRemoved;

			// Token: 0x040013DA RID: 5082
			[Token(Token = "0x40013DA")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AddObserver;

			// Token: 0x040013DB RID: 5083
			[Token(Token = "0x40013DB")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RemoveObserver;

			// Token: 0x040013DC RID: 5084
			[Token(Token = "0x40013DC")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__AddIDObserver;

			// Token: 0x040013DD RID: 5085
			[Token(Token = "0x40013DD")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__RemoveIDObserver;

			// Token: 0x040013DE RID: 5086
			[Token(Token = "0x40013DE")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__GetIDObservers;

			// Token: 0x040013DF RID: 5087
			[Token(Token = "0x40013DF")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__GetGeneralObservers;

			// Token: 0x040013E0 RID: 5088
			[Token(Token = "0x40013E0")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200051E RID: 1310
			[Token(Token = "0x200051E")]
			public interface ITrackObserver : IHotfixable
			{
				// Token: 0x06004F54 RID: 20308
				[Token(Token = "0x6004F54")]
				IList<string> ConcernedTypes();

				// Token: 0x06004F55 RID: 20309
				[Token(Token = "0x6004F55")]
				void OnTrackStateChanged(string type, string id, bool exists);
			}

			// Token: 0x0200051F RID: 1311
			[Token(Token = "0x200051F")]
			public class IDObserver : LocalTrackStore.TrackObserverCenter.ITrackObserver, IHotfixable
			{
				// Token: 0x17000245 RID: 581
				// (get) Token: 0x06004F56 RID: 20310 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x06004F57 RID: 20311 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17000245")]
				public string id
				{
					[Token(Token = "0x6004F56")]
					[Address(RVA = "0x18894F0", Offset = "0x18880F0", VA = "0x1818894F0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Token(Token = "0x6004F57")]
					[Address(RVA = "0x1889550", Offset = "0x1888150", VA = "0x181889550")]
					[CompilerGenerated]
					private set
					{
					}
				}

				// Token: 0x06004F58 RID: 20312 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004F58")]
				[Address(RVA = "0x1889150", Offset = "0x1887D50", VA = "0x181889150")]
				public void CenterOnly_Init(string type, string id, LocalTrackStore.TrackObserverCenter.IDObserver.TrackChangeCallback callback, object context)
				{
				}

				// Token: 0x06004F59 RID: 20313 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004F59")]
				[Address(RVA = "0x1889410", Offset = "0x1888010", VA = "0x181889410")]
				public static void Reset(LocalTrackStore.TrackObserverCenter.IDObserver inst)
				{
				}

				// Token: 0x06004F5A RID: 20314 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004F5A")]
				[Address(RVA = "0x1889300", Offset = "0x1887F00", VA = "0x181889300", Slot = "4")]
				public IList<string> ConcernedTypes()
				{
					return null;
				}

				// Token: 0x06004F5B RID: 20315 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004F5B")]
				[Address(RVA = "0x1889360", Offset = "0x1887F60", VA = "0x181889360", Slot = "5")]
				public void OnTrackStateChanged(string type, string id, bool exists)
				{
				}

				// Token: 0x06004F5C RID: 20316 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004F5C")]
				[Address(RVA = "0x1889490", Offset = "0x1888090", VA = "0x181889490")]
				public IDObserver()
				{
				}

				// Token: 0x040013E1 RID: 5089
				[Token(Token = "0x40013E1")]
				[FieldOffset(Offset = "0x10")]
				private string[] m_typeArray;

				// Token: 0x040013E2 RID: 5090
				[Token(Token = "0x40013E2")]
				[FieldOffset(Offset = "0x18")]
				private object m_context;

				// Token: 0x040013E3 RID: 5091
				[Token(Token = "0x40013E3")]
				[FieldOffset(Offset = "0x20")]
				private LocalTrackStore.TrackObserverCenter.IDObserver.TrackChangeCallback m_callback;

				// Token: 0x040013E5 RID: 5093
				[Token(Token = "0x40013E5")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_id;

				// Token: 0x040013E6 RID: 5094
				[Token(Token = "0x40013E6")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_set_id;

				// Token: 0x040013E7 RID: 5095
				[Token(Token = "0x40013E7")]
				[FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_CenterOnly_Init;

				// Token: 0x040013E8 RID: 5096
				[Token(Token = "0x40013E8")]
				[FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_Reset;

				// Token: 0x040013E9 RID: 5097
				[Token(Token = "0x40013E9")]
				[FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_ConcernedTypes;

				// Token: 0x040013EA RID: 5098
				[Token(Token = "0x40013EA")]
				[FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_OnTrackStateChanged;

				// Token: 0x040013EB RID: 5099
				[Token(Token = "0x40013EB")]
				[FieldOffset(Offset = "0x30")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x02000520 RID: 1312
				// (Invoke) Token: 0x06004F5E RID: 20318
				[Token(Token = "0x2000520")]
				public delegate void TrackChangeCallback(bool exists, object context);
			}
		}
	}
}
