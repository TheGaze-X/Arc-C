using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200038B RID: 907
	[Token(Token = "0x200038B")]
	public abstract class Asn1Encodable : IAsn1Convertible
	{
		// Token: 0x06001F10 RID: 7952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F10")]
		[Address(RVA = "0x530DDE0", Offset = "0x530C9E0", VA = "0x18530DDE0")]
		public byte[] GetEncoded()
		{
			return null;
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F11")]
		[Address(RVA = "0x530DED0", Offset = "0x530CAD0", VA = "0x18530DED0")]
		public byte[] GetEncoded(string encoding)
		{
			return null;
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F12")]
		[Address(RVA = "0x530DD90", Offset = "0x530C990", VA = "0x18530DD90")]
		public byte[] GetDerEncoded()
		{
			return null;
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x0000EE20 File Offset: 0x0000D020
		[Token(Token = "0x6001F13")]
		[Address(RVA = "0x530E000", Offset = "0x530CC00", VA = "0x18530E000", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x0000EE38 File Offset: 0x0000D038
		[Token(Token = "0x6001F14")]
		[Address(RVA = "0x530DCA0", Offset = "0x530C8A0", VA = "0x18530DCA0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001F15 RID: 7957
		[Token(Token = "0x6001F15")]
		public abstract Asn1Object ToAsn1Object();

		// Token: 0x06001F16 RID: 7958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F16")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Asn1Encodable()
		{
		}

		// Token: 0x040010DD RID: 4317
		[Token(Token = "0x40010DD")]
		public const string Der = "DER";

		// Token: 0x040010DE RID: 4318
		[Token(Token = "0x40010DE")]
		public const string Ber = "BER";
	}
}
