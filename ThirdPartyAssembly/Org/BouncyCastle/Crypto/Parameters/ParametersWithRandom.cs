using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002E7 RID: 743
	[Token(Token = "0x20002E7")]
	public class ParametersWithRandom : ICipherParameters
	{
		// Token: 0x06001916 RID: 6422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001916")]
		[Address(RVA = "0x5294080", Offset = "0x5292C80", VA = "0x185294080")]
		public ParametersWithRandom(ICipherParameters parameters, SecureRandom random)
		{
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001917")]
		[Address(RVA = "0x5293F90", Offset = "0x5292B90", VA = "0x185293F90")]
		public ParametersWithRandom(ICipherParameters parameters)
		{
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001918")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		[Obsolete("Use Random property instead")]
		public SecureRandom GetRandom()
		{
			return null;
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000380")]
		public SecureRandom Random
		{
			[Token(Token = "0x6001919")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000381")]
		public ICipherParameters Parameters
		{
			[Token(Token = "0x600191A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D3E RID: 3390
		[Token(Token = "0x4000D3E")]
		[FieldOffset(Offset = "0x10")]
		private readonly ICipherParameters parameters;

		// Token: 0x04000D3F RID: 3391
		[Token(Token = "0x4000D3F")]
		[FieldOffset(Offset = "0x18")]
		private readonly SecureRandom random;
	}
}
