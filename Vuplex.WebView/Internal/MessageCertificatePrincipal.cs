using System;
using Il2CppDummyDll;

namespace Vuplex.WebView.Internal
{
	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	[Serializable]
	public class MessageCertificatePrincipal
	{
		// Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MessageCertificatePrincipal()
		{
		}

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x10")]
		public string DisplayName;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x18")]
		public string CommonName;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x20")]
		public string LocalityName;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x28")]
		public string StateOrProvinceName;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x30")]
		public string CountryName;
	}
}
