using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	[DefaultMember("Item")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XmlNode : ICloneable, IEnumerable
	{
		// Token: 0x060005C2 RID: 1474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal XmlNode()
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x4FD5F20", Offset = "0x4FD4B20", VA = "0x184FD5F20")]
		internal XmlNode(XmlDocument doc)
		{
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005C4 RID: 1476
		[Token(Token = "0x17000175")]
		public abstract string Name { [Token(Token = "0x60005C4")] get; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000176")]
		public virtual string Value
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x4FD6A50", Offset = "0x4FD5650", VA = "0x184FD6A50", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060005C7 RID: 1479
		[Token(Token = "0x17000177")]
		public abstract XmlNodeType NodeType { [Token(Token = "0x60005C7")] get; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000178")]
		public virtual XmlNode ParentNode
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x4FD66E0", Offset = "0x4FD52E0", VA = "0x184FD66E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000179")]
		public virtual XmlNodeList ChildNodes
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x4FD60E0", Offset = "0x4FD4CE0", VA = "0x184FD60E0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017A")]
		public virtual XmlNode PreviousSibling
		{
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017B")]
		public virtual XmlNode NextSibling
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017C")]
		public virtual XmlAttributeCollection Attributes
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017D")]
		public virtual XmlDocument OwnerDocument
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x4FD65B0", Offset = "0x4FD51B0", VA = "0x184FD65B0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017E")]
		public virtual XmlNode FirstChild
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x4FD6230", Offset = "0x4FD4E30", VA = "0x184FD6230", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017F")]
		public virtual XmlNode LastChild
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x4FD6530", Offset = "0x4FD5130", VA = "0x184FD6530", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x17000180")]
		internal virtual bool IsContainer
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000181")]
		internal virtual XmlLinkedNode LastNode
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x4FD4470", Offset = "0x4FD3070", VA = "0x184FD4470")]
		internal bool AncestorNode(XmlNode node)
		{
			return default(bool);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x4FD5870", Offset = "0x4FD4470", VA = "0x184FD5870", Slot = "21")]
		public virtual XmlNode RemoveChild(XmlNode oldChild)
		{
			return null;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x4FD48C0", Offset = "0x4FD34C0", VA = "0x184FD48C0", Slot = "22")]
		public virtual XmlNode AppendChild(XmlNode newChild)
		{
			return null;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x4FD4500", Offset = "0x4FD3100", VA = "0x184FD4500", Slot = "23")]
		internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			return null;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "24")]
		internal virtual bool IsValidChildType(XmlNodeType type)
		{
			return default(bool);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "25")]
		internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			return default(bool);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x17000182")]
		public virtual bool HasChildNodes
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x4FD6280", Offset = "0x4FD4E80", VA = "0x184FD6280", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005DA RID: 1498
		[Token(Token = "0x60005DA")]
		public abstract XmlNode CloneNode(bool deep);

		// Token: 0x060005DB RID: 1499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x4FD4FA0", Offset = "0x4FD3BA0", VA = "0x184FD4FA0", Slot = "28")]
		internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep)
		{
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000183")]
		public virtual string NamespaceURI
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x4FD6570", Offset = "0x4FD5170", VA = "0x184FD6570", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000184")]
		public virtual string Prefix
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x4FD6820", Offset = "0x4FD5420", VA = "0x184FD6820", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060005DE RID: 1502
		[Token(Token = "0x17000185")]
		public abstract string LocalName { [Token(Token = "0x60005DE")] get; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x17000186")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x4FD6440", Offset = "0x4FD5040", VA = "0x184FD6440", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x4FD56C0", Offset = "0x4FD42C0", VA = "0x184FD56C0")]
		internal static bool HasReadOnlyParent(XmlNode n)
		{
			return default(bool);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x4FD5E80", Offset = "0x4FD4A80", VA = "0x184FD5E80", Slot = "4")]
		private object Clone()
		{
			return null;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x4FD5E20", Offset = "0x4FD4A20", VA = "0x184FD5E20", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x4FD47A0", Offset = "0x4FD33A0", VA = "0x184FD47A0")]
		private void AppendChildText(StringBuilder builder)
		{
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000187")]
		public virtual string InnerText
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x4FD62C0", Offset = "0x4FD4EC0", VA = "0x184FD62C0", Slot = "33")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x4FD6860", Offset = "0x4FD5460", VA = "0x184FD6860", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000188")]
		public virtual string InnerXml
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x4FD69E0", Offset = "0x4FD55E0", VA = "0x184FD69E0", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000189")]
		public virtual string BaseURI
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x4FD5FC0", Offset = "0x4FD4BC0", VA = "0x184FD5FC0", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x4FD57C0", Offset = "0x4FD43C0", VA = "0x184FD57C0", Slot = "37")]
		public virtual void RemoveAll()
		{
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018A")]
		internal XmlDocument Document
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x4FD6140", Offset = "0x4FD4D40", VA = "0x184FD6140")]
			get
			{
				return null;
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x4FD5660", Offset = "0x4FD4260", VA = "0x184FD5660", Slot = "38")]
		public virtual string GetPrefixOfNamespace(string namespaceURI)
		{
			return null;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x4FD5280", Offset = "0x4FD3E80", VA = "0x184FD5280")]
		internal string GetPrefixOfNamespaceStrict(string namespaceURI)
		{
			return null;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x4FD5CF0", Offset = "0x4FD48F0", VA = "0x184FD5CF0", Slot = "39")]
		internal virtual void SetParent(XmlNode node)
		{
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "40")]
		internal virtual void SetParentForLoad(XmlNode node)
		{
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x4FD5D40", Offset = "0x4FD4940", VA = "0x184FD5D40")]
		internal static void SplitName(string name, out string prefix, out string localName)
		{
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x4FD50B0", Offset = "0x4FD3CB0", VA = "0x184FD50B0", Slot = "41")]
		internal virtual XmlNode FindChild(XmlNodeType type)
		{
			return null;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x4FD5150", Offset = "0x4FD3D50", VA = "0x184FD5150", Slot = "42")]
		internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			return null;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x4FD4F20", Offset = "0x4FD3B20", VA = "0x184FD4F20", Slot = "43")]
		internal virtual void BeforeEvent(XmlNodeChangedEventArgs args)
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x4FD43F0", Offset = "0x4FD2FF0", VA = "0x184FD43F0", Slot = "44")]
		internal virtual void AfterEvent(XmlNodeChangedEventArgs args)
		{
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x1700018B")]
		internal virtual bool IsText
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x4FD5790", Offset = "0x4FD4390", VA = "0x184FD5790")]
		internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x4FD5EC0", Offset = "0x4FD4AC0", VA = "0x184FD5EC0")]
		internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
		}

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x10")]
		internal XmlNode parentNode;
	}
}
