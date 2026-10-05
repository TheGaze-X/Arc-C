using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	internal class Datatype_List : Datatype_anySimpleType
	{
		// Token: 0x0600088E RID: 2190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x4FE0920", Offset = "0x4FDF520", VA = "0x184FE0920", Slot = "16")]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x4FE1330", Offset = "0x4FDFF30", VA = "0x184FE1330")]
		internal Datatype_List(DatatypeImplementation type, int minListSize)
		{
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x4FE05D0", Offset = "0x4FDF1D0", VA = "0x184FE05D0", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000217")]
		public override Type ValueType
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x4F41FF0", Offset = "0x4F40BF0", VA = "0x184F41FF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x17000218")]
		public override XmlTokenizedType TokenizedType
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x4FE1450", Offset = "0x4FE0050", VA = "0x184FE1450", Slot = "5")]
			get
			{
				return XmlTokenizedType.CDATA;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000219")]
		internal override Type ListValueType
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0x4FE1400", Offset = "0x4FE0000", VA = "0x184FE1400", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021A")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x4FE13B0", Offset = "0x4FDFFB0", VA = "0x184FE13B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x1700021B")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x4FE14A0", Offset = "0x4FE00A0", VA = "0x184FE14A0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x4FE0D60", Offset = "0x4FDF960", VA = "0x184FE0D60", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x38")]
		private DatatypeImplementation itemType;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x40")]
		private int minListSize;
	}
}
