using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Win32
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	internal static class NativeMethods
	{
		// Token: 0x0600033F RID: 831 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x50DB600", Offset = "0x50DA200", VA = "0x1850DB600")]
		public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
		{
			return default(bool);
		}

		// Token: 0x06000340 RID: 832
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x50DB770", Offset = "0x50DA370", VA = "0x1850DB770")]
		[MethodImpl(4096)]
		public static extern IntPtr GetCurrentProcess();

		// Token: 0x06000341 RID: 833
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x50DB850", Offset = "0x50DA450", VA = "0x1850DB850")]
		[MethodImpl(4096)]
		public static extern bool GetExitCodeProcess(IntPtr processHandle, out int exitCode);

		// Token: 0x06000342 RID: 834 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x50DB780", Offset = "0x50DA380", VA = "0x1850DB780")]
		public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode)
		{
			return default(bool);
		}

		// Token: 0x06000343 RID: 835
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x50DB860", Offset = "0x50DA460", VA = "0x1850DB860")]
		[MethodImpl(4096)]
		public static extern bool TerminateProcess(IntPtr processHandle, int exitCode);

		// Token: 0x06000344 RID: 836 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x50DB870", Offset = "0x50DA470", VA = "0x1850DB870")]
		public static bool TerminateProcess(SafeProcessHandle processHandle, int exitCode)
		{
			return default(bool);
		}

		// Token: 0x06000345 RID: 837
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x50DB760", Offset = "0x50DA360", VA = "0x1850DB760")]
		[MethodImpl(4096)]
		public static extern int GetCurrentProcessId();

		// Token: 0x06000346 RID: 838
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x50DB5F0", Offset = "0x50DA1F0", VA = "0x1850DB5F0")]
		[MethodImpl(4096)]
		public static extern bool CloseProcess(IntPtr handle);
	}
}
