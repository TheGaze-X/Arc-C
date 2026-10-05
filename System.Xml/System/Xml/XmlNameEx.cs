using System;
using System.Xml.Schema;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	internal sealed class XmlNameEx : XmlName
	{
		// Token: 0x060005A0 RID: 1440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x4FD2AC0", Offset = "0x4FD16C0", VA = "0x184FD2AC0")]
		internal XmlNameEx(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo)
		{
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x1700016A")]
		public override XmlSchemaValidity Validity
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x4FD2DE0", Offset = "0x4FD19E0", VA = "0x184FD2DE0", Slot = "11")]
			get
			{
				return XmlSchemaValidity.NotKnown;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x1700016B")]
		public override bool IsDefault
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x4FD2C60", Offset = "0x4FD1860", VA = "0x184FD2C60", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x1700016C")]
		public override bool IsNil
		{
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x4FD2C70", Offset = "0x4FD1870", VA = "0x184FD2C70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016D")]
		public override XmlSchemaSimpleType MemberType
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016E")]
		public override XmlSchemaType SchemaType
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016F")]
		public override XmlSchemaElement SchemaElement
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x4FD2D30", Offset = "0x4FD1930", VA = "0x184FD2D30", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000170")]
		public override XmlSchemaAttribute SchemaAttribute
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x4FD2C80", Offset = "0x4FD1880", VA = "0x184FD2C80", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x4FD2AB0", Offset = "0x4FD16B0", VA = "0x184FD2AB0")]
		public void SetValidity(XmlSchemaValidity value)
		{
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x4FD2A50", Offset = "0x4FD1650", VA = "0x184FD2A50")]
		public void SetIsDefault(bool value)
		{
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x4FD2A80", Offset = "0x4FD1680", VA = "0x184FD2A80")]
		public void SetIsNil(bool value)
		{
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x4FD28D0", Offset = "0x4FD14D0", VA = "0x184FD28D0", Slot = "18")]
		public override bool Equals(IXmlSchemaInfo schemaInfo)
		{
			return default(bool);
		}

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x48")]
		private byte flags;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x50")]
		private XmlSchemaSimpleType memberType;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x58")]
		private XmlSchemaType schemaType;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x60")]
		private object decl;
	}
}
