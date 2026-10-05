using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public class SDKPromiseWithResult<Param> : SDKPromise<Param> where Param : class
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000264 RID: 612 RVA: 0x000020C6 File Offset: 0x000002C6
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700003E")]
		public Param result
		{
			[Token(Token = "0x6000264")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000265")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000266 RID: 614 RVA: 0x000020C6 File Offset: 0x000002C6
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700003F")]
		public object rejectInfo
		{
			[Token(Token = "0x6000266")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000267")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000268")]
		public override void Fulfill(object param)
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000269")]
		public override void Reject(object reason)
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600026A")]
		public SDKPromiseWithResult()
		{
		}
	}
}
