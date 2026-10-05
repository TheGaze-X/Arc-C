using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000157 RID: 343
	[Token(Token = "0x2000157")]
	public class XmlSchemaType : XmlSchemaAnnotated
	{
		// Token: 0x06000B11 RID: 2833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x5021860", Offset = "0x5020460", VA = "0x185021860")]
		public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode)
		{
			return null;
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700032F")]
		[XmlIgnore]
		public XmlQualifiedName QualifiedName
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x4C2EF70", Offset = "0x4C2DB70", VA = "0x184C2EF70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000330")]
		[XmlIgnore]
		public XmlSchemaType BaseXmlSchemaType
		{
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000331")]
		[XmlIgnore]
		public XmlSchemaDatatype Datatype
		{
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000332 RID: 818
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000332")]
		[XmlIgnore]
		public virtual bool IsMixed
		{
			[Token(Token = "0x6000B15")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x000059D0 File Offset: 0x00003BD0
		[Token(Token = "0x17000333")]
		[XmlIgnore]
		public XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x5021970", Offset = "0x5020570", VA = "0x185021970")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000334")]
		[XmlIgnore]
		internal XmlValueConverter ValueConverter
		{
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x5021A40", Offset = "0x5020640", VA = "0x185021A40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x50218B0", Offset = "0x50204B0", VA = "0x1850218B0")]
		internal void SetQualifiedName(XmlQualifiedName value)
		{
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
		internal void SetBaseSchemaType(XmlSchemaType value)
		{
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
		internal void SetDerivedBy(XmlSchemaDerivationMethod value)
		{
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
		internal void SetDatatype(XmlSchemaDatatype value)
		{
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000335")]
		internal SchemaElementDecl ElementDecl
		{
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x43FBA90", Offset = "0x43FA690", VA = "0x1843FBA90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x5021AD0", Offset = "0x50206D0", VA = "0x185021AD0")]
			set
			{
			}
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x927040", Offset = "0x925C40", VA = "0x180927040")]
		internal void SetContentType(XmlSchemaContentType value)
		{
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x50218E0", Offset = "0x50204E0", VA = "0x1850218E0")]
		public XmlSchemaType()
		{
		}

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x10")]
		private XmlSchemaDerivationMethod final;

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x14")]
		private XmlSchemaDerivationMethod derivedBy;

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x18")]
		private XmlSchemaType baseSchemaType;

		// Token: 0x040005BE RID: 1470
		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0x20")]
		private XmlSchemaDatatype datatype;

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x28")]
		private SchemaElementDecl elementDecl;

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x30")]
		private XmlQualifiedName qname;

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0x38")]
		private XmlSchemaContentType contentType;
	}
}
