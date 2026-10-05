using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x02000284 RID: 644
	[Token(Token = "0x2000284")]
	public interface IValueTaskSource<out TResult>
	{
		// Token: 0x06001523 RID: 5411
		[Token(Token = "0x6001523")]
		ValueTaskSourceStatus GetStatus(short token);

		// Token: 0x06001524 RID: 5412
		[Token(Token = "0x6001524")]
		void OnCompleted(System.Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

		// Token: 0x06001525 RID: 5413
		[Token(Token = "0x6001525")]
		TResult GetResult(short token);
	}
}
