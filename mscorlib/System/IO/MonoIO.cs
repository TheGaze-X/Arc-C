using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000683 RID: 1667
	[Token(Token = "0x2000683")]
	internal static class MonoIO
	{
		// Token: 0x060032BE RID: 12990 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032BE")]
		[Address(RVA = "0x4C9AC90", Offset = "0x4C99890", VA = "0x184C9AC90")]
		public static System.Exception GetException(MonoIOError error)
		{
			return null;
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60032BF")]
		[Address(RVA = "0x4C9A4A0", Offset = "0x4C990A0", VA = "0x184C9A4A0")]
		public static System.Exception GetException(string path, MonoIOError error)
		{
			return null;
		}

		// Token: 0x060032C0 RID: 12992
		[Token(Token = "0x60032C0")]
		[Address(RVA = "0x4C9A490", Offset = "0x4C99090", VA = "0x184C9A490")]
		[MethodImpl(4096)]
		public static extern string GetCurrentDirectory(out MonoIOError error);

		// Token: 0x060032C1 RID: 12993
		[Token(Token = "0x60032C1")]
		[Address(RVA = "0x4C9B340", Offset = "0x4C99F40", VA = "0x184C9B340")]
		[MethodImpl(4096)]
		private unsafe static extern bool SetFileAttributes(char* path, FileAttributes attrs, out MonoIOError error);

		// Token: 0x060032C2 RID: 12994 RVA: 0x0001B1E0 File Offset: 0x000193E0
		[Token(Token = "0x60032C2")]
		[Address(RVA = "0x4C9B350", Offset = "0x4C99F50", VA = "0x184C9B350")]
		public static bool SetFileAttributes(string path, FileAttributes attrs, out MonoIOError error)
		{
			return default(bool);
		}

		// Token: 0x060032C3 RID: 12995
		[Token(Token = "0x60032C3")]
		[Address(RVA = "0x4C9AEC0", Offset = "0x4C99AC0", VA = "0x184C9AEC0")]
		[MethodImpl(4096)]
		private static extern MonoFileType GetFileType(System.IntPtr handle, out MonoIOError error);

		// Token: 0x060032C4 RID: 12996 RVA: 0x0001B1F8 File Offset: 0x000193F8
		[Token(Token = "0x60032C4")]
		[Address(RVA = "0x4C9ADB0", Offset = "0x4C999B0", VA = "0x184C9ADB0")]
		public static MonoFileType GetFileType(System.Runtime.InteropServices.SafeHandle safeHandle, out MonoIOError error)
		{
			return MonoFileType.Unknown;
		}

		// Token: 0x060032C5 RID: 12997
		[Token(Token = "0x60032C5")]
		[Address(RVA = "0x4C9A480", Offset = "0x4C99080", VA = "0x184C9A480")]
		[MethodImpl(4096)]
		public static extern bool FindCloseFile(System.IntPtr hnd);

		// Token: 0x060032C6 RID: 12998
		[Token(Token = "0x60032C6")]
		[Address(RVA = "0x4C9AFF0", Offset = "0x4C99BF0", VA = "0x184C9AFF0")]
		[MethodImpl(4096)]
		private unsafe static extern System.IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error);

		// Token: 0x060032C7 RID: 12999 RVA: 0x0001B210 File Offset: 0x00019410
		[Token(Token = "0x60032C7")]
		[Address(RVA = "0x4C9B000", Offset = "0x4C99C00", VA = "0x184C9B000")]
		public static System.IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error)
		{
			return 0;
		}

		// Token: 0x060032C8 RID: 13000
		[Token(Token = "0x60032C8")]
		[Address(RVA = "0x4C9A320", Offset = "0x4C98F20", VA = "0x184C9A320")]
		[MethodImpl(4096)]
		private static extern bool Cancel_internal(System.IntPtr handle, out MonoIOError error);

		// Token: 0x060032C9 RID: 13001 RVA: 0x0001B228 File Offset: 0x00019428
		[Token(Token = "0x60032C9")]
		[Address(RVA = "0x4C9A330", Offset = "0x4C98F30", VA = "0x184C9A330")]
		internal static bool Cancel(System.Runtime.InteropServices.SafeHandle safeHandle, out MonoIOError error)
		{
			return default(bool);
		}

		// Token: 0x060032CA RID: 13002
		[Token(Token = "0x60032CA")]
		[Address(RVA = "0x4C9A450", Offset = "0x4C99050", VA = "0x184C9A450")]
		[MethodImpl(4096)]
		public static extern bool Close(System.IntPtr handle, out MonoIOError error);

		// Token: 0x060032CB RID: 13003
		[Token(Token = "0x60032CB")]
		[Address(RVA = "0x4C9B1D0", Offset = "0x4C99DD0", VA = "0x184C9B1D0")]
		[MethodImpl(4096)]
		private static extern int Read(System.IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error);

		// Token: 0x060032CC RID: 13004 RVA: 0x0001B240 File Offset: 0x00019440
		[Token(Token = "0x60032CC")]
		[Address(RVA = "0x4C9B090", Offset = "0x4C99C90", VA = "0x184C9B090")]
		public static int Read(System.Runtime.InteropServices.SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error)
		{
			return 0;
		}

		// Token: 0x060032CD RID: 13005
		[Token(Token = "0x60032CD")]
		[Address(RVA = "0x4C9B650", Offset = "0x4C9A250", VA = "0x184C9B650")]
		[MethodImpl(4096)]
		private static extern int Write(System.IntPtr handle, [System.Runtime.InteropServices.In] byte[] src, int src_offset, int count, out MonoIOError error);

		// Token: 0x060032CE RID: 13006 RVA: 0x0001B258 File Offset: 0x00019458
		[Token(Token = "0x60032CE")]
		[Address(RVA = "0x4C9B510", Offset = "0x4C9A110", VA = "0x184C9B510")]
		public static int Write(System.Runtime.InteropServices.SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error)
		{
			return 0;
		}

		// Token: 0x060032CF RID: 13007
		[Token(Token = "0x60032CF")]
		[Address(RVA = "0x4C9B330", Offset = "0x4C99F30", VA = "0x184C9B330")]
		[MethodImpl(4096)]
		private static extern long Seek(System.IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error);

		// Token: 0x060032D0 RID: 13008 RVA: 0x0001B270 File Offset: 0x00019470
		[Token(Token = "0x60032D0")]
		[Address(RVA = "0x4C9B1F0", Offset = "0x4C99DF0", VA = "0x184C9B1F0")]
		public static long Seek(System.Runtime.InteropServices.SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error)
		{
			return 0L;
		}

		// Token: 0x060032D1 RID: 13009
		[Token(Token = "0x60032D1")]
		[Address(RVA = "0x4C9AED0", Offset = "0x4C99AD0", VA = "0x184C9AED0")]
		[MethodImpl(4096)]
		private static extern long GetLength(System.IntPtr handle, out MonoIOError error);

		// Token: 0x060032D2 RID: 13010 RVA: 0x0001B288 File Offset: 0x00019488
		[Token(Token = "0x60032D2")]
		[Address(RVA = "0x4C9AEE0", Offset = "0x4C99AE0", VA = "0x184C9AEE0")]
		public static long GetLength(System.Runtime.InteropServices.SafeHandle safeHandle, out MonoIOError error)
		{
			return 0L;
		}

		// Token: 0x060032D3 RID: 13011
		[Token(Token = "0x60032D3")]
		[Address(RVA = "0x4C9B3D0", Offset = "0x4C99FD0", VA = "0x184C9B3D0")]
		[MethodImpl(4096)]
		private static extern bool SetLength(System.IntPtr handle, long length, out MonoIOError error);

		// Token: 0x060032D4 RID: 13012 RVA: 0x0001B2A0 File Offset: 0x000194A0
		[Token(Token = "0x60032D4")]
		[Address(RVA = "0x4C9B3E0", Offset = "0x4C99FE0", VA = "0x184C9B3E0")]
		public static bool SetLength(System.Runtime.InteropServices.SafeHandle safeHandle, long length, out MonoIOError error)
		{
			return default(bool);
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060032D5 RID: 13013
		[Token(Token = "0x17000820")]
		public static extern System.IntPtr ConsoleOutput { [Token(Token = "0x60032D5")] [Address(RVA = "0x4C9B710", Offset = "0x4C9A310", VA = "0x184C9B710")] [MethodImpl(4096)] get; }

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060032D6 RID: 13014
		[Token(Token = "0x17000821")]
		public static extern System.IntPtr ConsoleInput { [Token(Token = "0x60032D6")] [Address(RVA = "0x4C9B700", Offset = "0x4C9A300", VA = "0x184C9B700")] [MethodImpl(4096)] get; }

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060032D7 RID: 13015
		[Token(Token = "0x17000822")]
		public static extern System.IntPtr ConsoleError { [Token(Token = "0x60032D7")] [Address(RVA = "0x4C9B6F0", Offset = "0x4C9A2F0", VA = "0x184C9B6F0")] [MethodImpl(4096)] get; }

		// Token: 0x060032D8 RID: 13016
		[Token(Token = "0x60032D8")]
		[Address(RVA = "0x4C9A460", Offset = "0x4C99060", VA = "0x184C9A460")]
		[MethodImpl(4096)]
		public static extern bool CreatePipe(out System.IntPtr read_handle, out System.IntPtr write_handle, out MonoIOError error);

		// Token: 0x060032D9 RID: 13017
		[Token(Token = "0x60032D9")]
		[Address(RVA = "0x4C9A470", Offset = "0x4C99070", VA = "0x184C9A470")]
		[MethodImpl(4096)]
		public static extern bool DuplicateHandle(System.IntPtr source_process_handle, System.IntPtr source_handle, System.IntPtr target_process_handle, out System.IntPtr target_handle, int access, int inherit, int options, out MonoIOError error);

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060032DA RID: 13018
		[Token(Token = "0x17000823")]
		public static extern char VolumeSeparatorChar { [Token(Token = "0x60032DA")] [Address(RVA = "0x4C9B740", Offset = "0x4C9A340", VA = "0x184C9B740")] [MethodImpl(4096)] get; }

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060032DB RID: 13019
		[Token(Token = "0x17000824")]
		public static extern char DirectorySeparatorChar { [Token(Token = "0x60032DB")] [Address(RVA = "0x4C9B720", Offset = "0x4C9A320", VA = "0x184C9B720")] [MethodImpl(4096)] get; }

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060032DC RID: 13020
		[Token(Token = "0x17000825")]
		public static extern char AltDirectorySeparatorChar { [Token(Token = "0x60032DC")] [Address(RVA = "0x4C9B6E0", Offset = "0x4C9A2E0", VA = "0x184C9B6E0")] [MethodImpl(4096)] get; }

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060032DD RID: 13021
		[Token(Token = "0x17000826")]
		public static extern char PathSeparator { [Token(Token = "0x60032DD")] [Address(RVA = "0x4C9B730", Offset = "0x4C9A330", VA = "0x184C9B730")] [MethodImpl(4096)] get; }

		// Token: 0x060032DE RID: 13022
		[Token(Token = "0x60032DE")]
		[Address(RVA = "0x4AEF900", Offset = "0x4AEE500", VA = "0x184AEF900")]
		[MethodImpl(4096)]
		private static extern void DumpHandles();

		// Token: 0x060032DF RID: 13023
		[Token(Token = "0x60032DF")]
		[Address(RVA = "0x4C9B1E0", Offset = "0x4C99DE0", VA = "0x184C9B1E0")]
		[MethodImpl(4096)]
		public static extern bool RemapPath(string path, out string newPath);

		// Token: 0x04001BB7 RID: 7095
		[Token(Token = "0x4001BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly System.IntPtr InvalidHandle;

		// Token: 0x04001BB8 RID: 7096
		[Token(Token = "0x4001BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool dump_handles;
	}
}
