using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000686 RID: 1670
	[Token(Token = "0x2000686")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public static class Path
	{
		// Token: 0x060032E1 RID: 13025 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032E1")]
		[Address(RVA = "0x4C9BF10", Offset = "0x4C9AB10", VA = "0x184C9BF10")]
		public static string ChangeExtension(string path, string extension)
		{
			return null;
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032E2")]
		[Address(RVA = "0x4C9C600", Offset = "0x4C9B200", VA = "0x184C9C600")]
		public static string Combine(string path1, string path2)
		{
			return null;
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032E3")]
		[Address(RVA = "0x4C9C1B0", Offset = "0x4C9ADB0", VA = "0x184C9C1B0")]
		internal static string CleanPath(string s)
		{
			return null;
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032E4")]
		[Address(RVA = "0x4C9D350", Offset = "0x4C9BF50", VA = "0x184C9D350")]
		public static string GetDirectoryName(string path)
		{
			return null;
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x0001B2B8 File Offset: 0x000194B8
		[Token(Token = "0x60032E5")]
		[Address(RVA = "0x4C9D270", Offset = "0x4C9BE70", VA = "0x184C9D270")]
		public static System.ReadOnlySpan<char> GetDirectoryName(System.ReadOnlySpan<char> path)
		{
			return default(System.ReadOnlySpan<char>);
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032E6")]
		[Address(RVA = "0x4C9D7B0", Offset = "0x4C9C3B0", VA = "0x184C9D7B0")]
		public static string GetExtension(string path)
		{
			return null;
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032E7")]
		[Address(RVA = "0x4C9DB20", Offset = "0x4C9C720", VA = "0x184C9DB20")]
		public static string GetFileName(string path)
		{
			return null;
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032E8")]
		[Address(RVA = "0x4C9D940", Offset = "0x4C9C540", VA = "0x184C9D940")]
		public static string GetFileNameWithoutExtension(string path)
		{
			return null;
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032E9")]
		[Address(RVA = "0x4C9E090", Offset = "0x4C9CC90", VA = "0x184C9E090")]
		public static string GetFullPath(string path)
		{
			return null;
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032EA")]
		[Address(RVA = "0x4C9DC40", Offset = "0x4C9C840", VA = "0x184C9DC40")]
		internal static string GetFullPathInternal(string path)
		{
			return null;
		}

		// Token: 0x060032EB RID: 13035
		[Token(Token = "0x60032EB")]
		[Address(RVA = "0x4C9DFB0", Offset = "0x4C9CBB0", VA = "0x184C9DFB0")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern int GetFullPathName(string path, int numBufferChars, System.Text.StringBuilder buffer, ref System.IntPtr lpFilePartOrNull);

		// Token: 0x060032EC RID: 13036 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032EC")]
		[Address(RVA = "0x4C9DC90", Offset = "0x4C9C890", VA = "0x184C9DC90")]
		internal static string GetFullPathName(string path)
		{
			return null;
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032ED")]
		[Address(RVA = "0x4CA0850", Offset = "0x4C9F450", VA = "0x184CA0850")]
		internal static string WindowsDriveAdjustment(string path)
		{
			return null;
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032EE")]
		[Address(RVA = "0x4C9EE20", Offset = "0x4C9DA20", VA = "0x184C9EE20")]
		internal static string InsecureGetFullPath(string path)
		{
			return null;
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x0001B2D0 File Offset: 0x000194D0
		[Token(Token = "0x60032EF")]
		[Address(RVA = "0x4C9F540", Offset = "0x4C9E140", VA = "0x184C9F540")]
		internal static bool IsDirectorySeparator(char c)
		{
			return default(bool);
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032F0")]
		[Address(RVA = "0x4C9E210", Offset = "0x4C9CE10", VA = "0x184C9E210")]
		public static string GetPathRoot(string path)
		{
			return null;
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032F1")]
		[Address(RVA = "0x4C9E8D0", Offset = "0x4C9D4D0", VA = "0x184C9E8D0")]
		public static string GetTempFileName()
		{
			return null;
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032F2")]
		[Address(RVA = "0x4C9ED00", Offset = "0x4C9D900", VA = "0x184C9ED00")]
		public static string GetTempPath()
		{
			return null;
		}

		// Token: 0x060032F3 RID: 13043
		[Token(Token = "0x60032F3")]
		[Address(RVA = "0x4CA0E70", Offset = "0x4C9FA70", VA = "0x184CA0E70")]
		[MethodImpl(4096)]
		private static extern string get_temp_path();

		// Token: 0x060032F4 RID: 13044 RVA: 0x0001B2E8 File Offset: 0x000194E8
		[Token(Token = "0x60032F4")]
		[Address(RVA = "0x4C9F7F0", Offset = "0x4C9E3F0", VA = "0x184C9F7F0")]
		public static bool IsPathRooted(System.ReadOnlySpan<char> path)
		{
			return default(bool);
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x0001B300 File Offset: 0x00019500
		[Token(Token = "0x60032F5")]
		[Address(RVA = "0x4C9F5C0", Offset = "0x4C9E1C0", VA = "0x184C9F5C0")]
		public static bool IsPathRooted(string path)
		{
			return default(bool);
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032F6")]
		[Address(RVA = "0x4C9E0F0", Offset = "0x4C9CCF0", VA = "0x184C9E0F0")]
		public static char[] GetInvalidFileNameChars()
		{
			return null;
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032F7")]
		[Address(RVA = "0x4C9E190", Offset = "0x4C9CD90", VA = "0x184C9E190")]
		public static char[] GetInvalidPathChars()
		{
			return null;
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x0001B318 File Offset: 0x00019518
		[Token(Token = "0x60032F8")]
		[Address(RVA = "0x4CA0DE0", Offset = "0x4C9F9E0", VA = "0x184CA0DE0")]
		private static int findExtension(string path)
		{
			return 0;
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032FA")]
		[Address(RVA = "0x4C9E6D0", Offset = "0x4C9D2D0", VA = "0x184C9E6D0")]
		private static string GetServerAndShare(string path)
		{
			return null;
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x0001B330 File Offset: 0x00019530
		[Token(Token = "0x60032FB")]
		[Address(RVA = "0x4CA02E0", Offset = "0x4C9EEE0", VA = "0x184CA02E0")]
		private static bool SameRoot(string root, string path)
		{
			return default(bool);
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032FC")]
		[Address(RVA = "0x4C9B750", Offset = "0x4C9A350", VA = "0x184C9B750")]
		private static string CanonicalizePath(string path)
		{
			return null;
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032FD")]
		[Address(RVA = "0x4C9CEF0", Offset = "0x4C9BAF0", VA = "0x184C9CEF0")]
		public static string Combine(params string[] paths)
		{
			return null;
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032FE")]
		[Address(RVA = "0x4C9CC70", Offset = "0x4C9B870", VA = "0x184C9CC70")]
		public static string Combine(string path1, string path2, string path3)
		{
			return null;
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032FF")]
		[Address(RVA = "0x4C9C950", Offset = "0x4C9B550", VA = "0x184C9C950")]
		public static string Combine(string path1, string path2, string path3, string path4)
		{
			return null;
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003300")]
		[Address(RVA = "0x4CA07F0", Offset = "0x4C9F3F0", VA = "0x184CA07F0")]
		internal static void Validate(string path)
		{
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003301")]
		[Address(RVA = "0x4CA05F0", Offset = "0x4C9F1F0", VA = "0x184CA05F0")]
		internal static void Validate(string path, string parameterName)
		{
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x0001B348 File Offset: 0x00019548
		[Token(Token = "0x6003302")]
		[Address(RVA = "0x4C9D9A0", Offset = "0x4C9C5A0", VA = "0x184C9D9A0")]
		public static System.ReadOnlySpan<char> GetFileName(System.ReadOnlySpan<char> path)
		{
			return default(System.ReadOnlySpan<char>);
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003303")]
		[Address(RVA = "0x4C9FFC0", Offset = "0x4C9EBC0", VA = "0x184C9FFC0")]
		public static string Join(System.ReadOnlySpan<char> path1, System.ReadOnlySpan<char> path2)
		{
			return null;
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003304")]
		[Address(RVA = "0x4CA0070", Offset = "0x4C9EC70", VA = "0x184CA0070")]
		public static string Join(System.ReadOnlySpan<char> path1, System.ReadOnlySpan<char> path2, System.ReadOnlySpan<char> path3)
		{
			return null;
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003305")]
		[Address(RVA = "0x4C9FD00", Offset = "0x4C9E900", VA = "0x184C9FD00")]
		private static string JoinInternal(System.ReadOnlySpan<char> first, System.ReadOnlySpan<char> second)
		{
			return null;
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003306")]
		[Address(RVA = "0x4C9F920", Offset = "0x4C9E520", VA = "0x184C9F920")]
		private static string JoinInternal(System.ReadOnlySpan<char> first, System.ReadOnlySpan<char> second, System.ReadOnlySpan<char> third)
		{
			return null;
		}

		// Token: 0x04001BDA RID: 7130
		[Token(Token = "0x4001BDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[System.Obsolete("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
		public static readonly char[] InvalidPathChars;

		// Token: 0x04001BDB RID: 7131
		[Token(Token = "0x4001BDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly char AltDirectorySeparatorChar;

		// Token: 0x04001BDC RID: 7132
		[Token(Token = "0x4001BDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public static readonly char DirectorySeparatorChar;

		// Token: 0x04001BDD RID: 7133
		[Token(Token = "0x4001BDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly char PathSeparator;

		// Token: 0x04001BDE RID: 7134
		[Token(Token = "0x4001BDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly string DirectorySeparatorStr;

		// Token: 0x04001BDF RID: 7135
		[Token(Token = "0x4001BDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly char VolumeSeparatorChar;

		// Token: 0x04001BE0 RID: 7136
		[Token(Token = "0x4001BE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static readonly char[] PathSeparatorChars;

		// Token: 0x04001BE1 RID: 7137
		[Token(Token = "0x4001BE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly bool dirEqualsVolume;

		// Token: 0x04001BE2 RID: 7138
		[Token(Token = "0x4001BE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal static readonly char[] trimEndCharsWindows;

		// Token: 0x04001BE3 RID: 7139
		[Token(Token = "0x4001BE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal static readonly char[] trimEndCharsUnix;
	}
}
