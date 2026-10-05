using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A4E RID: 27214
	[Token(Token = "0x2006A4E")]
	public class MixStoryLocalCache : Singleton<MixStoryLocalCache>
	{
		// Token: 0x06026E54 RID: 159316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E54")]
		[Address(RVA = "0x21FC180", Offset = "0x21FAD80", VA = "0x1821FC180")]
		private MixStoryLocalCache()
		{
		}

		// Token: 0x06026E55 RID: 159317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E55")]
		[Address(RVA = "0x21FBDC0", Offset = "0x21FA9C0", VA = "0x1821FBDC0")]
		public string GetLastVisitedStorySet()
		{
			return null;
		}

		// Token: 0x06026E56 RID: 159318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E56")]
		[Address(RVA = "0x21FBED0", Offset = "0x21FAAD0", VA = "0x1821FBED0")]
		public void SaveLastVisitedStorySet(string lastVisitedStorySet)
		{
		}

		// Token: 0x06026E57 RID: 159319 RVA: 0x000CC9C0 File Offset: 0x000CABC0
		[Token(Token = "0x6026E57")]
		[Address(RVA = "0x21FBE50", Offset = "0x21FAA50", VA = "0x1821FBE50")]
		public StageMixStoryOverallView.OverallDisplayFeature GetOverallDisplayFeature()
		{
			return StageMixStoryOverallView.OverallDisplayFeature.NONE;
		}

		// Token: 0x06026E58 RID: 159320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E58")]
		[Address(RVA = "0x21FBF70", Offset = "0x21FAB70", VA = "0x1821FBF70")]
		public void SaveOverallDisplayFeature(StageMixStoryOverallView.OverallDisplayFeature overallDisplayFeature)
		{
		}

		// Token: 0x06026E59 RID: 159321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E59")]
		[Address(RVA = "0x21FC000", Offset = "0x21FAC00", VA = "0x1821FC000")]
		private MixStoryLocalCache.Data _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x06026E5A RID: 159322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E5A")]
		[Address(RVA = "0x21FC0F0", Offset = "0x21FACF0", VA = "0x1821FC0F0")]
		private void _SaveData(MixStoryLocalCache.Data data)
		{
		}

		// Token: 0x04037015 RID: 225301
		[Token(Token = "0x4037015")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<MixStoryLocalCache.Data> m_memData;

		// Token: 0x04037016 RID: 225302
		[Token(Token = "0x4037016")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037017 RID: 225303
		[Token(Token = "0x4037017")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetLastVisitedStorySet;

		// Token: 0x04037018 RID: 225304
		[Token(Token = "0x4037018")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SaveLastVisitedStorySet;

		// Token: 0x04037019 RID: 225305
		[Token(Token = "0x4037019")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetOverallDisplayFeature;

		// Token: 0x0403701A RID: 225306
		[Token(Token = "0x403701A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SaveOverallDisplayFeature;

		// Token: 0x0403701B RID: 225307
		[Token(Token = "0x403701B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x0403701C RID: 225308
		[Token(Token = "0x403701C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x02006A4F RID: 27215
		[Token(Token = "0x2006A4F")]
		public class Data
		{
			// Token: 0x06026E5B RID: 159323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026E5B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Data()
			{
			}

			// Token: 0x0403701D RID: 225309
			[Token(Token = "0x403701D")]
			[FieldOffset(Offset = "0x10")]
			public string lastVisitedStorySet;

			// Token: 0x0403701E RID: 225310
			[Token(Token = "0x403701E")]
			[FieldOffset(Offset = "0x18")]
			public StageMixStoryOverallView.OverallDisplayFeature overallDisplayFeature;
		}
	}
}
