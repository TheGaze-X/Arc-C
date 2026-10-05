using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006166 RID: 24934
	[Token(Token = "0x2006166")]
	public class BossRushLocalCache : Singleton<BossRushLocalCache>
	{
		// Token: 0x06023FD6 RID: 147414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FD6")]
		[Address(RVA = "0x1EA3C50", Offset = "0x1EA2850", VA = "0x181EA3C50")]
		private BossRushLocalCache()
		{
		}

		// Token: 0x06023FD7 RID: 147415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FD7")]
		[Address(RVA = "0x1EA3950", Offset = "0x1EA2550", VA = "0x181EA3950")]
		private BossRushLocalCache.ActData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x06023FD8 RID: 147416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FD8")]
		[Address(RVA = "0x1EA3790", Offset = "0x1EA2390", VA = "0x181EA3790")]
		private BossRushLocalCache.ActData _EnsureActCacheData(string actId)
		{
			return null;
		}

		// Token: 0x06023FD9 RID: 147417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FD9")]
		[Address(RVA = "0x1EA3A90", Offset = "0x1EA2690", VA = "0x181EA3A90")]
		private BossRushLocalCache.DataInAct _GetDataInAct(string actId)
		{
			return null;
		}

		// Token: 0x06023FDA RID: 147418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FDA")]
		[Address(RVA = "0x1EA3BC0", Offset = "0x1EA27C0", VA = "0x181EA3BC0")]
		private void _SaveData(BossRushLocalCache.ActData data)
		{
		}

		// Token: 0x06023FDB RID: 147419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FDB")]
		[Address(RVA = "0x1EA2E80", Offset = "0x1EA1A80", VA = "0x181EA2E80")]
		public Dictionary<string, BossRushFixedMemberInfo> LoadFixedPartMemberCache(string actId, string teamId)
		{
			return null;
		}

		// Token: 0x06023FDC RID: 147420 RVA: 0x000C2B08 File Offset: 0x000C0D08
		[Token(Token = "0x6023FDC")]
		[Address(RVA = "0x1EA3100", Offset = "0x1EA1D00", VA = "0x181EA3100")]
		public ActivityBossRushData.BossRushStageType LoadStageGroupModeCache(string actId, string stageGroupId)
		{
			return ActivityBossRushData.BossRushStageType.NONE;
		}

		// Token: 0x06023FDD RID: 147421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FDD")]
		[Address(RVA = "0x1EA2F80", Offset = "0x1EA1B80", VA = "0x181EA2F80")]
		public string LoadSquadSelectTeamIdCache(string actId, string stageId)
		{
			return null;
		}

		// Token: 0x06023FDE RID: 147422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023FDE")]
		[Address(RVA = "0x1EA2D80", Offset = "0x1EA1980", VA = "0x181EA2D80")]
		public List<SquadSlotCache> LoadCustomPartSquadCache(string actId, string teamId)
		{
			return null;
		}

		// Token: 0x06023FDF RID: 147423 RVA: 0x000C2B20 File Offset: 0x000C0D20
		[Token(Token = "0x6023FDF")]
		[Address(RVA = "0x1EA3070", Offset = "0x1EA1C70", VA = "0x181EA3070")]
		public bool LoadSquadTeamPredefineChangedFlag(string actId)
		{
			return default(bool);
		}

		// Token: 0x06023FE0 RID: 147424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FE0")]
		[Address(RVA = "0x1EA3620", Offset = "0x1EA2220", VA = "0x181EA3620")]
		public void SaveStageGroupModeCache(string actId, string stageGroupId, ActivityBossRushData.BossRushStageType mode)
		{
		}

		// Token: 0x06023FE1 RID: 147425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FE1")]
		[Address(RVA = "0x1EA3410", Offset = "0x1EA2010", VA = "0x181EA3410")]
		public void SaveSquadSelectTeamCache(string actId, string stageId, string teamId)
		{
		}

		// Token: 0x06023FE2 RID: 147426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FE2")]
		[Address(RVA = "0x1EA3580", Offset = "0x1EA2180", VA = "0x181EA3580")]
		public void SaveSquadTeamPredefineChanged(string actId)
		{
		}

		// Token: 0x06023FE3 RID: 147427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FE3")]
		[Address(RVA = "0x1EA31E0", Offset = "0x1EA1DE0", VA = "0x181EA31E0")]
		public void SaveInitSquadCacheDict(string actId, string teamId, Dictionary<string, BossRushFixedMemberInfo> memberCache, List<SquadSlotCache> slotList)
		{
		}

		// Token: 0x04031FFA RID: 204794
		[Token(Token = "0x4031FFA")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<BossRushLocalCache.ActData> m_memData;

		// Token: 0x04031FFB RID: 204795
		[Token(Token = "0x4031FFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04031FFC RID: 204796
		[Token(Token = "0x4031FFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x04031FFD RID: 204797
		[Token(Token = "0x4031FFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureActCacheData;

		// Token: 0x04031FFE RID: 204798
		[Token(Token = "0x4031FFE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDataInAct;

		// Token: 0x04031FFF RID: 204799
		[Token(Token = "0x4031FFF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x04032000 RID: 204800
		[Token(Token = "0x4032000")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadFixedPartMemberCache;

		// Token: 0x04032001 RID: 204801
		[Token(Token = "0x4032001")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadStageGroupModeCache;

		// Token: 0x04032002 RID: 204802
		[Token(Token = "0x4032002")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadSquadSelectTeamIdCache;

		// Token: 0x04032003 RID: 204803
		[Token(Token = "0x4032003")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadCustomPartSquadCache;

		// Token: 0x04032004 RID: 204804
		[Token(Token = "0x4032004")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadSquadTeamPredefineChangedFlag;

		// Token: 0x04032005 RID: 204805
		[Token(Token = "0x4032005")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SaveStageGroupModeCache;

		// Token: 0x04032006 RID: 204806
		[Token(Token = "0x4032006")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SaveSquadSelectTeamCache;

		// Token: 0x04032007 RID: 204807
		[Token(Token = "0x4032007")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SaveSquadTeamPredefineChanged;

		// Token: 0x04032008 RID: 204808
		[Token(Token = "0x4032008")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SaveInitSquadCacheDict;

		// Token: 0x02006167 RID: 24935
		[Token(Token = "0x2006167")]
		private class DataInAct
		{
			// Token: 0x06023FE4 RID: 147428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023FE4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInAct()
			{
			}

			// Token: 0x04032009 RID: 204809
			[Token(Token = "0x4032009")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, ActivityBossRushData.BossRushStageType> stageGroupModeCacheDict;

			// Token: 0x0403200A RID: 204810
			[Token(Token = "0x403200A")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, BossRushLocalCache.SquadCache> initSquadCacheDict;

			// Token: 0x0403200B RID: 204811
			[Token(Token = "0x403200B")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, string> squadSelectCacheDict;

			// Token: 0x0403200C RID: 204812
			[Token(Token = "0x403200C")]
			[FieldOffset(Offset = "0x28")]
			public bool teamPredefineSkillChanged;
		}

		// Token: 0x02006168 RID: 24936
		[Token(Token = "0x2006168")]
		private class SquadCache
		{
			// Token: 0x06023FE5 RID: 147429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023FE5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SquadCache()
			{
			}

			// Token: 0x0403200D RID: 204813
			[Token(Token = "0x403200D")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, BossRushFixedMemberInfo> initFixedMemberCacheDict;

			// Token: 0x0403200E RID: 204814
			[Token(Token = "0x403200E")]
			[FieldOffset(Offset = "0x18")]
			public List<SquadSlotCache> initCustomSquadList;
		}

		// Token: 0x02006169 RID: 24937
		[Token(Token = "0x2006169")]
		private class ActData
		{
			// Token: 0x06023FE6 RID: 147430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023FE6")]
			[Address(RVA = "0x1E9D4E0", Offset = "0x1E9C0E0", VA = "0x181E9D4E0")]
			public ActData()
			{
			}

			// Token: 0x0403200F RID: 204815
			[Token(Token = "0x403200F")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04032010 RID: 204816
			[Token(Token = "0x4032010")]
			[FieldOffset(Offset = "0x18")]
			public BossRushLocalCache.DataInAct dataInAct;
		}
	}
}
