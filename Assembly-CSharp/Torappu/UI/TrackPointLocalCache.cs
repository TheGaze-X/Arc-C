using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003845 RID: 14405
	[Token(Token = "0x2003845")]
	public class TrackPointLocalCache : Singleton<TrackPointLocalCache>
	{
		// Token: 0x06016D32 RID: 93490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D32")]
		[Address(RVA = "0xF3C260", Offset = "0xF3AE60", VA = "0x180F3C260")]
		private TrackPointLocalCache()
		{
		}

		// Token: 0x06016D33 RID: 93491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016D33")]
		[Address(RVA = "0xF3C140", Offset = "0xF3AD40", VA = "0x180F3C140")]
		private MemUserDataStore.Data<TrackPointLocalCache.CacheData> _GetMemCache()
		{
			return null;
		}

		// Token: 0x06016D34 RID: 93492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D34")]
		[Address(RVA = "0xF3B950", Offset = "0xF3A550", VA = "0x180F3B950")]
		public static void LogTrace(string trace, TrackPointCacheGroup group)
		{
		}

		// Token: 0x06016D35 RID: 93493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D35")]
		[Address(RVA = "0xF3B530", Offset = "0xF3A130", VA = "0x180F3B530")]
		public static void BatchLogTrace(IEnumerator<KeyValuePair<string, TrackPointCacheGroup>> traceIter)
		{
		}

		// Token: 0x06016D36 RID: 93494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D36")]
		[Address(RVA = "0xF3B7B0", Offset = "0xF3A3B0", VA = "0x180F3B7B0")]
		public static void Consume(string trace, TrackPointCacheGroup group)
		{
		}

		// Token: 0x06016D37 RID: 93495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D37")]
		[Address(RVA = "0xF3B450", Offset = "0xF3A050", VA = "0x180F3B450")]
		public static void BatchConsume(IEnumerator<KeyValuePair<string, TrackPointCacheGroup>> traceIter)
		{
		}

		// Token: 0x06016D38 RID: 93496 RVA: 0x00093198 File Offset: 0x00091398
		[Token(Token = "0x6016D38")]
		[Address(RVA = "0xF3B610", Offset = "0xF3A210", VA = "0x180F3B610")]
		public static bool CheckTrace(string trace, TrackPointCacheGroup group)
		{
			return default(bool);
		}

		// Token: 0x06016D39 RID: 93497 RVA: 0x000931B0 File Offset: 0x000913B0
		[Token(Token = "0x6016D39")]
		[Address(RVA = "0xF3BBF0", Offset = "0xF3A7F0", VA = "0x180F3BBF0")]
		private static bool _ActionLogTrace(TrackPointLocalCache.CacheData data, string trace, TrackPointCacheGroup group)
		{
			return default(bool);
		}

		// Token: 0x06016D3A RID: 93498 RVA: 0x000931C8 File Offset: 0x000913C8
		[Token(Token = "0x6016D3A")]
		[Address(RVA = "0xF3BAF0", Offset = "0xF3A6F0", VA = "0x180F3BAF0")]
		private static bool _ActionConsumeTrace(TrackPointLocalCache.CacheData data, string trace, TrackPointCacheGroup group)
		{
			return default(bool);
		}

		// Token: 0x06016D3B RID: 93499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D3B")]
		[Address(RVA = "0xF3BDD0", Offset = "0xF3A9D0", VA = "0x180F3BDD0")]
		private void _ApplyTraceOnData(IEnumerator<KeyValuePair<string, TrackPointCacheGroup>> traceIter, Func<TrackPointLocalCache.CacheData, string, TrackPointCacheGroup, bool> action)
		{
		}

		// Token: 0x06016D3C RID: 93500 RVA: 0x000931E0 File Offset: 0x000913E0
		[Token(Token = "0x6016D3C")]
		[Address(RVA = "0xF3C010", Offset = "0xF3AC10", VA = "0x180F3C010")]
		public bool _CheckTrace(string trace, TrackPointCacheGroup group)
		{
			return default(bool);
		}

		// Token: 0x0401B864 RID: 112740
		[Token(Token = "0x401B864")]
		private const int VALID_TOKEN = 1;

		// Token: 0x0401B865 RID: 112741
		[Token(Token = "0x401B865")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<TrackPointLocalCache.CacheData> m_memCache;

		// Token: 0x0401B866 RID: 112742
		[Token(Token = "0x401B866")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B867 RID: 112743
		[Token(Token = "0x401B867")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetMemCache;

		// Token: 0x0401B868 RID: 112744
		[Token(Token = "0x401B868")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LogTrace;

		// Token: 0x0401B869 RID: 112745
		[Token(Token = "0x401B869")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BatchLogTrace;

		// Token: 0x0401B86A RID: 112746
		[Token(Token = "0x401B86A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Consume;

		// Token: 0x0401B86B RID: 112747
		[Token(Token = "0x401B86B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_BatchConsume;

		// Token: 0x0401B86C RID: 112748
		[Token(Token = "0x401B86C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckTrace;

		// Token: 0x0401B86D RID: 112749
		[Token(Token = "0x401B86D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ActionLogTrace;

		// Token: 0x0401B86E RID: 112750
		[Token(Token = "0x401B86E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ActionConsumeTrace;

		// Token: 0x0401B86F RID: 112751
		[Token(Token = "0x401B86F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ApplyTraceOnData;

		// Token: 0x0401B870 RID: 112752
		[Token(Token = "0x401B870")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckTrace;

		// Token: 0x02003846 RID: 14406
		[Token(Token = "0x2003846")]
		[Serializable]
		private class CacheData
		{
			// Token: 0x06016D3D RID: 93501 RVA: 0x000931F8 File Offset: 0x000913F8
			[Token(Token = "0x6016D3D")]
			[Address(RVA = "0xF39B10", Offset = "0xF38710", VA = "0x180F39B10")]
			public bool LogTrace(string trace, TrackPointCacheGroup group)
			{
				return default(bool);
			}

			// Token: 0x06016D3E RID: 93502 RVA: 0x00093210 File Offset: 0x00091410
			[Token(Token = "0x6016D3E")]
			[Address(RVA = "0xF39A70", Offset = "0xF38670", VA = "0x180F39A70")]
			public bool ConsumeTrace(string trace, TrackPointCacheGroup group)
			{
				return default(bool);
			}

			// Token: 0x06016D3F RID: 93503 RVA: 0x00093228 File Offset: 0x00091428
			[Token(Token = "0x6016D3F")]
			[Address(RVA = "0xF399D0", Offset = "0xF385D0", VA = "0x180F399D0")]
			public bool CheckTrace(string trace, TrackPointCacheGroup group)
			{
				return default(bool);
			}

			// Token: 0x06016D40 RID: 93504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016D40")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CacheData()
			{
			}

			// Token: 0x0401B871 RID: 112753
			[Token(Token = "0x401B871")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			private Dictionary<int, HashSet<string>> m_traceMap;
		}
	}
}
