using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.FunLive
{
	// Token: 0x02002696 RID: 9878
	[Token(Token = "0x2002696")]
	public class FunLiveInput : IHotfixable
	{
		// Token: 0x0601022C RID: 66092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601022C")]
		[Address(RVA = "0x7E9070", Offset = "0x7E7C70", VA = "0x1807E9070")]
		public FunLiveInput()
		{
		}

		// Token: 0x04011FC4 RID: 73668
		[Token(Token = "0x4011FC4")]
		[FieldOffset(Offset = "0x10")]
		public int skillLevel;

		// Token: 0x04011FC5 RID: 73669
		[Token(Token = "0x4011FC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
