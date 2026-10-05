using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006845 RID: 26693
	[Token(Token = "0x2006845")]
	public class SixStarLocalCache : Singleton<SixStarLocalCache>
	{
		// Token: 0x0602637E RID: 156542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602637E")]
		[Address(RVA = "0x2149720", Offset = "0x2148320", VA = "0x182149720")]
		private SixStarLocalCache()
		{
		}

		// Token: 0x0602637F RID: 156543 RVA: 0x000CA668 File Offset: 0x000C8868
		[Token(Token = "0x602637F")]
		[Address(RVA = "0x21492B0", Offset = "0x2147EB0", VA = "0x1821492B0")]
		public bool GetIsPreviewSelectSixStar(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06026380 RID: 156544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026380")]
		[Address(RVA = "0x2149380", Offset = "0x2147F80", VA = "0x182149380")]
		public void SaveIsSelectSixStar(string zoneId, bool isPreviewSelectedSixStar)
		{
		}

		// Token: 0x06026381 RID: 156545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026381")]
		[Address(RVA = "0x2149550", Offset = "0x2148150", VA = "0x182149550")]
		private SixStarLocalCache.SixStarLocalMemData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x06026382 RID: 156546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026382")]
		[Address(RVA = "0x2149690", Offset = "0x2148290", VA = "0x182149690")]
		private void _SaveData(SixStarLocalCache.SixStarLocalMemData data)
		{
		}

		// Token: 0x04035DF1 RID: 220657
		[Token(Token = "0x4035DF1")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<SixStarLocalCache.SixStarLocalMemData> m_memData;

		// Token: 0x04035DF2 RID: 220658
		[Token(Token = "0x4035DF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04035DF3 RID: 220659
		[Token(Token = "0x4035DF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetIsPreviewSelectSixStar;

		// Token: 0x04035DF4 RID: 220660
		[Token(Token = "0x4035DF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SaveIsSelectSixStar;

		// Token: 0x04035DF5 RID: 220661
		[Token(Token = "0x4035DF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x04035DF6 RID: 220662
		[Token(Token = "0x4035DF6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x02006846 RID: 26694
		[Token(Token = "0x2006846")]
		private class SixStarLocalMemData
		{
			// Token: 0x06026383 RID: 156547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026383")]
			[Address(RVA = "0x2149790", Offset = "0x2148390", VA = "0x182149790")]
			public SixStarLocalMemData()
			{
			}

			// Token: 0x04035DF7 RID: 220663
			[Token(Token = "0x4035DF7")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, SixStarLocalCache.SingleZoneSixStarLocalMemData> memDataDict;
		}

		// Token: 0x02006847 RID: 26695
		[Token(Token = "0x2006847")]
		private class SingleZoneSixStarLocalMemData
		{
			// Token: 0x06026384 RID: 156548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026384")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SingleZoneSixStarLocalMemData()
			{
			}

			// Token: 0x04035DF8 RID: 220664
			[Token(Token = "0x4035DF8")]
			[FieldOffset(Offset = "0x10")]
			public bool isPreviewSelectedSixStar;
		}
	}
}
