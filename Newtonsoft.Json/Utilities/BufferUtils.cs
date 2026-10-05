using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[Preserve]
	internal static class BufferUtils
	{
		// Token: 0x060003B6 RID: 950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x4D7D580", Offset = "0x4D7C180", VA = "0x184D7D580")]
		public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize)
		{
			return null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x4D7D600", Offset = "0x4D7C200", VA = "0x184D7D600")]
		public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer)
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x4D7D4E0", Offset = "0x4D7C0E0", VA = "0x184D7D4E0")]
		public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer)
		{
			return null;
		}
	}
}
