using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200026B RID: 619
	[Token(Token = "0x200026B")]
	public abstract class NamedCurve
	{
		// Token: 0x060014E5 RID: 5349 RVA: 0x0000AD58 File Offset: 0x00008F58
		[Token(Token = "0x60014E5")]
		[Address(RVA = "0x524A9E0", Offset = "0x52495E0", VA = "0x18524A9E0")]
		public static bool IsValid(int namedCurve)
		{
			return default(bool);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x60014E6")]
		[Address(RVA = "0x524AA00", Offset = "0x5249600", VA = "0x18524AA00")]
		public static bool RefersToASpecificNamedCurve(int namedCurve)
		{
			return default(bool);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected NamedCurve()
		{
		}

		// Token: 0x04000B85 RID: 2949
		[Token(Token = "0x4000B85")]
		public const int sect163k1 = 1;

		// Token: 0x04000B86 RID: 2950
		[Token(Token = "0x4000B86")]
		public const int sect163r1 = 2;

		// Token: 0x04000B87 RID: 2951
		[Token(Token = "0x4000B87")]
		public const int sect163r2 = 3;

		// Token: 0x04000B88 RID: 2952
		[Token(Token = "0x4000B88")]
		public const int sect193r1 = 4;

		// Token: 0x04000B89 RID: 2953
		[Token(Token = "0x4000B89")]
		public const int sect193r2 = 5;

		// Token: 0x04000B8A RID: 2954
		[Token(Token = "0x4000B8A")]
		public const int sect233k1 = 6;

		// Token: 0x04000B8B RID: 2955
		[Token(Token = "0x4000B8B")]
		public const int sect233r1 = 7;

		// Token: 0x04000B8C RID: 2956
		[Token(Token = "0x4000B8C")]
		public const int sect239k1 = 8;

		// Token: 0x04000B8D RID: 2957
		[Token(Token = "0x4000B8D")]
		public const int sect283k1 = 9;

		// Token: 0x04000B8E RID: 2958
		[Token(Token = "0x4000B8E")]
		public const int sect283r1 = 10;

		// Token: 0x04000B8F RID: 2959
		[Token(Token = "0x4000B8F")]
		public const int sect409k1 = 11;

		// Token: 0x04000B90 RID: 2960
		[Token(Token = "0x4000B90")]
		public const int sect409r1 = 12;

		// Token: 0x04000B91 RID: 2961
		[Token(Token = "0x4000B91")]
		public const int sect571k1 = 13;

		// Token: 0x04000B92 RID: 2962
		[Token(Token = "0x4000B92")]
		public const int sect571r1 = 14;

		// Token: 0x04000B93 RID: 2963
		[Token(Token = "0x4000B93")]
		public const int secp160k1 = 15;

		// Token: 0x04000B94 RID: 2964
		[Token(Token = "0x4000B94")]
		public const int secp160r1 = 16;

		// Token: 0x04000B95 RID: 2965
		[Token(Token = "0x4000B95")]
		public const int secp160r2 = 17;

		// Token: 0x04000B96 RID: 2966
		[Token(Token = "0x4000B96")]
		public const int secp192k1 = 18;

		// Token: 0x04000B97 RID: 2967
		[Token(Token = "0x4000B97")]
		public const int secp192r1 = 19;

		// Token: 0x04000B98 RID: 2968
		[Token(Token = "0x4000B98")]
		public const int secp224k1 = 20;

		// Token: 0x04000B99 RID: 2969
		[Token(Token = "0x4000B99")]
		public const int secp224r1 = 21;

		// Token: 0x04000B9A RID: 2970
		[Token(Token = "0x4000B9A")]
		public const int secp256k1 = 22;

		// Token: 0x04000B9B RID: 2971
		[Token(Token = "0x4000B9B")]
		public const int secp256r1 = 23;

		// Token: 0x04000B9C RID: 2972
		[Token(Token = "0x4000B9C")]
		public const int secp384r1 = 24;

		// Token: 0x04000B9D RID: 2973
		[Token(Token = "0x4000B9D")]
		public const int secp521r1 = 25;

		// Token: 0x04000B9E RID: 2974
		[Token(Token = "0x4000B9E")]
		public const int brainpoolP256r1 = 26;

		// Token: 0x04000B9F RID: 2975
		[Token(Token = "0x4000B9F")]
		public const int brainpoolP384r1 = 27;

		// Token: 0x04000BA0 RID: 2976
		[Token(Token = "0x4000BA0")]
		public const int brainpoolP512r1 = 28;

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4000BA1")]
		public const int arbitrary_explicit_prime_curves = 65281;

		// Token: 0x04000BA2 RID: 2978
		[Token(Token = "0x4000BA2")]
		public const int arbitrary_explicit_char2_curves = 65282;
	}
}
