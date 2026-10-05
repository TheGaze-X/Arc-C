using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	public class XmlSchemaComplexType : XmlSchemaType
	{
		// Token: 0x06000AC4 RID: 2756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x501E800", Offset = "0x501D400", VA = "0x18501E800")]
		private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents)
		{
			return null;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x501F3C0", Offset = "0x501DFC0", VA = "0x18501F3C0")]
		public XmlSchemaComplexType()
		{
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000312")]
		[XmlIgnore]
		internal static XmlSchemaComplexType AnyType
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x501F520", Offset = "0x501E120", VA = "0x18501F520")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000313")]
		internal static ContentValidator AnyTypeContentValidator
		{
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x501F4A0", Offset = "0x501E0A0", VA = "0x18501F4A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000314 RID: 788
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000314")]
		[XmlAttribute("mixed")]
		[DefaultValue(false)]
		public override bool IsMixed
		{
			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x501F570", Offset = "0x501E170", VA = "0x18501F570", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000315")]
		[XmlIgnore]
		public XmlSchemaParticle ContentTypeParticle
		{
			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
		internal void SetContentTypeParticle(XmlSchemaParticle value)
		{
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
		internal void SetAttributeWildcard(XmlSchemaAnyAttribute value)
		{
		}

		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0x40")]
		private XmlSchemaDerivationMethod block;

		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0x48")]
		private XmlSchemaParticle contentTypeParticle;

		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x50")]
		private XmlSchemaAnyAttribute attributeWildcard;

		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x0")]
		private static XmlSchemaComplexType anyTypeLax;

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x8")]
		private static XmlSchemaComplexType anyTypeSkip;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x10")]
		private static XmlSchemaComplexType untypedAnyType;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x58")]
		private byte pvFlags;
	}
}
