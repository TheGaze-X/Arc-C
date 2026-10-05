using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002CA RID: 714
	[Token(Token = "0x20002CA")]
	public class DsaKeyGenerationParameters : KeyGenerationParameters
	{
		// Token: 0x06001879 RID: 6265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001879")]
		[Address(RVA = "0x5285890", Offset = "0x5284490", VA = "0x185285890")]
		public DsaKeyGenerationParameters(SecureRandom random, DsaParameters parameters)
		{
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000350")]
		public DsaParameters Parameters
		{
			[Token(Token = "0x600187A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D04 RID: 3332
		[Token(Token = "0x4000D04")]
		[FieldOffset(Offset = "0x20")]
		private readonly DsaParameters parameters;
	}
}
