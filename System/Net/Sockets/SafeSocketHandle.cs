using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace System.Net.Sockets
{
	// Token: 0x020003C6 RID: 966
	[Token(Token = "0x20003C6")]
	internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid
	{
		// Token: 0x060019F7 RID: 6647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F7")]
		[Address(RVA = "0x50BE260", Offset = "0x50BCE60", VA = "0x1850BE260")]
		public SafeSocketHandle(IntPtr preexistingHandle, bool ownsHandle)
		{
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0000BA18 File Offset: 0x00009C18
		[Token(Token = "0x60019F8")]
		[Address(RVA = "0x50BDAF0", Offset = "0x50BC6F0", VA = "0x1850BDAF0", Slot = "7")]
		protected override bool ReleaseHandle()
		{
			return default(bool);
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F9")]
		[Address(RVA = "0x50BD980", Offset = "0x50BC580", VA = "0x1850BD980")]
		public void RegisterForBlockingSyscall()
		{
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019FA")]
		[Address(RVA = "0x50BE050", Offset = "0x50BCC50", VA = "0x1850BE050")]
		public void UnRegisterForBlockingSyscall()
		{
		}

		// Token: 0x040010CA RID: 4298
		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x20")]
		private List<Thread> blocking_threads;

		// Token: 0x040010CB RID: 4299
		[Token(Token = "0x40010CB")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Thread, StackTrace> threads_stacktraces;

		// Token: 0x040010CC RID: 4300
		[Token(Token = "0x40010CC")]
		[FieldOffset(Offset = "0x30")]
		private bool in_cleanup;

		// Token: 0x040010CD RID: 4301
		[Token(Token = "0x40010CD")]
		private const int SOCKET_CLOSED = 10004;

		// Token: 0x040010CE RID: 4302
		[Token(Token = "0x40010CE")]
		private const int ABORT_RETRIES = 10;

		// Token: 0x040010CF RID: 4303
		[Token(Token = "0x40010CF")]
		[FieldOffset(Offset = "0x0")]
		private static bool THROW_ON_ABORT_RETRIES;
	}
}
