using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public static class Environment
	{
		// Token: 0x06000F56 RID: 3926 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F56")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		internal static string GetResourceString(string key)
		{
			return null;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x4D352D0", Offset = "0x4D33ED0", VA = "0x184D352D0")]
		internal static string GetResourceString(string key, params object[] values)
		{
			return null;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x4D35180", Offset = "0x4D33D80", VA = "0x184D35180")]
		internal static string GetResourceStringEncodingName(int codePage)
		{
			return null;
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000155")]
		public static string CurrentDirectory
		{
			[Token(Token = "0x6000F59")]
			[Address(RVA = "0x4D35CC0", Offset = "0x4D348C0", VA = "0x184D35CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x0000D050 File Offset: 0x0000B250
		[Token(Token = "0x17000156")]
		public static int CurrentManagedThreadId
		{
			[Token(Token = "0x6000F5A")]
			[Address(RVA = "0x4D35CD0", Offset = "0x4D348D0", VA = "0x184D35CD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000F5B RID: 3931
		[Token(Token = "0x17000157")]
		public static extern bool HasShutdownStarted { [Token(Token = "0x6000F5B")] [Address(RVA = "0x4D35D00", Offset = "0x4D34900", VA = "0x184D35D00")] [MethodImpl(4096)] get; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000F5C RID: 3932
		[Token(Token = "0x17000158")]
		public static extern string MachineName { [Token(Token = "0x6000F5C")] [Address(RVA = "0x4D35D60", Offset = "0x4D34960", VA = "0x184D35D60")] [MethodImpl(4096)] get; }

		// Token: 0x06000F5D RID: 3933
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x4D35150", Offset = "0x4D33D50", VA = "0x184D35150")]
		[MethodImpl(4096)]
		private static extern string GetNewLine();

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000159")]
		public static string NewLine
		{
			[Token(Token = "0x6000F5E")]
			[Address(RVA = "0x4D35D70", Offset = "0x4D34970", VA = "0x184D35D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000F5F RID: 3935
		[Token(Token = "0x1700015A")]
		internal static extern System.PlatformID Platform { [Token(Token = "0x6000F5F")] [Address(RVA = "0x4D35EE0", Offset = "0x4D34AE0", VA = "0x184D35EE0")] [System.Runtime.CompilerServices.CompilerGenerated] [MethodImpl(4096)] get; }

		// Token: 0x06000F60 RID: 3936
		[Token(Token = "0x6000F60")]
		[Address(RVA = "0x4D35160", Offset = "0x4D33D60", VA = "0x184D35160")]
		[MethodImpl(4096)]
		internal static extern string GetOSVersionString();

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700015B")]
		public static System.OperatingSystem OSVersion
		{
			[Token(Token = "0x6000F61")]
			[Address(RVA = "0x4D35DF0", Offset = "0x4D349F0", VA = "0x184D35DF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x4D34870", Offset = "0x4D33470", VA = "0x184D34870")]
		internal static System.Version CreateVersionFromString(string info)
		{
			return null;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700015C")]
		public static string StackTrace
		{
			[Token(Token = "0x6000F63")]
			[Address(RVA = "0x4D35F00", Offset = "0x4D34B00", VA = "0x184D35F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700015D")]
		public static string SystemDirectory
		{
			[Token(Token = "0x6000F64")]
			[Address(RVA = "0x4D35F80", Offset = "0x4D34B80", VA = "0x184D35F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000F65 RID: 3941
		[Token(Token = "0x1700015E")]
		public static extern int TickCount { [Token(Token = "0x6000F65")] [Address(RVA = "0x4D361E0", Offset = "0x4D34DE0", VA = "0x184D361E0")] [MethodImpl(4096)] get; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700015F")]
		public static string UserDomainName
		{
			[Token(Token = "0x6000F66")]
			[Address(RVA = "0x4D35D60", Offset = "0x4D34960", VA = "0x184D35D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000F67 RID: 3943
		[Token(Token = "0x17000160")]
		public static extern string UserName { [Token(Token = "0x6000F67")] [Address(RVA = "0x4D361F0", Offset = "0x4D34DF0", VA = "0x184D361F0")] [MethodImpl(4096)] get; }

		// Token: 0x06000F68 RID: 3944
		[Token(Token = "0x6000F68")]
		[Address(RVA = "0x4D34A40", Offset = "0x4D33640", VA = "0x184D34A40")]
		[MethodImpl(4096)]
		public static extern void Exit(int exitCode);

		// Token: 0x06000F69 RID: 3945 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x4D34A50", Offset = "0x4D33650", VA = "0x184D34A50")]
		public static string ExpandEnvironmentVariables(string name)
		{
			return null;
		}

		// Token: 0x06000F6A RID: 3946
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x4D34E90", Offset = "0x4D33A90", VA = "0x184D34E90")]
		[MethodImpl(4096)]
		public static extern string[] GetCommandLineArgs();

		// Token: 0x06000F6B RID: 3947
		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x4D362A0", Offset = "0x4D34EA0", VA = "0x184D362A0")]
		[MethodImpl(4096)]
		internal static extern string internalGetEnvironmentVariable_native(System.IntPtr variable);

		// Token: 0x06000F6C RID: 3948 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x4D36200", Offset = "0x4D34E00", VA = "0x184D36200")]
		internal static string internalGetEnvironmentVariable(string variable)
		{
			return null;
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x4D34EB0", Offset = "0x4D33AB0", VA = "0x184D34EB0")]
		public static string GetEnvironmentVariable(string variable)
		{
			return null;
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0x4D34EC0", Offset = "0x4D33AC0", VA = "0x184D34EC0")]
		private static System.Collections.Hashtable GetEnvironmentVariablesNoCase()
		{
			return null;
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0x4D34FC0", Offset = "0x4D33BC0", VA = "0x184D34FC0")]
		public static System.Collections.IDictionary GetEnvironmentVariables()
		{
			return null;
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F70")]
		[Address(RVA = "0x4D350B0", Offset = "0x4D33CB0", VA = "0x184D350B0")]
		public static string GetFolderPath(System.Environment.SpecialFolder folder)
		{
			return null;
		}

		// Token: 0x06000F71 RID: 3953
		[Token(Token = "0x6000F71")]
		[Address(RVA = "0x4D353E0", Offset = "0x4D33FE0", VA = "0x184D353E0")]
		[MethodImpl(4096)]
		private static extern string GetWindowsFolderPath(int folder);

		// Token: 0x06000F72 RID: 3954 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F72")]
		[Address(RVA = "0x4D350F0", Offset = "0x4D33CF0", VA = "0x184D350F0")]
		public static string GetFolderPath(System.Environment.SpecialFolder folder, System.Environment.SpecialFolderOption option)
		{
			return null;
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F73")]
		[Address(RVA = "0x4D353F0", Offset = "0x4D33FF0", VA = "0x184D353F0")]
		private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback)
		{
			return null;
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F74")]
		[Address(RVA = "0x4D35750", Offset = "0x4D34350", VA = "0x184D35750")]
		internal static string UnixGetFolderPath(System.Environment.SpecialFolder folder, System.Environment.SpecialFolderOption option)
		{
			return null;
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F75")]
		[Address(RVA = "0x4D34E70", Offset = "0x4D33A70", VA = "0x184D34E70")]
		public static void FailFast(string message)
		{
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x4D34E60", Offset = "0x4D33A60", VA = "0x184D34E60")]
		public static void FailFast(string message, System.Exception exception)
		{
		}

		// Token: 0x06000F77 RID: 3959
		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x4D34E80", Offset = "0x4D33A80", VA = "0x184D34E80")]
		[MethodImpl(4096)]
		internal static extern void FailFast(string message, System.Exception exception, string errorSource);

		// Token: 0x06000F78 RID: 3960
		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x4BB5150", Offset = "0x4BB3D50", VA = "0x184BB5150")]
		[MethodImpl(4096)]
		private static extern bool GetIs64BitOperatingSystem();

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x0000D068 File Offset: 0x0000B268
		[Token(Token = "0x17000161")]
		public static bool Is64BitOperatingSystem
		{
			[Token(Token = "0x6000F79")]
			[Address(RVA = "0x4BB5150", Offset = "0x4BB3D50", VA = "0x184BB5150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x0000D080 File Offset: 0x0000B280
		[Token(Token = "0x17000162")]
		public static bool Is64BitProcess
		{
			[Token(Token = "0x6000F7A")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000F7B RID: 3963
		[Token(Token = "0x17000163")]
		public static extern int ProcessorCount { [Token(Token = "0x6000F7B")] [Address(RVA = "0x4D35EF0", Offset = "0x4D34AF0", VA = "0x184D35EF0")] [MethodImpl(4096)] get; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x0000D098 File Offset: 0x0000B298
		[Token(Token = "0x17000164")]
		internal static bool IsRunningOnWindows
		{
			[Token(Token = "0x6000F7C")]
			[Address(RVA = "0x4D35D10", Offset = "0x4D34910", VA = "0x184D35D10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000F7D RID: 3965
		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x4D34EA0", Offset = "0x4D33AA0", VA = "0x184D34EA0")]
		[MethodImpl(4096)]
		private static extern string[] GetEnvironmentVariableNames();

		// Token: 0x06000F7E RID: 3966
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x4D35140", Offset = "0x4D33D40", VA = "0x184D35140")]
		[MethodImpl(4096)]
		internal static extern string GetMachineConfigPath();

		// Token: 0x06000F7F RID: 3967
		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0x4D362B0", Offset = "0x4D34EB0", VA = "0x184D362B0")]
		[MethodImpl(4096)]
		internal static extern string internalGetHome();

		// Token: 0x06000F80 RID: 3968
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x4D35170", Offset = "0x4D33D70", VA = "0x184D35170")]
		[MethodImpl(4096)]
		internal static extern int GetPageSize();

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		[Token(Token = "0x17000165")]
		internal static bool IsUnix
		{
			[Token(Token = "0x6000F81")]
			[Address(RVA = "0x4D35D30", Offset = "0x4D34930", VA = "0x184D35D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F82")]
		[Address(RVA = "0x4D35340", Offset = "0x4D33F40", VA = "0x184D35340")]
		internal static string GetStackTrace(System.Exception e, bool needFileInfo)
		{
			return null;
		}

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		private const string mono_corlib_version = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789";

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string nl;

		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.OperatingSystem os;

		// Token: 0x02000198 RID: 408
		[Token(Token = "0x2000198")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public enum SpecialFolder
		{
			// Token: 0x040006E8 RID: 1768
			[Token(Token = "0x40006E8")]
			MyDocuments = 5,
			// Token: 0x040006E9 RID: 1769
			[Token(Token = "0x40006E9")]
			Desktop = 0,
			// Token: 0x040006EA RID: 1770
			[Token(Token = "0x40006EA")]
			MyComputer = 17,
			// Token: 0x040006EB RID: 1771
			[Token(Token = "0x40006EB")]
			Programs = 2,
			// Token: 0x040006EC RID: 1772
			[Token(Token = "0x40006EC")]
			Personal = 5,
			// Token: 0x040006ED RID: 1773
			[Token(Token = "0x40006ED")]
			Favorites,
			// Token: 0x040006EE RID: 1774
			[Token(Token = "0x40006EE")]
			Startup,
			// Token: 0x040006EF RID: 1775
			[Token(Token = "0x40006EF")]
			Recent,
			// Token: 0x040006F0 RID: 1776
			[Token(Token = "0x40006F0")]
			SendTo,
			// Token: 0x040006F1 RID: 1777
			[Token(Token = "0x40006F1")]
			StartMenu = 11,
			// Token: 0x040006F2 RID: 1778
			[Token(Token = "0x40006F2")]
			MyMusic = 13,
			// Token: 0x040006F3 RID: 1779
			[Token(Token = "0x40006F3")]
			DesktopDirectory = 16,
			// Token: 0x040006F4 RID: 1780
			[Token(Token = "0x40006F4")]
			Templates = 21,
			// Token: 0x040006F5 RID: 1781
			[Token(Token = "0x40006F5")]
			ApplicationData = 26,
			// Token: 0x040006F6 RID: 1782
			[Token(Token = "0x40006F6")]
			LocalApplicationData = 28,
			// Token: 0x040006F7 RID: 1783
			[Token(Token = "0x40006F7")]
			InternetCache = 32,
			// Token: 0x040006F8 RID: 1784
			[Token(Token = "0x40006F8")]
			Cookies,
			// Token: 0x040006F9 RID: 1785
			[Token(Token = "0x40006F9")]
			History,
			// Token: 0x040006FA RID: 1786
			[Token(Token = "0x40006FA")]
			CommonApplicationData,
			// Token: 0x040006FB RID: 1787
			[Token(Token = "0x40006FB")]
			System = 37,
			// Token: 0x040006FC RID: 1788
			[Token(Token = "0x40006FC")]
			ProgramFiles,
			// Token: 0x040006FD RID: 1789
			[Token(Token = "0x40006FD")]
			MyPictures,
			// Token: 0x040006FE RID: 1790
			[Token(Token = "0x40006FE")]
			CommonProgramFiles = 43,
			// Token: 0x040006FF RID: 1791
			[Token(Token = "0x40006FF")]
			MyVideos = 14,
			// Token: 0x04000700 RID: 1792
			[Token(Token = "0x4000700")]
			NetworkShortcuts = 19,
			// Token: 0x04000701 RID: 1793
			[Token(Token = "0x4000701")]
			Fonts,
			// Token: 0x04000702 RID: 1794
			[Token(Token = "0x4000702")]
			CommonStartMenu = 22,
			// Token: 0x04000703 RID: 1795
			[Token(Token = "0x4000703")]
			CommonPrograms,
			// Token: 0x04000704 RID: 1796
			[Token(Token = "0x4000704")]
			CommonStartup,
			// Token: 0x04000705 RID: 1797
			[Token(Token = "0x4000705")]
			CommonDesktopDirectory,
			// Token: 0x04000706 RID: 1798
			[Token(Token = "0x4000706")]
			PrinterShortcuts = 27,
			// Token: 0x04000707 RID: 1799
			[Token(Token = "0x4000707")]
			Windows = 36,
			// Token: 0x04000708 RID: 1800
			[Token(Token = "0x4000708")]
			UserProfile = 40,
			// Token: 0x04000709 RID: 1801
			[Token(Token = "0x4000709")]
			SystemX86,
			// Token: 0x0400070A RID: 1802
			[Token(Token = "0x400070A")]
			ProgramFilesX86,
			// Token: 0x0400070B RID: 1803
			[Token(Token = "0x400070B")]
			CommonProgramFilesX86 = 44,
			// Token: 0x0400070C RID: 1804
			[Token(Token = "0x400070C")]
			CommonTemplates,
			// Token: 0x0400070D RID: 1805
			[Token(Token = "0x400070D")]
			CommonDocuments,
			// Token: 0x0400070E RID: 1806
			[Token(Token = "0x400070E")]
			CommonAdminTools,
			// Token: 0x0400070F RID: 1807
			[Token(Token = "0x400070F")]
			AdminTools,
			// Token: 0x04000710 RID: 1808
			[Token(Token = "0x4000710")]
			CommonMusic = 53,
			// Token: 0x04000711 RID: 1809
			[Token(Token = "0x4000711")]
			CommonPictures,
			// Token: 0x04000712 RID: 1810
			[Token(Token = "0x4000712")]
			CommonVideos,
			// Token: 0x04000713 RID: 1811
			[Token(Token = "0x4000713")]
			Resources,
			// Token: 0x04000714 RID: 1812
			[Token(Token = "0x4000714")]
			LocalizedResources,
			// Token: 0x04000715 RID: 1813
			[Token(Token = "0x4000715")]
			CommonOemLinks,
			// Token: 0x04000716 RID: 1814
			[Token(Token = "0x4000716")]
			CDBurning
		}

		// Token: 0x02000199 RID: 409
		[Token(Token = "0x2000199")]
		public enum SpecialFolderOption
		{
			// Token: 0x04000718 RID: 1816
			[Token(Token = "0x4000718")]
			None,
			// Token: 0x04000719 RID: 1817
			[Token(Token = "0x4000719")]
			DoNotVerify = 16384,
			// Token: 0x0400071A RID: 1818
			[Token(Token = "0x400071A")]
			Create = 32768
		}
	}
}
