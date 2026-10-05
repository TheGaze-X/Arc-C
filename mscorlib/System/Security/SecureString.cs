using System;
using Il2CppDummyDll;

namespace System.Security
{
	// Token: 0x020002C0 RID: 704
	[Token(Token = "0x20002C0")]
	[MonoTODO("work in progress - encryption is missing")]
	public sealed class SecureString : System.IDisposable
	{
		// Token: 0x060017AE RID: 6062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017AE")]
		[Address(RVA = "0x4B184B0", Offset = "0x4B170B0", VA = "0x184B184B0")]
		public SecureString()
		{
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017AF")]
		[Address(RVA = "0x4B18330", Offset = "0x4B16F30", VA = "0x184B18330")]
		[System.CLSCompliant(false)]
		public unsafe SecureString(char* value, int length)
		{
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x000111A8 File Offset: 0x0000F3A8
		[Token(Token = "0x17000264")]
		public int Length
		{
			[Token(Token = "0x60017B0")]
			[Address(RVA = "0x4B18510", Offset = "0x4B17110", VA = "0x184B18510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B1")]
		[Address(RVA = "0x4B18230", Offset = "0x4B16E30", VA = "0x184B18230", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B2")]
		[Address(RVA = "0x3CF2790", Offset = "0x3CF1390", VA = "0x183CF2790")]
		private void Encrypt()
		{
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B3")]
		[Address(RVA = "0x3CF2790", Offset = "0x3CF1390", VA = "0x183CF2790")]
		private void Decrypt()
		{
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B4")]
		[Address(RVA = "0x4B180A0", Offset = "0x4B16CA0", VA = "0x184B180A0")]
		private void Alloc(int length, bool realloc)
		{
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017B5")]
		[Address(RVA = "0x4B18280", Offset = "0x4B16E80", VA = "0x184B18280")]
		internal byte[] GetBuffer()
		{
			return null;
		}

		// Token: 0x04000CC5 RID: 3269
		[Token(Token = "0x4000CC5")]
		[FieldOffset(Offset = "0x10")]
		private int length;

		// Token: 0x04000CC6 RID: 3270
		[Token(Token = "0x4000CC6")]
		[FieldOffset(Offset = "0x14")]
		private bool disposed;

		// Token: 0x04000CC7 RID: 3271
		[Token(Token = "0x4000CC7")]
		[FieldOffset(Offset = "0x18")]
		private byte[] data;
	}
}
