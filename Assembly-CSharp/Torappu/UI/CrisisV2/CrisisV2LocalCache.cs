using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200590B RID: 22795
	[Token(Token = "0x200590B")]
	public class CrisisV2LocalCache : Singleton<CrisisV2LocalCache>
	{
		// Token: 0x06021380 RID: 136064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021380")]
		[Address(RVA = "0x1B909B0", Offset = "0x1B8F5B0", VA = "0x181B909B0")]
		private CrisisV2LocalCache()
		{
		}

		// Token: 0x06021381 RID: 136065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021381")]
		[Address(RVA = "0x1B904F0", Offset = "0x1B8F0F0", VA = "0x181B904F0")]
		private CrisisV2LocalCache.SeasonData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x06021382 RID: 136066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021382")]
		[Address(RVA = "0x1B90630", Offset = "0x1B8F230", VA = "0x181B90630")]
		private CrisisV2LocalCache.SeasonData _EnsureSeasonCacheData(string seasonId)
		{
			return null;
		}

		// Token: 0x06021383 RID: 136067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021383")]
		[Address(RVA = "0x1B907F0", Offset = "0x1B8F3F0", VA = "0x181B907F0")]
		private CrisisV2LocalCache.DataInSeason _GetDataInSeason(string seasonId)
		{
			return null;
		}

		// Token: 0x06021384 RID: 136068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021384")]
		[Address(RVA = "0x1B90920", Offset = "0x1B8F520", VA = "0x181B90920")]
		private void _SaveData(CrisisV2LocalCache.SeasonData data)
		{
		}

		// Token: 0x06021385 RID: 136069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021385")]
		[Address(RVA = "0x1B8FFD0", Offset = "0x1B8EBD0", VA = "0x181B8FFD0")]
		public List<string> LoadSelectSlotList(string seasonId, string mapId)
		{
			return null;
		}

		// Token: 0x06021386 RID: 136070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021386")]
		[Address(RVA = "0x1B901B0", Offset = "0x1B8EDB0", VA = "0x181B901B0")]
		public void SaveSelectSlotList(string seasonId, string mapId, List<string> selectSlotList)
		{
		}

		// Token: 0x0402D3F6 RID: 185334
		[Token(Token = "0x402D3F6")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<CrisisV2LocalCache.SeasonData> m_memData;

		// Token: 0x0402D3F7 RID: 185335
		[Token(Token = "0x402D3F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402D3F8 RID: 185336
		[Token(Token = "0x402D3F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x0402D3F9 RID: 185337
		[Token(Token = "0x402D3F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureSeasonCacheData;

		// Token: 0x0402D3FA RID: 185338
		[Token(Token = "0x402D3FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDataInSeason;

		// Token: 0x0402D3FB RID: 185339
		[Token(Token = "0x402D3FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x0402D3FC RID: 185340
		[Token(Token = "0x402D3FC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadSelectSlotList;

		// Token: 0x0402D3FD RID: 185341
		[Token(Token = "0x402D3FD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SaveSelectSlotList;

		// Token: 0x0200590C RID: 22796
		[Token(Token = "0x200590C")]
		private class DataInSeason
		{
			// Token: 0x06021387 RID: 136071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021387")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInSeason()
			{
			}

			// Token: 0x0402D3FE RID: 185342
			[Token(Token = "0x402D3FE")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, List<string>> mapSelectSlotList;
		}

		// Token: 0x0200590D RID: 22797
		[Token(Token = "0x200590D")]
		private class SeasonData
		{
			// Token: 0x06021388 RID: 136072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021388")]
			[Address(RVA = "0x1B9DFC0", Offset = "0x1B9CBC0", VA = "0x181B9DFC0")]
			public SeasonData()
			{
			}

			// Token: 0x0402D3FF RID: 185343
			[Token(Token = "0x402D3FF")]
			[FieldOffset(Offset = "0x10")]
			public string seasonId;

			// Token: 0x0402D400 RID: 185344
			[Token(Token = "0x402D400")]
			[FieldOffset(Offset = "0x18")]
			public CrisisV2LocalCache.DataInSeason dataInSeason;
		}
	}
}
