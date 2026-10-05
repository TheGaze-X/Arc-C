using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002E9 RID: 745
	[Token(Token = "0x20002E9")]
	public class ParametersWithSBox : ICipherParameters
	{
		// Token: 0x0600191F RID: 6431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public ParametersWithSBox(ICipherParameters parameters, byte[] sBox)
		{
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		public byte[] GetSBox()
		{
			return null;
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000383")]
		public ICipherParameters Parameters
		{
			[Token(Token = "0x6001921")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D42 RID: 3394
		[Token(Token = "0x4000D42")]
		[FieldOffset(Offset = "0x10")]
		private ICipherParameters parameters;

		// Token: 0x04000D43 RID: 3395
		[Token(Token = "0x4000D43")]
		[FieldOffset(Offset = "0x18")]
		private byte[] sBox;
	}
}
