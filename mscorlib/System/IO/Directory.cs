using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000665 RID: 1637
	[Token(Token = "0x2000665")]
	public static class Directory
	{
		// Token: 0x06003158 RID: 12632 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003158")]
		[Address(RVA = "0x4C776F0", Offset = "0x4C762F0", VA = "0x184C776F0")]
		public static DirectoryInfo CreateDirectory(string path)
		{
			return null;
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x0001A928 File Offset: 0x00018B28
		[Token(Token = "0x6003159")]
		[Address(RVA = "0x4C778D0", Offset = "0x4C764D0", VA = "0x184C778D0")]
		public static bool Exists(string path)
		{
			return default(bool);
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600315A")]
		[Address(RVA = "0x4C77E50", Offset = "0x4C76A50", VA = "0x184C77E50")]
		public static string[] GetFiles(string path)
		{
			return null;
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600315B")]
		[Address(RVA = "0x4C77D70", Offset = "0x4C76970", VA = "0x184C77D70")]
		public static string[] GetFiles(string path, string searchPattern)
		{
			return null;
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600315C")]
		[Address(RVA = "0x4C77F40", Offset = "0x4C76B40", VA = "0x184C77F40")]
		public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			return null;
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600315D")]
		[Address(RVA = "0x4C78120", Offset = "0x4C76D20", VA = "0x184C78120")]
		public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return null;
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600315E")]
		[Address(RVA = "0x4C77960", Offset = "0x4C76560", VA = "0x184C77960")]
		public static string[] GetDirectories(string path)
		{
			return null;
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600315F")]
		[Address(RVA = "0x4C77A50", Offset = "0x4C76650", VA = "0x184C77A50")]
		public static string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return null;
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003160")]
		[Address(RVA = "0x4C77C10", Offset = "0x4C76810", VA = "0x184C77C10")]
		public static string[] GetFileSystemEntries(string path)
		{
			return null;
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003161")]
		[Address(RVA = "0x4C77D00", Offset = "0x4C76900", VA = "0x184C77D00")]
		public static string[] GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return null;
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003162")]
		[Address(RVA = "0x4C78230", Offset = "0x4C76E30", VA = "0x184C78230")]
		internal static System.Collections.Generic.IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			return null;
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003163")]
		[Address(RVA = "0x4C77AC0", Offset = "0x4C766C0", VA = "0x184C77AC0")]
		public static string GetDirectoryRoot(string path)
		{
			return null;
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003164")]
		[Address(RVA = "0x4C78480", Offset = "0x4C77080", VA = "0x184C78480")]
		internal static string InternalGetDirectoryRoot(string path)
		{
			return null;
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003165")]
		[Address(RVA = "0x4C77950", Offset = "0x4C76550", VA = "0x184C77950")]
		public static string GetCurrentDirectory()
		{
			return null;
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003166")]
		[Address(RVA = "0x4C77860", Offset = "0x4C76460", VA = "0x184C77860")]
		public static void Delete(string path, bool recursive)
		{
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003167")]
		[Address(RVA = "0x4C78190", Offset = "0x4C76D90", VA = "0x184C78190")]
		internal static string InsecureGetCurrentDirectory()
		{
			return null;
		}
	}
}
