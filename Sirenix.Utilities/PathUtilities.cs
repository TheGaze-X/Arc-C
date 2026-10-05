using System;
using System.IO;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	public static class PathUtilities
	{
		// Token: 0x06000140 RID: 320 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x4E28770", Offset = "0x4E27370", VA = "0x184E28770")]
		public static string GetDirectoryName(string x)
		{
			return null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x4E28810", Offset = "0x4E27410", VA = "0x184E28810")]
		public static bool HasSubDirectory(this DirectoryInfo parentDir, DirectoryInfo subDir)
		{
			return default(bool);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x4E286C0", Offset = "0x4E272C0", VA = "0x184E286C0")]
		public static DirectoryInfo FindParentDirectoryWithName(this DirectoryInfo dir, string folderName)
		{
			return null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x4E28450", Offset = "0x4E27050", VA = "0x184E28450")]
		public static bool CanMakeRelative(string absoluteParentPath, string absolutePath)
		{
			return default(bool);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x4E289A0", Offset = "0x4E275A0", VA = "0x184E289A0")]
		public static string MakeRelative(string absoluteParentPath, string absolutePath)
		{
			return null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x4E28D10", Offset = "0x4E27910", VA = "0x184E28D10")]
		public static bool TryMakeRelative(string absoluteParentPath, string absolutePath, out string relativePath)
		{
			return default(bool);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x4E285F0", Offset = "0x4E271F0", VA = "0x184E285F0")]
		public static string Combine(string a, string b)
		{
			return null;
		}
	}
}
