using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200650A RID: 25866
	[Token(Token = "0x200650A")]
	public class ArtMagazineLocalCache : Singleton<ArtMagazineLocalCache>
	{
		// Token: 0x060252E6 RID: 152294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252E6")]
		[Address(RVA = "0x203C3D0", Offset = "0x203AFD0", VA = "0x18203C3D0")]
		private ArtMagazineLocalCache()
		{
		}

		// Token: 0x060252E7 RID: 152295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60252E7")]
		[Address(RVA = "0x203C200", Offset = "0x203AE00", VA = "0x18203C200")]
		private ArtMagazineLocalCache.CacheData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x060252E8 RID: 152296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60252E8")]
		[Address(RVA = "0x203BFB0", Offset = "0x203ABB0", VA = "0x18203BFB0")]
		private ArtMagazineLocalCache.CacheData _EnsureData()
		{
			return null;
		}

		// Token: 0x060252E9 RID: 152297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252E9")]
		[Address(RVA = "0x203C340", Offset = "0x203AF40", VA = "0x18203C340")]
		private void _SaveData(ArtMagazineLocalCache.CacheData data)
		{
		}

		// Token: 0x060252EA RID: 152298 RVA: 0x000C6E10 File Offset: 0x000C5010
		[Token(Token = "0x60252EA")]
		[Address(RVA = "0x203BDB0", Offset = "0x203A9B0", VA = "0x18203BDB0")]
		public bool GetTemplateSaveAnimPlayed(string templateId)
		{
			return default(bool);
		}

		// Token: 0x060252EB RID: 152299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252EB")]
		[Address(RVA = "0x203BE70", Offset = "0x203AA70", VA = "0x18203BE70")]
		public void MarkTemplateSaveAnimPlayed(string templateId)
		{
		}

		// Token: 0x04034263 RID: 213603
		[Token(Token = "0x4034263")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<ArtMagazineLocalCache.CacheData> m_cacheData;

		// Token: 0x04034264 RID: 213604
		[Token(Token = "0x4034264")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04034265 RID: 213605
		[Token(Token = "0x4034265")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x04034266 RID: 213606
		[Token(Token = "0x4034266")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureData;

		// Token: 0x04034267 RID: 213607
		[Token(Token = "0x4034267")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x04034268 RID: 213608
		[Token(Token = "0x4034268")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetTemplateSaveAnimPlayed;

		// Token: 0x04034269 RID: 213609
		[Token(Token = "0x4034269")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_MarkTemplateSaveAnimPlayed;

		// Token: 0x0200650B RID: 25867
		[Token(Token = "0x200650B")]
		private class CacheData
		{
			// Token: 0x060252EC RID: 152300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60252EC")]
			[Address(RVA = "0x203FD20", Offset = "0x203E920", VA = "0x18203FD20")]
			public CacheData()
			{
			}

			// Token: 0x0403426A RID: 213610
			[Token(Token = "0x403426A")]
			[FieldOffset(Offset = "0x10")]
			public HashSet<string> settedTemplateIdSet;
		}
	}
}
