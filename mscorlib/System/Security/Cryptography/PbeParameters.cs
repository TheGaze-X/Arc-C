using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000344 RID: 836
	[Token(Token = "0x2000344")]
	public sealed class PbeParameters
	{
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00012780 File Offset: 0x00010980
		[Token(Token = "0x1700030C")]
		public PbeEncryptionAlgorithm EncryptionAlgorithm
		{
			[Token(Token = "0x6001BAC")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return PbeEncryptionAlgorithm.Unknown;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x00012798 File Offset: 0x00010998
		[Token(Token = "0x1700030D")]
		public HashAlgorithmName HashAlgorithm
		{
			[Token(Token = "0x6001BAD")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(HashAlgorithmName);
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x000127B0 File Offset: 0x000109B0
		[Token(Token = "0x1700030E")]
		public int IterationCount
		{
			[Token(Token = "0x6001BAE")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x4B61E90", Offset = "0x4B60A90", VA = "0x184B61E90")]
		public PbeParameters(PbeEncryptionAlgorithm encryptionAlgorithm, HashAlgorithmName hashAlgorithm, int iterationCount)
		{
		}
	}
}
