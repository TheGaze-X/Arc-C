using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public class XmlElement : XmlLinkedNode
	{
		// Token: 0x0600052F RID: 1327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x4FCB7A0", Offset = "0x4FCA3A0", VA = "0x184FCB7A0")]
		internal XmlElement(XmlName name, bool empty, XmlDocument doc)
		{
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x4FCB740", Offset = "0x4FCA340", VA = "0x184FCB740")]
		protected internal XmlElement(string prefix, string localName, string namespaceURI, XmlDocument doc)
		{
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000137")]
		internal XmlName XmlName
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x4FCADC0", Offset = "0x4FC99C0", VA = "0x184FCADC0", Slot = "27")]
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000138")]
		public override string Name
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x4FCBB70", Offset = "0x4FCA770", VA = "0x184FCBB70", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000139")]
		public override string LocalName
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x4FCBB50", Offset = "0x4FCA750", VA = "0x184FCBB50", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013A")]
		public override string NamespaceURI
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x4FCBB90", Offset = "0x4FCA790", VA = "0x184FCBB90", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013B")]
		public override string Prefix
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x4FCBC30", Offset = "0x4FCA830", VA = "0x184FCBC30", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x1700013C")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "9")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013D")]
		public override XmlNode ParentNode
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013E")]
		public override XmlDocument OwnerDocument
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x4FCBC10", Offset = "0x4FCA810", VA = "0x184FCBC10", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x1700013F")]
		internal override bool IsContainer
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x4FCAB70", Offset = "0x4FC9770", VA = "0x184FCAB70", Slot = "23")]
		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			return null;
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00003498 File Offset: 0x00001698
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000140")]
		public bool IsEmpty
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x4FCBB30", Offset = "0x4FCA730", VA = "0x184FCBB30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x4FCBEB0", Offset = "0x4FCAAB0", VA = "0x184FCBEB0")]
			set
			{
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000141")]
		internal override XmlLinkedNode LastNode
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x4FCBB40", Offset = "0x4FCA740", VA = "0x184FCBB40", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x4FCB480", Offset = "0x4FCA080", VA = "0x184FCB480", Slot = "24")]
		internal override bool IsValidChildType(XmlNodeType type)
		{
			return default(bool);
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000142")]
		public override XmlAttributeCollection Attributes
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x4FCB990", Offset = "0x4FCA590", VA = "0x184FCB990", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x17000143")]
		public virtual bool HasAttributes
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x4FCBAD0", Offset = "0x4FCA6D0", VA = "0x184FCBAD0", Slot = "46")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x4FCB590", Offset = "0x4FCA190", VA = "0x184FCB590", Slot = "47")]
		public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr)
		{
			return null;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x4FCB4E0", Offset = "0x4FCA0E0", VA = "0x184FCB4E0", Slot = "48")]
		public virtual void RemoveAllAttributes()
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x4FCB550", Offset = "0x4FCA150", VA = "0x184FCB550", Slot = "37")]
		public override void RemoveAll()
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x4FCB540", Offset = "0x4FCA140", VA = "0x184FCB540")]
		internal void RemoveAllChildren()
		{
		}

		// Token: 0x17000144 RID: 324
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000144")]
		public override string InnerXml
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x4FCBD90", Offset = "0x4FCA990", VA = "0x184FCBD90", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000145")]
		public override string InnerText
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x4FCBB20", Offset = "0x4FCA720", VA = "0x184FCBB20", Slot = "33")]
			get
			{
				return null;
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x4FCBC50", Offset = "0x4FCA850", VA = "0x184FCBC50", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000146")]
		public override XmlNode NextSibling
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x4FCBBB0", Offset = "0x4FCA7B0", VA = "0x184FCBBB0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "39")]
		internal override void SetParent(XmlNode node)
		{
		}

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x20")]
		private XmlName name;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x28")]
		private XmlAttributeCollection attributes;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x30")]
		private XmlLinkedNode lastChild;
	}
}
