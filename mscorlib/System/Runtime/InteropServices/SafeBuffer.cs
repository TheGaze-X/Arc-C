using System;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200045B RID: 1115
	[Token(Token = "0x200045B")]
	public abstract class SafeBuffer : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06002215 RID: 8725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002215")]
		[Address(RVA = "0x4BC4D40", Offset = "0x4BC3940", VA = "0x184BC4D40")]
		[System.CLSCompliant(false)]
		public unsafe void AcquirePointer(ref byte* pointer)
		{
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002216")]
		[Address(RVA = "0x4BC4EC0", Offset = "0x4BC3AC0", VA = "0x184BC4EC0")]
		public void ReleasePointer()
		{
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002217")]
		[Address(RVA = "0x4BC4E50", Offset = "0x4BC3A50", VA = "0x184BC4E50")]
		private static System.InvalidOperationException NotInitialized()
		{
			return null;
		}

		// Token: 0x04001327 RID: 4903
		[Token(Token = "0x4001327")]
		[FieldOffset(Offset = "0x0")]
		private static readonly System.UIntPtr Uninitialized;

		// Token: 0x04001328 RID: 4904
		[Token(Token = "0x4001328")]
		[FieldOffset(Offset = "0x20")]
		private System.UIntPtr _numBytes;
	}
}
