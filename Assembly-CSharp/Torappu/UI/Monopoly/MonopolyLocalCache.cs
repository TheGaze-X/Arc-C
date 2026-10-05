using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004821 RID: 18465
	[Token(Token = "0x2004821")]
	public class MonopolyLocalCache : Singleton<MonopolyLocalCache>
	{
		// Token: 0x0601BEA5 RID: 114341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEA5")]
		[Address(RVA = "0x153F5C0", Offset = "0x153E1C0", VA = "0x18153F5C0")]
		private MonopolyLocalCache()
		{
		}

		// Token: 0x0601BEA6 RID: 114342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BEA6")]
		[Address(RVA = "0x153F2C0", Offset = "0x153DEC0", VA = "0x18153F2C0")]
		private MonopolyLocalCache.ActData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x0601BEA7 RID: 114343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BEA7")]
		[Address(RVA = "0x153F150", Offset = "0x153DD50", VA = "0x18153F150")]
		private MonopolyLocalCache.ActData _EnsureActCacheData(string actId)
		{
			return null;
		}

		// Token: 0x0601BEA8 RID: 114344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BEA8")]
		[Address(RVA = "0x153F400", Offset = "0x153E000", VA = "0x18153F400")]
		private MonopolyLocalCache.DataInAct _GetDataInAct(string actId)
		{
			return null;
		}

		// Token: 0x0601BEA9 RID: 114345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEA9")]
		[Address(RVA = "0x153F530", Offset = "0x153E130", VA = "0x18153F530")]
		private void _SaveData(MonopolyLocalCache.ActData data)
		{
		}

		// Token: 0x0601BEAA RID: 114346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BEAA")]
		[Address(RVA = "0x153EC40", Offset = "0x153D840", VA = "0x18153EC40")]
		public string GetLastPlayStageId(string actId)
		{
			return null;
		}

		// Token: 0x0601BEAB RID: 114347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEAB")]
		[Address(RVA = "0x153EEC0", Offset = "0x153DAC0", VA = "0x18153EEC0")]
		public void SaveLastPlayStageId(string actId, string stageId)
		{
		}

		// Token: 0x0601BEAC RID: 114348 RVA: 0x000A69F8 File Offset: 0x000A4BF8
		[Token(Token = "0x601BEAC")]
		[Address(RVA = "0x153EB60", Offset = "0x153D760", VA = "0x18153EB60")]
		public bool CheckStageChecked(string actId, string stageId)
		{
			return default(bool);
		}

		// Token: 0x0601BEAD RID: 114349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEAD")]
		[Address(RVA = "0x153EDC0", Offset = "0x153D9C0", VA = "0x18153EDC0")]
		public void SaveCheckedStage(string actId, string stageId)
		{
		}

		// Token: 0x0601BEAE RID: 114350 RVA: 0x000A6A10 File Offset: 0x000A4C10
		[Token(Token = "0x601BEAE")]
		[Address(RVA = "0x153ECF0", Offset = "0x153D8F0", VA = "0x18153ECF0")]
		public bool GetShouldSkipEndRoundConfirmDialog(string actId, long gameId)
		{
			return default(bool);
		}

		// Token: 0x0601BEAF RID: 114351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEAF")]
		[Address(RVA = "0x153EFA0", Offset = "0x153DBA0", VA = "0x18153EFA0")]
		public void SetShouldSkipEndRoundConfirmDialog(string actId, long gameId, bool value)
		{
		}

		// Token: 0x0402464E RID: 149070
		[Token(Token = "0x402464E")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<MonopolyLocalCache.ActData> m_memData;

		// Token: 0x0402464F RID: 149071
		[Token(Token = "0x402464F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04024650 RID: 149072
		[Token(Token = "0x4024650")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x04024651 RID: 149073
		[Token(Token = "0x4024651")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureActCacheData;

		// Token: 0x04024652 RID: 149074
		[Token(Token = "0x4024652")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDataInAct;

		// Token: 0x04024653 RID: 149075
		[Token(Token = "0x4024653")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x04024654 RID: 149076
		[Token(Token = "0x4024654")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetLastPlayStageId;

		// Token: 0x04024655 RID: 149077
		[Token(Token = "0x4024655")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SaveLastPlayStageId;

		// Token: 0x04024656 RID: 149078
		[Token(Token = "0x4024656")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckStageChecked;

		// Token: 0x04024657 RID: 149079
		[Token(Token = "0x4024657")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SaveCheckedStage;

		// Token: 0x04024658 RID: 149080
		[Token(Token = "0x4024658")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetShouldSkipEndRoundConfirmDialog;

		// Token: 0x04024659 RID: 149081
		[Token(Token = "0x4024659")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetShouldSkipEndRoundConfirmDialog;

		// Token: 0x02004822 RID: 18466
		[Token(Token = "0x2004822")]
		private class DataInAct
		{
			// Token: 0x0601BEB0 RID: 114352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BEB0")]
			[Address(RVA = "0x154AE50", Offset = "0x1549A50", VA = "0x18154AE50")]
			public DataInAct()
			{
			}

			// Token: 0x0402465A RID: 149082
			[Token(Token = "0x402465A")]
			[FieldOffset(Offset = "0x10")]
			public string lastPlayStage;

			// Token: 0x0402465B RID: 149083
			[Token(Token = "0x402465B")]
			[FieldOffset(Offset = "0x18")]
			public HashSet<string> checkedStageIdSet;

			// Token: 0x0402465C RID: 149084
			[Token(Token = "0x402465C")]
			[FieldOffset(Offset = "0x20")]
			public long gameId;

			// Token: 0x0402465D RID: 149085
			[Token(Token = "0x402465D")]
			[FieldOffset(Offset = "0x28")]
			public MonopolyLocalCache.InGameData inGameData;
		}

		// Token: 0x02004823 RID: 18467
		[Token(Token = "0x2004823")]
		private class InGameData
		{
			// Token: 0x0601BEB1 RID: 114353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BEB1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InGameData()
			{
			}

			// Token: 0x0402465E RID: 149086
			[Token(Token = "0x402465E")]
			[FieldOffset(Offset = "0x10")]
			public bool skipEndRoundConfirmDialog;
		}

		// Token: 0x02004824 RID: 18468
		[Token(Token = "0x2004824")]
		private class ActData
		{
			// Token: 0x0601BEB2 RID: 114354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BEB2")]
			[Address(RVA = "0x154AD30", Offset = "0x1549930", VA = "0x18154AD30")]
			public ActData()
			{
			}

			// Token: 0x0402465F RID: 149087
			[Token(Token = "0x402465F")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04024660 RID: 149088
			[Token(Token = "0x4024660")]
			[FieldOffset(Offset = "0x18")]
			public MonopolyLocalCache.DataInAct dataInAct;
		}
	}
}
