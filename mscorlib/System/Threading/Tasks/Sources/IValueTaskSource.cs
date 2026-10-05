using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x02000283 RID: 643
	[Token(Token = "0x2000283")]
	public interface IValueTaskSource
	{
		// Token: 0x06001520 RID: 5408
		[Token(Token = "0x6001520")]
		ValueTaskSourceStatus GetStatus(short token);

		// Token: 0x06001521 RID: 5409
		[Token(Token = "0x6001521")]
		void OnCompleted(System.Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

		// Token: 0x06001522 RID: 5410
		[Token(Token = "0x6001522")]
		void GetResult(short token);
	}
}
