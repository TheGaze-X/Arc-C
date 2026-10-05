using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	internal interface IXmlDeclaration : IXmlNode
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000AAA RID: 2730
		[Token(Token = "0x170001ED")]
		string Version { [Token(Token = "0x6000AAA")] get; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000AAB RID: 2731
		// (set) Token: 0x06000AAC RID: 2732
		[Token(Token = "0x170001EE")]
		string Encoding { [Token(Token = "0x6000AAB")] get; [Token(Token = "0x6000AAC")] set; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000AAD RID: 2733
		// (set) Token: 0x06000AAE RID: 2734
		[Token(Token = "0x170001EF")]
		string Standalone { [Token(Token = "0x6000AAD")] get; [Token(Token = "0x6000AAE")] set; }
	}
}
