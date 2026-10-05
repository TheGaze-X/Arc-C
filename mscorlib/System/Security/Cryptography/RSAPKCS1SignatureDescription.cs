using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000327 RID: 807
	[Token(Token = "0x2000327")]
	internal abstract class RSAPKCS1SignatureDescription : SignatureDescription
	{
		// Token: 0x06001AC5 RID: 6853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC5")]
		[Address(RVA = "0x4B46B60", Offset = "0x4B45760", VA = "0x184B46B60")]
		protected RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm)
		{
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AC6")]
		[Address(RVA = "0x4B46840", Offset = "0x4B45440", VA = "0x184B46840", Slot = "4")]
		public sealed override AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
		{
			return null;
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AC7")]
		[Address(RVA = "0x4B469D0", Offset = "0x4B455D0", VA = "0x184B469D0", Slot = "5")]
		public sealed override AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
		{
			return null;
		}

		// Token: 0x04000E4E RID: 3662
		[Token(Token = "0x4000E4E")]
		[FieldOffset(Offset = "0x30")]
		private string _hashAlgorithm;
	}
}
