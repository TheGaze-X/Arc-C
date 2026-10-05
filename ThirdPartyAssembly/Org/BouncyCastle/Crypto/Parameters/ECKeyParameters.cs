using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002D2 RID: 722
	[Token(Token = "0x20002D2")]
	public abstract class ECKeyParameters : AsymmetricKeyParameter
	{
		// Token: 0x060018AA RID: 6314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x5287FE0", Offset = "0x5286BE0", VA = "0x185287FE0")]
		protected ECKeyParameters(string algorithm, bool isPrivate, ECDomainParameters parameters)
		{
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x5288130", Offset = "0x5286D30", VA = "0x185288130")]
		protected ECKeyParameters(string algorithm, bool isPrivate, DerObjectIdentifier publicKeyParamSet)
		{
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000360")]
		public string AlgorithmName
		{
			[Token(Token = "0x60018AC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000361")]
		public ECDomainParameters Parameters
		{
			[Token(Token = "0x60018AD")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000362")]
		public DerObjectIdentifier PublicKeyParamSet
		{
			[Token(Token = "0x60018AE")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0000C078 File Offset: 0x0000A278
		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x52876F0", Offset = "0x52862F0", VA = "0x1852876F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0000C090 File Offset: 0x0000A290
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x5287660", Offset = "0x5286260", VA = "0x185287660")]
		protected bool Equals(ECKeyParameters other)
		{
			return default(bool);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x52877F0", Offset = "0x52863F0", VA = "0x1852877F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x5287500", Offset = "0x5286100", VA = "0x185287500")]
		internal ECKeyGenerationParameters CreateKeyGenerationParameters(SecureRandom random)
		{
			return null;
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x5287BD0", Offset = "0x52867D0", VA = "0x185287BD0")]
		internal static string VerifyAlgorithmName(string algorithm)
		{
			return null;
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x5287850", Offset = "0x5286450", VA = "0x185287850")]
		internal static ECDomainParameters LookupParameters(DerObjectIdentifier publicKeyParamSet)
		{
			return null;
		}

		// Token: 0x04000D16 RID: 3350
		[Token(Token = "0x4000D16")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] algorithms;

		// Token: 0x04000D17 RID: 3351
		[Token(Token = "0x4000D17")]
		[FieldOffset(Offset = "0x18")]
		private readonly string algorithm;

		// Token: 0x04000D18 RID: 3352
		[Token(Token = "0x4000D18")]
		[FieldOffset(Offset = "0x20")]
		private readonly ECDomainParameters parameters;

		// Token: 0x04000D19 RID: 3353
		[Token(Token = "0x4000D19")]
		[FieldOffset(Offset = "0x28")]
		private readonly DerObjectIdentifier publicKeyParamSet;
	}
}
