using System;
using System.Diagnostics;
using System.Xml.Schema;
using Il2CppDummyDll;

namespace System.Xml.XPath
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x4FEC330", Offset = "0x4FEAF30", VA = "0x184FEC330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DD")]
		public override XmlSchemaType XmlType
		{
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x4FED560", Offset = "0x4FEC160", VA = "0x184FED560", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DE")]
		public override object TypedValue
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x4FEC7B0", Offset = "0x4FEB3B0", VA = "0x184FEC7B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DF")]
		public override Type ValueType
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x4FED460", Offset = "0x4FEC060", VA = "0x184FED460", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x170001E0")]
		public override bool ValueAsBoolean
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x4FEC990", Offset = "0x4FEB590", VA = "0x184FEC990", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x170001E1")]
		public override DateTime ValueAsDateTime
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x4FECBC0", Offset = "0x4FEB7C0", VA = "0x184FECBC0", Slot = "9")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x170001E2")]
		public override double ValueAsDouble
		{
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x4FECDF0", Offset = "0x4FEB9F0", VA = "0x184FECDF0", Slot = "10")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x170001E3")]
		public override int ValueAsInt
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x4FED020", Offset = "0x4FEBC20", VA = "0x184FED020", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x170001E4")]
		public override long ValueAsLong
		{
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x4FED230", Offset = "0x4FEBE30", VA = "0x184FED230", Slot = "12")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x4FEC370", Offset = "0x4FEAF70", VA = "0x184FEC370", Slot = "14")]
		public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x4FEC2F0", Offset = "0x4FEAEF0", VA = "0x184FEC2F0", Slot = "15")]
		private object Clone()
		{
			return null;
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060007DE RID: 2014
		[Token(Token = "0x170001E5")]
		public abstract XmlNameTable NameTable { [Token(Token = "0x60007DE")] get; }

		// Token: 0x060007DF RID: 2015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x4FEBD40", Offset = "0x4FEA940", VA = "0x184FEBD40", Slot = "19")]
		public virtual string LookupNamespace(string prefix)
		{
			return null;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x4FEBF40", Offset = "0x4FEAB40", VA = "0x184FEBF40", Slot = "20")]
		public virtual string LookupPrefix(string namespaceURI)
		{
			return null;
		}

		// Token: 0x060007E1 RID: 2017
		[Token(Token = "0x60007E1")]
		public abstract XPathNavigator Clone();

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060007E2 RID: 2018
		[Token(Token = "0x170001E6")]
		public abstract XPathNodeType NodeType { [Token(Token = "0x60007E2")] get; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060007E3 RID: 2019
		[Token(Token = "0x170001E7")]
		public abstract string LocalName { [Token(Token = "0x60007E3")] get; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060007E4 RID: 2020
		[Token(Token = "0x170001E8")]
		public abstract string NamespaceURI { [Token(Token = "0x60007E4")] get; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060007E5 RID: 2021
		[Token(Token = "0x170001E9")]
		public abstract string Prefix { [Token(Token = "0x60007E5")] get; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EA")]
		public virtual object UnderlyingObject
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x4FEC200", Offset = "0x4FEAE00", VA = "0x184FEC200", Slot = "27")]
		public virtual bool MoveToNamespace(string name)
		{
			return default(bool);
		}

		// Token: 0x060007E8 RID: 2024
		[Token(Token = "0x60007E8")]
		public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

		// Token: 0x060007E9 RID: 2025
		[Token(Token = "0x60007E9")]
		public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

		// Token: 0x060007EA RID: 2026
		[Token(Token = "0x60007EA")]
		public abstract bool MoveToParent();

		// Token: 0x060007EB RID: 2027
		[Token(Token = "0x60007EB")]
		public abstract bool IsSamePosition(XPathNavigator other);

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EB")]
		public virtual IXmlSchemaInfo SchemaInfo
		{
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x4FEC770", Offset = "0x4FEB370", VA = "0x184FEC770", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x4FEBD30", Offset = "0x4FEA930", VA = "0x184FEBD30")]
		internal static bool IsText(XPathNodeType type)
		{
			return default(bool);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected XPathNavigator()
		{
		}

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly XPathNavigatorKeyComparer comparer;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly char[] NodeTypeLetter;

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly char[] UniqueIdTbl;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly int[] ContentKindMasks;
	}
}
