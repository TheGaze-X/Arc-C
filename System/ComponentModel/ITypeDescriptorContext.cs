using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x20001B0")]
	public interface ITypeDescriptorContext : IServiceProvider
	{
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000B14 RID: 2836
		[Token(Token = "0x1700023C")]
		IContainer Container { [Token(Token = "0x6000B14")] get; }

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000B15 RID: 2837
		[Token(Token = "0x1700023D")]
		object Instance { [Token(Token = "0x6000B15")] get; }

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000B16 RID: 2838
		[Token(Token = "0x1700023E")]
		PropertyDescriptor PropertyDescriptor { [Token(Token = "0x6000B16")] get; }

		// Token: 0x06000B17 RID: 2839
		[Token(Token = "0x6000B17")]
		bool OnComponentChanging();

		// Token: 0x06000B18 RID: 2840
		[Token(Token = "0x6000B18")]
		void OnComponentChanged();
	}
}
