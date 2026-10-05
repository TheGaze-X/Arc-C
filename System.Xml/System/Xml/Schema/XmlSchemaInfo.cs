using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	public class XmlSchemaInfo : IXmlSchemaInfo
	{
		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x50209A0", Offset = "0x501F5A0", VA = "0x1850209A0")]
		public XmlSchemaInfo()
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x5020920", Offset = "0x501F520", VA = "0x185020920")]
		internal XmlSchemaInfo(XmlSchemaValidity validity)
		{
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x17000321")]
		public XmlSchemaValidity Validity
		{
			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "4")]
			get
			{
				return XmlSchemaValidity.NotKnown;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x17000322")]
		public bool IsDefault
		{
			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x17000323")]
		public bool IsNil
		{
			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000324")]
		public XmlSchemaSimpleType MemberType
		{
			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000325")]
		public XmlSchemaType SchemaType
		{
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000326")]
		public XmlSchemaElement SchemaElement
		{
			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000327")]
		public XmlSchemaAttribute SchemaAttribute
		{
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x50208B0", Offset = "0x501F4B0", VA = "0x1850208B0")]
		internal void Clear()
		{
		}

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x10")]
		private bool isDefault;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x11")]
		private bool isNil;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x18")]
		private XmlSchemaElement schemaElement;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x20")]
		private XmlSchemaAttribute schemaAttribute;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x28")]
		private XmlSchemaType schemaType;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x30")]
		private XmlSchemaSimpleType memberType;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0x38")]
		private XmlSchemaValidity validity;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0x3C")]
		private XmlSchemaContentType contentType;
	}
}
