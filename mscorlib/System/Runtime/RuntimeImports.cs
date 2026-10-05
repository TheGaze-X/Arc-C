using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Runtime
{
	// Token: 0x0200035B RID: 859
	[Token(Token = "0x200035B")]
	public static class RuntimeImports
	{
		// Token: 0x06001C55 RID: 7253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C55")]
		[Address(RVA = "0x4B66B90", Offset = "0x4B65790", VA = "0x184B66B90")]
		internal static void RhZeroMemory(ref byte b, ulong byteLength)
		{
		}

		// Token: 0x06001C56 RID: 7254
		[Token(Token = "0x6001C56")]
		[Address(RVA = "0x4B66B90", Offset = "0x4B65790", VA = "0x184B66B90")]
		[MethodImpl(4096)]
		private unsafe static extern void ZeroMemory(void* p, uint byteLength);

		// Token: 0x06001C57 RID: 7255
		[Token(Token = "0x6001C57")]
		[Address(RVA = "0x4B66B70", Offset = "0x4B65770", VA = "0x184B66B70")]
		[MethodImpl(4096)]
		internal unsafe static extern void Memmove(byte* dest, byte* src, uint len);

		// Token: 0x06001C58 RID: 7256
		[Token(Token = "0x6001C58")]
		[Address(RVA = "0x4B66B80", Offset = "0x4B65780", VA = "0x184B66B80")]
		[MethodImpl(4096)]
		internal unsafe static extern void Memmove_wbarrier(byte* dest, byte* src, uint len, System.IntPtr type_handle);

		// Token: 0x06001C59 RID: 7257
		[Token(Token = "0x6001C59")]
		[Address(RVA = "0x4B66BA0", Offset = "0x4B657A0", VA = "0x184B66BA0")]
		[MethodImpl(4096)]
		internal unsafe static extern void _ecvt_s(byte* buffer, int sizeInBytes, double value, int count, int* dec, int* sign);
	}
}
