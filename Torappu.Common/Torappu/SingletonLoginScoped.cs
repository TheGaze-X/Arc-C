using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	public class SingletonLoginScoped<T> : ScopedSingleton<T> where T : SingletonLoginScoped<T>
	{
		// Token: 0x060001A8 RID: 424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A8")]
		protected override string DefineScope()
		{
			return null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001A9")]
		public SingletonLoginScoped()
		{
		}
	}
}
