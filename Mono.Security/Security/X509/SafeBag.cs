using System;
using Il2CppDummyDll;

namespace Mono.Security.X509
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	internal class SafeBag
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public SafeBag(string bagOID, ASN1 asn1)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public string BagOID
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public ASN1 ASN1
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		private string _bagOID;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x18")]
		private ASN1 _asn1;
	}
}
