using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AB6 RID: 31414
	[Token(Token = "0x2007AB6")]
	public class Act12sideMissionItemHolder : IHotfixable
	{
		// Token: 0x0602C00E RID: 180238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C00E")]
		[Address(RVA = "0x27DF3A0", Offset = "0x27DDFA0", VA = "0x1827DF3A0")]
		public Act12sideMissionItemHolder()
		{
		}

		// Token: 0x0403FC20 RID: 261152
		[Token(Token = "0x403FC20")]
		[FieldOffset(Offset = "0x10")]
		public Act12sideMissionItemView itemView;

		// Token: 0x0403FC21 RID: 261153
		[Token(Token = "0x403FC21")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
