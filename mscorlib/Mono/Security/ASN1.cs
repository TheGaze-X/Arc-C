using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;

namespace Mono.Security
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[System.Reflection.DefaultMember("Item")]
	internal class ASN1
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x4A760E0", Offset = "0x4A74CE0", VA = "0x184A760E0")]
		public ASN1(byte tag)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x4A76120", Offset = "0x4A74D20", VA = "0x184A76120")]
		public ASN1(byte tag, byte[] data)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x4AA8B70", Offset = "0x4AA7770", VA = "0x184AA8B70")]
		public ASN1(byte[] data)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x17000017")]
		public int Count
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x4A76160", Offset = "0x4A74D60", VA = "0x184A76160")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000018")]
		public byte[] Value
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x4AA8D00", Offset = "0x4AA7900", VA = "0x184AA8D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x4AA7DA0", Offset = "0x4AA69A0", VA = "0x184AA7DA0")]
		public ASN1 Add(ASN1 asn1)
		{
			return null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x4AA8160", Offset = "0x4AA6D60", VA = "0x184AA8160", Slot = "4")]
		public virtual byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x4AA7F80", Offset = "0x4AA6B80", VA = "0x184AA7F80")]
		protected void Decode(byte[] asn1, ref int anPos, int anLength)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x4AA7E60", Offset = "0x4AA6A60", VA = "0x184AA7E60")]
		protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x4AA8900", Offset = "0x4AA7500", VA = "0x184AA8900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x10")]
		private byte m_nTag;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_aValue;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x20")]
		private System.Collections.ArrayList elist;
	}
}
