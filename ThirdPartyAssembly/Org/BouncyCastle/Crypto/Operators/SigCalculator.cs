using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x020002FB RID: 763
	[Token(Token = "0x20002FB")]
	internal class SigCalculator : IStreamCalculator
	{
		// Token: 0x06001985 RID: 6533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001985")]
		[Address(RVA = "0x5296C20", Offset = "0x5295820", VA = "0x185296C20")]
		internal SigCalculator(ISigner sig)
		{
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A0")]
		public Stream Stream
		{
			[Token(Token = "0x6001986")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001987")]
		[Address(RVA = "0x5296BB0", Offset = "0x52957B0", VA = "0x185296BB0", Slot = "5")]
		public object GetResult()
		{
			return null;
		}

		// Token: 0x04000D5E RID: 3422
		[Token(Token = "0x4000D5E")]
		[FieldOffset(Offset = "0x10")]
		private readonly ISigner sig;

		// Token: 0x04000D5F RID: 3423
		[Token(Token = "0x4000D5F")]
		[FieldOffset(Offset = "0x18")]
		private readonly Stream stream;
	}
}
