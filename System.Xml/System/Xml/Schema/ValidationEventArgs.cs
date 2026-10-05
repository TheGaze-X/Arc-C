using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000136")]
	public class ValidationEventArgs : EventArgs
	{
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x17000303")]
		public XmlSeverityType Severity
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return XmlSeverityType.Error;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000304")]
		public XmlSchemaException Exception
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x10")]
		private XmlSchemaException ex;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0x18")]
		private XmlSeverityType severity;
	}
}
