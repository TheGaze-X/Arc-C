using System;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class HGGameUpdateSDKPluginDefault : IHGGameUpdateSDK
	{
		// Token: 0x06000035 RID: 53 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x4A07C20", Offset = "0x4A06820", VA = "0x184A07C20", Slot = "4")]
		public int Init(string config)
		{
			return 0;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x4A07910", Offset = "0x4A06510", VA = "0x184A07910", Slot = "5")]
		public void GetLatestGame(Action<string> onResult)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x4A07EA0", Offset = "0x4A06AA0", VA = "0x184A07EA0", Slot = "6")]
		public long Update(int updateType, bool useMobileData)
		{
			return 0L;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x4A076E0", Offset = "0x4A062E0", VA = "0x184A076E0", Slot = "7")]
		public int EnableMobileData(long taskId)
		{
			return 0;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x4A07B60", Offset = "0x4A06760", VA = "0x184A07B60", Slot = "8")]
		public int GetTaskState(long taskId)
		{
			return 0;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x4A07CE0", Offset = "0x4A068E0", VA = "0x184A07CE0", Slot = "9")]
		public int Pause(long taskId)
		{
			return 0;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x4A07D40", Offset = "0x4A06940", VA = "0x184A07D40", Slot = "10")]
		public int Resume(long taskId)
		{
			return 0;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x4A075C0", Offset = "0x4A061C0", VA = "0x184A075C0", Slot = "11")]
		public int CancelAndClear(long taskId)
		{
			return 0;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x4A07620", Offset = "0x4A06220", VA = "0x184A07620", Slot = "12")]
		public int Cancel(long taskId)
		{
			return 0;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x4A07C80", Offset = "0x4A06880", VA = "0x184A07C80", Slot = "13")]
		public int Install(long taskId)
		{
			return 0;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x4A07680", Offset = "0x4A06280", VA = "0x184A07680", Slot = "14")]
		public int ClearAllTask()
		{
			return 0;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4A07740", Offset = "0x4A06340", VA = "0x184A07740", Slot = "15")]
		public long GetDownloadSpeed(long taskId)
		{
			return 0L;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x4A077A0", Offset = "0x4A063A0", VA = "0x184A077A0", Slot = "16")]
		public long GetDownloadedSize(long taskId)
		{
			return 0L;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x4A07BC0", Offset = "0x4A067C0", VA = "0x184A07BC0", Slot = "17")]
		public long GetTotalDownloadSize(long taskId)
		{
			return 0L;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x4A078B0", Offset = "0x4A064B0", VA = "0x184A078B0", Slot = "18")]
		public long GetEstimatedDownloadSize(int updateType)
		{
			return 0L;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x4A07E40", Offset = "0x4A06A40", VA = "0x184A07E40", Slot = "19")]
		public int SetNotificationTitle(string titleConfig)
		{
			return 0;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4A07DA0", Offset = "0x4A069A0", VA = "0x184A07DA0", Slot = "20")]
		public int SetEnv(string env)
		{
			return 0;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4A07800", Offset = "0x4A06400", VA = "0x184A07800", Slot = "21")]
		public string GetEnv()
		{
			return null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HGGameUpdateSDKPluginDefault()
		{
		}
	}
}
