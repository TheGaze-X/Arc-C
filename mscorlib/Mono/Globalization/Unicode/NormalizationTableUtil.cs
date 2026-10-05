using System;
using Il2CppDummyDll;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	internal class NormalizationTableUtil
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x4AB02F0", Offset = "0x4AAEEF0", VA = "0x184AB02F0")]
		public static int PropIdx(int cp)
		{
			return 0;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x4AB0280", Offset = "0x4AAEE80", VA = "0x184AB0280")]
		public static int MapIdx(int cp)
		{
			return 0;
		}

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CodePointIndexer Prop;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x8")]
		public static readonly CodePointIndexer Map;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x10")]
		public static readonly CodePointIndexer Combining;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x18")]
		public static readonly CodePointIndexer Composite;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x20")]
		public static readonly CodePointIndexer Helper;
	}
}
