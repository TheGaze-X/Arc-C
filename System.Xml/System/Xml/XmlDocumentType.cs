using System;
using System.Xml.Schema;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	public class XmlDocumentType : XmlLinkedNode
	{
		// Token: 0x06000521 RID: 1313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x4FCA870", Offset = "0x4FC9470", VA = "0x184FCA870")]
		protected internal XmlDocumentType(string name, string publicId, string systemId, string internalSubset, XmlDocument doc)
		{
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012C")]
		public override string Name
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012D")]
		public override string LocalName
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x1700012E")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x2114980", Offset = "0x2113580", VA = "0x182114980", Slot = "9")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x4FCA7B0", Offset = "0x4FC93B0", VA = "0x184FCA7B0", Slot = "27")]
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x1700012F")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000130")]
		public XmlNamedNodeMap Entities
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x4FCAA50", Offset = "0x4FC9650", VA = "0x184FCAA50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000131")]
		public XmlNamedNodeMap Notations
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x4FCAAE0", Offset = "0x4FC96E0", VA = "0x184FCAAE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000132")]
		public string PublicId
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000133")]
		public string SystemId
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000134")]
		public string InternalSubset
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x17000135")]
		internal bool ParseWithNamespaces
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000136")]
		internal SchemaInfo DtdSchemaInfo
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			set
			{
			}
		}

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x20")]
		private string name;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x28")]
		private string publicId;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x30")]
		private string systemId;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x38")]
		private string internalSubset;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x40")]
		private bool namespaces;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x48")]
		private XmlNamedNodeMap entities;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x50")]
		private XmlNamedNodeMap notations;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x58")]
		private SchemaInfo schemaInfo;
	}
}
