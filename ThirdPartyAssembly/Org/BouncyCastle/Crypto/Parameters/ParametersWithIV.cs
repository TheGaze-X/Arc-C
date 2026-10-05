using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002E6 RID: 742
	[Token(Token = "0x20002E6")]
	public class ParametersWithIV : ICipherParameters
	{
		// Token: 0x06001912 RID: 6418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001912")]
		[Address(RVA = "0x5293DD0", Offset = "0x52929D0", VA = "0x185293DD0")]
		public ParametersWithIV(ICipherParameters parameters, byte[] iv)
		{
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001913")]
		[Address(RVA = "0x5293E90", Offset = "0x5292A90", VA = "0x185293E90")]
		public ParametersWithIV(ICipherParameters parameters, byte[] iv, int ivOff, int ivLen)
		{
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001914")]
		[Address(RVA = "0x5293D50", Offset = "0x5292950", VA = "0x185293D50")]
		public byte[] GetIV()
		{
			return null;
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037F")]
		public ICipherParameters Parameters
		{
			[Token(Token = "0x6001915")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D3C RID: 3388
		[Token(Token = "0x4000D3C")]
		[FieldOffset(Offset = "0x10")]
		private readonly ICipherParameters parameters;

		// Token: 0x04000D3D RID: 3389
		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] iv;
	}
}
