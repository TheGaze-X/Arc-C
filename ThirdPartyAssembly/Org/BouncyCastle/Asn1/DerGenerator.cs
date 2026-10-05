using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003BB RID: 955
	[Token(Token = "0x20003BB")]
	public abstract class DerGenerator : Asn1Generator
	{
		// Token: 0x0600204F RID: 8271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204F")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		protected DerGenerator(Stream outStream)
		{
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002050")]
		[Address(RVA = "0x5316460", Offset = "0x5315060", VA = "0x185316460")]
		protected DerGenerator(Stream outStream, int tagNo, bool isExplicit)
		{
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002051")]
		[Address(RVA = "0x53206F0", Offset = "0x531F2F0", VA = "0x1853206F0")]
		private static void WriteLength(Stream outStr, int length)
		{
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002052")]
		[Address(RVA = "0x5320580", Offset = "0x531F180", VA = "0x185320580")]
		internal static void WriteDerEncoded(Stream outStream, int tag, byte[] bytes)
		{
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002053")]
		[Address(RVA = "0x5320430", Offset = "0x531F030", VA = "0x185320430")]
		internal void WriteDerEncoded(int tag, byte[] bytes)
		{
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002054")]
		[Address(RVA = "0x5320540", Offset = "0x531F140", VA = "0x185320540")]
		internal static void WriteDerEncoded(Stream outStr, int tag, Stream inStr)
		{
		}

		// Token: 0x04001137 RID: 4407
		[Token(Token = "0x4001137")]
		[FieldOffset(Offset = "0x18")]
		private bool _tagged;

		// Token: 0x04001138 RID: 4408
		[Token(Token = "0x4001138")]
		[FieldOffset(Offset = "0x19")]
		private bool _isExplicit;

		// Token: 0x04001139 RID: 4409
		[Token(Token = "0x4001139")]
		[FieldOffset(Offset = "0x1C")]
		private int _tagNo;
	}
}
