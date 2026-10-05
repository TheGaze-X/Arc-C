using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	public class Singleton<T> : IHotfixable where T : class
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000024")]
		public static T instance
		{
			[Token(Token = "0x600018C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x17000025")]
		public static bool hasInstance
		{
			[Token(Token = "0x600018D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600018E")]
		public static void Reset()
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600018F")]
		private static void _CreateInstance()
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000190")]
		protected Singleton()
		{
		}

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x0")]
		private static T s_instance;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate8 __Hotfix0_get_hasInstance;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate14 __Hotfix0_Reset;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate14 __Hotfix0__CreateInstance;
	}
}
