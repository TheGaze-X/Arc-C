using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	public class SDKPromise<Param> : ISDKPromise
	{
		// Token: 0x06000261 RID: 609 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000261")]
		public virtual void Fulfill(object param)
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000262")]
		public virtual void Reject(object reason)
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000263")]
		public SDKPromise()
		{
		}

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x0")]
		public Action<Param> onFulfilled;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x0")]
		public Action<object> onRejected;
	}
}
