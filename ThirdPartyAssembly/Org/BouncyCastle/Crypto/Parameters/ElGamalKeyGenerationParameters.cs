using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002D5 RID: 725
	[Token(Token = "0x20002D5")]
	public class ElGamalKeyGenerationParameters : KeyGenerationParameters
	{
		// Token: 0x060018C6 RID: 6342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C6")]
		[Address(RVA = "0x528AB00", Offset = "0x5289700", VA = "0x18528AB00")]
		public ElGamalKeyGenerationParameters(SecureRandom random, ElGamalParameters parameters)
		{
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000365")]
		public ElGamalParameters Parameters
		{
			[Token(Token = "0x60018C7")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x0000C150 File Offset: 0x0000A350
		[Token(Token = "0x60018C8")]
		[Address(RVA = "0x528AAD0", Offset = "0x52896D0", VA = "0x18528AAD0")]
		internal static int GetStrength(ElGamalParameters parameters)
		{
			return 0;
		}

		// Token: 0x04000D1C RID: 3356
		[Token(Token = "0x4000D1C")]
		[FieldOffset(Offset = "0x20")]
		private readonly ElGamalParameters parameters;
	}
}
