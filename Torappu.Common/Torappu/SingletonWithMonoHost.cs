using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	public abstract class SingletonWithMonoHost<TSingleton, THost> : IHotfixable where TSingleton : class where THost : SingletonMonoBehaviour<THost>, ISingletonMonoHost
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002F")]
		public static TSingleton instanceOrNull
		{
			[Token(Token = "0x60001C2")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C3")]
		private static TSingleton _CreateInstance()
		{
			return null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001C4")]
		protected SingletonWithMonoHost()
		{
		}
	}
}
