using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AF8 RID: 31480
	[Token(Token = "0x2007AF8")]
	public class RelicObjViewHolder : IHotfixable
	{
		// Token: 0x0602C150 RID: 180560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C150")]
		[Address(RVA = "0x2801C00", Offset = "0x2800800", VA = "0x182801C00")]
		public RelicObjViewHolder()
		{
		}

		// Token: 0x0403FE23 RID: 261667
		[Token(Token = "0x403FE23")]
		[FieldOffset(Offset = "0x10")]
		public Act12D6RelicHandBookItemView view;

		// Token: 0x0403FE24 RID: 261668
		[Token(Token = "0x403FE24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
