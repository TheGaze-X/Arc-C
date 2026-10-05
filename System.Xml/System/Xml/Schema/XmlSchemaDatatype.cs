using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public abstract class XmlSchemaDatatype
	{
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000ACC RID: 2764
		[Token(Token = "0x17000316")]
		public abstract Type ValueType { [Token(Token = "0x6000ACC")] get; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000ACD RID: 2765
		[Token(Token = "0x17000317")]
		public abstract XmlTokenizedType TokenizedType { [Token(Token = "0x6000ACD")] get; }

		// Token: 0x06000ACE RID: 2766
		[Token(Token = "0x6000ACE")]
		public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00005940 File Offset: 0x00003B40
		[Token(Token = "0x17000318")]
		public virtual XmlSchemaDatatypeVariety Variety
		{
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
			get
			{
				return XmlSchemaDatatypeVariety.Atomic;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x17000319")]
		public virtual XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000AD1 RID: 2769
		[Token(Token = "0x1700031A")]
		internal abstract XmlValueConverter ValueConverter { [Token(Token = "0x6000AD1")] get; }

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000AD2 RID: 2770
		[Token(Token = "0x1700031B")]
		internal abstract RestrictionFacets Restriction { [Token(Token = "0x6000AD2")] get; }

		// Token: 0x06000AD3 RID: 2771
		[Token(Token = "0x6000AD3")]
		internal abstract int Compare(object value1, object value2);

		// Token: 0x06000AD4 RID: 2772
		[Token(Token = "0x6000AD4")]
		internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000AD5 RID: 2773
		[Token(Token = "0x1700031C")]
		internal abstract FacetsChecker FacetsChecker { [Token(Token = "0x6000AD5")] get; }

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000AD6 RID: 2774
		[Token(Token = "0x1700031D")]
		internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { [Token(Token = "0x6000AD6")] get; }

		// Token: 0x06000AD7 RID: 2775
		[Token(Token = "0x6000AD7")]
		internal abstract bool IsEqual(object o1, object o2);

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031E")]
		internal string TypeCodeString
		{
			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x501FB80", Offset = "0x501E780", VA = "0x18501FB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x501F5F0", Offset = "0x501E1F0", VA = "0x18501F5F0")]
		internal string TypeCodeToString(XmlTypeCode typeCode)
		{
			return null;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x501F5A0", Offset = "0x501E1A0", VA = "0x18501F5A0")]
		internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token)
		{
			return null;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected XmlSchemaDatatype()
		{
		}
	}
}
