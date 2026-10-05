using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002C4 RID: 708
	[Token(Token = "0x20002C4")]
	public class DHKeyGenerationParameters : KeyGenerationParameters
	{
		// Token: 0x0600184C RID: 6220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184C")]
		[Address(RVA = "0x5282CB0", Offset = "0x52818B0", VA = "0x185282CB0")]
		public DHKeyGenerationParameters(SecureRandom random, DHParameters parameters)
		{
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000343")]
		public DHParameters Parameters
		{
			[Token(Token = "0x600184D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		[Token(Token = "0x600184E")]
		[Address(RVA = "0x5282C80", Offset = "0x5281880", VA = "0x185282C80")]
		internal static int GetStrength(DHParameters parameters)
		{
			return 0;
		}

		// Token: 0x04000CF5 RID: 3317
		[Token(Token = "0x4000CF5")]
		[FieldOffset(Offset = "0x20")]
		private readonly DHParameters parameters;
	}
}
