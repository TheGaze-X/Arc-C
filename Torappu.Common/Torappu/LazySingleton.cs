using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	public class LazySingleton<T> : IHotfixable where T : class
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000026")]
		public static T instance
		{
			[Token(Token = "0x6000191")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000192")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000193")]
		public static void SetInstance(T inst)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000194")]
		public static void Release()
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000195")]
		public LazySingleton()
		{
		}

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate14 __Hotfix0_Release;
	}
}
