using System;
using Il2CppDummyDll;

namespace BestHTTP.Extensions
{
	// Token: 0x020004E1 RID: 1249
	[Token(Token = "0x20004E1")]
	public interface IHeartbeat
	{
		// Token: 0x0600294D RID: 10573
		[Token(Token = "0x600294D")]
		void OnHeartbeatUpdate(TimeSpan dif);
	}
}
