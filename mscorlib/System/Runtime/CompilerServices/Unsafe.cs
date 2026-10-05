using System;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004CB RID: 1227
	[Token(Token = "0x20004CB")]
	internal static class Unsafe
	{
		// Token: 0x06002374 RID: 9076 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002374")]
		public static ref T Add<T>(ref T source, int elementOffset)
		{
			return null;
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002375")]
		public static ref T Add<T>(ref T source, System.IntPtr elementOffset)
		{
			return null;
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002376")]
		public unsafe static void* Add<T>(void* source, int elementOffset)
		{
			return null;
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002377")]
		public static ref T AddByteOffset<T>(ref T source, System.IntPtr byteOffset)
		{
			return null;
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x00014208 File Offset: 0x00012408
		[Token(Token = "0x6002378")]
		public static bool AreSame<T>(ref T left, ref T right)
		{
			return default(bool);
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002379")]
		public static T As<T>(object o) where T : class
		{
			return null;
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600237A")]
		public static ref TTo As<TFrom, TTo>(ref TFrom source)
		{
			return null;
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600237B")]
		public unsafe static void* AsPointer<T>(ref T value)
		{
			return null;
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600237C")]
		public unsafe static ref T AsRef<T>(void* source)
		{
			return null;
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600237D")]
		public static ref T AsRef<T>(in T source)
		{
			return null;
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237E")]
		[Address(RVA = "0x4BEB5C0", Offset = "0x4BEA1C0", VA = "0x184BEB5C0")]
		public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount)
		{
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600237F")]
		public unsafe static T Read<T>(void* source)
		{
			return null;
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002380")]
		public static T ReadUnaligned<T>(ref byte source)
		{
			return null;
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00014220 File Offset: 0x00012420
		[Token(Token = "0x6002381")]
		public static int SizeOf<T>()
		{
			return 0;
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002382")]
		public static void WriteUnaligned<T>(ref byte destination, T value)
		{
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00014238 File Offset: 0x00012438
		[Token(Token = "0x6002383")]
		public static bool IsAddressLessThan<T>(ref T left, ref T right)
		{
			return default(bool);
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002384")]
		[MethodImpl(256)]
		internal static ref T AddByteOffset<T>(ref T source, ulong byteOffset)
		{
			return null;
		}
	}
}
