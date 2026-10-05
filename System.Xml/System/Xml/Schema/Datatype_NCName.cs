using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000104 RID: 260
	[Token(Token = "0x2000104")]
	internal class Datatype_NCName : Datatype_Name
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x17000270")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x4FFA100", Offset = "0x4FF8D00", VA = "0x184FFA100", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x4FF9F80", Offset = "0x4FF8B80", VA = "0x184FF9F80", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x4FF9F50", Offset = "0x4FF8B50", VA = "0x184FF9F50")]
		public Datatype_NCName()
		{
		}
	}
}
