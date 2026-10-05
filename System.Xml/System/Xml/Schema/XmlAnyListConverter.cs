using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	internal class XmlAnyListConverter : XmlListConverter
	{
		// Token: 0x06000C5B RID: 3163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x5029140", Offset = "0x5027D40", VA = "0x185029140")]
		protected XmlAnyListConverter(XmlBaseConverter atomicConverter)
		{
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x5028BF0", Offset = "0x50277F0", VA = "0x185028BF0", Slot = "61")]
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x0400062D RID: 1581
		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly XmlValueConverter ItemList;

		// Token: 0x0400062E RID: 1582
		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly XmlValueConverter AnyAtomicList;
	}
}
