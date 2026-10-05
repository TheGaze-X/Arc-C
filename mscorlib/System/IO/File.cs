using System;
using System.Text;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000668 RID: 1640
	[Token(Token = "0x2000668")]
	public static class File
	{
		// Token: 0x06003182 RID: 12674 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003182")]
		[Address(RVA = "0x4C7AE50", Offset = "0x4C79A50", VA = "0x184C7AE50")]
		public static StreamReader OpenText(string path)
		{
			return null;
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003183")]
		[Address(RVA = "0x4C7A560", Offset = "0x4C79160", VA = "0x184C7A560")]
		public static void Copy(string sourceFileName, string destFileName)
		{
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003184")]
		[Address(RVA = "0x4C7A330", Offset = "0x4C78F30", VA = "0x184C7A330")]
		public static void Copy(string sourceFileName, string destFileName, bool overwrite)
		{
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003185")]
		[Address(RVA = "0x4C7A5F0", Offset = "0x4C791F0", VA = "0x184C7A5F0")]
		public static FileStream Create(string path)
		{
			return null;
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003186")]
		[Address(RVA = "0x4C7A570", Offset = "0x4C79170", VA = "0x184C7A570")]
		public static FileStream Create(string path, int bufferSize)
		{
			return null;
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003187")]
		[Address(RVA = "0x4C7A670", Offset = "0x4C79270", VA = "0x184C7A670")]
		public static void Delete(string path)
		{
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x0001A9E8 File Offset: 0x00018BE8
		[Token(Token = "0x6003188")]
		[Address(RVA = "0x4C7A720", Offset = "0x4C79320", VA = "0x184C7A720")]
		public static bool Exists(string path)
		{
			return default(bool);
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003189")]
		[Address(RVA = "0x4C7AFA0", Offset = "0x4C79BA0", VA = "0x184C7AFA0")]
		public static FileStream Open(string path, FileMode mode)
		{
			return null;
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600318A")]
		[Address(RVA = "0x4C7B040", Offset = "0x4C79C40", VA = "0x184C7B040")]
		public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
		{
			return null;
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318B")]
		[Address(RVA = "0x4C7BE50", Offset = "0x4C7AA50", VA = "0x184C7BE50")]
		public static void SetLastWriteTime(string path, System.DateTime lastWriteTime)
		{
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x0001AA00 File Offset: 0x00018C00
		[Token(Token = "0x600318C")]
		[Address(RVA = "0x4C7A800", Offset = "0x4C79400", VA = "0x184C7A800")]
		public static System.DateTime GetLastWriteTime(string path)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318D")]
		[Address(RVA = "0x4C7BD50", Offset = "0x4C7A950", VA = "0x184C7BD50")]
		public static void SetAttributes(string path, FileAttributes fileAttributes)
		{
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600318E")]
		[Address(RVA = "0x4C7ADD0", Offset = "0x4C799D0", VA = "0x184C7ADD0")]
		public static FileStream OpenRead(string path)
		{
			return null;
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600318F")]
		[Address(RVA = "0x4C7AF30", Offset = "0x4C79B30", VA = "0x184C7AF30")]
		public static FileStream OpenWrite(string path)
		{
			return null;
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003190")]
		[Address(RVA = "0x4C7B830", Offset = "0x4C7A430", VA = "0x184C7B830")]
		public static string ReadAllText(string path)
		{
			return null;
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003191")]
		[Address(RVA = "0x4C7B920", Offset = "0x4C7A520", VA = "0x184C7B920")]
		public static string ReadAllText(string path, System.Text.Encoding encoding)
		{
			return null;
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003192")]
		[Address(RVA = "0x4C7A890", Offset = "0x4C79490", VA = "0x184C7A890")]
		private static string InternalReadAllText(string path, System.Text.Encoding encoding)
		{
			return null;
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003193")]
		[Address(RVA = "0x4C7C290", Offset = "0x4C7AE90", VA = "0x184C7C290")]
		public static void WriteAllText(string path, string contents)
		{
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003194")]
		[Address(RVA = "0x4C7C050", Offset = "0x4C7AC50", VA = "0x184C7C050")]
		public static void WriteAllText(string path, string contents, System.Text.Encoding encoding)
		{
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003195")]
		[Address(RVA = "0x4C7B590", Offset = "0x4C7A190", VA = "0x184C7B590")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003196")]
		[Address(RVA = "0x4C7B0E0", Offset = "0x4C79CE0", VA = "0x184C7B0E0")]
		private static byte[] ReadAllBytesUnknownLength(FileStream fs)
		{
			return null;
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003197")]
		[Address(RVA = "0x4C7BF00", Offset = "0x4C7AB00", VA = "0x184C7BF00")]
		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003198")]
		[Address(RVA = "0x4C7A9D0", Offset = "0x4C795D0", VA = "0x184C7A9D0")]
		private static void InternalWriteAllBytes(string path, byte[] bytes)
		{
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003199")]
		[Address(RVA = "0x4C7A150", Offset = "0x4C78D50", VA = "0x184C7A150")]
		public static void AppendAllText(string path, string contents)
		{
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319A")]
		[Address(RVA = "0x4C7BA60", Offset = "0x4C7A660", VA = "0x184C7BA60")]
		public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
		{
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319B")]
		[Address(RVA = "0x4C7BBD0", Offset = "0x4C7A7D0", VA = "0x184C7BBD0")]
		public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
		{
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319C")]
		[Address(RVA = "0x4C7AB20", Offset = "0x4C79720", VA = "0x184C7AB20")]
		public static void Move(string sourceFileName, string destFileName)
		{
		}
	}
}
