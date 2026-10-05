using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public static class CriFsPlugin
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[Token(Token = "0x17000078")]
		public static bool isInitialized
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x36FA3D0", Offset = "0x36F8FD0", VA = "0x1836FA3D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x36FA020", Offset = "0x36F8C20", VA = "0x1836FA020")]
		public static void SetConfigParameters(int num_loaders, int num_binders, int num_installers, int argInstallBufferSize, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check)
		{
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x36FA140", Offset = "0x36F8D40", VA = "0x1836FA140")]
		public static void SetReadDeviceEnabled(int deviceId, bool enabled)
		{
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetConfigAdditionalParameters_EDITOR(int additionalLoaders)
		{
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetConfigAdditionalParameters_ANDROID(int device_read_bps)
		{
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetMemoryFileSystemThreadPriorityExperimentalAndroid(int prio)
		{
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SetDataDecompressionThreadPriorityExperimentalAndroid(int prio)
		{
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x36F9DF0", Offset = "0x36F89F0", VA = "0x1836F9DF0")]
		public static void InitializeLibrary()
		{
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00003BFC File Offset: 0x00001DFC
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x36F9F80", Offset = "0x36F8B80", VA = "0x1836F9F80")]
		public static bool IsLibraryInitialized()
		{
			return default(bool);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x36F9BB0", Offset = "0x36F87B0", VA = "0x1836F9BB0")]
		public static void FinalizeLibrary()
		{
		}

		// Token: 0x060006A3 RID: 1699
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x36F9AF0", Offset = "0x36F86F0", VA = "0x1836F9AF0")]
		[PreserveSig]
		private static extern void CRIWAREACF30831(int num_loaders, int num_binders, int num_installers, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check);

		// Token: 0x060006A4 RID: 1700
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x36F9A80", Offset = "0x36F8680", VA = "0x1836F9A80")]
		[PreserveSig]
		private static extern void CRIWARE8BE8B0FD();

		// Token: 0x060006A5 RID: 1701
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x36F9A10", Offset = "0x36F8610", VA = "0x1836F9A10")]
		[PreserveSig]
		public static extern bool CRIWARE7F5CF698();

		// Token: 0x060006A6 RID: 1702
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x36F9930", Offset = "0x36F8530", VA = "0x1836F9930")]
		[PreserveSig]
		private static extern void CRIWARE47645696();

		// Token: 0x060006A7 RID: 1703
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x36F99A0", Offset = "0x36F85A0", VA = "0x1836F99A0")]
		[PreserveSig]
		public static extern uint CRIWARE73E26CCB();

		// Token: 0x060006A8 RID: 1704
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x36FA2D0", Offset = "0x36F8ED0", VA = "0x1836FA2D0")]
		[PreserveSig]
		public static extern uint criFsLoader_GetRetryCount();

		// Token: 0x060006A9 RID: 1705
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x36FA340", Offset = "0x36F8F40", VA = "0x1836FA340")]
		[PreserveSig]
		private static extern int criFs_SetReadDeviceEnabled(int device_id, bool enabled);

		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int initializationCount;

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static bool isConfigured;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int defaultInstallBufferSize;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int installBufferSize;
	}
}
