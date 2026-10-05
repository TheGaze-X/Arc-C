using System;
using Il2CppDummyDll;

namespace YostarSDKV2
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public static class YostarPcSdkFacadeProvider
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		public static IYostarPcSdkFacade Instance
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x51A3B0", Offset = "0x518FB0", VA = "0x18051A3B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x51A350", Offset = "0x518F50", VA = "0x18051A350")]
		internal static void SetForTesting(IYostarPcSdkFacade facade)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x51A2D0", Offset = "0x518ED0", VA = "0x18051A2D0")]
		internal static void Reset()
		{
		}

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x0")]
		private static IYostarPcSdkFacade s_instance;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x8")]
		private static IYostarPcSdkFacade s_overrideForTesting;
	}
}
