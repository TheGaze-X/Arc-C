using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	internal class Datatype_integer : Datatype_decimal
	{
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x1700027D")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x5000370", Offset = "0x4FFEF70", VA = "0x185000370", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x5000160", Offset = "0x4FFED60", VA = "0x185000160", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x5000320", Offset = "0x4FFEF20", VA = "0x185000320")]
		public Datatype_integer()
		{
		}
	}
}
