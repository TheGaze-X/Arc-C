using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x0200477F RID: 18303
	[Token(Token = "0x200477F")]
	public class RecalRuneLocalCache : Singleton<RecalRuneLocalCache>
	{
		// Token: 0x0601BB3E RID: 113470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB3E")]
		[Address(RVA = "0x1507F20", Offset = "0x1506B20", VA = "0x181507F20")]
		private RecalRuneLocalCache()
		{
		}

		// Token: 0x0601BB3F RID: 113471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB3F")]
		[Address(RVA = "0x1507B20", Offset = "0x1506720", VA = "0x181507B20")]
		public List<string> LoadSelectedRunes(string stageId)
		{
			return null;
		}

		// Token: 0x0601BB40 RID: 113472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB40")]
		[Address(RVA = "0x1507C00", Offset = "0x1506800", VA = "0x181507C00")]
		public void SaveSelectedRunes(string stageId, List<string> selectedRunes)
		{
		}

		// Token: 0x0601BB41 RID: 113473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BB41")]
		[Address(RVA = "0x1507D50", Offset = "0x1506950", VA = "0x181507D50")]
		private RecalRuneLocalCache.RecalRuneData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x0601BB42 RID: 113474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB42")]
		[Address(RVA = "0x1507E90", Offset = "0x1506A90", VA = "0x181507E90")]
		private void _SaveData(RecalRuneLocalCache.RecalRuneData data)
		{
		}

		// Token: 0x0402402F RID: 147503
		[Token(Token = "0x402402F")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<RecalRuneLocalCache.RecalRuneData> m_memData;

		// Token: 0x04024030 RID: 147504
		[Token(Token = "0x4024030")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04024031 RID: 147505
		[Token(Token = "0x4024031")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadSelectedRunes;

		// Token: 0x04024032 RID: 147506
		[Token(Token = "0x4024032")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SaveSelectedRunes;

		// Token: 0x04024033 RID: 147507
		[Token(Token = "0x4024033")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x04024034 RID: 147508
		[Token(Token = "0x4024034")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x02004780 RID: 18304
		[Token(Token = "0x2004780")]
		private class RecalRuneData
		{
			// Token: 0x0601BB43 RID: 113475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BB43")]
			[Address(RVA = "0x15079D0", Offset = "0x15065D0", VA = "0x1815079D0")]
			public RecalRuneData()
			{
			}

			// Token: 0x04024035 RID: 147509
			[Token(Token = "0x4024035")]
			[FieldOffset(Offset = "0x10")]
			public readonly Dictionary<string, List<string>> selectedRunesOfStages;
		}
	}
}
