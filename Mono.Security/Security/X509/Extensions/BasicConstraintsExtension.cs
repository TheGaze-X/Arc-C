using System;
using Il2CppDummyDll;

namespace Mono.Security.X509.Extensions
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public class BasicConstraintsExtension : X509Extension
	{
		// Token: 0x06000103 RID: 259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x4A76E00", Offset = "0x4A75A00", VA = "0x184A76E00")]
		public BasicConstraintsExtension(X509Extension extension)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x4A76E90", Offset = "0x4A75A90", VA = "0x184A76E90", Slot = "4")]
		protected override void Decode()
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x4A76FE0", Offset = "0x4A75BE0", VA = "0x184A76FE0", Slot = "5")]
		protected override void Encode()
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x1700004E")]
		public bool CertificateAuthority
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x4A77170", Offset = "0x4A75D70", VA = "0x184A77170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x28")]
		private bool cA;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x2C")]
		private int pathLenConstraint;
	}
}
