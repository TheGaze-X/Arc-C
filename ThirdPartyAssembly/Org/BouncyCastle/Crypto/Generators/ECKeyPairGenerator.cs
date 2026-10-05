using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000322 RID: 802
	[Token(Token = "0x2000322")]
	public class ECKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06001AEB RID: 6891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AEB")]
		[Address(RVA = "0x52A53C0", Offset = "0x52A3FC0", VA = "0x1852A53C0")]
		public ECKeyPairGenerator()
		{
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AEC")]
		[Address(RVA = "0x52A52F0", Offset = "0x52A3EF0", VA = "0x1852A52F0")]
		public ECKeyPairGenerator(string algorithm)
		{
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x52A4EA0", Offset = "0x52A3AA0", VA = "0x1852A4EA0", Slot = "4")]
		public void Init(KeyGenerationParameters parameters)
		{
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0x52A4A20", Offset = "0x52A3620", VA = "0x1852A4A20", Slot = "5")]
		public AsymmetricCipherKeyPair GenerateKeyPair()
		{
			return null;
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEF")]
		[Address(RVA = "0x52A4970", Offset = "0x52A3570", VA = "0x1852A4970", Slot = "6")]
		protected virtual ECMultiplier CreateBasePointMultiplier()
		{
			return null;
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF0")]
		[Address(RVA = "0x52A49C0", Offset = "0x52A35C0", VA = "0x1852A49C0")]
		internal static X9ECParameters FindECCurveByOid(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0x52A4D70", Offset = "0x52A3970", VA = "0x1852A4D70")]
		internal static ECPublicKeyParameters GetCorrespondingPublicKey(ECPrivateKeyParameters privKey)
		{
			return null;
		}

		// Token: 0x04000E47 RID: 3655
		[Token(Token = "0x4000E47")]
		[FieldOffset(Offset = "0x10")]
		private readonly string algorithm;

		// Token: 0x04000E48 RID: 3656
		[Token(Token = "0x4000E48")]
		[FieldOffset(Offset = "0x18")]
		private ECDomainParameters parameters;

		// Token: 0x04000E49 RID: 3657
		[Token(Token = "0x4000E49")]
		[FieldOffset(Offset = "0x20")]
		private DerObjectIdentifier publicKeyParamSet;

		// Token: 0x04000E4A RID: 3658
		[Token(Token = "0x4000E4A")]
		[FieldOffset(Offset = "0x28")]
		private SecureRandom random;
	}
}
