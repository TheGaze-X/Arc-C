using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public static class Buffer
	{
		// Token: 0x06000DCF RID: 3535
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x4D0FD50", Offset = "0x4D0E950", VA = "0x184D0FD50")]
		[MethodImpl(4096)]
		internal static extern bool InternalBlockCopy(System.Array src, int srcOffsetBytes, System.Array dst, int dstOffsetBytes, int byteCount);

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x4D0FC90", Offset = "0x4D0E890", VA = "0x184D0FC90")]
		internal unsafe static int IndexOfByte(byte* src, byte value, int index, int count)
		{
			return 0;
		}

		// Token: 0x06000DD1 RID: 3537
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x4D101D0", Offset = "0x4D0EDD0", VA = "0x184D101D0")]
		[MethodImpl(4096)]
		private static extern int _ByteLength(System.Array array);

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x4D101B0", Offset = "0x4D0EDB0", VA = "0x184D101B0")]
		internal unsafe static void ZeroMemory(byte* src, long len)
		{
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x4D10000", Offset = "0x4D0EC00", VA = "0x184D10000")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		internal unsafe static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len)
		{
		}

		// Token: 0x06000DD4 RID: 3540
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x4D0FD60", Offset = "0x4D0E960", VA = "0x184D0FD60")]
		[MethodImpl(4096)]
		internal unsafe static extern void InternalMemcpy(byte* dest, byte* src, int count);

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x4D0FBD0", Offset = "0x4D0E7D0", VA = "0x184D0FBD0")]
		public static int ByteLength(System.Array array)
		{
			return 0;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x4D0F910", Offset = "0x4D0E510", VA = "0x184D0F910")]
		public static void BlockCopy(System.Array src, int srcOffset, System.Array dst, int dstOffset, int count)
		{
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x4D10090", Offset = "0x4D0EC90", VA = "0x184D10090")]
		[System.CLSCompliant(false)]
		public unsafe static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy)
		{
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x4D10310", Offset = "0x4D0EF10", VA = "0x184D10310")]
		internal unsafe static void memcpy4(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x4D10290", Offset = "0x4D0EE90", VA = "0x184D10290")]
		internal unsafe static void memcpy2(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x4D101E0", Offset = "0x4D0EDE0", VA = "0x184D101E0")]
		private unsafe static void memcpy1(byte* dest, byte* src, int size)
		{
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x4D0FD70", Offset = "0x4D0E970", VA = "0x184D0FD70")]
		internal unsafe static void Memcpy(byte* dest, byte* src, int len, bool useICall = true)
		{
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x4D10050", Offset = "0x4D0EC50", VA = "0x184D10050")]
		internal unsafe static void Memmove(byte* dest, byte* src, uint len)
		{
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDD")]
		internal static void Memmove<T>(ref T destination, ref T source, ulong elementCount)
		{
		}
	}
}
