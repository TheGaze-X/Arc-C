using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	public class FastActionDetector : Singleton<FastActionDetector>
	{
		// Token: 0x06000464 RID: 1124 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x54FD2F0", Offset = "0x54FBEF0", VA = "0x1854FD2F0")]
		private FastActionDetector()
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0000539C File Offset: 0x0000359C
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x54FD1E0", Offset = "0x54FBDE0", VA = "0x1854FD1E0")]
		public static bool IsFastAction(float fastthershold = 0.25f)
		{
			return default(bool);
		}

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x10")]
		private double m_latestInvoke;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		public const float FAST_THRESHOLD = 0.25f;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate55 __Hotfix0_IsFastAction;
	}
}
