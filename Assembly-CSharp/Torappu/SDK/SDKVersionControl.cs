using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.SDK
{
	// Token: 0x02001502 RID: 5378
	[Token(Token = "0x2001502")]
	public static class SDKVersionControl
	{
		// Token: 0x06007BA9 RID: 31657 RVA: 0x000371E8 File Offset: 0x000353E8
		[Token(Token = "0x6007BA9")]
		[Address(RVA = "0x27451F0", Offset = "0x2743DF0", VA = "0x1827451F0")]
		public static bool CheckIfHGSDKV2()
		{
			return default(bool);
		}

		// Token: 0x06007BAA RID: 31658 RVA: 0x00037200 File Offset: 0x00035400
		[Token(Token = "0x6007BAA")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public static bool IsTestMode()
		{
			return default(bool);
		}

		// Token: 0x06007BAB RID: 31659 RVA: 0x00037218 File Offset: 0x00035418
		[Token(Token = "0x6007BAB")]
		[Address(RVA = "0x2745180", Offset = "0x2743D80", VA = "0x182745180")]
		public static bool CheckIfHGDownload()
		{
			return default(bool);
		}

		// Token: 0x06007BAC RID: 31660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BAC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void TestOnly_ToggleLocalHGSDKVersion()
		{
		}

		// Token: 0x06007BAD RID: 31661 RVA: 0x00037230 File Offset: 0x00035430
		[Token(Token = "0x6007BAD")]
		[Address(RVA = "0x2745380", Offset = "0x2743F80", VA = "0x182745380")]
		private static SDKVersionControl.DevConfig _LoadDevConfig([Optional] SDKVersionControl.DevConfig? preferred)
		{
			return default(SDKVersionControl.DevConfig);
		}

		// Token: 0x06007BAE RID: 31662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BAE")]
		[Address(RVA = "0x2745560", Offset = "0x2744160", VA = "0x182745560")]
		private static void _SaveDevConfig(SDKVersionControl.DevConfig config)
		{
		}

		// Token: 0x06007BAF RID: 31663 RVA: 0x00037248 File Offset: 0x00035448
		[Token(Token = "0x6007BAF")]
		[Address(RVA = "0x2745310", Offset = "0x2743F10", VA = "0x182745310")]
		public static SDKVersionControl.EnvType GetSDKEnv()
		{
			return SDKVersionControl.EnvType.DEV;
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BB0")]
		[Address(RVA = "0x2745260", Offset = "0x2743E60", VA = "0x182745260")]
		public static string GetSDKEnvDesc()
		{
			return null;
		}

		// Token: 0x04007A21 RID: 31265
		[Token(Token = "0x4007A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool? s_useHGSDKV2;

		// Token: 0x02001503 RID: 5379
		[Token(Token = "0x2001503")]
		public enum EnvType
		{
			// Token: 0x04007A23 RID: 31267
			[Token(Token = "0x4007A23")]
			DEV,
			// Token: 0x04007A24 RID: 31268
			[Token(Token = "0x4007A24")]
			PROD
		}

		// Token: 0x02001504 RID: 5380
		[Token(Token = "0x2001504")]
		private struct DevConfig
		{
			// Token: 0x04007A25 RID: 31269
			[Token(Token = "0x4007A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly SDKVersionControl.DevConfig DEFAULT;

			// Token: 0x04007A26 RID: 31270
			[Token(Token = "0x4007A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool HGSDKV2;
		}
	}
}
