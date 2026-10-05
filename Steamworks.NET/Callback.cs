using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	public abstract class Callback
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060008C1 RID: 2241
		[Token(Token = "0x17000022")]
		public abstract bool IsGameServer { [Token(Token = "0x60008C1")] get; }

		// Token: 0x060008C2 RID: 2242
		[Token(Token = "0x60008C2")]
		internal abstract Type GetCallbackType();

		// Token: 0x060008C3 RID: 2243
		[Token(Token = "0x60008C3")]
		internal abstract void OnRunCallback(IntPtr pvParam);

		// Token: 0x060008C4 RID: 2244
		[Token(Token = "0x60008C4")]
		internal abstract void SetUnregistered();

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Callback()
		{
		}
	}
}
