using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x020002FE RID: 766
	[Token(Token = "0x20002FE")]
	internal class VerifierCalculator : IStreamCalculator
	{
		// Token: 0x0600198F RID: 6543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600198F")]
		[Address(RVA = "0x5297380", Offset = "0x5295F80", VA = "0x185297380")]
		internal VerifierCalculator(ISigner sig)
		{
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A2")]
		public Stream Stream
		{
			[Token(Token = "0x6001990")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001991")]
		[Address(RVA = "0x5297310", Offset = "0x5295F10", VA = "0x185297310", Slot = "5")]
		public object GetResult()
		{
			return null;
		}

		// Token: 0x04000D63 RID: 3427
		[Token(Token = "0x4000D63")]
		[FieldOffset(Offset = "0x10")]
		private readonly ISigner sig;

		// Token: 0x04000D64 RID: 3428
		[Token(Token = "0x4000D64")]
		[FieldOffset(Offset = "0x18")]
		private readonly Stream stream;
	}
}
