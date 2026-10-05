using System;
using System.Xml.Schema;
using Il2CppDummyDll;

namespace System.Xml.XPath
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	public abstract class XPathItem
	{
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060007C7 RID: 1991
		[Token(Token = "0x170001D4")]
		public abstract XmlSchemaType XmlType { [Token(Token = "0x60007C7")] get; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060007C8 RID: 1992
		[Token(Token = "0x170001D5")]
		public abstract string Value { [Token(Token = "0x60007C8")] get; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060007C9 RID: 1993
		[Token(Token = "0x170001D6")]
		public abstract object TypedValue { [Token(Token = "0x60007C9")] get; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060007CA RID: 1994
		[Token(Token = "0x170001D7")]
		public abstract Type ValueType { [Token(Token = "0x60007CA")] get; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060007CB RID: 1995
		[Token(Token = "0x170001D8")]
		public abstract bool ValueAsBoolean { [Token(Token = "0x60007CB")] get; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060007CC RID: 1996
		[Token(Token = "0x170001D9")]
		public abstract DateTime ValueAsDateTime { [Token(Token = "0x60007CC")] get; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060007CD RID: 1997
		[Token(Token = "0x170001DA")]
		public abstract double ValueAsDouble { [Token(Token = "0x60007CD")] get; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060007CE RID: 1998
		[Token(Token = "0x170001DB")]
		public abstract int ValueAsInt { [Token(Token = "0x60007CE")] get; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060007CF RID: 1999
		[Token(Token = "0x170001DC")]
		public abstract long ValueAsLong { [Token(Token = "0x60007CF")] get; }

		// Token: 0x060007D0 RID: 2000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x4FEB9B0", Offset = "0x4FEA5B0", VA = "0x184FEB9B0", Slot = "13")]
		public virtual object ValueAs(Type returnType)
		{
			return null;
		}

		// Token: 0x060007D1 RID: 2001
		[Token(Token = "0x60007D1")]
		public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver);

		// Token: 0x060007D2 RID: 2002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected XPathItem()
		{
		}
	}
}
