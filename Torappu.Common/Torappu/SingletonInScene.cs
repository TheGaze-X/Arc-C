using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	public abstract class SingletonInScene<T> : IHotfixable where T : class
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x060001AB RID: 427 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000029")]
		public string sceneName
		{
			[Token(Token = "0x60001AA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002A")]
		public static T instance
		{
			[Token(Token = "0x60001AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001AD")]
		private static void _ActivateIfNot()
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001AE")]
		private static T _CreateInstance()
		{
			return null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001AF")]
		private static void _OnActiveSceneChanged(string from, string to)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001B0")]
		private static void _DisposeSelf()
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001B1")]
		protected SingletonInScene()
		{
		}

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x0")]
		private static T s_instance;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_isActivated;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x0")]
		private static string s_contextSceneName;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate14 __Hotfix0__ActivateIfNot;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate0 __Hotfix0__OnActiveSceneChanged;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate14 __Hotfix0__DisposeSelf;
	}
}
