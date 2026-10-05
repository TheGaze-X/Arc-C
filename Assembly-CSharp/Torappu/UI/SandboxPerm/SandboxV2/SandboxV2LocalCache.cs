using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043AC RID: 17324
	[Token(Token = "0x20043AC")]
	public class SandboxV2LocalCache : Singleton<SandboxV2LocalCache>
	{
		// Token: 0x0601A94F RID: 108879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A94F")]
		[Address(RVA = "0x13ABC90", Offset = "0x13AA890", VA = "0x1813ABC90")]
		private SandboxV2LocalCache()
		{
		}

		// Token: 0x0601A950 RID: 108880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A950")]
		[Address(RVA = "0x13AB5F0", Offset = "0x13AA1F0", VA = "0x1813AB5F0")]
		private SandboxV2LocalCache.CacheData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x0601A951 RID: 108881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A951")]
		[Address(RVA = "0x13AB8C0", Offset = "0x13AA4C0", VA = "0x1813AB8C0")]
		private SandboxV2LocalCache.DataInTopic _EnsureTopicData(SandboxV2LocalCache.CacheData cacheData, string topicId)
		{
			return null;
		}

		// Token: 0x0601A952 RID: 108882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A952")]
		[Address(RVA = "0x13AB730", Offset = "0x13AA330", VA = "0x1813AB730")]
		private SandboxV2LocalCache.DataInSingleGame _EnsureSingleGameData(SandboxV2LocalCache.CacheData cacheData, string topicId, long timestamp)
		{
			return null;
		}

		// Token: 0x0601A953 RID: 108883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A953")]
		[Address(RVA = "0x13ABC00", Offset = "0x13AA800", VA = "0x1813ABC00")]
		private void _SaveData(SandboxV2LocalCache.CacheData data)
		{
		}

		// Token: 0x0601A954 RID: 108884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A954")]
		[Address(RVA = "0x13ABAC0", Offset = "0x13AA6C0", VA = "0x1813ABAC0")]
		private SandboxV2LocalCache.DataInTopic _GetDataInTopic(string topicId)
		{
			return null;
		}

		// Token: 0x0601A955 RID: 108885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A955")]
		[Address(RVA = "0x13AB1B0", Offset = "0x13A9DB0", VA = "0x1813AB1B0")]
		public SandboxV2LocalCache.SandboxV2SquadFocusCacheModel LoadSquadFocusCacheModel(string topicId, long timestamp)
		{
			return null;
		}

		// Token: 0x0601A956 RID: 108886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A956")]
		[Address(RVA = "0x13AB370", Offset = "0x13A9F70", VA = "0x1813AB370")]
		public void SaveSquadFocusCacheModel(string topicId, long timestamp, SandboxV2LocalCache.SandboxV2SquadFocusCacheModel focusCacheModel)
		{
		}

		// Token: 0x04021DEC RID: 138732
		[Token(Token = "0x4021DEC")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<SandboxV2LocalCache.CacheData> m_memData;

		// Token: 0x04021DED RID: 138733
		[Token(Token = "0x4021DED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04021DEE RID: 138734
		[Token(Token = "0x4021DEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x04021DEF RID: 138735
		[Token(Token = "0x4021DEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureTopicData;

		// Token: 0x04021DF0 RID: 138736
		[Token(Token = "0x4021DF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnsureSingleGameData;

		// Token: 0x04021DF1 RID: 138737
		[Token(Token = "0x4021DF1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x04021DF2 RID: 138738
		[Token(Token = "0x4021DF2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetDataInTopic;

		// Token: 0x04021DF3 RID: 138739
		[Token(Token = "0x4021DF3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadSquadFocusCacheModel;

		// Token: 0x04021DF4 RID: 138740
		[Token(Token = "0x4021DF4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SaveSquadFocusCacheModel;

		// Token: 0x020043AD RID: 17325
		[Token(Token = "0x20043AD")]
		public class SandboxV2SquadFocusCacheModel
		{
			// Token: 0x0601A957 RID: 108887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A957")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SandboxV2SquadFocusCacheModel()
			{
			}

			// Token: 0x04021DF5 RID: 138741
			[Token(Token = "0x4021DF5")]
			[FieldOffset(Offset = "0x10")]
			public int squadSelectIndex;
		}

		// Token: 0x020043AE RID: 17326
		[Token(Token = "0x20043AE")]
		private class DataInSingleGame
		{
			// Token: 0x0601A958 RID: 108888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A958")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInSingleGame()
			{
			}

			// Token: 0x04021DF6 RID: 138742
			[Token(Token = "0x4021DF6")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2LocalCache.SandboxV2SquadFocusCacheModel focusModel;
		}

		// Token: 0x020043AF RID: 17327
		[Token(Token = "0x20043AF")]
		private class DataInTopic
		{
			// Token: 0x0601A959 RID: 108889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A959")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInTopic()
			{
			}

			// Token: 0x04021DF7 RID: 138743
			[Token(Token = "0x4021DF7")]
			[FieldOffset(Offset = "0x10")]
			public long timestamp;

			// Token: 0x04021DF8 RID: 138744
			[Token(Token = "0x4021DF8")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2LocalCache.DataInSingleGame dataInSingleGame;
		}

		// Token: 0x020043B0 RID: 17328
		[Token(Token = "0x20043B0")]
		private class CacheData
		{
			// Token: 0x0601A95A RID: 108890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A95A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CacheData()
			{
			}

			// Token: 0x04021DF9 RID: 138745
			[Token(Token = "0x4021DF9")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, SandboxV2LocalCache.DataInTopic> topicCacheDataMap;
		}
	}
}
