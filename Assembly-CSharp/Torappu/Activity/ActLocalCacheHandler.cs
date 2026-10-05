using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D4F RID: 27983
	[Token(Token = "0x2006D4F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ActLocalCacheHandler
	{
		// Token: 0x06027E20 RID: 163360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E20")]
		[Address(RVA = "0x22EEF50", Offset = "0x22EDB50", VA = "0x1822EEF50")]
		private static MemUserDataStore.Data<ActivityLocalCache> _GetMemCache()
		{
			return null;
		}

		// Token: 0x06027E21 RID: 163361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E21")]
		[Address(RVA = "0x22EEDE0", Offset = "0x22ED9E0", VA = "0x1822EEDE0")]
		private static ActivityLocalCache _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x06027E22 RID: 163362 RVA: 0x000CFC48 File Offset: 0x000CDE48
		[Token(Token = "0x6027E22")]
		[Address(RVA = "0x22EE5B0", Offset = "0x22ED1B0", VA = "0x1822EE5B0")]
		public static int GetParamFromCache(string key, int defaultParam = 0)
		{
			return 0;
		}

		// Token: 0x06027E23 RID: 163363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E23")]
		[Address(RVA = "0x22EE4B0", Offset = "0x22ED0B0", VA = "0x1822EE4B0")]
		public static string GetParamFromCache(string key, string defaultParam)
		{
			return null;
		}

		// Token: 0x06027E24 RID: 163364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E24")]
		[Address(RVA = "0x22EEA00", Offset = "0x22ED600", VA = "0x1822EEA00")]
		public static void SaveParamToCache(string key, int value)
		{
		}

		// Token: 0x06027E25 RID: 163365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E25")]
		[Address(RVA = "0x22EEAE0", Offset = "0x22ED6E0", VA = "0x1822EEAE0")]
		public static void SaveParamToCache(string key, string value)
		{
		}

		// Token: 0x06027E26 RID: 163366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E26")]
		[Address(RVA = "0x22EE460", Offset = "0x22ED060", VA = "0x1822EE460")]
		public static ActivityLocalCache GetActLocalCache()
		{
			return null;
		}

		// Token: 0x06027E27 RID: 163367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E27")]
		[Address(RVA = "0x22EE970", Offset = "0x22ED570", VA = "0x1822EE970")]
		public static void SaveActLocalCache(ActivityLocalCache activityLocalCache)
		{
		}

		// Token: 0x06027E28 RID: 163368 RVA: 0x000CFC60 File Offset: 0x000CDE60
		[Token(Token = "0x6027E28")]
		[Address(RVA = "0x22EE6B0", Offset = "0x22ED2B0", VA = "0x1822EE6B0")]
		public static int GetParam(string key, int defaultParam = 0)
		{
			return 0;
		}

		// Token: 0x06027E29 RID: 163369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E29")]
		[Address(RVA = "0x22EEBC0", Offset = "0x22ED7C0", VA = "0x1822EEBC0")]
		public static void SaveParam(string key, int value)
		{
		}

		// Token: 0x06027E2A RID: 163370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E2A")]
		[Address(RVA = "0x22EE810", Offset = "0x22ED410", VA = "0x1822EE810")]
		public static string GetParam(string key, string defaultParam)
		{
			return null;
		}

		// Token: 0x06027E2B RID: 163371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E2B")]
		[Address(RVA = "0x22EECD0", Offset = "0x22ED8D0", VA = "0x1822EECD0")]
		public static void SaveParam(string key, string value)
		{
		}

		// Token: 0x04038887 RID: 231559
		[Token(Token = "0x4038887")]
		[FieldOffset(Offset = "0x0")]
		private static MemUserDataStore.Data<ActivityLocalCache> s_memCache;

		// Token: 0x04038888 RID: 231560
		[Token(Token = "0x4038888")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetMemCache;

		// Token: 0x04038889 RID: 231561
		[Token(Token = "0x4038889")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x0403888A RID: 231562
		[Token(Token = "0x403888A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetParamFromCache;

		// Token: 0x0403888B RID: 231563
		[Token(Token = "0x403888B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_GetParamFromCache;

		// Token: 0x0403888C RID: 231564
		[Token(Token = "0x403888C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SaveParamToCache;

		// Token: 0x0403888D RID: 231565
		[Token(Token = "0x403888D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_SaveParamToCache;

		// Token: 0x0403888E RID: 231566
		[Token(Token = "0x403888E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActLocalCache;

		// Token: 0x0403888F RID: 231567
		[Token(Token = "0x403888F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SaveActLocalCache;

		// Token: 0x04038890 RID: 231568
		[Token(Token = "0x4038890")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetParam;

		// Token: 0x04038891 RID: 231569
		[Token(Token = "0x4038891")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SaveParam;

		// Token: 0x04038892 RID: 231570
		[Token(Token = "0x4038892")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix1_GetParam;

		// Token: 0x04038893 RID: 231571
		[Token(Token = "0x4038893")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix1_SaveParam;
	}
}
