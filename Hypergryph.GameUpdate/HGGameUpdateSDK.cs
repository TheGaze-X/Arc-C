using System;
using System.Threading;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public static class HGGameUpdateSDK
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000001")]
		private static IHGGameUpdateSDK gameUpdateSDK
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x4A08B80", Offset = "0x4A07780", VA = "0x184A08B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4A08600", Offset = "0x4A07200", VA = "0x184A08600")]
		public static int Init(string config, IHGGameUpdateSDKCallback callback)
		{
			return 0;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4A08390", Offset = "0x4A06F90", VA = "0x184A08390")]
		public static void GetLatestGame()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4A08C30", Offset = "0x4A07830", VA = "0x184A08C30")]
		public static void runInMainTread(Action action)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4A08A80", Offset = "0x4A07680", VA = "0x184A08A80")]
		public static long Update(int updateType, bool useMobileData)
		{
			return 0L;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4A080A0", Offset = "0x4A06CA0", VA = "0x184A080A0")]
		public static int EnableMobileData(long taskId)
		{
			return 0;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4A08540", Offset = "0x4A07140", VA = "0x184A08540")]
		public static int GetTaskState(long taskId)
		{
			return 0;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4A08900", Offset = "0x4A07500", VA = "0x184A08900")]
		public static int Pause(long taskId)
		{
			return 0;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4A08960", Offset = "0x4A07560", VA = "0x184A08960")]
		public static int Resume(long taskId)
		{
			return 0;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4A07F00", Offset = "0x4A06B00", VA = "0x184A07F00")]
		public static int CancelAndClear(long taskId)
		{
			return 0;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4A07F60", Offset = "0x4A06B60", VA = "0x184A07F60")]
		public static int Cancel(long taskId)
		{
			return 0;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4A088A0", Offset = "0x4A074A0", VA = "0x184A088A0")]
		public static int Install(long taskId)
		{
			return 0;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x4A07FC0", Offset = "0x4A06BC0", VA = "0x184A07FC0")]
		public static int ClearAllTask()
		{
			return 0;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4A08100", Offset = "0x4A06D00", VA = "0x184A08100")]
		public static long GetDownloadSpeed(long taskId)
		{
			return 0L;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4A08160", Offset = "0x4A06D60", VA = "0x184A08160")]
		public static long GetDownloadedSize(long taskId)
		{
			return 0L;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x4A085A0", Offset = "0x4A071A0", VA = "0x184A085A0")]
		public static long GetTotalDownloadSize(long taskId)
		{
			return 0L;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x4A082A0", Offset = "0x4A06EA0", VA = "0x184A082A0")]
		public static long GetEstimatedDownloadSize(int updateType)
		{
			return 0L;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4A08A20", Offset = "0x4A07620", VA = "0x184A08A20")]
		public static int SetNotificationTitle(string titleConfig)
		{
			return 0;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x4A089C0", Offset = "0x4A075C0", VA = "0x184A089C0")]
		public static int SetEnv(string env)
		{
			return 0;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x4A081C0", Offset = "0x4A06DC0", VA = "0x184A081C0")]
		public static string GetEnv()
		{
			return null;
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x0")]
		private static IHGGameUpdateSDK s_gu;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x8")]
		private static IHGGameUpdateSDKCallback m_callback;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x10")]
		private static SynchronizationContext mainThreadContext;
	}
}
