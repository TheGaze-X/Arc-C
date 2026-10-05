using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000457 RID: 1111
	[Token(Token = "0x2000457")]
	public static class MemoryMarshal
	{
		// Token: 0x06002200 RID: 8704 RVA: 0x00013A70 File Offset: 0x00011C70
		[Token(Token = "0x6002200")]
		[MethodImpl(256)]
		public static System.Span<byte> AsBytes<T>(System.Span<T> span) where T : struct
		{
			return default(System.Span<byte>);
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00013A88 File Offset: 0x00011C88
		[Token(Token = "0x6002201")]
		[MethodImpl(256)]
		public static System.ReadOnlySpan<byte> AsBytes<T>(System.ReadOnlySpan<T> span) where T : struct
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00013AA0 File Offset: 0x00011CA0
		[Token(Token = "0x6002202")]
		public static System.Memory<T> AsMemory<T>(System.ReadOnlyMemory<T> memory)
		{
			return default(System.Memory<T>);
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002203")]
		public static ref T GetReference<T>(System.Span<T> span)
		{
			return null;
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002204")]
		public static ref T GetReference<T>(System.ReadOnlySpan<T> span)
		{
			return null;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002205")]
		[MethodImpl(256)]
		internal static ref T GetNonNullPinnableReference<T>(System.Span<T> span)
		{
			return null;
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002206")]
		[MethodImpl(256)]
		internal static ref T GetNonNullPinnableReference<T>(System.ReadOnlySpan<T> span)
		{
			return null;
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x00013AB8 File Offset: 0x00011CB8
		[Token(Token = "0x6002207")]
		[MethodImpl(256)]
		public static System.ReadOnlySpan<T> CreateReadOnlySpan<T>(ref T reference, int length)
		{
			return default(System.ReadOnlySpan<T>);
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00013AD0 File Offset: 0x00011CD0
		[Token(Token = "0x6002208")]
		public static bool TryGetArray<T>(System.ReadOnlyMemory<T> memory, out System.ArraySegment<T> segment)
		{
			return default(bool);
		}
	}
}
