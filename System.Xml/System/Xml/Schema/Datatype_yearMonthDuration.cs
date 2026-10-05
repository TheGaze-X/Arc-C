using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	internal class Datatype_yearMonthDuration : Datatype_duration
	{
		// Token: 0x060008E5 RID: 2277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x5003520", Offset = "0x5002120", VA = "0x185003520", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x17000243")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x50037A0", Offset = "0x50023A0", VA = "0x1850037A0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x5003750", Offset = "0x5002350", VA = "0x185003750")]
		public Datatype_yearMonthDuration()
		{
		}
	}
}
