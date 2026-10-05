using System;
using Il2CppDummyDll;

namespace Mono.Security.X509.Extensions
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	public class AuthorityKeyIdentifierExtension : X509Extension
	{
		// Token: 0x060000FE RID: 254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x4A76E00", Offset = "0x4A75A00", VA = "0x184A76E00")]
		public AuthorityKeyIdentifierExtension(X509Extension extension)
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x4A76970", Offset = "0x4A75570", VA = "0x184A76970", Slot = "4")]
		protected override void Decode()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x4A76AE0", Offset = "0x4A756E0", VA = "0x184A76AE0", Slot = "5")]
		protected override void Encode()
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		public byte[] Identifier
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x4A76E10", Offset = "0x4A75A10", VA = "0x184A76E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x4A76C60", Offset = "0x4A75860", VA = "0x184A76C60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x28")]
		private byte[] aki;
	}
}
