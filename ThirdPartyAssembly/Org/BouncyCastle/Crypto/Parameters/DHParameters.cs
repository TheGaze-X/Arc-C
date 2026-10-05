using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002C6 RID: 710
	[Token(Token = "0x20002C6")]
	public class DHParameters : ICipherParameters
	{
		// Token: 0x06001856 RID: 6230 RVA: 0x0000BD18 File Offset: 0x00009F18
		[Token(Token = "0x6001856")]
		[Address(RVA = "0x5283190", Offset = "0x5281D90", VA = "0x185283190")]
		private static int GetDefaultMParam(int lParam)
		{
			return 0;
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001857")]
		[Address(RVA = "0x52832C0", Offset = "0x5281EC0", VA = "0x1852832C0")]
		public DHParameters(BigInteger p, BigInteger g)
		{
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001858")]
		[Address(RVA = "0x52833C0", Offset = "0x5281FC0", VA = "0x1852833C0")]
		public DHParameters(BigInteger p, BigInteger g, BigInteger q)
		{
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001859")]
		[Address(RVA = "0x5283440", Offset = "0x5282040", VA = "0x185283440")]
		public DHParameters(BigInteger p, BigInteger g, BigInteger q, int l)
		{
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185A")]
		[Address(RVA = "0x5283340", Offset = "0x5281F40", VA = "0x185283340")]
		public DHParameters(BigInteger p, BigInteger g, BigInteger q, int m, int l)
		{
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185B")]
		[Address(RVA = "0x5283380", Offset = "0x5281F80", VA = "0x185283380")]
		public DHParameters(BigInteger p, BigInteger g, BigInteger q, BigInteger j, DHValidationParameters validation)
		{
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185C")]
		[Address(RVA = "0x5283500", Offset = "0x5282100", VA = "0x185283500")]
		public DHParameters(BigInteger p, BigInteger g, BigInteger q, int m, int l, BigInteger j, DHValidationParameters validation)
		{
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000346")]
		public BigInteger P
		{
			[Token(Token = "0x600185D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000347")]
		public BigInteger G
		{
			[Token(Token = "0x600185E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000348")]
		public BigInteger Q
		{
			[Token(Token = "0x600185F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000349")]
		public BigInteger J
		{
			[Token(Token = "0x6001860")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x0000BD30 File Offset: 0x00009F30
		[Token(Token = "0x1700034A")]
		public int M
		{
			[Token(Token = "0x6001861")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x0000BD48 File Offset: 0x00009F48
		[Token(Token = "0x1700034B")]
		public int L
		{
			[Token(Token = "0x6001862")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034C")]
		public DHValidationParameters ValidationParameters
		{
			[Token(Token = "0x6001863")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0000BD60 File Offset: 0x00009F60
		[Token(Token = "0x6001864")]
		[Address(RVA = "0x5282FC0", Offset = "0x5281BC0", VA = "0x185282FC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0000BD78 File Offset: 0x00009F78
		[Token(Token = "0x6001865")]
		[Address(RVA = "0x52830C0", Offset = "0x5281CC0", VA = "0x1852830C0", Slot = "4")]
		protected virtual bool Equals(DHParameters other)
		{
			return default(bool);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0000BD90 File Offset: 0x00009F90
		[Token(Token = "0x6001866")]
		[Address(RVA = "0x52831F0", Offset = "0x5281DF0", VA = "0x1852831F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000CF8 RID: 3320
		[Token(Token = "0x4000CF8")]
		private const int DefaultMinimumLength = 160;

		// Token: 0x04000CF9 RID: 3321
		[Token(Token = "0x4000CF9")]
		[FieldOffset(Offset = "0x10")]
		private readonly BigInteger p;

		// Token: 0x04000CFA RID: 3322
		[Token(Token = "0x4000CFA")]
		[FieldOffset(Offset = "0x18")]
		private readonly BigInteger g;

		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0x20")]
		private readonly BigInteger q;

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0x28")]
		private readonly BigInteger j;

		// Token: 0x04000CFD RID: 3325
		[Token(Token = "0x4000CFD")]
		[FieldOffset(Offset = "0x30")]
		private readonly int m;

		// Token: 0x04000CFE RID: 3326
		[Token(Token = "0x4000CFE")]
		[FieldOffset(Offset = "0x34")]
		private readonly int l;

		// Token: 0x04000CFF RID: 3327
		[Token(Token = "0x4000CFF")]
		[FieldOffset(Offset = "0x38")]
		private readonly DHValidationParameters validation;
	}
}
