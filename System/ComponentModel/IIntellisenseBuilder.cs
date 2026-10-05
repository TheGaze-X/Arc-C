using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001AA RID: 426
	[Token(Token = "0x20001AA")]
	public interface IIntellisenseBuilder
	{
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000B0A RID: 2826
		[Token(Token = "0x17000236")]
		string Name { [Token(Token = "0x6000B0A")] get; }

		// Token: 0x06000B0B RID: 2827
		[Token(Token = "0x6000B0B")]
		bool Show(string language, string value, ref string newValue);
	}
}
