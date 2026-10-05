using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C6D RID: 23661
	[Token(Token = "0x2005C6D")]
	public class ClimbTowerLocalCache : Singleton<ClimbTowerLocalCache>
	{
		// Token: 0x06022492 RID: 140434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022492")]
		[Address(RVA = "0x1CBFAD0", Offset = "0x1CBE6D0", VA = "0x181CBFAD0")]
		private ClimbTowerLocalCache()
		{
		}

		// Token: 0x06022493 RID: 140435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022493")]
		[Address(RVA = "0x1CBF830", Offset = "0x1CBE430", VA = "0x181CBF830")]
		private ClimbTowerLocalCache.Data _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x06022494 RID: 140436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022494")]
		[Address(RVA = "0x1CBFA40", Offset = "0x1CBE640", VA = "0x181CBFA40")]
		private void _SaveData(ClimbTowerLocalCache.Data data)
		{
		}

		// Token: 0x06022495 RID: 140437 RVA: 0x000BCE50 File Offset: 0x000BB050
		[Token(Token = "0x6022495")]
		[Address(RVA = "0x1CBE9E0", Offset = "0x1CBD5E0", VA = "0x181CBE9E0")]
		public bool GetTrainTowerToastPlayed()
		{
			return default(bool);
		}

		// Token: 0x06022496 RID: 140438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022496")]
		[Address(RVA = "0x1CBF4C0", Offset = "0x1CBE0C0", VA = "0x181CBF4C0")]
		public void SetTrainTowerToastPlayed()
		{
		}

		// Token: 0x06022497 RID: 140439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022497")]
		[Address(RVA = "0x1CBEA50", Offset = "0x1CBD650", VA = "0x181CBEA50")]
		public Dictionary<int, ClimbTowerCharEditCacheModel> LoadCharEditCacheDict()
		{
			return null;
		}

		// Token: 0x06022498 RID: 140440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022498")]
		[Address(RVA = "0x1CBEBE0", Offset = "0x1CBD7E0", VA = "0x181CBEBE0")]
		public void SaveCharEditCacheDict(Dictionary<int, ClimbTowerCharEditCacheModel> charEditCache)
		{
		}

		// Token: 0x06022499 RID: 140441 RVA: 0x000BCE68 File Offset: 0x000BB068
		[Token(Token = "0x6022499")]
		[Address(RVA = "0x1CBE710", Offset = "0x1CBD310", VA = "0x181CBE710")]
		public bool GetGodCardChecked(string cardId)
		{
			return default(bool);
		}

		// Token: 0x0602249A RID: 140442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602249A")]
		[Address(RVA = "0x1CBF130", Offset = "0x1CBDD30", VA = "0x181CBF130")]
		public void SetGodCardChecked(string cardId)
		{
		}

		// Token: 0x0602249B RID: 140443 RVA: 0x000BCE80 File Offset: 0x000BB080
		[Token(Token = "0x602249B")]
		[Address(RVA = "0x1CBEB10", Offset = "0x1CBD710", VA = "0x181CBEB10")]
		public bool LoadTowerSelectedModeCache(string towerId)
		{
			return default(bool);
		}

		// Token: 0x0602249C RID: 140444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602249C")]
		[Address(RVA = "0x1CBEFB0", Offset = "0x1CBDBB0", VA = "0x181CBEFB0")]
		public void SaveTowerSelectedModeCache(string towerId, bool isHardMode)
		{
		}

		// Token: 0x0602249D RID: 140445 RVA: 0x000BCE98 File Offset: 0x000BB098
		[Token(Token = "0x602249D")]
		[Address(RVA = "0x1CBE670", Offset = "0x1CBD270", VA = "0x181CBE670")]
		public bool GetEntryFloatGodCardTabIsClose()
		{
			return default(bool);
		}

		// Token: 0x0602249E RID: 140446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602249E")]
		[Address(RVA = "0x1CBED60", Offset = "0x1CBD960", VA = "0x181CBED60")]
		public void SaveEntryFloatGodCardTabIsClose(bool isClose)
		{
		}

		// Token: 0x0602249F RID: 140447 RVA: 0x000BCEB0 File Offset: 0x000BB0B0
		[Token(Token = "0x602249F")]
		[Address(RVA = "0x1CBE7E0", Offset = "0x1CBD3E0", VA = "0x181CBE7E0")]
		public bool GetSeasonReplicatedTowerChecked(string seasonId)
		{
			return default(bool);
		}

		// Token: 0x060224A0 RID: 140448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60224A0")]
		[Address(RVA = "0x1CBEE30", Offset = "0x1CBDA30", VA = "0x181CBEE30")]
		public void SaveSeasonReplicatedTowerChecked(string seasonId)
		{
		}

		// Token: 0x060224A1 RID: 140449 RVA: 0x000BCEC8 File Offset: 0x000BB0C8
		[Token(Token = "0x60224A1")]
		[Address(RVA = "0x1CBE8D0", Offset = "0x1CBD4D0", VA = "0x181CBE8D0")]
		public bool GetTowerIsUseSweep(string towerId, bool isHardMode)
		{
			return default(bool);
		}

		// Token: 0x060224A2 RID: 140450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60224A2")]
		[Address(RVA = "0x1CBF2D0", Offset = "0x1CBDED0", VA = "0x181CBF2D0")]
		public void SetTowerIsUseSweep(string towerId, bool isHardMode, bool isUseSweep)
		{
		}

		// Token: 0x060224A3 RID: 140451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60224A3")]
		[Address(RVA = "0x1CBF970", Offset = "0x1CBE570", VA = "0x181CBF970")]
		private string _GeneSweepKey(string towerId, bool isHardMode)
		{
			return null;
		}

		// Token: 0x060224A4 RID: 140452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60224A4")]
		[Address(RVA = "0x1CBF670", Offset = "0x1CBE270", VA = "0x181CBF670")]
		private string _CurGameID()
		{
			return null;
		}

		// Token: 0x060224A5 RID: 140453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60224A5")]
		[Address(RVA = "0x1CBF730", Offset = "0x1CBE330", VA = "0x181CBF730")]
		private ClimbTowerLocalCache.DataInGame _EnsureDataInGame()
		{
			return null;
		}

		// Token: 0x060224A6 RID: 140454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60224A6")]
		[Address(RVA = "0x1CBF570", Offset = "0x1CBE170", VA = "0x181CBF570")]
		private void _ConfirmDataInGame(ClimbTowerLocalCache.DataInGame data, bool triggerSave = true)
		{
		}

		// Token: 0x0402F16C RID: 192876
		[Token(Token = "0x402F16C")]
		private const string HARD_MODE = "hard";

		// Token: 0x0402F16D RID: 192877
		[Token(Token = "0x402F16D")]
		private const string NORMAL_MODE = "norm";

		// Token: 0x0402F16E RID: 192878
		[Token(Token = "0x402F16E")]
		private const string SWEEP_TOWER_ID_AND_HARD_MODE_KEY_FORMAT = "{0}_{1}";

		// Token: 0x0402F16F RID: 192879
		[Token(Token = "0x402F16F")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<ClimbTowerLocalCache.Data> m_memData;

		// Token: 0x0402F170 RID: 192880
		[Token(Token = "0x402F170")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402F171 RID: 192881
		[Token(Token = "0x402F171")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x0402F172 RID: 192882
		[Token(Token = "0x402F172")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x0402F173 RID: 192883
		[Token(Token = "0x402F173")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTrainTowerToastPlayed;

		// Token: 0x0402F174 RID: 192884
		[Token(Token = "0x402F174")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetTrainTowerToastPlayed;

		// Token: 0x0402F175 RID: 192885
		[Token(Token = "0x402F175")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadCharEditCacheDict;

		// Token: 0x0402F176 RID: 192886
		[Token(Token = "0x402F176")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SaveCharEditCacheDict;

		// Token: 0x0402F177 RID: 192887
		[Token(Token = "0x402F177")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetGodCardChecked;

		// Token: 0x0402F178 RID: 192888
		[Token(Token = "0x402F178")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetGodCardChecked;

		// Token: 0x0402F179 RID: 192889
		[Token(Token = "0x402F179")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadTowerSelectedModeCache;

		// Token: 0x0402F17A RID: 192890
		[Token(Token = "0x402F17A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SaveTowerSelectedModeCache;

		// Token: 0x0402F17B RID: 192891
		[Token(Token = "0x402F17B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetEntryFloatGodCardTabIsClose;

		// Token: 0x0402F17C RID: 192892
		[Token(Token = "0x402F17C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SaveEntryFloatGodCardTabIsClose;

		// Token: 0x0402F17D RID: 192893
		[Token(Token = "0x402F17D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetSeasonReplicatedTowerChecked;

		// Token: 0x0402F17E RID: 192894
		[Token(Token = "0x402F17E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SaveSeasonReplicatedTowerChecked;

		// Token: 0x0402F17F RID: 192895
		[Token(Token = "0x402F17F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetTowerIsUseSweep;

		// Token: 0x0402F180 RID: 192896
		[Token(Token = "0x402F180")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SetTowerIsUseSweep;

		// Token: 0x0402F181 RID: 192897
		[Token(Token = "0x402F181")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GeneSweepKey;

		// Token: 0x0402F182 RID: 192898
		[Token(Token = "0x402F182")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CurGameID;

		// Token: 0x0402F183 RID: 192899
		[Token(Token = "0x402F183")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__EnsureDataInGame;

		// Token: 0x0402F184 RID: 192900
		[Token(Token = "0x402F184")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ConfirmDataInGame;

		// Token: 0x02005C6E RID: 23662
		[Token(Token = "0x2005C6E")]
		private class Data
		{
			// Token: 0x060224A7 RID: 140455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60224A7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Data()
			{
			}

			// Token: 0x0402F185 RID: 192901
			[Token(Token = "0x402F185")]
			[FieldOffset(Offset = "0x10")]
			public bool isEntryFloatGodCardTabClose;

			// Token: 0x0402F186 RID: 192902
			[Token(Token = "0x402F186")]
			[FieldOffset(Offset = "0x18")]
			public ClimbTowerLocalCache.DataInGame dataInGame;

			// Token: 0x0402F187 RID: 192903
			[Token(Token = "0x402F187")]
			[FieldOffset(Offset = "0x20")]
			public bool isTrainTowerCompleteToastPlayed;

			// Token: 0x0402F188 RID: 192904
			[Token(Token = "0x402F188")]
			[FieldOffset(Offset = "0x28")]
			public HashSet<string> godCardCheckSet;

			// Token: 0x0402F189 RID: 192905
			[Token(Token = "0x402F189")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<string, bool> towerSelectModeCacheDict;

			// Token: 0x0402F18A RID: 192906
			[Token(Token = "0x402F18A")]
			[FieldOffset(Offset = "0x38")]
			public HashSet<string> seasonReplicatedTowerCheckedSet;

			// Token: 0x0402F18B RID: 192907
			[Token(Token = "0x402F18B")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, bool> towerIsUseSweepDict;
		}

		// Token: 0x02005C6F RID: 23663
		[Token(Token = "0x2005C6F")]
		private class DataInGame
		{
			// Token: 0x060224A8 RID: 140456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60224A8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInGame()
			{
			}

			// Token: 0x0402F18C RID: 192908
			[Token(Token = "0x402F18C")]
			[FieldOffset(Offset = "0x10")]
			public string gameId;

			// Token: 0x0402F18D RID: 192909
			[Token(Token = "0x402F18D")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<int, ClimbTowerCharEditCacheModel> charEditCacheDict;
		}
	}
}
