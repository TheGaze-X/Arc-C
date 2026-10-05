using System;
using Il2CppDummyDll;

namespace System.ComponentModel.Design
{
	// Token: 0x02000235 RID: 565
	[Token(Token = "0x2000235")]
	public interface IDesignerHost : IServiceProvider
	{
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000F7C RID: 3964
		[Token(Token = "0x17000313")]
		IComponent RootComponent { [Token(Token = "0x6000F7C")] get; }

		// Token: 0x06000F7D RID: 3965
		[Token(Token = "0x6000F7D")]
		IDesigner GetDesigner(IComponent component);
	}
}
