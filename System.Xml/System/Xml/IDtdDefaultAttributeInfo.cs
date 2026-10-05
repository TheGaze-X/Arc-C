using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600007E RID: 126
		[Token(Token = "0x17000011")]
		string DefaultValueExpanded { [Token(Token = "0x600007E")] get; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007F RID: 127
		[Token(Token = "0x17000012")]
		object DefaultValueTyped { [Token(Token = "0x600007F")] get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000080 RID: 128
		[Token(Token = "0x17000013")]
		int ValueLineNumber { [Token(Token = "0x6000080")] get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000081 RID: 129
		[Token(Token = "0x17000014")]
		int ValueLinePosition { [Token(Token = "0x6000081")] get; }
	}
}
