using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048BA RID: 18618
	[Token(Token = "0x20048BA")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class MiniActTrialLocalCacheHandler
	{
		// Token: 0x0601C166 RID: 115046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C166")]
		[Address(RVA = "0x159A860", Offset = "0x1599460", VA = "0x18159A860")]
		private static MemUserDataStore.Data<MiniActTrialLocalCache> _GetMemCache()
		{
			return null;
		}

		// Token: 0x0601C167 RID: 115047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C167")]
		[Address(RVA = "0x159A740", Offset = "0x1599340", VA = "0x18159A740")]
		private static MiniActTrialLocalCache _EnsureMemCacheData()
		{
			return null;
		}

		// Token: 0x0601C168 RID: 115048 RVA: 0x000A72C8 File Offset: 0x000A54C8
		[Token(Token = "0x601C168")]
		[Address(RVA = "0x159A510", Offset = "0x1599110", VA = "0x18159A510")]
		public static bool GetStatusFromCache(string key, bool defaultParam = false)
		{
			return default(bool);
		}

		// Token: 0x0601C169 RID: 115049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C169")]
		[Address(RVA = "0x159A6A0", Offset = "0x15992A0", VA = "0x18159A6A0")]
		public static void SetStatusToCache(string key, bool value)
		{
		}

		// Token: 0x0601C16A RID: 115050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C16A")]
		[Address(RVA = "0x159A610", Offset = "0x1599210", VA = "0x18159A610")]
		public static void SaveLocalCache()
		{
		}

		// Token: 0x0601C16B RID: 115051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C16B")]
		[Address(RVA = "0x159A4A0", Offset = "0x15990A0", VA = "0x18159A4A0")]
		public static string GenMiniActTrialVisitKey(string actId)
		{
			return null;
		}

		// Token: 0x04024B47 RID: 150343
		[Token(Token = "0x4024B47")]
		public const string MINI_ACT_TRIAL_VISIT = "mini_act_trial_visit_{0}";

		// Token: 0x04024B48 RID: 150344
		[Token(Token = "0x4024B48")]
		[FieldOffset(Offset = "0x0")]
		private static MemUserDataStore.Data<MiniActTrialLocalCache> s_memCache;

		// Token: 0x04024B49 RID: 150345
		[Token(Token = "0x4024B49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetMemCache;

		// Token: 0x04024B4A RID: 150346
		[Token(Token = "0x4024B4A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureMemCacheData;

		// Token: 0x04024B4B RID: 150347
		[Token(Token = "0x4024B4B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetStatusFromCache;

		// Token: 0x04024B4C RID: 150348
		[Token(Token = "0x4024B4C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetStatusToCache;

		// Token: 0x04024B4D RID: 150349
		[Token(Token = "0x4024B4D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SaveLocalCache;

		// Token: 0x04024B4E RID: 150350
		[Token(Token = "0x4024B4E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GenMiniActTrialVisitKey;
	}
}
