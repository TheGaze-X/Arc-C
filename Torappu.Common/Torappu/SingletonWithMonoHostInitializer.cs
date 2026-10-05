using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	public static class SingletonWithMonoHostInitializer<THost> where THost : SingletonMonoBehaviour<THost>, ISingletonMonoHost
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001C5")]
		public static void BindSingletonWithMonoHost<T>() where T : SingletonWithMonoHost<T, THost>
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001C6")]
		public static void Initialize(THost host)
		{
		}

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, Action<THost>> s_initialFuncDict;
	}
}
