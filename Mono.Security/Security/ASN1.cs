using System;
using System.Collections;
using Il2CppDummyDll;

namespace Mono.Security
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public class ASN1
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x4A760E0", Offset = "0x4A74CE0", VA = "0x184A760E0")]
		public ASN1(byte tag)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x4A76120", Offset = "0x4A74D20", VA = "0x184A76120")]
		public ASN1(byte tag, byte[] data)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x4A75F50", Offset = "0x4A74B50", VA = "0x184A75F50")]
		public ASN1(byte[] data)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x17000001")]
		public int Count
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x4A76160", Offset = "0x4A74D60", VA = "0x184A76160")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x17000002")]
		public byte Tag
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x17000003")]
		public int Length
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x4A762E0", Offset = "0x4A74EE0", VA = "0x184A762E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000004")]
		public byte[] Value
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x4A762F0", Offset = "0x4A74EF0", VA = "0x184A762F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x4A763A0", Offset = "0x4A74FA0", VA = "0x184A763A0")]
			set
			{
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4A75030", Offset = "0x4A73C30", VA = "0x184A75030")]
		private bool CompareArray(byte[] array1, byte[] array2)
		{
			return default(bool);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4A750B0", Offset = "0x4A73CB0", VA = "0x184A750B0")]
		public bool CompareValue(byte[] value)
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x4A74F70", Offset = "0x4A73B70", VA = "0x184A74F70")]
		public ASN1 Add(ASN1 asn1)
		{
			return null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x4A75580", Offset = "0x4A74180", VA = "0x184A75580", Slot = "4")]
		public virtual byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x4A75250", Offset = "0x4A73E50", VA = "0x184A75250")]
		protected void Decode(byte[] asn1, ref int anPos, int anLength)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x4A75130", Offset = "0x4A73D30", VA = "0x184A75130")]
		protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content)
		{
		}

		// Token: 0x17000005 RID: 5
		[Token(Token = "0x17000005")]
		public ASN1 this[int index]
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x4A761B0", Offset = "0x4A74DB0", VA = "0x184A761B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x4A75430", Offset = "0x4A74030", VA = "0x184A75430")]
		public ASN1 Element(int index, byte anTag)
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x4A75CE0", Offset = "0x4A748E0", VA = "0x184A75CE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private byte m_nTag;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_aValue;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		private ArrayList elist;
	}
}
