using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200779C RID: 30620
	[Token(Token = "0x200779C")]
	public class Act1VHalfIdleDepotBuffStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602AFE9 RID: 176105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFE9")]
		[Address(RVA = "0x26C8E30", Offset = "0x26C7A30", VA = "0x1826C8E30")]
		public Act1VHalfIdleDepotBuffStateBean()
		{
		}

		// Token: 0x0403E0EC RID: 254188
		[Token(Token = "0x403E0EC")]
		[FieldOffset(Offset = "0x10")]
		public Act1VHalfIdleDepotBuffProp prop;

		// Token: 0x0403E0ED RID: 254189
		[Token(Token = "0x403E0ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
