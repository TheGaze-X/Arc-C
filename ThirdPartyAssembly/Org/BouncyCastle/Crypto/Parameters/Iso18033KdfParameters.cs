using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002E1 RID: 737
	[Token(Token = "0x20002E1")]
	public class Iso18033KdfParameters : IDerivationParameters
	{
		// Token: 0x06001902 RID: 6402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001902")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public Iso18033KdfParameters(byte[] seed)
		{
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001903")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
		public byte[] GetSeed()
		{
			return null;
		}

		// Token: 0x04000D33 RID: 3379
		[Token(Token = "0x4000D33")]
		[FieldOffset(Offset = "0x10")]
		private byte[] seed;
	}
}
