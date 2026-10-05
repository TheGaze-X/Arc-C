using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	internal class XsdSimpleValue
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000208")]
		public XmlSchemaSimpleType XmlType
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000209")]
		public object TypedValue
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x10")]
		private XmlSchemaSimpleType xmlType;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x18")]
		private object typedValue;
	}
}
