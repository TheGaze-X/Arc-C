using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AF9 RID: 27385
	[Token(Token = "0x2006AF9")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ActArchiveLocalCacheHandler
	{
		// Token: 0x06027287 RID: 160391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027287")]
		[Address(RVA = "0x224D600", Offset = "0x224C200", VA = "0x18224D600")]
		private static MemUserDataStore.Data<ActArchiveLocalCache> _GetMemCache()
		{
			return null;
		}

		// Token: 0x06027288 RID: 160392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027288")]
		[Address(RVA = "0x224D490", Offset = "0x224C090", VA = "0x18224D490")]
		private static ActArchiveLocalCache _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x06027289 RID: 160393 RVA: 0x000CD8C0 File Offset: 0x000CBAC0
		[Token(Token = "0x6027289")]
		[Address(RVA = "0x224CC60", Offset = "0x224B860", VA = "0x18224CC60")]
		public static int GetParamFromCache(string key, int defaultParam = 0)
		{
			return 0;
		}

		// Token: 0x0602728A RID: 160394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602728A")]
		[Address(RVA = "0x224CB60", Offset = "0x224B760", VA = "0x18224CB60")]
		public static string GetParamFromCache(string key, string defaultParam)
		{
			return null;
		}

		// Token: 0x0602728B RID: 160395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602728B")]
		[Address(RVA = "0x224D190", Offset = "0x224BD90", VA = "0x18224D190")]
		public static void SaveParamToCache(string key, int value)
		{
		}

		// Token: 0x0602728C RID: 160396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602728C")]
		[Address(RVA = "0x224D0B0", Offset = "0x224BCB0", VA = "0x18224D0B0")]
		public static void SaveParamToCache(string key, string value)
		{
		}

		// Token: 0x0602728D RID: 160397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602728D")]
		[Address(RVA = "0x224CB10", Offset = "0x224B710", VA = "0x18224CB10")]
		public static ActArchiveLocalCache GetActArchiveLocalCache()
		{
			return null;
		}

		// Token: 0x0602728E RID: 160398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602728E")]
		[Address(RVA = "0x224D020", Offset = "0x224BC20", VA = "0x18224D020")]
		public static void SaveActArchiveLocalCache(ActArchiveLocalCache actArchiveLocalCache)
		{
		}

		// Token: 0x0602728F RID: 160399 RVA: 0x000CD8D8 File Offset: 0x000CBAD8
		[Token(Token = "0x602728F")]
		[Address(RVA = "0x224CEC0", Offset = "0x224BAC0", VA = "0x18224CEC0")]
		public static int GetParam(string key, int defaultParam = 0)
		{
			return 0;
		}

		// Token: 0x06027290 RID: 160400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027290")]
		[Address(RVA = "0x224D380", Offset = "0x224BF80", VA = "0x18224D380")]
		public static void SaveParam(string key, int value)
		{
		}

		// Token: 0x06027291 RID: 160401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027291")]
		[Address(RVA = "0x224CD60", Offset = "0x224B960", VA = "0x18224CD60")]
		public static string GetParam(string key, string defaultParam)
		{
			return null;
		}

		// Token: 0x06027292 RID: 160402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027292")]
		[Address(RVA = "0x224D270", Offset = "0x224BE70", VA = "0x18224D270")]
		public static void SaveParam(string key, string value)
		{
		}

		// Token: 0x0403764A RID: 226890
		[Token(Token = "0x403764A")]
		[FieldOffset(Offset = "0x0")]
		private static MemUserDataStore.Data<ActArchiveLocalCache> s_memCache;

		// Token: 0x0403764B RID: 226891
		[Token(Token = "0x403764B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetMemCache;

		// Token: 0x0403764C RID: 226892
		[Token(Token = "0x403764C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x0403764D RID: 226893
		[Token(Token = "0x403764D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetParamFromCache;

		// Token: 0x0403764E RID: 226894
		[Token(Token = "0x403764E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_GetParamFromCache;

		// Token: 0x0403764F RID: 226895
		[Token(Token = "0x403764F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SaveParamToCache;

		// Token: 0x04037650 RID: 226896
		[Token(Token = "0x4037650")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_SaveParamToCache;

		// Token: 0x04037651 RID: 226897
		[Token(Token = "0x4037651")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActArchiveLocalCache;

		// Token: 0x04037652 RID: 226898
		[Token(Token = "0x4037652")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SaveActArchiveLocalCache;

		// Token: 0x04037653 RID: 226899
		[Token(Token = "0x4037653")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetParam;

		// Token: 0x04037654 RID: 226900
		[Token(Token = "0x4037654")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SaveParam;

		// Token: 0x04037655 RID: 226901
		[Token(Token = "0x4037655")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix1_GetParam;

		// Token: 0x04037656 RID: 226902
		[Token(Token = "0x4037656")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix1_SaveParam;
	}
}
