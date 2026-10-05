using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200030E RID: 782
	[Token(Token = "0x200030E")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class RandomNumberGenerator : System.IDisposable
	{
		// Token: 0x060019A4 RID: 6564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected RandomNumberGenerator()
		{
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019A5")]
		[Address(RVA = "0x4B32BC0", Offset = "0x4B317C0", VA = "0x184B32BC0")]
		public static RandomNumberGenerator Create()
		{
			return null;
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x4B32C10", Offset = "0x4B31810", VA = "0x184B32C10")]
		public static RandomNumberGenerator Create(string rngName)
		{
			return null;
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A7")]
		[Address(RVA = "0x4B32CF0", Offset = "0x4B318F0", VA = "0x184B32CF0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060019A9 RID: 6569
		[Token(Token = "0x60019A9")]
		public abstract void GetBytes(byte[] data);

		// Token: 0x060019AA RID: 6570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AA")]
		[Address(RVA = "0x4B32E30", Offset = "0x4B31A30", VA = "0x184B32E30", Slot = "7")]
		public virtual void GetBytes(byte[] data, int offset, int count)
		{
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AB")]
		[Address(RVA = "0x4B336E0", Offset = "0x4B322E0", VA = "0x184B336E0", Slot = "8")]
		public virtual void GetNonZeroBytes(byte[] data)
		{
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AC")]
		[Address(RVA = "0x4B32DC0", Offset = "0x4B319C0", VA = "0x184B32DC0")]
		public static void Fill(System.Span<byte> data)
		{
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AD")]
		[Address(RVA = "0x4B32D60", Offset = "0x4B31960", VA = "0x184B32D60")]
		internal static void FillSpan(System.Span<byte> data)
		{
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x4B33080", Offset = "0x4B31C80", VA = "0x184B33080", Slot = "9")]
		public virtual void GetBytes(System.Span<byte> data)
		{
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0x4B33500", Offset = "0x4B32100", VA = "0x184B33500", Slot = "10")]
		public virtual void GetNonZeroBytes(System.Span<byte> data)
		{
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00011CD0 File Offset: 0x0000FED0
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x4B33300", Offset = "0x4B31F00", VA = "0x184B33300")]
		public static int GetInt32(int fromInclusive, int toExclusive)
		{
			return 0;
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x4B33270", Offset = "0x4B31E70", VA = "0x184B33270")]
		public static int GetInt32(int toExclusive)
		{
			return 0;
		}
	}
}
