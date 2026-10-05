using System;
using Il2CppDummyDll;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	public class StandaloneX509CertificatePrincipal
	{
		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x5BC46D0", Offset = "0x5BC32D0", VA = "0x185BC46D0")]
		internal StandaloneX509CertificatePrincipal(MessageCertificatePrincipal principal)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x5BC4300", Offset = "0x5BC2F00", VA = "0x185BC4300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x10")]
		public readonly string DisplayName;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x18")]
		public readonly string CommonName;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x20")]
		public readonly string LocalityName;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x28")]
		public readonly string StateOrProvinceName;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x30")]
		public readonly string CountryName;
	}
}
