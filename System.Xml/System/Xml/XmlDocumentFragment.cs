using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	public class XmlDocumentFragment : XmlNode
	{
		// Token: 0x06000514 RID: 1300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x4FCA560", Offset = "0x4FC9160", VA = "0x184FCA560")]
		protected internal XmlDocumentFragment(XmlDocument ownerDocument)
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000124")]
		public override string Name
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x4FCA600", Offset = "0x4FC9200", VA = "0x184FCA600", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000125")]
		public override string LocalName
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x4FCA600", Offset = "0x4FC9200", VA = "0x184FCA600", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x17000126")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x2110790", Offset = "0x210F390", VA = "0x182110790", Slot = "9")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000127")]
		public override XmlNode ParentNode
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000128")]
		public override XmlDocument OwnerDocument
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x4FCA650", Offset = "0x4FC9250", VA = "0x184FCA650", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000129 RID: 297
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000129")]
		public override string InnerXml
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x4FCA700", Offset = "0x4FC9300", VA = "0x184FCA700", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x4FCA400", Offset = "0x4FC9000", VA = "0x184FCA400", Slot = "27")]
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x1700012A")]
		internal override bool IsContainer
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012B")]
		internal override XmlLinkedNode LastNode
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x4FCA4C0", Offset = "0x4FC90C0", VA = "0x184FCA4C0", Slot = "24")]
		internal override bool IsValidChildType(XmlNodeType type)
		{
			return default(bool);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x4FCA340", Offset = "0x4FC8F40", VA = "0x184FCA340", Slot = "25")]
		internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			return default(bool);
		}

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x18")]
		private XmlLinkedNode lastChild;
	}
}
