using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	public struct TimeTransiting : IHotfixable
	{
		// Token: 0x06000508 RID: 1288 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x5511F50", Offset = "0x5510B50", VA = "0x185511F50")]
		public TimeTransiting(float transition)
		{
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00005894 File Offset: 0x00003A94
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x5511EA0", Offset = "0x5510AA0", VA = "0x185511EA0")]
		public bool Check()
		{
			return default(bool);
		}

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x0")]
		private ScaledStopwatch m_stopwatch;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x10")]
		private float m_transition;

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x14")]
		private bool m_notEmpty;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate83 _c__Hotfix0_ctor;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate84 __Hotfix0_Check;
	}
}
