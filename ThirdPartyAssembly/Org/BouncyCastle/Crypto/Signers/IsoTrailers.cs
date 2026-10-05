using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002B9 RID: 697
	[Token(Token = "0x20002B9")]
	public class IsoTrailers
	{
		// Token: 0x060017EC RID: 6124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EC")]
		[Address(RVA = "0x5268910", Offset = "0x5267510", VA = "0x185268910")]
		private static IDictionary CreateTrailerMap()
		{
			return null;
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x0000BB38 File Offset: 0x00009D38
		[Token(Token = "0x60017ED")]
		[Address(RVA = "0x5268C40", Offset = "0x5267840", VA = "0x185268C40")]
		public static int GetTrailer(IDigest digest)
		{
			return 0;
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x0000BB50 File Offset: 0x00009D50
		[Token(Token = "0x60017EE")]
		[Address(RVA = "0x5268D30", Offset = "0x5267930", VA = "0x185268D30")]
		public static bool NoTrailerAvailable(IDigest digest)
		{
			return default(bool);
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017EF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public IsoTrailers()
		{
		}

		// Token: 0x04000CB5 RID: 3253
		[Token(Token = "0x4000CB5")]
		public const int TRAILER_IMPLICIT = 188;

		// Token: 0x04000CB6 RID: 3254
		[Token(Token = "0x4000CB6")]
		public const int TRAILER_RIPEMD160 = 12748;

		// Token: 0x04000CB7 RID: 3255
		[Token(Token = "0x4000CB7")]
		public const int TRAILER_RIPEMD128 = 13004;

		// Token: 0x04000CB8 RID: 3256
		[Token(Token = "0x4000CB8")]
		public const int TRAILER_SHA1 = 13260;

		// Token: 0x04000CB9 RID: 3257
		[Token(Token = "0x4000CB9")]
		public const int TRAILER_SHA256 = 13516;

		// Token: 0x04000CBA RID: 3258
		[Token(Token = "0x4000CBA")]
		public const int TRAILER_SHA512 = 13772;

		// Token: 0x04000CBB RID: 3259
		[Token(Token = "0x4000CBB")]
		public const int TRAILER_SHA384 = 14028;

		// Token: 0x04000CBC RID: 3260
		[Token(Token = "0x4000CBC")]
		public const int TRAILER_WHIRLPOOL = 14284;

		// Token: 0x04000CBD RID: 3261
		[Token(Token = "0x4000CBD")]
		public const int TRAILER_SHA224 = 14540;

		// Token: 0x04000CBE RID: 3262
		[Token(Token = "0x4000CBE")]
		public const int TRAILER_SHA512_224 = 14796;

		// Token: 0x04000CBF RID: 3263
		[Token(Token = "0x4000CBF")]
		public const int TRAILER_SHA512_256 = 16588;

		// Token: 0x04000CC0 RID: 3264
		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary trailerMap;
	}
}
