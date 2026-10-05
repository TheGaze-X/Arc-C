using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	public class CriFsWebInstaller : CriDisposable
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00003C2C File Offset: 0x00001E2C
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007B")]
		public static bool isInitialized
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x36FDF20", Offset = "0x36FCB20", VA = "0x1836FDF20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x36FDFA0", Offset = "0x36FCBA0", VA = "0x1836FDFA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00003C44 File Offset: 0x00001E44
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007C")]
		public static bool isCrcEnabled
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x36FDEE0", Offset = "0x36FCAE0", VA = "0x1836FDEE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x36FDF60", Offset = "0x36FCB60", VA = "0x1836FDF60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00003C5C File Offset: 0x00001E5C
		[Token(Token = "0x1700007D")]
		public static CriFsWebInstaller.ModuleConfig defaultModuleConfig
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x36FDE80", Offset = "0x36FCA80", VA = "0x1836FDE80")]
			get
			{
				return default(CriFsWebInstaller.ModuleConfig);
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x36FD770", Offset = "0x36FC370", VA = "0x1836FD770")]
		public CriFsWebInstaller()
		{
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x36FCF70", Offset = "0x36FBB70", VA = "0x1836FCF70", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x36FCB20", Offset = "0x36FB720", VA = "0x1836FCB20", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x36FCA60", Offset = "0x36FB660", VA = "0x1836FCA60")]
		public void Copy(string url, string dstPath)
		{
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x36FD6B0", Offset = "0x36FC2B0", VA = "0x1836FD6B0")]
		public void Stop()
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00003C74 File Offset: 0x00001E74
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x36FD0E0", Offset = "0x36FBCE0", VA = "0x1836FD0E0")]
		public CriFsWebInstaller.StatusInfo GetStatusInfo()
		{
			return default(CriFsWebInstaller.StatusInfo);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00003C8C File Offset: 0x00001E8C
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x36FCFD0", Offset = "0x36FBBD0", VA = "0x1836FCFD0")]
		public bool GetCRC32(out uint ret_val)
		{
			return default(bool);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x36FD1F0", Offset = "0x36FBDF0", VA = "0x1836FD1F0")]
		public static void InitializeModule(CriFsWebInstaller.ModuleConfig config)
		{
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x36FD060", Offset = "0x36FBC60", VA = "0x1836FD060")]
		private static Type GetCriFsWebInstallerCurlExpansionClass()
		{
			return null;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x36FCDD0", Offset = "0x36FB9D0", VA = "0x1836FCDD0")]
		public static void FinalizeModule()
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x36FCD60", Offset = "0x36FB960", VA = "0x1836FCD60")]
		public static void ExecuteMain()
		{
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00003CA4 File Offset: 0x00001EA4
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x36FD5F0", Offset = "0x36FC1F0", VA = "0x1836FD5F0")]
		public static bool SetRequestHeader(string field, string value)
		{
			return default(bool);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x36FCB80", Offset = "0x36FB780", VA = "0x1836FCB80")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x060006CF RID: 1743
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x36FDC50", Offset = "0x36FC850", VA = "0x1836FDC50")]
		[PreserveSig]
		private static extern int criFsWebInstaller_Initialize([In] ref CriFsWebInstaller.ModuleConfig config);

		// Token: 0x060006D0 RID: 1744
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x36FDAC0", Offset = "0x36FC6C0", VA = "0x1836FDAC0")]
		[PreserveSig]
		private static extern int criFsWebInstaller_Finalize();

		// Token: 0x060006D1 RID: 1745
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x36FCD60", Offset = "0x36FB960", VA = "0x1836FCD60")]
		[PreserveSig]
		private static extern int criFsWebInstaller_ExecuteMain();

		// Token: 0x060006D2 RID: 1746
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x36FD9C0", Offset = "0x36FC5C0", VA = "0x1836FD9C0")]
		[PreserveSig]
		private static extern int criFsWebInstaller_Create(out IntPtr installer);

		// Token: 0x060006D3 RID: 1747
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x36FDA40", Offset = "0x36FC640", VA = "0x1836FDA40")]
		[PreserveSig]
		private static extern int criFsWebInstaller_Destroy(IntPtr installer);

		// Token: 0x060006D4 RID: 1748
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x36FD8F0", Offset = "0x36FC4F0", VA = "0x1836FD8F0")]
		[PreserveSig]
		private static extern int criFsWebInstaller_Copy(IntPtr installer, string url, string dstPath);

		// Token: 0x060006D5 RID: 1749
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x36FDE00", Offset = "0x36FCA00", VA = "0x1836FDE00")]
		[PreserveSig]
		private static extern int criFsWebInstaller_Stop(IntPtr installer);

		// Token: 0x060006D6 RID: 1750
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x36FDBC0", Offset = "0x36FC7C0", VA = "0x1836FDBC0")]
		[PreserveSig]
		private static extern int criFsWebInstaller_GetStatusInfo(IntPtr installer, out CriFsWebInstaller.StatusInfo status);

		// Token: 0x060006D7 RID: 1751
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x36FDB30", Offset = "0x36FC730", VA = "0x1836FDB30")]
		[PreserveSig]
		private static extern int criFsWebInstaller_GetCRC32(IntPtr installer, out uint crc32);

		// Token: 0x060006D8 RID: 1752
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x36FDD40", Offset = "0x36FC940", VA = "0x1836FDD40")]
		[PreserveSig]
		private static extern int criFsWebInstaller_SetRequestHeader(string field, string value);

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		public const int InvalidHttpStatusCode = -1;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		public const long InvalidContentsSize = -1L;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr handle;

		// Token: 0x020000CC RID: 204
		[Token(Token = "0x20000CC")]
		public enum Status
		{
			// Token: 0x040003A3 RID: 931
			[Token(Token = "0x40003A3")]
			Stop,
			// Token: 0x040003A4 RID: 932
			[Token(Token = "0x40003A4")]
			Busy,
			// Token: 0x040003A5 RID: 933
			[Token(Token = "0x40003A5")]
			Complete,
			// Token: 0x040003A6 RID: 934
			[Token(Token = "0x40003A6")]
			Error
		}

		// Token: 0x020000CD RID: 205
		[Token(Token = "0x20000CD")]
		public enum Error
		{
			// Token: 0x040003A8 RID: 936
			[Token(Token = "0x40003A8")]
			None,
			// Token: 0x040003A9 RID: 937
			[Token(Token = "0x40003A9")]
			Timeout,
			// Token: 0x040003AA RID: 938
			[Token(Token = "0x40003AA")]
			Memory,
			// Token: 0x040003AB RID: 939
			[Token(Token = "0x40003AB")]
			LocalFs,
			// Token: 0x040003AC RID: 940
			[Token(Token = "0x40003AC")]
			DNS,
			// Token: 0x040003AD RID: 941
			[Token(Token = "0x40003AD")]
			Connection,
			// Token: 0x040003AE RID: 942
			[Token(Token = "0x40003AE")]
			SSL,
			// Token: 0x040003AF RID: 943
			[Token(Token = "0x40003AF")]
			HTTP,
			// Token: 0x040003B0 RID: 944
			[Token(Token = "0x40003B0")]
			Internal
		}

		// Token: 0x020000CE RID: 206
		[Token(Token = "0x20000CE")]
		public struct StatusInfo
		{
			// Token: 0x040003B1 RID: 945
			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CriFsWebInstaller.Status status;

			// Token: 0x040003B2 RID: 946
			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public CriFsWebInstaller.Error error;

			// Token: 0x040003B3 RID: 947
			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int httpStatusCode;

			// Token: 0x040003B4 RID: 948
			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long contentsSize;

			// Token: 0x040003B5 RID: 949
			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public long receivedSize;
		}

		// Token: 0x020000CF RID: 207
		[Token(Token = "0x20000CF")]
		public struct ModuleConfig
		{
			// Token: 0x040003B6 RID: 950
			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint numInstallers;

			// Token: 0x040003B7 RID: 951
			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string proxyHost;

			// Token: 0x040003B8 RID: 952
			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ushort proxyPort;

			// Token: 0x040003B9 RID: 953
			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string userAgent;

			// Token: 0x040003BA RID: 954
			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint inactiveTimeoutSec;

			// Token: 0x040003BB RID: 955
			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool allowInsecureSSL;

			// Token: 0x040003BC RID: 956
			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			public bool crcEnabled;

			// Token: 0x040003BD RID: 957
			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			public CriFsWebInstaller.ModulePlatformConfig platformConfig;
		}

		// Token: 0x020000D0 RID: 208
		[Token(Token = "0x20000D0")]
		public struct ModulePlatformConfig
		{
			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00003CBC File Offset: 0x00001EBC
			[Token(Token = "0x1700007E")]
			public static CriFsWebInstaller.ModulePlatformConfig defaultConfig
			{
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
				get
				{
					return default(CriFsWebInstaller.ModulePlatformConfig);
				}
			}

			// Token: 0x040003BE RID: 958
			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte reserved;
		}
	}
}
