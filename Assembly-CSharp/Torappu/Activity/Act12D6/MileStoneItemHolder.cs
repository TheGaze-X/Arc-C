using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AF1 RID: 31473
	[Token(Token = "0x2007AF1")]
	public class MileStoneItemHolder : IHotfixable
	{
		// Token: 0x0602C135 RID: 180533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C135")]
		[Address(RVA = "0x28016E0", Offset = "0x28002E0", VA = "0x1828016E0")]
		public MileStoneItemHolder()
		{
		}

		// Token: 0x0403FDE7 RID: 261607
		[Token(Token = "0x403FDE7")]
		[FieldOffset(Offset = "0x10")]
		public Act12D6MileStoneItemObj item;

		// Token: 0x0403FDE8 RID: 261608
		[Token(Token = "0x403FDE8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
