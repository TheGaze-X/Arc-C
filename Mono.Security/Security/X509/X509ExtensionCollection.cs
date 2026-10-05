using System;
using System.Collections;
using Il2CppDummyDll;

namespace Mono.Security.X509
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public sealed class X509ExtensionCollection : CollectionBase, IEnumerable
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x4A887E0", Offset = "0x4A873E0", VA = "0x184A887E0")]
		public X509ExtensionCollection()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x4A8D990", Offset = "0x4A8C590", VA = "0x184A8D990")]
		public X509ExtensionCollection(ASN1 asn1)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x4A8D750", Offset = "0x4A8C350", VA = "0x184A8D750")]
		public int IndexOf(string oid)
		{
			return 0;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x4A88790", Offset = "0x4A87390", VA = "0x184A88790", Slot = "19")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000041 RID: 65
		[Token(Token = "0x17000041")]
		public X509Extension this[string oid]
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x4A8DB10", Offset = "0x4A8C710", VA = "0x184A8DB10")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x18")]
		private bool readOnly;
	}
}
