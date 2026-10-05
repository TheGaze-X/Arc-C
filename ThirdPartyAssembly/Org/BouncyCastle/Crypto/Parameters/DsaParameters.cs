using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002CC RID: 716
	[Token(Token = "0x20002CC")]
	public class DsaParameters : ICipherParameters
	{
		// Token: 0x06001880 RID: 6272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001880")]
		[Address(RVA = "0x5285D90", Offset = "0x5284990", VA = "0x185285D90")]
		public DsaParameters(BigInteger p, BigInteger q, BigInteger g)
		{
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001881")]
		[Address(RVA = "0x5285F20", Offset = "0x5284B20", VA = "0x185285F20")]
		public DsaParameters(BigInteger p, BigInteger q, BigInteger g, DsaValidationParameters parameters)
		{
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000352")]
		public BigInteger P
		{
			[Token(Token = "0x6001882")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000353")]
		public BigInteger Q
		{
			[Token(Token = "0x6001883")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000354")]
		public BigInteger G
		{
			[Token(Token = "0x6001884")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000355")]
		public DsaValidationParameters ValidationParameters
		{
			[Token(Token = "0x6001885")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		[Token(Token = "0x6001886")]
		[Address(RVA = "0x5285B20", Offset = "0x5284720", VA = "0x185285B20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		[Token(Token = "0x6001887")]
		[Address(RVA = "0x5285A20", Offset = "0x5284620", VA = "0x185285A20")]
		protected bool Equals(DsaParameters other)
		{
			return default(bool);
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0000BF10 File Offset: 0x0000A110
		[Token(Token = "0x6001888")]
		[Address(RVA = "0x5285CC0", Offset = "0x52848C0", VA = "0x185285CC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D06 RID: 3334
		[Token(Token = "0x4000D06")]
		[FieldOffset(Offset = "0x10")]
		private readonly BigInteger p;

		// Token: 0x04000D07 RID: 3335
		[Token(Token = "0x4000D07")]
		[FieldOffset(Offset = "0x18")]
		private readonly BigInteger q;

		// Token: 0x04000D08 RID: 3336
		[Token(Token = "0x4000D08")]
		[FieldOffset(Offset = "0x20")]
		private readonly BigInteger g;

		// Token: 0x04000D09 RID: 3337
		[Token(Token = "0x4000D09")]
		[FieldOffset(Offset = "0x28")]
		private readonly DsaValidationParameters validation;
	}
}
