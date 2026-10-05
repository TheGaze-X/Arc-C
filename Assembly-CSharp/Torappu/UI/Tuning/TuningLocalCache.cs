using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CB4 RID: 15540
	[Token(Token = "0x2003CB4")]
	public class TuningLocalCache : Singleton<TuningLocalCache>
	{
		// Token: 0x060183DB RID: 99291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183DB")]
		[Address(RVA = "0x10C2640", Offset = "0x10C1240", VA = "0x1810C2640")]
		private TuningLocalCache()
		{
		}

		// Token: 0x060183DC RID: 99292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60183DC")]
		[Address(RVA = "0x10C2340", Offset = "0x10C0F40", VA = "0x1810C2340")]
		private TuningLocalCache.ActData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x060183DD RID: 99293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60183DD")]
		[Address(RVA = "0x10C2180", Offset = "0x10C0D80", VA = "0x1810C2180")]
		private TuningLocalCache.ActData _EnsureActCacheData(string actId)
		{
			return null;
		}

		// Token: 0x060183DE RID: 99294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60183DE")]
		[Address(RVA = "0x10C2480", Offset = "0x10C1080", VA = "0x1810C2480")]
		private TuningLocalCache.DataInAct _GetDataInAct(string actId)
		{
			return null;
		}

		// Token: 0x060183DF RID: 99295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183DF")]
		[Address(RVA = "0x10C25B0", Offset = "0x10C11B0", VA = "0x1810C25B0")]
		private void _SaveData(TuningLocalCache.ActData data)
		{
		}

		// Token: 0x060183E0 RID: 99296 RVA: 0x00099C00 File Offset: 0x00097E00
		[Token(Token = "0x60183E0")]
		[Address(RVA = "0x10C1C10", Offset = "0x10C0810", VA = "0x1810C1C10")]
		public bool CheckTuningInvestUnhandledIndex(string actId, string groupId, string investId)
		{
			return default(bool);
		}

		// Token: 0x060183E1 RID: 99297 RVA: 0x00099C18 File Offset: 0x00097E18
		[Token(Token = "0x60183E1")]
		[Address(RVA = "0x10C1E20", Offset = "0x10C0A20", VA = "0x1810C1E20")]
		public int GetTuningInvestUnhandledIndex(string actId, string groupId, string investId)
		{
			return 0;
		}

		// Token: 0x060183E2 RID: 99298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183E2")]
		[Address(RVA = "0x10C1F60", Offset = "0x10C0B60", VA = "0x1810C1F60")]
		public void SetTuningInvestUnhandledIndex(string actId, string groupId, string investId, int index)
		{
		}

		// Token: 0x060183E3 RID: 99299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183E3")]
		[Address(RVA = "0x10C1D30", Offset = "0x10C0930", VA = "0x1810C1D30")]
		public void ConsumeTuningInvestUnhandledIndex(string actId, string groupId)
		{
		}

		// Token: 0x0401D8F6 RID: 121078
		[Token(Token = "0x401D8F6")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<TuningLocalCache.ActData> m_memData;

		// Token: 0x0401D8F7 RID: 121079
		[Token(Token = "0x401D8F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401D8F8 RID: 121080
		[Token(Token = "0x401D8F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x0401D8F9 RID: 121081
		[Token(Token = "0x401D8F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureActCacheData;

		// Token: 0x0401D8FA RID: 121082
		[Token(Token = "0x401D8FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDataInAct;

		// Token: 0x0401D8FB RID: 121083
		[Token(Token = "0x401D8FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x0401D8FC RID: 121084
		[Token(Token = "0x401D8FC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckTuningInvestUnhandledIndex;

		// Token: 0x0401D8FD RID: 121085
		[Token(Token = "0x401D8FD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTuningInvestUnhandledIndex;

		// Token: 0x0401D8FE RID: 121086
		[Token(Token = "0x401D8FE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetTuningInvestUnhandledIndex;

		// Token: 0x0401D8FF RID: 121087
		[Token(Token = "0x401D8FF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ConsumeTuningInvestUnhandledIndex;

		// Token: 0x02003CB5 RID: 15541
		[Token(Token = "0x2003CB5")]
		private class InvestGroup
		{
			// Token: 0x060183E4 RID: 99300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60183E4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InvestGroup()
			{
			}

			// Token: 0x0401D900 RID: 121088
			[Token(Token = "0x401D900")]
			[FieldOffset(Offset = "0x10")]
			public string investId;

			// Token: 0x0401D901 RID: 121089
			[Token(Token = "0x401D901")]
			[FieldOffset(Offset = "0x18")]
			public int unhandledIndex;
		}

		// Token: 0x02003CB6 RID: 15542
		[Token(Token = "0x2003CB6")]
		private class DataInAct
		{
			// Token: 0x060183E5 RID: 99301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60183E5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInAct()
			{
			}

			// Token: 0x0401D902 RID: 121090
			[Token(Token = "0x401D902")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, TuningLocalCache.InvestGroup> investGroups;
		}

		// Token: 0x02003CB7 RID: 15543
		[Token(Token = "0x2003CB7")]
		private class ActData
		{
			// Token: 0x060183E6 RID: 99302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60183E6")]
			[Address(RVA = "0x10BA9C0", Offset = "0x10B95C0", VA = "0x1810BA9C0")]
			public ActData()
			{
			}

			// Token: 0x0401D903 RID: 121091
			[Token(Token = "0x401D903")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0401D904 RID: 121092
			[Token(Token = "0x401D904")]
			[FieldOffset(Offset = "0x18")]
			public TuningLocalCache.DataInAct dataInAct;
		}
	}
}
