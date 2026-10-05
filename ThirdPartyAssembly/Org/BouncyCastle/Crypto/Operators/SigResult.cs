using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x020002FC RID: 764
	[Token(Token = "0x20002FC")]
	internal class SigResult : IBlockResult
	{
		// Token: 0x06001988 RID: 6536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001988")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal SigResult(ISigner sig)
		{
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001989")]
		[Address(RVA = "0x5296E10", Offset = "0x5295A10", VA = "0x185296E10", Slot = "4")]
		public byte[] Collect()
		{
			return null;
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		[Token(Token = "0x600198A")]
		[Address(RVA = "0x5296CF0", Offset = "0x52958F0", VA = "0x185296CF0", Slot = "5")]
		public int Collect(byte[] destination, int offset)
		{
			return 0;
		}

		// Token: 0x04000D60 RID: 3424
		[Token(Token = "0x4000D60")]
		[FieldOffset(Offset = "0x10")]
		private readonly ISigner sig;
	}
}
