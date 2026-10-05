using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003ACE RID: 15054
	[Token(Token = "0x2003ACE")]
	public class LocalBattleCache : Singleton<LocalBattleCache>
	{
		// Token: 0x06017BDF RID: 97247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BDF")]
		[Address(RVA = "0xFFDE80", Offset = "0xFFCA80", VA = "0x180FFDE80")]
		private LocalBattleCache()
		{
		}

		// Token: 0x06017BE0 RID: 97248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BE0")]
		[Address(RVA = "0xFFD880", Offset = "0xFFC480", VA = "0x180FFD880")]
		private LocalBattleCache.MemCache _EnsureMemCache()
		{
			return null;
		}

		// Token: 0x06017BE1 RID: 97249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BE1")]
		[Address(RVA = "0xFFD460", Offset = "0xFFC060", VA = "0x180FFD460")]
		public Dictionary<string, StageViewModel.LocalCache> UILocalCache_GetStageCache(string key)
		{
			return null;
		}

		// Token: 0x06017BE2 RID: 97250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BE2")]
		[Address(RVA = "0xFFD6C0", Offset = "0xFFC2C0", VA = "0x180FFD6C0")]
		public void UILocalCache_SaveStageCache(string key, Dictionary<string, StageViewModel.LocalCache> localCache)
		{
		}

		// Token: 0x06017BE3 RID: 97251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BE3")]
		[Address(RVA = "0xFFD590", Offset = "0xFFC190", VA = "0x180FFD590")]
		public Dictionary<string, ZoneViewModel.LocalCache> UILocalCache_GetZoneCache(string key)
		{
			return null;
		}

		// Token: 0x06017BE4 RID: 97252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BE4")]
		[Address(RVA = "0xFFD7A0", Offset = "0xFFC3A0", VA = "0x180FFD7A0")]
		public void UILocalCache_SaveZoneCache(string key, Dictionary<string, ZoneViewModel.LocalCache> localCache)
		{
		}

		// Token: 0x06017BE5 RID: 97253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BE5")]
		[Address(RVA = "0xFFD290", Offset = "0xFFBE90", VA = "0x180FFD290")]
		public List<LocalBattleCache.RecentBattleRecord> GetRecentBattleRecords()
		{
			return null;
		}

		// Token: 0x06017BE6 RID: 97254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BE6")]
		[Address(RVA = "0xFFD320", Offset = "0xFFBF20", VA = "0x180FFD320")]
		public void RecordLastBattle(LocalBattleCache.RecentBattleRecord record)
		{
		}

		// Token: 0x06017BE7 RID: 97255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017BE7")]
		[Address(RVA = "0xFFDAD0", Offset = "0xFFC6D0", VA = "0x180FFDAD0")]
		private LocalBattleCache.RecentBattleCache _EnsureRecentBattleCache()
		{
			return null;
		}

		// Token: 0x0401CAAA RID: 117418
		[Token(Token = "0x401CAAA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ListSet<StageType> TYPES_TO_RECORD;

		// Token: 0x0401CAAB RID: 117419
		[Token(Token = "0x401CAAB")]
		[FieldOffset(Offset = "0x10")]
		private LocalBattleCache.MemCache m_cache;

		// Token: 0x0401CAAC RID: 117420
		[Token(Token = "0x401CAAC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401CAAD RID: 117421
		[Token(Token = "0x401CAAD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureMemCache;

		// Token: 0x0401CAAE RID: 117422
		[Token(Token = "0x401CAAE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UILocalCache_GetStageCache;

		// Token: 0x0401CAAF RID: 117423
		[Token(Token = "0x401CAAF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UILocalCache_SaveStageCache;

		// Token: 0x0401CAB0 RID: 117424
		[Token(Token = "0x401CAB0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UILocalCache_GetZoneCache;

		// Token: 0x0401CAB1 RID: 117425
		[Token(Token = "0x401CAB1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UILocalCache_SaveZoneCache;

		// Token: 0x0401CAB2 RID: 117426
		[Token(Token = "0x401CAB2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetRecentBattleRecords;

		// Token: 0x0401CAB3 RID: 117427
		[Token(Token = "0x401CAB3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RecordLastBattle;

		// Token: 0x0401CAB4 RID: 117428
		[Token(Token = "0x401CAB4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EnsureRecentBattleCache;

		// Token: 0x02003ACF RID: 15055
		[Token(Token = "0x2003ACF")]
		private class MemCache : IHotfixable
		{
			// Token: 0x06017BE9 RID: 97257 RVA: 0x00097E00 File Offset: 0x00096000
			[Token(Token = "0x6017BE9")]
			[Address(RVA = "0x1000730", Offset = "0xFFF330", VA = "0x181000730")]
			public bool IsValid(string uid, string sessionId)
			{
				return default(bool);
			}

			// Token: 0x06017BEA RID: 97258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BEA")]
			[Address(RVA = "0x10007F0", Offset = "0xFFF3F0", VA = "0x1810007F0")]
			public MemCache()
			{
			}

			// Token: 0x0401CAB5 RID: 117429
			[Token(Token = "0x401CAB5")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x0401CAB6 RID: 117430
			[Token(Token = "0x401CAB6")]
			[FieldOffset(Offset = "0x18")]
			public string sessionId;

			// Token: 0x0401CAB7 RID: 117431
			[Token(Token = "0x401CAB7")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, StageViewModel.LocalCache> stageCache;

			// Token: 0x0401CAB8 RID: 117432
			[Token(Token = "0x401CAB8")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, ZoneViewModel.LocalCache> zoneCache;

			// Token: 0x0401CAB9 RID: 117433
			[Token(Token = "0x401CAB9")]
			[FieldOffset(Offset = "0x30")]
			public LocalBattleCache.RecentBattleCache recentBattleCache;

			// Token: 0x0401CABA RID: 117434
			[Token(Token = "0x401CABA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsValid;

			// Token: 0x0401CABB RID: 117435
			[Token(Token = "0x401CABB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003AD0 RID: 15056
		[Token(Token = "0x2003AD0")]
		public struct RecentBattleRecord
		{
			// Token: 0x06017BEB RID: 97259 RVA: 0x00097E18 File Offset: 0x00096018
			[Token(Token = "0x6017BEB")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0401CABC RID: 117436
			[Token(Token = "0x401CABC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LocalBattleCache.RecentBattleRecord EMPTY;

			// Token: 0x0401CABD RID: 117437
			[Token(Token = "0x401CABD")]
			[FieldOffset(Offset = "0x0")]
			public string stageId;

			// Token: 0x0401CABE RID: 117438
			[Token(Token = "0x401CABE")]
			[FieldOffset(Offset = "0x8")]
			[JsonConverter(typeof(StringEnumConverter))]
			public StageType type;
		}

		// Token: 0x02003AD1 RID: 15057
		[Token(Token = "0x2003AD1")]
		private class RecentBattleCache : IHotfixable
		{
			// Token: 0x06017BED RID: 97261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BED")]
			[Address(RVA = "0x10045C0", Offset = "0x10031C0", VA = "0x1810045C0")]
			public void RecordLastBattle(LocalBattleCache.RecentBattleRecord newRecord)
			{
			}

			// Token: 0x06017BEE RID: 97262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BEE")]
			[Address(RVA = "0x10048F0", Offset = "0x10034F0", VA = "0x1810048F0")]
			public RecentBattleCache()
			{
			}

			// Token: 0x0401CABF RID: 117439
			[Token(Token = "0x401CABF")]
			[JsonIgnore]
			private const int MAX_RECORDS_EACH_TYPE = 3;

			// Token: 0x0401CAC0 RID: 117440
			[Token(Token = "0x401CAC0")]
			[FieldOffset(Offset = "0x10")]
			[JsonIgnore]
			private Dictionary<StageType, int> m_typeCountMap;

			// Token: 0x0401CAC1 RID: 117441
			[Token(Token = "0x401CAC1")]
			[FieldOffset(Offset = "0x18")]
			public List<LocalBattleCache.RecentBattleRecord> records;

			// Token: 0x0401CAC2 RID: 117442
			[Token(Token = "0x401CAC2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_RecordLastBattle;

			// Token: 0x0401CAC3 RID: 117443
			[Token(Token = "0x401CAC3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
