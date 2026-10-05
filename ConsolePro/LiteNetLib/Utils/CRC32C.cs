using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public static class CRC32C
	{
		// Token: 0x06000191 RID: 401 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x36978F0", Offset = "0x36964F0", VA = "0x1836978F0")]
		public static uint Compute(byte[] input, int offset, int length)
		{
			return 0U;
		}

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		public const int ChecksumSize = 4;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		private const uint Poly = 2197175160U;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint[] Table;
	}
}
