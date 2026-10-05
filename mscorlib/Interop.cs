using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
internal static class Interop
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x4AAB0C0", Offset = "0x4AA9CC0", VA = "0x184AAB0C0")]
	internal unsafe static void GetRandomBytes(byte* buffer, int length)
	{
	}

	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	internal static class Kernel32
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x4AAB590", Offset = "0x4AAA190", VA = "0x184AAB590")]
		internal static int CopyFileUWP(string src, string dst, bool failIfExists)
		{
			return 0;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x4AAB6C0", Offset = "0x4AAA2C0", VA = "0x184AAB6C0")]
		internal static int CopyFile(string src, string dst, bool failIfExists)
		{
			return 0;
		}

		// Token: 0x06000004 RID: 4
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x4AABFB0", Offset = "0x4AAABB0", VA = "0x184AABFB0")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern bool DeleteVolumeMountPointPrivate(string mountPoint);

		// Token: 0x06000005 RID: 5 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x4AAC050", Offset = "0x4AAAC50", VA = "0x184AAC050")]
		internal static bool DeleteVolumeMountPoint(string mountPoint)
		{
			return default(bool);
		}

		// Token: 0x06000006 RID: 6
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x4AAC5B0", Offset = "0x4AAB1B0", VA = "0x184AAC5B0")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern bool FreeLibrary(System.IntPtr hModule);

		// Token: 0x06000007 RID: 7
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x4AACCB0", Offset = "0x4AAB8B0", VA = "0x184AACCB0")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern SafeLibraryHandle LoadLibraryEx(string libFilename, System.IntPtr reserved, int flags);

		// Token: 0x06000008 RID: 8
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x4AAC920", Offset = "0x4AAB520", VA = "0x184AAC920")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern bool GetFileMUIPath(uint flags, string filePath, [System.Runtime.InteropServices.Out] System.Text.StringBuilder language, ref int languageLength, [System.Runtime.InteropServices.Out] System.Text.StringBuilder fileMuiPath, ref int fileMuiPathLength, ref long enumerator);

		// Token: 0x06000009 RID: 9
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4AAC640", Offset = "0x4AAB240", VA = "0x184AAC640")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern uint GetDynamicTimeZoneInformation(out Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION pTimeZoneInformation);

		// Token: 0x0600000A RID: 10
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4AACC20", Offset = "0x4AAB820", VA = "0x184AACC20")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern uint GetTimeZoneInformation(out Interop.Kernel32.TIME_ZONE_INFORMATION lpTimeZoneInformation);

		// Token: 0x0600000B RID: 11
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4AAB220", Offset = "0x4AA9E20", VA = "0x184AAB220")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern bool CloseHandle(System.IntPtr handle);

		// Token: 0x0600000C RID: 12
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4AAB2B0", Offset = "0x4AA9EB0", VA = "0x184AAB2B0")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern int CopyFile2(string pwszExistingFileName, string pwszNewFileName, ref Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS pExtendedParameters);

		// Token: 0x0600000D RID: 13
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x4AAB360", Offset = "0x4AA9F60", VA = "0x184AAB360")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern bool CopyFileExPrivate(string src, string dst, System.IntPtr progressRoutine, System.IntPtr progressData, ref int cancel, int flags);

		// Token: 0x0600000E RID: 14 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x4AAB450", Offset = "0x4AAA050", VA = "0x184AAB450")]
		internal static bool CopyFileEx(string src, string dst, System.IntPtr progressRoutine, System.IntPtr progressData, ref int cancel, int flags)
		{
			return default(bool);
		}

		// Token: 0x0600000F RID: 15
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x4AAB8C0", Offset = "0x4AAA4C0", VA = "0x184AAB8C0")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern bool CreateDirectoryPrivate(string path, ref Interop.Kernel32.SECURITY_ATTRIBUTES lpSecurityAttributes);

		// Token: 0x06000010 RID: 16 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x4AAB960", Offset = "0x4AAA560", VA = "0x184AAB960")]
		internal static bool CreateDirectory(string path, ref Interop.Kernel32.SECURITY_ATTRIBUTES lpSecurityAttributes)
		{
			return default(bool);
		}

		// Token: 0x06000011 RID: 17
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x4AABA50", Offset = "0x4AAA650", VA = "0x184AABA50")]
		[System.Runtime.InteropServices.PreserveSig]
		private unsafe static extern System.IntPtr CreateFilePrivate(string lpFileName, int dwDesiredAccess, System.IO.FileShare dwShareMode, Interop.Kernel32.SECURITY_ATTRIBUTES* securityAttrs, System.IO.FileMode dwCreationDisposition, int dwFlagsAndAttributes, System.IntPtr hTemplateFile);

		// Token: 0x06000012 RID: 18 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x4AABC70", Offset = "0x4AAA870", VA = "0x184AABC70")]
		internal static Microsoft.Win32.SafeHandles.SafeFileHandle CreateFile(string lpFileName, int dwDesiredAccess, System.IO.FileShare dwShareMode, System.IO.FileMode dwCreationDisposition, int dwFlagsAndAttributes)
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x4AABB30", Offset = "0x4AAA730", VA = "0x184AABB30")]
		internal static System.IntPtr CreateFile_IntPtr(string lpFileName, int dwDesiredAccess, System.IO.FileShare dwShareMode, System.IO.FileMode dwCreationDisposition, int dwFlagsAndAttributes)
		{
			return 0;
		}

		// Token: 0x06000014 RID: 20
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x4AABE30", Offset = "0x4AAAA30", VA = "0x184AABE30")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern bool DeleteFilePrivate(string path);

		// Token: 0x06000015 RID: 21 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x4AABED0", Offset = "0x4AAAAD0", VA = "0x184AABED0")]
		internal static bool DeleteFile(string path)
		{
			return default(bool);
		}

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4AAC170", Offset = "0x4AAAD70", VA = "0x184AAC170")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern SafeFindHandle FindFirstFileExPrivate(string lpFileName, Interop.Kernel32.FINDEX_INFO_LEVELS fInfoLevelId, ref Interop.Kernel32.WIN32_FIND_DATA lpFindFileData, Interop.Kernel32.FINDEX_SEARCH_OPS fSearchOp, System.IntPtr lpSearchFilter, int dwAdditionalFlags);

		// Token: 0x06000017 RID: 23 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x4AAC290", Offset = "0x4AAAE90", VA = "0x184AAC290")]
		internal static SafeFindHandle FindFirstFile(string fileName, ref Interop.Kernel32.WIN32_FIND_DATA data)
		{
			return null;
		}

		// Token: 0x06000018 RID: 24
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x4AAC3E0", Offset = "0x4AAAFE0", VA = "0x184AAC3E0")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern bool FindNextFile(SafeFindHandle hndFindFile, ref Interop.Kernel32.WIN32_FIND_DATA lpFindFileData);

		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x4AAC4C0", Offset = "0x4AAB0C0", VA = "0x184AAC4C0")]
		[System.Runtime.InteropServices.PreserveSig]
		private unsafe static extern int FormatMessage(int dwFlags, System.IntPtr lpSource, uint dwMessageId, int dwLanguageId, char* lpBuffer, int nSize, System.IntPtr[] arguments);

		// Token: 0x0600001A RID: 26 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4AACBD0", Offset = "0x4AAB7D0", VA = "0x184AACBD0")]
		internal static string GetMessage(int errorCode)
		{
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4AACA50", Offset = "0x4AAB650", VA = "0x184AACA50")]
		internal static string GetMessage(System.IntPtr moduleHandle, int errorCode)
		{
			return null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4AAD770", Offset = "0x4AAC370", VA = "0x184AAD770")]
		private static bool TryGetErrorMessage(System.IntPtr moduleHandle, int errorCode, System.Span<char> buffer, out string errorMsg)
		{
			return default(bool);
		}

		// Token: 0x0600001D RID: 29
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4AAC6D0", Offset = "0x4AAB2D0", VA = "0x184AAC6D0")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern bool GetFileAttributesExPrivate(string name, Interop.Kernel32.GET_FILEEX_INFO_LEVELS fileInfoLevel, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA lpFileInformation);

		// Token: 0x0600001E RID: 30 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4AAC780", Offset = "0x4AAB380", VA = "0x184AAC780")]
		internal static bool GetFileAttributesEx(string name, Interop.Kernel32.GET_FILEEX_INFO_LEVELS fileInfoLevel, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA lpFileInformation)
		{
			return default(bool);
		}

		// Token: 0x0600001F RID: 31
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4AAC870", Offset = "0x4AAB470", VA = "0x184AAC870")]
		[System.Runtime.InteropServices.PreserveSig]
		public static extern bool GetFileInformationByHandleEx(System.IntPtr hFile, Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileInformationClass, System.IntPtr lpFileInformation, uint dwBufferSize);

		// Token: 0x06000020 RID: 32
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4AACDA0", Offset = "0x4AAB9A0", VA = "0x184AACDA0")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern bool MoveFileExPrivate(string src, string dst, uint flags);

		// Token: 0x06000021 RID: 33 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4AACE60", Offset = "0x4AABA60", VA = "0x184AACE60")]
		internal static bool MoveFile(string src, string dst)
		{
			return default(bool);
		}

		// Token: 0x06000022 RID: 34
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4AACF60", Offset = "0x4AABB60", VA = "0x184AACF60")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern bool RemoveDirectoryPrivate(string path);

		// Token: 0x06000023 RID: 35 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4AAD000", Offset = "0x4AABC00", VA = "0x184AAD000")]
		internal static bool RemoveDirectory(string path)
		{
			return default(bool);
		}

		// Token: 0x06000024 RID: 36
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4AAD0E0", Offset = "0x4AABCE0", VA = "0x184AAD0E0")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern bool ReplaceFilePrivate(string replacedFileName, string replacementFileName, string backupFileName, int dwReplaceFlags, System.IntPtr lpExclude, System.IntPtr lpReserved);

		// Token: 0x06000025 RID: 37 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4AAD1D0", Offset = "0x4AABDD0", VA = "0x184AAD1D0")]
		internal static bool ReplaceFile(string replacedFileName, string replacementFileName, string backupFileName, int dwReplaceFlags, System.IntPtr lpExclude, System.IntPtr lpReserved)
		{
			return default(bool);
		}

		// Token: 0x06000026 RID: 38
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4AAD320", Offset = "0x4AABF20", VA = "0x184AAD320")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern bool SetFileAttributesPrivate(string name, int attr);

		// Token: 0x06000027 RID: 39 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4AAD3C0", Offset = "0x4AABFC0", VA = "0x184AAD3C0")]
		internal static bool SetFileAttributes(string name, int attr)
		{
			return default(bool);
		}

		// Token: 0x06000028 RID: 40
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x4AAD4A0", Offset = "0x4AAC0A0", VA = "0x184AAD4A0")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern bool SetFileInformationByHandle(Microsoft.Win32.SafeHandles.SafeFileHandle hFile, Interop.Kernel32.FILE_INFO_BY_HANDLE_CLASS FileInformationClass, ref Interop.Kernel32.FILE_BASIC_INFO lpFileInformation, uint dwBufferSize);

		// Token: 0x06000029 RID: 41 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4AAD5A0", Offset = "0x4AAC1A0", VA = "0x184AAD5A0")]
		internal static bool SetFileTime(Microsoft.Win32.SafeHandles.SafeFileHandle hFile, long creationTime = -1L, long lastAccessTime = -1L, long lastWriteTime = -1L, long changeTime = -1L, uint fileAttributes = 0U)
		{
			return default(bool);
		}

		// Token: 0x0600002A RID: 42
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4AAD6D0", Offset = "0x4AAC2D0", VA = "0x184AAD6D0")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern bool SetThreadErrorMode(uint dwNewMode, out uint lpOldMode);

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool useUWPFallback;

		// Token: 0x02000004 RID: 4
		[Token(Token = "0x2000004")]
		[StructLayout(0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
		internal struct WIN32_FIND_DATA
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600002B RID: 43 RVA: 0x000021A8 File Offset: 0x000003A8
			[Token(Token = "0x17000001")]
			internal System.ReadOnlySpan<char> cFileName
			{
				[Token(Token = "0x600002B")]
				[Address(RVA = "0x4ABF7A0", Offset = "0x4ABE3A0", VA = "0x184ABF7A0")]
				get
				{
					return default(System.ReadOnlySpan<char>);
				}
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x4ABF6F0", Offset = "0x4ABE2F0", VA = "0x184ABF6F0")]
			internal void SetFileName(string fileName)
			{
			}

			// Token: 0x04000002 RID: 2
			[Token(Token = "0x4000002")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal uint dwFileAttributes;

			// Token: 0x04000003 RID: 3
			[Token(Token = "0x4000003")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal Interop.Kernel32.FILE_TIME ftCreationTime;

			// Token: 0x04000004 RID: 4
			[Token(Token = "0x4000004")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Interop.Kernel32.FILE_TIME ftLastAccessTime;

			// Token: 0x04000005 RID: 5
			[Token(Token = "0x4000005")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Interop.Kernel32.FILE_TIME ftLastWriteTime;

			// Token: 0x04000006 RID: 6
			[Token(Token = "0x4000006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal uint nFileSizeHigh;

			// Token: 0x04000007 RID: 7
			[Token(Token = "0x4000007")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal uint nFileSizeLow;

			// Token: 0x04000008 RID: 8
			[Token(Token = "0x4000008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal uint dwReserved0;

			// Token: 0x04000009 RID: 9
			[Token(Token = "0x4000009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint dwReserved1;

			// Token: 0x0400000A RID: 10
			[Token(Token = "0x400000A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[System.Runtime.CompilerServices.FixedBuffer(typeof(char), 260)]
			private Interop.Kernel32.WIN32_FIND_DATA.<_cFileName>e__FixedBuffer _cFileName;

			// Token: 0x0400000B RID: 11
			[Token(Token = "0x400000B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
			[System.Runtime.CompilerServices.FixedBuffer(typeof(char), 14)]
			private Interop.Kernel32.WIN32_FIND_DATA.<_cAlternateFileName>e__FixedBuffer _cAlternateFileName;

			// Token: 0x02000005 RID: 5
			[Token(Token = "0x2000005")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			[System.Runtime.CompilerServices.UnsafeValueType]
			[StructLayout(0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
			public struct <_cFileName>e__FixedBuffer
			{
				// Token: 0x0400000C RID: 12
				[Token(Token = "0x400000C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public char FixedElementField;
			}

			// Token: 0x02000006 RID: 6
			[Token(Token = "0x2000006")]
			[System.Runtime.CompilerServices.UnsafeValueType]
			[System.Runtime.CompilerServices.CompilerGenerated]
			[StructLayout(0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
			public struct <_cAlternateFileName>e__FixedBuffer
			{
				// Token: 0x0400000D RID: 13
				[Token(Token = "0x400000D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public char FixedElementField;
			}
		}

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		internal struct REG_TZI_FORMAT
		{
			// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x4AB0C80", Offset = "0x4AAF880", VA = "0x184AB0C80")]
			internal REG_TZI_FORMAT(in Interop.Kernel32.TIME_ZONE_INFORMATION tzi)
			{
			}

			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int Bias;

			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal int StandardBias;

			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int DaylightBias;

			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Interop.Kernel32.SYSTEMTIME StandardDate;

			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal Interop.Kernel32.SYSTEMTIME DaylightDate;
		}

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		internal struct SYSTEMTIME
		{
			// Token: 0x0600002E RID: 46 RVA: 0x000021C0 File Offset: 0x000003C0
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x4AB1940", Offset = "0x4AB0540", VA = "0x184AB1940")]
			internal bool Equals(in Interop.Kernel32.SYSTEMTIME other)
			{
				return default(bool);
			}

			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ushort Year;

			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			internal ushort Month;

			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal ushort DayOfWeek;

			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			internal ushort Day;

			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ushort Hour;

			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			internal ushort Minute;

			// Token: 0x04000019 RID: 25
			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal ushort Second;

			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			internal ushort Milliseconds;
		}

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		[StructLayout(0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
		internal struct TIME_DYNAMIC_ZONE_INFORMATION
		{
			// Token: 0x0600002F RID: 47 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x4ABB270", Offset = "0x4AB9E70", VA = "0x184ABB270")]
			internal string GetTimeZoneKeyName()
			{
				return null;
			}

			// Token: 0x0400001B RID: 27
			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int Bias;

			// Token: 0x0400001C RID: 28
			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[System.Runtime.CompilerServices.FixedBuffer(typeof(char), 32)]
			internal Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.<StandardName>e__FixedBuffer StandardName;

			// Token: 0x0400001D RID: 29
			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal Interop.Kernel32.SYSTEMTIME StandardDate;

			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400001E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal int StandardBias;

			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400001F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[System.Runtime.CompilerServices.FixedBuffer(typeof(char), 32)]
			internal Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.<DaylightName>e__FixedBuffer DaylightName;

			// Token: 0x04000020 RID: 32
			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			internal Interop.Kernel32.SYSTEMTIME DaylightDate;

			// Token: 0x04000021 RID: 33
			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal int DaylightBias;

			// Token: 0x04000022 RID: 34
			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[System.Runtime.CompilerServices.FixedBuffer(typeof(char), 128)]
			internal Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.<TimeZoneKeyName>e__FixedBuffer TimeZoneKeyName;

			// Token: 0x04000023 RID: 35
			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			internal byte DynamicDaylightTimeDisabled;

			// Token: 0x0200000A RID: 10
			[Token(Token = "0x200000A")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			[System.Runtime.CompilerServices.UnsafeValueType]
			[StructLayout(0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
			public struct <StandardName>e__FixedBuffer
			{
				// Token: 0x04000024 RID: 36
				[Token(Token = "0x4000024")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public char FixedElementField;
			}

			// Token: 0x0200000B RID: 11
			[Token(Token = "0x200000B")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			[System.Runtime.CompilerServices.UnsafeValueType]
			[StructLayout(0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
			public struct <DaylightName>e__FixedBuffer
			{
				// Token: 0x04000025 RID: 37
				[Token(Token = "0x4000025")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public char FixedElementField;
			}

			// Token: 0x0200000C RID: 12
			[Token(Token = "0x200000C")]
			[System.Runtime.CompilerServices.UnsafeValueType]
			[System.Runtime.CompilerServices.CompilerGenerated]
			[StructLayout(0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
			public struct <TimeZoneKeyName>e__FixedBuffer
			{
				// Token: 0x04000026 RID: 38
				[Token(Token = "0x4000026")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public char FixedElementField;
			}
		}

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		[StructLayout(0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
		internal struct TIME_ZONE_INFORMATION
		{
			// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x4ABB2B0", Offset = "0x4AB9EB0", VA = "0x184ABB2B0")]
			internal TIME_ZONE_INFORMATION(in Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION dtzi)
			{
			}

			// Token: 0x06000031 RID: 49 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x4ABB2A0", Offset = "0x4AB9EA0", VA = "0x184ABB2A0")]
			internal string GetStandardName()
			{
				return null;
			}

			// Token: 0x06000032 RID: 50 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x4ABB290", Offset = "0x4AB9E90", VA = "0x184ABB290")]
			internal string GetDaylightName()
			{
				return null;
			}

			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int Bias;

			// Token: 0x04000028 RID: 40
			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[System.Runtime.CompilerServices.FixedBuffer(typeof(char), 32)]
			internal Interop.Kernel32.TIME_ZONE_INFORMATION.<StandardName>e__FixedBuffer StandardName;

			// Token: 0x04000029 RID: 41
			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal Interop.Kernel32.SYSTEMTIME StandardDate;

			// Token: 0x0400002A RID: 42
			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal int StandardBias;

			// Token: 0x0400002B RID: 43
			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[System.Runtime.CompilerServices.FixedBuffer(typeof(char), 32)]
			internal Interop.Kernel32.TIME_ZONE_INFORMATION.<DaylightName>e__FixedBuffer DaylightName;

			// Token: 0x0400002C RID: 44
			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			internal Interop.Kernel32.SYSTEMTIME DaylightDate;

			// Token: 0x0400002D RID: 45
			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal int DaylightBias;

			// Token: 0x0200000E RID: 14
			[Token(Token = "0x200000E")]
			[System.Runtime.CompilerServices.UnsafeValueType]
			[System.Runtime.CompilerServices.CompilerGenerated]
			[StructLayout(0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
			public struct <StandardName>e__FixedBuffer
			{
				// Token: 0x0400002E RID: 46
				[Token(Token = "0x400002E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public char FixedElementField;
			}

			// Token: 0x0200000F RID: 15
			[Token(Token = "0x200000F")]
			[System.Runtime.CompilerServices.UnsafeValueType]
			[System.Runtime.CompilerServices.CompilerGenerated]
			[StructLayout(0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
			public struct <DaylightName>e__FixedBuffer
			{
				// Token: 0x0400002F RID: 47
				[Token(Token = "0x400002F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public char FixedElementField;
			}
		}

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		internal struct COPYFILE2_EXTENDED_PARAMETERS
		{
			// Token: 0x04000030 RID: 48
			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal uint dwSize;

			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal uint dwCopyFlags;

			// Token: 0x04000032 RID: 50
			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal System.IntPtr pfCancel;

			// Token: 0x04000033 RID: 51
			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal System.IntPtr pProgressRoutine;

			// Token: 0x04000034 RID: 52
			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal System.IntPtr pvCallbackContext;
		}

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x2000011")]
		internal enum FILE_INFO_BY_HANDLE_CLASS : uint
		{
			// Token: 0x04000036 RID: 54
			[Token(Token = "0x4000036")]
			FileBasicInfo,
			// Token: 0x04000037 RID: 55
			[Token(Token = "0x4000037")]
			FileStandardInfo,
			// Token: 0x04000038 RID: 56
			[Token(Token = "0x4000038")]
			FileNameInfo,
			// Token: 0x04000039 RID: 57
			[Token(Token = "0x4000039")]
			FileRenameInfo,
			// Token: 0x0400003A RID: 58
			[Token(Token = "0x400003A")]
			FileDispositionInfo,
			// Token: 0x0400003B RID: 59
			[Token(Token = "0x400003B")]
			FileAllocationInfo,
			// Token: 0x0400003C RID: 60
			[Token(Token = "0x400003C")]
			FileEndOfFileInfo,
			// Token: 0x0400003D RID: 61
			[Token(Token = "0x400003D")]
			FileStreamInfo,
			// Token: 0x0400003E RID: 62
			[Token(Token = "0x400003E")]
			FileCompressionInfo,
			// Token: 0x0400003F RID: 63
			[Token(Token = "0x400003F")]
			FileAttributeTagInfo,
			// Token: 0x04000040 RID: 64
			[Token(Token = "0x4000040")]
			FileIdBothDirectoryInfo,
			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000041")]
			FileIdBothDirectoryRestartInfo,
			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000042")]
			FileIoPriorityHintInfo,
			// Token: 0x04000043 RID: 67
			[Token(Token = "0x4000043")]
			FileRemoteProtocolInfo,
			// Token: 0x04000044 RID: 68
			[Token(Token = "0x4000044")]
			FileFullDirectoryInfo,
			// Token: 0x04000045 RID: 69
			[Token(Token = "0x4000045")]
			FileFullDirectoryRestartInfo
		}

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x2000012")]
		internal struct FILE_TIME
		{
			// Token: 0x06000033 RID: 51 RVA: 0x000021D8 File Offset: 0x000003D8
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x4AAB0B0", Offset = "0x4AA9CB0", VA = "0x184AAB0B0")]
			internal long ToTicks()
			{
				return 0L;
			}

			// Token: 0x06000034 RID: 52 RVA: 0x000021F0 File Offset: 0x000003F0
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x4AAB030", Offset = "0x4AA9C30", VA = "0x184AAB030")]
			internal System.DateTimeOffset ToDateTimeOffset()
			{
				return default(System.DateTimeOffset);
			}

			// Token: 0x04000046 RID: 70
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal uint dwLowDateTime;

			// Token: 0x04000047 RID: 71
			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal uint dwHighDateTime;
		}

		// Token: 0x02000013 RID: 19
		[Token(Token = "0x2000013")]
		internal enum FINDEX_INFO_LEVELS : uint
		{
			// Token: 0x04000049 RID: 73
			[Token(Token = "0x4000049")]
			FindExInfoStandard,
			// Token: 0x0400004A RID: 74
			[Token(Token = "0x400004A")]
			FindExInfoBasic,
			// Token: 0x0400004B RID: 75
			[Token(Token = "0x400004B")]
			FindExInfoMaxInfoLevel
		}

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		internal enum FINDEX_SEARCH_OPS : uint
		{
			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			FindExSearchNameMatch,
			// Token: 0x0400004E RID: 78
			[Token(Token = "0x400004E")]
			FindExSearchLimitToDirectories,
			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			FindExSearchLimitToDevices,
			// Token: 0x04000050 RID: 80
			[Token(Token = "0x4000050")]
			FindExSearchMaxSearchOp
		}

		// Token: 0x02000015 RID: 21
		[Token(Token = "0x2000015")]
		internal enum GET_FILEEX_INFO_LEVELS : uint
		{
			// Token: 0x04000052 RID: 82
			[Token(Token = "0x4000052")]
			GetFileExInfoStandard,
			// Token: 0x04000053 RID: 83
			[Token(Token = "0x4000053")]
			GetFileExMaxInfoLevel
		}

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		internal struct SECURITY_ATTRIBUTES
		{
			// Token: 0x04000054 RID: 84
			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal uint nLength;

			// Token: 0x04000055 RID: 85
			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal System.IntPtr lpSecurityDescriptor;

			// Token: 0x04000056 RID: 86
			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Interop.BOOL bInheritHandle;
		}

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		internal struct FILE_BASIC_INFO
		{
			// Token: 0x04000057 RID: 87
			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal long CreationTime;

			// Token: 0x04000058 RID: 88
			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal long LastAccessTime;

			// Token: 0x04000059 RID: 89
			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal long LastWriteTime;

			// Token: 0x0400005A RID: 90
			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal long ChangeTime;

			// Token: 0x0400005B RID: 91
			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal uint FileAttributes;
		}

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		internal struct WIN32_FILE_ATTRIBUTE_DATA
		{
			// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x4ABF6C0", Offset = "0x4ABE2C0", VA = "0x184ABF6C0")]
			internal void PopulateFrom(ref Interop.Kernel32.WIN32_FIND_DATA findData)
			{
			}

			// Token: 0x0400005C RID: 92
			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int dwFileAttributes;

			// Token: 0x0400005D RID: 93
			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal Interop.Kernel32.FILE_TIME ftCreationTime;

			// Token: 0x0400005E RID: 94
			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Interop.Kernel32.FILE_TIME ftLastAccessTime;

			// Token: 0x0400005F RID: 95
			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Interop.Kernel32.FILE_TIME ftLastWriteTime;

			// Token: 0x04000060 RID: 96
			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal uint nFileSizeHigh;

			// Token: 0x04000061 RID: 97
			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal uint nFileSizeLow;
		}
	}

	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	internal class BCrypt
	{
		// Token: 0x06000036 RID: 54
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x4AA9D00", Offset = "0x4AA8900", VA = "0x184AA9D00")]
		[System.Runtime.InteropServices.PreserveSig]
		internal unsafe static extern Interop.BCrypt.NTSTATUS BCryptGenRandom(System.IntPtr hAlgorithm, byte* pbBuffer, int cbBuffer, int dwFlags);

		// Token: 0x0200001A RID: 26
		[Token(Token = "0x200001A")]
		internal enum NTSTATUS : uint
		{
			// Token: 0x04000063 RID: 99
			[Token(Token = "0x4000063")]
			STATUS_SUCCESS,
			// Token: 0x04000064 RID: 100
			[Token(Token = "0x4000064")]
			STATUS_NOT_FOUND = 3221226021U,
			// Token: 0x04000065 RID: 101
			[Token(Token = "0x4000065")]
			STATUS_INVALID_PARAMETER = 3221225485U,
			// Token: 0x04000066 RID: 102
			[Token(Token = "0x4000066")]
			STATUS_NO_MEMORY = 3221225495U
		}
	}

	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	internal class User32
	{
		// Token: 0x06000037 RID: 55
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x4ABF590", Offset = "0x4ABE190", VA = "0x184ABF590")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern int LoadString(SafeLibraryHandle handle, int id, [System.Runtime.InteropServices.Out] System.Text.StringBuilder buffer, int bufferLength);
	}

	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	internal enum BOOL
	{
		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		FALSE,
		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		TRUE
	}

	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	internal enum BOOLEAN : byte
	{
		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		FALSE,
		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		TRUE
	}

	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	internal struct LongFileTime
	{
		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal long TicksSince1601;
	}

	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	internal struct UNICODE_STRING
	{
		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal ushort Length;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		internal ushort MaximumLength;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal System.IntPtr Buffer;
	}

	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	internal class NtDll
	{
		// Token: 0x06000038 RID: 56
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x4AB09D0", Offset = "0x4AAF5D0", VA = "0x184AB09D0")]
		[System.Runtime.InteropServices.PreserveSig]
		private unsafe static extern int NtCreateFile(out System.IntPtr FileHandle, Interop.NtDll.DesiredAccess DesiredAccess, ref Interop.NtDll.OBJECT_ATTRIBUTES ObjectAttributes, out Interop.NtDll.IO_STATUS_BLOCK IoStatusBlock, long* AllocationSize, System.IO.FileAttributes FileAttributes, System.IO.FileShare ShareAccess, Interop.NtDll.CreateDisposition CreateDisposition, Interop.NtDll.CreateOptions CreateOptions, void* EaBuffer, uint EaLength);

		// Token: 0x06000039 RID: 57 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x4AB07B0", Offset = "0x4AAF3B0", VA = "0x184AB07B0")]
		internal static System.ValueTuple<int, System.IntPtr> CreateFile(System.ReadOnlySpan<char> path, System.IntPtr rootDirectory, Interop.NtDll.CreateDisposition createDisposition, Interop.NtDll.DesiredAccess desiredAccess = Interop.NtDll.DesiredAccess.SYNCHRONIZE | Interop.NtDll.DesiredAccess.FILE_GENERIC_READ, System.IO.FileShare shareAccess = System.IO.FileShare.Read | System.IO.FileShare.Write | System.IO.FileShare.Delete, System.IO.FileAttributes fileAttributes = (System.IO.FileAttributes)0, Interop.NtDll.CreateOptions createOptions = Interop.NtDll.CreateOptions.FILE_SYNCHRONOUS_IO_NONALERT, Interop.NtDll.ObjectAttributes objectAttributes = Interop.NtDll.ObjectAttributes.OBJ_CASE_INSENSITIVE)
		{
			return default(System.ValueTuple<int, System.IntPtr>);
		}

		// Token: 0x0600003A RID: 58
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x4AB0AD0", Offset = "0x4AAF6D0", VA = "0x184AB0AD0")]
		[System.Runtime.InteropServices.PreserveSig]
		public unsafe static extern int NtQueryDirectoryFile(System.IntPtr FileHandle, System.IntPtr Event, System.IntPtr ApcRoutine, System.IntPtr ApcContext, out Interop.NtDll.IO_STATUS_BLOCK IoStatusBlock, System.IntPtr FileInformation, uint Length, Interop.NtDll.FILE_INFORMATION_CLASS FileInformationClass, Interop.BOOLEAN ReturnSingleEntry, Interop.UNICODE_STRING* FileName, Interop.BOOLEAN RestartScan);

		// Token: 0x0600003B RID: 59
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x4AB0BD0", Offset = "0x4AAF7D0", VA = "0x184AB0BD0")]
		[System.Runtime.InteropServices.PreserveSig]
		public static extern uint RtlNtStatusToDosError(int Status);

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x2000021")]
		[StructLayout(0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
		public struct FILE_FULL_DIR_INFORMATION
		{
			// Token: 0x17000002 RID: 2
			// (get) Token: 0x0600003C RID: 60 RVA: 0x00002220 File Offset: 0x00000420
			[Token(Token = "0x17000002")]
			public System.ReadOnlySpan<char> FileName
			{
				[Token(Token = "0x600003C")]
				[Address(RVA = "0x4AAAFA0", Offset = "0x4AA9BA0", VA = "0x184AAAFA0")]
				get
				{
					return default(System.ReadOnlySpan<char>);
				}
			}

			// Token: 0x0600003D RID: 61 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x4AAAF80", Offset = "0x4AA9B80", VA = "0x184AAAF80")]
			public unsafe static Interop.NtDll.FILE_FULL_DIR_INFORMATION* GetNextInfo(Interop.NtDll.FILE_FULL_DIR_INFORMATION* info)
			{
				return null;
			}

			// Token: 0x04000071 RID: 113
			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint NextEntryOffset;

			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint FileIndex;

			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Interop.LongFileTime CreationTime;

			// Token: 0x04000074 RID: 116
			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Interop.LongFileTime LastAccessTime;

			// Token: 0x04000075 RID: 117
			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Interop.LongFileTime LastWriteTime;

			// Token: 0x04000076 RID: 118
			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Interop.LongFileTime ChangeTime;

			// Token: 0x04000077 RID: 119
			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public long EndOfFile;

			// Token: 0x04000078 RID: 120
			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public long AllocationSize;

			// Token: 0x04000079 RID: 121
			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public System.IO.FileAttributes FileAttributes;

			// Token: 0x0400007A RID: 122
			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public uint FileNameLength;

			// Token: 0x0400007B RID: 123
			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public uint EaSize;

			// Token: 0x0400007C RID: 124
			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private char _fileName;
		}

		// Token: 0x02000022 RID: 34
		[Token(Token = "0x2000022")]
		public enum FILE_INFORMATION_CLASS : uint
		{
			// Token: 0x0400007E RID: 126
			[Token(Token = "0x400007E")]
			FileDirectoryInformation = 1U,
			// Token: 0x0400007F RID: 127
			[Token(Token = "0x400007F")]
			FileFullDirectoryInformation,
			// Token: 0x04000080 RID: 128
			[Token(Token = "0x4000080")]
			FileBothDirectoryInformation,
			// Token: 0x04000081 RID: 129
			[Token(Token = "0x4000081")]
			FileBasicInformation,
			// Token: 0x04000082 RID: 130
			[Token(Token = "0x4000082")]
			FileStandardInformation,
			// Token: 0x04000083 RID: 131
			[Token(Token = "0x4000083")]
			FileInternalInformation,
			// Token: 0x04000084 RID: 132
			[Token(Token = "0x4000084")]
			FileEaInformation,
			// Token: 0x04000085 RID: 133
			[Token(Token = "0x4000085")]
			FileAccessInformation,
			// Token: 0x04000086 RID: 134
			[Token(Token = "0x4000086")]
			FileNameInformation,
			// Token: 0x04000087 RID: 135
			[Token(Token = "0x4000087")]
			FileRenameInformation,
			// Token: 0x04000088 RID: 136
			[Token(Token = "0x4000088")]
			FileLinkInformation,
			// Token: 0x04000089 RID: 137
			[Token(Token = "0x4000089")]
			FileNamesInformation,
			// Token: 0x0400008A RID: 138
			[Token(Token = "0x400008A")]
			FileDispositionInformation,
			// Token: 0x0400008B RID: 139
			[Token(Token = "0x400008B")]
			FilePositionInformation,
			// Token: 0x0400008C RID: 140
			[Token(Token = "0x400008C")]
			FileFullEaInformation,
			// Token: 0x0400008D RID: 141
			[Token(Token = "0x400008D")]
			FileModeInformation,
			// Token: 0x0400008E RID: 142
			[Token(Token = "0x400008E")]
			FileAlignmentInformation,
			// Token: 0x0400008F RID: 143
			[Token(Token = "0x400008F")]
			FileAllInformation,
			// Token: 0x04000090 RID: 144
			[Token(Token = "0x4000090")]
			FileAllocationInformation,
			// Token: 0x04000091 RID: 145
			[Token(Token = "0x4000091")]
			FileEndOfFileInformation,
			// Token: 0x04000092 RID: 146
			[Token(Token = "0x4000092")]
			FileAlternateNameInformation,
			// Token: 0x04000093 RID: 147
			[Token(Token = "0x4000093")]
			FileStreamInformation,
			// Token: 0x04000094 RID: 148
			[Token(Token = "0x4000094")]
			FilePipeInformation,
			// Token: 0x04000095 RID: 149
			[Token(Token = "0x4000095")]
			FilePipeLocalInformation,
			// Token: 0x04000096 RID: 150
			[Token(Token = "0x4000096")]
			FilePipeRemoteInformation,
			// Token: 0x04000097 RID: 151
			[Token(Token = "0x4000097")]
			FileMailslotQueryInformation,
			// Token: 0x04000098 RID: 152
			[Token(Token = "0x4000098")]
			FileMailslotSetInformation,
			// Token: 0x04000099 RID: 153
			[Token(Token = "0x4000099")]
			FileCompressionInformation,
			// Token: 0x0400009A RID: 154
			[Token(Token = "0x400009A")]
			FileObjectIdInformation,
			// Token: 0x0400009B RID: 155
			[Token(Token = "0x400009B")]
			FileCompletionInformation,
			// Token: 0x0400009C RID: 156
			[Token(Token = "0x400009C")]
			FileMoveClusterInformation,
			// Token: 0x0400009D RID: 157
			[Token(Token = "0x400009D")]
			FileQuotaInformation,
			// Token: 0x0400009E RID: 158
			[Token(Token = "0x400009E")]
			FileReparsePointInformation,
			// Token: 0x0400009F RID: 159
			[Token(Token = "0x400009F")]
			FileNetworkOpenInformation,
			// Token: 0x040000A0 RID: 160
			[Token(Token = "0x40000A0")]
			FileAttributeTagInformation,
			// Token: 0x040000A1 RID: 161
			[Token(Token = "0x40000A1")]
			FileTrackingInformation,
			// Token: 0x040000A2 RID: 162
			[Token(Token = "0x40000A2")]
			FileIdBothDirectoryInformation,
			// Token: 0x040000A3 RID: 163
			[Token(Token = "0x40000A3")]
			FileIdFullDirectoryInformation,
			// Token: 0x040000A4 RID: 164
			[Token(Token = "0x40000A4")]
			FileValidDataLengthInformation,
			// Token: 0x040000A5 RID: 165
			[Token(Token = "0x40000A5")]
			FileShortNameInformation,
			// Token: 0x040000A6 RID: 166
			[Token(Token = "0x40000A6")]
			FileIoCompletionNotificationInformation,
			// Token: 0x040000A7 RID: 167
			[Token(Token = "0x40000A7")]
			FileIoStatusBlockRangeInformation,
			// Token: 0x040000A8 RID: 168
			[Token(Token = "0x40000A8")]
			FileIoPriorityHintInformation,
			// Token: 0x040000A9 RID: 169
			[Token(Token = "0x40000A9")]
			FileSfioReserveInformation,
			// Token: 0x040000AA RID: 170
			[Token(Token = "0x40000AA")]
			FileSfioVolumeInformation,
			// Token: 0x040000AB RID: 171
			[Token(Token = "0x40000AB")]
			FileHardLinkInformation,
			// Token: 0x040000AC RID: 172
			[Token(Token = "0x40000AC")]
			FileProcessIdsUsingFileInformation,
			// Token: 0x040000AD RID: 173
			[Token(Token = "0x40000AD")]
			FileNormalizedNameInformation,
			// Token: 0x040000AE RID: 174
			[Token(Token = "0x40000AE")]
			FileNetworkPhysicalNameInformation,
			// Token: 0x040000AF RID: 175
			[Token(Token = "0x40000AF")]
			FileIdGlobalTxDirectoryInformation,
			// Token: 0x040000B0 RID: 176
			[Token(Token = "0x40000B0")]
			FileIsRemoteDeviceInformation,
			// Token: 0x040000B1 RID: 177
			[Token(Token = "0x40000B1")]
			FileUnusedInformation,
			// Token: 0x040000B2 RID: 178
			[Token(Token = "0x40000B2")]
			FileNumaNodeInformation,
			// Token: 0x040000B3 RID: 179
			[Token(Token = "0x40000B3")]
			FileStandardLinkInformation,
			// Token: 0x040000B4 RID: 180
			[Token(Token = "0x40000B4")]
			FileRemoteProtocolInformation,
			// Token: 0x040000B5 RID: 181
			[Token(Token = "0x40000B5")]
			FileRenameInformationBypassAccessCheck,
			// Token: 0x040000B6 RID: 182
			[Token(Token = "0x40000B6")]
			FileLinkInformationBypassAccessCheck,
			// Token: 0x040000B7 RID: 183
			[Token(Token = "0x40000B7")]
			FileVolumeNameInformation,
			// Token: 0x040000B8 RID: 184
			[Token(Token = "0x40000B8")]
			FileIdInformation,
			// Token: 0x040000B9 RID: 185
			[Token(Token = "0x40000B9")]
			FileIdExtdDirectoryInformation,
			// Token: 0x040000BA RID: 186
			[Token(Token = "0x40000BA")]
			FileReplaceCompletionInformation,
			// Token: 0x040000BB RID: 187
			[Token(Token = "0x40000BB")]
			FileHardLinkFullIdInformation,
			// Token: 0x040000BC RID: 188
			[Token(Token = "0x40000BC")]
			FileIdExtdBothDirectoryInformation,
			// Token: 0x040000BD RID: 189
			[Token(Token = "0x40000BD")]
			FileDispositionInformationEx,
			// Token: 0x040000BE RID: 190
			[Token(Token = "0x40000BE")]
			FileRenameInformationEx,
			// Token: 0x040000BF RID: 191
			[Token(Token = "0x40000BF")]
			FileRenameInformationExBypassAccessCheck,
			// Token: 0x040000C0 RID: 192
			[Token(Token = "0x40000C0")]
			FileDesiredStorageClassInformation,
			// Token: 0x040000C1 RID: 193
			[Token(Token = "0x40000C1")]
			FileStatInformation
		}

		// Token: 0x02000023 RID: 35
		[Token(Token = "0x2000023")]
		public struct IO_STATUS_BLOCK
		{
			// Token: 0x040000C2 RID: 194
			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Interop.NtDll.IO_STATUS_BLOCK.IO_STATUS Status;

			// Token: 0x040000C3 RID: 195
			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public System.IntPtr Information;

			// Token: 0x02000024 RID: 36
			[Token(Token = "0x2000024")]
			[StructLayout(2)]
			public struct IO_STATUS
			{
				// Token: 0x040000C4 RID: 196
				[Token(Token = "0x40000C4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public uint Status;

				// Token: 0x040000C5 RID: 197
				[Token(Token = "0x40000C5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public System.IntPtr Pointer;
			}
		}

		// Token: 0x02000025 RID: 37
		[Token(Token = "0x2000025")]
		public struct OBJECT_ATTRIBUTES
		{
			// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x4AB0C50", Offset = "0x4AAF850", VA = "0x184AB0C50")]
			public unsafe OBJECT_ATTRIBUTES(Interop.UNICODE_STRING* objectName, Interop.NtDll.ObjectAttributes attributes, System.IntPtr rootDirectory)
			{
			}

			// Token: 0x040000C6 RID: 198
			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint Length;

			// Token: 0x040000C7 RID: 199
			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public System.IntPtr RootDirectory;

			// Token: 0x040000C8 RID: 200
			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public unsafe Interop.UNICODE_STRING* ObjectName;

			// Token: 0x040000C9 RID: 201
			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Interop.NtDll.ObjectAttributes Attributes;

			// Token: 0x040000CA RID: 202
			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public unsafe void* SecurityDescriptor;

			// Token: 0x040000CB RID: 203
			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public unsafe void* SecurityQualityOfService;
		}

		// Token: 0x02000026 RID: 38
		[Token(Token = "0x2000026")]
		[System.Flags]
		public enum ObjectAttributes : uint
		{
			// Token: 0x040000CD RID: 205
			[Token(Token = "0x40000CD")]
			OBJ_INHERIT = 2U,
			// Token: 0x040000CE RID: 206
			[Token(Token = "0x40000CE")]
			OBJ_PERMANENT = 16U,
			// Token: 0x040000CF RID: 207
			[Token(Token = "0x40000CF")]
			OBJ_EXCLUSIVE = 32U,
			// Token: 0x040000D0 RID: 208
			[Token(Token = "0x40000D0")]
			OBJ_CASE_INSENSITIVE = 64U,
			// Token: 0x040000D1 RID: 209
			[Token(Token = "0x40000D1")]
			OBJ_OPENIF = 128U,
			// Token: 0x040000D2 RID: 210
			[Token(Token = "0x40000D2")]
			OBJ_OPENLINK = 256U
		}

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		public enum CreateDisposition : uint
		{
			// Token: 0x040000D4 RID: 212
			[Token(Token = "0x40000D4")]
			FILE_SUPERSEDE,
			// Token: 0x040000D5 RID: 213
			[Token(Token = "0x40000D5")]
			FILE_OPEN,
			// Token: 0x040000D6 RID: 214
			[Token(Token = "0x40000D6")]
			FILE_CREATE,
			// Token: 0x040000D7 RID: 215
			[Token(Token = "0x40000D7")]
			FILE_OPEN_IF,
			// Token: 0x040000D8 RID: 216
			[Token(Token = "0x40000D8")]
			FILE_OVERWRITE,
			// Token: 0x040000D9 RID: 217
			[Token(Token = "0x40000D9")]
			FILE_OVERWRITE_IF
		}

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		public enum CreateOptions : uint
		{
			// Token: 0x040000DB RID: 219
			[Token(Token = "0x40000DB")]
			FILE_DIRECTORY_FILE = 1U,
			// Token: 0x040000DC RID: 220
			[Token(Token = "0x40000DC")]
			FILE_WRITE_THROUGH,
			// Token: 0x040000DD RID: 221
			[Token(Token = "0x40000DD")]
			FILE_SEQUENTIAL_ONLY = 4U,
			// Token: 0x040000DE RID: 222
			[Token(Token = "0x40000DE")]
			FILE_NO_INTERMEDIATE_BUFFERING = 8U,
			// Token: 0x040000DF RID: 223
			[Token(Token = "0x40000DF")]
			FILE_SYNCHRONOUS_IO_ALERT = 16U,
			// Token: 0x040000E0 RID: 224
			[Token(Token = "0x40000E0")]
			FILE_SYNCHRONOUS_IO_NONALERT = 32U,
			// Token: 0x040000E1 RID: 225
			[Token(Token = "0x40000E1")]
			FILE_NON_DIRECTORY_FILE = 64U,
			// Token: 0x040000E2 RID: 226
			[Token(Token = "0x40000E2")]
			FILE_CREATE_TREE_CONNECTION = 128U,
			// Token: 0x040000E3 RID: 227
			[Token(Token = "0x40000E3")]
			FILE_COMPLETE_IF_OPLOCKED = 256U,
			// Token: 0x040000E4 RID: 228
			[Token(Token = "0x40000E4")]
			FILE_NO_EA_KNOWLEDGE = 512U,
			// Token: 0x040000E5 RID: 229
			[Token(Token = "0x40000E5")]
			FILE_RANDOM_ACCESS = 2048U,
			// Token: 0x040000E6 RID: 230
			[Token(Token = "0x40000E6")]
			FILE_DELETE_ON_CLOSE = 4096U,
			// Token: 0x040000E7 RID: 231
			[Token(Token = "0x40000E7")]
			FILE_OPEN_BY_FILE_ID = 8192U,
			// Token: 0x040000E8 RID: 232
			[Token(Token = "0x40000E8")]
			FILE_OPEN_FOR_BACKUP_INTENT = 16384U,
			// Token: 0x040000E9 RID: 233
			[Token(Token = "0x40000E9")]
			FILE_NO_COMPRESSION = 32768U,
			// Token: 0x040000EA RID: 234
			[Token(Token = "0x40000EA")]
			FILE_OPEN_REQUIRING_OPLOCK = 65536U,
			// Token: 0x040000EB RID: 235
			[Token(Token = "0x40000EB")]
			FILE_DISALLOW_EXCLUSIVE = 131072U,
			// Token: 0x040000EC RID: 236
			[Token(Token = "0x40000EC")]
			FILE_SESSION_AWARE = 262144U,
			// Token: 0x040000ED RID: 237
			[Token(Token = "0x40000ED")]
			FILE_RESERVE_OPFILTER = 1048576U,
			// Token: 0x040000EE RID: 238
			[Token(Token = "0x40000EE")]
			FILE_OPEN_REPARSE_POINT = 2097152U,
			// Token: 0x040000EF RID: 239
			[Token(Token = "0x40000EF")]
			FILE_OPEN_NO_RECALL = 4194304U
		}

		// Token: 0x02000029 RID: 41
		[Token(Token = "0x2000029")]
		[System.Flags]
		public enum DesiredAccess : uint
		{
			// Token: 0x040000F1 RID: 241
			[Token(Token = "0x40000F1")]
			FILE_READ_DATA = 1U,
			// Token: 0x040000F2 RID: 242
			[Token(Token = "0x40000F2")]
			FILE_LIST_DIRECTORY = 1U,
			// Token: 0x040000F3 RID: 243
			[Token(Token = "0x40000F3")]
			FILE_WRITE_DATA = 2U,
			// Token: 0x040000F4 RID: 244
			[Token(Token = "0x40000F4")]
			FILE_ADD_FILE = 2U,
			// Token: 0x040000F5 RID: 245
			[Token(Token = "0x40000F5")]
			FILE_APPEND_DATA = 4U,
			// Token: 0x040000F6 RID: 246
			[Token(Token = "0x40000F6")]
			FILE_ADD_SUBDIRECTORY = 4U,
			// Token: 0x040000F7 RID: 247
			[Token(Token = "0x40000F7")]
			FILE_CREATE_PIPE_INSTANCE = 4U,
			// Token: 0x040000F8 RID: 248
			[Token(Token = "0x40000F8")]
			FILE_READ_EA = 8U,
			// Token: 0x040000F9 RID: 249
			[Token(Token = "0x40000F9")]
			FILE_WRITE_EA = 16U,
			// Token: 0x040000FA RID: 250
			[Token(Token = "0x40000FA")]
			FILE_EXECUTE = 32U,
			// Token: 0x040000FB RID: 251
			[Token(Token = "0x40000FB")]
			FILE_TRAVERSE = 32U,
			// Token: 0x040000FC RID: 252
			[Token(Token = "0x40000FC")]
			FILE_DELETE_CHILD = 64U,
			// Token: 0x040000FD RID: 253
			[Token(Token = "0x40000FD")]
			FILE_READ_ATTRIBUTES = 128U,
			// Token: 0x040000FE RID: 254
			[Token(Token = "0x40000FE")]
			FILE_WRITE_ATTRIBUTES = 256U,
			// Token: 0x040000FF RID: 255
			[Token(Token = "0x40000FF")]
			FILE_ALL_ACCESS = 983551U,
			// Token: 0x04000100 RID: 256
			[Token(Token = "0x4000100")]
			DELETE = 65536U,
			// Token: 0x04000101 RID: 257
			[Token(Token = "0x4000101")]
			READ_CONTROL = 131072U,
			// Token: 0x04000102 RID: 258
			[Token(Token = "0x4000102")]
			WRITE_DAC = 262144U,
			// Token: 0x04000103 RID: 259
			[Token(Token = "0x4000103")]
			WRITE_OWNER = 524288U,
			// Token: 0x04000104 RID: 260
			[Token(Token = "0x4000104")]
			SYNCHRONIZE = 1048576U,
			// Token: 0x04000105 RID: 261
			[Token(Token = "0x4000105")]
			STANDARD_RIGHTS_READ = 131072U,
			// Token: 0x04000106 RID: 262
			[Token(Token = "0x4000106")]
			STANDARD_RIGHTS_WRITE = 131072U,
			// Token: 0x04000107 RID: 263
			[Token(Token = "0x4000107")]
			STANDARD_RIGHTS_EXECUTE = 131072U,
			// Token: 0x04000108 RID: 264
			[Token(Token = "0x4000108")]
			FILE_GENERIC_READ = 2147483648U,
			// Token: 0x04000109 RID: 265
			[Token(Token = "0x4000109")]
			FILE_GENERIC_WRITE = 1073741824U,
			// Token: 0x0400010A RID: 266
			[Token(Token = "0x400010A")]
			FILE_GENERIC_EXECUTE = 536870912U
		}
	}

	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	internal class Advapi32
	{
		// Token: 0x0600003F RID: 63
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x4AA8DB0", Offset = "0x4AA79B0", VA = "0x184AA8DB0")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern int RegCloseKey(System.IntPtr hKey);

		// Token: 0x06000040 RID: 64
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4AA8E30", Offset = "0x4AA7A30", VA = "0x184AA8E30")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern int RegEnumKeyEx(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, int dwIndex, char[] lpName, ref int lpcbName, int[] lpReserved, [System.Runtime.InteropServices.Out] System.Text.StringBuilder lpClass, int[] lpcbClass, long[] lpftLastWriteTime);

		// Token: 0x06000041 RID: 65
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x4AA8FC0", Offset = "0x4AA7BC0", VA = "0x184AA8FC0")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern int RegOpenKeyEx(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, string lpSubKey, int ulOptions, int samDesired, out Microsoft.Win32.SafeHandles.SafeRegistryHandle hkResult);

		// Token: 0x06000042 RID: 66
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x4AA9130", Offset = "0x4AA7D30", VA = "0x184AA9130")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern int RegQueryInfoKey(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, [System.Runtime.InteropServices.Out] System.Text.StringBuilder lpClass, int[] lpcbClass, System.IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, int[] lpcbMaxSubKeyLen, int[] lpcbMaxClassLen, ref int lpcValues, int[] lpcbMaxValueNameLen, int[] lpcbMaxValueLen, int[] lpcbSecurityDescriptor, int[] lpftLastWriteTime);

		// Token: 0x06000043 RID: 67
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x4AA9580", Offset = "0x4AA8180", VA = "0x184AA9580")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern int RegQueryValueEx(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, [System.Runtime.InteropServices.Out] byte[] lpData, ref int lpcbData);

		// Token: 0x06000044 RID: 68
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x4AA9340", Offset = "0x4AA7F40", VA = "0x184AA9340")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern int RegQueryValueEx(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, ref int lpData, ref int lpcbData);

		// Token: 0x06000045 RID: 69
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4AA9460", Offset = "0x4AA8060", VA = "0x184AA9460")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern int RegQueryValueEx(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, ref long lpData, ref int lpcbData);

		// Token: 0x06000046 RID: 70
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4AA9720", Offset = "0x4AA8320", VA = "0x184AA9720")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern int RegQueryValueEx(Microsoft.Win32.SafeHandles.SafeRegistryHandle hKey, string lpValueName, int[] lpReserved, ref int lpType, [System.Runtime.InteropServices.Out] char[] lpData, ref int lpcbData);
	}
}
