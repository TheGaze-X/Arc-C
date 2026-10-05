using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000162 RID: 354
	[Token(Token = "0x2000162")]
	public interface IContainer : IDisposable
	{
		// Token: 0x06000908 RID: 2312
		[Token(Token = "0x6000908")]
		void Add(IComponent component);

		// Token: 0x06000909 RID: 2313
		[Token(Token = "0x6000909")]
		void Add(IComponent component, string name);

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600090A RID: 2314
		[Token(Token = "0x170001C2")]
		ComponentCollection Components { [Token(Token = "0x600090A")] get; }

		// Token: 0x0600090B RID: 2315
		[Token(Token = "0x600090B")]
		void Remove(IComponent component);
	}
}
