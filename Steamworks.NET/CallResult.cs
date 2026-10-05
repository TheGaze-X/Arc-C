using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000184 RID: 388
	[Token(Token = "0x2000184")]
	public abstract class CallResult
	{
		// Token: 0x060008D7 RID: 2263
		[Token(Token = "0x60008D7")]
		internal abstract Type GetCallbackType();

		// Token: 0x060008D8 RID: 2264
		[Token(Token = "0x60008D8")]
		internal abstract void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall);

		// Token: 0x060008D9 RID: 2265
		[Token(Token = "0x60008D9")]
		internal abstract void SetUnregistered();

		// Token: 0x060008DA RID: 2266 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected CallResult()
		{
		}
	}
}
