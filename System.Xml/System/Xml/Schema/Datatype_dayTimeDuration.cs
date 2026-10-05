using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	internal class Datatype_dayTimeDuration : Datatype_duration
	{
		// Token: 0x060008E8 RID: 2280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x4FFD550", Offset = "0x4FFC150", VA = "0x184FFD550", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x17000244")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x4FFD7D0", Offset = "0x4FFC3D0", VA = "0x184FFD7D0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x4FFD780", Offset = "0x4FFC380", VA = "0x184FFD780")]
		public Datatype_dayTimeDuration()
		{
		}
	}
}
