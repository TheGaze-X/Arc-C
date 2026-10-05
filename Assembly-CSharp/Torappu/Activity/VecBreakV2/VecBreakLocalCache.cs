using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E91 RID: 28305
	[Token(Token = "0x2006E91")]
	public class VecBreakLocalCache : Singleton<VecBreakLocalCache>
	{
		// Token: 0x0602849F RID: 165023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602849F")]
		[Address(RVA = "0x2398C20", Offset = "0x2397820", VA = "0x182398C20")]
		private VecBreakLocalCache()
		{
		}

		// Token: 0x060284A0 RID: 165024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60284A0")]
		[Address(RVA = "0x2398920", Offset = "0x2397520", VA = "0x182398920")]
		private VecBreakLocalCache.ActData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x060284A1 RID: 165025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60284A1")]
		[Address(RVA = "0x2398760", Offset = "0x2397360", VA = "0x182398760")]
		private VecBreakLocalCache.ActData _EnsureActCacheData(string actId)
		{
			return null;
		}

		// Token: 0x060284A2 RID: 165026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60284A2")]
		[Address(RVA = "0x2398A60", Offset = "0x2397660", VA = "0x182398A60")]
		private VecBreakLocalCache.DataInAct _GetDataInAct(string actId)
		{
			return null;
		}

		// Token: 0x060284A3 RID: 165027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284A3")]
		[Address(RVA = "0x2398B90", Offset = "0x2397790", VA = "0x182398B90")]
		private void _SaveData(VecBreakLocalCache.ActData data)
		{
		}

		// Token: 0x060284A4 RID: 165028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60284A4")]
		[Address(RVA = "0x2398260", Offset = "0x2396E60", VA = "0x182398260")]
		public List<SquadSlotCache> LoadSquadCache(string actId, string squadId)
		{
			return null;
		}

		// Token: 0x060284A5 RID: 165029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284A5")]
		[Address(RVA = "0x23985F0", Offset = "0x23971F0", VA = "0x1823985F0")]
		public void SaveSquadCache(string actId, string squadId, List<SquadSlotCache> slotList)
		{
		}

		// Token: 0x060284A6 RID: 165030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60284A6")]
		[Address(RVA = "0x2398080", Offset = "0x2396C80", VA = "0x182398080")]
		public string LoadDefenseCacheStageId(string actId)
		{
			return null;
		}

		// Token: 0x060284A7 RID: 165031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284A7")]
		[Address(RVA = "0x2398350", Offset = "0x2396F50", VA = "0x182398350")]
		public void SaveDefenseCacheStageId(string actId, string stageId)
		{
		}

		// Token: 0x060284A8 RID: 165032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60284A8")]
		[Address(RVA = "0x23981C0", Offset = "0x2396DC0", VA = "0x1823981C0")]
		public string LoadOffenseCacheStageId(string actId)
		{
			return null;
		}

		// Token: 0x060284A9 RID: 165033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284A9")]
		[Address(RVA = "0x2398510", Offset = "0x2397110", VA = "0x182398510")]
		public void SaveOffenseCacheStageId(string actId, string stageId)
		{
		}

		// Token: 0x060284AA RID: 165034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60284AA")]
		[Address(RVA = "0x2398120", Offset = "0x2396D20", VA = "0x182398120")]
		public string LoadHardCacheStageId(string actId)
		{
			return null;
		}

		// Token: 0x060284AB RID: 165035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284AB")]
		[Address(RVA = "0x2398430", Offset = "0x2397030", VA = "0x182398430")]
		public void SaveHardCacheStageId(string actId, string stageId)
		{
		}

		// Token: 0x0403941F RID: 234527
		[Token(Token = "0x403941F")]
		public const string OFFENSE_SQUAD_ID = "offense_squad";

		// Token: 0x04039420 RID: 234528
		[Token(Token = "0x4039420")]
		public const string DEFENSE_SQUAD_ID = "defense_squad_{0}";

		// Token: 0x04039421 RID: 234529
		[Token(Token = "0x4039421")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<VecBreakLocalCache.ActData> m_memData;

		// Token: 0x04039422 RID: 234530
		[Token(Token = "0x4039422")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04039423 RID: 234531
		[Token(Token = "0x4039423")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x04039424 RID: 234532
		[Token(Token = "0x4039424")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureActCacheData;

		// Token: 0x04039425 RID: 234533
		[Token(Token = "0x4039425")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDataInAct;

		// Token: 0x04039426 RID: 234534
		[Token(Token = "0x4039426")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x04039427 RID: 234535
		[Token(Token = "0x4039427")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadSquadCache;

		// Token: 0x04039428 RID: 234536
		[Token(Token = "0x4039428")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SaveSquadCache;

		// Token: 0x04039429 RID: 234537
		[Token(Token = "0x4039429")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadDefenseCacheStageId;

		// Token: 0x0403942A RID: 234538
		[Token(Token = "0x403942A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SaveDefenseCacheStageId;

		// Token: 0x0403942B RID: 234539
		[Token(Token = "0x403942B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadOffenseCacheStageId;

		// Token: 0x0403942C RID: 234540
		[Token(Token = "0x403942C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SaveOffenseCacheStageId;

		// Token: 0x0403942D RID: 234541
		[Token(Token = "0x403942D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadHardCacheStageId;

		// Token: 0x0403942E RID: 234542
		[Token(Token = "0x403942E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SaveHardCacheStageId;

		// Token: 0x02006E92 RID: 28306
		[Token(Token = "0x2006E92")]
		private class DataInAct
		{
			// Token: 0x060284AC RID: 165036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60284AC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInAct()
			{
			}

			// Token: 0x0403942F RID: 234543
			[Token(Token = "0x403942F")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, List<SquadSlotCache>> squadCacheDict;

			// Token: 0x04039430 RID: 234544
			[Token(Token = "0x4039430")]
			[FieldOffset(Offset = "0x18")]
			public string defenseCacheStageId;

			// Token: 0x04039431 RID: 234545
			[Token(Token = "0x4039431")]
			[FieldOffset(Offset = "0x20")]
			public string offenseCacheStageId;

			// Token: 0x04039432 RID: 234546
			[Token(Token = "0x4039432")]
			[FieldOffset(Offset = "0x28")]
			public string hardCacheStageId;
		}

		// Token: 0x02006E93 RID: 28307
		[Token(Token = "0x2006E93")]
		private class ActData
		{
			// Token: 0x060284AD RID: 165037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60284AD")]
			[Address(RVA = "0x238B940", Offset = "0x238A540", VA = "0x18238B940")]
			public ActData()
			{
			}

			// Token: 0x04039433 RID: 234547
			[Token(Token = "0x4039433")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04039434 RID: 234548
			[Token(Token = "0x4039434")]
			[FieldOffset(Offset = "0x18")]
			public VecBreakLocalCache.DataInAct dataInAct;
		}
	}
}
