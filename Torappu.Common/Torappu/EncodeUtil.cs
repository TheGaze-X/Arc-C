using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	public static class EncodeUtil
	{
		// Token: 0x0600055B RID: 1371 RVA: 0x00005C54 File Offset: 0x00003E54
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1AF4CC0", Offset = "0x1AF38C0", VA = "0x181AF4CC0")]
		public static uint ComputeELFHash(string chars)
		{
			return 0U;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x55166D0", Offset = "0x55152D0", VA = "0x1855166D0")]
		public static string BinaryToBase64(byte[] binary, int index, int length)
		{
			return null;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00005C6C File Offset: 0x00003E6C
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x55165F0", Offset = "0x55151F0", VA = "0x1855165F0")]
		public static int Base64ToBinary(string encodedStr, out byte[] binary)
		{
			return 0;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x5516790", Offset = "0x5515390", VA = "0x185516790")]
		public static string BinaryToHexString(byte[] binary, int index, int length, bool lowercase = false)
		{
			return null;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x5516A20", Offset = "0x5515620", VA = "0x185516A20")]
		public static string TrimMD5BaseNString(byte[] md5, string customBase)
		{
			return null;
		}

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		public const int MD5_BYTE_LEN = 16;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		private const string HEX_INDEX = "0123456789ABCDEF";

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		private const string HEX_INDEX_LOWERCASE = "0123456789abcdef";
	}
}
