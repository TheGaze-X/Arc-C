using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Network
{
	// Token: 0x0200152B RID: 5419
	[Token(Token = "0x200152B")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class NetworkUtil
	{
		// Token: 0x06007C5B RID: 31835 RVA: 0x00037488 File Offset: 0x00035688
		[Token(Token = "0x6007C5B")]
		[Address(RVA = "0x273E040", Offset = "0x273CC40", VA = "0x18273E040")]
		public static PlatformKey GetPlatformKey()
		{
			return PlatformKey.IOS;
		}

		// Token: 0x06007C5C RID: 31836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C5C")]
		[Address(RVA = "0x273D890", Offset = "0x273C490", VA = "0x18273D890")]
		public static string ConvertLatestUrl(string url)
		{
			return null;
		}

		// Token: 0x06007C5D RID: 31837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C5D")]
		[Address(RVA = "0x273DB60", Offset = "0x273C760", VA = "0x18273DB60")]
		public static string ConvertUrlByPlatform(string url)
		{
			return null;
		}

		// Token: 0x06007C5E RID: 31838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C5E")]
		[Address(RVA = "0x273DC10", Offset = "0x273C810", VA = "0x18273DC10")]
		public static string ConvertUrlByStoreId(string url)
		{
			return null;
		}

		// Token: 0x06007C5F RID: 31839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C5F")]
		[Address(RVA = "0x273DED0", Offset = "0x273CAD0", VA = "0x18273DED0")]
		public static string GetDownloadUrlForCurrentPlatform(Networker.Configuration networkConfig)
		{
			return null;
		}

		// Token: 0x06007C60 RID: 31840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C60")]
		[Address(RVA = "0x273E190", Offset = "0x273CD90", VA = "0x18273E190")]
		public static void UpdateServiceLicenseVersionIfNeeded()
		{
		}

		// Token: 0x06007C61 RID: 31841 RVA: 0x000374A0 File Offset: 0x000356A0
		[Token(Token = "0x6007C61")]
		[Address(RVA = "0x273D740", Offset = "0x273C340", VA = "0x18273D740")]
		public static bool CheckServiceLicenseVersionOutOfDate()
		{
			return default(bool);
		}

		// Token: 0x06007C62 RID: 31842 RVA: 0x000374B8 File Offset: 0x000356B8
		[Token(Token = "0x6007C62")]
		[Address(RVA = "0x273E110", Offset = "0x273CD10", VA = "0x18273E110")]
		public static bool IsServerBusinessError(long responseCode)
		{
			return default(bool);
		}

		// Token: 0x06007C63 RID: 31843 RVA: 0x000374D0 File Offset: 0x000356D0
		[Token(Token = "0x6007C63")]
		[Address(RVA = "0x273E090", Offset = "0x273CC90", VA = "0x18273E090")]
		public static bool IsServerAuthTimeout(long responseCode)
		{
			return default(bool);
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C64")]
		[Address(RVA = "0x273DD60", Offset = "0x273C960", VA = "0x18273DD60")]
		public static string CreateRemoteConfigUrl(out bool useDynGameConfig)
		{
			return null;
		}

		// Token: 0x06007C65 RID: 31845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C65")]
		[Address(RVA = "0x273DCE0", Offset = "0x273C8E0", VA = "0x18273DCE0")]
		public static string CreateNetworkConfigUrl()
		{
			return null;
		}

		// Token: 0x04007C3C RID: 31804
		[Token(Token = "0x4007C3C")]
		[FieldOffset(Offset = "0x0")]
		private static uint s_deviceHash;

		// Token: 0x04007C3D RID: 31805
		[Token(Token = "0x4007C3D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPlatformKey;

		// Token: 0x04007C3E RID: 31806
		[Token(Token = "0x4007C3E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ConvertLatestUrl;

		// Token: 0x04007C3F RID: 31807
		[Token(Token = "0x4007C3F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ConvertUrlByPlatform;

		// Token: 0x04007C40 RID: 31808
		[Token(Token = "0x4007C40")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConvertUrlByStoreId;

		// Token: 0x04007C41 RID: 31809
		[Token(Token = "0x4007C41")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDownloadUrlForCurrentPlatform;

		// Token: 0x04007C42 RID: 31810
		[Token(Token = "0x4007C42")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateServiceLicenseVersionIfNeeded;

		// Token: 0x04007C43 RID: 31811
		[Token(Token = "0x4007C43")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckServiceLicenseVersionOutOfDate;

		// Token: 0x04007C44 RID: 31812
		[Token(Token = "0x4007C44")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsServerBusinessError;

		// Token: 0x04007C45 RID: 31813
		[Token(Token = "0x4007C45")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsServerAuthTimeout;

		// Token: 0x04007C46 RID: 31814
		[Token(Token = "0x4007C46")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CreateRemoteConfigUrl;

		// Token: 0x04007C47 RID: 31815
		[Token(Token = "0x4007C47")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CreateNetworkConfigUrl;
	}
}
