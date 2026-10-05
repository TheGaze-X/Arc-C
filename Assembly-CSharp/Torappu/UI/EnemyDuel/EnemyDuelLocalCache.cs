using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F5E RID: 20318
	[Token(Token = "0x2004F5E")]
	public class EnemyDuelLocalCache : Singleton<EnemyDuelLocalCache>
	{
		// Token: 0x0601E3EC RID: 123884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3EC")]
		[Address(RVA = "0x1805340", Offset = "0x1803F40", VA = "0x181805340")]
		private EnemyDuelLocalCache()
		{
		}

		// Token: 0x0601E3ED RID: 123885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E3ED")]
		[Address(RVA = "0x1805040", Offset = "0x1803C40", VA = "0x181805040")]
		private EnemyDuelLocalCache.ActData _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x0601E3EE RID: 123886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E3EE")]
		[Address(RVA = "0x1804E80", Offset = "0x1803A80", VA = "0x181804E80")]
		private EnemyDuelLocalCache.ActData _EnsureActCacheData(string actId)
		{
			return null;
		}

		// Token: 0x0601E3EF RID: 123887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E3EF")]
		[Address(RVA = "0x1805180", Offset = "0x1803D80", VA = "0x181805180")]
		private EnemyDuelLocalCache.DataInAct _GetDataInAct(string actId)
		{
			return null;
		}

		// Token: 0x0601E3F0 RID: 123888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3F0")]
		[Address(RVA = "0x18052B0", Offset = "0x1803EB0", VA = "0x1818052B0")]
		private void _SaveData(EnemyDuelLocalCache.ActData data)
		{
		}

		// Token: 0x0601E3F1 RID: 123889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E3F1")]
		[Address(RVA = "0x1804A50", Offset = "0x1803650", VA = "0x181804A50")]
		public string GetLastUseEmoticonId(string actId)
		{
			return null;
		}

		// Token: 0x0601E3F2 RID: 123890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3F2")]
		[Address(RVA = "0x1804BD0", Offset = "0x18037D0", VA = "0x181804BD0")]
		public void SaveLastUseEmoticonThemeId(string actId, string emoticonThemeId)
		{
		}

		// Token: 0x0402858B RID: 165259
		[Token(Token = "0x402858B")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<EnemyDuelLocalCache.ActData> m_memData;

		// Token: 0x0402858C RID: 165260
		[Token(Token = "0x402858C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402858D RID: 165261
		[Token(Token = "0x402858D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x0402858E RID: 165262
		[Token(Token = "0x402858E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureActCacheData;

		// Token: 0x0402858F RID: 165263
		[Token(Token = "0x402858F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetDataInAct;

		// Token: 0x04028590 RID: 165264
		[Token(Token = "0x4028590")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SaveData;

		// Token: 0x04028591 RID: 165265
		[Token(Token = "0x4028591")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetLastUseEmoticonId;

		// Token: 0x04028592 RID: 165266
		[Token(Token = "0x4028592")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SaveLastUseEmoticonThemeId;

		// Token: 0x02004F5F RID: 20319
		[Token(Token = "0x2004F5F")]
		private class DataInAct
		{
			// Token: 0x0601E3F3 RID: 123891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E3F3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DataInAct()
			{
			}

			// Token: 0x04028593 RID: 165267
			[Token(Token = "0x4028593")]
			[FieldOffset(Offset = "0x10")]
			public string lastUseEmoticonThemeId;
		}

		// Token: 0x02004F60 RID: 20320
		[Token(Token = "0x2004F60")]
		private class ActData
		{
			// Token: 0x0601E3F4 RID: 123892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E3F4")]
			[Address(RVA = "0x17F6220", Offset = "0x17F4E20", VA = "0x1817F6220")]
			public ActData()
			{
			}

			// Token: 0x04028594 RID: 165268
			[Token(Token = "0x4028594")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04028595 RID: 165269
			[Token(Token = "0x4028595")]
			[FieldOffset(Offset = "0x18")]
			public EnemyDuelLocalCache.DataInAct dataInAct;
		}
	}
}
