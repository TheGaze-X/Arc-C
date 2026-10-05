using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace System.IO
{
	// Token: 0x02000643 RID: 1603
	[Token(Token = "0x2000643")]
	internal static class FileSystem
	{
		// Token: 0x06003001 RID: 12289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003001")]
		[Address(RVA = "0x4C5E890", Offset = "0x4C5D490", VA = "0x184C5E890")]
		public static void CopyFile(string sourceFullPath, string destFullPath, bool overwrite)
		{
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003002")]
		[Address(RVA = "0x4C60470", Offset = "0x4C5F070", VA = "0x184C60470")]
		public static void ReplaceFile(string sourceFullPath, string destFullPath, string destBackupFullPath, bool ignoreMetadataErrors)
		{
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003003")]
		[Address(RVA = "0x4C5EB10", Offset = "0x4C5D710", VA = "0x184C5EB10")]
		public static void CreateDirectory(string fullPath)
		{
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003004")]
		[Address(RVA = "0x4C5EFF0", Offset = "0x4C5DBF0", VA = "0x184C5EFF0")]
		public static void DeleteFile(string fullPath)
		{
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x0001A0D0 File Offset: 0x000182D0
		[Token(Token = "0x6003005")]
		[Address(RVA = "0x4C5F080", Offset = "0x4C5DC80", VA = "0x184C5F080")]
		public static bool DirectoryExists(string fullPath)
		{
			return default(bool);
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x0001A0E8 File Offset: 0x000182E8
		[Token(Token = "0x6003006")]
		[Address(RVA = "0x4C5F0D0", Offset = "0x4C5DCD0", VA = "0x184C5F0D0")]
		private static bool DirectoryExists(string path, out int lastError)
		{
			return default(bool);
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x0001A100 File Offset: 0x00018300
		[Token(Token = "0x6003007")]
		[Address(RVA = "0x4C5F170", Offset = "0x4C5DD70", VA = "0x184C5F170")]
		internal static int FillAttributeInfo(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data, bool returnErrorOnNotFound)
		{
			return 0;
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x0001A118 File Offset: 0x00018318
		[Token(Token = "0x6003008")]
		[Address(RVA = "0x4C5F120", Offset = "0x4C5DD20", VA = "0x184C5F120")]
		public static bool FileExists(string fullPath)
		{
			return default(bool);
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x0001A130 File Offset: 0x00018330
		[Token(Token = "0x6003009")]
		[Address(RVA = "0x4C5F710", Offset = "0x4C5E310", VA = "0x184C5F710")]
		public static System.DateTimeOffset GetLastWriteTime(string fullPath)
		{
			return default(System.DateTimeOffset);
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300A")]
		[Address(RVA = "0x4C5F7C0", Offset = "0x4C5E3C0", VA = "0x184C5F7C0")]
		public static void MoveFile(string sourceFullPath, string destFullPath)
		{
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600300B")]
		[Address(RVA = "0x4C5F870", Offset = "0x4C5E470", VA = "0x184C5F870")]
		private static Microsoft.Win32.SafeHandles.SafeFileHandle OpenHandle(string fullPath, bool asDirectory)
		{
			return null;
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300C")]
		[Address(RVA = "0x4C60330", Offset = "0x4C5EF30", VA = "0x184C60330")]
		public static void RemoveDirectory(string fullPath, bool recursive)
		{
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300D")]
		[Address(RVA = "0x4C5F5B0", Offset = "0x4C5E1B0", VA = "0x184C5F5B0")]
		private static void GetFindData(string fullPath, ref Interop.Kernel32.WIN32_FIND_DATA findData)
		{
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x0001A148 File Offset: 0x00018348
		[Token(Token = "0x600300E")]
		[Address(RVA = "0x4C5F7A0", Offset = "0x4C5E3A0", VA = "0x184C5F7A0")]
		private static bool IsNameSurrogateReparsePoint(ref Interop.Kernel32.WIN32_FIND_DATA data)
		{
			return default(bool);
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300F")]
		[Address(RVA = "0x4C5FC30", Offset = "0x4C5E830", VA = "0x184C5FC30")]
		private static void RemoveDirectoryRecursive(string fullPath, ref Interop.Kernel32.WIN32_FIND_DATA findData, bool topLevel)
		{
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003010")]
		[Address(RVA = "0x4C5FB00", Offset = "0x4C5E700", VA = "0x184C5FB00")]
		private static void RemoveDirectoryInternal(string fullPath, bool topLevel, bool allowDirectoryNotEmpty = false)
		{
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003011")]
		[Address(RVA = "0x4C60550", Offset = "0x4C5F150", VA = "0x184C60550")]
		public static void SetAttributes(string fullPath, FileAttributes attributes)
		{
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003012")]
		[Address(RVA = "0x4C60680", Offset = "0x4C5F280", VA = "0x184C60680")]
		public static void SetLastWriteTime(string fullPath, System.DateTimeOffset time, bool asDirectory)
		{
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x0001A160 File Offset: 0x00018360
		[Token(Token = "0x6003013")]
		[Address(RVA = "0x4C60820", Offset = "0x4C5F420", VA = "0x184C60820")]
		private static bool UnityCreateDirectory(string name)
		{
			return default(bool);
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x0001A178 File Offset: 0x00018378
		[Token(Token = "0x6003014")]
		[Address(RVA = "0x4C61050", Offset = "0x4C5FC50", VA = "0x184C61050")]
		private static bool UnityRemoveDirectory(string fullPath)
		{
			return default(bool);
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x0001A190 File Offset: 0x00018390
		[Token(Token = "0x6003015")]
		[Address(RVA = "0x4C60E50", Offset = "0x4C5FA50", VA = "0x184C60E50")]
		private static bool UnityGetFileAttributesEx(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data)
		{
			return default(bool);
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x0001A1A8 File Offset: 0x000183A8
		[Token(Token = "0x6003016")]
		[Address(RVA = "0x4C61130", Offset = "0x4C5FD30", VA = "0x184C61130")]
		private static bool UnitySetFileAttributes(string fullPath, FileAttributes attributes)
		{
			return default(bool);
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x0001A1C0 File Offset: 0x000183C0
		[Token(Token = "0x6003017")]
		[Address(RVA = "0x4C608C0", Offset = "0x4C5F4C0", VA = "0x184C608C0")]
		internal static System.IntPtr UnityCreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes)
		{
			return 0;
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x0001A1D8 File Offset: 0x000183D8
		[Token(Token = "0x6003018")]
		[Address(RVA = "0x4C607C0", Offset = "0x4C5F3C0", VA = "0x184C607C0")]
		private static int UnityCopyFile(string sourceFullPath, string destFullPath, bool failIfExists)
		{
			return 0;
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x0001A1F0 File Offset: 0x000183F0
		[Token(Token = "0x6003019")]
		[Address(RVA = "0x4C609D0", Offset = "0x4C5F5D0", VA = "0x184C609D0")]
		private static bool UnityDeleteFile(string path)
		{
			return default(bool);
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x0001A208 File Offset: 0x00018408
		[Token(Token = "0x600301A")]
		[Address(RVA = "0x4C60FB0", Offset = "0x4C5FBB0", VA = "0x184C60FB0")]
		private static bool UnityMoveFile(string sourceFullPath, string destFullPath)
		{
			return default(bool);
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600301B")]
		[Address(RVA = "0x4C60AB0", Offset = "0x4C5F6B0", VA = "0x184C60AB0")]
		private static SafeFindHandle UnityFindFirstFile(string path, ref Interop.Kernel32.WIN32_FIND_DATA findData)
		{
			return null;
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x0001A220 File Offset: 0x00018420
		[Token(Token = "0x600301C")]
		[Address(RVA = "0x4C60C80", Offset = "0x4C5F880", VA = "0x184C60C80")]
		private static bool UnityFindNextFile(SafeFindHandle handle, ref Interop.Kernel32.WIN32_FIND_DATA findData)
		{
			return default(bool);
		}

		// Token: 0x0600301D RID: 12317
		[Token(Token = "0x600301D")]
		[Address(RVA = "0x4C5E810", Offset = "0x4C5D410", VA = "0x184C5E810")]
		[MethodImpl(4096)]
		private static extern bool BrokeredCreateDirectory(string path);

		// Token: 0x0600301E RID: 12318
		[Token(Token = "0x600301E")]
		[Address(RVA = "0x4C5E810", Offset = "0x4C5D410", VA = "0x184C5E810")]
		[MethodImpl(4096)]
		private static extern bool BrokeredRemoveDirectory(string path);

		// Token: 0x0600301F RID: 12319
		[Token(Token = "0x600301F")]
		[Address(RVA = "0x4C5E840", Offset = "0x4C5D440", VA = "0x184C5E840")]
		[MethodImpl(4096)]
		private static extern bool BrokeredGetFileAttributes(string path, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA data);

		// Token: 0x06003020 RID: 12320
		[Token(Token = "0x6003020")]
		[Address(RVA = "0x4C5E880", Offset = "0x4C5D480", VA = "0x184C5E880")]
		[MethodImpl(4096)]
		private static extern bool BrokeredSetAttributes(string path, FileAttributes attributes);

		// Token: 0x06003021 RID: 12321
		[Token(Token = "0x6003021")]
		[Address(RVA = "0x4C5E860", Offset = "0x4C5D460", VA = "0x184C5E860")]
		[MethodImpl(4096)]
		private static extern System.IntPtr BrokeredOpenFile(string lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, int dwFlagsAndAttributes);

		// Token: 0x06003022 RID: 12322
		[Token(Token = "0x6003022")]
		[Address(RVA = "0x4C5E800", Offset = "0x4C5D400", VA = "0x184C5E800")]
		[MethodImpl(4096)]
		private static extern void BrokeredCopyFile(string sourcePath, string destPath, bool overwrite, ref int error);

		// Token: 0x06003023 RID: 12323
		[Token(Token = "0x6003023")]
		[Address(RVA = "0x4C5E850", Offset = "0x4C5D450", VA = "0x184C5E850")]
		[MethodImpl(4096)]
		private static extern bool BrokeredMoveFile(string sourceFullPath, string destFullPath);

		// Token: 0x06003024 RID: 12324
		[Token(Token = "0x6003024")]
		[Address(RVA = "0x4C5E810", Offset = "0x4C5D410", VA = "0x184C5E810")]
		[MethodImpl(4096)]
		private static extern bool BrokeredDeleteFile(string path);

		// Token: 0x06003025 RID: 12325
		[Token(Token = "0x6003025")]
		[Address(RVA = "0x4C5E820", Offset = "0x4C5D420", VA = "0x184C5E820")]
		[MethodImpl(4096)]
		private static extern System.IntPtr BrokeredFindFirstFile(string searchPath, ref string resultFilePath, ref uint attributes);

		// Token: 0x06003026 RID: 12326
		[Token(Token = "0x6003026")]
		[Address(RVA = "0x4C5E830", Offset = "0x4C5D430", VA = "0x184C5E830")]
		[MethodImpl(4096)]
		private static extern bool BrokeredFindNextFile(System.IntPtr handle, ref string resultFilePath, ref uint attributes);

		// Token: 0x06003027 RID: 12327
		[Token(Token = "0x6003027")]
		[Address(RVA = "0x4C5E870", Offset = "0x4C5D470", VA = "0x184C5E870")]
		[MethodImpl(4096)]
		private static extern int BrokeredSafeFindHandleDispose(System.IntPtr handle);

		// Token: 0x06003028 RID: 12328 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003028")]
		[Address(RVA = "0x4C60400", Offset = "0x4C5F000", VA = "0x184C60400")]
		private static string RemoveExtendedPathPrefix(string path)
		{
			return null;
		}

		// Token: 0x02000644 RID: 1604
		[Token(Token = "0x2000644")]
		private class UnitySafeFindHandle : SafeFindHandle
		{
			// Token: 0x06003029 RID: 12329 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003029")]
			[Address(RVA = "0x4C720D0", Offset = "0x4C70CD0", VA = "0x184C720D0")]
			public UnitySafeFindHandle(System.IntPtr handle)
			{
			}

			// Token: 0x170007BE RID: 1982
			// (get) Token: 0x0600302A RID: 12330 RVA: 0x0001A238 File Offset: 0x00018438
			[Token(Token = "0x170007BE")]
			public System.IntPtr Handle
			{
				[Token(Token = "0x600302A")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170007BF RID: 1983
			// (get) Token: 0x0600302B RID: 12331 RVA: 0x0001A250 File Offset: 0x00018450
			[Token(Token = "0x170007BF")]
			public override bool IsInvalid
			{
				[Token(Token = "0x600302B")]
				[Address(RVA = "0x4C72100", Offset = "0x4C70D00", VA = "0x184C72100", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600302C RID: 12332 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600302C")]
			[Address(RVA = "0x4C72060", Offset = "0x4C70C60", VA = "0x184C72060", Slot = "6")]
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x04001AA0 RID: 6816
			[Token(Token = "0x4001AA0")]
			[FieldOffset(Offset = "0x20")]
			private readonly System.IntPtr m_Handle;
		}
	}
}
