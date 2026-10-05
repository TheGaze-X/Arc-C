using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	public static class PathUtil
	{
		// Token: 0x0600069C RID: 1692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x5523A20", Offset = "0x5522620", VA = "0x185523A20")]
		public static string ChangeExtension(string path, string extension)
		{
			return null;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x55240A0", Offset = "0x5522CA0", VA = "0x1855240A0")]
		public static string Combine(string path1, string path2)
		{
			return null;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x55243F0", Offset = "0x5522FF0", VA = "0x1855243F0")]
		public static string GetDirectoryName(string path)
		{
			return null;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x5524770", Offset = "0x5523370", VA = "0x185524770")]
		public static string GetExtension(string path)
		{
			return null;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x5524A50", Offset = "0x5523650", VA = "0x185524A50")]
		public static string GetFileName(string path)
		{
			return null;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x5524900", Offset = "0x5523500", VA = "0x185524900")]
		public static string GetFileNameWithoutExtension(string path)
		{
			return null;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x5524B70", Offset = "0x5523770", VA = "0x185524B70")]
		public static string GetFullPath(string path)
		{
			return null;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x5524BC0", Offset = "0x55237C0", VA = "0x185524BC0")]
		public static string GetPathRoot(string path)
		{
			return null;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x5525080", Offset = "0x5523C80", VA = "0x185525080")]
		public static string GetTempFileName()
		{
			return null;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x55250C0", Offset = "0x5523CC0", VA = "0x1855250C0")]
		public static string GetTempPath()
		{
			return null;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0000638C File Offset: 0x0000458C
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x5525100", Offset = "0x5523D00", VA = "0x185525100")]
		public static bool HasExtension(string path)
		{
			return default(bool);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000063A4 File Offset: 0x000045A4
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x55252A0", Offset = "0x5523EA0", VA = "0x1855252A0")]
		public static bool IsPathRooted(string path)
		{
			return default(bool);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x5523CC0", Offset = "0x55228C0", VA = "0x185523CC0")]
		internal static string CleanPath(string s)
		{
			return null;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000063BC File Offset: 0x000045BC
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x5525690", Offset = "0x5524290", VA = "0x185525690")]
		private static int findExtension(string path)
		{
			return 0;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000063D4 File Offset: 0x000045D4
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x5525220", Offset = "0x5523E20", VA = "0x185525220")]
		private static bool IsDsc(char c)
		{
			return default(bool);
		}

		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly char[] InvalidPathChars;

		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0x8")]
		public static readonly char DirectorySeparatorChar;

		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0xA")]
		public static readonly char AltDirectorySeparatorChar;

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0xC")]
		public static readonly char VolumeSeparatorChar;

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly string DirectorySeparatorStr;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly char[] PathSeparatorChars;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x20")]
		private static readonly bool dirEqualsVolume;
	}
}
