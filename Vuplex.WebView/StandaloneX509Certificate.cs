using System;
using Il2CppDummyDll;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	public class StandaloneX509Certificate
	{
		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x5BC49A0", Offset = "0x5BC35A0", VA = "0x185BC49A0")]
		internal StandaloneX509Certificate(MessageCertificate cert)
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x5BC4750", Offset = "0x5BC3350", VA = "0x185BC4750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x10")]
		public readonly int ID;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x18")]
		public readonly StandaloneX509CertificatePrincipal Issuer;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x20")]
		public readonly StandaloneX509CertificatePrincipal Subject;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x28")]
		public readonly DateTime ValidStart;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x30")]
		public readonly DateTime ValidExpiry;
	}
}
