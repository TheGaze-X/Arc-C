using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	public interface ISite : IServiceProvider
	{
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600090C RID: 2316
		[Token(Token = "0x170001C3")]
		IComponent Component { [Token(Token = "0x600090C")] get; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600090D RID: 2317
		[Token(Token = "0x170001C4")]
		IContainer Container { [Token(Token = "0x600090D")] get; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600090E RID: 2318
		[Token(Token = "0x170001C5")]
		bool DesignMode { [Token(Token = "0x600090E")] get; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600090F RID: 2319
		// (set) Token: 0x06000910 RID: 2320
		[Token(Token = "0x170001C6")]
		string Name { [Token(Token = "0x600090F")] get; [Token(Token = "0x6000910")] set; }
	}
}
