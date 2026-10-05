using System;
using System.Xml.Schema;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	internal class XmlName : IXmlSchemaInfo
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x4FD2E10", Offset = "0x4FD1A10", VA = "0x184FD2E10")]
		public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo)
		{
			return null;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x4FD2FB0", Offset = "0x4FD1BB0", VA = "0x184FD2FB0")]
		internal XmlName(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next)
		{
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015D")]
		public string LocalName
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015E")]
		public string NamespaceURI
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015F")]
		public string Prefix
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x17000160")]
		public int HashCode
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000161")]
		public XmlDocument OwnerDocument
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000162")]
		public string Name
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x4FD3060", Offset = "0x4FD1C60", VA = "0x184FD3060")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x17000163")]
		public virtual XmlSchemaValidity Validity
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "11")]
			get
			{
				return XmlSchemaValidity.NotKnown;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x17000164")]
		public virtual bool IsDefault
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x17000165")]
		public virtual bool IsNil
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000166")]
		public virtual XmlSchemaSimpleType MemberType
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000167")]
		public virtual XmlSchemaType SchemaType
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000168")]
		public virtual XmlSchemaElement SchemaElement
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000169")]
		public virtual XmlSchemaAttribute SchemaAttribute
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x167C240", Offset = "0x167AE40", VA = "0x18167C240", Slot = "18")]
		public virtual bool Equals(IXmlSchemaInfo schemaInfo)
		{
			return default(bool);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x4FD2F40", Offset = "0x4FD1B40", VA = "0x184FD2F40")]
		public static int GetHashCode(string name)
		{
			return 0;
		}

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x10")]
		private string prefix;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x18")]
		private string localName;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x20")]
		private string ns;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x28")]
		private string name;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x30")]
		private int hashCode;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x38")]
		internal XmlDocument ownerDoc;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x40")]
		internal XmlName next;
	}
}
