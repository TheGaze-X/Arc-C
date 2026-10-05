using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	public abstract class XmlSchemaGroupBase : XmlSchemaParticle
	{
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000AE7 RID: 2791
		[Token(Token = "0x17000320")]
		[XmlIgnore]
		public abstract XmlSchemaObjectCollection Items { [Token(Token = "0x6000AE7")] get; }

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x5020860", Offset = "0x501F460", VA = "0x185020860")]
		protected XmlSchemaGroupBase()
		{
		}
	}
}
